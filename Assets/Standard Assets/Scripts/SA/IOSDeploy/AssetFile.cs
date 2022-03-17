using System;
using UnityEngine;

namespace SA.IOSDeploy
{
	[Serializable]
	public class AssetFile
	{
		public bool IsOpen;

		public string XCodePath;

		public UnityEngine.Object Asset;

		public string FileName => "";

		public string FilePath => "";

		public string XCodeRelativePath => "";

		public bool IsDirectory => false;
	}
}
