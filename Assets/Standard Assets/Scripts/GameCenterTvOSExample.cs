using SA.Common.Models;
using System;
using UnityEngine;

public class GameCenterTvOSExample : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<Result> _003C_003E9__11_0;

		internal void _003CShowLeaderboardByID_003Eb__11_0(Result obj)
		{
		}
	}

	private int hiScore;

	private bool _IsUILocked;

	private string TEST_LEADERBOARD_1;

	private string TEST_ACHIEVEMENT_1_ID;

	private string TEST_ACHIEVEMENT_2_ID;

	private void Start()
	{
	}

	private void OnAuthFinished(Result res)
	{
	}

	public void ShowAchivemnets()
	{
	}

	public void SubmitAchievement()
	{
	}

	public void ResetAchievements()
	{
	}

	public void ShowLeaderboards()
	{
	}

	public void ShowLeaderboardByID()
	{
	}

	public void ReportScore()
	{
	}

	private void OnScoreSubmitted(GK_LeaderboardResult result)
	{
	}

	private void OnAchievementsLoaded(Result result)
	{
	}

	private void HandleOnAchievementsReset(Result obj)
	{
	}

	private void HandleOnAchievementsProgress(GK_AchievementProgressResult result)
	{
	}

	private void GameCenterManager_OnGameCenterViewDismissed()
	{
	}

	private void _003COnAuthFinished_003Eb__6_0()
	{
	}
}
