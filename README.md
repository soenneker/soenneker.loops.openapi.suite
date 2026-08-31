[![](https://img.shields.io/nuget/v/soenneker.loops.openapi.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.loops.openapi.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.loops.openapi.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.loops.openapi.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.loops.openapi.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.loops.openapi.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.loops.openapi.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.loops.openapi.suite/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Loops.OpenApi.Suite

Install and register `Soenneker.Loops.Contacts` through a single Loops suite entry point.

## Install

```bash
dotnet add package Soenneker.Loops.OpenApi.Suite
```

This package currently references only `Soenneker.Loops.Contacts`. Install that package directly when a meta-package is unnecessary.

## Configure and register

```json
{ "Loops": { "ApiKey": "<API key>" } }
```

For scoped contact operations over the shared Loops client provider:

```csharp
services.AddLoopsOpenApiSuiteAsScoped();
```

For application-lifetime contact operations:

```csharp
services.AddLoopsOpenApiSuiteAsSingleton();
```

Both methods register `ILoopsContactsUtil`, which creates, updates, finds, and deletes contacts by email. See `Soenneker.Loops.Contacts` for subscription-state and deletion behavior.
