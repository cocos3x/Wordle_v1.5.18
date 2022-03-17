namespace UnityEngine.UI.Extensions
{
	public class Gradient : BaseMeshEffect
	{
		public GradientMode gradientMode;

		public GradientDir gradientDir;

		public bool overwriteAllColor;

		public Color vertex1;

		public Color vertex2;

		private Graphic targetGraphic;

		protected override void Start()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		private bool CompareCarefully(Color col1, Color col2)
		{
			return false;
		}
	}
}
