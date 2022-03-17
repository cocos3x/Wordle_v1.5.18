using SA.Common.Pattern;
using System;

public class AN_LicenseManager : Singleton<AN_LicenseManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__6_0(AN_LicenseRequestResult _003Cp0_003E)
		{
		}
	}

	public static Action<AN_LicenseRequestResult> OnLicenseRequestResult;

	private void Awake()
	{
	}

	public void StartLicenseRequest()
	{
	}

	public void StartLicenseRequest(string base64PublicKey)
	{
	}

	private void OnLicenseRequestRes(string data)
	{
	}
}
