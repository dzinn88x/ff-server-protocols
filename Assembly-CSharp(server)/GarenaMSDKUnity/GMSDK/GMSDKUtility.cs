using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.GMSDK
{
	// Token: 0x02002BC0 RID: 11200
	[Token(Token = "0x2002BC0")]
	internal static class GMSDKUtility
	{
		// Token: 0x0600F804 RID: 63492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F804")]
		[Address(RVA = "0x2741B18", Offset = "0x2741B18", VA = "0x7BBCF41B18")]
		public static string GeneratePassword(int length = 64)
		{
			return null;
		}

		// Token: 0x0600F805 RID: 63493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F805")]
		[Address(RVA = "0x2741CD8", Offset = "0x2741CD8", VA = "0x7BBCF41CD8")]
		public static string Digest_SHA256(string template)
		{
			return null;
		}

		// Token: 0x0600F806 RID: 63494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F806")]
		[Address(RVA = "0x2741F4C", Offset = "0x2741F4C", VA = "0x7BBCF41F4C")]
		public static string MakeUrlParameters(Dictionary<string, string> data)
		{
			return null;
		}

		// Token: 0x0600F807 RID: 63495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F807")]
		[Address(RVA = "0x2742194", Offset = "0x2742194", VA = "0x7BBCF42194")]
		public static string MakeJsonParameters(Dictionary<string, string> data)
		{
			return null;
		}

		// Token: 0x04011B8E RID: 72590
		[Token(Token = "0x4011B8E")]
		private const string PASSWORD_CHARACTERS = "0123456789abcdefghijklmnopqrstuvwxyz!@#$%^&*()";

		// Token: 0x02002BC1 RID: 11201
		[Token(Token = "0x2002BC1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FF7C4", Offset = "0x10FF7C4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600F809 RID: 63497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F809")]
			[Address(RVA = "0x274242C", Offset = "0x274242C", VA = "0x7BBCF4242C")]
			public <>c()
			{
			}

			// Token: 0x0600F80A RID: 63498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F80A")]
			[Address(RVA = "0x2742434", Offset = "0x2742434", VA = "0x7BBCF42434")]
			internal string <Digest_SHA256>b__2_0(byte item)
			{
				return null;
			}

			// Token: 0x04011B8F RID: 72591
			[Token(Token = "0x4011B8F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly GMSDKUtility.<>c <>9;

			// Token: 0x04011B90 RID: 72592
			[Token(Token = "0x4011B90")]
			[FieldOffset(Offset = "0x8")]
			public static Func<byte, string> <>9__2_0;
		}
	}
}
