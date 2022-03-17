namespace UnityEditor.XCodeEditor
{
	public class XCBuildConfiguration : PBXObject
	{
		protected const string BUILDSETTINGS_KEY = "buildSettings";

		protected const string HEADER_SEARCH_PATHS_KEY = "HEADER_SEARCH_PATHS";

		protected const string LIBRARY_SEARCH_PATHS_KEY = "LIBRARY_SEARCH_PATHS";

		protected const string FRAMEWORK_SEARCH_PATHS_KEY = "FRAMEWORK_SEARCH_PATHS";

		protected const string OTHER_C_FLAGS_KEY = "OTHER_CFLAGS";

		protected const string OTHER_LDFLAGS_KEY = "OTHER_LDFLAGS";

		public PBXSortedDictionary buildSettings => null;

		public XCBuildConfiguration(string guid, PBXDictionary dictionary)
		{
		}

		protected bool AddSearchPaths(string path, string key, bool recursive = true)
		{
			return false;
		}

		protected bool AddSearchPaths(PBXList paths, string key, bool recursive = true, bool quoted = false)
		{
			return false;
		}

		public bool AddHeaderSearchPaths(PBXList paths, bool recursive = true)
		{
			return false;
		}

		public bool AddLibrarySearchPaths(PBXList paths, bool recursive = true)
		{
			return false;
		}

		public bool AddFrameworkSearchPaths(PBXList paths, bool recursive = true)
		{
			return false;
		}

		public bool AddOtherCFlags(string flag)
		{
			return false;
		}

		public bool AddOtherCFlags(PBXList flags)
		{
			return false;
		}

		public bool AddOtherLinkerFlags(string flag)
		{
			return false;
		}

		public bool AddOtherLinkerFlags(PBXList flags)
		{
			return false;
		}

		public bool overwriteBuildSetting(string settingName, string settingValue)
		{
			return false;
		}
	}
}
