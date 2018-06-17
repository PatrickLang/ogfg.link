





Steps to deploy

`draft init` if you haven't done it already

`draft up` - will deploy to default namespace, no external IP
`draft connect` - proxy to it



Not working yet - creates svc but not responding :(
`draft up -e live` - will deploy to `live` namespace, external IP




TODO

- [ ]  Windows conversion
  - [ ] `Dockerfile` created by Draft assumes sed, bash shell. Fix it
  - [ ] Try out Draft
