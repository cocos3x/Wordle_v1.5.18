namespace UnityEditor.XCodeEditor
{
	public class PBXObject
	{
		protected const string ISA_KEY = "isa";

		protected string _guid;

		protected PBXDictionary _data;

		public string guid => "";

		public PBXDictionary data => null;

		public PBXObject()
		{
		}

		public PBXObject(string guid)
		{
		}

		public PBXObject(string guid, PBXDictionary dictionary)
		{
		}

		public static bool IsGuid(string aString)
		{
			return false;
		}

		public static string GenerateGuid()
		{
			return "";
		}

		public void Add(string key, object obj)
		{
		}

		public bool Remove(string key)
		{
			return false;
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public static implicit operator bool(PBXObject x)
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
