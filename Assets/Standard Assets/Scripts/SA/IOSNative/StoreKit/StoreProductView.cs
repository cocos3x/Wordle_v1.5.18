using System;
using System.Collections.Generic;

namespace SA.IOSNative.StoreKit
{
	public class StoreProductView
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action _003C_003E9__14_0;

			public static Action _003C_003E9__14_1;

			public static Action _003C_003E9__14_2;

			public static Action _003C_003E9__14_3;

			public static Action _003C_003E9__15_0;

			public static Action _003C_003E9__15_1;

			public static Action _003C_003E9__15_2;

			public static Action _003C_003E9__15_3;

			internal void _003C_002Ector_003Eb__14_0()
			{
			}

			internal void _003C_002Ector_003Eb__14_1()
			{
			}

			internal void _003C_002Ector_003Eb__14_2()
			{
			}

			internal void _003C_002Ector_003Eb__14_3()
			{
			}

			internal void _003C_002Ector_003Eb__15_0()
			{
			}

			internal void _003C_002Ector_003Eb__15_1()
			{
			}

			internal void _003C_002Ector_003Eb__15_2()
			{
			}

			internal void _003C_002Ector_003Eb__15_3()
			{
			}
		}

		private int _id;

		private List<string> _ids;

		public int Id => 0;

		public event Action Loaded
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action LoadFailed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action Appeared
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action Dismissed
		{
			add
			{
			}
			remove
			{
			}
		}

		public StoreProductView()
		{
		}

		public StoreProductView(params string[] ids)
		{
		}

		public void addProductId(string productId)
		{
		}

		public void Load()
		{
		}

		public void Show()
		{
		}

		public void OnProductViewAppeard()
		{
		}

		public void OnProductViewDismissed()
		{
		}

		public void OnContentLoaded()
		{
		}

		public void OnContentLoadFailed()
		{
		}

		public void SetId(int viewId)
		{
		}
	}
}
