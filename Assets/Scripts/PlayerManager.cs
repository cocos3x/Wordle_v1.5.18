using DoozyUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
	private sealed class _003CDoInitialiseLevel_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool launchScene;

		public PlayerManager _003C_003E4__this;

		public bool bonusRound;

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
		public _003CDoInitialiseLevel_003Ed__38(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public int wordScore;

		internal bool _003CSaveHighScoreWord_003Eb__0(MyWords3 x)
		{
			return false;
		}

		internal bool _003CSaveHighScoreWord_003Eb__2(MyWords3 x)
		{
			return false;
		}

		internal bool _003CSaveHighScoreWord_003Eb__4(MyWords2 x)
		{
			return false;
		}

		internal bool _003CSaveHighScoreWord_003Eb__6(MyWords2 x)
		{
			return false;
		}

		internal bool _003CSaveHighScoreWord_003Eb__7(MyWords2 x)
		{
			return false;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<MyWords3, int> _003C_003E9__43_1;

		public static Func<MyWords3, int> _003C_003E9__43_3;

		public static Func<MyWords2, int> _003C_003E9__43_5;

		internal int _003CSaveHighScoreWord_003Eb__43_1(MyWords3 x)
		{
			return 0;
		}

		internal int _003CSaveHighScoreWord_003Eb__43_3(MyWords3 x)
		{
			return 0;
		}

		internal int _003CSaveHighScoreWord_003Eb__43_5(MyWords2 x)
		{
			return 0;
		}
	}

	public static PlayerManager playerManager;

	public Color doubleColor;

	public Color tripleColor;

	public UIElement levelStart;

	public int Score;

	public int WordsFound;

	public string LongWord;

	public string HighScoreWord;

	public int HighScoreWordScore;

	public int LvlScore;

	public int LvlTarget;

	public int LvlWordsFound;

	public string LvlLongWord;

	public int LvlLongWordScore;

	public string LvlHighScoreWord;

	public int LvlHighScoreWordScore;

	public float LvlTimeTaken;

	public bool LvlBonusRound;

	public bool LvlIsTimed;

	public int LvlsStartedInSession;

	public int updateScore;

	public bool initialised;

	public bool helpShown;

	public bool showLvl25ProgressOnScreen;

	public bool showLvl50ProgressOnScreen;

	public bool shownLvl25ProgressThisSession;

	public bool shownLvl50ProgressThisSession;

	public int TodaysDailyChallengeScore()
	{
		return 0;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MakeThisTheOnlyPlayerManager()
	{
	}

	private void Update()
	{
	}

	private void checkScore()
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

	public void OnInitialiseLevel(bool bonusRound, bool launchScene)
	{
	}

	public void OnExitTutorial()
	{
	}

	private IEnumerator DoInitialiseLevel(bool bonusRound, bool launchScene)
	{
		return null;
	}

	private void OnBeforeinitialiseLevel()
	{
	}

	private void initialiseLevel(bool bonusRound)
	{
	}

	public void resetAllLevelProperties()
	{
	}

	private void GenerateTileSpaces()
	{
	}

	private void SaveHighScoreWord(string word, int wordScore, List<Letter> wordLetters, List<LetterMatrix> boardLetters)
	{
	}

	public void OnWordCreated(string word, int wordScore, List<Letter> wordLetters, List<LetterMatrix> boardLetters)
	{
	}

	public void QuitGame()
	{
	}

	private bool _003CDoInitialiseLevel_003Eb__38_0()
	{
		return false;
	}
}
