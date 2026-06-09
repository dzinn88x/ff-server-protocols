using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FAD RID: 4013
	[Token(Token = "0x2000FAD")]
	internal class UPDMessagePoolManager
	{
		// Token: 0x06003A7B RID: 14971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A7B")]
		[Address(RVA = "0x223D398", Offset = "0x223D398", VA = "0x7BBCA3D398")]
		public static void ClearPool()
		{
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A7C")]
		[Address(RVA = "0x223D540", Offset = "0x223D540", VA = "0x7BBCA3D540")]
		public static void Register(UPDMessagePoolInterface pool)
		{
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A7D")]
		[Address(RVA = "0x223D5CC", Offset = "0x223D5CC", VA = "0x7BBCA3D5CC")]
		public UPDMessagePoolManager()
		{
		}

		// Token: 0x04004C03 RID: 19459
		[Token(Token = "0x4004C03")]
		[FieldOffset(Offset = "0x0")]
		private static List<UPDMessagePoolInterface> Pools;
	}
}
