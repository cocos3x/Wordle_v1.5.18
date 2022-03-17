using System;
using System.Collections.Generic;

public class GP_RTM_Controller : iRTM_Matchmaker
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<UM_RTM_Invite> _003C_003E9__20_0;

		public static Action<UM_RTM_Invite> _003C_003E9__20_1;

		public static Action<string> _003C_003E9__20_2;

		public static Action<UM_RTM_RoomCreatedResult> _003C_003E9__20_3;

		public static Action _003C_003E9__20_4;

		public static Action<string, byte[]> _003C_003E9__20_5;

		internal void _003C_002Ector_003Eb__20_0(UM_RTM_Invite _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__20_1(UM_RTM_Invite _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__20_2(string _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__20_3(UM_RTM_RoomCreatedResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__20_4()
		{
		}

		internal void _003C_002Ector_003Eb__20_5(string _003Cp0_003E, byte[] _003Cp1_003E)
		{
		}
	}

	private List<UM_RTM_Invite> _Invitations;

	private UM_RTM_Room _CurrentRoom;

	public List<UM_RTM_Invite> Invitations => null;

	public UM_RTM_Room CurrentRoom => null;

	public event Action<UM_RTM_Invite> InvitationReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UM_RTM_Invite> InvitationAccepted
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

	public event Action<UM_RTM_RoomCreatedResult> RoomCreated
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action RoomUpdated
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<string, byte[]> MatchDataReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public void OpenInvitationUI(int minPlayers, int maxPlayers)
	{
	}

	public void AcceptInvite(UM_RTM_Invite invite)
	{
	}

	public void DeclineInvite(UM_RTM_Invite invite)
	{
	}

	public void FindMatch(int minPlayers, int maxPlayers)
	{
	}

	public void SendDataToAll(byte[] data, UM_RTM_PackageType type)
	{
	}

	public void SendDataToPlayer(byte[] data, UM_RTM_PackageType type, params string[] receivers)
	{
	}

	public void LeaveMatch()
	{
	}

	private void HandleActionRoomUpdated(GP_RTM_Room room)
	{
	}

	private void HandleActionMatchDataReceived(GP_RTM_Network_Package package)
	{
	}

	private void HandleActionRoomCreated(GP_GamesStatusCodes status)
	{
	}

	private void HandleActionPlayerConnected()
	{
	}

	private void HandleActionInvitationReceived(GP_Invite invite)
	{
	}

	private void HandleActionInvitationRemoved(string id)
	{
	}

	private void HandleActionInvitationAccepted(GP_Invite invite)
	{
	}

	private bool TryGetInvitation(string id, out UM_RTM_Invite invite)
	{
		return false;
	}

	private void RemoveInvitation(string id)
	{
	}
}
