namespace UnityEngine.UI.Extensions
{
	public class CurvedText : BaseMeshEffect
	{
		public AnimationCurve curveForText;

		public float curveMultiplier;

		private RectTransform rectTrans;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}
	}
}
