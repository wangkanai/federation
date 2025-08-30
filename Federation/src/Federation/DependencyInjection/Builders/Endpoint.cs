﻿// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.

using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Http;

using Wangkanai.Federation.Endpoints;
using Wangkanai.Federation.Hosting;

using static Wangkanai.Federation.Constants;

namespace Microsoft.Extensions.DependencyInjection;

public static class FederationEndpointBuilderExtensions
{
	/// <summary>
	/// Adds Federation default endpoints
	/// </summary>
	/// <param name="builder"></param>
	/// <returns></returns>
	public static IFederationBuilder AddDefaultEndpoints(this IFederationBuilder builder)
	{
		builder.Services.AddTransient<IEndpointRouter, EndpointRouter>();

		builder.AddEndpoint<DiscoveryEndpoint>(EndpointNames.Discovery, ProtocolRoutePaths.DiscoveryConfiguration.EnsureLeadingSlash());

		return builder;
	}

	public static IFederationBuilder AddEndpoint<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T>(this IFederationBuilder builder, string name, PathString path)
		where T : class, IEndpointHandler
	{
		builder.Services.AddTransient<T>();
		builder.Services.AddSingleton(new Wangkanai.Federation.Hosting.Endpoint(name, path, typeof(T)));

		return builder;
	}
}
