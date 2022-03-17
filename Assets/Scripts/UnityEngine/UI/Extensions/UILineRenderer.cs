using System;

namespace UnityEngine.UI.Extensions
{
	public class UILineRenderer : UIPrimitiveBase
	{
		private enum SegmentType
		{
			Start,
			Middle,
			End
		}

		public enum JoinType
		{
			Bevel,
			Miter
		}

		public enum BezierType
		{
			None,
			Quick,
			Basic,
			Improved
		}

		private const float MIN_MITER_JOIN = (float)Math.PI / 12f;

		private const float MIN_BEVEL_NICE_JOIN = (float)Math.PI / 6f;

		private static readonly Vector2 UV_TOP_LEFT;

		private static readonly Vector2 UV_BOTTOM_LEFT;

		private static readonly Vector2 UV_TOP_CENTER;

		private static readonly Vector2 UV_BOTTOM_CENTER;

		private static readonly Vector2 UV_TOP_RIGHT;

		private static readonly Vector2 UV_BOTTOM_RIGHT;

		private static readonly Vector2[] startUvs;

		private static readonly Vector2[] middleUvs;

		private static readonly Vector2[] endUvs;

		[SerializeField]
		private Rect m_UVRect;

		[SerializeField]
		private Vector2[] m_points;

		public float LineThickness;

		public bool UseMargins;

		public Vector2 Margin;

		public bool relativeSize;

		public bool LineList;

		public bool LineCaps;

		public JoinType LineJoins;

		public BezierType BezierMode;

		public int BezierSegmentsPerCurve;

		public Rect uvRect
		{
			get
			{
				return (Rect)null;
			}
			set
			{
			}
		}

		public Vector2[] Points
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, SegmentType type)
		{
			return null;
		}

		private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, SegmentType type)
		{
			return null;
		}
	}
}
