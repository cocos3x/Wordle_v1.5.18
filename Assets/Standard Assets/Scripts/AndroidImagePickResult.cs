using UnityEngine;

public class AndroidImagePickResult : AndroidActivityResult
{
	private Texture2D _Image;

	private string _ImagePath;

	public Texture2D image => null;

	public Texture2D Image => null;

	public string ImagePath => "";

	public AndroidImagePickResult(string codeString, string ImageData, string ImagePathInfo)
	{
	}
}
