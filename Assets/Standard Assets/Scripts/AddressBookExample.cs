using System.Collections.Generic;
using UnityEngine;

public class AddressBookExample : MonoBehaviour
{
	public SA_Label _name;

	public SA_Label _phone;

	public SA_Label _note;

	public SA_Label _email;

	public SA_Label _chat;

	public SA_Label _address;

	private List<AndroidContactInfo> all_contacts;

	private void LoadAdressBook()
	{
	}

	private void OnContactsLoaded()
	{
	}
}
