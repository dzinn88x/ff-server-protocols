using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005D8 RID: 1496
	[Token(Token = "0x20005D8")]
	[ProtoContract]
	public class ExchangeChangeData
	{
		// Token: 0x06002358 RID: 9048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002358")]
		[Address(RVA = "0x21B9CE4", Offset = "0x21B9CE4", VA = "0x7BBC9B9CE4")]
		public ExchangeChangeData()
		{
		}

		// Token: 0x04001DAD RID: 7597
		[Token(Token = "0x4001DAD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110526C", Offset = "0x110526C")]
		public ulong trans_id;

		// Token: 0x04001DAE RID: 7598
		[Token(Token = "0x4001DAE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105280", Offset = "0x1105280")]
		public List<Item> add_item_list;

		// Token: 0x04001DAF RID: 7599
		[Token(Token = "0x4001DAF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105294", Offset = "0x1105294")]
		public List<Item> del_item_list;

		// Token: 0x04001DB0 RID: 7600
		[Token(Token = "0x4001DB0")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11052A8", Offset = "0x11052A8")]
		public int coins_delta;

		// Token: 0x04001DB1 RID: 7601
		[Token(Token = "0x4001DB1")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11052BC", Offset = "0x11052BC")]
		public int gems_delta;

		// Token: 0x04001DB2 RID: 7602
		[Token(Token = "0x4001DB2")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11052D0", Offset = "0x11052D0")]
		public int gop_gems_delta;

		// Token: 0x04001DB3 RID: 7603
		[Token(Token = "0x4001DB3")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11052E4", Offset = "0x11052E4")]
		public EInventory.TransReason reason;

		// Token: 0x04001DB4 RID: 7604
		[Token(Token = "0x4001DB4")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11052F8", Offset = "0x11052F8")]
		public uint sub_reason;

		// Token: 0x04001DB5 RID: 7605
		[Token(Token = "0x4001DB5")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110530C", Offset = "0x110530C")]
		public uint gop_gems;

		// Token: 0x04001DB6 RID: 7606
		[Token(Token = "0x4001DB6")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105320", Offset = "0x1105320")]
		public ulong gop_total_topup;

		// Token: 0x04001DB7 RID: 7607
		[Token(Token = "0x4001DB7")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105334", Offset = "0x1105334")]
		public ulong gop_total_free;

		// Token: 0x04001DB8 RID: 7608
		[Token(Token = "0x4001DB8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105348", Offset = "0x1105348")]
		public List<ExchangedAward> exchangeAward;

		// Token: 0x04001DB9 RID: 7609
		[Token(Token = "0x4001DB9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110535C", Offset = "0x110535C")]
		public bool check_bundle;
	}
}
