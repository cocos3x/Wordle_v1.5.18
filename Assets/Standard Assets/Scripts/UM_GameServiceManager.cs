using SA.Common.Models;
using SA.Common.Pattern;
using System;
using System.Collections.Generic;

public class UM_GameServiceManager : Singleton<UM_GameServiceManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__114_0()
		{
		}

		internal void _003C_002Ecctor_003Eb__114_1()
		{
		}

		internal void _003C_002Ecctor_003Eb__114_2(UM_ConnectionState _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__114_3(UM_LeaderboardResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__114_4(UM_LeaderboardResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__114_5(UM_Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__114_6(UM_Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__114_7(UM_Result _003Cp0_003E)
		{
		}
	}

	private bool _IsInitedCalled;

	private bool _IsDataLoaded;

	private int _DataEventsCount;

	private int _CurrentEventsCount;

	private UM_Player _Player;

	private UM_ConnectionState _ConnectionSate;

	private static List<string> _FriendsList;

	private bool _WaitingForLeaderboardsData;

	private int _LeaderboardsDataEventsCount;

	private int _CurrentLeaderboardsEventsCount;

	public List<string> FriendsList => null;

	public UM_ConnectionState ConnectionSate => (UM_ConnectionState)null;

	public bool IsConnected => false;

	public UM_Player player => null;

	public UM_Player Player => null;

	public static event Action OnPlayerConnected
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnPlayerDisconnected
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<UM_ConnectionState> OnConnectionStateChnaged
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<UM_LeaderboardResult> ActionScoreSubmitted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<UM_LeaderboardResult> ActionScoresListLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<UM_Result> ActionFriendsListLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<UM_Result> ActionAchievementsInfoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<UM_Result> ActionLeaderboardsInfoLoaded
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

	private void Init()
	{
	}

	public void Connect()
	{
	}

	public void Disconnect()
	{
	}

	public void LoadFriends()
	{
	}

	public bool IsParticipantFriend(UM_TBM_Participant playerParticipant)
	{
		return false;
	}

	public UM_Player GetPlayer(string playerId)
	{
		return null;
	}

	public void LoadAchievementsInfo()
	{
	}

	public void ShowAchievementsUI()
	{
	}

	public void RevealAchievement(string id)
	{
	}

	public void RevealAchievement(UM_Achievement achievement)
	{
	}

	public void ReportAchievement(string id)
	{
	}

	public void ReportAchievement(UM_Achievement achievement)
	{
	}

	public void UnlockAchievement(string id)
	{
	}

	private void UnlockAchievement(UM_Achievement achievement)
	{
	}

	public void IncrementAchievement(string id, float percentages)
	{
	}

	public void IncrementAchievement(UM_Achievement achievement, float percentages)
	{
	}

	public void IncrementAchievementByCurrentSteps(string id, int steps)
	{
	}

	public void IncrementAchievementByCurrentSteps(UM_Achievement achievement, int steps)
	{
	}

	public void ResetAchievements()
	{
	}

	public float GetAchievementProgress(string id)
	{
		return 0f;
	}

	public float GetAchievementProgress(UM_Achievement achievement)
	{
		return 0f;
	}

	public int GetAchievementProgressInSteps(string id)
	{
		return 0;
	}

	public int GetAchievementProgressInSteps(UM_Achievement achievement)
	{
		return 0;
	}

	public void LoadLeaderboardsInfo()
	{
	}

	public UM_Leaderboard GetLeaderboard(string leaderboardId)
	{
		return null;
	}

	public void ShowLeaderBoardsUI()
	{
	}

	public void ShowLeaderBoardUI(string id)
	{
	}

	public void ShowLeaderBoardUI(UM_Leaderboard leaderboard)
	{
	}

	public void SubmitScore(string LeaderboardId, long score, long context = 0L)
	{
	}

	public void SubmitScore(UM_Leaderboard leaderboard, long score, long context = 0L)
	{
	}

	public UM_Score GetCurrentPlayerScore(string leaderBoardId, UM_TimeSpan timeSpan = UM_TimeSpan.ALL_TIME, UM_CollectionType collection = UM_CollectionType.GLOBAL)
	{
		return null;
	}

	public UM_Score GetCurrentPlayerScore(UM_Leaderboard leaderboard, UM_TimeSpan timeSpan = UM_TimeSpan.ALL_TIME, UM_CollectionType collection = UM_CollectionType.GLOBAL)
	{
		return null;
	}

	public void LoadPlayerCenteredScores(string leaderboardId, int maxResults, UM_TimeSpan timeSpan = UM_TimeSpan.ALL_TIME, UM_CollectionType collection = UM_CollectionType.GLOBAL)
	{
	}

	public void LoadPlayerCenteredScores(UM_Leaderboard leaderboard, int maxResults, UM_TimeSpan timeSpan = UM_TimeSpan.ALL_TIME, UM_CollectionType collection = UM_CollectionType.GLOBAL)
	{
	}

	public void LoadTopScores(string leaderboardId, int maxResults, UM_TimeSpan timeSpan = UM_TimeSpan.ALL_TIME, UM_CollectionType collection = UM_CollectionType.GLOBAL)
	{
	}

	public void LoadTopScores(UM_Leaderboard leaderboard, int maxResults, UM_TimeSpan timeSpan = UM_TimeSpan.ALL_TIME, UM_CollectionType collection = UM_CollectionType.GLOBAL)
	{
	}

	private void OnServiceConnected()
	{
	}

	private void OnGooglePlayServiceDataLoaded(GooglePlayResult result)
	{
	}

	private void OnGooglePlayLeaderDataLoaded(GooglePlayResult res)
	{
	}

	private void OnGameCenterServiceDataLoaded(Result e)
	{
	}

	private void OnGameCenterServiceLeaderDataLoaded(GK_LeaderboardResult res)
	{
	}

	private void OnAllLoaded()
	{
	}

	private void OnAchievementsDataLoaded(UM_Result result)
	{
	}

	private void OnLeaderboardsDataLoaded(UM_Result result)
	{
	}

	private void OnAuthFinished(Result res)
	{
	}

	private void IOS_HandleOnScoreSubmitted(GK_LeaderboardResult res)
	{
	}

	private void IOS_HandleOnScoresListLoaded(GK_LeaderboardResult res)
	{
	}

	private void IOS_OnFriendsListLoaded(Result res)
	{
	}

	private void IOS_AchievementsDataLoaded(Result res)
	{
	}

	private void IOS_LeaderboardsDataLoaded(GK_LeaderboardResult res)
	{
	}

	private void OnAndroidPlayerConnected()
	{
	}

	private void OnAndroidPlayerDisconnected()
	{
	}

	private void Android_HandleActionScoresListLoaded(GP_LeaderboardResult res)
	{
	}

	private void Android_HandleActionScoreSubmited(GP_LeaderboardResult res)
	{
	}

	private void Android_ActionFriendsListLoaded(GooglePlayResult res)
	{
	}

	private void Android_AchievementsDataLoaded(GooglePlayResult res)
	{
	}

	private void Android_LeaderboardsDataLoaded(GooglePlayResult res)
	{
	}

	private void OnAmazonInitializeResult(AMN_InitializeResult result)
	{
	}

	private void OnAmazonRequestPlayerDataReceived(AMN_RequestPlayerDataResult result)
	{
	}

	private void OnAmazonGameCircleRequestLeaderboardsReceived(AMN_RequestLeaderboardsResult result)
	{
	}

	private void OnAmazonLocalPlayerScoreLoaded(AMN_LocalPlayerScoreLoadedResult result)
	{
	}

	private void OnAmazonGameCircleRequestAchievementsReceived(AMN_RequestAchievementsResult result)
	{
	}

	private void OnAmazonRequestAchievementsReceived(AMN_RequestAchievementsResult result)
	{
	}

	private void OnAmazonRequestLeaderboardsReceived(AMN_RequestLeaderboardsResult result)
	{
	}

	private void OnAmazonSubmitLeaderboardReceived(AMN_SubmitLeaderboardResult result)
	{
	}

	private void OnAmazonScoresLoaded(AMN_ScoresLoadedResult result)
	{
	}

	private void SetConnectionState(UM_ConnectionState NewState)
	{
	}

	private void SetFriendList(List<string> friendsIds)
	{
	}
}
