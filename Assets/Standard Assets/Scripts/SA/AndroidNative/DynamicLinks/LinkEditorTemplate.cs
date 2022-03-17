using System;
using UnityEngine;

namespace SA.AndroidNative.DynamicLinks
{
	[Serializable]
	public class LinkEditorTemplate
	{
		[SerializeField]
		public string Host;

		[SerializeField]
		public string Scheme;
	}
}
