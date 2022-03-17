using UnityEngine;
using UnityEngine.UI;

public class QuestsAndEventsTab : FeatureTab
{
	public Image avatar;

	private Sprite logo;

	private Sprite defaulttexture;

	public Texture2D pieIcon;

	public Button connectButton;

	public Text connectButtonText;

	public Text playerLabel;

	public Button[] ConnectionDependedntButtons;

	private const string EVENT_ID = "CgkIipfs2qcGEAIQDQ";

	private const string QUEST_ID = "CgkIipfs2qcGEAIQDg";

	private void Start()
	{
	}

	public void ConncetButtonPress()
	{
	}

	private void FixedUpdate()
	{
	}

	public void LoadEvents()
	{
	}

	public void IncrementEvent()
	{
	}

	public void ShowAllQuests()
	{
	}

	public void ShowAcceptedQuests()
	{
	}

	public void ShowCompletedQuests()
	{
	}

	public void ShowOpenQuests()
	{
	}

	public void AcceptQuest()
	{
	}

	public void LoadQuests()
	{
	}

	private void OnEventsLoaded(GooglePlayResult result)
	{
	}

	private void OnQuestsAccepted(GP_QuestResult result)
	{
	}

	private void OnQuestsCompleted(GP_QuestResult result)
	{
	}

	private void OnQuestsLoaded(GooglePlayResult result)
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

	private void OnDestroy()
	{
	}
}
