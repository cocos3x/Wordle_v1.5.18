using GoogleMobileAds.Common.Mediation.UnityAds;

namespace GoogleMobileAds.Api.Mediation.UnityAds
{
	public class UnityAds
	{
		public static readonly IUnityAdsClient client;

		private static IUnityAdsClient GetUnityAdsClient()
		{
			return null;
		}

		public static void SetGDPRConsentMetaData(bool consent)
		{
		}
	}
}
