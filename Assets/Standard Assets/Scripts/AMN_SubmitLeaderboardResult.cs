public class AMN_SubmitLeaderboardResult : AMN_Result
{
	private string error;

	private string leaderboardID;

	public string Error => "";

	public string LeaderboardID => "";

	public AMN_SubmitLeaderboardResult(bool success)
	{
	}

	public AMN_SubmitLeaderboardResult(string id, string err)
	{
	}

	public AMN_SubmitLeaderboardResult(string id)
	{
	}
}
