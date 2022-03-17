using UnityEngine;

public class TBM_Game_Example : AndroidNativeExampleBase
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

	public SA_PartisipantUI[] patrisipants;

	private GP_TBM_Match mMatch;

	private void Start()
	{
	}

	public void Init()
	{
	}

	public void playTurn()
	{
	}

	private void ActionMatchUpdated(GP_TBM_UpdateMatchResult result)
	{
	}

	public void InitTBM()
	{
	}

	public void ShowInboxUI()
	{
	}

	public void FinishMathc()
	{
	}

	public void findMatch()
	{
	}

	private void ActionMatchCreationCanceled(AndroidActivityResult result)
	{
	}

	private void ActionMatchInitiated(GP_TBM_MatchInitiatedResult result)
	{
	}

	public void LoadAllMatchersInfo()
	{
	}

	public void LoadActiveMatchesInfo()
	{
	}

	private void ConncetButtonPress()
	{
	}

	private void DrawParticipants()
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

	private void OnConnectionResult(GooglePlayConnectionResult result)
	{
	}
}
