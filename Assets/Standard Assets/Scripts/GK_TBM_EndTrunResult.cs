using SA.Common.Models;

public class GK_TBM_EndTrunResult : Result
{
	private GK_TBM_Match _Match;

	public GK_TBM_Match Match => null;

	public GK_TBM_EndTrunResult(GK_TBM_Match match)
	{
	}

	public GK_TBM_EndTrunResult(string errorData)
	{
	}
}
