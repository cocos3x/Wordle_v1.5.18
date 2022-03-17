using UnityEngine;
using UnityEngine.UI;

public class GoogleAdMobTab : FeatureTab
{
	private const string MY_BANNERS_AD_UNIT_ID = "ca-app-pub-6101605888755494/1824764765";

	private const string MY_INTERSTISIALS_AD_UNIT_ID = "ca-app-pub-6101605888755494/3301497967";

	private const string MY_REWARDED_VIDEO_AD_UNIT_ID = "ca-app-pub-6101605888755494/5378283960";

	private GoogleMobileAdBanner Banner;

	private GoogleMobileAdBanner SmartBanner;

	private bool IsInterstisialsAdReady;

	[SerializeField]
	private Button ShowInterstitialButton;

	public Toggle CustomPosTgl;

	public Toggle UpperLeftTgl;

	public Toggle UpperCenterTgl;

	public Toggle BottomLeftTgl;

	public Toggle BottomCenterTgl;

	public Toggle BottomRightTgl;

	public Button BannerHideBtn;

	public Button BannerCreateBtn;

	public Button BannerRefreshBtn;

	public Button BannerChangePosToMiddleBtn;

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

	private void HandleOnRewardedVideoAdClosed()
	{
	}

	private void HandleOnRewardedVideoLoaded()
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

	public void LoadRewardedVideoAd()
	{
	}

	public void ShowRewardedVideoAd()
	{
	}

	public void BannerHide()
	{
	}

	public void BannerShow()
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

	public void SmartBannerShow()
	{
	}

	public void SmartBannerRefresh()
	{
	}

	public void SmartBannerDestroy()
	{
	}

	public void ChnagePostToMiddle()
	{
	}

	public void ChangePostRandom()
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

	private void OnInAppRequest(string productId)
	{
	}

	private void _003CStart_003Eb__27_0(bool b)
	{
	}

	private void _003CStart_003Eb__27_1(bool b)
	{
	}

	private void _003CStart_003Eb__27_2(bool b)
	{
	}

	private void _003CStart_003Eb__27_3(bool b)
	{
	}

	private void _003CStart_003Eb__27_4(bool b)
	{
	}

	private void _003CStart_003Eb__27_5(bool b)
	{
	}

	private void _003CStart_003Eb__27_6(bool b)
	{
	}

	private void _003CStart_003Eb__27_7(bool b)
	{
	}
}
