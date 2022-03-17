using UnityEngine;

public class RTM_Game_Example : AndroidNativeExampleBase
{
	public GameObject avatar;

	public GameObject hi;

	public SA_Label playerLabel;

	public SA_Label gameState;

	public SA_Label parisipants;

	public DefaultPreviewButton connectButton;

	public DefaultPreviewButton helloButton;

	public DefaultPreviewButton leaveRoomButton;

	public DefaultPreviewButton showRoomButton;

	public DefaultPreviewButton[] ConnectionDependedntButtons;

	public SA_PartisipantUI[] patricipants;

	public SA_FriendUI[] friends;

	private Texture defaulttexture;

	private string inviteId;

	private void Start()
	{
	}

	private void WaitingUIClosed(AndroidActivityResult result)
	{
	}

	private void ConncetButtonPress()
	{
	}

	private void ShowWatingRoom()
	{
	}

	private void findMatch()
	{
	}

	private void InviteFriends()
	{
	}

	private void SendHello()
	{
	}

	private void LeaveRoomInstance()
	{
	}

	private void DrawParticipants()
	{
	}

	private void UpdateGameState(string msg)
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnPlayerDisconnected()
	{
	}

	private void OnPlayerConnected()
	{
	}

	private void OnFriendListLoaded(GooglePlayResult result)
	{
	}

	private void OnConnectionResult(GooglePlayConnectionResult result)
	{
	}

	private void OnInvite(GP_Invite invitation)
	{
	}

	private void ActionInvitationAccepted(GP_Invite invitation)
	{
	}

	private void OnRoomCreated(GP_GamesStatusCodes code)
	{
	}

	private void OnInvDialogComplete(AndroidDialogResult result)
	{
	}

	private void OnInvManageDialogComplete(AndroidDialogResult result)
	{
	}

	private void OnGCDataReceived(GP_RTM_Network_Package package)
	{
	}
}
