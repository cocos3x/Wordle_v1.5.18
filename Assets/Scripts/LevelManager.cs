using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	private sealed class _003CshowLastVisitedMenu_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelManager _003C_003E4__this;

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
		public _003CshowLastVisitedMenu_003Ed__30(int _003C_003E1__state)
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

		public static Func<MyScores, int> _003C_003E9__39_1;

		public static Func<MyScores, int> _003C_003E9__39_2;

		public static Predicate<MyWords3> _003C_003E9__53_0;

		public static Predicate<MyScores> _003C_003E9__53_1;

		public static Predicate<MyWords2> _003C_003E9__53_2;

		public static Predicate<Stage> _003C_003E9__69_0;

		public static Predicate<Stage> _003C_003E9__70_0;

		public static Predicate<Stage> _003C_003E9__71_0;

		public static Predicate<Stage> _003C_003E9__72_0;

		internal int _003CupdateLevelStatistics_003Eb__39_1(MyScores x)
		{
			return 0;
		}

		internal int _003CupdateLevelStatistics_003Eb__39_2(MyScores x)
		{
			return 0;
		}

		internal bool _003CLoadMyWords_003Eb__53_0(MyWords3 item)
		{
			return false;
		}

		internal bool _003CLoadMyWords_003Eb__53_1(MyScores item)
		{
			return false;
		}

		internal bool _003CLoadMyWords_003Eb__53_2(MyWords2 item)
		{
			return false;
		}

		internal bool _003CcurrentLetterFocus_003Eb__69_0(Stage i)
		{
			return false;
		}

		internal bool _003CcurrentEnding_003Eb__70_0(Stage i)
		{
			return false;
		}

		internal bool _003CcurrentScoreRequired_003Eb__71_0(Stage i)
		{
			return false;
		}

		internal bool _003CcurrentTime_003Eb__72_0(Stage i)
		{
			return false;
		}
	}

	private sealed class _003COnLoadGame_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelManager _003C_003E4__this;

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
		public _003COnLoadGame_003Ed__40(int _003C_003E1__state)
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

	private sealed class _003COnLoadMainMenu_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelManager _003C_003E4__this;

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
		public _003COnLoadMainMenu_003Ed__41(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public List<MyWords> myOldWords;
	}

	private sealed class _003C_003Ec__DisplayClass53_1
	{
		public int i;

		public _003C_003Ec__DisplayClass53_0 CS_0024_003C_003E8__locals1;
	}

	private sealed class _003C_003Ec__DisplayClass53_2
	{
		public int i2;

		public _003C_003Ec__DisplayClass53_1 CS_0024_003C_003E8__locals2;

		internal bool _003CLoadMyWords_003Eb__3(Letter myLetter)
		{
			return false;
		}
	}

	public static LevelManager levelManager;

	public LevelList levelList;

	public LevelList challengeLevelList;

	public List<Level> levels;

	public List<Level> challengelevels;

	public List<wordleLevelStats> wordleStagesStats;

	public wordleLevelStats TodaysChallengeStagesStats;

	public DateTime lastDailyReward;

	public Level currentLevel;

	public wordleLevelStats currentWordleStageStats;

	public List<string> stageNames;

	public List<MyWords2> myWords;

	public List<MyWords2> myWeeklyWords;

	public List<MyWords2> stageWords;

	public List<PossibleWords> possibleWords;

	public List<MyScores> topScores;

	public List<MyWords3> topWords;

	public List<MyScores> weeklyScores;

	public List<MyWords3> weeklyWords;

	public string appPassword;

	public string appSaveToFile;

	public int bonusHintsPerStage;

	public float bonusStageTime;

	public float levelTimeTarget;

	private int sceneLoadedFrom;

	public static int HighestCompletedStage => 0;

	private void Awake()
	{
	}

	private void MakeThisTheOnlyLevelManager()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private IEnumerator showLastVisitedMenu()
	{
		return null;
	}

	private List<string> TextAssetToList(TextAsset ta)
	{
		return null;
	}

	public void LoadResources()
	{
	}

	public void ReInitialize()
	{
	}

	public void Initialize()
	{
	}

	public int CheckHighestCompletedStage(List<wordleLevelStats> wordleStagesStats)
	{
		return 0;
	}

	public void updateBonusRound()
	{
	}

	public void updateLevelStatistics()
	{
	}

	private IEnumerator OnLoadGame()
	{
		return null;
	}

	private IEnumerator OnLoadMainMenu()
	{
		return null;
	}

	public void LoadGame(int level)
	{
	}

	public void LoadGame(int level, int stage)
	{
	}

	public void LoadMainMenu()
	{
	}

	public void LoadLevel(int level)
	{
	}

	public void LoadLevel(int level, int stage)
	{
	}

	public bool LoadNextStage()
	{
		return false;
	}

	public void LoadBonusLevel()
	{
	}

	public void ReplayStage()
	{
	}

	public void LoadNextLevel(bool nextLevel)
	{
	}

	public void StartNextStage()
	{
	}

	public int CurrentStage()
	{
		return 0;
	}

	private void LoadMyWords()
	{
	}

	private void LoadWordleStagesList()
	{
	}

	private void OverrideWordleStagesStats()
	{
	}

	private void LoadChallengeStagesList()
	{
	}

	private void LoadLastDailyReward()
	{
	}

	public void SaveData()
	{
	}

	private void OnApplicationPaused(bool pauseStatus)
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void CreateWordleStagesStatsList()
	{
	}

	public int TodaysDailyChallenge()
	{
		return 0;
	}

	public Level GetTodaysDailyChallenge()
	{
		return null;
	}

	public wordleLevelStats GetTodaysDailyChallengeDetails()
	{
		return null;
	}

	private void doLoadDailyChallenge()
	{
	}

	public bool isDailyChallengeComplete()
	{
		return false;
	}

	public void LoadDailyChallenge()
	{
	}

	public string currentLetterFocus()
	{
		return "";
	}

	public bool currentEnding()
	{
		return false;
	}

	public int currentScoreRequired()
	{
		return 0;
	}

	public float currentTime()
	{
		return 0f;
	}

	public bool isTimed()
	{
		return false;
	}

	private bool _003CupdateLevelStatistics_003Eb__39_0(StageStats i)
	{
		return false;
	}
}
