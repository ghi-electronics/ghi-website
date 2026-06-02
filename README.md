# Website

This website is built using [Docusaurus](https://docusaurus.io/), a modern static website generator.

## Installation

```bash
npm install
```

## Local Development

```bash
npm start
```

This command starts a local development server and opens up a browser window. Most changes are reflected live without having to restart the server.

## Build

```bash
npm run build
```

This command generates static content into the `build` directory and can be served using any static contents hosting service. Preview the production build locally with:

```bash
npm run serve
```

## TinyCLR API Reference

The TinyCLR API reference under `docs/tinyclr/api/` is **generated from the TinyCLR
library source** and **committed to this repository**. The normal `npm run build`
does **not** regenerate it — it just uses the committed pages. This keeps the build
fast and lets the automatic GitHub deploy work without needing the libraries.

You only need to regenerate the API when the TinyCLR libraries change:

1. **Get the libraries.** Check out the
   [`TinyCLR-Libraries`](https://github.com/ghi-electronics/TinyCLR-Libraries)
   repository **next to** this one, so the folders are siblings:

   ```
   <parent>\
     ghi-website\          <- this repo
     TinyCLR-Libraries\    <- the library source
   ```

   Make whatever changes you need (e.g. add/fix `/// <summary>` and `/// <param>`
   doc-comments in the `.cs` files). No compile is required — the generator reads
   the source directly.

2. **Regenerate the API pages** by running the batch script from this repo's root:

   ```bash
   build_tinyclr_api.bat
   ```

   This rewrites `docs/tinyclr/api/`. Optional arguments are passed through, e.g.
   `build_tinyclr_api.bat --only Devices.Gpio` to limit to matching packages, or
   `build_tinyclr_api.bat --libs "D:\path\to\TinyCLR-Libraries"` to point at a
   different location. (`npm run gen-api` does the same thing.)

3. **Commit the result.** Review and commit the updated `docs/tinyclr/api/` folder
   along with your other changes.

> If you are only editing pages, images, or styles — and not the API — skip this
> step entirely. Just run `npm start` to preview and commit your changes.

## Deployment

Deployment is automatic. Pushing to the `main` branch triggers the
**Deploy to GitHub Pages** GitHub Actions workflow
(`.github/workflows/deploy.yml`), which runs `npm run build` and publishes the
`build` output to GitHub Pages. No manual deploy step is needed.
