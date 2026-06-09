using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002037 RID: 8247
	[Token(Token = "0x2002037")]
	public class RuleMapping
	{
		// Token: 0x0600B7D8 RID: 47064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7D8")]
		[Address(RVA = "0x1B32018", Offset = "0x1B32018", VA = "0x7BBC332018")]
		public RuleMapping(string tabKey, string contentKey)
		{
		}

		// Token: 0x0400B9E9 RID: 47593
		[Token(Token = "0x400B9E9")]
		[FieldOffset(Offset = "0x10")]
		public string Tab;

		// Token: 0x0400B9EA RID: 47594
		[Token(Token = "0x400B9EA")]
		[FieldOffset(Offset = "0x18")]
		public string Content;

		// Token: 0x0400B9EB RID: 47595
		[Token(Token = "0x400B9EB")]
		[FieldOffset(Offset = "0x20")]
		public bool DoLoced;
	}
}
