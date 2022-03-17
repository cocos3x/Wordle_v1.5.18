namespace UnityEditor.XCodeEditor
{
	public class PBXBuildFile : PBXObject
	{
		private const string FILE_REF_KEY = "fileRef";

		private const string SETTINGS_KEY = "settings";

		private const string ATTRIBUTES_KEY = "ATTRIBUTES";

		private const string WEAK_VALUE = "Weak";

		private const string COMPILER_FLAGS_KEY = "COMPILER_FLAGS";

		public string fileRef => "";

		public PBXBuildFile(PBXFileReference fileRef, bool weak = false)
		{
		}

		public PBXBuildFile(string guid, PBXDictionary dictionary)
		{
		}

		public bool SetWeakLink(bool weak = false)
		{
			return false;
		}

		public bool AddCodeSignOnCopy()
		{
			return false;
		}

		public bool AddCompilerFlag(string flag)
		{
			return false;
		}
	}
}
