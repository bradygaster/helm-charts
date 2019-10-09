# .NET Core 3.0 Worker Service

This template installs the most basic possible Worker service, which makes it easy to get started building long-running processes or microservices. It makes use of a single environment variable you can configure, named `DELAY`. This isn't required, but it gives you an example of how to configure the Worker service.

The example code below presumes you have a namespace named `aspnetcore`. If you don't, use the command below to create it. 

```bash
kubectl create namespace aspnetcore
```

To install this app into your cluster, first add the Helm repository:

```bash
helm repo add aspnetcore-samples https://raw.githubusercontent.com/bradygaster/helm-charts/master/
```

Then, install the worker into your cluster:

```bash
helm install aspnetcore-samples/netcore-worker --namespace aspnetcore --set DELAY=5000
```