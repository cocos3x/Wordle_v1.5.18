using SA.Common.Models;

public class GK_SaveDataLoaded : Result
{
	private GK_SavedGame _SavedGame;

	public GK_SavedGame SavedGame => null;

	public GK_SaveDataLoaded(GK_SavedGame save)
	{
	}

	public GK_SaveDataLoaded(Error error)
	{
	}
}
