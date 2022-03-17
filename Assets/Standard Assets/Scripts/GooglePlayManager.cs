using SA.Common.Pattern;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GooglePlayManager : Singleton<GooglePlayManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__125_0(GP_LeaderboardResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__125_1(GP_LeaderboardResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__125_2(GooglePlayResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__125_3(GP_AchievementResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__125_4(GooglePlayResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__125_5(GooglePlayResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__125_6(GooglePlayGiftRequestResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__125_7()
		{
		}

		internal void _003C_002Ecctor_003Eb__125_8(List<GPGameRequest> _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__125_9(List<GPGameRequest> _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__125_10(List<string> _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__125_11(string _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__125_12(GooglePlayResult _003Cp0_003E, string _003Cp1_003E)
		{
		}
	}

	private GooglePlayerTemplate _player;

	private Dictionary<string, GooglePlayerTemplate> _players;

	private List<string> _friendsList;

	private List<string> _deviceGoogleAccountList;

	private List<GPGameRequest> _gameRequests;

	private string _loadedAuthToken;

	private string _currentAccount;

	private static bool _IsLeaderboardsDataLoaded;

	public string currentAccount => "";

	public GooglePlayerTemplate player => null;

	public Dictionary<string, GooglePlayerTemplate> players => null;

	public List<GPLeaderBoard> LeaderBoards => null;

	public List<GPAchievement> Achievements => null;

	public List<string> friendsList => null;

	public List<GPGameRequest> gameRequests => null;

	public List<string> deviceGoogleAccountList => null;

	public string loadedAuthToken => "";

	public static bool IsLeaderboardsDataLoaded => false;

	public static event Action<GP_LeaderboardResult> ActionScoreSubmited
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_LeaderboardResult> ActionScoresListLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GooglePlayResult> ActionLeaderboardsLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_AchievementResult> ActionAchievementUpdated
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GooglePlayResult> ActionFriendsListLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GooglePlayResult> ActionAchievementsLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GooglePlayGiftRequestResult> ActionSendGiftResultReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action ActionRequestsInboxDialogDismissed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<List<GPGameRequest>> ActionPendingGameRequestsDetected
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<List<GPGameRequest>> ActionGameRequestsAccepted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<List<string>> ActionAvailableDeviceAccountsLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string> ActionOAuthTokenLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GooglePlayResult, string> ActionServerAuthCodeLoaded
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

	public void Create()
	{
	}

	public GP_PlayServicesStatus GetPlayServicesStatus()
	{
		//IL_0003: Expected I4, but got O
		return (GP_PlayServicesStatus)null;
	}

	public void RetrieveDeviceGoogleAccounts()
	{
	}

	public void LoadToken(string accountName, string scopes)
	{
	}

	public void LoadToken()
	{
	}

	public void GetGamesServerAuthCode(string webClientAppId)
	{
	}

	public void InvalidateToken(string token)
	{
	}

	public void ShowAchievementsUI()
	{
	}

	public void ShowLeaderBoardsUI()
	{
	}

	public void ShowLeaderBoard(string leaderboardName)
	{
	}

	public void ShowLeaderBoardById(string leaderboardId)
	{
	}

	public void SubmitScore(string leaderboardName, long score, string tag = "")
	{
	}

	public void SubmitScoreById(string leaderboardId, long score, string tag = "")
	{
	}

	public void LoadLeaderBoards()
	{
	}

	public void UpdatePlayerScoreLocal(GPLeaderBoard leaderboard)
	{
	}

	public void LoadPlayerCenteredScores(string leaderboardId, GPBoardTimeSpan span, GPCollectionType collection, int maxResults)
	{
	}

	public void LoadTopScores(string leaderboardId, GPBoardTimeSpan span, GPCollectionType collection, int maxResults)
	{
	}

	public void UnlockAchievement(string achievementName)
	{
	}

	public void UnlockAchievementById(string achievementId)
	{
	}

	public void RevealAchievement(string achievementName)
	{
	}

	public void RevealAchievementById(string achievementId)
	{
	}

	public void IncrementAchievement(string achievementName, int numsteps)
	{
	}

	public void IncrementAchievementById(string achievementId, int numsteps)
	{
	}

	public void SetStepsImmediate(string achievementId, int numsteps)
	{
	}

	public void LoadAchievements()
	{
	}

	public void ResetAchievement(string achievementId)
	{
	}

	public void ResetAllAchievements()
	{
	}

	public void ResetLeaderBoard(string leaderboardId)
	{
	}

	public void LoadFriends()
	{
	}

	public void SendGiftRequest(GPGameRequestType type, int requestLifetimeDays, Texture2D icon, string description, string playload = "")
	{
	}

	public void ShowRequestsAccepDialog()
	{
	}

	public void AcceptRequests(params string[] ids)
	{
	}

	public void DismissRequest(params string[] ids)
	{
	}

	public void DispatchLeaderboardUpdateEvent(GP_LeaderboardResult result)
	{
	}

	public GPLeaderBoard GetLeaderBoard(string leaderboardId)
	{
		return null;
	}

	public GPAchievement GetAchievement(string achievementId)
	{
		return null;
	}

	public GooglePlayerTemplate GetPlayerById(string playerId)
	{
		return null;
	}

	public GPGameRequest GetGameRequestById(string id)
	{
		return null;
	}

	private void OnGiftSendResult(string data)
	{
	}

	private void OnRequestsInboxDialogDismissed(string data)
	{
	}

	private void OnAchievementsLoaded(string data)
	{
	}

	private void OnAchievementUpdated(string data)
	{
	}

	private void OnScoreDataRecevied(string data)
	{
	}

	private void OnLeaderboardDataLoaded(string data)
	{
	}

	private void OnPlayerScoreUpdated(string data)
	{
	}

	private void OnScoreSubmitted(string data)
	{
	}

	private void OnPlayerDataLoaded(string data)
	{
	}

	private void OnPlayersLoaded(string data)
	{
	}

	private void OnGameRequestsLoaded(string data)
	{
	}

	private void OnGameRequestsAccepted(string data)
	{
	}

	private void OnAccountsLoaded(string data)
	{
	}

	private void OnTokenLoaded(string token)
	{
	}

	private void OnGamesServerAuthCodeLoaded(string data)
	{
	}

	public static GP_Participant ParseParticipanData(string[] data, int index)
	{
		return null;
	}

	public static List<GP_Participant> ParseParticipantsData(string[] data, int index)
	{
		return null;
	}

	private void AddPlayer(GooglePlayerTemplate p)
	{
	}
}
