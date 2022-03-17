using System.Collections.Generic;

public class AMN_RequestLeaderboardsResult : AMN_Result
{
	private string error;

	private List<GC_Leaderboard> leaderboardsList;

	public string Error => "";

	public List<GC_Leaderboard> LeaderboardsList => null;

	public AMN_RequestLeaderboardsResult(bool success)
	{
	}

	public AMN_RequestLeaderboardsResult(string err)
	{
	}

	public AMN_RequestLeaderboardsResult(List<GC_Leaderboard> list)
	{
	}
}
