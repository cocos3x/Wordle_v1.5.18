using System.Collections.Generic;

namespace SA.Analytics.Google
{
	public class CachedRequest
	{
		private long _TimeCreated;

		private string _RequestBody;

		public long TimeCreated
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string RequestBody
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string Delay => "";

		public List<string> DataForJSON => null;

		public CachedRequest()
		{
		}

		public CachedRequest(string body, long ticks)
		{
		}
	}
}
