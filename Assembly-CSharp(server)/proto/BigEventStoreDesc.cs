using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B0A RID: 2826
	[Token(Token = "0x2000B0A")]
	[ProtoContract]
	public class BigEventStoreDesc
	{
		// Token: 0x06002812 RID: 10258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002812")]
		[Address(RVA = "0x21AF94C", Offset = "0x21AF94C", VA = "0x7BBC9AF94C")]
		public BigEventStoreDesc()
		{
		}

		// Token: 0x04003555 RID: 13653
		[Token(Token = "0x4003555")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A5F8", Offset = "0x112A5F8")]
		public uint store_id;

		// Token: 0x04003556 RID: 13654
		[Token(Token = "0x4003556")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A60C", Offset = "0x112A60C")]
		public ELimitedEvent.EventID event_id;

		// Token: 0x04003557 RID: 13655
		[Token(Token = "0x4003557")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A620", Offset = "0x112A620")]
		public ELimitedEvent.StoreType store_type;

		// Token: 0x04003558 RID: 13656
		[Token(Token = "0x4003558")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A634", Offset = "0x112A634")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A634", Offset = "0x112A634")]
		public string start_time;

		// Token: 0x04003559 RID: 13657
		[Token(Token = "0x4003559")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A684", Offset = "0x112A684")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A684", Offset = "0x112A684")]
		public string end_time;

		// Token: 0x0400355A RID: 13658
		[Token(Token = "0x400355A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A6D4", Offset = "0x112A6D4")]
		public uint start_timestamp;

		// Token: 0x0400355B RID: 13659
		[Token(Token = "0x400355B")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A6E8", Offset = "0x112A6E8")]
		public uint end_timestamp;

		// Token: 0x0400355C RID: 13660
		[Token(Token = "0x400355C")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A6FC", Offset = "0x112A6FC")]
		public uint condition;

		// Token: 0x0400355D RID: 13661
		[Token(Token = "0x400355D")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A710", Offset = "0x112A710")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A710", Offset = "0x112A710")]
		public string cdn_url;
	}
}
