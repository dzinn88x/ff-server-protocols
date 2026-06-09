using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A9E RID: 2718
	[Token(Token = "0x2000A9E")]
	[ProtoContract]
	public class GiftRewardDesc
	{
		// Token: 0x060027A8 RID: 10152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A8")]
		[Address(RVA = "0x21BACA8", Offset = "0x21BACA8", VA = "0x7BBC9BACA8")]
		public GiftRewardDesc()
		{
		}

		// Token: 0x040032B8 RID: 12984
		[Token(Token = "0x40032B8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125364", Offset = "0x1125364")]
		public EStore.GiftRankType rank_tab_id;

		// Token: 0x040032B9 RID: 12985
		[Token(Token = "0x40032B9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125378", Offset = "0x1125378")]
		public uint gift_item_num;

		// Token: 0x040032BA RID: 12986
		[Token(Token = "0x40032BA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112538C", Offset = "0x112538C")]
		public EInventory.AwardType reward_item_type;

		// Token: 0x040032BB RID: 12987
		[Token(Token = "0x40032BB")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11253A0", Offset = "0x11253A0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11253A0", Offset = "0x11253A0")]
		public string reward_item_name;

		// Token: 0x040032BC RID: 12988
		[Token(Token = "0x40032BC")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11253F0", Offset = "0x11253F0")]
		public uint reward_item_id;

		// Token: 0x040032BD RID: 12989
		[Token(Token = "0x40032BD")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125404", Offset = "0x1125404")]
		public uint reward_item_num;

		// Token: 0x040032BE RID: 12990
		[Token(Token = "0x40032BE")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125418", Offset = "0x1125418")]
		public uint award_time;
	}
}
