﻿// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.

namespace Wangkanai.Federation.Validations;

public class ValidationTokenRequest : ValidationRequest
{
	public string GrantType { get; set; }
	public string RequestedResourceIndicator { get; set; }
	public string Username { get; set; }
}
