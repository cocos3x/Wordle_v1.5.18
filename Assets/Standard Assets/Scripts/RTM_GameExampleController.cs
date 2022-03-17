using UnityEngine;

public class RTM_GameExampleController : MonoBehaviour
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

	private void HandleMatchDataReceived(string senderId, byte[] data)
	{
	}

	private void HandleRoomCreated(UM_RTM_RoomCreatedResult result)
	{
	}

	private void HandleInvitationAccepted(UM_RTM_Invite invite)
	{
	}

	private void HandleInvitationReceived(UM_RTM_Invite invite)
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

	private void LeaveRoom()
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

	private void OnInvite(GP_Invite invitation)
	{
	}

	private void OnInvDialogComplete(AndroidDialogResult result)
	{
	}

	private void OnInvManageDialogComplete(AndroidDialogResult result)
	{
	}
}
