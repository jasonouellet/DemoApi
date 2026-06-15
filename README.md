# DemoApi

[![CI](https://github.com/jasonouellet/DemoApi/actions/workflows/CI.yml/badge.svg)](https://github.com/jasonouellet/DemoApi/actions/workflows/CI.yml)
[![Dependabot](https://github.com/jasonouellet/DemoApi/actions/workflows/update_dependabot.yml/badge.svg)](https://github.com/jasonouellet/DemoApi/actions/workflows/update_dependabot.yml)

Basic ASP.NET Core Web API sample targeting .NET 10.

## Features

- ASP.NET Core API project structure
- Swagger/OpenAPI generation in development
- Unit and integration tests with xUnit
- CI security and quality pipelines (CodeQL, SonarCloud, Snyk)

## Project Structure

- `src/` - API source code and Dockerfile
- `tests/` - unit and integration tests
- `docs/openapi/swagger.json` - published OpenAPI manifest
- `.github/workflows/` - CI/CD and automation workflows

## Prerequisites

- .NET SDK 10.0+
- Git
- Optional: Docker (for container run)

## Getting Started

1. Clone the repository.
2. Restore dependencies.
3. Run the API.

```bash
dotnet restore src/DemoApi.csproj
dotnet run --project src/DemoApi.csproj
```

## Development

Run tests:

```bash
dotnet test tests/DemoApi.Tests.csproj
```

Build release artifacts:

```bash
dotnet build src/DemoApi.csproj -c Release
```

## OpenAPI and Swagger

- Swagger UI is available in Development environment.
- Endpoint: `/swagger`
- Raw OpenAPI document: `/swagger/v1/swagger.json`

## Docker

Build image from `src/`:

```bash
docker build -t demoapi:local src
```

Run container:

```bash
docker run --rm -p 8080:80 demoapi:local
```

## CI/CD

- CI: build, test, quality/security checks
- CI: build, test, quality/security checks, and OpenAPI manifest publish on `main`
- CodeQL: static application security analysis
- Dependabot workflow: automates dependency PR handling

## License

Licensed under the terms in `LICENSE`.