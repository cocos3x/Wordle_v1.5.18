using UnityEngine;
using UnityEngine.UI;

namespace EnergyBarToolkit
{
	public class SlicedRendererUGUI : EnergyBarUGUIBase
	{
		public enum BlinkOperator
		{
			LessThan,
			LessOrEqual,
			GreaterThan,
			GreaterOrEqual
		}

		public Sprite spriteBar;

		public ColorType spriteBarColorType;

		public Color spriteBarColor;

		public Gradient spriteBarGradient;

		public float spriteBarMinSize;

		public GrowDirection growDirection;

		public Vector3 barImageScale;

		public Vector3 barImageOffset;

		public bool effectBlink;

		public float effectBlinkValue;

		public float effectBlinkRatePerSecond;

		public Color effectBlinkColor;

		public BlinkOperator effectBlinkOperator;

		[SerializeField]
		private int lastRebuildHash;

		[SerializeField]
		private bool dirty;

		[SerializeField]
		private Image imageBar;

		[SerializeField]
		private Image imageBurn;

		private bool _003CforceBlinking_003Ek__BackingField;

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

		public override void SetNativeSize()
		{
		}

		public bool GrowDirectionSupportedByFollowEffect(GrowDirection growDirection)
		{
			return false;
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		private void UpdateSize()
		{
		}

		private void UpdateNonIntrusive()
		{
		}

		private void UpdateBarScaleAndOffset()
		{
		}

		private void UpdateBarOffset()
		{
		}

		private void UpdateBarOffset(Image bar)
		{
		}

		private void UpdateValue()
		{
		}

		private void SetBarValue(Image image, float valueF)
		{
		}

		private void UpdateBlinkEffect()
		{
		}

		private bool CanBlink()
		{
			return false;
		}

		private void UpdateBurnEffect()
		{
		}

		private Color GetBurnColor()
		{
			return (Color)null;
		}

		private void UpdateColor()
		{
		}

		private Color ComputeBarColor()
		{
			return (Color)null;
		}

		public void UpdateRebuild()
		{
		}

		private bool RebuildNeeded()
		{
			return false;
		}

		private void Rebuild()
		{
		}

		private void BuildBurnBar()
		{
		}

		private void BuildBar()
		{
		}

		protected override Image.Type GetImageType()
		{
			//IL_0003: Expected I4, but got O
			return (Image.Type)null;
		}
	}
}
