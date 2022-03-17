using System.Collections;

namespace UnityEditor.XCodeEditor
{
	public class XCMod
	{
		private Hashtable _datastore;

		private ArrayList _libs;

		private string _003Cname_003Ek__BackingField;

		private string _003Cpath_003Ek__BackingField;

		public string name
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public string path
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public string group => "";

		public ArrayList patches => null;

		public ArrayList libs => null;

		public ArrayList frameworks => null;

		public ArrayList headerpaths => null;

		public ArrayList files => null;

		public ArrayList folders => null;

		public ArrayList excludes => null;

		public ArrayList compiler_flags => null;

		public ArrayList linker_flags => null;

		public ArrayList embed_binaries => null;

		public Hashtable plist => null;

		public XCMod(string filename)
		{
		}
	}
}
