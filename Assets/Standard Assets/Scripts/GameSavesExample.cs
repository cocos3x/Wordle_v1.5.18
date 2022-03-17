using SA.Common.Models;
using System.Collections.Generic;

public class GameSavesExample : BaseIOSFeaturePreview
{
	private Dictionary<string, List<GK_SavedGame>> GameSaves;

	private Dictionary<string, List<GK_SavedGame>> SavesConflicts;

	private string test_name;

	private string test_name_2;

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}

	private void Save(string name)
	{
	}

	private void Fetch()
	{
	}

	private void Delete(string name)
	{
	}

	private void Load()
	{
	}

	private void ResolveConflicts()
	{
	}

	private GK_SavedGame GetLoadedSave(string saveGameName)
	{
		return null;
	}

	private List<GK_SavedGame> GetConflict()
	{
		return null;
	}

	private int GetConflictsCount()
	{
		return 0;
	}

	private void CheckSavesOnDuplicates()
	{
	}

	private void HandleOnAuthFinished(Result result)
	{
	}

	private void HandleActionGameSaved(GK_SaveResult res)
	{
	}

	private void HandleActionSaveRemoved(GK_SaveRemoveResult res)
	{
	}

	private void HandleActionDataLoaded(GK_SaveDataLoaded res)
	{
	}

	private void HandleActionSavesFetched(GK_FetchResult res)
	{
	}

	private void HandleActionSavesResolved(GK_SavesResolveResult res)
	{
	}
}
