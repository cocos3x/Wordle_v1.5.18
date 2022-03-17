using System.Collections.Generic;

namespace UnityEditor.XCodeEditor
{
	public class PBXResolver
	{
		private class PBXResolverReverseIndex : Dictionary<string, string>
		{
		}

		private PBXDictionary objects;

		private string rootObject;

		private PBXResolverReverseIndex index;

		public PBXResolver(PBXDictionary pbxData)
		{
		}

		private void BuildReverseIndex()
		{
		}

		public string ResolveName(string guid)
		{
			return "";
		}

		public string ResolveBuildPhaseNameForFile(string guid)
		{
			return "";
		}
	}
}
