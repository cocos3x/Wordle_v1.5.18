namespace UnityEngine.UI.Extensions
{
	public class SoftMaskScript : MonoBehaviour
	{
		private Material mat;

		private Canvas cachedCanvas;

		private Transform cachedCanvasTransform;

		private readonly Vector3[] m_WorldCorners;

		private readonly Vector3[] m_CanvasCorners;

		public RectTransform MaskArea;

		public Texture AlphaMask;

		public float CutOff;

		public bool HardBlend;

		public bool FlipAlphaMask;

		public bool DontClipMaskScalingRect;

		private Vector2 maskOffset;

		private Vector2 maskScale;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void SetMask()
		{
		}

		public Rect GetCanvasRect()
		{
			return (Rect)null;
		}
	}
}
