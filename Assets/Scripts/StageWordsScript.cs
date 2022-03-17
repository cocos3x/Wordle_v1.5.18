using DoozyUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class StageWordsScript : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PossibleWords, int> _003C_003E9__42_0;

		public static Func<PossibleWords, int> _003C_003E9__42_1;

		public static Func<MyWords2, int> _003C_003E9__42_2;

		public static Func<MyWords2, int> _003C_003E9__42_3;

		public static Func<PossibleWords, int> _003C_003E9__42_4;

		public static Func<PossibleWords, int> _003C_003E9__42_5;

		public static Func<MyWords2, int> _003C_003E9__42_6;

		public static Func<MyWords2, int> _003C_003E9__42_7;

		public static Func<MyWords2, int> _003C_003E9__45_0;

		public static Func<MyWords2, int> _003C_003E9__45_1;

		public static Func<PossibleWords, int> _003C_003E9__45_2;

		public static Func<PossibleWords, int> _003C_003E9__45_3;

		internal int _003CReOrderLists_003Eb__42_0(PossibleWords x)
		{
			return 0;
		}

		internal int _003CReOrderLists_003Eb__42_1(PossibleWords x)
		{
			return 0;
		}

		internal int _003CReOrderLists_003Eb__42_2(MyWords2 x)
		{
			return 0;
		}

		internal int _003CReOrderLists_003Eb__42_3(MyWords2 x)
		{
			return 0;
		}

		internal int _003CReOrderLists_003Eb__42_4(PossibleWords x)
		{
			return 0;
		}

		internal int _003CReOrderLists_003Eb__42_5(PossibleWords x)
		{
			return 0;
		}

		internal int _003CReOrderLists_003Eb__42_6(MyWords2 x)
		{
			return 0;
		}

		internal int _003CReOrderLists_003Eb__42_7(MyWords2 x)
		{
			return 0;
		}

		internal int _003CInitialize_003Eb__45_0(MyWords2 x)
		{
			return 0;
		}

		internal int _003CInitialize_003Eb__45_1(MyWords2 x)
		{
			return 0;
		}

		internal int _003CInitialize_003Eb__45_2(PossibleWords x)
		{
			return 0;
		}

		internal int _003CInitialize_003Eb__45_3(PossibleWords x)
		{
			return 0;
		}
	}

	private sealed class _003CInitialize_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageWordsScript _003C_003E4__this;

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
		public _003CInitialize_003Ed__45(int _003C_003E1__state)
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

	public static StageWordsScript stageWordsScript;

	public List<TutorialTileScript> Tiles;

	public UIElement allWords;

	public VerticalScrollSnap allWordsVerticalScrollSnap;

	public RectTransform allWordsScrollView;

	public Transform allWordsContent;

	public VerticalScrollSnap myWordsVerticalScrollSnap;

	public RectTransform myWordsScrollView;

	public Transform myWordsContent;

	public GameObject wordPanelPrefab;

	public int WordPanelHeight;

	public TextMeshProUGUI totalText;

	public TextMeshProUGUI letterFocusText;

	public GameObject wordnikAtt;

	public TextMeshProUGUI wordText;

	public TextMeshProUGUI DefinitionText;

	public List<MyWords2> myWords;

	public List<PossibleWords> AllpossibleWords;

	public List<PossibleWords> topPossibleWords;

	private int currentIndex;

	private int lowestIndex;

	private bool orderByLength;

	private myWordScript allWordsTopButton;

	private myWordScript myWordsTopButton;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void ResizeScrollView()
	{
	}

	public bool AllWords()
	{
		return false;
	}

	public void OnToggleAllWords()
	{
	}

	public void GetDefinition(int index, bool bAll)
	{
	}

	public void GetNextDefinition()
	{
	}

	public void GetNextDefinition(bool bAll)
	{
	}

	public void GetPreviousDefinition()
	{
	}

	public void GetPreviousDefinition(bool bAll)
	{
	}

	public void ReInitialize()
	{
	}

	public void GoToTopMyWords()
	{
	}

	public void GoToTopMyWords(bool active)
	{
	}

	public void GoToTopAllWords()
	{
	}

	public void GoToTopAllWords(bool active)
	{
	}

	public void PopulateTileBoard(string word, List<LetterMatrix> letterMatrix)
	{
	}

	public void OnSelectWord(int index, int position)
	{
	}

	public void OnSelectWord(int index, int position, bool bAll)
	{
	}

	public void ReOrderLists()
	{
	}

	public void PopulateMyWordsList()
	{
	}

	public void PopulateAllWordsList()
	{
	}

	private IEnumerator Initialize()
	{
		return null;
	}

	public void onShowDefinitions()
	{
	}
}
