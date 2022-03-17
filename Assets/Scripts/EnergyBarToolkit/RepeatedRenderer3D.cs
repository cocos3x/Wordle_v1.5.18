using System;
using System.Collections.Generic;
using UnityEngine;

namespace EnergyBarToolkit
{
	public class RepeatedRenderer3D : EnergyBar3DBase
	{
		public enum GrowType
		{
			None,
			Grow,
			Fade,
			Fill
		}

		public enum CutDirection
		{
			LeftToRight,
			TopToBottom,
			RightToLeft,
			BottomToTop
		}

		public Texture2D textureIcon;

		public Texture2D textureSlot;

		public string atlasTextureIconGUID;

		public string atlasTextureSlotGUID;

		public Color tintIcon;

		public Color tintSlot;

		public int repeatCount;

		public Vector2 repeatPositionDelta;

		public float repeatRotationDelta;

		public GrowType growType;

		public MadSprite.FillType fillDirection;

		private List<MadSprite> slotSprites;

		private List<MadSprite> iconSprites;

		private int lastRebuildHash;

		private bool dirty;

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

		public override Rect DrawAreaRect => (Rect)null;

		private Color IconTintTransparent => (Color)null;

		public event Action<MadSprite> onIconShow
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<MadSprite> onIconHide
		{
			add
			{
			}
			remove
			{
			}
		}

		public MadSprite GetSlotSprite(int index)
		{
			return null;
		}

		public MadSprite GetIconSprite(int index)
		{
			return null;
		}

		private new void Start()
		{
		}

		protected override void Update()
		{
		}

		private void UpdateBar()
		{
		}

		private void SetIconVisible(MadSprite sprite)
		{
		}

		private void UpdateSlot(MadSprite sprite)
		{
		}

		private void SetIconInvisible(MadSprite sprite)
		{
		}

		private void UpdateVisible()
		{
		}

		private bool RebuildNeeded()
		{
			return false;
		}

		protected override void Rebuild()
		{
		}

		private void RebuildClear()
		{
		}

		private int RebuildBuild()
		{
			return 0;
		}

		private int BuildTextures(int depth)
		{
			return 0;
		}

		private Vector2 RotateVector(Vector2 v, float degrees)
		{
			return (Vector2)null;
		}

		private Vector2 LocalIconOffset(Vector2 iconSize)
		{
			return (Vector2)null;
		}

		private Vector2 ComputeDrawAreaSize(Vector2 iconSize)
		{
			return (Vector2)null;
		}
	}
}
