using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TileScript : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public TileScript _003C_003E4__this;

		public Color special;

		internal void _003CChangeColor_003Eb__0()
		{
		}

		internal void _003CChangeColor_003Eb__1()
		{
		}
	}

	private sealed class _003CDoAddLetter_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TileScript _003C_003E4__this;

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
		public _003CDoAddLetter_003Ed__28(int _003C_003E1__state)
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

	private sealed class _003CDoResetLetter_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TileScript _003C_003E4__this;

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
		public _003CDoResetLetter_003Ed__29(int _003C_003E1__state)
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

	private sealed class _003CDoDestroyTile_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TileScript _003C_003E4__this;

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
		public _003CDoDestroyTile_003Ed__35(int _003C_003E1__state)
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

	public TextMeshProUGUI ValueText;

	public TextMeshProUGUI SpecialText;

	public Image Special;

	public RectTransform Background;

	public Image backgroundImage;

	public Color normalTile;

	public Color specialTile;

	public Color highlightedTile;

	public Color WordTile;

	public Letter letter;

	public Color tileSpecial1;

	public Color tileSpecial2;

	public Color tileSpecial3;

	public Color tileSpecial4;

	public AudioClip selectSound;

	public AudioClip impact;

	public AudioClip fall;

	private Vector2 origRectSize;

	public Image tileImage;

	private bool contactBelow;

	private void Start()
	{
	}

	public void AddLetter()
	{
	}

	public void AddLetter(bool reset)
	{
	}

	public void letterNormalColors()
	{
	}

	public void letterSpecialColors()
	{
	}

	private void ChangeColor(Color special)
	{
	}

	public void resetLetter()
	{
	}

	private IEnumerator DoAddLetter()
	{
		return null;
	}

	private IEnumerator DoResetLetter()
	{
		return null;
	}

	private void OnTouchBegin()
	{
	}

	private void OnTouchEnd()
	{
	}

	private void OnTouchOver()
	{
	}

	public void LetterInWord()
	{
	}

	public void LetterNotInWord()
	{
	}

	private IEnumerator DoDestroyTile()
	{
		return null;
	}

	public void DestroyTile()
	{
	}

	public void LetterSelectedAnimation()
	{
	}

	public void LetterDeSelectedAnimation()
	{
	}

	public void LetterDeSelectedAnimation(bool playSound)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
