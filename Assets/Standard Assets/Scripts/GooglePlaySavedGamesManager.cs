using SA.Common.Pattern;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GooglePlaySavedGamesManager : Singleton<GooglePlaySavedGamesManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__41_0()
		{
		}

		internal void _003C_002Ecctor_003Eb__41_1()
		{
		}

		internal void _003C_002Ecctor_003Eb__41_2(GooglePlayResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__41_3(GP_SpanshotLoadResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__41_4(GP_SpanshotLoadResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__41_5(GP_SnapshotConflict _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__41_6(GP_DeleteSnapshotResult _003Cp0_003E)
		{
		}
	}

	private List<GP_SnapshotMeta> _AvailableGameSaves;

	public List<GP_SnapshotMeta> AvailableGameSaves => null;

	public static event Action ActionGameSaveUIClosed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action ActionNewGameSaveRequest
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GooglePlayResult> ActionAvailableGameSavesLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_SpanshotLoadResult> ActionGameSaveLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_SpanshotLoadResult> ActionGameSaveResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_SnapshotConflict> ActionConflict
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_DeleteSnapshotResult> ActionGameSaveRemoved
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void ShowSavedGamesUI(string title, int maxNumberOfSavedGamesToShow, bool allowAddButton = true, bool allowDelete = true)
	{
	}

	public void CreateNewSnapshot(string name, string description, Texture2D coverImage, string spanshotData, long PlayedTime)
	{
	}

	public void CreateNewSnapshot(string name, string description, Texture2D coverImage, byte[] spanshotData, long PlayedTime)
	{
	}

	public void LoadSpanshotByName(string name)
	{
	}

	public void DeleteSpanshotByName(string name)
	{
	}

	public void LoadAvailableSavedGames()
	{
	}

	private static byte[] GetBytes(string str)
	{
		return null;
	}

	private static string GetString(byte[] bytes)
	{
		return "";
	}

	private void OnLoadSnapshotsResult(string data)
	{
	}

	private void OnSavedGamePicked(string data)
	{
	}

	private void OnSavedGameSaveResult(string data)
	{
	}

	private void OnConflict(string data)
	{
	}

	private void OnNewGameSaveRequest(string data)
	{
	}

	private void OnSavedGamesUIClosed(string data)
	{
	}

	private void OnDeleteResult(string data)
	{
	}
}
