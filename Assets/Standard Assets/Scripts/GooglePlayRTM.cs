using SA.Common.Pattern;
using System;
using System.Collections.Generic;

public class GooglePlayRTM : Singleton<GooglePlayRTM>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__127_0(GP_RTM_Network_Package _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_1(GP_RTM_Room _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_2(GP_RTM_ReliableMessageSentResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_3(GP_RTM_ReliableMessageDeliveredResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_4()
		{
		}

		internal void _003C_002Ecctor_003Eb__127_5()
		{
		}

		internal void _003C_002Ecctor_003Eb__127_6(string _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_7(string _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_8(string[] _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_9(string[] _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_10(string[] _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_11(string[] _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_12(string[] _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_13(string[] _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_14()
		{
		}

		internal void _003C_002Ecctor_003Eb__127_15()
		{
		}

		internal void _003C_002Ecctor_003Eb__127_16(GP_GamesStatusCodes _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_17(GP_RTM_Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_18(GP_GamesStatusCodes _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_19(GP_GamesStatusCodes _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_20(AndroidActivityResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_21(AndroidActivityResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_22(GP_Invite _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_23(GP_Invite _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__127_24(string _003Cp0_003E)
		{
		}
	}

	private const int BYTE_LIMIT = 256;

	private GP_RTM_Room _currentRoom;

	private List<GP_Invite> _invitations;

	private Dictionary<int, GP_RTM_ReliableMessageListener> _ReliableMassageListeners;

	public GP_RTM_Room currentRoom => null;

	public List<GP_Invite> invitations => null;

	public static event Action<GP_RTM_Network_Package> ActionDataRecieved
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_RTM_Room> ActionRoomUpdated
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_RTM_ReliableMessageSentResult> ActionReliableMessageSent
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_RTM_ReliableMessageDeliveredResult> ActionReliableMessageDelivered
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action ActionConnectedToRoom
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action ActionDisconnectedFromRoom
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string> ActionP2PConnected
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string> ActionP2PDisconnected
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string[]> ActionPeerDeclined
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string[]> ActionPeerInvitedToRoom
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string[]> ActionPeerJoined
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string[]> ActionPeerLeft
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string[]> ActionPeersConnected
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string[]> ActionPeersDisconnected
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action ActionRoomAutomatching
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action ActionRoomConnecting
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_GamesStatusCodes> ActionJoinedRoom
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_RTM_Result> ActionLeftRoom
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_GamesStatusCodes> ActionRoomConnected
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_GamesStatusCodes> ActionRoomCreated
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<AndroidActivityResult> ActionInvitationBoxUIClosed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<AndroidActivityResult> ActionWatingRoomIntentClosed
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

	public static event Action<GP_Invite> ActionInvitationReceived
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

	public void FindMatch(int minPlayers, int maxPlayers)
	{
	}

	public void FindMatch(int minPlayers, int maxPlayers, params GooglePlayerTemplate[] playersToInvite)
	{
	}

	public void FindMatch(int minPlayers, int maxPlayers, params string[] playersToInvite)
	{
	}

	public void FindMatch(GooglePlayerTemplate[] playersToInvite)
	{
	}

	public void FindMatch(string[] playersToInvite)
	{
	}

	public void SendDataToAll(byte[] data, GP_RTM_PackageType sendType)
	{
	}

	public void SendDataToPlayers(byte[] data, GP_RTM_PackageType sendType, params string[] players)
	{
	}

	public void ShowWaitingRoomIntent()
	{
	}

	public void OpenInvitationBoxUI(int minPlayers, int maxPlayers)
	{
	}

	public void LeaveRoom()
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

	public void OpenInvitationInBoxUI()
	{
	}

	public void SetVariant(int val)
	{
	}

	public void SetExclusiveBitMask(int val)
	{
	}

	public void ClearReliableMessageListener(int dataTokenId)
	{
	}

	private void OnWatingRoomIntentClosed(string data)
	{
	}

	private void OnRoomUpdate(string data)
	{
	}

	private void OnReliableMessageSent(string data)
	{
	}

	private void OnReliableMessageDelivered(string data)
	{
	}

	private void OnMatchDataRecieved(string data)
	{
	}

	private void OnConnectedToRoom(string data)
	{
	}

	private void OnDisconnectedFromRoom(string data)
	{
	}

	private void OnP2PConnected(string participantId)
	{
	}

	private void OnP2PDisconnected(string participantId)
	{
	}

	private void OnPeerDeclined(string data)
	{
	}

	private void OnPeerInvitedToRoom(string data)
	{
	}

	private void OnPeerJoined(string data)
	{
	}

	private void OnPeerLeft(string data)
	{
	}

	private void OnPeersConnected(string data)
	{
	}

	private void OnPeersDisconnected(string data)
	{
	}

	private void OnRoomAutoMatching(string data)
	{
	}

	private void OnRoomConnecting(string data)
	{
	}

	private void OnJoinedRoom(string data)
	{
	}

	private void OnLeftRoom(string data)
	{
	}

	private void OnRoomConnected(string data)
	{
	}

	private void OnRoomCreated(string data)
	{
	}

	private void OnInvitationBoxUiClosed(string data)
	{
	}

	private void OnInvitationReceived(GP_Invite inv)
	{
	}

	private void OnInvitationRemoved(string invitationId)
	{
	}

	private void OnInvitationAccepted(GP_Invite inv)
	{
	}
}
