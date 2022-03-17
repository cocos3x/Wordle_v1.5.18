using System.Collections.Generic;

namespace UnityEditor.XCodeEditor
{
	public class PBXFileReference : PBXObject
	{
		protected const string PATH_KEY = "path";

		protected const string NAME_KEY = "name";

		protected const string SOURCETREE_KEY = "sourceTree";

		protected const string EXPLICIT_FILE_TYPE_KEY = "explicitFileType";

		protected const string LASTKNOWN_FILE_TYPE_KEY = "lastKnownFileType";

		protected const string ENCODING_KEY = "fileEncoding";

		public string compilerFlags;

		public string buildPhase;

		public readonly Dictionary<TreeEnum, string> trees;

		public static readonly Dictionary<string, string> typeNames;

		public static readonly Dictionary<string, string> typePhases;

		public string name => "";

		public string path => "";

		public PBXFileReference(string guid, PBXDictionary dictionary)
		{
		}

		public PBXFileReference(string filePath, TreeEnum tree = TreeEnum.SOURCE_ROOT)
		{
		}

		private void GuessFileType()
		{
		}

		private void SetFileType(string fileType)
		{
		}
	}
}
