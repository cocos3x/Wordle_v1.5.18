using UnityEngine;

public class GP_Event
{
	public string Id;

	public string Description;

	public string IconImageUrl;

	public string FormattedValue;

	public long Value;

	private Texture2D _icon;

	public Texture2D icon => null;

	public void LoadIcon()
	{
	}

	private void OnTextureLoaded(Texture2D tex)
	{
	}
}
