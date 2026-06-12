// Local CORS proxy for the GHI Electronics Discourse forum.
//
// Why: Discourse's JSON endpoints don't send CORS headers, so a browser running on
// localhost can't fetch them directly. In production at www.ghielectronics.com the
// requests go same-origin via the live forum, but in dev we route them through this
// proxy on port 3001.
//
// Run with:   npm run proxy
// Or alongside the dev server with:   npm run start:proxy

const express = require('express');
const { createProxyMiddleware } = require('http-proxy-middleware');

const app = express();

app.use(
  '/api/forum',
  createProxyMiddleware({
    target: 'https://forums.ghielectronics.com',
    changeOrigin: true,
    pathRewrite: { '^/api/forum': '' },
    onProxyRes(proxyRes) {
      proxyRes.headers['Access-Control-Allow-Origin'] = '*';
      proxyRes.headers['Access-Control-Allow-Methods'] = 'GET, POST, PUT, DELETE, OPTIONS';
      proxyRes.headers['Access-Control-Allow-Headers'] = 'Content-Type';
    },
  }),
);

const PORT = 3001;
app.listen(PORT, () => {
  console.log(`Forum proxy running at http://localhost:${PORT}`);
  console.log(`Example: http://localhost:${PORT}/api/forum/c/press/announcements/5/l/latest.json`);
});
