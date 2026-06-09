using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002015 RID: 8213
	[Token(Token = "0x2002015")]
	public class ReserveMessageInfo
	{
		// Token: 0x0600B6F2 RID: 46834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6F2")]
		[Address(RVA = "0x175CFFC", Offset = "0x175CFFC", VA = "0x7BBBF5CFFC")]
		public ReserveMessageInfo()
		{
		}

		// Token: 0x0400B8DE RID: 47326
		[Token(Token = "0x400B8DE")]
		[FieldOffset(Offset = "0x10")]
		public string content;

		// Token: 0x0400B8DF RID: 47327
		[Token(Token = "0x400B8DF")]
		[FieldOffset(Offset = "0x18")]
		public bool isRequest;

		// Token: 0x0400B8E0 RID: 47328
		[Token(Token = "0x400B8E0")]
		[FieldOffset(Offset = "0x19")]
		public bool isAccepted;

		// Token: 0x0400B8E1 RID: 47329
		[Token(Token = "0x400B8E1")]
		[FieldOffset(Offset = "0x1C")]
		public int reason;
	}
}
