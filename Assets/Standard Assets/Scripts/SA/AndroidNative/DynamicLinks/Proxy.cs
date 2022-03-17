namespace SA.AndroidNative.DynamicLinks
{
	public static class Proxy
	{
		private const string CLASS_NAME = "com.androidnative.firebase.dynamiclinks.Bridge";

		public static string GetPendingLink()
		{
			return "";
		}

		public static void RequestLink(string request)
		{
		}

		private static T CallStaticFunction<T>(string methodName, params object[] args)
		{
			return (T)null;
		}

		private static void CallStaticFunction(string methodName, params object[] args)
		{
		}
	}
}
