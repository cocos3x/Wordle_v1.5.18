using UnityEngine;
using UnityEngine.UI;

namespace EnergyBarToolkit
{
	public class TransformRendererUGUI : EnergyBarUGUIBase
	{
		public SpriteTex spriteObject;

		public Vector2 spriteObjectPivot;

		public bool transformTranslate;

		public bool transformRotate;

		public bool transformScale;

		public TranslateFunction translateFunction;

		public RotateFunction rotateFunction;

		public ScaleFunction scaleFunction;

		[SerializeField]
		private const int BuildVersion = 1;

		[SerializeField]
		private int lastRebuildHash;

		[SerializeField]
		private bool dirty;

		[SerializeField]
		private Image imageObject;

		[SerializeField]
		private Transform imageObjectContainer;

		public override void SetNativeSize()
		{
		}

		private Vector2? ComputeNativeSize()
		{
			return null;
		}

		private Sprite FirstBackgroundOrForegroundSprite()
		{
			return null;
		}

		protected override void Update()
		{
		}

		private void UpdateAnchor()
		{
		}

		private void UpdateSize()
		{
		}

		private bool TryGetNativeSize(out Vector2 nativeSize)
		{
			return false;
		}

		private void UpdateColor()
		{
		}

		private void UpdateTransform()
		{
		}

		private void UpdateRebuild()
		{
		}

		private bool IsValid()
		{
			return false;
		}

		private bool RebuildNeeded()
		{
			return false;
		}

		private void Rebuild()
		{
		}

		private void BuildObject()
		{
		}
	}
}
