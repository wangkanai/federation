﻿// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.

namespace Wangkanai.Federation.Entities;

public class IdentityTenant : IdentityTenant<Guid>
{
	public IdentityTenant()
	{
		Id = Guid.NewGuid();
	}

	public IdentityTenant(string tenantName) : this()
	{
		Name = tenantName;
	}
}

public class IdentityTenant<TKey> where TKey : IEquatable<TKey>
{
	public IdentityTenant() { }

	public IdentityTenant(string tenantName) : this()
	{
		Name = tenantName;
	}

	public virtual TKey Id { get; set; } = default!;
	public virtual string Name { get; set; }
	public virtual string NormalizedName { get; set; }
	public virtual string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

	public override string ToString()
		=> Name ?? string.Empty;
}
