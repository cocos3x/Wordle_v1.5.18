using System.Collections.Generic;

namespace UnityEditor.XCodeEditor
{
	public class PBXDictionary : Dictionary<string, object>
	{
		public void Append(PBXDictionary dictionary)
		{
		}

		public void Append<T>(PBXDictionary<T> dictionary) where T : PBXObject
		{
		}

		public void Append(PBXSortedDictionary dictionary)
		{
		}

		public void Append<T>(PBXSortedDictionary<T> dictionary) where T : PBXObject
		{
		}

		public static implicit operator bool(PBXDictionary x)
		{
			return false;
		}

		public string ToCSV()
		{
			return "";
		}

		public override string ToString()
		{
			return "";
		}
	}
	public class PBXDictionary<T> : Dictionary<string, T> where T : PBXObject
	{
		public PBXDictionary()
		{
		}

		public PBXDictionary(PBXDictionary genericDictionary)
		{
		}

		public PBXDictionary(PBXSortedDictionary genericDictionary)
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
