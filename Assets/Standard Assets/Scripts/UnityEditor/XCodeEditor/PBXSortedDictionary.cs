using System.Collections.Generic;

namespace UnityEditor.XCodeEditor
{
	public class PBXSortedDictionary : SortedDictionary<string, object>
	{
		public void Append(PBXDictionary dictionary)
		{
		}

		public void Append<T>(PBXDictionary<T> dictionary) where T : PBXObject
		{
		}
	}
	public class PBXSortedDictionary<T> : SortedDictionary<string, T> where T : PBXObject
	{
		public PBXSortedDictionary()
		{
		}

		public PBXSortedDictionary(PBXDictionary genericDictionary)
		{
		}

		public void Add(T newObject)
		{
		}

		public void Append(PBXDictionary<T> dictionary)
		{
		}
	}
}
