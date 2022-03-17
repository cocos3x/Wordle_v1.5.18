using UnityEngine;
using UnityEngine.UI;

public class RealTimeMultiplayerTab : FeatureTab
{
	public Image avatar;

	private Sprite defaulttexture;

	private Sprite logo;

	public GameObject hi;

	public Text playerLabel;

	public Text gameState;

	public Text parisipants;

	public Button connectButton;

	public Text connectButtonLabel;

	public Button helloButton;

	public Button leaveRoomButton;

	public Button showRoomButton;

	public Button[] ConnectionDependedntButtons;

	public ParticipantPresenter[] patricipants;

	public FriendPresenter[] friends;

	private string inviteId;

	private void Start()
	{
	}

	private void WaitingUIClosed(AndroidActivityResult result)
	{
	}

	public void ConncetButtonPress()
	{
	}

	public void ShowWatingRoom()
	{
	}

	public void findMatch()
	{
	}

	public void InviteFriends()
	{
	}

	public void SendHello()
	{
	}

	public void LeaveRoomInstance()
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
