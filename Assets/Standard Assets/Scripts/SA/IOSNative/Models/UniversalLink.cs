using System;

namespace SA.IOSNative.Models
{
	public class UniversalLink
	{
		private Uri _URI;

		private string _AbsoluteUrl;

		public bool IsEmpty => false;

		public Uri URI => null;

		public string Host => "";

		public string AbsoluteUrl => "";

		public UniversalLink(string absoluteUrl)
		{
		}
	}
}
