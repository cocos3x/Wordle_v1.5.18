using System;
using UnityEngine;

public class GC_Player
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<Texture2D> _003C_003E9__17_0;

		internal void _003C_002Ector_003Eb__17_0(Texture2D _003Cp0_003E)
		{
		}
	}

	private string _playerId;

	private string _name;

	private string _avatarUrl;

	private Texture2D _avatar;

	public string PlayerId => "";

	public string Name => "";

	public string AvatarUrl => "";

	public Texture2D Avatar => null;

	public event Action<Texture2D> AvatarLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public void LoadAvatar()
	{
	}

	private void OnProfileImageLoaded(Texture2D texture)
	{
	}
}
