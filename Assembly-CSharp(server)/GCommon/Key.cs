using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FC4 RID: 4036
	[Token(Token = "0x2000FC4")]
	public class Key
	{
		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06003AF9 RID: 15097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F1")]
		public static byte[] InitVectorKeys
		{
			[Token(Token = "0x6003AF9")]
			[Address(RVA = "0x21201B8", Offset = "0x21201B8", VA = "0x7BBC9201B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06003AFA RID: 15098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F2")]
		public static byte[] Keys
		{
			[Token(Token = "0x6003AFA")]
			[Address(RVA = "0x2120220", Offset = "0x2120220", VA = "0x7BBC920220")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFB")]
		[Address(RVA = "0x2120948", Offset = "0x2120948", VA = "0x7BBC920948")]
		public Key()
		{
		}

		// Token: 0x04004C88 RID: 19592
		[Token(Token = "0x4004C88")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] m_InitVectorKeys;

		// Token: 0x04004C89 RID: 19593
		[Token(Token = "0x4004C89")]
		[FieldOffset(Offset = "0x8")]
		private static string m_Keys;
	}
}
