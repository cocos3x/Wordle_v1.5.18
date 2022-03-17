using System;
using System.Collections.Generic;

namespace SA.IOSNative.Models
{
	[Serializable]
	public class UrlType
	{
		public string Identifier;

		public List<string> Schemes;

		public bool IsOpen;

		public UrlType(string identifier)
		{
		}

		public void AddSchemes(string schemes)
		{
		}
	}
}
