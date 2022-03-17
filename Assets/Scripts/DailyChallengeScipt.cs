using DoozyUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyChallengeScipt : MonoBehaviour
{
	private sealed class _003CshowTodaysScores_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public DailyChallengeScipt _003C_003E4__this;

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
		public _003CshowTodaysScores_003Ed__37(int _003C_003E1__state)
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

	public Sprite stageCompleteImg;

	public Sprite stageNotCompleteImg;

	public GameObject scoreBoard;

	public GameObject scoreBoardEntryPrefab;

	public Transform scoreBoardListContent;

	public Image stage1;

	public Image stage2;

	public Image stage3;

	public TextMeshProUGUI stage;

	public TextMeshProUGUI stageDesc;

	public TextMeshProUGUI letterFocus;

	public GameObject stageDetails;

	public GameObject stageComplete;

	public GameObject playBtn;

	public GameObject helpText;

	public GameObject firstPlace;

	public GameObject secondPlace;

	public GameObject thirdPlace;

	public GameObject noScores;

	public HiScorePanelScript firstPlaceScript;

	public HiScorePanelScript secondPlaceScript;

	public HiScorePanelScript thirdPlaceScript;

	public Image avatar;

	public GameObject notConnected;

	public TextMeshProUGUI score;

	public TextMeshProUGUI rank;

	public GameObject loginBtn;

	public UIElement todaysScores;

	public UIElement dailyChallenge;

	private Level level;

	private wordleLevelStats levelStats;

	private bool levelComplete;

	public Texture2D noPhoto;

	private List<UM_Score> scores;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void OnExitDailyChallenge()
	{
	}

	private IEnumerator showTodaysScores(float delay)
	{
		return null;
	}

	private void LeaderboardLoaded(UM_LeaderboardResult result)
	{
	}

	private void RefreshLeaderboard()
	{
	}

	public void Initialise()
	{
	}
}
