# Changelog

## Unreleased

### Changed
- Migrated projects to .NET 10 (net10.0 / net10.0-windows).
- Updated NuGet dependencies to .NET 10-compatible packages and migrated legacy projects to SDK-style format.
- Upgraded System.Security.Cryptography.Xml to 10.0.7 to resolve NU1903 security advisories.
- Updated certificate loading/signing code to use modern X509 APIs (X509CertificateLoader, GetRSAPrivateKey/GetECDsaPrivateKey) and removed Windows certificate UI selection.
- Suppressed CS8981 for legacy lower-case XML-serialization model types in NFe.Classes.
- Added SDK pinning via global.json and CI definitions targeting .NET 10 on Windows build agents.
