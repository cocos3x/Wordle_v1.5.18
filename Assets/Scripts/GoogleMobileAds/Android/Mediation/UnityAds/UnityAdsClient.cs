using GoogleMobileAds.Common.Mediation.UnityAds;

namespace GoogleMobileAds.Android.Mediation.UnityAds
{
	public class UnityAdsClient : IUnityAdsClient
	{
		private static UnityAdsClient instance;

		public static UnityAdsClient Instance => null;

		private UnityAdsClient()
		{
		}

		public void SetGDPRConsentMetaData(bool consent)
		{
		}
	}
}
