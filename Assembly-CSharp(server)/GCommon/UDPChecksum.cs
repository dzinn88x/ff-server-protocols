using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FAA RID: 4010
	[Token(Token = "0x2000FAA")]
	internal static class UDPChecksum
	{
		// Token: 0x06003A5F RID: 14943 RVA: 0x000120A8 File Offset: 0x000102A8
		[Token(Token = "0x6003A5F")]
		[Address(RVA = "0x2017E90", Offset = "0x2017E90", VA = "0x7BBC817E90")]
		public static byte CRC7(byte crcIn, byte v)
		{
			return 0;
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x000120C0 File Offset: 0x000102C0
		[Token(Token = "0x6003A60")]
		[Address(RVA = "0x2017F44", Offset = "0x2017F44", VA = "0x7BBC817F44")]
		public static byte CRC7(byte crcIn, ushort v)
		{
			return 0;
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x000120D8 File Offset: 0x000102D8
		[Token(Token = "0x6003A61")]
		[Address(RVA = "0x2017FC0", Offset = "0x2017FC0", VA = "0x7BBC817FC0")]
		public static byte CRC7(byte crcIn, byte[] buf)
		{
			return 0;
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x000120F0 File Offset: 0x000102F0
		[Token(Token = "0x6003A62")]
		[Address(RVA = "0x2018048", Offset = "0x2018048", VA = "0x7BBC818048")]
		public static byte CRC7(byte crcIn, byte[] buf, int Count, int offset = 0)
		{
			return 0;
		}

		// Token: 0x04004BFF RID: 19455
		[Token(Token = "0x4004BFF")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] crc7tab;
	}
}
