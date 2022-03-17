namespace UnityEngine.UI.Extensions
{
	public class UICornerCut : UIPrimitiveBase
	{
		public Vector2 cornerSize;

		public bool cutUL;

		public bool cutUR;

		public bool cutLL;

		public bool cutLR;

		public bool makeColumns;

		public bool useColorUp;

		public Color32 colorUp;

		public bool useColorDown;

		public Color32 colorDown;

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		private static void AddSquare(Rect rect, Rect rectUV, Color32 color32, VertexHelper vh)
		{
		}

		private static void AddSquare(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Rect rectUV, Color32 color32, VertexHelper vh)
		{
		}

		private static int AddVert(float x, float y, Rect area, Color32 color32, VertexHelper vh)
		{
			return 0;
		}
	}
}
