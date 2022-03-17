using SA.Common.Models;

public class GK_SaveResult : Result
{
	private GK_SavedGame _SavedGame;

	public GK_SavedGame SavedGame => null;

	public GK_SaveResult(GK_SavedGame save)
	{
	}

	public GK_SaveResult(string errorData)
	{
	}

	public GK_SaveResult(Error error)
	{
	}
}
