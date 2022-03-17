using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class myWordScript : MonoBehaviour
{
	private sealed class _003CSelectMyWordButton_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public myWordScript _003C_003E4__this;

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
		public _003CSelectMyWordButton_003Ed__11(int _003C_003E1__state)
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

	public TextMeshProUGUI postitionText;

	public TextMeshProUGUI wordText;

	public TextMeshProUGUI scoreText;

	public GameObject noWordImage;

	public GameObject isNewText;

	public Transform wordContent;

	public GameObject wordTilePrefab;

	public HorizontalLayoutGroup wordLayourGrp;

	private int index;

	private int position;

	public void DoSelectMyWordButton(bool active)
	{
	}

	private IEnumerator SelectMyWordButton()
	{
		return null;
	}

	private string AddOrdinal(int num)
	{
		return "";
	}

	public void NoWordDetails()
	{
	}

	public void UpdateWordDetails(int indx, int pos, string word, List<Letter> wordLetters, int score, DateTime date)
	{
	}

	public void OnSelectWord()
	{
	}
}
