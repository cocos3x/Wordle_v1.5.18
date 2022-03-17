using System;
using UnityEngine;

namespace SA.Common.Models
{
	public class Invoker : MonoBehaviour
	{
		private Action _callback;

		public static Invoker Create(string name)
		{
			return null;
		}

		private void Awake()
		{
		}

		public void StartInvoke(Action callback, float time)
		{
		}

		private void TimeOut()
		{
		}
	}
}
