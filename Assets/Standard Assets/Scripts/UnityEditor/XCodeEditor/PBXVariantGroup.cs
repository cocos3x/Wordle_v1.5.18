using System.Runtime.InteropServices;

namespace UnityEditor.XCodeEditor
{
	public class PBXVariantGroup : PBXGroup
	{
		public PBXVariantGroup(string name, [Optional] string path, string tree = "SOURCE_ROOT")
		{
		}

		public PBXVariantGroup(string guid, PBXDictionary dictionary)
		{
		}
	}
}
