using UnityEngine;
using UnityEngine.UI;

public class LeaderboardsUITab : FeatureTab
{
	private const string LEADERBOARD_ID = "CgkIipfs2qcGEAIQAA";

	public Image avatar;

	private Sprite defaulttexture;

	private Sprite logo;

	public Button connectButton;

	public Text connectButtonLabel;

	public Text playerLabel;

	public Toggle GlobalButton;

	public Toggle FriendsButton;

	public Toggle AllTimeButton;

	public Toggle WeekButton;

	public Toggle TodayButton;

	public Button SubmitScoreButton;

	public Text SubmitScoreLabel;

	public Selectable[] ConnectionDependedntButtons;

	public LeaderboardInfoPresenter[] lines;

	private GPLeaderBoard loadedLeaderBoard;

	private GPCollectionType displayCollection;

	private GPBoardTimeSpan displayTime;

	private int score;

	private void Start()
	{
	}

	public void LoadScore()
	{
	}

	public void OpenUI()
	{
	}

	public void ShowGlobal()
	{
	}

	public void ShowLocal()
	{
	}

	public void ShowAllTime()
	{
	}

	public void ShowWeek()
	{
	}

	public void ShowDay()
	{
	}

	public void ConncetButtonPress()
	{
	}

	private void UpdateScoresDisaplay()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SubmitScore()
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

	private void ActionScoreRequestReceived(GooglePlayResult obj)
	{
	}

	private void OnScoreSbumitted(GP_LeaderboardResult result)
	{
	}

	private void OnDestroy()
	{
	}

	private void _003CStart_003Eb__20_0(bool b)
	{
	}

	private void _003CStart_003Eb__20_1(bool b)
	{
	}

	private void _003CStart_003Eb__20_2(bool b)
	{
	}

	private void _003CStart_003Eb__20_3(bool b)
	{
	}

	private void _003CStart_003Eb__20_4(bool b)
	{
	}
}
