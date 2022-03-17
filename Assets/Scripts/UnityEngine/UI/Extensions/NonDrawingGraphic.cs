namespace UnityEngine.UI.Extensions
{
	public class NonDrawingGraphic : MaskableGraphic
	{
		public override void SetMaterialDirty()
		{
		}

		public override void SetVerticesDirty()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}
