# ASP.NET Core 3.0 Razor App

This template installs the most basic possible Razor app. It makes use of a single environment variable you can configure, named `TITLE`. This isn't required, but it gives you an example of how to configure a site when you set it up. 

The example code below presumes you have a namespace named `aspnetcore`. If you don't, use the command below to create it. 

```bash
kubectl create namespace aspnetcore
```

To install this app into your cluster, first add the Helm repository:

```bash
helm repo add aspnetcore-samples https://raw.githubusercontent.com/bradygaster/helm-charts/master/
```

Then, install the app into your cluster:

```bash
helm install aspnetcore-samples/aspnetcore-razorapp --namespace aspnetcore --set TITLE="Welcome to ASP.NET Core 3.0 on Azure Kubernetes Service\, installed via Helm"
```