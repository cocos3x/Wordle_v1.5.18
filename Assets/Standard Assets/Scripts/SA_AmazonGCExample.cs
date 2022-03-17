using System.Collections.Generic;
using UnityEngine;

public class SA_AmazonGCExample : MonoBehaviour
{
	public DefaultPreviewButton[] buttons;

	public SA_Label playerLabel;

	public SA_Label playerID;

	public SA_Label alias;

	private AMN_WWWTextureLoader loader;

	private Texture2D image;

	public GameObject avatar;

	private List<GC_Achievement> achievements;

	private List<GC_Leaderboard> leaderboards;

	private bool isInitialized;

	private long leaderboard_progress;

	private float achieve_progress;

	private string achieve_id;

	private string leaderboard_id;

	private void Start()
	{
	}

	private void OnGUI()
	{
	}

	private void OnInitializeResult(AMN_InitializeResult result)
	{
	}

	private void OnRequestPlayerDataReceived(AMN_RequestPlayerDataResult result)
	{
	}

	private void OnProfileImageLoaded(Texture2D texture)
	{
	}

	private void OnRequestAchievementsReceived(AMN_RequestAchievementsResult result)
	{
	}

	private void OnRequestLeaderboardsReceived(AMN_RequestLeaderboardsResult result)
	{
	}

	private void OnUpdateAchievementReceived(AMN_UpdateAchievementResult result)
	{
	}

	private void OnSubmitLeaderboardReceived(AMN_SubmitLeaderboardResult result)
	{
	}

	private void InitializeAmazon()
	{
	}

	private void DisableButtons()
	{
	}

	private void EnableButtons()
	{
	}

	private void ShowGCOverlay()
	{
	}

	private void ShowSignInPage()
	{
	}

	private void RetrieveLocalPlayer()
	{
	}

	private void ShowAchievementsOverlay()
	{
	}

	private void RequestAchievements()
	{
	}

	private void LoadAvatar(string url)
	{
	}

	private void UpdateAchievementProgress()
	{
	}

	private void ShowLeaderboardsOverlay()
	{
	}

	private void RequestLeaderboards()
	{
	}

	private void SubmitLeaderBoardProgress()
	{
	}
}
