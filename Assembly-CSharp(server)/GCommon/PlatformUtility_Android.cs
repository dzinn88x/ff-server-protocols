using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F46 RID: 3910
	[Token(Token = "0x2000F46")]
	public static class PlatformUtility_Android
	{
		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06003843 RID: 14403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D4")]
		private static AndroidJavaClass FFAPI
		{
			[Token(Token = "0x6003843")]
			[Address(RVA = "0x2474244", Offset = "0x2474244", VA = "0x7BBCC74244")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x000116E8 File Offset: 0x0000F8E8
		[Token(Token = "0x6003844")]
		[Address(RVA = "0x247431C", Offset = "0x247431C", VA = "0x7BBCC7431C")]
		public static int Build_VERSION_SDK_INT()
		{
			return 0;
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003845")]
		[Address(RVA = "0x24743C4", Offset = "0x24743C4", VA = "0x7BBCC743C4")]
		public static string BuildVariant_PackageName()
		{
			return null;
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003846")]
		public static T GetAndroidManifestMetaData<T>(string packageName, string name)
		{
			return null;
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003847")]
		[Address(RVA = "0x246FC24", Offset = "0x246FC24", VA = "0x7BBCC6FC24")]
		public static void NativeLog(string log)
		{
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x00011700 File Offset: 0x0000F900
		[Token(Token = "0x6003848")]
		[Address(RVA = "0x247446C", Offset = "0x247446C", VA = "0x7BBCC7446C")]
		public static bool IsGooglePlayServicesAvailable()
		{
			return default(bool);
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003849")]
		[Address(RVA = "0x246E7AC", Offset = "0x246E7AC", VA = "0x7BBCC6E7AC")]
		public static void SetUnitySendMessageGameObjectName(string gameObjectName)
		{
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x00011718 File Offset: 0x0000F918
		[Token(Token = "0x600384A")]
		[Address(RVA = "0x2474514", Offset = "0x2474514", VA = "0x7BBCC74514")]
		public static PlatformUtility_Android.PermissionGrantResult CheckPermission(string permission)
		{
			return PlatformUtility_Android.PermissionGrantResult.Granted;
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x2474620", Offset = "0x2474620", VA = "0x7BBCC74620")]
		public static void RequestPermissions(int requestCode, string[] permissions, PlatformUtility_Android.OnRequestPermissionsResultCallback callback)
		{
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x00011730 File Offset: 0x0000F930
		[Token(Token = "0x600384C")]
		[Address(RVA = "0x2474834", Offset = "0x2474834", VA = "0x7BBCC74834")]
		public static bool ShouldShowRequestPermissionRationale(string permission)
		{
			return default(bool);
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384D")]
		[Address(RVA = "0x2474940", Offset = "0x2474940", VA = "0x7BBCC74940")]
		public static string ConvertFilePathToUri(string filePath)
		{
			return null;
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384E")]
		[Address(RVA = "0x246E90C", Offset = "0x246E90C", VA = "0x7BBCC6E90C")]
		public static PlatformUtility.OpenedWith GetOpenedWith()
		{
			return null;
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384F")]
		[Address(RVA = "0x246EB44", Offset = "0x246EB44", VA = "0x7BBCC6EB44")]
		public static void ClearOpenedWith()
		{
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003850")]
		[Address(RVA = "0x246EC40", Offset = "0x246EC40", VA = "0x7BBCC6EC40")]
		public static string GetOpenedByUrl()
		{
			return null;
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003851")]
		[Address(RVA = "0x246ED4C", Offset = "0x246ED4C", VA = "0x7BBCC6ED4C")]
		public static void SetOpenedByUrl(string url)
		{
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003852")]
		[Address(RVA = "0x246EEB4", Offset = "0x246EEB4", VA = "0x7BBCC6EEB4")]
		public static void SetCanHandleLowMemory(bool canHandle)
		{
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003853")]
		[Address(RVA = "0x246F040", Offset = "0x246F040", VA = "0x7BBCC6F040")]
		public static void CopyStringToClipboard(string content)
		{
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003854")]
		[Address(RVA = "0x246F1F8", Offset = "0x246F1F8", VA = "0x7BBCC6F1F8")]
		public static string CopyStringFromClipboard()
		{
			return null;
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003855")]
		[Address(RVA = "0x246F33C", Offset = "0x246F33C", VA = "0x7BBCC6F33C")]
		public static void SaveImageToAlbum(byte[] imageData, string title, string description)
		{
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003856")]
		[Address(RVA = "0x24747B8", Offset = "0x24747B8", VA = "0x7BBCC747B8")]
		public static AndroidJavaObject ToJava(string[] strings)
		{
			return null;
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003857")]
		[Address(RVA = "0x2474AA0", Offset = "0x2474AA0", VA = "0x7BBCC74AA0")]
		public static AndroidJavaObject ToJava(float[] floats)
		{
			return null;
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003858")]
		[Address(RVA = "0x2474B1C", Offset = "0x2474B1C", VA = "0x7BBCC74B1C")]
		public static AndroidJavaObject ToJava(byte[] bytes)
		{
			return null;
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003859")]
		private static AndroidJavaObject ToJava<T>(T[] ts, string javaClass)
		{
			return null;
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x00011748 File Offset: 0x0000F948
		[Token(Token = "0x600385A")]
		[Address(RVA = "0x2474B98", Offset = "0x2474B98", VA = "0x7BBCC74B98")]
		public static bool IsPackageInstalled(string bundleIdentifier)
		{
			return default(bool);
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x00011760 File Offset: 0x0000F960
		[Token(Token = "0x600385B")]
		[Address(RVA = "0x246F5A4", Offset = "0x246F5A4", VA = "0x7BBCC6F5A4")]
		public static bool SendText(string title, string text)
		{
			return default(bool);
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x00011778 File Offset: 0x0000F978
		[Token(Token = "0x600385C")]
		[Address(RVA = "0x246F89C", Offset = "0x246F89C", VA = "0x7BBCC6F89C")]
		public static bool SendImage(string title, string filePath, string packageName = "", string className = "")
		{
			return default(bool);
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x00011790 File Offset: 0x0000F990
		[Token(Token = "0x600385D")]
		[Address(RVA = "0x2470A20", Offset = "0x2470A20", VA = "0x7BBCC70A20")]
		public static int GetAppMemory()
		{
			return 0;
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385E")]
		[Address(RVA = "0x2474CA4", Offset = "0x2474CA4", VA = "0x7BBCC74CA4")]
		public static PlatformUtility_Android.ProcessMemoryInfo GetProcessMemoryInfo()
		{
			return null;
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385F")]
		[Address(RVA = "0x2470C6C", Offset = "0x2470C6C", VA = "0x7BBCC70C6C")]
		public static PlatformUtility_Android.MemoryInfo GetMemoryInfo()
		{
			return null;
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[Token(Token = "0x6003860")]
		[Address(RVA = "0x2470B2C", Offset = "0x2470B2C", VA = "0x7BBCC70B2C")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x113BA58", Offset = "0x113BA58")]
		public static int GetAvailMemory()
		{
			return 0;
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x000117C0 File Offset: 0x0000F9C0
		[Token(Token = "0x6003861")]
		[Address(RVA = "0x2470ECC", Offset = "0x2470ECC", VA = "0x7BBCC70ECC")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x113BA94", Offset = "0x113BA94")]
		public static int GetLowMemoryThreshold()
		{
			return 0;
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x000117D8 File Offset: 0x0000F9D8
		[Token(Token = "0x6003862")]
		[Address(RVA = "0x2474E70", Offset = "0x2474E70", VA = "0x7BBCC74E70")]
		public static long GetSDCardAvailStorageWithByte()
		{
			return 0L;
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x000117F0 File Offset: 0x0000F9F0
		[Token(Token = "0x6003863")]
		[Address(RVA = "0x2474F18", Offset = "0x2474F18", VA = "0x7BBCC74F18")]
		public static int GetSDCardTotalStorage()
		{
			return 0;
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x00011808 File Offset: 0x0000FA08
		[Token(Token = "0x6003864")]
		[Address(RVA = "0x2474FD8", Offset = "0x2474FD8", VA = "0x7BBCC74FD8")]
		public static int GetSDCardAvailStorage()
		{
			return 0;
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x00011820 File Offset: 0x0000FA20
		[Token(Token = "0x6003865")]
		[Address(RVA = "0x2475098", Offset = "0x2475098", VA = "0x7BBCC75098")]
		public static int GetSystemInnerTotalStorage()
		{
			return 0;
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x00011838 File Offset: 0x0000FA38
		[Token(Token = "0x6003866")]
		[Address(RVA = "0x2475158", Offset = "0x2475158", VA = "0x7BBCC75158")]
		public static int GetSystemInnerAvailStorage()
		{
			return 0;
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x00011850 File Offset: 0x0000FA50
		[Token(Token = "0x6003867")]
		[Address(RVA = "0x2475218", Offset = "0x2475218", VA = "0x7BBCC75218")]
		public static int getAvailbleStorageByPath(string _path)
		{
			return 0;
		}

		// Token: 0x06003868 RID: 14440 RVA: 0x00011868 File Offset: 0x0000FA68
		[Token(Token = "0x6003868")]
		[Address(RVA = "0x247533C", Offset = "0x247533C", VA = "0x7BBCC7533C")]
		public static int getTotalStorageByPath(string _path)
		{
			return 0;
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003869")]
		[Address(RVA = "0x2475460", Offset = "0x2475460", VA = "0x7BBCC75460")]
		public static PlatformUtility_Android.StorageDeviceSpace getInternalStorageDeviceSpace()
		{
			return null;
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600386A")]
		[Address(RVA = "0x24755AC", Offset = "0x24755AC", VA = "0x7BBCC755AC")]
		public static PlatformUtility_Android.StorageDeviceSpace getExternalStorageDeviceSpace()
		{
			return null;
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D5")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x115A3A4", Offset = "0x115A3A4")]
		public static string DeviceIdentifier
		{
			[Token(Token = "0x600386B")]
			[Address(RVA = "0x246FD84", Offset = "0x246FD84", VA = "0x7BBCC6FD84")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600386C RID: 14444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386C")]
		[Address(RVA = "0x24734C4", Offset = "0x24734C4", VA = "0x7BBCC734C4")]
		public static void OnRequestPermissionsResult(string result)
		{
		}

		// Token: 0x0600386D RID: 14445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386D")]
		[Address(RVA = "0x2475F44", Offset = "0x2475F44", VA = "0x7BBCC75F44")]
		public static void ShowAlertDialog(string title, string content, string yes, string no, string cancel, Action onYes, Action onNo, Action onCancel, string identifier = "")
		{
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386E")]
		[Address(RVA = "0x24738A4", Offset = "0x24738A4", VA = "0x7BBCC738A4")]
		public static void OnAlertDialogPositiveButtonClick(string identifier)
		{
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386F")]
		[Address(RVA = "0x2473A88", Offset = "0x2473A88", VA = "0x7BBCC73A88")]
		public static void OnAlertDialogNegativeButtonClick(string identifier)
		{
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003870")]
		[Address(RVA = "0x2473C6C", Offset = "0x2473C6C", VA = "0x7BBCC73C6C")]
		public static void OnAlertDialogNeutralButtonClick(string identifier)
		{
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003871")]
		[Address(RVA = "0x2476288", Offset = "0x2476288", VA = "0x7BBCC76288")]
		public static void ShowRequestPermissionRationalesAlertDialog(Action onOK, string identifier)
		{
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003872")]
		[Address(RVA = "0x24763C4", Offset = "0x24763C4", VA = "0x7BBCC763C4")]
		public static void ShowRequestPermissionRationaleAlertDialog(string permission, bool isCritical, Action onYes, Action onNo, string identifier)
		{
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003873")]
		[Address(RVA = "0x2476660", Offset = "0x2476660", VA = "0x7BBCC76660")]
		public static void ShowGotoApplicationDetailsSettingsAlertDialog(string permission, Action onYes, Action onNo, string identifier)
		{
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003874")]
		[Address(RVA = "0x2476828", Offset = "0x2476828", VA = "0x7BBCC76828")]
		public static void GotoApplicationDetailsSettings()
		{
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003875")]
		[Address(RVA = "0x24756F8", Offset = "0x24756F8", VA = "0x7BBCC756F8")]
		public static string GetBuildSerial()
		{
			return null;
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003876")]
		[Address(RVA = "0x24768C8", Offset = "0x24768C8", VA = "0x7BBCC768C8")]
		public static string GetBuildFingerPrint()
		{
			return null;
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003877")]
		[Address(RVA = "0x2476970", Offset = "0x2476970", VA = "0x7BBCC76970")]
		public static string GetBuildModel()
		{
			return null;
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003878")]
		[Address(RVA = "0x2476A18", Offset = "0x2476A18", VA = "0x7BBCC76A18")]
		public static string GetBuildHardware()
		{
			return null;
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003879")]
		[Address(RVA = "0x2476AC0", Offset = "0x2476AC0", VA = "0x7BBCC76AC0")]
		public static string GetBuildDevice()
		{
			return null;
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387A")]
		[Address(RVA = "0x2476B68", Offset = "0x2476B68", VA = "0x7BBCC76B68")]
		public static string GetBuildBrand()
		{
			return null;
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387B")]
		[Address(RVA = "0x2476C10", Offset = "0x2476C10", VA = "0x7BBCC76C10")]
		public static string GetBuildManufacturer()
		{
			return null;
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387C")]
		[Address(RVA = "0x2476CB8", Offset = "0x2476CB8", VA = "0x7BBCC76CB8")]
		public static string GetBuildProduct()
		{
			return null;
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387D")]
		[Address(RVA = "0x2476D60", Offset = "0x2476D60", VA = "0x7BBCC76D60")]
		public static string GetBuildBoard()
		{
			return null;
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387E")]
		[Address(RVA = "0x2476E08", Offset = "0x2476E08", VA = "0x7BBCC76E08")]
		public static string GetBuildBootloader()
		{
			return null;
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387F")]
		[Address(RVA = "0x2476EB0", Offset = "0x2476EB0", VA = "0x7BBCC76EB0")]
		public static string GetTelephonyManagerSubscriberId()
		{
			return null;
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003880")]
		[Address(RVA = "0x246B63C", Offset = "0x246B63C", VA = "0x7BBCC6B63C")]
		public static string GetTelephonyManagerIMEI()
		{
			return null;
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003881")]
		[Address(RVA = "0x246B6E4", Offset = "0x246B6E4", VA = "0x7BBCC6B6E4")]
		public static string GetTelephonyManagerMEID()
		{
			return null;
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x00011880 File Offset: 0x0000FA80
		[Token(Token = "0x6003882")]
		[Address(RVA = "0x2476F58", Offset = "0x2476F58", VA = "0x7BBCC76F58")]
		public static ulong DigestEmulatorInfoDetail(Dictionary<string, bool> detail)
		{
			return 0UL;
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003883")]
		[Address(RVA = "0x2477168", Offset = "0x2477168", VA = "0x7BBCC77168")]
		public static Dictionary<string, bool> CheckEmulatorFilesDetail()
		{
			return null;
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x00011898 File Offset: 0x0000FA98
		[Token(Token = "0x6003884")]
		[Address(RVA = "0x24774C4", Offset = "0x24774C4", VA = "0x7BBCC774C4")]
		public static bool CheckEmulatorFiles()
		{
			return default(bool);
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003885")]
		[Address(RVA = "0x24776B4", Offset = "0x24776B4", VA = "0x7BBCC776B4")]
		private static string GetString(string className, string methodName, string[] parameters)
		{
			return null;
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003886")]
		[Address(RVA = "0x247786C", Offset = "0x247786C", VA = "0x7BBCC7786C")]
		private static string GetSystemProperty(string propertyName)
		{
			return null;
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003887")]
		[Address(RVA = "0x2477978", Offset = "0x2477978", VA = "0x7BBCC77978")]
		public static Dictionary<string, bool> CheckEmualtorPropertiesDetail()
		{
			return null;
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x000118B0 File Offset: 0x0000FAB0
		[Token(Token = "0x6003888")]
		[Address(RVA = "0x2477C70", Offset = "0x2477C70", VA = "0x7BBCC77C70")]
		public static bool CheckEmulatorProperties()
		{
			return default(bool);
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x000118C8 File Offset: 0x0000FAC8
		[Token(Token = "0x6003889")]
		[Address(RVA = "0x2477E9C", Offset = "0x2477E9C", VA = "0x7BBCC77E9C")]
		private static bool CheckPackageName(string packageName)
		{
			return default(bool);
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600388A")]
		[Address(RVA = "0x2477FA8", Offset = "0x2477FA8", VA = "0x7BBCC77FA8")]
		public static Dictionary<string, bool> CheckEmulatorPackageNamesDetail()
		{
			return null;
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x000118E0 File Offset: 0x0000FAE0
		[Token(Token = "0x600388B")]
		[Address(RVA = "0x24780E4", Offset = "0x24780E4", VA = "0x7BBCC780E4")]
		public static bool CheckEmulatorPackageNames()
		{
			return default(bool);
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x000118F8 File Offset: 0x0000FAF8
		[Token(Token = "0x600388C")]
		[Address(RVA = "0x24773B8", Offset = "0x24773B8", VA = "0x7BBCC773B8")]
		public static bool CheckFileExists(string fileName)
		{
			return default(bool);
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600388D")]
		[Address(RVA = "0x247068C", Offset = "0x247068C", VA = "0x7BBCC7068C")]
		public static string GetNetworkOperatorName()
		{
			return null;
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600388E")]
		[Address(RVA = "0x2470588", Offset = "0x2470588", VA = "0x7BBCC70588")]
		public static string GetNetworkType()
		{
			return null;
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x00011910 File Offset: 0x0000FB10
		[Token(Token = "0x600388F")]
		[Address(RVA = "0x24702FC", Offset = "0x24702FC", VA = "0x7BBCC702FC")]
		public static bool IsEmulator()
		{
			return default(bool);
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003890")]
		[Address(RVA = "0x2470798", Offset = "0x2470798", VA = "0x7BBCC70798")]
		public static void ToggleBatteryReport(bool shouldReport)
		{
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x00011928 File Offset: 0x0000FB28
		[Token(Token = "0x6003891")]
		[Address(RVA = "0x247091C", Offset = "0x247091C", VA = "0x7BBCC7091C")]
		public static float GetBatteryLevel()
		{
			return 0f;
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x00011940 File Offset: 0x0000FB40
		[Token(Token = "0x6003892")]
		[Address(RVA = "0x2470FE4", Offset = "0x2470FE4", VA = "0x7BBCC70FE4")]
		public static bool IsBatteryCharging()
		{
			return default(bool);
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x00011958 File Offset: 0x0000FB58
		[Token(Token = "0x6003893")]
		[Address(RVA = "0x24710E8", Offset = "0x24710E8", VA = "0x7BBCC710E8")]
		public static float GetWifiSignalLevel()
		{
			return 0f;
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003894")]
		[Address(RVA = "0x24611A0", Offset = "0x24611A0", VA = "0x7BBCC611A0")]
		public static void CallTraceRoute(string address, int thread_count)
		{
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003895")]
		[Address(RVA = "0x24781C8", Offset = "0x24781C8", VA = "0x7BBCC781C8")]
		public static string GetNativeLibraryDir()
		{
			return null;
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003896")]
		[Address(RVA = "0x2478270", Offset = "0x2478270", VA = "0x7BBCC78270")]
		public static string GetNativeDir()
		{
			return null;
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003897")]
		[Address(RVA = "0x2478318", Offset = "0x2478318", VA = "0x7BBCC78318")]
		public static void SendBroadcast(string packageName, string actionName, Dictionary<string, string> extras)
		{
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003898")]
		[Address(RVA = "0x24786A4", Offset = "0x24786A4", VA = "0x7BBCC786A4")]
		public static string[] GetCodecsForMediaFormat_MimeType(string mime_type, bool isEncoder, bool log)
		{
			return null;
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x00011970 File Offset: 0x0000FB70
		[Token(Token = "0x6003899")]
		[Address(RVA = "0x247888C", Offset = "0x247888C", VA = "0x7BBCC7888C")]
		public static bool SupportHardwareDecodingForH264(bool log)
		{
			return default(bool);
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600389A")]
		[Address(RVA = "0x247898C", Offset = "0x247898C", VA = "0x7BBCC7898C")]
		public static string GetCpuArchitecture()
		{
			return null;
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x00011988 File Offset: 0x0000FB88
		[Token(Token = "0x600389B")]
		[Address(RVA = "0x2478A34", Offset = "0x2478A34", VA = "0x7BBCC78A34")]
		public static bool Relaunch(long delayMS)
		{
			return default(bool);
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600389C")]
		[Address(RVA = "0x2478B68", Offset = "0x2478B68", VA = "0x7BBCC78B68")]
		public static PlatformUtility_Android.GetAdvertisingIdResult GetGoogleAdvertisingId()
		{
			return null;
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x000119A0 File Offset: 0x0000FBA0
		[Token(Token = "0x600389D")]
		[Address(RVA = "0x2478CF0", Offset = "0x2478CF0", VA = "0x7BBCC78CF0")]
		public static bool IsAdvertisingIdProviderAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389E")]
		[Address(RVA = "0x2473F50", Offset = "0x2473F50", VA = "0x7BBCC73F50")]
		internal static void OnGetAdvertisingId(PlatformUtility_Android.GetAdvertisingIdResult result)
		{
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389F")]
		[Address(RVA = "0x2478DA0", Offset = "0x2478DA0", VA = "0x7BBCC78DA0")]
		public static void GetAdvertisingId(Action<PlatformUtility_Android.GetAdvertisingIdResult> callback)
		{
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x000119B8 File Offset: 0x0000FBB8
		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x2471234", Offset = "0x2471234", VA = "0x7BBCC71234")]
		public static bool SupportInAppReview()
		{
			return default(bool);
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x000119D0 File Offset: 0x0000FBD0
		[Token(Token = "0x60038A1")]
		[Address(RVA = "0x2471330", Offset = "0x2471330", VA = "0x7BBCC71330")]
		public static bool DoInAppReview(Action<bool> callback)
		{
			return default(bool);
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A2")]
		[Address(RVA = "0x2474174", Offset = "0x2474174", VA = "0x7BBCC74174")]
		internal static void OnDoneInAppReview(PlatformUtility_Android.InAppReviewResult result)
		{
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A3")]
		[Address(RVA = "0x2478E58", Offset = "0x2478E58", VA = "0x7BBCC78E58")]
		public static void SetDebugDisplayCutout(bool debug)
		{
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x000119E8 File Offset: 0x0000FBE8
		[Token(Token = "0x60038A4")]
		[Address(RVA = "0x2478F80", Offset = "0x2478F80", VA = "0x7BBCC78F80")]
		public static bool HasDisplayCutout()
		{
			return default(bool);
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060038A5 RID: 14501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D6")]
		private static AndroidJavaClass FFLocalNotification
		{
			[Token(Token = "0x60038A5")]
			[Address(RVA = "0x2479028", Offset = "0x2479028", VA = "0x7BBCC79028")]
			get
			{
				return null;
			}
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A6")]
		[Address(RVA = "0x24715A8", Offset = "0x24715A8", VA = "0x7BBCC715A8")]
		public static void SetLocalNotificationChannel(string channel_id, PlatformUtility.LocalNotificationImportance importance, string name, string description)
		{
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A7")]
		[Address(RVA = "0x2479100", Offset = "0x2479100", VA = "0x7BBCC79100")]
		public static void GotoChannelNotificationSettings()
		{
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A8")]
		[Address(RVA = "0x2471CE4", Offset = "0x2471CE4", VA = "0x7BBCC71CE4")]
		public static void ScheduleLocalNotification(int id, string title, string content, long time_ms, int repeat_interval_ms, int repeat_times, string uri, string channel_id)
		{
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A9")]
		[Address(RVA = "0x247214C", Offset = "0x247214C", VA = "0x7BBCC7214C")]
		public static void UnscheduleLocalNotification(int id)
		{
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AA")]
		[Address(RVA = "0x24722D0", Offset = "0x24722D0", VA = "0x7BBCC722D0")]
		public static void UnscheduleAllLocalNotifications()
		{
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AB")]
		[Address(RVA = "0x24723CC", Offset = "0x24723CC", VA = "0x7BBCC723CC")]
		public static void ClearAllNotifications()
		{
		}

		// Token: 0x04004A76 RID: 19062
		[Token(Token = "0x4004A76")]
		public const int PERMISSION_REQUEST_CODE = 1638;

		// Token: 0x04004A77 RID: 19063
		[Token(Token = "0x4004A77")]
		[FieldOffset(Offset = "0x0")]
		public static string FileProviderAuthorities;

		// Token: 0x04004A78 RID: 19064
		[Token(Token = "0x4004A78")]
		[FieldOffset(Offset = "0x8")]
		private static PlatformUtility_Android.OnRequestPermissionsResultCallback _OnRequestPermissionsResult;

		// Token: 0x04004A79 RID: 19065
		[Token(Token = "0x4004A79")]
		[FieldOffset(Offset = "0x10")]
		private static AndroidJavaClass _FFAPI;

		// Token: 0x04004A7A RID: 19066
		[Token(Token = "0x4004A7A")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<string, Action> _PositiveCallbacks;

		// Token: 0x04004A7B RID: 19067
		[Token(Token = "0x4004A7B")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<string, Action> _NegativeCallbacks;

		// Token: 0x04004A7C RID: 19068
		[Token(Token = "0x4004A7C")]
		[FieldOffset(Offset = "0x28")]
		private static Dictionary<string, Action> _NeutralCallbacks;

		// Token: 0x04004A7D RID: 19069
		[Token(Token = "0x4004A7D")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Dictionary<string, string[]> _EmulatorFiles;

		// Token: 0x04004A7E RID: 19070
		[Token(Token = "0x4004A7E")]
		[FieldOffset(Offset = "0x38")]
		private static readonly Dictionary<string, string> _EmulatorProperties;

		// Token: 0x04004A7F RID: 19071
		[Token(Token = "0x4004A7F")]
		private const int PROPERTIES_THRESHOLD = 5;

		// Token: 0x04004A80 RID: 19072
		[Token(Token = "0x4004A80")]
		[FieldOffset(Offset = "0x40")]
		private static readonly string[] _EmulatorPackageNames;

		// Token: 0x04004A81 RID: 19073
		[Token(Token = "0x4004A81")]
		public const string CODEC_NAME_PREFIX_SOFTWARE = "OMX.google.";

		// Token: 0x04004A82 RID: 19074
		[Token(Token = "0x4004A82")]
		[FieldOffset(Offset = "0x48")]
		private static Action<PlatformUtility_Android.GetAdvertisingIdResult> _GetAdvertisingIdCallback;

		// Token: 0x04004A83 RID: 19075
		[Token(Token = "0x4004A83")]
		[FieldOffset(Offset = "0x50")]
		private static Action<bool> _DoInAppReviewCallback;

		// Token: 0x04004A84 RID: 19076
		[Token(Token = "0x4004A84")]
		[FieldOffset(Offset = "0x58")]
		private static AndroidJavaClass _FFLocalNotification;

		// Token: 0x02000F47 RID: 3911
		[Token(Token = "0x2000F47")]
		private static class IntentExtra
		{
			// Token: 0x04004A85 RID: 19077
			[Token(Token = "0x4004A85")]
			public const string TEXT = "android.intent.extra.TEXT";

			// Token: 0x04004A86 RID: 19078
			[Token(Token = "0x4004A86")]
			public const string STREAM = "android.intent.extra.STREAM";
		}

		// Token: 0x02000F48 RID: 3912
		[Token(Token = "0x2000F48")]
		private static class IntentType
		{
			// Token: 0x04004A87 RID: 19079
			[Token(Token = "0x4004A87")]
			public const string TEXT_PLAIN = "text/plain";

			// Token: 0x04004A88 RID: 19080
			[Token(Token = "0x4004A88")]
			public const string IMAGE = "image/*";
		}

		// Token: 0x02000F49 RID: 3913
		[Token(Token = "0x2000F49")]
		public static class Permissions
		{
			// Token: 0x04004A89 RID: 19081
			[Token(Token = "0x4004A89")]
			public const string READ_EXTERNAL_STORAGE = "android.permission.READ_EXTERNAL_STORAGE";

			// Token: 0x04004A8A RID: 19082
			[Token(Token = "0x4004A8A")]
			public const string WRITE_EXTERNAL_STORAGE = "android.permission.WRITE_EXTERNAL_STORAGE";

			// Token: 0x04004A8B RID: 19083
			[Token(Token = "0x4004A8B")]
			public const string READ_PHONE_STATE = "android.permission.READ_PHONE_STATE";

			// Token: 0x04004A8C RID: 19084
			[Token(Token = "0x4004A8C")]
			public const string RECORD_AUDIO = "android.permission.RECORD_AUDIO";

			// Token: 0x04004A8D RID: 19085
			[Token(Token = "0x4004A8D")]
			public const string GET_ACCOUNTS = "android.permission.GET_ACCOUNTS";
		}

		// Token: 0x02000F4A RID: 3914
		[Token(Token = "0x2000F4A")]
		public enum PermissionGrantResult
		{
			// Token: 0x04004A8F RID: 19087
			[Token(Token = "0x4004A8F")]
			Denied = -1,
			// Token: 0x04004A90 RID: 19088
			[Token(Token = "0x4004A90")]
			Granted
		}

		// Token: 0x02000F4B RID: 3915
		[Token(Token = "0x2000F4B")]
		public class RequestPermissionResult
		{
			// Token: 0x060038AD RID: 14509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038AD")]
			[Address(RVA = "0x24757A0", Offset = "0x24757A0", VA = "0x7BBCC757A0")]
			public RequestPermissionResult()
			{
			}

			// Token: 0x04004A91 RID: 19089
			[Token(Token = "0x4004A91")]
			[FieldOffset(Offset = "0x10")]
			public int RequestCode;

			// Token: 0x04004A92 RID: 19090
			[Token(Token = "0x4004A92")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> Results;
		}

		// Token: 0x02000F4C RID: 3916
		// (Invoke) Token: 0x060038AF RID: 14511
		[Token(Token = "0x2000F4C")]
		public delegate void OnRequestPermissionsResultCallback(PlatformUtility_Android.RequestPermissionResult result);

		// Token: 0x02000F4D RID: 3917
		[Token(Token = "0x2000F4D")]
		public class ProcessMemoryInfo
		{
			// Token: 0x060038B2 RID: 14514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038B2")]
			[Address(RVA = "0x247A324", Offset = "0x247A324", VA = "0x7BBCC7A324")]
			public ProcessMemoryInfo()
			{
			}

			// Token: 0x04004A93 RID: 19091
			[Token(Token = "0x4004A93")]
			[FieldOffset(Offset = "0x10")]
			public int cost_ms;

			// Token: 0x04004A94 RID: 19092
			[Token(Token = "0x4004A94")]
			[FieldOffset(Offset = "0x14")]
			public int dalvikPrivateDirty;

			// Token: 0x04004A95 RID: 19093
			[Token(Token = "0x4004A95")]
			[FieldOffset(Offset = "0x18")]
			public int dalvikPss;

			// Token: 0x04004A96 RID: 19094
			[Token(Token = "0x4004A96")]
			[FieldOffset(Offset = "0x1C")]
			public int dalvikSharedDirty;

			// Token: 0x04004A97 RID: 19095
			[Token(Token = "0x4004A97")]
			[FieldOffset(Offset = "0x20")]
			public int nativePrivateDirty;

			// Token: 0x04004A98 RID: 19096
			[Token(Token = "0x4004A98")]
			[FieldOffset(Offset = "0x24")]
			public int nativePss;

			// Token: 0x04004A99 RID: 19097
			[Token(Token = "0x4004A99")]
			[FieldOffset(Offset = "0x28")]
			public int nativeSharedDirty;

			// Token: 0x04004A9A RID: 19098
			[Token(Token = "0x4004A9A")]
			[FieldOffset(Offset = "0x2C")]
			public int otherPrivateDirty;

			// Token: 0x04004A9B RID: 19099
			[Token(Token = "0x4004A9B")]
			[FieldOffset(Offset = "0x30")]
			public int otherPss;

			// Token: 0x04004A9C RID: 19100
			[Token(Token = "0x4004A9C")]
			[FieldOffset(Offset = "0x34")]
			public int otherSharedDirty;

			// Token: 0x04004A9D RID: 19101
			[Token(Token = "0x4004A9D")]
			[FieldOffset(Offset = "0x38")]
			public int totalPrivateClean;

			// Token: 0x04004A9E RID: 19102
			[Token(Token = "0x4004A9E")]
			[FieldOffset(Offset = "0x3C")]
			public int totalPrivateDirty;

			// Token: 0x04004A9F RID: 19103
			[Token(Token = "0x4004A9F")]
			[FieldOffset(Offset = "0x40")]
			public int totalPss;

			// Token: 0x04004AA0 RID: 19104
			[Token(Token = "0x4004AA0")]
			[FieldOffset(Offset = "0x44")]
			public int totalSharedClean;

			// Token: 0x04004AA1 RID: 19105
			[Token(Token = "0x4004AA1")]
			[FieldOffset(Offset = "0x48")]
			public int totalSharedDirty;

			// Token: 0x04004AA2 RID: 19106
			[Token(Token = "0x4004AA2")]
			[FieldOffset(Offset = "0x4C")]
			public int totalSwappablePss;
		}

		// Token: 0x02000F4E RID: 3918
		[Token(Token = "0x2000F4E")]
		public class MemoryInfo
		{
			// Token: 0x060038B3 RID: 14515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038B3")]
			[Address(RVA = "0x247A2DC", Offset = "0x247A2DC", VA = "0x7BBCC7A2DC")]
			public MemoryInfo()
			{
			}

			// Token: 0x04004AA3 RID: 19107
			[Token(Token = "0x4004AA3")]
			[FieldOffset(Offset = "0x10")]
			public long availMem;

			// Token: 0x04004AA4 RID: 19108
			[Token(Token = "0x4004AA4")]
			[FieldOffset(Offset = "0x18")]
			public bool lowMemory;

			// Token: 0x04004AA5 RID: 19109
			[Token(Token = "0x4004AA5")]
			[FieldOffset(Offset = "0x20")]
			public long threshold;

			// Token: 0x04004AA6 RID: 19110
			[Token(Token = "0x4004AA6")]
			[FieldOffset(Offset = "0x28")]
			public long totalMem;

			// Token: 0x04004AA7 RID: 19111
			[Token(Token = "0x4004AA7")]
			[FieldOffset(Offset = "0x30")]
			public int cost_ms;
		}

		// Token: 0x02000F4F RID: 3919
		[Token(Token = "0x2000F4F")]
		public class StorageDeviceSpace
		{
			// Token: 0x060038B4 RID: 14516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038B4")]
			[Address(RVA = "0x247A32C", Offset = "0x247A32C", VA = "0x7BBCC7A32C")]
			public StorageDeviceSpace()
			{
			}

			// Token: 0x04004AA8 RID: 19112
			[Token(Token = "0x4004AA8")]
			[FieldOffset(Offset = "0x10")]
			public long Free;

			// Token: 0x04004AA9 RID: 19113
			[Token(Token = "0x4004AA9")]
			[FieldOffset(Offset = "0x18")]
			public long Total;
		}

		// Token: 0x02000F50 RID: 3920
		[Token(Token = "0x2000F50")]
		public static class MimeTypes
		{
			// Token: 0x04004AAA RID: 19114
			[Token(Token = "0x4004AAA")]
			public const string VIDEO_AVC = "video/avc";
		}

		// Token: 0x02000F51 RID: 3921
		[Token(Token = "0x2000F51")]
		public class GetAdvertisingIdResult
		{
			// Token: 0x060038B5 RID: 14517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038B5")]
			[Address(RVA = "0x247A2CC", Offset = "0x247A2CC", VA = "0x7BBCC7A2CC")]
			public GetAdvertisingIdResult()
			{
			}

			// Token: 0x04004AAB RID: 19115
			[Token(Token = "0x4004AAB")]
			[FieldOffset(Offset = "0x10")]
			public string Exception;

			// Token: 0x04004AAC RID: 19116
			[Token(Token = "0x4004AAC")]
			[FieldOffset(Offset = "0x18")]
			public string AdvertisingId;

			// Token: 0x04004AAD RID: 19117
			[Token(Token = "0x4004AAD")]
			[FieldOffset(Offset = "0x20")]
			public string ProviderPackageName;

			// Token: 0x04004AAE RID: 19118
			[Token(Token = "0x4004AAE")]
			[FieldOffset(Offset = "0x28")]
			public bool IsLimitAdTrackingEnabled;
		}

		// Token: 0x02000F52 RID: 3922
		[Token(Token = "0x2000F52")]
		[Serializable]
		public class InAppReviewResult
		{
			// Token: 0x060038B6 RID: 14518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038B6")]
			[Address(RVA = "0x247A2D4", Offset = "0x247A2D4", VA = "0x7BBCC7A2D4")]
			public InAppReviewResult()
			{
			}

			// Token: 0x04004AAF RID: 19119
			[Token(Token = "0x4004AAF")]
			[FieldOffset(Offset = "0x10")]
			public bool RequestFailure;

			// Token: 0x04004AB0 RID: 19120
			[Token(Token = "0x4004AB0")]
			[FieldOffset(Offset = "0x11")]
			public bool LaunchFailure;

			// Token: 0x04004AB1 RID: 19121
			[Token(Token = "0x4004AB1")]
			[FieldOffset(Offset = "0x18")]
			public string ExceptionType;

			// Token: 0x04004AB2 RID: 19122
			[Token(Token = "0x4004AB2")]
			[FieldOffset(Offset = "0x20")]
			public string ExceptionMessage;
		}

		// Token: 0x02000F53 RID: 3923
		[Token(Token = "0x2000F53")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA480", Offset = "0x10EA480")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060038B8 RID: 14520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038B8")]
			[Address(RVA = "0x247A020", Offset = "0x247A020", VA = "0x7BBCC7A020")]
			public <>c()
			{
			}

			// Token: 0x060038B9 RID: 14521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60038B9")]
			[Address(RVA = "0x247A028", Offset = "0x247A028", VA = "0x7BBCC7A028")]
			internal string <get_DeviceIdentifier>b__55_0(byte item)
			{
				return null;
			}

			// Token: 0x04004AB3 RID: 19123
			[Token(Token = "0x4004AB3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly PlatformUtility_Android.<>c <>9;

			// Token: 0x04004AB4 RID: 19124
			[Token(Token = "0x4004AB4")]
			[FieldOffset(Offset = "0x8")]
			public static Func<byte, string> <>9__55_0;
		}

		// Token: 0x02000F54 RID: 3924
		[Token(Token = "0x2000F54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA490", Offset = "0x10EA490")]
		private sealed class <>c__DisplayClass116_0
		{
			// Token: 0x060038BA RID: 14522 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038BA")]
			[Address(RVA = "0x2478D98", Offset = "0x2478D98", VA = "0x7BBCC78D98")]
			public <>c__DisplayClass116_0()
			{
			}

			// Token: 0x060038BB RID: 14523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038BB")]
			[Address(RVA = "0x247A080", Offset = "0x247A080", VA = "0x7BBCC7A080")]
			internal void <OnGetAdvertisingId>b__0()
			{
			}

			// Token: 0x04004AB5 RID: 19125
			[Token(Token = "0x4004AB5")]
			[FieldOffset(Offset = "0x10")]
			public PlatformUtility_Android.GetAdvertisingIdResult result;
		}

		// Token: 0x02000F55 RID: 3925
		[Token(Token = "0x2000F55")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA4A0", Offset = "0x10EA4A0")]
		private sealed class <>c__DisplayClass123_0
		{
			// Token: 0x060038BC RID: 14524 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038BC")]
			[Address(RVA = "0x2478E50", Offset = "0x2478E50", VA = "0x7BBCC78E50")]
			public <>c__DisplayClass123_0()
			{
			}

			// Token: 0x060038BD RID: 14525 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038BD")]
			[Address(RVA = "0x247A14C", Offset = "0x247A14C", VA = "0x7BBCC7A14C")]
			internal void <OnDoneInAppReview>b__0()
			{
			}

			// Token: 0x04004AB6 RID: 19126
			[Token(Token = "0x4004AB6")]
			[FieldOffset(Offset = "0x10")]
			public PlatformUtility_Android.InAppReviewResult result;
		}
	}
}
