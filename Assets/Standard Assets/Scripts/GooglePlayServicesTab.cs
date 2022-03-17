using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GooglePlayServicesTab : FeatureTab
{
	private int score;

	private const string LEADERBOARD_NAME = "leaderboard_best_scores";

	private const string PIE_GIFT_ID = "Pie";

	private const string LEADERBOARD_ID = "CgkIipfs2qcGEAIQAA";

	private const string INCREMENTAL_ACHIEVEMENT_ID = "CgkIipfs2qcGEAIQCg";

	public Image avatar;

	private Sprite defaulttexture;

	private Sprite logo;

	public Texture2D pieIcon;

	public Button connectButton;

	public Text connectButtonLabel;

	public Button scoreSubmit;

	public Text scoreSubmitLabel;

	public Text playerLabel;

	public Button[] ConnectionDependedntButtons;

	public Text a_id;

	public Text a_name;

	public Text a_descr;

	public Text a_type;

	public Text a_state;

	public Text a_steps;

	public Text a_total;

	public Text b_id;

	public Text b_name;

	public Text b_all_time;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void ConncetButtonPress()
	{
	}

	public void GetAccs()
	{
	}

	public void RetrieveToken()
	{
	}

	public void showLeaderBoardsUI()
	{
	}

	public void loadLeaderBoards()
	{
	}

	public void showLeaderBoard()
	{
	}

	public void submitScore()
	{
	}

	public void ResetBoard()
	{
	}

	public void showAchievementsUI()
	{
	}

	public void loadAchievements()
	{
	}

	public void reportAchievement()
	{
	}

	public void incrementAchievement()
	{
	}

	public void revealAchievement()
	{
	}

	public void ResetAchievement()
	{
	}

	public void ResetAllAchievements()
	{
	}

	public void SendGiftRequest()
	{
	}

	public void OpenInbox()
	{
	}

	public void clearDefaultAccount()
	{
	}

	private void FixedUpdate()
	{
	}

	public void RequestAdvertisingId()
	{
	}

	private void ActionAdvertisingIdLoaded(GP_AdvertisingIdLoadResult res)
	{
	}

	private void OnAchievmnetsLoadedInfoListner(GooglePlayResult res)
	{
	}

	private void OnAchievementsLoaded(GooglePlayResult result)
	{
	}

	private void OnAchievementUpdated(GP_AchievementResult result)
	{
	}

	private void OnLeaderBoardsLoaded(GooglePlayResult result)
	{
	}

	private void UpdateBoardInfo()
	{
	}

	private void OnScoreSubmited(GP_LeaderboardResult result)
	{
	}

	private void OnScoreUpdated(GooglePlayResult res)
	{
	}

	private void OnPlayerDisconnected()
	{
	}

	private void OnPlayerConnected()
	{
	}

	private void ActionConnectionResultReceived(GooglePlayConnectionResult result)
	{
	}

	private void OnGiftResult(GooglePlayGiftRequestResult result)
	{
	}

	private void OnPendingGiftsDetected(List<GPGameRequest> gifts)
	{
	}

	private void OnPromtGiftDialogClose(AndroidDialogResult res)
	{
	}

	private void OnGameRequestAccepted(List<GPGameRequest> gifts)
	{
	}

	private void ActionAvailableDeviceAccountsLoaded(List<string> accounts)
	{
	}

	private void SighDialogComplete(AndroidDialogResult res)
	{
	}

	private void ActionOAuthTokenLoaded(string token)
	{
	}
}
