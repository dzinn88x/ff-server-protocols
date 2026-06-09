using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011BF RID: 4543
	[Token(Token = "0x20011BF")]
	public static class DeviceIdentifier
	{
		// Token: 0x060046B2 RID: 18098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B2")]
		[Address(RVA = "0x16059E0", Offset = "0x16059E0", VA = "0x7BBBE059E0")]
		public static void Init()
		{
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B3")]
		[Address(RVA = "0x1605C38", Offset = "0x1605C38", VA = "0x7BBBE05C38")]
		public static string Read()
		{
			return null;
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B4")]
		[Address(RVA = "0x16059E4", Offset = "0x16059E4", VA = "0x7BBBE059E4")]
		private static void InitAndroid()
		{
		}

		// Token: 0x060046B5 RID: 18101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B5")]
		[Address(RVA = "0x1605DE4", Offset = "0x1605DE4", VA = "0x7BBBE05DE4")]
		private static void OnGetAdvertisingId(PlatformUtility_Android.GetAdvertisingIdResult result)
		{
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B6")]
		[Address(RVA = "0x1605D20", Offset = "0x1605D20", VA = "0x7BBBE05D20")]
		private static void WriteAndroidDeviceIdentifier(string deviceIdentifier)
		{
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B7")]
		[Address(RVA = "0x1605C3C", Offset = "0x1605C3C", VA = "0x7BBBE05C3C")]
		private static string ReadAndroidDeviceIdentifier()
		{
			return null;
		}

		// Token: 0x04006DE3 RID: 28131
		[Token(Token = "0x4006DE3")]
		private const string DEVICE_IDENTIFIER_FORMAT = "{0}|{1}";

		// Token: 0x04006DE4 RID: 28132
		[Token(Token = "0x4006DE4")]
		private const string PLAYER_PREFS_KEY_ANDROID_DEVICE_IDENTIFIER = "AND_DEV_ID_0";

		// Token: 0x04006DE5 RID: 28133
		[Token(Token = "0x4006DE5")]
		private const string PROVIDER_GOOGLE = "Google";
	}
}
