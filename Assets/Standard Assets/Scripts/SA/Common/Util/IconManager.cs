using System.Collections.Generic;
using UnityEngine;

namespace SA.Common.Util
{
	public static class IconManager
	{
		private static Dictionary<string, Texture2D> s_icons;

		private static Dictionary<float, Texture2D> s_colorIcons;

		public static Texture2D GetIconFromHtmlColorString(string htmlString)
		{
			return null;
		}

		public static Texture2D GetIconFromHtmlColorString(string htmlString, Color fallback)
		{
			return null;
		}

		public static Texture2D GetIcon(Color color, int width = 1, int height = 1)
		{
			return null;
		}

		public static Texture2D GetIconAtPath(string path)
		{
			return null;
		}

		public static Texture2D Rotate(Texture2D tex, float angle)
		{
			return null;
		}

		private static Color getPixel(Texture2D tex, float x, float y)
		{
			return (Color)null;
		}

		private static float rot_x(float angle, float x, float y)
		{
			return 0f;
		}

		private static float rot_y(float angle, float x, float y)
		{
			return 0f;
		}
	}
}
