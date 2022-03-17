namespace UnityEngine.UI.Extensions
{
	public class UILineTextureRenderer : UIPrimitiveBase
	{
		[SerializeField]
		private Rect m_UVRect;

		[SerializeField]
		private Vector2[] m_points;

		public float LineThickness;

		public bool UseMargins;

		public Vector2 Margin;

		public bool relativeSize;

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

		public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles)
		{
			return (Vector3)null;
		}
	}
}
