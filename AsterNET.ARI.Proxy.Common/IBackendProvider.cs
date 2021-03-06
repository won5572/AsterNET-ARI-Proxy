﻿using System;

namespace AsterNET.ARI.Proxy.Common
{
	/// <summary>
	/// Handles communications with a backend provider, like Azure or RMQ
	/// </summary>
	public interface IBackendProvider : IDisposable
	{
		IDialogue CreateDialogue(string appName);
		void RegisterApplication(string appName);
	}
}