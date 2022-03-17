using QuickEngine.Common;
using System.Collections.Generic;
using UnityEngine;

namespace DoozyUI
{
	public class SceneLoader : Singleton<SceneLoader>
	{
		public const string DEFAULT_LOAD_SCENE_ASYNC_SCENE_NAME = "LoadSceneAsync_Name_";

		public const string DEFAULT_LOAD_SCENE_ASYNC_SCENE_BUILD_INDEX = "LoadSceneAsync_ID_";

		public const string DEFAULT_LOAD_SCENE_ADDITIVE_ASYNC_SCENE_NAME = "LoadSceneAdditiveAsync_Name_";

		public const string DEFAULT_LOAD_SCENE_ADDITIVE_ASYNC_SCENE_BUILD_INDEX = "LoadSceneAdditiveAsync_ID_";

		public const string DEFAULT_UNLOAD_SCENE_SCENE_NAME = "UnloadScene_Name_";

		public const string DEFAULT_UNLOAD_SCENE_SCENE_BUILD_INDEX = "UnloadScene_ID_";

		public const string DEFAULT_UNLOAD_LEVEL = "UnloadLevel_";

		public const string DEFAULT_LOAD_LEVEL = "LoadLevel_";

		public const string DEFAULT_LEVEL_SCENE_NAME = "Level_";

		public const string DEFAULT_LEVEL_LOADED = "LevelLoaded";

		public List<EnergyBar> energyBars;

		public string command_LoadSceneAsync_SceneName;

		public string command_LoadSceneAsync_SceneBuildIndex;

		public string command_LoadSceneAdditiveAsync_SceneName;

		public string command_LoadSceneAdditiveAsync_SceneBuildIndex;

		public string command_UnloadScene_SceneName;

		public string command_UnloadScene_SceneBuildIndex;

		public string command_LoadLevel;

		public string command_UnloadLevel;

		public string levelSceneName;

		public string levelLoadedGameEvent;

		public AsyncOperation async;

		private int sceneBuildIndex;

		private string sceneName;

		public static SceneLoader AddSceneLoaderToScene()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void CheckIfLevelLoaded()
		{
		}

		private void UpdateEnergyBars()
		{
		}

		public void OnGameEvent(string gameEvent)
		{
		}

		public void LoadSceneAsync(string sceneName)
		{
		}

		public void LoadSceneAsync(int sceneBuildIndex)
		{
		}

		public void LoadLevelAdditiveAsync(string sceneName)
		{
		}

		public void LoadLevelAdditiveAsync(int sceneBuildIndex)
		{
		}

		public void UnloadScene(string sceneName)
		{
		}

		public void UnloadScene(int sceneBuildIndex)
		{
		}

		public void LoadLevel(int levelNumber)
		{
		}

		public void UnloadLevel(int levelNumber)
		{
		}
	}
}
