using UnityEngine;
using UnityEngine.UI;

public class GoogleMobileAdTab : FeatureTab
{
	private const string MY_BANNERS_AD_UNIT_ID = "ca-app-pub-6101605888755494/1824764765";

	private const string MY_INTERSTISIALS_AD_UNIT_ID = "ca-app-pub-6101605888755494/3301497967";

	private const string MY_REWARDED_VIDEO_AD_UNIT_ID = "ca-app-pub-6101605888755494/5378283960";

	private GoogleMobileAdBanner Banner;

	private GoogleMobileAdBanner SmartBanner;

	private bool IsInterstisialsAdReady;

	private bool IsVideoAdReady;

	[SerializeField]
	private Button ShowInterstitialButton;

	[SerializeField]
	private Button ShowVideoButton;

	public Toggle CustomPosTgl;

	public Toggle UpperLeftTgl;

	public Toggle UpperCenterTgl;

	public Toggle UpperRightTgl;

	public Toggle BottomLeftTgl;

	public Toggle BottomCenterTgl;

	public Toggle BottomRightTgl;

	public Button BannerHideBtn;

	public Button BannerCreateBtn;

	public Button BannerRefreshBtn;

	public Button BannerChangePosRandomBtn;

	public Button BannerDestroyBtn;

	public Toggle SmartBotPosTgl;

	public Toggle SmartTopPosTgl;

	public Button SmartHide;

	public Button SmartCreate;

	public Button SmartRefresh;

	public Button SmartDestroy;

	private TextAnchor? BannerPosition;

	private TextAnchor SmartBannerPosition;

	private void Start()
	{
	}

	public void Init()
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

	public void StartRewardedVideoAd()
	{
	}

	public void LoadRewardedVideoAd()
	{
	}

	public void ShowRewardedVideoAd()
	{
	}

	public void BannerHide()
	{
	}

	public void BannerCreate()
	{
	}

	public void BannerRefresh()
	{
	}

	public void BannerDestroy()
	{
	}

	public void SmartBannerHide()
	{
	}

	public void SmartBannerCreate()
	{
	}

	public void SmartBannerRefresh()
	{
	}

	public void SmartBannerDestroy()
	{
	}

	public void ChangePosRandom()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnInterstisialsLoaded()
	{
	}

	private void OnInterstisialsOpen()
	{
	}

	private void HandleOnRewardedVideoLoaded()
	{
	}

	private void HandleOnRewardedVideoAdClosed()
	{
	}

	private void OnInAppRequest(string productId)
	{
	}

	private void _003CStart_003Eb__29_0(bool b)
	{
	}

	private void _003CStart_003Eb__29_1(bool b)
	{
	}

	private void _003CStart_003Eb__29_2(bool b)
	{
	}

	private void _003CStart_003Eb__29_3(bool b)
	{
	}

	private void _003CStart_003Eb__29_4(bool b)
	{
	}

	private void _003CStart_003Eb__29_5(bool b)
	{
	}

	private void _003CStart_003Eb__29_6(bool b)
	{
	}

	private void _003CStart_003Eb__29_7(bool b)
	{
	}

	private void _003CStart_003Eb__29_8(bool b)
	{
	}
}
