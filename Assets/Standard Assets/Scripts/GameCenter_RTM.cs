using SA.Common.Models;
using SA.Common.Pattern;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class GameCenter_RTM : Singleton<GameCenter_RTM>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__62_0(GK_RTM_MatchStartedResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__62_1(Error _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__62_2(GK_Player _003Cp0_003E, bool _003Cp1_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__62_3(GK_RTM_QueryActivityResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__62_4(Error _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__62_5(GK_Player _003Cp0_003E, byte[] _003Cp1_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__62_6(GK_Player _003Cp0_003E, GK_PlayerConnectionState _003Cp1_003E, GK_RTM_Match _003Cp2_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__62_7(GK_Player _003Cp0_003E)
		{
		}
	}

	private GK_RTM_Match _CurrentMatch;

	private Dictionary<string, GK_Player> _NearbyPlayers;

	public GK_RTM_Match CurrentMatch => null;

	public List<GK_Player> NearbyPlayersList => null;

	public Dictionary<string, GK_Player> NearbyPlayers => null;

	public static event Action<GK_RTM_MatchStartedResult> ActionMatchStarted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Error> ActionMatchFailed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_Player, bool> ActionNearbyPlayerStateUpdated
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_RTM_QueryActivityResult> ActionActivityResultReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Error> ActionDataSendError
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_Player, byte[]> ActionDataReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_Player, GK_PlayerConnectionState, GK_RTM_Match> ActionPlayerStateChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_Player> ActionDiconnectedPlayerReinvited
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void FindMatch(int minPlayers, int maxPlayers, string msg = "", [Optional] string[] playersToInvite)
	{
	}

	public void FindMatchWithNativeUI(int minPlayers, int maxPlayers, string msg = "", [Optional] string[] playersToInvite)
	{
	}

	public void SetPlayerGroup(int group)
	{
	}

	public void SetPlayerAttributes(int attributes)
	{
	}

	public void StartMatchWithInvite(GK_Invite invite, bool useNativeUI)
	{
	}

	public void CancelPendingInviteToPlayer(GK_Player player)
	{
	}

	public void CancelMatchSearch()
	{
	}

	public void FinishMatchmaking()
	{
	}

	public void QueryActivity()
	{
	}

	public void QueryPlayerGroupActivity(int group)
	{
	}

	public void StartBrowsingForNearbyPlayers()
	{
	}

	public void StopBrowsingForNearbyPlayers()
	{
	}

	public void Rematch()
	{
	}

	public void Disconnect()
	{
	}

	public void SendDataToAll(byte[] data, GK_MatchSendDataMode dataMode)
	{
	}

	public void SendData(byte[] data, GK_MatchSendDataMode dataMode, params GK_Player[] players)
	{
	}

	private void OnMatchStartFailed(string errorData)
	{
	}

	private void OnMatchStarted(string matchData)
	{
	}

	private void OnMatchFailed(string errorData)
	{
	}

	private void OnNearbyPlayerInfoReceived(string data)
	{
	}

	private void OnQueryActivity(string data)
	{
	}

	private void OnQueryActivityFailed(string errorData)
	{
	}

	private void OnMatchInfoUpdated(string matchData)
	{
	}

	private void OnMatchPlayerStateChanged(string data)
	{
	}

	private void OnDiconnectedPlayerReinvited(string playerId)
	{
	}

	private void OnMatchDataReceived(string data)
	{
	}

	private void OnSendDataError(string errorData)
	{
	}

	private GK_RTM_Match ParseMatchData(string matchData)
	{
		return null;
	}
}
