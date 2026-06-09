using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002094 RID: 8340
	[Token(Token = "0x2002094")]
	public static class ShopeeUtility
	{
		// Token: 0x0600BB6D RID: 47981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB6D")]
		[Address(RVA = "0x1B37AB4", Offset = "0x1B37AB4", VA = "0x7BBC337AB4")]
		public static void AfterAppLaunch()
		{
		}

		// Token: 0x0600BB6E RID: 47982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB6E")]
		[Address(RVA = "0x1B37BF0", Offset = "0x1B37BF0", VA = "0x7BBC337BF0")]
		private static void AfterAppLaunch_Android()
		{
		}

		// Token: 0x0600BB6F RID: 47983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB6F")]
		[Address(RVA = "0x1B37EF8", Offset = "0x1B37EF8", VA = "0x7BBC337EF8")]
		public static void AfterLoginServer()
		{
		}

		// Token: 0x0600BB70 RID: 47984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB70")]
		[Address(RVA = "0x1B3807C", Offset = "0x1B3807C", VA = "0x7BBC33807C")]
		private static void AfterLoginServer_Android_Garena()
		{
		}

		// Token: 0x0400BC60 RID: 48224
		[Token(Token = "0x400BC60")]
		private const string ANDROID_ACTION = "com.freefire.broadcast.ID";

		// Token: 0x0400BC61 RID: 48225
		[Token(Token = "0x400BC61")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] ANDROID_APP_NAMES;

		// Token: 0x0400BC62 RID: 48226
		[Token(Token = "0x400BC62")]
		private const string ANDROID_BROADCAST_INTENT_EXTRA_KEY_DEVICE_FINGERPRINT = "device_fingerprint";

		// Token: 0x0400BC63 RID: 48227
		[Token(Token = "0x400BC63")]
		private const string ANDROID_BROADCAST_INTENT_EXTRA_KEY_GOP_ID = "gop_id";

		// Token: 0x0400BC64 RID: 48228
		[Token(Token = "0x400BC64")]
		private const string ANDROID_BROADCAST_INTENT_EXTRA_KEY_GOP_ENV = "gop_env";

		// Token: 0x0400BC65 RID: 48229
		[Token(Token = "0x400BC65")]
		private const string ANDROID_AES_PASSWORD = "FreeFire_Shopee_20190813";

		// Token: 0x0400BC66 RID: 48230
		[Token(Token = "0x400BC66")]
		[FieldOffset(Offset = "0x8")]
		private static readonly AES.AESOption AES_Option_DeviceIdentifier;

		// Token: 0x0400BC67 RID: 48231
		[Token(Token = "0x400BC67")]
		[FieldOffset(Offset = "0x10")]
		private static readonly AES.AESOption AES_Option_OpenID;
	}
}
