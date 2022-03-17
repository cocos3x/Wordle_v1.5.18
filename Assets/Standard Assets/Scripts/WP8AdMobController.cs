using SA.Common.Pattern;
using System;
using System.Collections.Generic;
using UnityEngine;

public class WP8AdMobController : Singleton<WP8AdMobController>, GoogleMobileAdInterface
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__91_0;

		public static Action<int> _003C_003E9__91_1;

		public static Action _003C_003E9__91_2;

		public static Action _003C_003E9__91_3;

		public static Action _003C_003E9__91_4;

		public static Action<string> _003C_003E9__91_5;

		public static Action<string, int> _003C_003E9__91_6;

		public static Action _003C_003E9__91_7;

		public static Action<int> _003C_003E9__91_8;

		public static Action _003C_003E9__91_9;

		public static Action _003C_003E9__91_10;

		public static Action _003C_003E9__91_11;

		public static Action _003C_003E9__91_12;

		internal void _003C_002Ector_003Eb__91_0()
		{
		}

		internal void _003C_002Ector_003Eb__91_1(int _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__91_2()
		{
		}

		internal void _003C_002Ector_003Eb__91_3()
		{
		}

		internal void _003C_002Ector_003Eb__91_4()
		{
		}

		internal void _003C_002Ector_003Eb__91_5(string _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__91_6(string _003Cp0_003E, int _003Cp1_003E)
		{
		}

		internal void _003C_002Ector_003Eb__91_7()
		{
		}

		internal void _003C_002Ector_003Eb__91_8(int _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__91_9()
		{
		}

		internal void _003C_002Ector_003Eb__91_10()
		{
		}

		internal void _003C_002Ector_003Eb__91_11()
		{
		}

		internal void _003C_002Ector_003Eb__91_12()
		{
		}
	}

	private bool _IsInited;

	private Dictionary<int, WP8ADBanner> _banners;

	private string _BannersUunitId;

	private string _InterstisialUnitId;

	private string _RewardedVideoAdUnitId;

	private const string DEVICES_SEPARATOR = ",";

	public List<GoogleMobileAdBanner> banners => null;

	public bool IsInited => false;

	public string BannersUunitId => "";

	public string InterstisialUnitId => "";

	public string RewardedVideoAdUnitId => "";

	public event Action OnInterstitialLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<int> OnInterstitialFailedLoading
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnInterstitialOpened
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnInterstitialClosed
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnInterstitialLeftApplication
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<string> OnAdInAppRequest
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<string, int> OnRewarded
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnRewardedVideoAdClosed
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<int> OnRewardedVideoAdFailedToLoad
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnRewardedVideoAdLeftApplication
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnRewardedVideoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnRewardedVideoAdOpened
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnRewardedVideoStarted
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

	public void Init(string ad_unit_id)
	{
	}

	public void Init(string banners_unit_id, string interstisial_unit_id)
	{
	}

	public void InitEditorTesting(bool isEditorTesting, int fillRate)
	{
	}

	public void SetOrientation(ScreenOrientation orientation)
	{
	}

	public void SetBannersUnitID(string ad_unit_id)
	{
	}

	public void SetInterstisialsUnitID(string ad_unit_id)
	{
	}

	public void SetRewardedVideoAdUnitID(string id)
	{
	}

	public GoogleMobileAdBanner CreateAdBanner(TextAnchor anchor, GADBannerSize size)
	{
		return null;
	}

	public GoogleMobileAdBanner CreateAdBanner(int x, int y, GADBannerSize size)
	{
		return null;
	}

	public void DestroyBanner(int id)
	{
	}

	public void RecordInAppResolution(GADInAppResolution resolution)
	{
	}

	public void AddKeyword(string keyword)
	{
	}

	public void AddTestDevice(string deviceId)
	{
	}

	public void AddTestDevices(params string[] ids)
	{
	}

	public void SetGender(GoogleGender gender)
	{
	}

	public void SetBirthday(int year, AndroidMonth month, int day)
	{
	}

	public void TagForChildDirectedTreatment(bool tagForChildDirectedTreatment)
	{
	}

	public void StartInterstitialAd()
	{
	}

	public void LoadInterstitialAd()
	{
	}

	public void ShowInterstitialAd()
	{
	}

	public void StartRewardedVideo()
	{
	}

	public void LoadRewardedVideo()
	{
	}

	public void ShowRewardedVideo()
	{
	}

	public GoogleMobileAdBanner GetBanner(int id)
	{
		return null;
	}

	private void OnBannerAdLoaded(string data)
	{
	}

	private void OnBannerAdFailedToLoad(string bannerID)
	{
	}

	private void OnBannerAdOpened(string bannerID)
	{
	}

	private void OnBannerAdClosed(string bannerID)
	{
	}

	private void OnBannerAdLeftApplication(string bannerID)
	{
	}

	private void OnInterstitialAdLoaded(string data)
	{
	}

	private void OnInterstitialAdFailedToLoad(string data)
	{
	}

	private void OnInterstitialAdOpened(string data)
	{
	}

	private void OnInterstitialAdClosed(string data)
	{
	}

	private void OnInterstitialAdLeftApplication(string data)
	{
	}

	private void OnInAppPurchaseRequested(string productId)
	{
	}
}
