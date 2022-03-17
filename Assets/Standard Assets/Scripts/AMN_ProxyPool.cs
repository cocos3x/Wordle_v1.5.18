using System.Collections.Generic;
using UnityEngine;

public abstract class AMN_ProxyPool
{
	private static Dictionary<string, AndroidJavaObject> pool;

	private static bool isInitialized;

	public static void CallStatic(string className, string methodName, params object[] args)
	{
	}
}
