using System.Collections.Generic;
using UnityEngine;

public abstract class MNProxyPool
{
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public string methodName;

		public object[] args;
	}

	private sealed class _003C_003Ec__DisplayClass1_1
	{
		public AndroidJavaObject bridge;

		public _003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals1;

		internal void _003CCallStatic_003Eb__0()
		{
		}
	}

	private static Dictionary<string, AndroidJavaObject> pool;

	public static void CallStatic(string className, string methodName, params object[] args)
	{
	}
}
