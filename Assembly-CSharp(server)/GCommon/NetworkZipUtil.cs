using System;
using ICSharpCode.SharpZipLib.GZip;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F99 RID: 3993
	[Token(Token = "0x2000F99")]
	internal static class NetworkZipUtil
	{
		// Token: 0x06003A29 RID: 14889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A29")]
		[Address(RVA = "0x2468884", Offset = "0x2468884", VA = "0x7BBCC68884")]
		public static void ZipXORHeader(byte[] data, int dataLen, byte[] secretKey)
		{
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x00012000 File Offset: 0x00010200
		[Token(Token = "0x6003A2A")]
		[Address(RVA = "0x2468950", Offset = "0x2468950", VA = "0x7BBCC68950")]
		public static long Unzip(GZipInputStream gzipStream, byte[] data, int dataLen, byte[] secretKey, byte[] outputData, byte[] tmpBuffer)
		{
			return 0L;
		}
	}
}
