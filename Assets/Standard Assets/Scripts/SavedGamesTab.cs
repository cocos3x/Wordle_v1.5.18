using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class SavedGamesTab : FeatureTab
{
	private sealed class _003CMakeScreenshotAndSaveGameData_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SavedGamesTab _003C_003E4__this;

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
		public _003CMakeScreenshotAndSaveGameData_003Ed__23(int _003C_003E1__state)
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

	public Image avatar;

	private Sprite logo;

	private Sprite defaulttexture;

	public Button connectButton;

	public Text connectButtonLabel;

	public Text playerLabel;

	public Button[] ConnectionDependedntButtons;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void ConncetButtonPress()
	{
	}

	private void FixedUpdate()
	{
	}

	public void CreateNewSnapshot()
	{
	}

	public void ShowSavedGamesUI()
	{
	}

	public void LoadSavedGames()
	{
	}

	private void ActionAvailableGameSavesLoaded(GooglePlayResult res)
	{
	}

	private void OnSpanshotLoadDialogComplete(AndroidDialogResult res)
	{
	}

	private void ActionNewGameSaveRequest()
	{
	}

	private void ActionGameSaveLoaded(GP_SpanshotLoadResult result)
	{
	}

	private void ActionGameSaveResult(GP_SpanshotLoadResult result)
	{
	}

	private void ActionConflict(GP_SnapshotConflict result)
	{
	}

	private void OnPlayerDisconnected()
	{
	}

	private void OnPlayerConnected()
	{
	}

	private void OnConnectionResult(GooglePlayConnectionResult result)
	{
	}

	private IEnumerator MakeScreenshotAndSaveGameData()
	{
		return null;
	}
}
