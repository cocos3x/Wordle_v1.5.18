using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EnergyBarToolkit
{
	public class Image2 : MaskableGraphic
	{
		private class Quad
		{
			public enum Point
			{
				TopLeft,
				TopRight,
				BottomRight,
				BottomLeft
			}

			public Point anchor;

			public float offset;

			public float progress;

			public bool invert;

			public Quad(bool invert)
			{
			}

			public Quad(Quad other)
			{
			}

			public MadList<Vector2> Points(float left, float top, float right, float bottom, MadList<Vector2> list)
			{
				return null;
			}

			private float Y(float val)
			{
				return 0f;
			}
		}

		public Sprite sprite;

		[SerializeField]
		private Sprite cachedSprite;

		[SerializeField]
		private Vector4 cachedPadding;

		private static Dictionary<int, Vector4> cachedPaddings;

		public EnergyBarBase.GrowDirection growDirection;

		[SerializeField]
		private float _fillValue;

		public float radialFillOffset;

		public float radialFillLength;

		public Vector2 uvOffset;

		public Vector2 uvTiling;

		public bool readable;

		public float fillValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override Texture mainTexture => null;

		protected override void OnPopulateMesh(Mesh mesh)
		{
		}

		private void FillRegular(Mesh mesh)
		{
		}

		private Vector4 FixUV(Vector4 outerUv)
		{
			return (Vector4)null;
		}

		private void FillQuad(Mesh mesh)
		{
		}

		private void PreparePointsAndUvs(MadList<Vector2> points, MadList<Vector2> uvs, Vector4 outerUv)
		{
		}

		private void AddToMesh(VertexHelper vertexHelper, MadList<Vector2> points, MadList<Vector2> uvs)
		{
		}

		public override void SetNativeSize()
		{
		}

		public Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			return (Vector4)null;
		}

		private Vector4 GetCachedPadding()
		{
			return (Vector4)null;
		}

		private Vector4 GetPadding(Sprite sprite)
		{
			return (Vector4)null;
		}

		private Vector4 GetPaddingManual(Sprite sprite)
		{
			return (Vector4)null;
		}
	}
}
