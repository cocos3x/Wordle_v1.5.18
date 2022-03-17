namespace UnityEngine.UI.Extensions
{
	public class UICircle : UIPrimitiveBase
	{
		public int fillPercent;

		public bool FixedToSegments;

		public bool fill;

		public float thickness;

		public int segments;

		private void Update()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		private void StepThroughPointsAndFill(float outer, float inner, ref Vector2 prevX, ref Vector2 prevY, out Vector2 pos0, out Vector2 pos1, out Vector2 pos2, out Vector2 pos3, float c, float s)
		{
		}
	}
}
