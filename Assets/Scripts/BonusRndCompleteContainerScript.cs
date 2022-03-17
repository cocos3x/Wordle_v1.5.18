using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class BonusRndCompleteContainerScript : MonoBehaviour
{
	private sealed class _003CUpdateDisplay_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BonusRndCompleteContainerScript _003C_003E4__this;

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
		public _003CUpdateDisplay_003Ed__9(int _003C_003E1__state)
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

	public TextMeshProUGUI hintsCountText;

	public TextMeshProUGUI wordsFoundText;

	public EnergyBar wordsFoundBar;

	private int wordsTarget1;

	private int wordsTarget2;

	private int wordsTarget3;

	private int wordsFound;

	private int wordsFoundInc;

	public void Initialise()
	{
	}

	private IEnumerator UpdateDisplay()
	{
		return null;
	}

	public void Exit()
	{
	}

	private void UpdateValues()
	{
	}
}
