using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SA.AndroidNative.Firebase
{
	public static class Analytics
	{
		private const string SEPARATOR1 = "%";

		private const string SEPARATOR2 = "|";

		public static void Init()
		{
		}

		public static void SetEnabled(bool enabled)
		{
		}

		public static void SetMinimumSessionDuration(long milliseconds)
		{
		}

		public static void SetSessionTimeoutDuration(long milliseconds)
		{
		}

		public static void SetUserId(string userId)
		{
		}

		public static void SetUserProperty(string name, string value)
		{
		}

		public static void LogEvent(string name, [Optional] Dictionary<string, object> data)
		{
		}
	}
}
