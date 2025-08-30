// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.

using System.Security.Claims;

using Microsoft.AspNetCore.Authentication;

namespace Wangkanai.Federation.Services;

public interface IUserSession
{
	Task<string> CreateSessionIdAsync(ClaimsPrincipal principal, AuthenticationProperties properties);
	Task<ClaimsPrincipal> GetUserAsync();
	Task<string> GetSessionIdAsync();

	Task EnsureSessionIdCookieAsync();
	Task RemoveSessionIdCookieAsync();
	Task AddClientIdAsync(string clientId);

	Task<IEnumerable<string>> GetClientListAsync();
}
