using System;
using System.Collections.Generic;

public class SA_AmazonGameCircleManager : AMN_Singleton<SA_AmazonGameCircleManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<AMN_InitializeResult> _003C_003E9__60_0;

		public static Action<AMN_RequestPlayerDataResult> _003C_003E9__60_1;

		public static Action<AMN_RequestAchievementsResult> _003C_003E9__60_2;

		public static Action<AMN_UpdateAchievementResult> _003C_003E9__60_3;

		public static Action<AMN_RequestLeaderboardsResult> _003C_003E9__60_4;

		public static Action<AMN_SubmitLeaderboardResult> _003C_003E9__60_5;

		public static Action<AMN_LocalPlayerScoreLoadedResult> _003C_003E9__60_6;

		public static Action<AMN_ScoresLoadedResult> _003C_003E9__60_7;

		internal void _003C_002Ector_003Eb__60_0(AMN_InitializeResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__60_1(AMN_RequestPlayerDataResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__60_2(AMN_RequestAchievementsResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__60_3(AMN_UpdateAchievementResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__60_4(AMN_RequestLeaderboardsResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__60_5(AMN_SubmitLeaderboardResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__60_6(AMN_LocalPlayerScoreLoadedResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__60_7(AMN_ScoresLoadedResult _003Cp0_003E)
		{
		}
	}

	private GC_Player _player;

	private Dictionary<string, GC_Player> _Players;

	private bool _isInitialized;

	public bool IsInitialized => false;

	public GC_Player Player
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<string, GC_Player> Players => null;

	public List<GC_Achievement> Achievements => null;

	public List<GC_Leaderboard> Leaderboards => null;

	public event Action<AMN_InitializeResult> OnInitializeResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AMN_RequestPlayerDataResult> OnRequestPlayerDataReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AMN_RequestAchievementsResult> OnRequestAchievementsReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AMN_UpdateAchievementResult> OnUpdateAchievementReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AMN_RequestLeaderboardsResult> OnRequestLeaderboardsReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AMN_SubmitLeaderboardResult> OnSubmitLeaderboardReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AMN_LocalPlayerScoreLoadedResult> OnLocalPlayerScoreLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AMN_ScoresLoadedResult> OnScoresLoaded
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

	private void OnServiceConnected()
	{
	}

	private void OnServiceDisconnected(string error)
	{
	}

	public void Connect()
	{
	}

	public void Disconnect()
	{
	}

	public void ShowGCOverlay()
	{
	}

	public void ShowSignInPage()
	{
	}

	public void RetrieveLocalPlayer()
	{
	}

	public void ShowAchievementsOverlay()
	{
	}

	public void RequestAchievements()
	{
	}

	public GC_Achievement GetAchievement(string id)
	{
		return null;
	}

	public void UpdateAchievementProgress(string achieve_id, float score)
	{
	}

	public void ShowLeaderboardsOverlay()
	{
	}

	public void RequestLeaderboards()
	{
	}

	public void SubmitLeaderBoardProgress(string leaderBId, long score)
	{
	}

	public GC_Leaderboard GetLeaderboard(string id)
	{
		return null;
	}

	public void LoadLocalPlayerScores(string id, GC_ScoreTimeSpan timeSpan)
	{
	}

	public void LoadTopScores(string id, GC_ScoreTimeSpan timeSpan)
	{
	}

	public void AddPlayer(GC_Player player)
	{
	}

	public GC_Player GetPlayerById(string id)
	{
		return null;
	}

	private void Init()
	{
	}

	private void SubscribeToEvents()
	{
	}
}
