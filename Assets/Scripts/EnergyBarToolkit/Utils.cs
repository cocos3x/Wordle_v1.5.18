using System;
using UnityEngine;

namespace EnergyBarToolkit
{
	public class Utils
	{
		public class TextureReadable : IDisposable
		{
			private readonly bool isReadable;

			private readonly string assetPath;

			public TextureReadable(Texture texture)
			{
			}

			private void DisplayError(Texture texture)
			{
			}

			public void Dispose()
			{
			}
		}

		public static Vector4 ComputePadding(Texture2D texture)
		{
			return (Vector4)null;
		}

		public static Vector4 ComputePadding(Texture2D texture, Rect rect)
		{
			return (Vector4)null;
		}

		private static bool HasVisibleHoriz(int y, Color32[] colors, Rect rect, int stride)
		{
			return false;
		}

		private static bool HasVisibleVert(int x, Color32[] colors, Rect rect, int stride)
		{
			return false;
		}

		private static bool HasVisible(int minX, int minY, int maxX, int maxY, Color32[] colors, int stride)
		{
			return false;
		}

		private static int Index(int x, int y, int w)
		{
			return 0;
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
