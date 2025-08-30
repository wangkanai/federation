﻿// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.

using System.Text;

using Microsoft.AspNetCore.Authentication;

using Wangkanai.Cryptography;

namespace Wangkanai.Federation.Extensions;

public static class AuthenticationPropertiesExtensions
{
	internal const string SessionIdKey = "session_id";
	internal const string ClientListKey = "client_list";

	public static string? GetSessionId(this AuthenticationProperties properties)
		=> properties.Items.ContainsKey(SessionIdKey)
			   ? properties.Items[SessionIdKey]
			   : null;

	public static void SetSessionId(this AuthenticationProperties properties, string sid)
		=> properties.Items[SessionIdKey] = sid;

	public static IEnumerable<string> GetClientList(this AuthenticationProperties properties)
		=> properties.Items.TryGetValue(ClientListKey, out var value)
			   ? DecodeList(value)
			   : Enumerable.Empty<string>();


	public static void SetClientList(this AuthenticationProperties properties, IEnumerable<string> clientIds)
	{
		var list = string.Join(",", clientIds);
		var bytes = Encoding.UTF8.GetBytes(list);
		var value = Base64Url.Encode(bytes);
		properties.Items[ClientListKey] = value;
	}

	public static void RemoveClientList(this AuthenticationProperties properties)
		=> properties.Items.Remove(ClientListKey);

	public static void AddClientId(this AuthenticationProperties properties, string clientId)
	{
		clientId.ThrowIfNull();

		var clients = properties.GetClientList();
		if (clients.Contains(clientId))
			return;

		var update = clients.ToList();
		update.Add(clientId);
		properties.SetClientList(update);
	}

	private static string EncodeList(IEnumerable<string> list)
	{
		if (list.IsNullOrEmpty())
			return null!;

		var value = FederationSerializer.ToString(list);
		var bytes = Encoding.UTF8.GetBytes(value);
		value = Base64Url.Encode(bytes);
		return value;
	}

	private static IEnumerable<string> DecodeList(string value)
	{
		if (value.IsNullOrWhiteSpace())
			return Enumerable.Empty<string>();

		var bytes = Base64Url.Decode(value);
		value = Encoding.UTF8.GetString(bytes);
		return FederationSerializer.FromString<string[]>(value);
	}
}
