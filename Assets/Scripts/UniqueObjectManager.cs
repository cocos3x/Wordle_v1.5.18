using System.Collections.Generic;
using UnityEngine;

public class UniqueObjectManager : MonoBehaviour
{
	public GameObject[] sceneObjects;

	public GameObject[] prefabs;

	public static List<GameObject> createdObjects;

	public static UniqueObjectManager mgr;

	public static GameObject[] SceneObjects => null;

	public static GameObject[] Prefabs => null;

	public static List<GameObject> CreatedObjects => null;

	public static GameObject InstantiatePrefab(string prefabName, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public static GameObject InstantiatePrefab(string prefabName)
	{
		return null;
	}

	public static void DestroyObject(GameObject obj)
	{
	}

	public static GameObject FindPrefabWithName(string prefabName)
	{
		return null;
	}

	public void Awake()
	{
	}
}
