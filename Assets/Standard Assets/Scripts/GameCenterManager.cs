using SA.Common.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameCenterManager : MonoBehaviour
{
	private sealed class _003CLoadLeaderboardInfoLocal_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLoadLeaderboardInfoLocal_003Ed__61(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__136_0(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__136_1(GK_LeaderboardResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__136_2(GK_LeaderboardResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__136_3(GK_LeaderboardResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__136_4(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__136_5(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__136_6(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__136_7(GK_AchievementProgressResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__136_8()
		{
		}

		internal void _003C_002Ecctor_003Eb__136_9(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__136_10(GK_UserInfoLoadResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__136_11(GK_PlayerSignatureResult _003Cp0_003E)
		{
		}
	}

	private static bool _IsInitialized;

	private static bool _IsAchievementsInfoLoaded;

	private static Dictionary<string, GK_Player> _players;

	private static List<string> _friendsList;

	private static List<GK_LeaderboardSet> _LeaderboardSets;

	private static Dictionary<int, GK_FriendRequest> _FriendRequests;

	private static GK_Player _player;

	private const string ISN_GC_PP_KEY = "ISN_GameCenterManager";

	public static List<GK_AchievementTemplate> Achievements => null;

	public static List<GK_Leaderboard> Leaderboards => null;

	public static Dictionary<string, GK_Player> Players => null;

	public static GK_Player Player => null;

	public static bool IsInitialized => false;

	public static List<GK_LeaderboardSet> LeaderboardSets => null;

	public static bool IsPlayerAuthenticated => false;

	public static bool IsAchievementsInfoLoaded => false;

	public static List<string> FriendsList => null;

	public static bool IsPlayerUnderage => false;

	public static event Action<Result> OnAuthFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_LeaderboardResult> OnScoreSubmitted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_LeaderboardResult> OnScoresListLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_LeaderboardResult> OnLeadrboardInfoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Result> OnLeaderboardSetsInfoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Result> OnAchievementsReset
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Result> OnAchievementsLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_AchievementProgressResult> OnAchievementsProgress
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnGameCenterViewDismissed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Result> OnFriendsListLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_UserInfoLoadResult> OnUserInfoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_PlayerSignatureResult> OnPlayerSignatureRetrieveResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void init()
	{
	}

	public static void Init()
	{
	}

	public static void RetrievePlayerSignature()
	{
	}

	public static void ShowGmaeKitNotification(string title, string message)
	{
	}

	public static void RegisterAchievement(string achievementId)
	{
	}

	public static void RegisterAchievement(GK_AchievementTemplate achievement)
	{
	}

	public static void ShowLeaderboard(string leaderboardId)
	{
	}

	public static void ShowLeaderboard(string leaderboardId, GK_TimeSpan timeSpan)
	{
	}

	public static void ShowLeaderboards()
	{
	}

	public static void ReportScore(long score, string leaderboardId, long context = 0L)
	{
	}

	public static void ReportScore(double score, string leaderboardId)
	{
	}

	public static void RetrieveFriends()
	{
	}

	public static void LoadUsersData(string[] UIDs)
	{
	}

	public static void LoadGKPlayerInfo(string playerId)
	{
	}

	public static void LoadGKPlayerPhoto(string playerId, GK_PhotoSize size)
	{
	}

	public static void LoadCurrentPlayerScore(string leaderboardId, GK_TimeSpan timeSpan = GK_TimeSpan.ALL_TIME, GK_CollectionType collection = GK_CollectionType.GLOBAL)
	{
	}

	public static void LoadLeaderboardInfo(string leaderboardId)
	{
	}

	private IEnumerator LoadLeaderboardInfoLocal(string leaderboardId)
	{
		return null;
	}

	public static void LoadScore(string leaderboardId, int startIndex, int length, GK_TimeSpan timeSpan = GK_TimeSpan.ALL_TIME, GK_CollectionType collection = GK_CollectionType.GLOBAL)
	{
	}

	public static void IssueLeaderboardChallenge(string leaderboardId, string message, string playerId)
	{
	}

	public static void IssueLeaderboardChallenge(string leaderboardId, string message, string[] playerIds)
	{
	}

	public static void IssueLeaderboardChallenge(string leaderboardId, string message)
	{
	}

	public static void IssueAchievementChallenge(string achievementId, string message, string playerId)
	{
	}

	public static void LoadLeaderboardSetInfo()
	{
	}

	public static void LoadLeaderboardsForSet(string setId)
	{
	}

	public static void LoadAchievements()
	{
	}

	public static void IssueAchievementChallenge(string achievementId, string message, string[] playerIds)
	{
	}

	public static void IssueAchievementChallenge(string achievementId, string message)
	{
	}

	public static void ShowAchievements()
	{
	}

	public static void ResetAchievements()
	{
	}

	public static void SubmitAchievement(float percent, string achievementId)
	{
	}

	public static void SubmitAchievementNoCache(float percent, string achievementId)
	{
	}

	public static void SubmitAchievement(float percent, string achievementId, bool isCompleteNotification)
	{
	}

	public static float GetAchievementProgress(string id)
	{
		return 0f;
	}

	public static GK_AchievementTemplate GetAchievement(string achievementId)
	{
		return null;
	}

	public static GK_Leaderboard GetLeaderboard(string id)
	{
		return null;
	}

	public static GK_Player GetPlayerById(string playerID)
	{
		return null;
	}

	public static void SendFriendRequest(GK_FriendRequest request, List<string> emails, List<string> players)
	{
	}

	private void OnLoaderBoardInfoRetrivedFail(string data)
	{
	}

	private void OnLoaderBoardInfoRetrived(string data)
	{
	}

	public void onScoreSubmittedEvent(string data)
	{
	}

	public void onScoreSubmittedFailed(string data)
	{
	}

	private void OnLeaderboardScoreListLoaded(string data)
	{
	}

	private void OnLeaderboardScoreListLoadFailed(string data)
	{
	}

	private void onAchievementsReset(string array)
	{
	}

	private void onAchievementsResetFailed(string errorData)
	{
	}

	private void onAchievementProgressChanged(string array)
	{
	}

	private void onAchievementsLoaded(string array)
	{
	}

	private void onAchievementsLoadedFailed(string errorData)
	{
	}

	private void onAuthenticateLocalPlayer(string array)
	{
	}

	private void onAuthenticationFailed(string errorData)
	{
	}

	private void OnUserInfoLoadedEvent(string array)
	{
	}

	private void OnUserInfoLoadFailedEvent(string playerId)
	{
	}

	private void OnUserPhotoLoadedEvent(string array)
	{
	}

	private void OnUserPhotoLoadFailedEvent(string data)
	{
	}

	private void OnFriendListLoadedEvent(string data)
	{
	}

	private void OnFriendListLoadFailEvent(string errorData)
	{
	}

	private void OnGameCenterViewDismissedEvent(string data)
	{
	}

	private void VerificationSignatureRetrieveFailed(string array)
	{
	}

	private void VerificationSignatureRetrieved(string array)
	{
	}

	private void SaveLocalProgress(GK_AchievementTemplate tpl)
	{
	}

	private static void ResetStoredProgress()
	{
	}

	private static void SaveAchievementProgress(string achievementId, float progress)
	{
	}

	private static float GetStoredAchievementProgress(string achievementId)
	{
		return 0f;
	}

	private void ISN_OnLBSetsLoaded(string array)
	{
	}

	private void ISN_OnLBSetsLoadFailed(string array)
	{
	}

	private void ISN_OnLBSetsBoardsLoadFailed(string identifier)
	{
	}

	private void ISN_OnLBSetsBoardsLoaded(string array)
	{
	}

	public static void DispatchLeaderboardUpdateEvent(GK_LeaderboardResult result, bool isInternal)
	{
	}

	public static List<GK_TBM_Participant> ParseParticipantsData(string[] data, int index)
	{
		return null;
	}

	public static GK_TBM_Participant ParseParticipanData(string[] data, int index)
	{
		return null;
	}
}
