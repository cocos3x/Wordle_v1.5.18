using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	public class NicerOutline : BaseMeshEffect
	{
		[SerializeField]
		private Color m_EffectColor;

		[SerializeField]
		private Vector2 m_EffectDistance;

		[SerializeField]
		private bool m_UseGraphicAlpha;

		public Color effectColor
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public Vector2 effectDistance
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		public bool useGraphicAlpha
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
		}

		protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
