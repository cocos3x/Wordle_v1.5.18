using SA.Common.Pattern;
using System;
using System.Collections.Generic;

namespace SA.IOSNative.Contacts
{
	public class ContactStore : Singleton<ContactStore>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<ContactsResult> _003C_003E9__11_0;

			public static Action<ContactsResult> _003C_003E9__12_0;

			public static Action<ContactsResult> _003C_003E9__13_0;

			public static Action<ContactsResult> _003C_003E9__14_0;

			public static Action<ContactsResult> _003C_003E9__15_0;

			public static Action<ContactsResult> _003C_003E9__15_1;

			internal void _003COnContactPickerDidCancel_003Eb__11_0(ContactsResult _003Cp0_003E)
			{
			}

			internal void _003COnPickerDidSelectContacts_003Eb__12_0(ContactsResult _003Cp0_003E)
			{
			}

			internal void _003COnContactsRetrieveFailed_003Eb__13_0(ContactsResult _003Cp0_003E)
			{
			}

			internal void _003COnContactsRetrieveFinished_003Eb__14_0(ContactsResult _003Cp0_003E)
			{
			}

			internal void _003C_002Ector_003Eb__15_0(ContactsResult _003Cp0_003E)
			{
			}

			internal void _003C_002Ector_003Eb__15_1(ContactsResult _003Cp0_003E)
			{
			}
		}

		private event Action<ContactsResult> ContactsLoadResult
		{
			add
			{
			}
			remove
			{
			}
		}

		private event Action<ContactsResult> ContactsPickResult
		{
			add
			{
			}
			remove
			{
			}
		}

		private void Awake()
		{
		}

		public void ShowContactsPickerUI(Action<ContactsResult> callback)
		{
		}

		public void RetrievePhoneContacts(Action<ContactsResult> callback)
		{
		}

		private Contact ParseContactData(string data)
		{
			return null;
		}

		private List<Contact> ParseContactArray(string data)
		{
			return null;
		}

		private void OnContactPickerDidCancel(string errorData)
		{
		}

		private void OnPickerDidSelectContacts(string data)
		{
		}

		private void OnContactsRetrieveFailed(string errorData)
		{
		}

		private void OnContactsRetrieveFinished(string data)
		{
		}
	}
}
