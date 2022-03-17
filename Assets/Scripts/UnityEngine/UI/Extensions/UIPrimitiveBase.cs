using System;

namespace UnityEngine.UI.Extensions
{
	public class UIPrimitiveBase : MaskableGraphic, ILayoutElement, ICanvasRaycastFilter
	{
		[SerializeField]
		private Sprite m_Sprite;

		[NonSerialized]
		private Sprite m_OverrideSprite;

		internal float m_EventAlphaThreshold;

		public Sprite sprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite overrideSprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float eventAlphaThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override Texture mainTexture => null;

		public float pixelsPerUnit => 0f;

		public virtual float minWidth => 0f;

		public virtual float preferredWidth => 0f;

		public virtual float flexibleWidth => 0f;

		public virtual float minHeight => 0f;

		public virtual float preferredHeight => 0f;

		public virtual float flexibleHeight => 0f;

		public virtual int layoutPriority => 0;

		protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs)
		{
			return null;
		}

		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		public virtual void CalculateLayoutInputVertical()
		{
		}

		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			return false;
		}

		private Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			return (Vector2)null;
		}

		private Vector4 GetAdjustedBorders(Vector4 border, Rect rect)
		{
			return (Vector4)null;
		}
	}
}
