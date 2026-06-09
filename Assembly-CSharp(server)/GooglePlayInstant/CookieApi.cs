using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayInstant
{
	// Token: 0x02002BA4 RID: 11172
	[Token(Token = "0x2002BA4")]
	public static class CookieApi
	{
		// Token: 0x0600F704 RID: 63236 RVA: 0x00046E60 File Offset: 0x00045060
		[Token(Token = "0x600F704")]
		[Address(RVA = "0x274BC80", Offset = "0x274BC80", VA = "0x7BBCF4BC80")]
		public static int GetInstantAppCookieMaxSizeBytes()
		{
			return 0;
		}

		// Token: 0x0600F705 RID: 63237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F705")]
		[Address(RVA = "0x274C82C", Offset = "0x274C82C", VA = "0x7BBCF4C82C")]
		public static string GetInstantAppCookie()
		{
			return null;
		}

		// Token: 0x0600F706 RID: 63238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F706")]
		[Address(RVA = "0x274C884", Offset = "0x274C884", VA = "0x7BBCF4C884")]
		public static byte[] GetInstantAppCookieBytes()
		{
			return null;
		}

		// Token: 0x0600F707 RID: 63239 RVA: 0x00046E78 File Offset: 0x00045078
		[Token(Token = "0x600F707")]
		[Address(RVA = "0x274CE10", Offset = "0x274CE10", VA = "0x7BBCF4CE10")]
		public static bool SetInstantAppCookie(string cookie)
		{
			return default(bool);
		}

		// Token: 0x0600F708 RID: 63240 RVA: 0x00046E90 File Offset: 0x00045090
		[Token(Token = "0x600F708")]
		[Address(RVA = "0x274CE5C", Offset = "0x274CE5C", VA = "0x7BBCF4CE5C")]
		public static bool SetInstantAppCookieBytes(byte[] cookie)
		{
			return default(bool);
		}

		// Token: 0x0600F709 RID: 63241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F709")]
		[Address(RVA = "0x274D384", Offset = "0x274D384", VA = "0x7BBCF4D384")]
		private static void VerifyContentProvider()
		{
		}

		// Token: 0x0600F70A RID: 63242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F70A")]
		[Address(RVA = "0x274BF5C", Offset = "0x274BF5C", VA = "0x7BBCF4BF5C")]
		private static AndroidJavaObject CallMethod(string methodName, AndroidJavaObject extrasBundle)
		{
			return null;
		}

		// Token: 0x0600F70B RID: 63243 RVA: 0x00046EA8 File Offset: 0x000450A8
		[Token(Token = "0x600F70B")]
		[Address(RVA = "0x274CC9C", Offset = "0x274CC9C", VA = "0x7BBCF4CC9C")]
		private static int ProcessGetMyUid()
		{
			return 0;
		}

		// Token: 0x04011B26 RID: 72486
		[Token(Token = "0x4011B26")]
		private const string Authority = "com.google.android.gms.instantapps.provider.api";

		// Token: 0x04011B27 RID: 72487
		[Token(Token = "0x4011B27")]
		private const string ContentAuthority = "content://com.google.android.gms.instantapps.provider.api/";

		// Token: 0x04011B28 RID: 72488
		[Token(Token = "0x4011B28")]
		private const string KeyCookie = "cookie";

		// Token: 0x04011B29 RID: 72489
		[Token(Token = "0x4011B29")]
		private const string KeyResult = "result";

		// Token: 0x04011B2A RID: 72490
		[Token(Token = "0x4011B2A")]
		private const string KeyUid = "uid";

		// Token: 0x04011B2B RID: 72491
		[Token(Token = "0x4011B2B")]
		private const string MethodGetInstantAppCookie = "getInstantAppCookie";

		// Token: 0x04011B2C RID: 72492
		[Token(Token = "0x4011B2C")]
		private const string MethodGetInstantAppCookieMaxSize = "getInstantAppCookieMaxSize";

		// Token: 0x04011B2D RID: 72493
		[Token(Token = "0x4011B2D")]
		private const string MethodSetInstantAppCookie = "setInstantAppCookie";

		// Token: 0x04011B2E RID: 72494
		[Token(Token = "0x4011B2E")]
		[FieldOffset(Offset = "0x0")]
		private static bool _verifiedContentProvider;

		// Token: 0x02002BA5 RID: 11173
		[Token(Token = "0x2002BA5")]
		public class CookieApiException : Exception
		{
			// Token: 0x0600F70C RID: 63244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F70C")]
			[Address(RVA = "0x274DBA8", Offset = "0x274DBA8", VA = "0x7BBCF4DBA8")]
			public CookieApiException(string message, Exception innerException)
			{
			}

			// Token: 0x0600F70D RID: 63245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F70D")]
			[Address(RVA = "0x274DB30", Offset = "0x274DB30", VA = "0x7BBCF4DB30")]
			public CookieApiException(string message)
			{
			}
		}
	}
}
