namespace UnityEngine.UI.Extensions
{
	public class ExampleSelectable : MonoBehaviour, IBoxSelectable
	{
		private bool _selected;

		private bool _preSelected;

		private SpriteRenderer spriteRenderer;

		private Image image;

		private Text text;

		public bool selected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool preSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private Transform UnityEngine_002EUI_002EExtensions_002EIBoxSelectable_002Eget_transform()
		{
			return null;
		}
	}
}
