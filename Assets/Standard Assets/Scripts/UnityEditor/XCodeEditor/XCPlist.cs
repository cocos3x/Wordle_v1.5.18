using System.Collections;
using System.Collections.Generic;

namespace UnityEditor.XCodeEditor
{
	public class XCPlist
	{
		private string plistPath;

		private bool plistModified;

		private const string BundleUrlTypes = "CFBundleURLTypes";

		private const string BundleTypeRole = "CFBundleTypeRole";

		private const string BundleUrlName = "CFBundleURLName";

		private const string BundleUrlSchemes = "CFBundleURLSchemes";

		private const string PlistUrlType = "urltype";

		private const string PlistRole = "role";

		private const string PlistEditor = "Editor";

		private const string PlistName = "name";

		private const string PlistSchemes = "schemes";

		public XCPlist(string plistPath)
		{
		}

		public void Process(Hashtable plist)
		{
		}

		public static Dictionary<K, V> HashtableToDictionary<K, V>(Hashtable table)
		{
			return null;
		}

		public void AddPlistItems(string key, object value, Dictionary<string, object> dict)
		{
		}

		private void processUrlTypes(ArrayList urltypes, Dictionary<string, object> dict)
		{
		}

		private Dictionary<string, object> findUrlTypeByName(List<object> bundleUrlTypes, string name)
		{
			return null;
		}
	}
}
