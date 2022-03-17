using UnityEngine;

namespace EnergyBarToolkit
{
	public class SequenceRenderer3D : EnergyBar3DBase
	{
		public enum Method
		{
			Grid,
			Sequence
		}

		public Method renderingMethod;

		public Texture2D gridTexture;

		public string gridAtlasTextureGUID;

		public int gridWidth;

		public int gridHeight;

		public bool gridFrameCountManual;

		public int gridFrameCount;

		public Color gridTint;

		public Texture2D[] sequenceTextures;

		public string[] sequenceAtlasTexturesGUID;

		private MadSprite spriteBar;

		private int lastRebuildHash;

		private bool dirty;

		public override Rect DrawAreaRect => (Rect)null;

		protected override void OnEnable()
		{
		}

		protected override void Update()
		{
		}

		private void UpdateColor()
		{
		}

		private void UpdateProgress()
		{
		}

		private void UpdateGridProgress()
		{
		}

		private void UpdateSequenceProgress()
		{
		}

		private int Index(int size)
		{
			return 0;
		}

		private bool RebuildNeeded()
		{
			return false;
		}

		protected override void Rebuild()
		{
		}

		private int BuildBar(int nextDepth)
		{
			return 0;
		}
	}
}
