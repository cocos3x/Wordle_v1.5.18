using SA.Common.Pattern;
using System;
using System.Collections.Generic;
using UnityEngine;

public class AndroidAdMobController : Singleton<AndroidAdMobController>, GoogleMobileAdInterface
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string, int> _003C_003E9__110_0;

		public static Action _003C_003E9__110_1;

		public static Action<int> _003C_003E9__110_2;

		public static Action _003C_003E9__110_3;

		public static Action _003C_003E9__110_4;

		public static Action _003C_003E9__110_5;

		public static Action _003C_003E9__110_6;

		public static Action _003C_003E9__110_7;

		public static Action<int> _003C_003E9__110_8;

		public static Action _003C_003E9__110_9;

		public static Action _003C_003E9__110_10;

		public static Action _003C_003E9__110_11;

		public static Action<string> _003C_003E9__110_12;

		internal void _003C_002Ector_003Eb__110_0(string _003Cp0_003E, int _003Cp1_003E)
		{
		}

		internal void _003C_002Ector_003Eb__110_1()
		{
		}

		internal void _003C_002Ector_003Eb__110_2(int _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__110_3()
		{
		}

		internal void _003C_002Ector_003Eb__110_4()
		{
		}

		internal void _003C_002Ector_003Eb__110_5()
		{
		}

		internal void _003C_002Ector_003Eb__110_6()
		{
		}

		internal void _003C_002Ector_003Eb__110_7()
		{
		}

		internal void _003C_002Ector_003Eb__110_8(int _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__110_9()
		{
		}

		internal void _003C_002Ector_003Eb__110_10()
		{
		}

		internal void _003C_002Ector_003Eb__110_11()
		{
		}

		internal void _003C_002Ector_003Eb__110_12(string _003Cp0_003E)
		{
		}
	}

	private bool _IsInited;

	private Dictionary<int, AndroidADBanner> _banners;

	private bool _IsEditorTestingEnabled;

	private int _EditorFillRate;

	private string _BannersUunitId;

	private string _InterstisialUnitId;

	private string _RewardedVideoAdUnitId;

	private const string DEVICES_SEPARATOR = ",";

	private bool _InterstitialShowOnLoad;

	private bool _RewardedVideoShowOnLoad;

	public List<GoogleMobileAdBanner> banners => null;

	public bool IsInited => false;

	public string BannersUunitId => "";

	public string InterstisialUnitId => "";

	public string RewardedVideoAdUnitId => "";

	public bool IsEditorTestingEnabled => false;

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

	private void Awake()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public void Init(string ad_unit_id)
	{
	}

	public void Init(string banners_unit_id, string interstisial_unit_id)
	{
	}

	public void InitEditorTesting(bool isTestingEnabled, int editorFillRate)
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

	public void AddKeyword(string keyword)
	{
	}

	public void SetBirthday(int year, AndroidMonth month, int day)
	{
	}

	public void TagForChildDirectedTreatment(bool tagForChildDirectedTreatment)
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

	public void StartInterstitialAd()
	{
	}

	public void LoadInterstitialAd()
	{
	}

	private void HandleOnInterstitialLoadComplete_Editor(bool success)
	{
	}

	public void ShowInterstitialAd()
	{
	}

	private void HandleOnInterstitialFinished_Editor(bool isRewarded)
	{
	}

	private void HandleOnInterstitialLeftApplication_Editor()
	{
	}

	public void StartRewardedVideo()
	{
	}

	public void LoadRewardedVideo()
	{
	}

	private void HandleOnVideoLoadComplete_Editor(bool success)
	{
	}

	public void ShowRewardedVideo()
	{
	}

	private void HandleOnVideoFinished_Editor(bool isRewarded)
	{
	}

	private void HandleOnVideoLeftApplication_Editor()
	{
	}

	public void RecordInAppResolution(GADInAppResolution resolution)
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

	private void OnInterstitialAdLoaded()
	{
	}

	private void OnInterstitialAdFailedToLoad(string errorCode)
	{
	}

	private void OnInterstitialAdOpened()
	{
	}

	private void OnInterstitialAdClosed()
	{
	}

	private void OnInterstitialAdLeftApplication()
	{
	}

	private void RewardedCallback(string data)
	{
	}

	private void RewardedVideoAdClosed()
	{
	}

	private void RewardedVideoAdFailedToLoad(string errorCode)
	{
	}

	private void RewardedVideoAdLeftApplication()
	{
	}

	private void RewardedVideoLoaded()
	{
	}

	private void RewardedVideoAdOpened()
	{
	}

	private void RewardedVideoStarted()
	{
	}

	private void OnInAppPurchaseRequested(string productId)
	{
	}
}
