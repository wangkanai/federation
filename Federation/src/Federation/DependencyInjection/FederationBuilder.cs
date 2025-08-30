// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>Helper function for configuring federation services.</summary>
public sealed class FederationBuilder : IFederationBuilder
{
	/// <summary>Create a new instance of <see cref="IFederationBuilder" />.</summary>
	/// <param name="services">The <see cref="IServiceCollection" /> to attached to. </param>
	public FederationBuilder(IServiceCollection services)
		=> Services = services.ThrowIfNull();

	/// <summary>Get the <see cref="IServiceCollection" /> services are attached to.</summary>
	/// <value>The <see cref="IServiceCollection" /> services are attached to.</value>
	public IServiceCollection Services { get; }
}
