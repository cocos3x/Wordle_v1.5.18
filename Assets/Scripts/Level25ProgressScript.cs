using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Level25ProgressScript : MonoBehaviour
{
	private sealed class _003CInitialize_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Level25ProgressScript _003C_003E4__this;

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
		public _003CInitialize_003Ed__11(int _003C_003E1__state)
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

	public TextMeshProUGUI timeText;

	public TextMeshProUGUI lvl50ProgressText;

	public TextMeshProUGUI lvl50ProgressText2;

	public Image lvl50Medal;

	public LevelManager levelMngr;

	public Color NormalSilver;

	public Color NormalGold;

	public Image difficulty;

	public Sprite MedDiff;

	public Sprite HighDiff;

	private void Start()
	{
	}

	private IEnumerator Initialize()
	{
		return null;
	}
}
