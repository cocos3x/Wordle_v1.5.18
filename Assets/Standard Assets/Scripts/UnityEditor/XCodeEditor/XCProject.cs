using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace UnityEditor.XCodeEditor
{
	public class XCProject : IDisposable
	{
		private PBXDictionary _datastore;

		public PBXDictionary _objects;

		private PBXGroup _rootGroup;

		private string _rootObjectKey;

		private string _003CprojectRootPath_003Ek__BackingField;

		private FileInfo projectFileInfo;

		private string _003CfilePath_003Ek__BackingField;

		private bool modified;

		private PBXSortedDictionary<PBXBuildFile> _buildFiles;

		private PBXSortedDictionary<PBXGroup> _groups;

		private PBXSortedDictionary<PBXFileReference> _fileReferences;

		private PBXDictionary<PBXNativeTarget> _nativeTargets;

		private PBXDictionary<PBXFrameworksBuildPhase> _frameworkBuildPhases;

		private PBXDictionary<PBXResourcesBuildPhase> _resourcesBuildPhases;

		private PBXDictionary<PBXShellScriptBuildPhase> _shellScriptBuildPhases;

		private PBXDictionary<PBXSourcesBuildPhase> _sourcesBuildPhases;

		private PBXDictionary<PBXCopyFilesBuildPhase> _copyBuildPhases;

		private PBXDictionary<PBXVariantGroup> _variantGroups;

		private PBXDictionary<XCBuildConfiguration> _buildConfigurations;

		private PBXSortedDictionary<XCConfigurationList> _configurationLists;

		private PBXProject _project;

		public string projectRootPath
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public string filePath
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public PBXProject project => null;

		public PBXGroup rootGroup => null;

		public PBXSortedDictionary<PBXBuildFile> buildFiles => null;

		public PBXSortedDictionary<PBXGroup> groups => null;

		public PBXSortedDictionary<PBXFileReference> fileReferences => null;

		public PBXDictionary<PBXVariantGroup> variantGroups => null;

		public PBXDictionary<PBXNativeTarget> nativeTargets => null;

		public PBXDictionary<XCBuildConfiguration> buildConfigurations => null;

		public PBXSortedDictionary<XCConfigurationList> configurationLists => null;

		public PBXDictionary<PBXFrameworksBuildPhase> frameworkBuildPhases => null;

		public PBXDictionary<PBXResourcesBuildPhase> resourcesBuildPhases => null;

		public PBXDictionary<PBXShellScriptBuildPhase> shellScriptBuildPhases => null;

		public PBXDictionary<PBXSourcesBuildPhase> sourcesBuildPhases => null;

		public PBXDictionary<PBXCopyFilesBuildPhase> copyBuildPhases => null;

		public Dictionary<string, object> objects => null;

		public XCProject()
		{
		}

		public XCProject(string filePath)
		{
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

		public bool overwriteBuildSetting(string settingName, string newValue, string buildConfigName = "all")
		{
			return false;
		}

		public bool AddHeaderSearchPaths(string path)
		{
			return false;
		}

		public bool AddHeaderSearchPaths(PBXList paths)
		{
			return false;
		}

		public bool AddLibrarySearchPaths(string path)
		{
			return false;
		}

		public bool AddLibrarySearchPaths(PBXList paths)
		{
			return false;
		}

		public bool AddFrameworkSearchPaths(string path)
		{
			return false;
		}

		public bool AddFrameworkSearchPaths(PBXList paths)
		{
			return false;
		}

		public object GetObject(string guid)
		{
			return null;
		}

		public PBXDictionary AddFile(string filePath, [Optional] PBXGroup parent, string tree = "SOURCE_ROOT", bool createBuildFiles = true, bool weak = false)
		{
			return null;
		}

		public PBXNativeTarget GetNativeTarget(string name)
		{
			return null;
		}

		public int GetBuildActionMask()
		{
			return 0;
		}

		public PBXCopyFilesBuildPhase AddEmbedFrameworkBuildPhase()
		{
			return null;
		}

		public void AddEmbedFramework(string fileName)
		{
		}

		private void BuildAddFile(PBXFileReference fileReference, KeyValuePair<string, PBXFrameworksBuildPhase> currentObject, bool weak)
		{
		}

		private void BuildAddFile(PBXFileReference fileReference, KeyValuePair<string, PBXResourcesBuildPhase> currentObject, bool weak)
		{
		}

		private void BuildAddFile(PBXFileReference fileReference, KeyValuePair<string, PBXShellScriptBuildPhase> currentObject, bool weak)
		{
		}

		private void BuildAddFile(PBXFileReference fileReference, KeyValuePair<string, PBXSourcesBuildPhase> currentObject, bool weak)
		{
		}

		private void BuildAddFile(PBXFileReference fileReference, KeyValuePair<string, PBXCopyFilesBuildPhase> currentObject, bool weak)
		{
		}

		public bool AddFolder(string folderPath, [Optional] PBXGroup parent, [Optional] string[] exclude, bool recursive = true, bool createBuildFile = true)
		{
			return false;
		}

		public bool AddLocFolder(string folderPath, [Optional] PBXGroup parent, [Optional] string[] exclude, bool createBuildFile = true)
		{
			return false;
		}

		public PBXFileReference GetFile(string name)
		{
			return null;
		}

		public PBXGroup GetGroup(string name, [Optional] string path, [Optional] PBXGroup parent)
		{
			return null;
		}

		public void ApplyMod(string pbxmod)
		{
		}

		public void ApplyMod(XCMod mod)
		{
		}

		public void Consolidate()
		{
		}

		public void Backup()
		{
		}

		private void DeleteExisting(string path)
		{
		}

		private void CreateNewProject(PBXDictionary result, string path)
		{
		}

		public void Save()
		{
		}

		public void Dispose()
		{
		}
	}
}
