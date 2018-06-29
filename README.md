Setup
- `draft init` if you haven't done it already
- `az acr login --name ...`
- `draft config set registry _.azurecr.io`
- Make sure the right kubernetes context is configured


Create a database on Azure

*TODO* OSBA integration with helm/draft

1. Manually create the SQL Azure DB
2. `kubectl -n live create service externalname recipedb --external-name <dbname>.database.windows.net`
service "recipedb" created
3. Verify with `kubectl get svc -n live`

```
NAME              TYPE           CLUSTER-IP    EXTERNAL-IP                   PORT(S)        AGE
recipe-csharp     LoadBalancer   10.0.177.70   13.77.176.18                  80:30483/TCP   4d
recipedb          ExternalName   <none>        ogfgdb.database.windows.net   <none>         17s
shorturl-csharp   LoadBalancer   10.0.58.153   13.66.169.180                 80:32381/TCP   12d
```

4. *TODO* Create secret
reference: https://anthonychu.ca/post/aspnet-core-appsettings-secrets-kubernetes/

Steps to deploy to test

`draft up` - will deploy to default namespace, no external IP
`draft connect` - proxy to it


Steps to deploy to live

`draft up -e live` - will deploy to `live` namespace, external IP


TODO
=======
Shorturl TODOs

- [ ] Hook up database backend, use manual inserts for now
- [ ]  Windows container conversion
  - [ ] `Dockerfile` created by Draft assumes sed, bash shell. Fix it
  - [ ] Try out Draft
- [ ] Regex validation & url generation using `abcdefghjkmnopqrstuvwxyz234679` `[a-hjkm-z234679]`
- [ ] authz/n - https://docs.microsoft.com/en-us/aspnet/core/security/authorization/secure-data?view=aspnetcore-2.1

Recipe TODOs

- [ ] summary view with qr code
- [ ] Hook up database backend for ratings
- [ ] static pages for placeholder recipes for homebrewcon
- [ ] authz/n - https://docs.microsoft.com/en-us/aspnet/core/security/authorization/secure-data?view=aspnetcore-2.1
- [ ] beerxml pretty format

Deployment TODOs

- [ ] look into external-dns https://github.com/kubernetes-incubator/external-dns/blob/master/docs/tutorials/azure.md
