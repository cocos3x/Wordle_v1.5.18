using SA.Common.Models;

public class UM_TBM_MatchResult : UM_Result
{
	private UM_TBM_Match _Match;

	public UM_TBM_Match Match => null;

	public UM_TBM_MatchResult(Result result)
	{
	}

	public UM_TBM_MatchResult(GooglePlayResult result)
	{
	}

	public void SetMatch(UM_TBM_Match match)
	{
	}
}
