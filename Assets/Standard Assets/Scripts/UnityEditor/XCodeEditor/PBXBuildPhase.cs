namespace UnityEditor.XCodeEditor
{
	public class PBXBuildPhase : PBXObject
	{
		protected const string FILES_KEY = "files";

		public PBXList files => null;

		public PBXBuildPhase()
		{
		}

		public PBXBuildPhase(string guid, PBXDictionary dictionary)
		{
		}

		public bool AddBuildFile(PBXBuildFile file)
		{
			return false;
		}

		public void RemoveBuildFile(string id)
		{
		}

		public bool HasBuildFile(string id)
		{
			return false;
		}
	}
}
