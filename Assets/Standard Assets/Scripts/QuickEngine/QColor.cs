using System;
using UnityEngine;

namespace QuickEngine
{
	[Serializable]
	public class QColor
	{
		private Color color;

		private Color colorDark;

		private Color colorLight;

		public Color Color => (Color)null;

		public Color ColorDark => (Color)null;

		public Color ColorLight => (Color)null;

		public float ColorBrightness => 0f;

		public float ColorDarkBrightness => 0f;

		public float ColorLightBrightness => 0f;

		public Color ColorOpaque => (Color)null;

		public Color ColorDarkOpaque => (Color)null;

		public Color ColorLightOpaque => (Color)null;

		public Color ColorInvert => (Color)null;

		public Color ColorDarkInvert => (Color)null;

		public Color ColorLightInvert => (Color)null;

		public QColor(Color color)
		{
		}

		public QColor(Color color, float alpha)
		{
		}

		public QColor(float r, float g, float b, bool from256 = true)
		{
		}

		public QColor(float r, float g, float b, float a, bool from256 = true)
		{
		}

		public void SetColor(Color color)
		{
		}

		public Color ColorWithBrightness(float brightness)
		{
			return (Color)null;
		}

		public Color ColorDarkWithBrightness(float brightness)
		{
			return (Color)null;
		}

		public Color ColorLightWithBrightness(float brightness)
		{
			return (Color)null;
		}

		public Color ColorWithAlpha(float alpha)
		{
			return (Color)null;
		}

		public Color ColorDarkWithAlpha(float alpha)
		{
			return (Color)null;
		}

		public Color ColorLightWithAlpha(float alpha)
		{
			return (Color)null;
		}
	}
}
