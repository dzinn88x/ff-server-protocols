using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AD0 RID: 2768
	[Token(Token = "0x2000AD0")]
	[ProtoContract]
	public class AwardFromCard
	{
		// Token: 0x060027D8 RID: 10200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D8")]
		[Address(RVA = "0x21AF6C0", Offset = "0x21AF6C0", VA = "0x7BBC9AF6C0")]
		public AwardFromCard()
		{
		}

		// Token: 0x04003401 RID: 13313
		[Token(Token = "0x4003401")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112795C", Offset = "0x112795C")]
		public uint weight;

		// Token: 0x04003402 RID: 13314
		[Token(Token = "0x4003402")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127970", Offset = "0x1127970")]
		public EInventory.AwardType award_type;

		// Token: 0x04003403 RID: 13315
		[Token(Token = "0x4003403")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127984", Offset = "0x1127984")]
		public uint award_id;

		// Token: 0x04003404 RID: 13316
		[Token(Token = "0x4003404")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127998", Offset = "0x1127998")]
		public uint award_num;

		// Token: 0x04003405 RID: 13317
		[Token(Token = "0x4003405")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11279AC", Offset = "0x11279AC")]
		public uint award_level;

		// Token: 0x04003406 RID: 13318
		[Token(Token = "0x4003406")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11279C0", Offset = "0x11279C0")]
		public uint from_card_rank;
	}
}
