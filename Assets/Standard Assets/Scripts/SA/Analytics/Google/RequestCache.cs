using System.Collections.Generic;

namespace SA.Analytics.Google
{
	public class RequestCache
	{
		private const string DATA_SPLITTER = "|";

		private const string RQUEST_DATA_SPLITTER = "%rps%";

		private const string GA_DATA_CACHE_KEY = "GoogleAnalyticsRequestCache";

		public static string SavedData
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public static List<CachedRequest> CurrenCachedRequests => null;

		public static void SaveRequest(string cache)
		{
		}

		public static void SendCachedRequests()
		{
		}

		public static void Clear()
		{
		}

		public static void CacheRequests(List<CachedRequest> requests)
		{
		}
	}
}
