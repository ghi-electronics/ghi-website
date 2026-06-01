import React from 'react';
import {useLocation} from '@docusaurus/router';
import clsx from 'clsx';

const NAV_ITEMS = [
  {label: 'TinyCLR', path: '/tinyclr/'},
  {label: 'SoC', path: '/sitcore/soc/'},
  {label: 'SoM', path: '/sitcore/som/'},
  {label: 'SBC', path: '/sitcore/sbc/'},
  {label: 'Dev', path: '/sitcore/dev/'},
  {label: 'Experiment', path: '/sitcore/experimenter-kit/'},
];

function normalize(p: string): string {
  return p.replace(/\/+$/, '');
}

export default function SitcoreNav(): React.ReactElement {
  const {pathname} = useLocation();
  const current = normalize(pathname);
  return (
    <nav className="sitcore-nav" aria-label="SITCore section">
      <div className="sitcore-nav__inner">
        {NAV_ITEMS.map((item) => {
          const isActive = current === normalize(item.path);
          return (
            <a
              key={item.path}
              href={item.path}
              className={clsx('sitcore-nav__item', isActive && 'sitcore-nav__item--active')}
              aria-current={isActive ? 'page' : undefined}
            >
              {item.label}
            </a>
          );
        })}
      </div>
    </nav>
  );
}
