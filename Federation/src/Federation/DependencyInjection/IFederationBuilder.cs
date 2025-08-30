﻿// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>Helper functions for configuring federation services.</summary>
public interface IFederationBuilder
{
	/// <summary>Get the <see cref="IServiceCollection" /> services are attached to. </summary>
	/// <value>The <see cref="IServiceCollection" /> services are attached to.</value>
	IServiceCollection Services { get; }
}
