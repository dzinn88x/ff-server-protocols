using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008A6 RID: 2214
	[Token(Token = "0x20008A6")]
	[ProtoContract]
	public class CSGetGiftStoreRes
	{
		// Token: 0x060025B4 RID: 9652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B4")]
		[Address(RVA = "0x21B4054", Offset = "0x21B4054", VA = "0x7BBC9B4054")]
		public CSGetGiftStoreRes()
		{
		}

		// Token: 0x040029BB RID: 10683
		[Token(Token = "0x40029BB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115C70", Offset = "0x1115C70")]
		public uint store_id;

		// Token: 0x040029BC RID: 10684
		[Token(Token = "0x40029BC")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115C84", Offset = "0x1115C84")]
		public uint open_time;

		// Token: 0x040029BD RID: 10685
		[Token(Token = "0x40029BD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115C98", Offset = "0x1115C98")]
		public uint close_time;

		// Token: 0x040029BE RID: 10686
		[Token(Token = "0x40029BE")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115CAC", Offset = "0x1115CAC")]
		public bool is_time_show;

		// Token: 0x040029BF RID: 10687
		[Token(Token = "0x40029BF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115CC0", Offset = "0x1115CC0")]
		public uint giver_level;

		// Token: 0x040029C0 RID: 10688
		[Token(Token = "0x40029C0")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115CD4", Offset = "0x1115CD4")]
		public uint receiver_level;

		// Token: 0x040029C1 RID: 10689
		[Token(Token = "0x40029C1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115CE8", Offset = "0x1115CE8")]
		public uint gift_time_limited;

		// Token: 0x040029C2 RID: 10690
		[Token(Token = "0x40029C2")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115CFC", Offset = "0x1115CFC")]
		public uint gift_num_limited;
	}
}
