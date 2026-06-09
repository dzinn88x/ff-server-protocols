using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009C6 RID: 2502
	[Token(Token = "0x20009C6")]
	[ProtoContract]
	public enum EPTarget_Status
	{
		// Token: 0x04002CCF RID: 11471
		[Token(Token = "0x4002CCF")]
		TS_ONGOING,
		// Token: 0x04002CD0 RID: 11472
		[Token(Token = "0x4002CD0")]
		TS_REACHED,
		// Token: 0x04002CD1 RID: 11473
		[Token(Token = "0x4002CD1")]
		TS_CLAIMED
	}
}
