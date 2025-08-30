﻿// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.

using Microsoft.IdentityModel.Tokens;

namespace Wangkanai.Federation.Models;

public class SecurityKeyInfo
{
	public SecurityKey Key { get; set; }
	public string SigningAlgorithm { get; set; }
}
