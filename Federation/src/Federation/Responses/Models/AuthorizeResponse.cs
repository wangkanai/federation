// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.

using Wangkanai.Federation.Validations;

namespace Wangkanai.Federation.Responses;

public class AuthorizeResponse
{
	public ValidationAuthorizeRequest? Request { get; set; }

	public string RedirectUri => Request?.RedirectUri;
	public string State => Request?.State;
	public string Scope => Request?.ValidationResources?.RawScopeValues.SeparateToSpace();
	public bool IsError => Error.IsExist();

	public int AccessTokenLifetime { get; set; }
	public string IdentityToken { get; set; }
	public string AccessToken { get; set; }
	public string SessionState { get; set; }

	public string Code { get; set; }
	public string Issuer { get; set; }
	public string Error { get; set; }
	public string Description { get; set; }
}
