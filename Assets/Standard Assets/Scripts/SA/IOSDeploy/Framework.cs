using System;

namespace SA.IOSDeploy
{
	[Serializable]
	public class Framework
	{
		public bool IsOpen;

		public iOSFramework Type;

		public bool IsOptional;

		public bool IsEmbeded;

		public string Name => "";

		public string TypeString => "";

		public Framework(iOSFramework type, bool Embaded = false)
		{
		}

		public Framework(string frameworkName)
		{
		}

		public int[] BaseIndexes()
		{
			return null;
		}
	}
}
