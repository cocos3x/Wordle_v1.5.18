using System;
using UnityEngine;

public class DefaultPreviewButton : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__22_0;

		internal void _003C_002Ector_003Eb__22_0()
		{
		}
	}

	public Texture normalTexture;

	public Texture pressedTexture;

	public Texture disabledTexture;

	public Texture selectedTexture;

	private Texture normalTex;

	public AudioClip sound;

	public AudioClip disabledsound;

	private bool IsDisabled;

	public string text
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public event Action ActionClick
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

	public void Select()
	{
	}

	public void Unselect()
	{
	}

	public void DisabledButton()
	{
	}

	public void EnabledButton()
	{
	}

	private void Update()
	{
	}

	protected virtual void OnClick()
	{
	}

	private void OnTimeoutPress()
	{
	}
}
