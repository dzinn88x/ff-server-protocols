using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F13 RID: 3859
	[Token(Token = "0x2000F13")]
	public static class AES
	{
		// Token: 0x06003696 RID: 13974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003696")]
		[Address(RVA = "0x25D607C", Offset = "0x25D607C", VA = "0x7BBCDD607C")]
		public static string EncryptText(string decoded, AES.AESOption option)
		{
			return null;
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003697")]
		[Address(RVA = "0x25D68AC", Offset = "0x25D68AC", VA = "0x7BBCDD68AC")]
		public static string DecryptText(string encoded, AES.AESOption option)
		{
			return null;
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003698")]
		[Address(RVA = "0x25D6134", Offset = "0x25D6134", VA = "0x7BBCDD6134")]
		public static byte[] Encrypt(string plainText, AES.AESOption option)
		{
			return null;
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003699")]
		[Address(RVA = "0x25D69D4", Offset = "0x25D69D4", VA = "0x7BBCDD69D4")]
		public static string Decrypt(byte[] cipherText, AES.AESOption option)
		{
			return null;
		}

		// Token: 0x02000F14 RID: 3860
		[Token(Token = "0x2000F14")]
		public class AESOption
		{
			// Token: 0x0600369A RID: 13978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600369A")]
			[Address(RVA = "0x25D70A0", Offset = "0x25D70A0", VA = "0x7BBCDD70A0")]
			public AESOption()
			{
			}

			// Token: 0x040049B5 RID: 18869
			[Token(Token = "0x40049B5")]
			[FieldOffset(Offset = "0x10")]
			public string Password;

			// Token: 0x040049B6 RID: 18870
			[Token(Token = "0x40049B6")]
			[FieldOffset(Offset = "0x18")]
			public string Salt;
		}
	}
}
