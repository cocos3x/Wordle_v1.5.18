using System;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	public class InputFieldEnterSubmit : MonoBehaviour
	{
		[Serializable]
		public class EnterSubmitEvent : UnityEvent<string>
		{
		}

		public EnterSubmitEvent EnterSubmit;

		private InputField _input;

		private void Awake()
		{
		}

		public void OnEndEdit(string txt)
		{
		}
	}
}
