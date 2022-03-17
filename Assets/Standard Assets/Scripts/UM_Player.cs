using System;
using UnityEngine;

public class UM_Player
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<Texture2D> _003C_003E9__9_0;

		public static Action<Texture2D> _003C_003E9__9_1;

		internal void _003C_002Ector_003Eb__9_0(Texture2D _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__9_1(Texture2D _003Cp0_003E)
		{
		}
	}

	private GK_Player _GK_Player;

	private GooglePlayerTemplate _GP_Player;

	private GC_Player _GC_Player;

	public string PlayerId => "";

	public string Name => "";

	public Texture2D Avatar => null;

	public Texture2D SmallPhoto => null;

	public Texture2D BigPhoto => null;

	public GK_Player GameCenterPlayer => null;

	public GooglePlayerTemplate GooglePlayPlayer => null;

	public GC_Player GameCirclePlayer => null;

	public event Action<Texture2D> BigPhotoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<Texture2D> SmallPhotoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public UM_Player(GK_Player gk, GooglePlayerTemplate gp, GC_Player gc)
	{
	}

	public void LoadBigPhoto()
	{
	}

	public void LoadSmallPhoto()
	{
	}

	private void HandleSmallPhotoLoaded(Texture2D tex)
	{
	}

	private void HandleBigPhotoLoaded(Texture2D tex)
	{
	}

	private void HandleOnPlayerPhotoLoaded(GK_UserPhotoLoadResult res)
	{
	}

	private void AmazonPlayerAvatarLoaded(Texture2D avatar)
	{
	}
}
