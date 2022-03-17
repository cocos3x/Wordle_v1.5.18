using System;
using UnityEngine;

public class PreviewScreenUtil : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__13_0;

		internal void _003C_002Ector_003Eb__13_0()
		{
		}
	}

	private static PreviewScreenUtil _instance;

	private int W;

	private int H;

	public static PreviewScreenUtil instance => null;

	public event Action ActionScreenResized
	{
		add
		{
		}
		remove
		{
		}
	}

	public static bool isInScreenRect(Rect rect, Vector2 point)
	{
		return false;
	}

	public static Rect getObjectBounds(GameObject obj)
	{
		return (Rect)null;
	}

	public static Rect getRendererBounds(Renderer renderer)
	{
		return (Rect)null;
	}

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
