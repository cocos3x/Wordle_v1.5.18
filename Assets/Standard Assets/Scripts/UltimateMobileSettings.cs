using System.Collections.Generic;
using UnityEngine;

public class UltimateMobileSettings : ScriptableObject
{
	public const string VERSION_NUMBER = "10.2/24";

	private const string UMSettingsAssetName = "UltimateMobileSettings";

	private const string UMSettingsAssetExtension = ".asset";

	public int ToolbarSelectedIndex;

	[SerializeField]
	public List<UM_InAppProduct> InAppProducts;

	public UM_TransactionsHandlingMode TransactionsHandlingMode;

	public int InApps_EditorFillRateIndex;

	public int InApps_EditorFillRate;

	public bool Is_InApps_EditorTestingEnabled;

	public bool IsInAppSettingsProductsOpen;

	[SerializeField]
	public List<UM_Leaderboard> Leaderboards;

	[SerializeField]
	public List<UM_Achievement> Achievements;

	public bool AutoLoadUsersSmallImages;

	public bool AutoLoadUsersBigImages;

	public bool AutoLoadLeaderboardsInfo;

	public bool AutoLoadAchievementsInfo;

	public bool IsAchievementsOpen;

	public bool IsLeaderBoardsOpen;

	public UM_IOSAdEngineOprions IOSAdEdngine;

	public UM_WP8AdEngineOprions WP8AdEdngine;

	public bool IsCameraAndGallerySettingsOpen;

	public bool IsCameraAndGalleryAndroidSettingsOpen;

	public bool IsCameraAndGalleryIOSSettingsOpen;

	public bool IsLP_Android_SettingsOpen;

	public bool IsLP_IOS_SettingsOpen;

	public bool TP_Android_SettingsOpen;

	public bool TP_IOS_SettingsOpen;

	public UM_PlatformDependencies PlatformEngine;

	private static UltimateMobileSettings instance;

	public static UltimateMobileSettings Instance => null;

	public void AddProduct(UM_InAppProduct p)
	{
	}

	public void RemoveProduct(UM_InAppProduct p)
	{
	}

	public UM_InAppProduct GetProductById(string id)
	{
		return null;
	}

	public UM_InAppProduct GetProductByIOSId(string id)
	{
		return null;
	}

	public UM_InAppProduct GetProductByAndroidId(string id)
	{
		return null;
	}

	public UM_InAppProduct GetProductByAmazonId(string id)
	{
		return null;
	}

	public UM_InAppProduct GetProductByWp8Id(string id)
	{
		return null;
	}

	public void AddAchievement(UM_Achievement a)
	{
	}

	public void RemoveAchievement(UM_Achievement a)
	{
	}

	public UM_Achievement GetAchievementById(string id)
	{
		return null;
	}

	public UM_Achievement GetAchievementByIOSId(string id)
	{
		return null;
	}

	public UM_Achievement GetAchievementByAndroidId(string id)
	{
		return null;
	}

	public void AddLeaderboard(UM_Leaderboard l)
	{
	}

	public void RemoveLeaderboard(UM_Leaderboard l)
	{
	}

	public UM_Leaderboard GetLeaderboardById(string id)
	{
		return null;
	}

	public UM_Leaderboard GetLeaderboardByIOSId(string id)
	{
		return null;
	}

	public UM_Leaderboard GetLeaderboardByAndroidId(string id)
	{
		return null;
	}

	public UM_Leaderboard GetLeaderboardByAmazonId(string id)
	{
		return null;
	}
}
