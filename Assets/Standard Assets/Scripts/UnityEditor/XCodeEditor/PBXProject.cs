namespace UnityEditor.XCodeEditor
{
	public class PBXProject : PBXObject
	{
		protected string MAINGROUP_KEY;

		protected string KNOWN_REGIONS_KEY;

		protected bool _clearedLoc;

		public string mainGroupID => "";

		public PBXList knownRegions => null;

		public PBXProject()
		{
		}

		public PBXProject(string guid, PBXDictionary dictionary)
		{
		}

		public void AddRegion(string region)
		{
		}
	}
}
