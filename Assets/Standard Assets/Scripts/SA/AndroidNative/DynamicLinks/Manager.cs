using SA.Common.Pattern;
using System;

namespace SA.AndroidNative.DynamicLinks
{
	public class Manager : Singleton<Manager>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<ShortLinkResult> _003C_003E9__5_0;

			internal void _003C_002Ector_003Eb__5_0(ShortLinkResult _003Cp0_003E)
			{
			}
		}

		public Action<ShortLinkResult> OnShortLinkReceived;

		private void Awake()
		{
		}

		public string GetPendingDynamicLink()
		{
			return "";
		}

		public void RequestShortDynamicLink(Link link)
		{
		}

		public void ShortLinkReceived(string data)
		{
		}
	}
}
