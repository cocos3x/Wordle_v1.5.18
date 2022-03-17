using System;
using System.Collections.Generic;

public class GK_LeaderboardSet
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<ISN_LoadSetLeaderboardsInfoResult> _003C_003E9__13_0;

		internal void _003C_002Ector_003Eb__13_0(ISN_LoadSetLeaderboardsInfoResult _003Cp0_003E)
		{
		}
	}

	public string Title;

	public string Identifier;

	public string GroupIdentifier;

	public List<GK_LeaderBoardInfo> _BoardsInfo;

	public List<GK_LeaderBoardInfo> BoardsInfo => null;

	public event Action<ISN_LoadSetLeaderboardsInfoResult> OnLoaderboardsInfoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public void LoadLeaderBoardsInfo()
	{
	}

	public void AddBoardInfo(GK_LeaderBoardInfo info)
	{
	}

	public void SendFailLoadEvent()
	{
	}

	public void SendSuccessLoadEvent()
	{
	}
}
