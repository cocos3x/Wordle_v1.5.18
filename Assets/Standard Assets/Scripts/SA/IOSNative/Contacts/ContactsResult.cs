using SA.Common.Models;
using System.Collections.Generic;

namespace SA.IOSNative.Contacts
{
	public class ContactsResult : Result
	{
		private List<Contact> _Contacts;

		public List<Contact> Contacts => null;

		public ContactsResult(List<Contact> contacts)
		{
		}

		public ContactsResult(Error error)
		{
		}
	}
}
