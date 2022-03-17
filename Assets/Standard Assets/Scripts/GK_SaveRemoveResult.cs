using SA.Common.Models;

public class GK_SaveRemoveResult : Result
{
	private string _SaveName;

	public string SaveName => "";

	public GK_SaveRemoveResult(string name)
	{
	}

	public GK_SaveRemoveResult(string name, string errorData)
	{
	}
}
