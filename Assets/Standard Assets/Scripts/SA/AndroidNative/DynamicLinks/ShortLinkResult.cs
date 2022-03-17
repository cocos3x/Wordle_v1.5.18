using SA.Common.Models;

namespace SA.AndroidNative.DynamicLinks
{
	public class ShortLinkResult : Result
	{
		private string shortLink;

		public string ShortLink => "";

		public ShortLinkResult(Error error)
		{
		}

		public ShortLinkResult(string link)
		{
		}
	}
}
