namespace UnityEngine.UI.Extensions
{
	public class RaycastMask : MonoBehaviour, ICanvasRaycastFilter
	{
		private Image _image;

		private Sprite _sprite;

		private void Start()
		{
		}

		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return false;
		}
	}
}
