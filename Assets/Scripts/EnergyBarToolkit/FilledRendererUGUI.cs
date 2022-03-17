using UnityEngine;

namespace EnergyBarToolkit
{
	public class FilledRendererUGUI : EnergyBarUGUIBase
	{
		public enum BlinkOperator
		{
			LessThan,
			LessOrEqual,
			GreaterThan,
			GreaterOrEqual
		}

		public Sprite spriteBar;

		public Material spriteBarMaterial;

		public ColorType spriteBarColorType;

		public Color spriteBarColor;

		public Gradient spriteBarGradient;

		public GrowDirection growDirection;

		public float radialOffset;

		public float radialLength;

		public Vector3 barImageScale;

		public Vector3 barImageOffset;

		public Vector2 barImageRepeater;

		public bool effectBlink;

		public float effectBlinkValue;

		public float effectBlinkRatePerSecond;

		public Color effectBlinkColor;

		public BlinkOperator effectBlinkOperator;

		public bool effectFollow;

		public GameObject effectFollowObject;

		public Vector3 effectFollowOffset;

		public AnimationCurve effectFollowScaleX;

		public AnimationCurve effectFollowScaleY;

		public AnimationCurve effectFollowScaleZ;

		public AnimationCurve effectFollowRotation;

		public Gradient effectFollowColor;

		public bool effectTiled;

		public Sprite effectTiledSprite;

		public Vector2 effectTiledTiling;

		public Vector2 effectTiledStartOffset;

		public Vector2 effectTiledOffsetChangeSpeed;

		public Color effectTiledTint;

		[SerializeField]
		private Image2 effectTilledImageBarMask;

		[SerializeField]
		private Image2 effectTilledImageTiles;

		[SerializeField]
		private int lastRebuildHash;

		[SerializeField]
		private bool dirty;

		[SerializeField]
		private Image2 imageBar;

		[SerializeField]
		private Image2 imageBurn;

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

		private void UpdateTiledEffect()
		{
		}

		private void UpdateValue()
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

		private void UpdateFollowEffect()
		{
		}

		private void UpdateEffectFollowDefaults()
		{
		}

		private Vector2 EdgePosition()
		{
			return (Vector2)null;
		}

		private Color GetBurnColor()
		{
			return (Color)null;
		}

		private void UpdateColor()
		{
		}

		private void UpdateRadialOffset()
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

		public void Rebuild()
		{
		}

		private void BuildBurnBar()
		{
		}

		private void BuildBar()
		{
		}

		private void BuildEffectTilled()
		{
		}
	}
}
