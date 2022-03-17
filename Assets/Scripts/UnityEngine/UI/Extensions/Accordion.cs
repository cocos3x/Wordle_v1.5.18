namespace UnityEngine.UI.Extensions
{
	public class Accordion : MonoBehaviour
	{
		public enum Transition
		{
			Instant,
			Tween
		}

		[SerializeField]
		private Transition m_Transition;

		[SerializeField]
		private float m_TransitionDuration;

		public Transition transition
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (Transition)null;
			}
			set
			{
			}
		}

		public float transitionDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
