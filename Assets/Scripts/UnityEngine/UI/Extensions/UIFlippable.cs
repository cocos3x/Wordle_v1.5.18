namespace UnityEngine.UI.Extensions
{
	public class UIFlippable : MonoBehaviour, IMeshModifier
	{
		[SerializeField]
		private bool m_Horizontal;

		[SerializeField]
		private bool m_Veritical;

		public bool horizontal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool vertical
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected void OnValidate()
		{
		}

		public void ModifyMesh(VertexHelper verts)
		{
		}

		public void ModifyMesh(Mesh mesh)
		{
		}
	}
}
