using SA.Common.Pattern;
using System;
using System.Collections.Generic;

public class ISN_GameSaves : Singleton<ISN_GameSaves>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__31_0(GK_SaveRemoveResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__31_1(GK_SaveResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__31_2(GK_FetchResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__31_3(GK_SavesResolveResult _003Cp0_003E)
		{
		}
	}

	private static Dictionary<string, GK_SavedGame> _CachedGameSaves;

	public static event Action<GK_SaveRemoveResult> ActionSaveRemoved
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_SaveResult> ActionGameSaved
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_FetchResult> ActionSavesFetched
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GK_SavesResolveResult> ActionSavesResolved
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

	public void SaveGame(byte[] data, string name)
	{
	}

	public void FetchSavedGames()
	{
	}

	public void DeleteSavedGame(string name)
	{
	}

	public void ResolveConflictingSavedGames(List<GK_SavedGame> conflicts, byte[] data)
	{
	}

	public void LoadSaveData(GK_SavedGame save)
	{
	}

	public void OnSaveSuccess(string data)
	{
	}

	public void OnSaveFailed(string erroData)
	{
	}

	public void OnFetchSuccess(string data)
	{
	}

	public void OnFetchFailed(string errorData)
	{
	}

	public void OnResolveSuccess(string data)
	{
	}

	public void OnResolveFailed(string errorData)
	{
	}

	public void OnDeleteSuccess(string name)
	{
	}

	public void OnDeleteFailed(string data)
	{
	}

	private void OnSaveDataLoaded(string data)
	{
	}

	private void OnSaveDataLoadFailed(string data)
	{
	}

	private GK_SavedGame DeserializeGameSave(string serializedData)
	{
		return null;
	}
}
