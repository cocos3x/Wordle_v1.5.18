using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class TileManager : MonoBehaviour
{
	private sealed class _003CCreateTiles_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TileManager _003C_003E4__this;

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
		public _003CCreateTiles_003Ed__61(int _003C_003E1__state)
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

	private sealed class _003CUpdateTiles_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TileManager _003C_003E4__this;

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
		public _003CUpdateTiles_003Ed__62(int _003C_003E1__state)
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

		public static Converter<int, string> _003C_003E9__69_0;

		internal string _003CAllWordsFromStart_003Eb__69_0(int x)
		{
			return "";
		}
	}

	private sealed class _003CFindPossibleWords_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TileManager _003C_003E4__this;

		private string _003CLetterFocus_003E5__2;

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
		public _003CFindPossibleWords_003Ed__72(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public Letter letter;

		internal bool _003CRemoveLetterFromCurrentWord_003Eb__0(LetterMatrix x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public Letter letter;

		internal bool _003CAddLetterToCurrentWord_003Eb__0(LetterMatrix x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public string focusLetters;
	}

	private sealed class _003C_003Ec__DisplayClass84_1
	{
		public int iLet;

		public _003C_003Ec__DisplayClass84_0 CS_0024_003C_003E8__locals1;

		internal bool _003CCalculateWordScore_003Eb__0(Letter myLetter)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public string word;

		internal bool _003CEndCurrentWord_003Eb__0(MyWords2 x)
		{
			return false;
		}
	}

	private sealed class _003CAnimateHintTiles_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TileManager _003C_003E4__this;

		public bool complete;

		private int _003Ci_003E5__2;

		private List<Transform> _003CTiles_003E5__3;

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
		public _003CAnimateHintTiles_003Ed__87(int _003C_003E1__state)
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

	private sealed class _003COnShake_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TileManager _003C_003E4__this;

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
		public _003COnShake_003Ed__91(int _003C_003E1__state)
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

	private sealed class _003COnJoker_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TileManager _003C_003E4__this;

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
		public _003COnJoker_003Ed__93(int _003C_003E1__state)
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

	private sealed class _003COnRotate_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TileManager _003C_003E4__this;

		private List<Transform> _003Ctiles_003E5__2;

		private RigidbodyConstraints _003Cconstraints_003E5__3;

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
		public _003COnRotate_003Ed__98(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public Transform Tile;

		public TileManager _003C_003E4__this;

		internal bool _003COnMouseOverTile_003Eb__0(LetterMatrix x)
		{
			return false;
		}

		internal bool _003COnMouseOverTile_003Eb__1(LetterMatrix x)
		{
			return false;
		}
	}

	public static TileManager tilemanager;

	public List<Letter> Letters;

	public List<string> StartLetters;

	public List<string> EndLetters;

	public List<float> weights;

	public float CombinedWeight;

	public List<Letter> currentWord;

	public int currentWordScore;

	public int maxSpecialTilesAllowed;

	public int maxOfTypeLetter;

	public int maxOfTypeWord;

	public List<GameObject> spawnLocations;

	public List<GameObject> columns;

	public CurrentWordScript currentWordScript;

	private List<LetterMatrix> letterMatrix;

	public int MaxTilesPerLocation;

	public GameObject TilePrefab;

	public List<string> possibleWords;

	public List<string> possibleWordsWithDupes;

	public List<string> possibleWordsLocations;

	public bool complete;

	private bool pauseWord;

	private string hintWord;

	private string hintWordLocation;

	private List<char> hintLetters;

	private List<Transform> hintTiles;

	public TextMeshProUGUI hintText;

	public GameObject hintsRemaining;

	public GameObject middlePanel;

	public GameObject wordCountText;

	public GameObject lvlScoresAndCountsGrp;

	public GameObject bonusWordsCountGrp;

	public GameObject bonusWordsProgressBar;

	public bool possibleWordsFound;

	public int minWordsFound;

	public int tileCount;

	public DateTime LastWord;

	public RectTransform container;

	public RectTransform tileGenerator;

	public RectTransform columnsContainer;

	public RectTransform tileBackgroundTransform;

	public RectTransform tileBoard;

	public BoxCollider tileBoardCollider;

	private float distanceAtDesignTime;

	private float widthAtDesignTime;

	public float startingPitch;

	public float startingVolume;

	public bool jokerActive;

	private float jokerTime;

	public float jokerTimeRemaining;

	private bool jokerWarning;

	private bool tilesInMotion;

	public GameObject jokerBtn;

	private int count;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Initialize()
	{
	}

	private void Update()
	{
	}

	public void resetJoker()
	{
	}

	private void PopulateLetters()
	{
	}

	public void ResetTiles()
	{
	}

	public void DoCreateTiles()
	{
	}

	private IEnumerator CreateTiles()
	{
		return null;
	}

	private IEnumerator UpdateTiles()
	{
		return null;
	}

	public void CheckColumns()
	{
	}

	public void DestroyAllTiles()
	{
	}

	public void CreateTileInColumn(GameObject Column, int colIndex, int spwnIndex)
	{
	}

	public Letter GoGetLetter()
	{
		return null;
	}

	public Letter GetLetter()
	{
		return null;
	}

	private void UpdateLetterMatrix()
	{
	}

	public List<string> AllWordsFromStart(string prefix, List<int> path, out List<string> locations, bool ending)
	{
		return null;
	}

	private List<string> AllPossibleWords(out List<string> PossibleWordsLocations)
	{
		return null;
	}

	private List<string> AllPossibleWords(out List<string> PossibleWordsLocations, string focus, bool ending)
	{
		return null;
	}

	private IEnumerator FindPossibleWords()
	{
		return null;
	}

	public void AddToPossibleWords(List<string> possibleWordsWithDupes, List<string> possibleWordsLocations, List<LetterMatrix> letterMatrix, string LetterFocus)
	{
	}

	public void ResetSelectStateOfLetterMatrix()
	{
	}

	public void OnMouseDownTile(Letter letter, Transform Tile)
	{
	}

	private bool IsCurrentWordAWord(Letter letter, ref string joker)
	{
		return false;
	}

	private string getCurrentWord()
	{
		return "";
	}

	private string CheckCurrentWord()
	{
		return "";
	}

	private string CheckCurrentWord(ref string joker)
	{
		return "";
	}

	private void RemoveLetterFromCurrentWord(Letter letter)
	{
	}

	private void AddLetterToCurrentWord(Letter letter)
	{
	}

	private void AddLetterToCurrentWord(Letter letter, bool NoAnim)
	{
	}

	private int CalculateWordScore()
	{
		return 0;
	}

	private int CalculateWordScore(ref List<Letter> wordLetters, string joker)
	{
		return 0;
	}

	private void EndCurrentWord()
	{
	}

	public void DoHint()
	{
	}

	private IEnumerator AnimateHintTiles(bool complete)
	{
		return null;
	}

	private void ResetHintTiles()
	{
	}

	private void ResetHintTiles(bool maintain)
	{
	}

	public void DoShake()
	{
	}

	private IEnumerator OnShake()
	{
		return null;
	}

	public void DoJoker()
	{
	}

	private IEnumerator OnJoker()
	{
		return null;
	}

	public void OnJokerEnd()
	{
	}

	public void OnJokerWarn()
	{
	}

	public bool TilesInMotion()
	{
		return false;
	}

	public void DoRotate()
	{
	}

	private IEnumerator OnRotate()
	{
		return null;
	}

	private GameObject[][] PopulateTempTileMatrix()
	{
		return null;
	}

	private GameObject[][] RotateMatrix(GameObject[][] matrix, int n)
	{
		return null;
	}

	public void RearrangeTilesInColumns(GameObject[][] columnsTemp)
	{
	}

	public void OnMouseUpTile(Letter letter, Transform Tile)
	{
	}

	public void OnTouchEnd()
	{
	}

	public void OnMouseOverTile(Letter letter, Transform Tile)
	{
	}

	private bool _003CDoHint_003Eb__86_0(string x)
	{
		return false;
	}

	private bool _003COnRotate_003Eb__98_0()
	{
		return false;
	}
}
