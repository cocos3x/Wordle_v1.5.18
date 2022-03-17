using System.Collections.Generic;
using UnityEngine;

namespace EnergyBarToolkit
{
	public class RepeatedRendererUGUI : EnergyBarUGUIBase
	{
		public enum GrowType
		{
			None,
			Grow,
			Fade,
			Fill
		}

		public enum BlinkOperator
		{
			LessThan,
			LessOrEqual,
			GreaterThan,
			GreaterOrEqual
		}

		public SpriteTex spriteIcon;

		public SpriteTex spriteSlot;

		public int repeatCount;

		public Vector2 repeatPositionDelta;

		public float repeatRotation;

		public bool repeatKeepOrientation;

		public bool repeatKeepPosition;

		public GrowType growType;

		public GrowDirection growDirection;

		public bool effectBlink;

		public float effectBlinkValue;

		public float effectBlinkRatePerSecond;

		public Color effectBlinkColor;

		public BlinkOperator effectBlinkOperator;

		private bool _003CforceBlinking_003Ek__BackingField;

		[SerializeField]
		private int lastRebuildHash;

		private bool dirty;

		[SerializeField]
		private List<Image2> slotImages;

		[SerializeField]
		private List<Image2> iconImages;

		[SerializeField]
		private List<Vector2> originPositions;

		[SerializeField]
		private Vector2 sizeOrigin;

		[SerializeField]
		private Vector2 scaleRatio;

		private bool _003CBlink_003Ek__BackingField;

		private float _effectBlinkAccum;

		public bool forceBlinking
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool Blink
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private Color IconTintTransparent => (Color)null;

		public override void SetNativeSize()
		{
		}

		private Vector2 ComputeNativeSize()
		{
			return (Vector2)null;
		}

		public Image2 GetIconImage(int index)
		{
			return null;
		}

		public Image2 GetSlotImage(int index)
		{
			return null;
		}

		public int GetIconCount()
		{
			return 0;
		}

		public int GetFullyVisibleIconCount()
		{
			return 0;
		}

		public int GetVisibleIconCount()
		{
			return 0;
		}

		protected override void Update()
		{
		}

		private void OnValidate()
		{
		}

		private void UpdateBar()
		{
		}

		private void UpdateSize()
		{
		}

		private void UpdateSpriteSize(Vector2 originPosition, Image2 image, Rect spriteRect)
		{
		}

		private void SetIconVisible(Image2 image, float scale = 1f)
		{
		}

		private void UpdateSlot(Image2 image)
		{
		}

		private void SetIconInvisible(Image2 image)
		{
		}

		private void UpdateVisible()
		{
		}

		private void UpdateBlinkEffect()
		{
		}

		private bool CanBlink()
		{
			return false;
		}

		private void UpdateRebuild()
		{
		}

		private bool RebuildNeeded()
		{
			return false;
		}

		private void Rebuild()
		{
		}

		private void BuildIconsAndSlots()
		{
		}

		private Vector2 ComputePosition(int count)
		{
			return (Vector2)null;
		}

		private void Expand(ref Vector2 min, ref Vector2 max, ref bool hasMinMax, RectTransform tr)
		{
		}
	}
}
