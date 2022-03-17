using SA.Common.Pattern;
using System;
using System.Collections.Generic;

public class GooglePlayInvitationManager : Singleton<GooglePlayInvitationManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__27_0(GP_Invite _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__27_1(GP_Invite _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__27_2(List<GP_Invite> _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__27_3(AN_InvitationInboxCloseResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__27_4(string _003Cp0_003E)
		{
		}
	}

	public static event Action<GP_Invite> ActionInvitationReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_Invite> ActionInvitationAccepted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<List<GP_Invite>> ActionInvitationsListLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<AN_InvitationInboxCloseResult> ActionInvitationInboxClosed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string> ActionInvitationRemoved
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

	private void OnInvitationReceived(string data)
	{
	}

	private void OnInvitationAccepted(string data)
	{
	}

	private void OnInvitationRemoved(string invId)
	{
	}

	private void OnInvitationBoxUiClosed(string response)
	{
	}

	private void OnLoadInvitationsResult(string data)
	{
	}

	private GP_Invite InviteFromString(string[] storeData, int offset)
	{
		return null;
	}

	public void RegisterInvitationListener()
	{
	}

	public void UnregisterInvitationListener()
	{
	}

	public void LoadInvitations()
	{
	}
}
