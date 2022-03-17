using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UM_Leaderboard
{
	[SerializeField]
	public string id;

	public bool IsOpen;

	[SerializeField]
	public string IOSId;

	[SerializeField]
	public string AndroidId;

	[SerializeField]
	public string AmazonId;

	[SerializeField]
	private string _Description;

	[SerializeField]
	private Texture2D _Texture;

	private GK_Leaderboard gk_Leaderboard;

	private GPLeaderBoard gp_Leaderboard;

	private GC_Leaderboard gc_Leaderboard;

	public bool IsValid => false;

	public string Id => "";

	public string Name => "";

	public bool CurrentPlayerScoreLoaded => false;

	public GK_Leaderboard GameCenterLeaderboard => null;

	public GPLeaderBoard GooglePlayLeaderboard => null;

	public GC_Leaderboard AmazonLeaderboard => null;

	public string Description
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public Texture2D Texture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void Setup(GPLeaderBoard gpLeaderboard)
	{
	}

	public void Setup(GK_Leaderboard gkLeaderboard)
	{
	}

	public void Setup(GC_Leaderboard gcLeaderboard)
	{
	}

	public UM_Score GetScore(int rank, UM_TimeSpan scope, UM_CollectionType collection)
	{
		return null;
	}

	public List<UM_Score> GetScoresList(UM_TimeSpan span, UM_CollectionType collection)
	{
		return null;
	}

	public UM_Score GetScoreByPlayerId(string playerId, UM_TimeSpan span, UM_CollectionType collection)
	{
		return null;
	}

	public UM_Score GetCurrentPlayerScore(UM_TimeSpan span, UM_CollectionType collection)
	{
		return null;
	}
}
