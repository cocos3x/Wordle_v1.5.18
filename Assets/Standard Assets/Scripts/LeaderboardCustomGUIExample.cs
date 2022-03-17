using SA.Common.Models;
using UnityEngine;

public class LeaderboardCustomGUIExample : MonoBehaviour
{
	private string leaderboardId_1;

	public int hiScore;

	public GUIStyle headerStyle;

	public GUIStyle boardStyle;

	private GK_Leaderboard loadedLeaderboard;

	private GK_CollectionType displayCollection;

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}

	private void OnScoresListLoaded(Result res)
	{
	}

	private void OnAuthFinished(Result res)
	{
	}
}
