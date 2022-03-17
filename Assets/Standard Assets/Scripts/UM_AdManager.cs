using System;
using UnityEngine;

public static class UM_AdManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__12_0;

		public static Action<int> _003C_003E9__12_1;

		public static Action _003C_003E9__12_2;

		internal void _003CResetActions_003Eb__12_0()
		{
		}

		internal void _003CResetActions_003Eb__12_1(int _003Cp0_003E)
		{
		}

		internal void _003CResetActions_003Eb__12_2()
		{
		}

		internal void _003C_002Ecctor_003Eb__31_0()
		{
		}

		internal void _003C_002Ecctor_003Eb__31_1(int _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__31_2()
		{
		}
	}

	private static bool _IsInited;

	private static bool _AmazonAdsShowOnLoad;

	public static bool IsInited => false;

	public static event Action OnInterstitialLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<int> OnInterstitialLoadFail
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnInterstitialClosed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void Init()
	{
	}

	public static void ResetActions()
	{
	}

	public static int CreateAdBanner(TextAnchor anchor, GADBannerSize size = GADBannerSize.BANNER)
	{
		return 0;
	}

	public static bool IsBannerLoaded(int id)
	{
		return false;
	}

	public static bool IsBannerOnScreen(int id)
	{
		return false;
	}

	public static void DestroyBanner(int id)
	{
	}

	public static void HideBanner(int id)
	{
	}

	public static void ShowBanner(int id)
	{
	}

	public static void RefreshBanner(int id)
	{
	}

	public static void StartInterstitialAd()
	{
	}

	public static void LoadInterstitialAd()
	{
	}

	public static void ShowInterstitialAd()
	{
	}

	private static void GoogleMobileAdInterstitialSubscribe()
	{
	}

	private static void InterstitialLoadedHandler()
	{
	}

	private static void InterstitialLoadFailHandler(int errorCode)
	{
	}

	private static void InterstitialClosedHandler()
	{
	}

	private static void AmazonInterstitialDismissed(AMN_InterstitialDismissedResult result)
	{
	}

	private static void AmazonInterstitialDataReceived(AMN_InterstitialDataResult result)
	{
	}
}
