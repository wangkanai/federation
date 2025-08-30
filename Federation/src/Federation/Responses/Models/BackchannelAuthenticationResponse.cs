﻿// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.

namespace Wangkanai.Federation.Responses;

public class BackchannelAuthenticationResponse
{
	public bool IsError => Error.IsExist();
	public string Error { get; set; }
	public string Description { get; set; }
	public string AuthenticationRequestId { get; set; }
	public int ExpiresIn { get; set; }
	public int Interval { get; set; }

	public BackchannelAuthenticationResponse() { }

	public BackchannelAuthenticationResponse(string error, string description = null)
	{
		Error = error;
		Description = description;
	}
}
