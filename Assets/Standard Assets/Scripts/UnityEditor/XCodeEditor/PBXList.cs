using System.Collections;

namespace UnityEditor.XCodeEditor
{
	public class PBXList : ArrayList
	{
		public PBXList()
		{
		}

		public PBXList(object firstValue)
		{
		}

		public static implicit operator bool(PBXList x)
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
}
