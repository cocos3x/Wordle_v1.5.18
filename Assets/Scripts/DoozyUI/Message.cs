using System;
using System.Collections.Generic;

namespace DoozyUI
{
	public class Message
	{
		public delegate void OnMessageHandleDelegate(Type callerType, Type handlerType, Type messageType, string messageName, string handlerMethodName);

		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public Delegate callback;

			internal bool _003CUnregisterListener_003Eb__0(Delegate x)
			{
				return false;
			}
		}

		public static OnMessageHandleDelegate OnMessageHandle;

		private static Dictionary<string, List<Delegate>> handlers;

		private const string TypelessMessagePrefix = "typeless ";

		public static void AddListener(string messageName, Action callback)
		{
		}

		public static void AddListener<T>(Action<T> callback) where T : Message
		{
		}

		public static void AddListener<T>(string messageName, Action<T> callback) where T : Message
		{
		}

		public static void RemoveListener(string messageName, Action callback)
		{
		}

		public static void RemoveListener<T>(Action<T> callback) where T : Message
		{
		}

		public static void RemoveListener<T>(string messageName, Action<T> callback) where T : Message
		{
		}

		public static void Send(string messageName)
		{
		}

		public static void Send<T>(T message) where T : Message
		{
		}

		public static void Send<T>(string messageName, T message) where T : Message
		{
		}

		private static void RegisterListener(string messageName, Delegate callback)
		{
		}

		private static void UnregisterListener(string messageName, Delegate callback)
		{
		}

		private static void SendMessage<T>(string messageName, T e) where T : Message
		{
		}

		protected Message()
		{
		}
	}
}
