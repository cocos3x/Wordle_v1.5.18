using SA.Common.Models;
using System.Collections.Generic;

public class GK_TBM_LoadMatchesResult : Result
{
	public Dictionary<string, GK_TBM_Match> LoadedMatches;

	public GK_TBM_LoadMatchesResult(bool IsResultSucceeded)
	{
	}

	public GK_TBM_LoadMatchesResult(string errorData)
	{
	}
}
