using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009A3 RID: 2467
	[Token(Token = "0x20009A3")]
	[ProtoContract]
	public class TriggeredEvent
	{
		// Token: 0x060026B1 RID: 9905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B1")]
		[Address(RVA = "0x24A13B4", Offset = "0x24A13B4", VA = "0x7BBCCA13B4")]
		public TriggeredEvent()
		{
		}

		// Token: 0x04002C8A RID: 11402
		[Token(Token = "0x4002C8A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A39C", Offset = "0x111A39C")]
		public EMiniGame.MonopolyNodeType type;

		// Token: 0x04002C8B RID: 11403
		[Token(Token = "0x4002C8B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A3B0", Offset = "0x111A3B0")]
		public uint triggered_index;
	}
}
