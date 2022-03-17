using System.Runtime.InteropServices;

namespace SA.AndroidNative.Firebase
{
	public static class Proxy
	{
		private const string CLASS_NAME = "com.androidnative.firebase.analytics.Bridge";

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

		public static void LogEvent(string name, [Optional] string data)
		{
		}

		private static void CallStaticFunction(string methodName, params object[] args)
		{
		}
	}
}
