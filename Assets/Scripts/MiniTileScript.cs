using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MiniTileScript : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public char[] focusLetters;

		internal bool _003CInitialiseTile_003Eb__0(Letter myLetter)
		{
			return false;
		}

		internal bool _003CInitialiseTile_003Eb__1(Letter myLetter)
		{
			return false;
		}
	}

	private sealed class _003CAnimateTiles_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MiniTileScript _003C_003E4__this;

		public bool bCorrect;

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
		public _003CAnimateTiles_003Ed__27(int _003C_003E1__state)
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

	public TextMeshProUGUI LetterText;

	public TextMeshProUGUI LetterValue;

	public RectTransform TileLetter;

	public Image TileEdge;

	public bool FocusTile;

	public GameObject dots;

	public Color TileEdgeColorCorrect;

	public Color TileEdgeColorWrong;

	public Color TileLetterNormal;

	public Color TileLetterJoker;

	public Letter letter;

	private float FocusHeight;

	private bool inCoroutine;

	public bool secondFocusTile;

	public GameObject jokerObj;

	public GameObject letterObj;

	public GameObject letterValueObj;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void InitialiseTile()
	{
	}

	public void showJoker(bool show)
	{
	}

	public void ResetTile()
	{
	}

	private void Start()
	{
	}

	public void IsWord(bool isWord)
	{
	}

	public void IsWord(bool isWord, string joker)
	{
	}

	public void WrongWord()
	{
	}

	public void CorrectWord()
	{
	}

	private IEnumerator AnimateTiles(bool bCorrect)
	{
		return null;
	}
}
