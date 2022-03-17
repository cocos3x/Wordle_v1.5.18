namespace UnityEngine.UI.Extensions
{
	public class ShineEffector : MonoBehaviour
	{
		public ShineEffect effector;

		[SerializeField]
		private GameObject effectRoot;

		public float yOffset;

		public float width;

		private RectTransform effectorRect;

		public float YOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void ChangeVal(float value)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
