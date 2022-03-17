using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.UI.Extensions
{
	public class SaveLoadMenu : MonoBehaviour
	{
		private sealed class _003Cwait_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

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
			public _003Cwait_003Ed__7(int _003C_003E1__state)
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

		public bool showMenu;

		public bool usePersistentDataPath;

		public string savePath;

		public Dictionary<string, GameObject> prefabDictionary;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnGUI()
		{
		}

		private IEnumerator wait(float time)
		{
			return null;
		}

		public void SaveGame()
		{
		}

		public void SaveGame(string saveGameName)
		{
		}

		public void LoadGame()
		{
		}

		public void LoadGame(string saveGameName)
		{
		}

		public void ClearScene()
		{
		}

		public SceneObject PackGameObject(GameObject go)
		{
			return null;
		}

		public ObjectComponent PackComponent(object component)
		{
			return null;
		}

		public GameObject UnpackGameObject(SceneObject sceneObject)
		{
			return null;
		}

		public void UnpackComponents(ref GameObject go, SceneObject sceneObject)
		{
		}
	}
}
