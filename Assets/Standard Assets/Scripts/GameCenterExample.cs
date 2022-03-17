using SA.Common.Models;

public class GameCenterExample : BaseIOSFeaturePreview
{
	private int hiScore;

	private string TEST_LEADERBOARD_1;

	private string TEST_LEADERBOARD_2;

	private string TEST_ACHIEVEMENT_1_ID;

	private string TEST_ACHIEVEMENT_2_ID;

	private static bool IsInitialized;

	private static long LB2BestScores;

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}

	private void OnAchievementsLoaded(Result result)
	{
	}

	private void OnLeaderboardSetsInfoLoaded(Result res)
	{
	}

	private void OnLoaderboardsInfoLoaded(ISN_LoadSetLeaderboardsInfoResult res)
	{
	}

	private void HandleOnAchievementsReset(Result obj)
	{
	}

	private void HandleOnAchievementsProgress(GK_AchievementProgressResult result)
	{
	}

	private void OnScoreSubmitted(GK_LeaderboardResult result)
	{
	}

	private void OnLeadrboardInfoLoaded(GK_LeaderboardResult result)
	{
	}

	private void OnScoreSubmitted(Result result)
	{
	}

	private void OnAuthFinished(Result res)
	{
	}

	private void OnPlayerSignatureRetrieveResult(GK_PlayerSignatureResult result)
	{
	}
}
