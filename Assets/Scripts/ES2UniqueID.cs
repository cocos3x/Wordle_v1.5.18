using System.Collections.Generic;
using UnityEngine;

public class ES2UniqueID : MonoBehaviour
{
	public int id;

	public string prefabName;

	private static List<ES2UniqueID> uniqueIDList;

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	private static int GenerateUniqueID()
	{
		return 0;
	}

	public static ES2UniqueID FindUniqueID(Transform t)
	{
		return null;
	}

	public static Transform FindTransform(int id)
	{
		return null;
	}
}
