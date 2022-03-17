using UnityEngine;

public class GameServicesScript : MonoBehaviour
{
	public static GameServicesScript gameServicesManager;

	public string dailyChallengeLeaderboardId;

	private UM_Score _dailyChallengeScoreDetails;

	public UM_Score DailyChallengeScoreDetails => null;

	private void Awake()
	{
	}

	public void DoConnect()
	{
	}

	public void DoShowLeaderBoards()
	{
	}

	public string GetConnectionState()
	{
		return "";
	}

	public bool IsConnected()
	{
		return false;
	}

	public string GetOrdinalSuffix(int num)
	{
		return "";
	}

	public int DailyChallengeRank()
	{
		return 0;
	}

	public string DailyChallengeRankAsString()
	{
		return "";
	}

	public void LoadDailyChallengeScores()
	{
	}

	public void SubmitDailChallengeScore(int score)
	{
	}

	private void submitScore(string LeaderBoardId, int score)
	{
	}

	public UM_Score DailyChallengePlayerScore()
	{
		return null;
	}

	public void ShowDailyChallengeLeaderBoard()
	{
	}
}
