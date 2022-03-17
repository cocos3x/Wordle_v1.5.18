using System.Collections.Generic;
using UnityEngine;

public class AmazonNativeSettings : ScriptableObject
{
	public const string VERSION_NUMBER = "2.8/24";

	public int ToolbarIndex;

	public bool ShowActions;

	public bool ShowStoreParams;

	public bool IsGameCircleEnabled;

	public bool IsBillingEnabled;

	public bool IsAdvertisingEnabled;

	public List<AmazonProductTemplate> InAppProducts;

	public string AppAPIKey;

	public bool IsTestMode;

	public AMN_BannerAlign AdvertisingBannerAlign;

	public bool ShowLeaderboards;

	public List<GC_Leaderboard> Leaderboards;

	public bool ShowAchievementsParams;

	public List<GC_Achievement> Achievements;

	public string AmazonDeveloperConsoleLink;

	public string GameCircleDownloadLink;

	public string BillingDownloadLink;

	public string AdvertisingDownloadLink;

	private const string AMNSettingsAssetName = "AmazonNativeSettings";

	private const string AMNSettingsPath = "Plugins/StansAssets/Support/Settings/Resources/";

	private const string AMNSettingsAssetExtension = ".asset";

	private static AmazonNativeSettings instance;

	public static AmazonNativeSettings Instance => null;
}
