using System;

namespace SA.Common.Util
{
	public static class General
	{
		private static string[] _rfc3339Formats;

		private const string Rfc3339Format = "yyyy-MM-dd'T'HH:mm:ssK";

		private const string MinRfc339Value = "0001-01-01T00:00:00Z";

		public static int CurrentTimeStamp => 0;

		public static string[] DateTimePatterns => null;

		public static void Invoke(float time, Action callback, string name = "")
		{
		}

		public static T ParseEnum<T>(string value)
		{
			return (T)null;
		}

		public static string DateTimeToRfc3339(DateTime dateTime)
		{
			return "";
		}

		public static DateTime ConvertFromUnixTimestamp(long timestamp)
		{
			return (DateTime)null;
		}

		public static long ConvertToUnixTimestamp(DateTime date)
		{
			return 0L;
		}

		public static bool TryParseRfc3339(string s, out DateTime result)
		{
			return false;
		}

		public static string HMAC(string key, string data)
		{
			return "";
		}

		public static void CleanupInstallation()
		{
		}
	}
}
