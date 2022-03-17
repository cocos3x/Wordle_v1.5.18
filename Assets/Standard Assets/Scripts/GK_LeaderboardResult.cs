using SA.Common.Models;

public class GK_LeaderboardResult : Result
{
	private GK_Leaderboard _Leaderboard;

	public GK_Leaderboard Leaderboard => null;

	public GK_LeaderboardResult(GK_Leaderboard leaderboard)
	{
	}

	public GK_LeaderboardResult(GK_Leaderboard leaderboard, Error error)
	{
	}

	private void Setinfo(GK_Leaderboard leaderboard)
	{
	}
}
