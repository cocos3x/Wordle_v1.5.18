using UnityEngine;

public class WPN_Singletone<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	public static T instance => null;

	public static bool HasInstance => false;
}
