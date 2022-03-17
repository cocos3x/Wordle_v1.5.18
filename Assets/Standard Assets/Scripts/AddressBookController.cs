using SA.Common.Pattern;
using System;
using System.Collections.Generic;

public class AddressBookController : Singleton<AddressBookController>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__20_0()
		{
		}
	}

	private const string DATA_SPLITTER_1 = "&#&";

	private const string DATA_SPLITTER_2 = "#&#";

	private const int byte_limit = 256;

	private static bool _isLoaded;

	private List<AndroidContactInfo> _contacts;

	public List<AndroidContactInfo> contacts => null;

	public static bool isLoaded => false;

	public static event Action OnContactsLoadedAction
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

	public void LoadContacts()
	{
	}

	private void OnContactsLoaded(string data)
	{
	}

	private void parseContacts(string data)
	{
	}

	private string trimString(string str, int index)
	{
		return "";
	}

	private bool isValid(string str)
	{
		return false;
	}

	private bool havePhoto(string str)
	{
		return false;
	}
}
