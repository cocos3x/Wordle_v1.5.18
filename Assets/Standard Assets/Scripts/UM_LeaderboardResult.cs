using SA.Common.Models;

public class UM_LeaderboardResult : UM_Result
{
	private UM_Leaderboard _Leaderboard;

	public UM_Leaderboard Leaderboard => null;

	public UM_LeaderboardResult(UM_Leaderboard leaderboard, Result result)
	{
	}

	public UM_LeaderboardResult(UM_Leaderboard leaderboard, GooglePlayResult result)
	{
	}

	public UM_LeaderboardResult(UM_Leaderboard leaderboard, AMN_Result result)
	{
	}

	private void Setinfo(UM_Leaderboard leaderboard)
	{
	}
}
