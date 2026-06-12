import React, { useState, useEffect } from 'react';
import styles from './styles.module.css';

const FORUM_HOST = 'https://forums.ghielectronics.com';

/**
 * Forum feed — pulls recent topics from a Discourse category and renders them.
 *
 * Props:
 *   categoryPath  — Discourse category path, e.g. "news/4" or "tinyclr/announcements/12".
 *                   Find this on the forum: visit the category page, the URL ends with `/c/{slug}/{id}`.
 *   title         — section heading (default: "Latest News")
 *   viewAllLabel  — label for the "View all" link at the bottom (default: derived from title)
 *   maxItems      — how many topics to show (default: 5)
 */
export default function ForumFeed({
  categoryPath,
  title = 'Latest News',
  viewAllLabel,
  maxItems = 5,
}) {
  const [topics, setTopics] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    if (!categoryPath) {
      setError('No categoryPath supplied to <ForumFeed>');
      setLoading(false);
      return;
    }

    // Use a local proxy in development to bypass CORS; hit Discourse directly in production.
    const isDevelopment = typeof window !== 'undefined' && window.location.hostname === 'localhost';
    const baseUrl = isDevelopment ? 'http://localhost:3001/api/forum' : FORUM_HOST;

    const apiUrl = `${baseUrl}/c/${categoryPath}/l/latest.json`;

    fetch(apiUrl)
      .then((response) => {
        if (!response.ok) throw new Error('Failed to fetch forum data');
        return response.json();
      })
      .then(async (data) => {
        // Skip very old topics; take the most recent N.
        const recent = (data.topic_list?.topics || []).filter((t) => {
          const lastActivity = new Date(t.last_posted_at || t.created_at);
          const createdDate = new Date(t.created_at);
          return createdDate.getFullYear() > 2017 || lastActivity.getFullYear() > 2017;
        });
        const latest = recent.slice(0, maxItems);

        // Fetch excerpts and images for topics that don't already have them.
        const enriched = await Promise.all(
          latest.map(async (topic) => {
            if (topic.excerpt) return topic;
            try {
              const r = await fetch(`${baseUrl}/t/${topic.id}.json`);
              if (!r.ok) return topic;
              const td = await r.json();
              if (td.excerpt) return { ...topic, excerpt: td.excerpt };
              const firstPost = td.post_stream?.posts?.[0];
              if (firstPost?.excerpt) return { ...topic, excerpt: firstPost.excerpt };
              if (firstPost?.cooked) {
                const tempDiv = document.createElement('div');
                tempDiv.innerHTML = firstPost.cooked;
                const img = tempDiv.querySelector('img');
                let imageUrl = null;
                if (img?.src) {
                  imageUrl = img.src;
                  if (!imageUrl.startsWith('http')) {
                    imageUrl = `${FORUM_HOST}${imageUrl.startsWith('/') ? '' : '/'}${imageUrl}`;
                  }
                }
                let plainText = tempDiv.textContent || '';
                plainText = plainText.replace(/\b\w+\d+×\d+\s+[\d.]+\s*[KMG]?B\b/gi, '');
                plainText = plainText.replace(/\b\w+\.(png|jpg|jpeg|gif|webp)\d+×\d+\s+[\d.]+\s*[KMG]?B?\b/gi, '');
                plainText = plainText.replace(/\b\d+×\d+\s+[\d.]+\s*[KMG]?B\b/g, '');
                plainText = plainText.trim().substring(0, 200);
                if (plainText.length > 20) {
                  return { ...topic, excerpt: plainText + '…', imageUrl };
                }
              }
            } catch (e) {
              console.error(`Error fetching topic ${topic.id}:`, e);
            }
            return { ...topic, excerpt: `Discussion: ${topic.title}` };
          }),
        );

        setTopics(enriched);
        setLoading(false);
      })
      .catch((err) => {
        console.error('Forum feed error:', err);
        setError(err.message);
        setLoading(false);
      });
  }, [categoryPath, maxItems]);

  const categoryUrl = `${FORUM_HOST}/c/${categoryPath}`;
  const computedViewAllLabel = viewAllLabel || `View all ${title.replace(/^Latest\s+/i, '').toLowerCase()} →`;

  if (loading) {
    return (
      <div className={styles.feedContainer}>
        <h2>{title}</h2>
        <div className={styles.loading}>Loading…</div>
      </div>
    );
  }

  if (error) {
    return (
      <div className={styles.feedContainer}>
        <h2>{title}</h2>
        <div className={styles.error}>
          Unable to load the feed.
          {typeof window !== 'undefined' && window.location.hostname === 'localhost' && (
            <div style={{ marginTop: '1rem', fontSize: '0.9rem' }}>
              For local development, run a CORS proxy on port 3001 (or test in production where the direct call works).
            </div>
          )}
        </div>
      </div>
    );
  }

  const formatDate = (dateString) => {
    const date = new Date(dateString);
    return date.toLocaleDateString('en-US', { month: 'short', day: 'numeric', year: 'numeric' });
  };

  return (
    <div className={styles.feedContainer}>
      <h2>{title}</h2>
      <div className={styles.feedList}>
        {topics.map((topic) => {
          const topicUrl = topic.featured_link || `${FORUM_HOST}/t/${topic.slug}/${topic.id}`;
          return (
            <div key={topic.id} className={styles.feedItem}>
              {topic.imageUrl && (
                <div className={styles.feedBanner}>
                  <img src={topic.imageUrl} alt={topic.title} />
                </div>
              )}
              <div className={styles.feedHeader}>
                <a
                  href={topicUrl}
                  target="_blank"
                  rel="noopener noreferrer"
                  className={styles.feedTitle}
                >
                  {topic.title}
                </a>
                <div className={styles.feedMeta}>
                  <span className={styles.date}>{formatDate(topic.last_posted_at || topic.created_at)}</span>
                  {topic.posts_count > 1 && (
                    <>
                      <span className={styles.separator}>•</span>
                      <span className={styles.replies}>
                        {topic.posts_count - 1} {topic.posts_count === 2 ? 'reply' : 'replies'}
                      </span>
                    </>
                  )}
                </div>
              </div>
              <div className={styles.feedExcerpt}>
                {topic.excerpt || `View the discussion about ${topic.title.toLowerCase()}…`}
              </div>
              <a
                href={topicUrl}
                target="_blank"
                rel="noopener noreferrer"
                className={styles.readMore}
                aria-label={`Read full post: ${topic.title}`}
              >
                Read full post →
              </a>
            </div>
          );
        })}
      </div>
      <div className={styles.viewMore}>
        <a href={categoryUrl} target="_blank" rel="noopener noreferrer" className="button button--secondary">
          {computedViewAllLabel}
        </a>
      </div>
    </div>
  );
}
