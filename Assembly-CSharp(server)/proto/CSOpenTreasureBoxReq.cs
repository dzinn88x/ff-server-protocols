using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007A0 RID: 1952
	[Token(Token = "0x20007A0")]
	[ProtoContract]
	public class CSOpenTreasureBoxReq
	{
		// Token: 0x060024AF RID: 9391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AF")]
		[Address(RVA = "0x21B6D10", Offset = "0x21B6D10", VA = "0x7BBC9B6D10")]
		public CSOpenTreasureBoxReq()
		{
		}

		// Token: 0x040025B4 RID: 9652
		[Token(Token = "0x40025B4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E588", Offset = "0x110E588")]
		public uint treasure_id;

		// Token: 0x040025B5 RID: 9653
		[Token(Token = "0x40025B5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E59C", Offset = "0x110E59C")]
		public ulong trans_id;

		// Token: 0x040025B6 RID: 9654
		[Token(Token = "0x40025B6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E5B0", Offset = "0x110E5B0")]
		public ETreasureBox.BoxType box_type;

		// Token: 0x040025B7 RID: 9655
		[Token(Token = "0x40025B7")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E5C4", Offset = "0x110E5C4")]
		public bool can_get_unique;

		// Token: 0x040025B8 RID: 9656
		[Token(Token = "0x40025B8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E5D8", Offset = "0x110E5D8")]
		public uint item_cnt;

		// Token: 0x040025B9 RID: 9657
		[Token(Token = "0x40025B9")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E5EC", Offset = "0x110E5EC")]
		public bool is_crate_treasure;

		// Token: 0x040025BA RID: 9658
		[Token(Token = "0x40025BA")]
		[FieldOffset(Offset = "0x2D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E600", Offset = "0x110E600")]
		public bool is_auto_open;
	}
}
