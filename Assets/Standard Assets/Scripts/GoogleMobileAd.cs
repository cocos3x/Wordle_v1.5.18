using System;
using UnityEngine;

public class GoogleMobileAd
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__91_0()
		{
		}

		internal void _003C_002Ecctor_003Eb__91_1(int _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_2()
		{
		}

		internal void _003C_002Ecctor_003Eb__91_3()
		{
		}

		internal void _003C_002Ecctor_003Eb__91_4()
		{
		}

		internal void _003C_002Ecctor_003Eb__91_5(string _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_6(string _003Cp0_003E, int _003Cp1_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_7()
		{
		}

		internal void _003C_002Ecctor_003Eb__91_8(int _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_9()
		{
		}

		internal void _003C_002Ecctor_003Eb__91_10()
		{
		}

		internal void _003C_002Ecctor_003Eb__91_11()
		{
		}

		internal void _003C_002Ecctor_003Eb__91_12()
		{
		}
	}

	public static GoogleMobileAdInterface controller;

	private static bool _IsInited;

	private static bool _IsInterstitialReady;

	private static bool _IsRewardedVideoReady;

	public static bool IsInited => false;

	public static string BannersUunitId => "";

	public static string InterstisialUnitId => "";

	public static bool IsInterstitialReady => false;

	public static string RewardedVideoUnitId => "";

	public static bool IsRewardedVideoReady => false;

	public bool IsEditorTestingEnabled => false;

	public static event Action OnInterstitialLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<int> OnInterstitialFailedLoading
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnInterstitialOpened
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

	public static event Action OnInterstitialLeftApplication
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string> OnAdInAppRequest
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string, int> OnRewarded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnRewardedVideoAdClosed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<int> OnRewardedVideoAdFailedToLoad
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnRewardedVideoAdLeftApplication
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnRewardedVideoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnRewardedVideoAdOpened
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnRewardedVideoStarted
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

	public static void SetBannersUnitID(string android_unit_id, string ios_unit_id, string wp8_unit_id)
	{
	}

	public static void SetInterstisialsUnitID(string android_unit_id, string ios_unit_id, string wp8_unit_id)
	{
	}

	public static GoogleMobileAdBanner CreateAdBanner(TextAnchor anchor, GADBannerSize size)
	{
		return null;
	}

	public static GoogleMobileAdBanner CreateAdBanner(int x, int y, GADBannerSize size)
	{
		return null;
	}

	public static GoogleMobileAdBanner GetBanner(int id)
	{
		return null;
	}

	public static void DestroyBanner(int id)
	{
	}

	public static void AddKeyword(string keyword)
	{
	}

	public static void SetBirthday(int year, AndroidMonth month, int day)
	{
	}

	public static void TagForChildDirectedTreatment(bool tagForChildDirectedTreatment)
	{
	}

	public static void AddTestDevice(string deviceId)
	{
	}

	public static void AddTestDevices(params string[] ids)
	{
	}

	public static void SetGender(GoogleGender gender)
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

	public static void RecordInAppResolution(GADInAppResolution resolution)
	{
	}

	public static void StartRewardedVideo()
	{
	}

	public static void LoadRewardedVideo()
	{
	}

	public static void ShowRewardedVideo()
	{
	}

	private static void OnInterstitialLoadedListner()
	{
	}

	private static void OnInterstitialFailedLoadingListner(int errorCode)
	{
	}

	private static void OnInterstitialOpenedListner()
	{
	}

	private static void OnInterstitialClosedListner()
	{
	}

	private static void OnInterstitialLeftApplicationListner()
	{
	}

	private static void OnAdInAppRequestListner(string itemId)
	{
	}

	private static void OnRewardedVideoLoadedListner()
	{
	}

	private static void OnRewardedVideoAdFailedToLoadListner(int errorCode)
	{
	}

	private static void OnRewardedVideoStartedListner()
	{
	}

	private static void OnRewardedVideoAdOpenedListner()
	{
	}

	private static void OnRewardedVideoAdClosedListner()
	{
	}

	private static void OnRewardedVideoAdLeftApplicationListner()
	{
	}

	private static void OnRewardedListner(string itemId, int count)
	{
	}
}
