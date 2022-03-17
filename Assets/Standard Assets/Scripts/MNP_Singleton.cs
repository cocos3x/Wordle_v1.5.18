using UnityEngine;

public abstract class MNP_Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	private static bool applicationIsQuitting;

	public static T Instance => null;

	public static bool HasInstance => false;

	public static bool IsDestroyed => false;

	protected virtual void OnDestroy()
	{
	}

	protected virtual void OnApplicationQuit()
	{
	}
}
