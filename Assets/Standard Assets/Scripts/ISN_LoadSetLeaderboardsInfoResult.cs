using SA.Common.Models;

public class ISN_LoadSetLeaderboardsInfoResult : Result
{
	public GK_LeaderboardSet _LeaderBoardsSet;

	public GK_LeaderboardSet LeaderBoardsSet => null;

	public ISN_LoadSetLeaderboardsInfoResult(GK_LeaderboardSet lbset)
	{
	}

	public ISN_LoadSetLeaderboardsInfoResult(GK_LeaderboardSet lbset, Error error)
	{
	}
}
