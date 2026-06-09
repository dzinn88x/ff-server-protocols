using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008B6 RID: 2230
	[Token(Token = "0x20008B6")]
	[ProtoContract]
	public class CSGetGiftRankRewardReq
	{
		// Token: 0x060025C4 RID: 9668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C4")]
		[Address(RVA = "0x21B3FD0", Offset = "0x21B3FD0", VA = "0x7BBC9B3FD0")]
		public CSGetGiftRankRewardReq()
		{
		}

		// Token: 0x040029FB RID: 10747
		[Token(Token = "0x40029FB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116378", Offset = "0x1116378")]
		public uint rank_id;

		// Token: 0x040029FC RID: 10748
		[Token(Token = "0x40029FC")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111638C", Offset = "0x111638C")]
		public EStore.GiftRankType gift_rank_type;

		// Token: 0x040029FD RID: 10749
		[Token(Token = "0x40029FD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11163A0", Offset = "0x11163A0")]
		public uint gift_item_num;
	}
}
