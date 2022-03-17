using System;
using UnityEngine;

namespace EnergyBarToolkit
{
	[Serializable]
	public class ObjectFinder
	{
		[Flags]
		public enum Method
		{
			ByPath = 0x1,
			ByTag = 0x2,
			ByType = 0x4,
			ByReference = 0x8
		}

		public Method chosenMethod;

		public string path;

		public string tag;

		public GameObject reference;

		public string typeString;

		public string assembly;

		public ObjectFinder(Type type, string defaultPath = "", string defaultTag = "", Method defaultMethod = Method.ByType)
		{
		}

		public T Lookup<T>(UnityEngine.Object parent) where T : Component
		{
			return null;
		}

		private T GetComponent<T>(GameObject go) where T : Component
		{
			return null;
		}

		private new Type GetType()
		{
			return null;
		}
	}
}
