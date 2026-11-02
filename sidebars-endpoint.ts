import type {SidebarsConfig} from '@docusaurus/plugin-content-docs';

const sidebars: SidebarsConfig = {
  endpointSidebar: [
    'getting-started',
    'hardware',
    'configuration',
    'deployment',
    'python',
    {
      type: 'category',
      label: 'Features',
      link: {type: 'doc', id: 'features'},
      collapsed: true,
      items: [
        {
          type: 'category',
          label: 'Hardware I/O',
          collapsed: true,
          items: [
            'feature/gpio',
            'feature/pwm',
            'feature/analog-in',
            'feature/analog-out',
            'feature/signal-control',
          ],
        },
        {
          type: 'category',
          label: 'Communication Buses',
          collapsed: true,
          items: [
            'feature/spi',
            'feature/i2c',
            'feature/uart',
            'feature/usb',
            'feature/can',
          ],
        },
        {
          type: 'category',
          label: 'Networking',
          collapsed: true,
          items: [
            'feature/networking',
            'feature/bluetooth',
          ],
        },
        {
          type: 'category',
          label: 'Cloud',
          collapsed: true,
          items: [
            'feature/azure',
            'feature/aws',
          ],
        },
        {
          type: 'category',
          label: 'Storage',
          collapsed: true,
          items: [
            'feature/file-system',
            'feature/databases',
          ],
        },
        {
          type: 'category',
          label: 'Display & Multimedia',
          collapsed: true,
          items: [
            'feature/displays',
            'feature/touch-screen',
            'feature/ui',
            'feature/graphics',
            'feature/camera',
            'feature/mjpeg-video',
          ],
        },
        {
          type: 'category',
          label: 'System Services',
          collapsed: true,
          items: [
            'feature/in-field-update',
            'feature/power-management',
            'feature/watchdog-timer',
            'feature/real-time-clock',
          ],
        },
      ],
    },
    {
      type: 'category',
      label: 'API References',
      link: {type: 'doc', id: 'api/index'},
      collapsed: true,
      items: [],
    },
    {
      type: 'category',
      label: 'Downloads',
      link: {type: 'doc', id: 'downloads'},
      collapsed: true,
      items: [
        'release-notes',
      ],
    },
    'limitations',
  ],
};

export default sidebars;
