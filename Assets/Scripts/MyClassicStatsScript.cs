using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class MyClassicStatsScript : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<MyWords3, int> _003C_003E9__30_0;

		public static Func<MyWords3, int> _003C_003E9__30_1;

		public static Func<MyWords3, int> _003C_003E9__30_2;

		public static Func<MyWords3, int> _003C_003E9__30_3;

		public static Func<MyScores, int> _003C_003E9__31_0;

		public static Func<MyScores, int> _003C_003E9__31_1;

		public static Func<MyScores, int> _003C_003E9__31_2;

		public static Func<MyScores, int> _003C_003E9__31_3;

		public static Func<MyScores, int> _003C_003E9__35_0;

		public static Func<MyWords3, int> _003C_003E9__37_0;

		public static Func<MyScores, int> _003C_003E9__37_1;

		internal int _003CReOrderWordsList_003Eb__30_0(MyWords3 x)
		{
			return 0;
		}

		internal int _003CReOrderWordsList_003Eb__30_1(MyWords3 x)
		{
			return 0;
		}

		internal int _003CReOrderWordsList_003Eb__30_2(MyWords3 x)
		{
			return 0;
		}

		internal int _003CReOrderWordsList_003Eb__30_3(MyWords3 x)
		{
			return 0;
		}

		internal int _003CReOrderScoressList_003Eb__31_0(MyScores x)
		{
			return 0;
		}

		internal int _003CReOrderScoressList_003Eb__31_1(MyScores x)
		{
			return 0;
		}

		internal int _003CReOrderScoressList_003Eb__31_2(MyScores x)
		{
			return 0;
		}

		internal int _003CReOrderScoressList_003Eb__31_3(MyScores x)
		{
			return 0;
		}

		internal int _003CPopulateTopScoresList_003Eb__35_0(MyScores x)
		{
			return 0;
		}

		internal int _003CInitialize_003Eb__37_0(MyWords3 x)
		{
			return 0;
		}

		internal int _003CInitialize_003Eb__37_1(MyScores x)
		{
			return 0;
		}
	}

	private sealed class _003CInitialize_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MyClassicStatsScript _003C_003E4__this;

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
		public _003CInitialize_003Ed__37(int _003C_003E1__state)
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

	public static MyClassicStatsScript myClassicStatsScript;

	public TextMeshProUGUI highestScoreText;

	public VerticalScrollSnap verticalScrollSnap;

	public RectTransform ScrollView;

	public Transform myWordsContent;

	public GameObject wordPanelPrefab;

	public int WordPanelHeight;

	public myWordScript WordOfTheWeek;

	public myScoreScript ScoreOfTheWeek;

	public VerticalScrollSnap scoresVerticalScrollSnap;

	public RectTransform scoresScrollView;

	public Transform scoresContent;

	public GameObject scoresPanelPrefab;

	public int scoresPanelHeight;

	public bool showingDefinitions;

	public TextMeshProUGUI wordText;

	public TextMeshProUGUI DefinitionText;

	public GameObject wordnikAtt;

	private int currentIndex;

	private bool orderByLength;

	private bool orderByWordsFound;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void ResizeScrollView()
	{
	}

	public void ReInitialize()
	{
	}

	public void GoToTopMyWords()
	{
	}

	public void GetDefinition(int index)
	{
	}

	public void GetNextDefinition()
	{
	}

	public void GetPreviousDefinition()
	{
	}

	public void onShowDefinitions()
	{
	}

	public void ReOrderWordsList()
	{
	}

	public void ReOrderScoressList()
	{
	}

	public void PopulateTopWordsList()
	{
	}

	public void PopulateTopWordsList(List<MyWords3> topWords)
	{
	}

	public void PopulateTopScoresList()
	{
	}

	public void PopulateTopScoresList(List<MyScores> topScores)
	{
	}

	public void OnSelectWord(int index, int position)
	{
	}

	private IEnumerator Initialize()
	{
		return null;
	}
}
