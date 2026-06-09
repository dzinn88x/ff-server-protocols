using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B1F RID: 2847
	[Token(Token = "0x2000B1F")]
	[ProtoContract]
	public class BigEventTokenTipsDesc
	{
		// Token: 0x06002827 RID: 10279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002827")]
		[Address(RVA = "0x21AF9AC", Offset = "0x21AF9AC", VA = "0x7BBC9AF9AC")]
		public BigEventTokenTipsDesc()
		{
		}

		// Token: 0x04003600 RID: 13824
		[Token(Token = "0x4003600")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BED0", Offset = "0x112BED0")]
		public uint id;

		// Token: 0x04003601 RID: 13825
		[Token(Token = "0x4003601")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BEE4", Offset = "0x112BEE4")]
		public uint token_id;

		// Token: 0x04003602 RID: 13826
		[Token(Token = "0x4003602")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112BEF8", Offset = "0x112BEF8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BEF8", Offset = "0x112BEF8")]
		public string way;

		// Token: 0x04003603 RID: 13827
		[Token(Token = "0x4003603")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BF48", Offset = "0x112BF48")]
		public uint go_pos;

		// Token: 0x04003604 RID: 13828
		[Token(Token = "0x4003604")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BF5C", Offset = "0x112BF5C")]
		public uint sub_go_pos;

		// Token: 0x04003605 RID: 13829
		[Token(Token = "0x4003605")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BF70", Offset = "0x112BF70")]
		public ELimitedEvent.EventID event_id;
	}
}
