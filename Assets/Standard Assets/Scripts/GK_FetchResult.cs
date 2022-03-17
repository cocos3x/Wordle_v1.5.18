using SA.Common.Models;
using System.Collections.Generic;

public class GK_FetchResult : Result
{
	private List<GK_SavedGame> _SavedGames;

	public List<GK_SavedGame> SavedGames => null;

	public GK_FetchResult(List<GK_SavedGame> saves)
	{
	}

	public GK_FetchResult(string errorData)
	{
	}
}
