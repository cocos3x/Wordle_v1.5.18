using UnityEngine;

public class AN_GMSGeneralProxy : MonoBehaviour
{
	private const string CLASS_NAME = "com.androidnative.gms.core.GameClientBridge";

	private static void CallActivityFunction(string methodName, params object[] args)
	{
	}

	private static ReturnType CallActivityFunction<ReturnType>(string methodName, params object[] args)
	{
		return (ReturnType)null;
	}

	public static GP_PlayServicesStatus GetPlayServicesStatus()
	{
		//IL_0003: Expected I4, but got O
		return (GP_PlayServicesStatus)null;
	}

	public static void loadGoogleAccountNames()
	{
	}

	public static void clearDefaultAccount()
	{
	}

	public static void signOut()
	{
	}

	public static void playServiceInit(string scopes)
	{
	}

	public static void setConnectionParams(bool showPopup)
	{
	}

	public static void playServiceConnect()
	{
	}

	public static void playServiceConnect(string accountName)
	{
	}

	public static void GetGamesServerAuthCode(string serverClientId)
	{
	}

	public static void loadToken(string accountName, string scope)
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

	public static void submitScore(string leaderboardName, long score, string tag)
	{
	}

	public static void submitScoreById(string leaderboardId, long score, string tag)
	{
	}

	public static void loadLeaderBoards()
	{
	}

	public static void loadLeaderboardInfoLocal(string leaderboardId, int requestId)
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

	public static void setStepsImmediate(string achievementId, string numsteps)
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

	public static void ShowSavedGamesUI_Bridge(string title, int maxNumberOfSavedGamesToShow, bool allowAddButton, bool allowDelete)
	{
	}

	public static void CreateNewSpanshot_Bridge(string name, string description, string ImageData, string Data, long PlayedTime)
	{
	}

	public static void ResolveSnapshotsConflict_Bridge(int index)
	{
	}

	public static void LoadSpanshots_Bridge()
	{
	}

	public static void OpenSpanshotByName_Bridge(string name)
	{
	}

	public static void DeleteSpanshotByName_Bridge(string name)
	{
	}
}
