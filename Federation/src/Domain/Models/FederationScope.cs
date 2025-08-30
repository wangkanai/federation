// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.

using System.Diagnostics;

using Wangkanai.Extensions;

namespace Wangkanai.Federation.Models;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public class FederationScope : FederationResource
{
	private string DebuggerDisplay => Name ?? $"{{{typeof(FederationScope)}}}";

	public bool Required { get; set; }
	public bool Emphasize { get; set; }

	public FederationScope() { }

	public FederationScope(string name)
		: this(name, name, null!) { }

	public FederationScope(string name, IEnumerable<string> claims)
		: this(name, name, claims) { }

	public FederationScope(string name, string displayName, IEnumerable<string> claims)
	{
		name.ThrowIfNullOrWhitespace();
		Name = name;
		DisplayName = displayName;

		if (claims.IsNullOrEmpty())
			return;

		foreach (var claim in claims)
			Claims.Add(claim);
	}
}
