public class AMN_ScoresLoadedResult : AMN_Result
{
	private string _LeaderboardId;

	private GC_Leaderboard _Leaderboard;

	public string LeaderboardId => "";

	public GC_Leaderboard Leaderboard => null;

	public AMN_ScoresLoadedResult(GC_Leaderboard leaderboard)
	{
	}

	public AMN_ScoresLoadedResult(string leaderboardId, string error)
	{
	}
}
