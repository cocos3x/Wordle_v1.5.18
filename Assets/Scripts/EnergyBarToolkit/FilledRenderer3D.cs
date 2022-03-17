using System;
using UnityEngine;

namespace EnergyBarToolkit
{
	public class FilledRenderer3D : EnergyBar3DBase
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static MadTransform.Predicate<MadSprite> _003C_003E9__50_0;

			internal bool _003CRebuild_003Eb__50_0(MadSprite s)
			{
				return false;
			}
		}

		public Texture2D textureBar;

		public string atlasTextureBarGUID;

		public ColorType textureBarColorType;

		public Color textureBarColor;

		public Gradient textureBarGradient;

		public GrowDirection growDirection;

		public float radialOffset;

		public float radialLength;

		public bool effectBlink;

		public float effectBlinkValue;

		public float effectBlinkRatePerSecond;

		public Color effectBlinkColor;

		public bool effectFollow;

		public UnityEngine.Object effectFollowObject;

		public AnimationCurve effectFollowScaleX;

		public AnimationCurve effectFollowScaleY;

		public AnimationCurve effectFollowScaleZ;

		public AnimationCurve effectFollowRotation;

		public Gradient effectFollowColor;

		[SerializeField]
		private bool effectFollowDefaultsSet;

		private MadSprite effectFollowSprite;

		private int lastRebuildHash;

		private bool dirty;

		private MadSprite spriteBar;

		private MadSprite spriteBurnBar;

		private bool _003CforceBlinking_003Ek__BackingField;

		private bool _003CBlink_003Ek__BackingField;

		private float _effectBlinkAccum;

		public override Pivot pivot
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (Pivot)null;
			}
			set
			{
			}
		}

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

		private Color BarColor => (Color)null;

		private Color BurnColor => (Color)null;

		public override Rect DrawAreaRect => (Rect)null;

		protected override void OnEnable()
		{
		}

		protected override void Update()
		{
		}

		private void UpdateBlinkEffect()
		{
		}

		private void UpdateBar()
		{
		}

		private void UpdatePivot()
		{
		}

		private void UpdateFollowEffect()
		{
		}

		private bool RebuildNeeded()
		{
			return false;
		}

		protected override void Rebuild()
		{
		}

		private MadSprite.FillType ToFillType(GrowDirection growDirection)
		{
			//IL_0003: Expected I4, but got O
			return (MadSprite.FillType)null;
		}

		public bool GrowDirectionSupportedByFollowEffect(GrowDirection growDirection)
		{
			return false;
		}

		private Vector2 EdgePosition()
		{
			return (Vector2)null;
		}

		private Vector2 ComputeOffset()
		{
			return (Vector2)null;
		}
	}
}
