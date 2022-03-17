using SA.Common.Models;

public class GK_UserInfoLoadResult : Result
{
	private string _playerId;

	private GK_Player _tpl;

	public string playerId => "";

	public GK_Player playerTemplate => null;

	public GK_UserInfoLoadResult(GK_Player tpl)
	{
	}

	public GK_UserInfoLoadResult(string id)
	{
	}
}
