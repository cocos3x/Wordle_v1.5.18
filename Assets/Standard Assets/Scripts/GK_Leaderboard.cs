using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GK_Leaderboard
{
	public bool IsOpen;

	private bool _CurrentPlayerScoreLoaded;

	public GK_ScoreCollection SocsialCollection;

	public GK_ScoreCollection GlobalCollection;

	private List<GK_Score> CurrentPlayerScore;

	private Dictionary<int, GK_LocalPlayerScoreUpdateListener> ScoreUpdateListners;

	[SerializeField]
	private GK_LeaderBoardInfo _info;

	public GK_LeaderBoardInfo Info => null;

	public string Id => "";

	public bool CurrentPlayerScoreLoaded => false;

	public string id => "";

	public GK_Leaderboard(string leaderboardId)
	{
	}

	public void Refresh()
	{
	}

	public GK_Score GetCurrentPlayerScore(GK_TimeSpan timeSpan, GK_CollectionType collection)
	{
		return null;
	}

	public GK_Score GetScoreByPlayerId(string playerId, GK_TimeSpan timeSpan, GK_CollectionType collection)
	{
		return null;
	}

	public List<GK_Score> GetScoresList(GK_TimeSpan timeSpan, GK_CollectionType collection)
	{
		return null;
	}

	public GK_Score GetScore(int rank, GK_TimeSpan timeSpan, GK_CollectionType collection)
	{
		return null;
	}

	public void CreateScoreListener(int requestId, bool isInternal)
	{
	}

	public void ReportLocalPlayerScoreUpdate(GK_Score score, int requestId)
	{
	}

	public void UpdateCurrentPlayerScore(List<GK_Score> newScores)
	{
	}

	public void UpdateCurrentPlayerScore(GK_Score score)
	{
	}

	public void ReportLocalPlayerScoreUpdateFail(string errorData, int requestId)
	{
	}

	public void UpdateScore(GK_Score s)
	{
	}

	public void UpdateMaxRange(int MR)
	{
	}
}
