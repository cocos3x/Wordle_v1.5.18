using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class CurrentWordScript : MonoBehaviour
{
	private sealed class _003CUpdateWordPanel_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CurrentWordScript _003C_003E4__this;

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
		public _003CUpdateWordPanel_003Ed__25(int _003C_003E1__state)
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

	private sealed class _003CDestroyTile_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject Tile;

		public CurrentWordScript _003C_003E4__this;

		private GameObject _003Cparent_003E5__2;

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
		public _003CDestroyTile_003Ed__27(int _003C_003E1__state)
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

	private sealed class _003CSecondsAdded_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CurrentWordScript _003C_003E4__this;

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
		public _003CSecondsAdded_003Ed__28(int _003C_003E1__state)
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

	public static CurrentWordScript currentWordManager;

	public GameObject MiniTilePrefab;

	public GameObject TileParent;

	public GameObject WordPanel;

	public GameObject StartDots;

	public GameObject EndDots;

	public GameObject StartTile;

	public GameObject EndTile;

	public GameObject StartTile2;

	public GameObject EndTile2;

	public Transform TileContainer;

	public TextMeshProUGUI WordPanelText;

	public List<GameObject> TileSpaceObjects;

	public AudioClip completedWord;

	public AudioClip invalidWord;

	public int maxTiles;

	public bool wordEnding;

	public string focus;

	private List<Letter> currentWord;

	public List<Letter> displayedWord;

	public GameObject secondsAddedObj;

	public TextMeshProUGUI secondsAdded;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private IEnumerator UpdateWordPanel()
	{
		return null;
	}

	private void UpdateWord()
	{
	}

	private IEnumerator DestroyTile(GameObject Tile)
	{
		return null;
	}

	private IEnumerator SecondsAdded()
	{
		return null;
	}

	public void OnWordCreated(string word, int wordScore)
	{
	}

	public void OnInvalidWord()
	{
	}

	public void OnInvalidWord(bool repeat)
	{
	}

	public void ResetAll()
	{
	}

	public void OnLetterSelected(bool isWord, string joker)
	{
	}

	public void OnLetterSelected(bool isWord, bool deSelect, string joker)
	{
	}
}
