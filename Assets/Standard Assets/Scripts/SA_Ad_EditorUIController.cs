using System;
using UnityEngine;
using UnityEngine.UI;

public class SA_Ad_EditorUIController : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<bool> _003C_003E9__24_0;

		public static Action _003C_003E9__24_1;

		public static Action<bool> _003C_003E9__24_2;

		public static Action _003C_003E9__24_3;

		internal void _003C_002Ector_003Eb__24_0(bool _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__24_1()
		{
		}

		internal void _003C_002Ector_003Eb__24_2(bool _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__24_3()
		{
		}
	}

	public GameObject VideoPanel;

	public GameObject InterstitialPanel;

	public Image[] AppIcons;

	public Text[] AppNames;

	public event Action<bool> OnCloseVideo
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnVideoLeftApplication
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<bool> OnCloseInterstitial
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnInterstitialLeftApplication
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void InterstitialClick()
	{
	}

	public void VideoClick()
	{
	}

	public void ShowInterstitialAd()
	{
	}

	public void ShowVideoAd()
	{
	}

	public void CloseInterstitial()
	{
	}

	public void CloseVideo()
	{
	}
}
