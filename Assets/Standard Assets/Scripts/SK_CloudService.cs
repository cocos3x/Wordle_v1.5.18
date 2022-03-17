using SA.Common.Pattern;
using System;

public class SK_CloudService : Singleton<SK_CloudService>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__21_0(SK_AuthorizationResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__21_1(SK_RequestCapabilitieResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__21_2(SK_RequestStorefrontIdentifierResult _003Cp0_003E)
		{
		}
	}

	public static int AuthorizationStatus => 0;

	public static event Action<SK_AuthorizationResult> OnAuthorizationFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<SK_RequestCapabilitieResult> OnCapabilitiesRequestFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<SK_RequestStorefrontIdentifierResult> OnStorefrontIdentifierRequestFinished
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

	public void RequestAuthorization()
	{
	}

	public void RequestCapabilities()
	{
	}

	public void RequestStorefrontIdentifier()
	{
	}

	private void Event_AuthorizationFinished(string data)
	{
	}

	private void Event_RequestCapabilitieSsuccess(string data)
	{
	}

	private void Event_RequestCapabilitiesFailed(string errorData)
	{
	}

	private void Event_RequestStorefrontIdentifierSsuccess(string storefrontIdentifier)
	{
	}

	private void Event_RequestStorefrontIdentifierFailed(string errorData)
	{
	}
}
