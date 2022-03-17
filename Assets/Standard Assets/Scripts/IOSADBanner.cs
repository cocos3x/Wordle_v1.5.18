using System;
using UnityEngine;

public class IOSADBanner : GoogleMobileAdBanner
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<GoogleMobileAdBanner> _003C_003E9__15_0;

		public static Action<GoogleMobileAdBanner> _003C_003E9__15_1;

		public static Action<GoogleMobileAdBanner> _003C_003E9__15_2;

		public static Action<GoogleMobileAdBanner> _003C_003E9__15_3;

		public static Action<GoogleMobileAdBanner> _003C_003E9__15_4;

		public static Action<GoogleMobileAdBanner> _003C_003E9__16_0;

		public static Action<GoogleMobileAdBanner> _003C_003E9__16_1;

		public static Action<GoogleMobileAdBanner> _003C_003E9__16_2;

		public static Action<GoogleMobileAdBanner> _003C_003E9__16_3;

		public static Action<GoogleMobileAdBanner> _003C_003E9__16_4;

		internal void _003C_002Ector_003Eb__15_0(GoogleMobileAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__15_1(GoogleMobileAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__15_2(GoogleMobileAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__15_3(GoogleMobileAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__15_4(GoogleMobileAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__16_0(GoogleMobileAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__16_1(GoogleMobileAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__16_2(GoogleMobileAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__16_3(GoogleMobileAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__16_4(GoogleMobileAdBanner _003Cp0_003E)
		{
		}
	}

	private int _id;

	private GADBannerSize _size;

	private TextAnchor _anchor;

	private bool _IsLoaded;

	private bool _IsOnScreen;

	private bool firstLoad;

	private bool _ShowOnLoad;

	private bool destroyOnLoad;

	private int _width;

	private int _height;

	private Action<GoogleMobileAdBanner> _OnLoadedAction;

	private Action<GoogleMobileAdBanner> _OnFailedLoadingAction;

	private Action<GoogleMobileAdBanner> _OnOpenedAction;

	private Action<GoogleMobileAdBanner> _OnClosedAction;

	private Action<GoogleMobileAdBanner> _OnLeftApplicationAction;

	public int id => 0;

	public int width => 0;

	public int height => 0;

	public GADBannerSize size => (GADBannerSize)null;

	public bool IsLoaded => false;

	public bool IsOnScreen => false;

	public bool ShowOnLoad
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public TextAnchor anchor => (TextAnchor)null;

	public GoogleGravity gravity => (GoogleGravity)null;

	public Action<GoogleMobileAdBanner> OnLoadedAction
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action<GoogleMobileAdBanner> OnFailedLoadingAction
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action<GoogleMobileAdBanner> OnOpenedAction
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action<GoogleMobileAdBanner> OnClosedAction
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action<GoogleMobileAdBanner> OnLeftApplicationAction
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public IOSADBanner(TextAnchor anchor, GADBannerSize size, int id)
	{
	}

	public IOSADBanner(int x, int y, GADBannerSize size, int id)
	{
	}

	public void Hide()
	{
	}

	public void Show()
	{
	}

	public void Refresh()
	{
	}

	public void SetBannerPosition(int x, int y)
	{
	}

	public void SetBannerPosition(TextAnchor anchor)
	{
	}

	public void DestroyAfterLoad()
	{
	}

	public void SetDimentions(int w, int h)
	{
	}

	public void OnBannerAdLoaded()
	{
	}

	public void OnBannerAdFailedToLoad()
	{
	}

	public void OnBannerAdOpened()
	{
	}

	public void OnBannerAdClosed()
	{
	}

	public void OnBannerAdLeftApplication()
	{
	}
}
