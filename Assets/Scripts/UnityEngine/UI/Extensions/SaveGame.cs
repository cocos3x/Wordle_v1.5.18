using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	[Serializable]
	public class SaveGame
	{
		public string savegameName;

		public List<SceneObject> sceneObjects;

		public SaveGame()
		{
		}

		public SaveGame(string s, List<SceneObject> list)
		{
		}
	}
}
