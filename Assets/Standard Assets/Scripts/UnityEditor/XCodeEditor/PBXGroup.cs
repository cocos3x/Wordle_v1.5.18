using System.Runtime.InteropServices;

namespace UnityEditor.XCodeEditor
{
	public class PBXGroup : PBXObject
	{
		protected const string NAME_KEY = "name";

		protected const string CHILDREN_KEY = "children";

		protected const string PATH_KEY = "path";

		protected const string SOURCETREE_KEY = "sourceTree";

		public PBXList children => null;

		public string name => "";

		public string path => "";

		public string sourceTree => "";

		public PBXGroup(string name, [Optional] string path, string tree = "SOURCE_ROOT")
		{
		}

		public PBXGroup(string guid, PBXDictionary dictionary)
		{
		}

		public string AddChild(PBXObject child)
		{
			return "";
		}

		public void RemoveChild(string id)
		{
		}

		public bool HasChild(string id)
		{
			return false;
		}

		public string GetName()
		{
			return "";
		}
	}
}
