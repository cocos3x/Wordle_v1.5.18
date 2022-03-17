using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class GP_TBM_Controller : iTBM_Matchmaker
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<UM_TBM_MatchResult> _003C_003E9__26_0;

		public static Action<UM_TBM_MatchResult> _003C_003E9__26_1;

		public static Action<UM_TBM_MatchResult> _003C_003E9__26_2;

		public static Action<string> _003C_003E9__26_3;

		public static Action<UM_TBM_MatchResult> _003C_003E9__26_4;

		public static Action<UM_TBM_MatchResult> _003C_003E9__26_5;

		public static Action<UM_TBM_MatchesLoadResult> _003C_003E9__26_6;

		public static Action _003C_003E9__26_7;

		internal void _003C_002Ector_003Eb__26_0(UM_TBM_MatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__26_1(UM_TBM_MatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__26_2(UM_TBM_MatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__26_3(string _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__26_4(UM_TBM_MatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__26_5(UM_TBM_MatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__26_6(UM_TBM_MatchesLoadResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__26_7()
		{
		}
	}

	public List<UM_TBM_Match> _Matches;

	public List<UM_TBM_Invite> _Invitations;

	private int DataEventCount;

	private const int PLACING_UNINITIALIZED = -1;

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

	public event Action MatchesListUpdated
	{
		add
		{
		}
		remove
		{
		}
	}

	public void SetGroup(int group)
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

	private void CheckDataCounter()
	{
	}

	public void LoadMatch(string matchId)
	{
	}

	public void TakeTurn(string matchId, byte[] matchData, UM_TBM_Participant nextParticipant)
	{
	}

	public void QuitInTurn(string matchId, UM_TBM_Participant nextParticipant)
	{
	}

	public void QuitOutOfTurn(string matchId)
	{
	}

	public void RemoveMatch(string matchId)
	{
	}

	public void FinishMatch(string matchId, byte[] matchData, params UM_TMB_ParticipantResult[] results)
	{
	}

	public void ConfirmhMatchFinis(string matchId)
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

	private void HandleActionMatchInitiated(GP_TBM_MatchInitiatedResult res)
	{
	}

	private void HandleActionMatchDataLoaded(GP_TBM_LoadMatchResult res)
	{
	}

	private void HandleActionMatchesResultLoaded(GP_TBM_LoadMatchesResult res)
	{
	}

	private void HandleActionInvitationsListLoaded(List<GP_Invite> res)
	{
	}

	private void HandleActionMatchUpdated(GP_TBM_UpdateMatchResult res)
	{
	}

	private void HandleActionTurnFinished(GP_TBM_UpdateMatchResult res)
	{
	}

	private void HandleActionPlayerConnected()
	{
	}

	private void HandleActionInvitationAccepted(GP_Invite invite)
	{
	}

	private void HandleActionInvitationReceived(GP_Invite invite)
	{
	}

	private void HandleActionMatchInvitationDeclined(string invitationId)
	{
	}

	private void HandleActionMatchInvitationAccepted(string invitationId, GP_TBM_MatchInitiatedResult res)
	{
	}

	private void HandleActionMatchLeaved(GP_TBM_LeaveMatchResult res)
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
}
