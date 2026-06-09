using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayInstant
{
	// Token: 0x02002BA6 RID: 11174
	[Token(Token = "0x2002BA6")]
	public static class InstallLauncher
	{
		// Token: 0x0600F70E RID: 63246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F70E")]
		[Address(RVA = "0x274DC28", Offset = "0x274DC28", VA = "0x7BBCF4DC28")]
		public static void ShowInstallPrompt()
		{
		}

		// Token: 0x0600F70F RID: 63247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F70F")]
		[Address(RVA = "0x274DFF8", Offset = "0x274DFF8", VA = "0x7BBCF4DFF8")]
		public static void ShowInstallPrompt(AndroidJavaObject activity, int requestCode, AndroidJavaObject postInstallIntent, string referrer)
		{
		}

		// Token: 0x0600F710 RID: 63248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F710")]
		[Address(RVA = "0x274DFFC", Offset = "0x274DFFC", VA = "0x7BBCF4DFFC")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x114B7A0", Offset = "0x114B7A0")]
		public static AndroidJavaObject GetCurrentActivity()
		{
			return null;
		}

		// Token: 0x0600F711 RID: 63249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F711")]
		[Address(RVA = "0x274DDBC", Offset = "0x274DDBC", VA = "0x7BBCF4DDBC")]
		public static AndroidJavaObject CreatePostInstallIntent(AndroidJavaObject activity)
		{
			return null;
		}

		// Token: 0x0600F712 RID: 63250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F712")]
		[Address(RVA = "0x274E000", Offset = "0x274E000", VA = "0x7BBCF4E000")]
		public static void PutPostInstallIntentStringExtra(AndroidJavaObject postInstallIntent, string extraKey, string extraValue)
		{
		}

		// Token: 0x0600F713 RID: 63251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F713")]
		[Address(RVA = "0x274E1B0", Offset = "0x274E1B0", VA = "0x7BBCF4E1B0")]
		public static string GetPostInstallIntentStringExtra(string extraKey)
		{
			return null;
		}

		// Token: 0x0600F714 RID: 63252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F714")]
		[Address(RVA = "0x274E4AC", Offset = "0x274E4AC", VA = "0x7BBCF4E4AC")]
		private static AndroidJavaObject CreateMarketDetailsUri(string referrer)
		{
			return null;
		}

		// Token: 0x0600F715 RID: 63253 RVA: 0x00046EC0 File Offset: 0x000450C0
		[Token(Token = "0x600F715")]
		[Address(RVA = "0x274ED50", Offset = "0x274ED50", VA = "0x7BBCF4ED50")]
		private static bool IsLegacyPlayStore(AndroidJavaObject context, AndroidJavaObject installIntent)
		{
			return default(bool);
		}

		// Token: 0x0600F716 RID: 63254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F716")]
		[Address(RVA = "0x274F030", Offset = "0x274F030", VA = "0x7BBCF4F030")]
		private static void ShowLegacyInstallPrompt(AndroidJavaObject activity, int requestCode, AndroidJavaObject uri)
		{
		}

		// Token: 0x04011B2F RID: 72495
		[Token(Token = "0x4011B2F")]
		private const string IntentActionInstantAppInstall = "com.google.android.finsky.action.IA_INSTALL";

		// Token: 0x04011B30 RID: 72496
		[Token(Token = "0x4011B30")]
		private const int IgnoredRequestCode = 1001;
	}
}
