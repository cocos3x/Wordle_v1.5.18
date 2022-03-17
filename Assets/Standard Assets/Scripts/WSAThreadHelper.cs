using System;
using System.Collections.Generic;
using UnityEngine;

public class WSAThreadHelper : MonoBehaviour
{
	public struct DelayedQueueItem
	{
		public float time;

		public Action action;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<DelayedQueueItem, bool> _003C_003E9__18_0;

		internal bool _003CUpdate_003Eb__18_0(DelayedQueueItem d)
		{
			return false;
		}
	}

	public static int maxThreads;

	private static int numThreads;

	private static WSAThreadHelper _current;

	private int _count;

	private static bool initialized;

	private List<Action> _actions;

	private List<DelayedQueueItem> _delayed;

	private List<DelayedQueueItem> _currentDelayed;

	private List<Action> _currentActions;

	public static WSAThreadHelper Current => null;

	private void Awake()
	{
	}

	private static void Initialize()
	{
	}

	public static void QueueOnMainThread(Action action)
	{
	}

	public static void QueueOnMainThread(Action action, float time)
	{
	}

	private static void RunAction(object action)
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}
}
