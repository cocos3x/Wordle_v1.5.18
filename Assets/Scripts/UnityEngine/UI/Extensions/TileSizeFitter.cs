using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class TileSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		[SerializeField]
		private Vector2 m_Border;

		[SerializeField]
		private Vector2 m_TileSize;

		[NonSerialized]
		private RectTransform m_Rect;

		private DrivenRectTransformTracker m_Tracker;

		public Vector2 Border
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		public Vector2 TileSize
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		private RectTransform rectTransform => null;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void UpdateRect()
		{
		}

		private Vector2 GetParentSize()
		{
			return (Vector2)null;
		}

		public virtual void SetLayoutHorizontal()
		{
		}

		public virtual void SetLayoutVertical()
		{
		}

		protected void SetDirty()
		{
		}
	}
}
