using SA.Common.Models;
using System.Collections.Generic;

public class GK_SavesResolveResult : Result
{
	private List<GK_SavedGame> _ResolvedSaves;

	public List<GK_SavedGame> SavedGames => null;

	public GK_SavesResolveResult(List<GK_SavedGame> saves)
	{
	}

	public GK_SavesResolveResult(Error error)
	{
	}

	public GK_SavesResolveResult(string errorData)
	{
	}
}
