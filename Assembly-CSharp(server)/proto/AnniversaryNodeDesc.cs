using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B0F RID: 2831
	[Token(Token = "0x2000B0F")]
	[ProtoContract]
	public class AnniversaryNodeDesc
	{
		// Token: 0x06002817 RID: 10263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002817")]
		[Address(RVA = "0x21AEFC0", Offset = "0x21AEFC0", VA = "0x7BBC9AEFC0")]
		public AnniversaryNodeDesc()
		{
		}

		// Token: 0x04003587 RID: 13703
		[Token(Token = "0x4003587")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112ADDC", Offset = "0x112ADDC")]
		public uint node_id;

		// Token: 0x04003588 RID: 13704
		[Token(Token = "0x4003588")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112ADF0", Offset = "0x112ADF0")]
		public ELimitedEvent.NodeStatus status;

		// Token: 0x04003589 RID: 13705
		[Token(Token = "0x4003589")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AE04", Offset = "0x112AE04")]
		public uint sub_node;

		// Token: 0x0400358A RID: 13706
		[Token(Token = "0x400358A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AE18", Offset = "0x112AE18")]
		public ulong unlock_amount;

		// Token: 0x0400358B RID: 13707
		[Token(Token = "0x400358B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AE2C", Offset = "0x112AE2C")]
		public ulong unlock_single;

		// Token: 0x0400358C RID: 13708
		[Token(Token = "0x400358C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AE40", Offset = "0x112AE40")]
		public List<AwardDesc> award_items;

		// Token: 0x0400358D RID: 13709
		[Token(Token = "0x400358D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AE54", Offset = "0x112AE54")]
		public uint node_type;
	}
}
