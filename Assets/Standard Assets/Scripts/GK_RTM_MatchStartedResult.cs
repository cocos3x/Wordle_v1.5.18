using SA.Common.Models;

public class GK_RTM_MatchStartedResult : Result
{
	private GK_RTM_Match _Match;

	public GK_RTM_Match Match => null;

	public GK_RTM_MatchStartedResult(GK_RTM_Match match)
	{
	}

	public GK_RTM_MatchStartedResult(string errorData)
	{
	}
}
