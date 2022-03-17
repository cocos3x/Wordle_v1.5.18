using System.Collections.Generic;
using UnityEngine;

namespace EnergyBarToolkit
{
	public class SequenceRendererUGUI : EnergyBarUGUIBase
	{
		public enum RenderMethod
		{
			Grid,
			Sequence
		}

		public RenderMethod renderMethod;

		public SpriteTex gridSprite;

		public int gridWidth;

		public int gridHeight;

		public bool frameCountAuto;

		public int frameCount;

		public List<SpriteTex> sequenceSprites;

		public Color sequenceTint;

		[SerializeField]
		private int lastRebuildHash;

		private bool dirty;

		[SerializeField]
		private Image2 barImage;

		public override void SetNativeSize()
		{
		}

		private void SetNativeSizeGrid()
		{
		}

		private void SetNativeSizeSequence()
		{
		}

		protected override void Update()
		{
		}

		private void UpdateNonIntrusive()
		{
		}

		private void UpdateSize()
		{
		}

		private void UpdateValue()
		{
		}

		private void UpdateValueGrid()
		{
		}

		private void UpdateColor()
		{
		}

		private Vector2 GetOffset(int frameIndex)
		{
			return (Vector2)null;
		}

		private Vector2 GetTilling()
		{
			return (Vector2)null;
		}

		private void UpdateValueSequence()
		{
		}

		private int GetFrameIndex(float progress)
		{
			return 0;
		}

		private int GetFrameCount()
		{
			return 0;
		}

		private bool RebuildNeeded()
		{
			return false;
		}

		private void Rebuild()
		{
		}

		private void BuildBar()
		{
		}
	}
}
