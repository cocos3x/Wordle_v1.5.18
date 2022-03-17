using SA.Common.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class GK_TBM_Controller : iTBM_Matchmaker
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<UM_TBM_MatchResult> _003C_003E9__29_0;

		public static Action<UM_TBM_MatchResult> _003C_003E9__29_1;

		public static Action<UM_TBM_MatchResult> _003C_003E9__29_2;

		public static Action<string> _003C_003E9__29_3;

		public static Action<UM_TBM_MatchResult> _003C_003E9__29_4;

		public static Action<UM_TBM_MatchResult> _003C_003E9__29_5;

		public static Action<UM_TBM_MatchesLoadResult> _003C_003E9__29_6;

		public static Action<List<UM_TBM_Invite>> _003C_003E9__29_7;

		public static Action _003C_003E9__29_8;

		internal void _003C_002Ector_003Eb__29_0(UM_TBM_MatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__29_1(UM_TBM_MatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__29_2(UM_TBM_MatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__29_3(string _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__29_4(UM_TBM_MatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__29_5(UM_TBM_MatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__29_6(UM_TBM_MatchesLoadResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__29_7(List<UM_TBM_Invite> _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__29_8()
		{
		}
	}

	public List<UM_TBM_Match> _Matches;

	public List<UM_TBM_Invite> _Invitations;

	public List<UM_TBM_Match> Matches => null;

	public List<UM_TBM_Invite> Invitations => null;

	public event Action<UM_TBM_MatchResult> MatchFoundEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UM_TBM_MatchResult> MatchLoadedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UM_TBM_MatchResult> InvitationAccepted
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<string> InvitationDeclined
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UM_TBM_MatchResult> TurnEndedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UM_TBM_MatchResult> MatchUpdatedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UM_TBM_MatchesLoadResult> MatchesListLoadedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<List<UM_TBM_Invite>> InvitationsListLoadedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action MatchesListUpdated
	{
		add
		{
		}
		remove
		{
		}
	}

	private void HandleActionMatchInvitationDeclined(GK_TBM_MatchRemovedResult res)
	{
	}

	private void HandleActionMatchInvitationAccepted(GK_TBM_MatchInitResult res)
	{
	}

	private void HandleActionMatchRemoved(GK_TBM_MatchRemovedResult res)
	{
	}

	public void SetGroup(int playerGroup)
	{
	}

	public void SetMask(int mask)
	{
	}

	public void FindMatch(int minPlayers, int maxPlayers, [Optional] string[] recipients)
	{
	}

	public void ShowNativeFindMatchUI(int minPlayers, int maxPlayers)
	{
	}

	public void LoadMatchesInfo()
	{
	}

	public void LoadMatch(string matchId)
	{
	}

	public void RemoveMatch(string matchId)
	{
	}

	public void TakeTurn(string matchId, byte[] matchData, UM_TBM_Participant nextParticipant)
	{
	}

	public void FinishMatch(string matchId, byte[] matchData, params UM_TMB_ParticipantResult[] results)
	{
	}

	public void Rematch(string matchId)
	{
	}

	public void AcceptInvite(UM_TBM_Invite invite)
	{
	}

	public void DeclineInvite(UM_TBM_Invite invite)
	{
	}

	public void QuitInTurn(string matchId, UM_TBM_Participant nextParticipant)
	{
	}

	public void QuitOutOfTurn(string matchId)
	{
	}

	public void SendMatchUpdateEvent(Result res, GK_TBM_Match match)
	{
	}

	private void UpdateMatchData(UM_TBM_Match match)
	{
	}

	private void RemoveMatchFromTheList(string matchId)
	{
	}

	private void RemoveInvitationsFromTheList(string inviteId)
	{
	}

	private void HandleActionMatchFound(GK_TBM_MatchInitResult res)
	{
	}

	private void HandleActionRematched(GK_TBM_RematchResult res)
	{
	}

	private void HandleActionTrunReceived(GK_TBM_MatchTurnResult res)
	{
	}

	private void HandleActionPlayerQuitForMatch(GK_TBM_Match match)
	{
	}

	private void HandleActionMatchQuit(GK_TBM_MatchQuitResult res)
	{
	}

	private void HandleActionMacthEnded(GK_TBM_MatchEndResult res)
	{
	}

	private void HandleActionMatchInfoLoaded(GK_TBM_LoadMatchResult res)
	{
	}

	private void HandleActionTrunEnded(GK_TBM_EndTrunResult res)
	{
	}

	private void HandleActionMatchesInfoLoaded(GK_TBM_LoadMatchesResult res)
	{
	}
}
