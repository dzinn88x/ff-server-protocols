using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FC5 RID: 4037
	[Token(Token = "0x2000FC5")]
	public class ResDecryption
	{
		// Token: 0x06003AFD RID: 15101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AFD")]
		[Address(RVA = "0x295F5FC", Offset = "0x295F5FC", VA = "0x7BBD15F5FC")]
		public static string GetFileHash(string filePath)
		{
			return null;
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFE")]
		[Address(RVA = "0x295F924", Offset = "0x295F924", VA = "0x7BBD15F924")]
		public static void HashBlock(SHA1CryptoServiceProvider worker, byte[] data, int offset, int size)
		{
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AFF")]
		[Address(RVA = "0x295FA8C", Offset = "0x295FA8C", VA = "0x7BBD15FA8C")]
		public static string HashFinalBlock(SHA1CryptoServiceProvider worker, byte[] data, int offset)
		{
			return null;
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B00")]
		[Address(RVA = "0x295FC44", Offset = "0x295FC44", VA = "0x7BBD15FC44")]
		public static string ComputeHash(SHA1CryptoServiceProvider worker, byte[] data, int offset = 0)
		{
			return null;
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B01")]
		[Address(RVA = "0x295FDE8", Offset = "0x295FDE8", VA = "0x7BBD15FDE8")]
		public static void Decryption(byte[] fileBytes, out byte[] decryptionBytes)
		{
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B02")]
		[Address(RVA = "0x29602C4", Offset = "0x29602C4", VA = "0x7BBD1602C4")]
		public static ICryptoTransform CreateDecryptor(out int blockSize)
		{
			return null;
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x00012540 File Offset: 0x00010740
		[Token(Token = "0x6003B03")]
		[Address(RVA = "0x29603B0", Offset = "0x29603B0", VA = "0x7BBD1603B0")]
		public static int Decryption(ICryptoTransform decryptor, int blockSize, byte[] fileBytes, ref byte[] decryptionBytes)
		{
			return 0;
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B04")]
		[Address(RVA = "0x296073C", Offset = "0x296073C", VA = "0x7BBD16073C")]
		public ResDecryption()
		{
		}

		// Token: 0x04004C8A RID: 19594
		[Token(Token = "0x4004C8A")]
		[FieldOffset(Offset = "0x0")]
		private static SHA1CryptoServiceProvider m_SHA1;
	}
}
