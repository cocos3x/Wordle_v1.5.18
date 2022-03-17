using SA.Common.Pattern;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class GameCenter_TBM : Singleton<GameCenter_TBM>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__91_0(GK_TBM_LoadMatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_1(GK_TBM_LoadMatchesResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_2(GK_TBM_MatchDataUpdateResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_3(GK_TBM_MatchInitResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_4(GK_TBM_MatchQuitResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_5(GK_TBM_EndTrunResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_6(GK_TBM_MatchEndResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_7(GK_TBM_RematchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_8(GK_TBM_MatchRemovedResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_9(GK_TBM_MatchInitResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_10(GK_TBM_MatchRemovedResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_11(GK_TBM_Match _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__91_12(GK_TBM_MatchTurnResult _003Cp0_003E)
		{
		}
	}

	private Dictionary<string, GK_TBM_Match> _Matches;

	public Dictionary<string, GK_TBM_Match> Matches => null;

	public List<GK_TBM_Match> MatchesList => null;

	public static event Action<GK_TBM_LoadMatchResult> ActionMatchInfoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_TBM_LoadMatchesResult> ActionMatchesInfoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_TBM_MatchDataUpdateResult> ActionMatchDataUpdated
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_TBM_MatchInitResult> ActionMatchFound
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_TBM_MatchQuitResult> ActionMatchQuit
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_TBM_EndTrunResult> ActionTrunEnded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_TBM_MatchEndResult> ActionMacthEnded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_TBM_RematchResult> ActionRematched
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_TBM_MatchRemovedResult> ActionMatchRemoved
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_TBM_MatchInitResult> ActionMatchInvitationAccepted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_TBM_MatchRemovedResult> ActionMatchInvitationDeclined
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_TBM_Match> ActionPlayerQuitForMatch
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_TBM_MatchTurnResult> ActionTrunReceived
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

	public void LoadMatchesInfo()
	{
	}

	public void LoadMatch(string matchId)
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

	public void SaveCurrentTurn(string matchId, byte[] matchData)
	{
	}

	public void EndTurn(string matchId, byte[] matchData, string nextPlayerId)
	{
	}

	public void QuitInTurn(string matchId, GK_TurnBasedMatchOutcome outcome, string nextPlayerId, byte[] matchData)
	{
	}

	public void QuitOutOfTurn(string matchId, GK_TurnBasedMatchOutcome outcome)
	{
	}

	public void EndMatch(string matchId, byte[] matchData)
	{
	}

	public void Rematch(string matchId)
	{
	}

	public void RemoveMatch(string matchId)
	{
	}

	public void AcceptInvite(string matchId)
	{
	}

	public void DeclineInvite(string matchId)
	{
	}

	public void UpdateParticipantOutcome(string matchId, int outcome, string playerId)
	{
	}

	public GK_TBM_Match GetMatchById(string matchId)
	{
		return null;
	}

	public static void PrintMatchInfo(GK_TBM_Match match)
	{
	}

	public void OnLoadMatchesResult(string data)
	{
	}

	private void OnLoadMatchesResultFailed(string errorData)
	{
	}

	private void OnLoadMatchResult(string data)
	{
	}

	private void OnLoadMatchResultFailed(string errorData)
	{
	}

	private void OnUpdateMatchResult(string data)
	{
	}

	private void OnUpdateMatchResultFailed(string errorData)
	{
	}

	private void OnMatchFoundResult(string data)
	{
	}

	private void OnMatchFoundResultFailed(string errorData)
	{
	}

	private void OnPlayerQuitForMatch(string data)
	{
	}

	private void OnMatchQuitResult(string matchId)
	{
	}

	private void OnMatchQuitResultFailed(string errorData)
	{
	}

	private void OnEndTurnResult(string data)
	{
	}

	private void OnEndTurnResultFailed(string errorData)
	{
	}

	private void OnEndMatch(string data)
	{
	}

	private void OnEndMatchResult(string errorData)
	{
	}

	private void OnRematchResult(string data)
	{
	}

	private void OnRematchFailed(string errorData)
	{
	}

	private void OnMatchRemoved(string matchId)
	{
	}

	private void OnMatchRemoveFailed(string errorData)
	{
	}

	private void OnMatchInvitationAccepted(string data)
	{
	}

	private void OnMatchInvitationAcceptedFailed(string errorData)
	{
	}

	private void OnMatchInvitationDeclined(string matchId)
	{
	}

	private void OnMatchInvitationDeclineFailed(string errorData)
	{
	}

	private void OnTrunReceived(string data)
	{
	}

	private void UpdateMatchInfo(GK_TBM_Match match)
	{
	}

	private static GK_TBM_Match ParceMatchInfo(string data)
	{
		return null;
	}

	public static GK_TBM_Match ParceMatchInfo(string[] MatchData, int index)
	{
		return null;
	}
}
