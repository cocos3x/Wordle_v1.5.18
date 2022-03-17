using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA.IOSDeploy
{
	public class ISD_Settings : ScriptableObject
	{
		public const string VERSION_NUMBER = "3.5/24";

		public bool IsfwSettingOpen;

		public bool IsLibSettingOpen;

		public bool IslinkerSettingOpne;

		public bool IscompilerSettingsOpen;

		public bool IsPlistSettingsOpen;

		public bool IsLanguageSettingOpen;

		public bool IsDefFrameworksOpen;

		public bool IsDefLibrariesOpen;

		public bool IsBuildSettingsOpen;

		public int ToolbarIndex;

		public bool enableBitCode;

		public bool enableTestability;

		public bool generateProfilingCode;

		public List<Framework> Frameworks;

		public List<Lib> Libraries;

		public List<Flag> Flags;

		public List<Variable> PlistVariables;

		public List<VariableId> VariableDictionary;

		public List<string> langFolders;

		public List<AssetFile> Files;

		private const string ISDAssetName = "ISD_Settings";

		private const string ISDAssetExtension = ".asset";

		private static ISD_Settings instance;

		public static ISD_Settings Instance => null;

		public void AddVariable(Variable var)
		{
		}

		public void AddVariableToDictionary(string uniqueIdKey, Variable var)
		{
		}

		public void RemoveVariable(Variable v, IList ListWithThisVariable)
		{
		}

		public Variable getVariableByKey(string uniqueIdKey)
		{
			return null;
		}

		public Variable GetVariableByName(string name)
		{
			return null;
		}

		public string getKeyFromVariable(Variable var)
		{
			return "";
		}

		public bool ContainsPlistVarWithName(string name)
		{
			return false;
		}

		public bool ContainsFramework(iOSFramework framework)
		{
			return false;
		}

		public Framework GetFramework(iOSFramework framework)
		{
			return null;
		}

		public Framework AddFramework(iOSFramework framework, bool embaded = false)
		{
			return null;
		}

		public bool ContainsLibWithName(string name)
		{
			return false;
		}

		public Lib GetLibrary(iOSLibrary library)
		{
			return null;
		}

		public Lib AddLibrary(iOSLibrary library)
		{
			return null;
		}

		public void AddLinkerFlag(string s)
		{
		}
	}
}
