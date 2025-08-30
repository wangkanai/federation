# Wangkanai Federation

[![NuGet Version](https://img.shields.io/nuget/v/wangkanai.federation)](https://www.nuget.org/packages/wangkanai.federation)
[![NuGet Pre Release](https://img.shields.io/nuget/vpre/wangkanai.federation)](https://www.nuget.org/packages/wangkanai.federation)

[![.NET](https://github.com/wangkanai/federation/actions/workflows/ci.yml/badge.svg)](https://github.com/wangkanai/federation/actions/workflows/ci.yml)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=wangkanai_federation&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=wangkanai_federation)

[![Open Collective](https://img.shields.io/badge/open%20collective-support%20me-3385FF.svg)](https://opencollective.com/wangkanai)
[![Patreon](https://img.shields.io/badge/patreon-support%20me-d9643a.svg)](https://www.patreon.com/wangkanai)
[![GitHub](https://img.shields.io/github/license/wangkanai/federation)](https://github.com/wangkanai/federation/blob/main/LICENSE)

A comprehensive collection of ASP.NET Core libraries for identity management, authentication, authorization, and security. This repository contains three key modules: Federation, Identity, and Security.

## Modules

### 🔐 Federation: The Ultimate Authentication and Authorization Server

Your one-stop solution for robust, flexible, and secure Authentication and Authorization in ASP.NET Core. It's not just a framework, it's your trusted partner for crafting seamless OAuth 2.1 and OpenID Connect integrations.

In the interconnected world of web services, managing authentication and authorization can be daunting. But not with `Federation`. This library goes beyond the basics, offering a flexible permission policy that tailors security to your application's unique needs.

`Federation` provides comprehensive support for Json Web Tokens (JWT) and external authentication providers. It elegantly handles user authentication and consent, ensuring your users' data is secure while providing a seamless login experience.

**Planned Features:**

* General
  - Json Web Token (Jwt)
* Authentication
  - Handle user authentication/consent
  - External authentication provider
* Authorization
  - Authorization Code Grant with PKCE
  - Client Credentials Grant
  - Refresh Token Flow
* Identity Model Structure
  - Identity User
  - Identity Role
  - Identity Client
  - Identity Resource
  - Identity Scope
  - Identity Directory
  - Identity Group
  - Identity Permission
  - Identity Tenant

### 👤 Identity: OpenID Connect & OAuth 2 Models Collection

Your Go-To Collection for OpenID Connect & OAuth 2 Models in ASP.NET Core. It's not just a collection of helper models, it's your secret weapon for simplifying the complex world of authentication and authorization.

The `Identity` collection has been painstakingly curated to provide developers with the most useful and relevant models for implementing OpenID Connect and OAuth 2 protocols. Each model has been designed with flexibility and ease-of-use in mind, allowing you to focus on crafting secure, robust, and user-friendly authentication and authorization systems.

The power of `Identity` comes from its versatility. Whether you're building an enterprise-level application with intricate security requirements, or a small personal project, `Identity` can adapt to your needs.

### 🛡️ Security: Advanced ASP.NET Core Security Extensions

An innovative extension to the native ASP.NET Core Security, engineered to bring advanced, robust features to better secure your applications.

In the digital era, the safety of your applications is not just a best practice, it's a crucial necessity. With the rise of cyber threats and data breaches, it's imperative to have a security solution that's not just strong, but also adaptable and forward-thinking.

`Security` is a powerful library that enriches the native ASP.NET Core Security with additional capabilities, providing a more comprehensive and proactive security solution for your applications. Our mission is to provide a sturdy security foundation, ensuring your applications stand resilient against evolving threats.

| Package        | NuGet                                                                                                                                                |
|----------------|------------------------------------------------------------------------------------------------------------------------------------------------------|
| Authentication | [![NuGet Badge](https://img.shields.io/nuget/v/wangkanai.security.authentication)](https://www.nuget.org/packages/wangkanai.security.authentication) |
| Authorization  | [![NuGet Badge](https://img.shields.io/nuget/v/wangkanai.security.authorization)](https://www.nuget.org/packages/wangkanai.security.authorization)   |
| Core           | [![NuGet Badge](https://img.shields.io/nuget/v/wangkanai.security)](https://www.nuget.org/packages/wangkanai.security)                             |

## Installation

Install the packages you need:

```bash
dotnet add package Wangkanai.Federation
dotnet add package Wangkanai.Identity
dotnet add package Wangkanai.Security
```

## Quick Start

### Federation Setup

```csharp
builder.Services.AddFederation();
```

### Identity Setup

```csharp
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddWangkanaiIdentity();
```

### Security Setup

```csharp
builder.Services.AddSecurity();
```

## Documentation

For detailed documentation, examples, and API reference, please visit:

- **Federation**: [Documentation](docs/federation.md)
- **Identity**: [Documentation](docs/identity.md)  
- **Security**: [Documentation](docs/security.md)

## Contributing

We welcome contributions! Please feel free to:

- Report bugs or request features via [Issues](https://github.com/wangkanai/federation/issues)
- Submit pull requests for improvements
- Help improve documentation

## Support

If these libraries have made your development work easier, please consider:

- ⭐ **Star** this repository on GitHub
- 💰 **Support** us on [Open Collective](https://opencollective.com/wangkanai) or [Patreon](https://www.patreon.com/wangkanai)
- 📢 **Share** with other developers

## License

This project is licensed under the Apache-2.0 License - see the [LICENSE](LICENSE) file for details.

## Authors

- **Sarin Na Wangkanai** - *Initial work* - [@wangkanai](https://github.com/wangkanai)

---

**© 2014-2025 Sarin Na Wangkanai, All rights reserved**