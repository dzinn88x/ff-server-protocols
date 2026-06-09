using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008B2 RID: 2226
	[Token(Token = "0x20008B2")]
	[ProtoContract]
	public class ClientGiftRankDesc
	{
		// Token: 0x060025C0 RID: 9664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C0")]
		[Address(RVA = "0x21B8CC4", Offset = "0x21B8CC4", VA = "0x7BBC9B8CC4")]
		public ClientGiftRankDesc()
		{
		}

		// Token: 0x040029EE RID: 10734
		[Token(Token = "0x40029EE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11161E8", Offset = "0x11161E8")]
		public uint rank_id;

		// Token: 0x040029EF RID: 10735
		[Token(Token = "0x40029EF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11161FC", Offset = "0x11161FC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11161FC", Offset = "0x11161FC")]
		public string rank_name;

		// Token: 0x040029F0 RID: 10736
		[Token(Token = "0x40029F0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111624C", Offset = "0x111624C")]
		public long open_time;

		// Token: 0x040029F1 RID: 10737
		[Token(Token = "0x40029F1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116260", Offset = "0x1116260")]
		public long close_time;

		// Token: 0x040029F2 RID: 10738
		[Token(Token = "0x40029F2")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116274", Offset = "0x1116274")]
		public bool is_time_show;

		// Token: 0x040029F3 RID: 10739
		[Token(Token = "0x40029F3")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116288", Offset = "0x1116288")]
		public uint giver_item_id;

		// Token: 0x040029F4 RID: 10740
		[Token(Token = "0x40029F4")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111629C", Offset = "0x111629C")]
		public uint receiver_item_id;

		// Token: 0x040029F5 RID: 10741
		[Token(Token = "0x40029F5")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11162B0", Offset = "0x11162B0")]
		public uint gift_ratio;
	}
}
