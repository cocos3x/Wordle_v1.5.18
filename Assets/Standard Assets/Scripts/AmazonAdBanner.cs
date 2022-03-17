using System;

public class AmazonAdBanner
{
	public enum BannerAligns
	{
		Top,
		TopLeft,
		TopRight,
		Bottom,
		BottomLeft,
		BottomRight
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<AmazonAdBanner> _003C_003E9__23_0;

		public static Action<AmazonAdBanner> _003C_003E9__23_1;

		public static Action<AmazonAdBanner> _003C_003E9__23_2;

		public static Action<AmazonAdBanner> _003C_003E9__23_3;

		public static Action<AmazonAdBanner> _003C_003E9__23_4;

		internal void _003C_002Ector_003Eb__23_0(AmazonAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__23_1(AmazonAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__23_2(AmazonAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__23_3(AmazonAdBanner _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__23_4(AmazonAdBanner _003Cp0_003E)
		{
		}
	}

	private int _id;

	private BannerAligns _position;

	private AMN_AdProperties _properties;

	private bool _isLoaded;

	private bool _isOnScreen;

	private int _width;

	private int _height;

	public int Id => 0;

	public bool IsLoaded => false;

	public bool IsOnScreen => false;

	public int Width => 0;

	public int Height => 0;

	public AMN_AdProperties Properties => null;

	public event Action<AmazonAdBanner> OnLoadedAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AmazonAdBanner> OnFailedLoadingAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AmazonAdBanner> OnExpandedAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AmazonAdBanner> OnDismissedAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AmazonAdBanner> OnCollapsedAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public AmazonAdBanner(BannerAligns position, int id)
	{
	}

	public void SetProperties(int width, int height, AMN_AdProperties props)
	{
	}

	public void Hide(bool hide)
	{
	}

	public void Destroy()
	{
	}

	public void Refresh()
	{
	}

	public void HandleOnBannerAdLoaded()
	{
	}

	public void HandleOnBannerAdFailedToLoad()
	{
	}

	public void HandleOnBannerAdExpanded()
	{
	}

	public void HandleOnBannerAdDismissed()
	{
	}

	public void HandleOnBannerAdCollapsed()
	{
	}

	private string GetPosition(BannerAligns BannerAlign)
	{
		return "";
	}
}
