using System;

namespace SA.IOSNative.Models
{
	public class LaunchUrl
	{
		private Uri _URI;

		private string _AbsoluteUrl;

		private string _SourceApplication;

		public bool IsEmpty => false;

		public Uri URI => null;

		public string Host => "";

		public string AbsoluteUrl => "";

		public string SourceApplication => "";

		public LaunchUrl(string data)
		{
		}

		public LaunchUrl(string absoluteUrl, string sourceApplication)
		{
		}
	}
}
