using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200202D RID: 8237
	[Token(Token = "0x200202D")]
	public class SuitOpenInfo
	{
		// Token: 0x0600B7AC RID: 47020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7AC")]
		[Address(RVA = "0x1B41A5C", Offset = "0x1B41A5C", VA = "0x7BBC341A5C")]
		public SuitOpenInfo()
		{
		}

		// Token: 0x0400B9B5 RID: 47541
		[Token(Token = "0x400B9B5")]
		[FieldOffset(Offset = "0x10")]
		public uint SuitId;

		// Token: 0x0400B9B6 RID: 47542
		[Token(Token = "0x400B9B6")]
		[FieldOffset(Offset = "0x14")]
		public bool IsOpenning;
	}
}
