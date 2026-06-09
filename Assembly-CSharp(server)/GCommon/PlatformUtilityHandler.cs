using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F45 RID: 3909
	[Token(Token = "0x2000F45")]
	internal class PlatformUtilityHandler : MonoBehaviour
	{
		// Token: 0x06003837 RID: 14391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003837")]
		[Address(RVA = "0x246DD74", Offset = "0x246DD74", VA = "0x7BBCC6DD74")]
		public static void Init()
		{
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003838")]
		[Address(RVA = "0x24732E0", Offset = "0x24732E0", VA = "0x7BBCC732E0")]
		public void OnBatteryChargingChanged(string message)
		{
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003839")]
		[Address(RVA = "0x2473378", Offset = "0x2473378", VA = "0x7BBCC73378")]
		public void OnBatteryLevelChanged(string message)
		{
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383A")]
		[Address(RVA = "0x24733E8", Offset = "0x24733E8", VA = "0x7BBCC733E8")]
		public void onSaveImageToAlbumResult(string error)
		{
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383B")]
		[Address(RVA = "0x2473460", Offset = "0x2473460", VA = "0x7BBCC73460")]
		public void onRequestPermissionsResult(string result)
		{
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383C")]
		[Address(RVA = "0x2473840", Offset = "0x2473840", VA = "0x7BBCC73840")]
		public void onAlertDialogPositiveButtonClick(string identifier)
		{
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383D")]
		[Address(RVA = "0x2473A24", Offset = "0x2473A24", VA = "0x7BBCC73A24")]
		public void onAlertDialogNegativeButtonClick(string identifier)
		{
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383E")]
		[Address(RVA = "0x2473C08", Offset = "0x2473C08", VA = "0x7BBCC73C08")]
		public void onAlertDialogNeutralButtonClick(string identifier)
		{
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383F")]
		[Address(RVA = "0x2473DEC", Offset = "0x2473DEC", VA = "0x7BBCC73DEC")]
		public void onGetAdvertisingId(string result)
		{
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003840")]
		[Address(RVA = "0x2474010", Offset = "0x2474010", VA = "0x7BBCC74010")]
		public void onInAppReviewCallback(string result)
		{
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003841")]
		[Address(RVA = "0x2474234", Offset = "0x2474234", VA = "0x7BBCC74234")]
		public void onTakenScreenshot(string clue)
		{
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003842")]
		[Address(RVA = "0x247423C", Offset = "0x247423C", VA = "0x7BBCC7423C")]
		public PlatformUtilityHandler()
		{
		}

		// Token: 0x04004A74 RID: 19060
		[Token(Token = "0x4004A74")]
		private const string PLATFORM_UTILITY_HANDLER = "PlatformUtilityHandler";

		// Token: 0x04004A75 RID: 19061
		[Token(Token = "0x4004A75")]
		[FieldOffset(Offset = "0x0")]
		private static PlatformUtilityHandler _I;
	}
}
