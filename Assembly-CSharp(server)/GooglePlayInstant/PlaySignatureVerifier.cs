using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayInstant
{
	// Token: 0x02002BA7 RID: 11175
	[Token(Token = "0x2002BA7")]
	public static class PlaySignatureVerifier
	{
		// Token: 0x0600F717 RID: 63255 RVA: 0x00046ED8 File Offset: 0x000450D8
		[Token(Token = "0x600F717")]
		[Address(RVA = "0x274DAC0", Offset = "0x274DAC0", VA = "0x7BBCF4DAC0")]
		public static bool VerifyGooglePlayServices(AndroidJavaObject packageManager)
		{
			return default(bool);
		}

		// Token: 0x0600F718 RID: 63256 RVA: 0x00046EF0 File Offset: 0x000450F0
		[Token(Token = "0x600F718")]
		[Address(RVA = "0x274FB50", Offset = "0x274FB50", VA = "0x7BBCF4FB50")]
		private static bool VerifyGooglePlayPackage(AndroidJavaObject packageManager, string packageName)
		{
			return default(bool);
		}

		// Token: 0x04011B31 RID: 72497
		[Token(Token = "0x4011B31")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] GooglePlayPackageSignature;
	}
}
