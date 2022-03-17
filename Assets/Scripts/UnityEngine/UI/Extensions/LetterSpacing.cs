namespace UnityEngine.UI.Extensions
{
	public class LetterSpacing : BaseMeshEffect
	{
		[SerializeField]
		private float m_spacing;

		public float spacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected LetterSpacing()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
