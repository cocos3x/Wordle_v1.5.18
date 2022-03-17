using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SIS
{
	public class VRGraphicRaycaster : BaseRaycaster
	{
		public enum BlockingObjects
		{
			None,
			TwoD,
			ThreeD,
			All
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<Graphic> _003C_003E9__24_0;

			internal int _003CRaycast_003Eb__24_0(Graphic g1, Graphic g2)
			{
				return 0;
			}
		}

		protected const int kNoEventMaskSet = -1;

		[SerializeField]
		private bool m_IgnoreReversedGraphics;

		[SerializeField]
		private BlockingObjects m_BlockingObjects;

		[SerializeField]
		protected LayerMask m_BlockingMask;

		private Canvas m_Canvas;

		[NonSerialized]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics;

		public override int sortOrderPriority => 0;

		public override int renderOrderPriority => 0;

		public bool ignoreReversedGraphics
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public BlockingObjects blockingObjects
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (BlockingObjects)null;
			}
			set
			{
			}
		}

		private Canvas canvas => null;

		public override Camera eventCamera => null;

		protected VRGraphicRaycaster()
		{
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, List<Graphic> results)
		{
		}
	}
}
