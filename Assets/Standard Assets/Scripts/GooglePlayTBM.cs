using SA.Common.Pattern;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class GooglePlayTBM : Singleton<GooglePlayTBM>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__78_0(GP_TBM_LoadMatchesResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__78_1(GP_TBM_MatchInitiatedResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__78_2(GP_TBM_CancelMatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__78_3(GP_TBM_LeaveMatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__78_4(GP_TBM_LoadMatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__78_5(GP_TBM_UpdateMatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__78_6(GP_TBM_UpdateMatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__78_7(GP_TBM_UpdateMatchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__78_8(GP_TBM_MatchRemovedResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__78_9(AndroidActivityResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__78_10(string _003Cp0_003E, GP_TBM_MatchInitiatedResult _003Cp1_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__78_11(string _003Cp0_003E)
		{
		}
	}

	private Dictionary<string, GP_TBM_Match> _Matches;

	public Dictionary<string, GP_TBM_Match> Matches => null;

	public static event Action<GP_TBM_LoadMatchesResult> ActionMatchesResultLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_TBM_MatchInitiatedResult> ActionMatchInitiated
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_TBM_CancelMatchResult> ActionMatchCanceled
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_TBM_LeaveMatchResult> ActionMatchLeaved
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_TBM_LoadMatchResult> ActionMatchDataLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_TBM_UpdateMatchResult> ActionMatchUpdated
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_TBM_UpdateMatchResult> ActionMatchTurnFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_TBM_UpdateMatchResult> ActionMatchReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_TBM_MatchRemovedResult> ActionMatchRemoved
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<AndroidActivityResult> ActionMatchCreationCanceled
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string, GP_TBM_MatchInitiatedResult> ActionMatchInvitationAccepted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string> ActionMatchInvitationDeclined
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

	public void Init()
	{
	}

	public void AcceptInvitation(string invitationId)
	{
	}

	public void DeclineInvitation(string invitationId)
	{
	}

	public void DismissInvitation(string invitationId)
	{
	}

	public void CreateMatch(int minPlayers, int maxPlayers, [Optional] string[] playersIds)
	{
	}

	public void CancelMatch(string matchId)
	{
	}

	public void DismissMatch(string matchId)
	{
	}

	public void ConfirmMatchFinish(string matchId)
	{
	}

	public void ConfirmhMatchFinis(string matchId)
	{
	}

	public void FinishMatch(string matchId, byte[] matchData, params GP_ParticipantResult[] results)
	{
	}

	public void LeaveMatch(string matchId)
	{
	}

	public void LeaveMatchDuringTurn(string matchId, string pendingParticipantId)
	{
	}

	public void LoadMatchInfo(string matchId)
	{
	}

	public void LoadMatchesInfo(GP_TBM_MatchesSortOrder sortOreder, params GP_TBM_MatchTurnStatus[] matchTurnStatuses)
	{
	}

	public void LoadAllMatchesInfo(GP_TBM_MatchesSortOrder sortOreder)
	{
	}

	public void Rematch(string matchId)
	{
	}

	public void RegisterMatchUpdateListener()
	{
	}

	public void UnregisterMatchUpdateListener()
	{
	}

	public void TakeTrun(string matchId, byte[] matchData, string pendingParticipantId, params GP_ParticipantResult[] results)
	{
	}

	public void StartSelectOpponentsView(int minPlayers, int maxPlayers, bool allowAutomatch)
	{
	}

	public void ShowInbox()
	{
	}

	public void SetVariant(int val)
	{
	}

	public void SetExclusiveBitMask(int val)
	{
	}

	private void OnLoadMatchesResult(string data)
	{
	}

	private void OnMatchInitiatedCallback(string data)
	{
	}

	private void OnInvitationAcceptedCallback(string data)
	{
	}

	private void OnCancelMatchResult(string data)
	{
	}

	private void OnLeaveMatchResult(string data)
	{
	}

	private void OnLoadMatchResult(string data)
	{
	}

	private void OnUpdateMatchResult(string data)
	{
	}

	private void AN_OnTurnResult(string data)
	{
	}

	private void OnTurnBasedMatchRemoved(string matchId)
	{
	}

	private void OnTurnBasedMatchReceived(string data)
	{
	}

	private void OnMatchCreationCanceled(string data)
	{
	}

	public static GP_TBM_Match ParceMatchInfo(string data)
	{
		return null;
	}

	public static GP_TBM_Match ParceMatchInfo(string[] MatchData, int index)
	{
		return null;
	}

	private void UpdateMatchInfo(GP_TBM_Match match)
	{
	}
}
