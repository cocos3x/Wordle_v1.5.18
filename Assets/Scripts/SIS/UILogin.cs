using UnityEngine;
using UnityEngine.UI;

namespace SIS
{
	public class UILogin : MonoBehaviour
	{
		public string nextScene;

		public GameObject loadingScreen;

		public InputField emailField;

		public InputField passwordField;

		public Text errorText;

		public Text userText;

		public Text keyText;

		public InputField userField;

		public InputField[] keyFields;

		private const string emailPref = "AccountEmail";

		private void Awake()
		{
		}
	}
}
