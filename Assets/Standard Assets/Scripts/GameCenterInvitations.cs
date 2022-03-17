using SA.Common.Pattern;
using System;

public class GameCenterInvitations : Singleton<GameCenterInvitations>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__17_0(GK_Player _003Cp0_003E, GK_InviteRecipientResponse _003Cp1_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__17_1(GK_MatchType _003Cp0_003E, GK_Invite _003Cp1_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__17_2(GK_MatchType _003Cp0_003E, string[] _003Cp1_003E, GK_Player[] _003Cp2_003E)
		{
		}
	}

	public static event Action<GK_Player, GK_InviteRecipientResponse> ActionInviteeResponse
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_MatchType, GK_Invite> ActionPlayerAcceptedInvitation
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_MatchType, string[], GK_Player[]> ActionPlayerRequestedMatchWithRecipients
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

	private void OnInviteeResponse(string data)
	{
	}

	private void OnPlayerAcceptedInvitation_RTM(string data)
	{
	}

	private void OnPlayerRequestedMatchWithRecipients_RTM(string data)
	{
	}

	private void OnPlayerAcceptedInvitation_TBM(string data)
	{
	}

	private void OnPlayerRequestedMatchWithRecipients_TBM(string data)
	{
	}
}
