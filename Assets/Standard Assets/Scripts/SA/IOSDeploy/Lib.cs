using System;

namespace SA.IOSDeploy
{
	[Serializable]
	public class Lib
	{
		public bool IsOpen;

		public iOSLibrary Type;

		public bool IsOptional;

		public string Name => "";

		public Lib(iOSLibrary lib)
		{
		}
	}
}