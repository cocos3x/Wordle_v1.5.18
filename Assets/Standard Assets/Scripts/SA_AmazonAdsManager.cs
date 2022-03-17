using System;
using System.Collections.Generic;

public class SA_AmazonAdsManager : AMN_Singleton<SA_AmazonAdsManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<AMN_InterstitialDataResult> _003C_003E9__33_0;

		public static Action<AMN_InterstitialDismissedResult> _003C_003E9__33_1;

		internal void _003C_002Ector_003Eb__33_0(AMN_InterstitialDataResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__33_1(AMN_InterstitialDismissedResult _003Cp0_003E)
		{
		}
	}

	public const string DATA_SPLITTER = "|";

	private bool _isInitialized;

	private Dictionary<int, AmazonAdBanner> _banners;

	public bool IsInitialized
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Dictionary<int, AmazonAdBanner> Banners => null;

	public event Action<AMN_InterstitialDataResult> OnInterstitialDataReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AMN_InterstitialDismissedResult> OnInterstitialDismissed
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void Create()
	{
	}

	public void Init(string api_key, bool isTestMode)
	{
	}

	public int CreateBanner(AmazonAdBanner.BannerAligns position)
	{
		return 0;
	}

	public bool IsBannerLoaded(int id)
	{
		return false;
	}

	public bool IsBannerOnScreen(int id)
	{
		return false;
	}

	public void RefreshBanner(int id)
	{
	}

	public void DestroyBanner(int id)
	{
	}

	public void HideBanner(bool hide, int id)
	{
	}

	public void LoadInterstitial()
	{
	}

	public void ShowInterstitial()
	{
	}

	private void OnAdLoaded(string data)
	{
	}

	private void OnAdFailedToLoad(string data)
	{
	}

	private void onAdCollapsed(string data)
	{
	}

	private void onAdDismissed(string data)
	{
	}

	private void onAdExpanded(string data)
	{
	}

	private void OnInterstitialsLoaded(string adProperties)
	{
	}

	private void OnInterstitialsFailed(string error_message)
	{
	}

	private void OnInterstitialsDismissed(string warning_message)
	{
	}
}
