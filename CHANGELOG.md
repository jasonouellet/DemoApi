# Changelog

All notable changes to this project will be documented in this file.

The format is based on Keep a Changelog,
and this project follows Semantic Versioning.

## [2026-06-15]

### Added

* Initial changelog file.
* CI `workflow_dispatch` support.
* CodeQL analysis integrated into the main CI workflow.
* OpenAPI manifest publish integrated into the main CI workflow.
* Basic project README with setup, run, test, Docker, and CI sections.
* Security policy content with reporting process and response expectations.
* NuGet lock files (`packages.lock.json`) for dependency tracking and reproducible builds.

### Changed

* CI workflow now centralizes build, test, security checks, and OpenAPI publish.
* CI job labels normalized in English.
* Docker image security: patched Alpine Linux base images with `apk upgrade` to fix CVEs.
* Snyk dependency scanning: now uses NuGet lock files instead of direct .csproj scanning for improved accuracy.

### Removed

* Standalone workflow for CodeQL analysis.
* Standalone workflow for OpenAPI publish.

## [2026-06-13]

### Changed

* Upgraded .NET and applied vulnerability patches (merged in PR #2).

## [2022-11-02]

### Changed

* Sonar configuration and quality scan setup updates.

## [2022-09-14]

### Changed

* Upgraded project to .NET 6.

## [2022-09-12]

### Added

* Dependabot configuration workflow and automation.

### Changed

* CI workflow renamed from `build.yml` to `CI.yml`.
* Dependabot configuration updates.

## [2021-10-18]

### Added

* Security policy file.
* Initial CodeQL workflow.

## [2021-09-20]

### Changed

* Dependency/library upgrades.
* Migrated project to .NET 5.

## [2021-09-15]

### Changed

* Build workflow updates.

## [2021-09-14]

### Added

* Initial repository scaffolding.
* API project and Dockerfile.
* Initial CI/build workflow.

### Changed

* Default branch name updated from `master` to `main`.
* Build workflow refinements and Snyk integration.
