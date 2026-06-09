using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B59 RID: 2905
	[Token(Token = "0x2000B59")]
	[ProtoContract]
	public enum EPProcess_Status
	{
		// Token: 0x0400374C RID: 14156
		[Token(Token = "0x400374C")]
		PS_ONGOING,
		// Token: 0x0400374D RID: 14157
		[Token(Token = "0x400374D")]
		PS_REACHED,
		// Token: 0x0400374E RID: 14158
		[Token(Token = "0x400374E")]
		PS_CLAIMED
	}
}
