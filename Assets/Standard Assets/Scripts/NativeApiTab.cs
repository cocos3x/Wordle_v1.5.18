using UnityEngine;
using UnityEngine.UI;

public class NativeApiTab : FeatureTab
{
	[SerializeField]
	private Image image;

	[SerializeField]
	private Texture2D helloWorldTexture;

	private void Start()
	{
	}

	public void SaveToGalalry()
	{
	}

	public void SaveScreenshot()
	{
	}

	public void GetImageFromGallery()
	{
	}

	public void GetImageFromCamera()
	{
	}

	public void CheckForTV()
	{
	}

	public void LoadNetworkInfo()
	{
	}

	private void HandleActionNetworkInfoLoaded(AN_NetworkInfo info)
	{
	}

	public void CheckAppInstalation()
	{
	}

	public void RunApp()
	{
	}

	public void CheckAppLicense()
	{
	}

	private void LicenseRequestResult(AN_LicenseRequestResult result)
	{
	}

	public void EnableImmersiveMode()
	{
	}

	public void GetAndroidId()
	{
	}

	private void OnAndroidIdLoaded(string id)
	{
	}

	public void LoadAppInfo()
	{
	}

	private void LoadAdressBook()
	{
	}

	private void OnDeviceTypeChecked()
	{
	}

	private void OnPackageCheckResult(AN_PackageCheckResult res)
	{
	}

	private void OnContactsLoaded()
	{
	}

	private void OnImagePicked(AndroidImagePickResult result)
	{
	}

	private void OnImageSaved(GallerySaveResult result)
	{
	}

	private void OnPackageInfoLoaded(PackageAppInfo PacakgeInfo)
	{
	}

	public void LoadInternal()
	{
	}

	public void LoadExternal()
	{
	}

	public void LoadLocaleInfo()
	{
	}

	private void LocaleInfoLoaded(AN_Locale locale)
	{
	}

	private void ExternalStoragePathLoaded(string path)
	{
	}

	private void InternalStoragePathLoaded(string path)
	{
	}
}
