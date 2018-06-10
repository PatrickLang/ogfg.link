Setup

- `draft init` if you haven't done it already
- `draft config set registry _.azurecr.io`
- Make sure the right kubernetes context is configured


Steps to deploy to test

`draft up` - will deploy to default namespace, no external IP
`draft connect` - proxy to it


Steps to deploy to live

`draft up -e live` - will deploy to `live` namespace, external IP


TODO
=======
Shorturl TODOs

- [ ]  Windows container conversion
  - [ ] `Dockerfile` created by Draft assumes sed, bash shell. Fix it
  - [ ] Try out Draft
- [ ] Regex validation & url generation using `abcdefghjkmnopqrstuvwxyz234679` `[a-hjkm-z234679]`
