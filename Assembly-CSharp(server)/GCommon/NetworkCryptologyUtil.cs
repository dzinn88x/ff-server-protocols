using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F81 RID: 3969
	[Token(Token = "0x2000F81")]
	public static class NetworkCryptologyUtil
	{
		// Token: 0x060039D4 RID: 14804 RVA: 0x00011EC8 File Offset: 0x000100C8
		[Token(Token = "0x60039D4")]
		[Address(RVA = "0x245E3A0", Offset = "0x245E3A0", VA = "0x7BBCC5E3A0")]
		public static bool TeaDecrypt(TeaDecTempBuffer decTempBuffer, byte[] pInBuf, int nInBufLen, byte[] pKey, byte[] pOutBuf, ref int pOutBufLen)
		{
			return default(bool);
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x00011EE0 File Offset: 0x000100E0
		[Token(Token = "0x60039D5")]
		[Address(RVA = "0x245EDDC", Offset = "0x245EDDC", VA = "0x7BBCC5EDDC")]
		private static int rand()
		{
			return 0;
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x00011EF8 File Offset: 0x000100F8
		[Token(Token = "0x60039D6")]
		[Address(RVA = "0x245EDE4", Offset = "0x245EDE4", VA = "0x7BBCC5EDE4")]
		public static int TeaEncrypt_Len(int nInBufLen)
		{
			return 0;
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D7")]
		[Address(RVA = "0x245EE80", Offset = "0x245EE80", VA = "0x7BBCC5EE80")]
		public static void TeaEncrypt(TeaEncTempBuffer encTempBuffer, byte[] pInBuf, int nInBufLen, byte[] pKey, byte[] pOutBuf, ref int pOutBufLen)
		{
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D8")]
		[Address(RVA = "0x245FAF4", Offset = "0x245FAF4", VA = "0x7BBCC5FAF4")]
		private static string bytesToString(byte[] p)
		{
			return null;
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D9")]
		[Address(RVA = "0x245F86C", Offset = "0x245F86C", VA = "0x7BBCC5F86C")]
		private static void TeaEncryptECB(TeaEncTempBuffer encTempBuffer, byte[] pInBuf, int inBufPos, byte[] pKey, byte[] pOutBuf, int outBufIndex)
		{
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DA")]
		[Address(RVA = "0x245EB24", Offset = "0x245EB24", VA = "0x7BBCC5EB24")]
		private static void TeaDecryptECB(TeaDecTempBuffer decTempBuffer, byte[] pInBuf, int inBufIndex, byte[] pKey, byte[] pOutBuf, int outBufIndex)
		{
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DB")]
		[Address(RVA = "0x245FBDC", Offset = "0x245FBDC", VA = "0x7BBCC5FBDC")]
		private static void IntToBytes(int value, byte[] array, int offset)
		{
		}

		// Token: 0x04004B5B RID: 19291
		[Token(Token = "0x4004B5B")]
		[FieldOffset(Offset = "0x0")]
		public static byte[] TestKey;

		// Token: 0x04004B5C RID: 19292
		[Token(Token = "0x4004B5C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int SALT_LEN;

		// Token: 0x04004B5D RID: 19293
		[Token(Token = "0x4004B5D")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int ZERO_LEN;

		// Token: 0x04004B5E RID: 19294
		[Token(Token = "0x4004B5E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly uint DELTA;

		// Token: 0x04004B5F RID: 19295
		[Token(Token = "0x4004B5F")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int ROUNDS;

		// Token: 0x04004B60 RID: 19296
		[Token(Token = "0x4004B60")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int LOG_ROUNDS;
	}
}
