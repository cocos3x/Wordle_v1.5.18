using UnityEngine;

public class AMN_AdvertisingProxy : MonoBehaviour
{
	private const string CLASS_NAME = "com.amazonnative.AMNMobileAd";

	private static void CallActivityFunction(string methodName, params object[] args)
	{
	}

	public static void GetInstance()
	{
	}

	public static void Init(string api_key, bool isTestmode)
	{
	}

	public static void CreateBanner(string position, int id)
	{
	}

	public static void RefreshBanner(int id)
	{
	}

	public static void DestroyBanner(int id)
	{
	}

	public static void HideBanner(bool hide, int id)
	{
	}

	public static void LoadInterstitial()
	{
	}

	public static void ShowInterstitial()
	{
	}

	public static void playServiceConnect(string accountName)
	{
	}

	public static void loadToken(string accountName, string scope)
	{
	}

	public static void loadToken()
	{
	}

	public static void invalidateToken(string token)
	{
	}

	public static void playServiceDisconnect()
	{
	}

	public static void showAchievementsUI()
	{
	}

	public static void showLeaderBoardsUI()
	{
	}

	public static void loadConnectedPlayers()
	{
	}

	public static void showLeaderBoard(string leaderboardName)
	{
	}

	public static void showLeaderBoardById(string leaderboardId)
	{
	}

	public static void submitScore(string leaderboardName, long score)
	{
	}

	public static void submitScoreById(string leaderboardId, long score)
	{
	}

	public static void loadLeaderBoards()
	{
	}

	public static void UpdatePlayerScore(string leaderboardId, int span, int leaderboardCollection)
	{
	}

	public static void loadPlayerCenteredScores(string leaderboardId, int span, int leaderboardCollection, int maxResults)
	{
	}

	public static void loadTopScores(string leaderboardId, int span, int leaderboardCollection, int maxResults)
	{
	}

	public static void reportAchievement(string achievementName)
	{
	}

	public static void reportAchievementById(string achievementId)
	{
	}

	public static void revealAchievement(string achievementName)
	{
	}

	public static void revealAchievementById(string achievementId)
	{
	}

	public static void incrementAchievement(string achievementName, string numsteps)
	{
	}

	public static void incrementAchievementById(string achievementId, string numsteps)
	{
	}

	public static void loadAchievements()
	{
	}

	public static void resetAchievement(string achievementId)
	{
	}

	public static void ResetAllAchievements()
	{
	}

	public static void resetLeaderBoard(string leaderboardId)
	{
	}

	public static void OnApplicationPause(bool isPaused)
	{
	}
}
