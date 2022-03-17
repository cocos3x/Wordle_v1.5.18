using UnityEngine;

namespace EnergyBarToolkit
{
	public class TransformRenderer3D : EnergyBar3DBase
	{
		public Texture2D objectTexture;

		public string objectAtlasTextureGUID;

		public Color objectTint;

		public Vector2 objectAnchor;

		public bool transformTranslate;

		public bool transformRotate;

		public bool transformScale;

		public TranslateFunction translateFunction;

		public RotateFunction rotateFunction;

		public ScaleFunction scaleFunction;

		private int lastRebuildHash;

		private bool dirty;

		private MadSprite objectSprite;

		public override Rect DrawAreaRect => (Rect)null;

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		private void UpdateColor()
		{
		}

		private void UpdateTransform()
		{
		}

		private bool RebuildNeeded()
		{
			return false;
		}

		protected override void Rebuild()
		{
		}

		private int BuildObject(int nextDepth)
		{
			return 0;
		}
	}
}
