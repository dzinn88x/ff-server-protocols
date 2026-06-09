using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008AC RID: 2220
	[Token(Token = "0x20008AC")]
	[ProtoContract]
	public class CSExchangeStorePurchaseReq
	{
		// Token: 0x060025BA RID: 9658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BA")]
		[Address(RVA = "0x21B1270", Offset = "0x21B1270", VA = "0x7BBC9B1270")]
		public CSExchangeStorePurchaseReq()
		{
		}

		// Token: 0x040029D2 RID: 10706
		[Token(Token = "0x40029D2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115F04", Offset = "0x1115F04")]
		public uint store_id;

		// Token: 0x040029D3 RID: 10707
		[Token(Token = "0x40029D3")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115F18", Offset = "0x1115F18")]
		public uint commodity_id;

		// Token: 0x040029D4 RID: 10708
		[Token(Token = "0x40029D4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115F2C", Offset = "0x1115F2C")]
		public ulong trans_id;

		// Token: 0x040029D5 RID: 10709
		[Token(Token = "0x40029D5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115F40", Offset = "0x1115F40")]
		public uint cnt;

		// Token: 0x040029D6 RID: 10710
		[Token(Token = "0x40029D6")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115F54", Offset = "0x1115F54")]
		public uint currency_id;

		// Token: 0x040029D7 RID: 10711
		[Token(Token = "0x40029D7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115F68", Offset = "0x1115F68")]
		public uint currency_price;

		// Token: 0x040029D8 RID: 10712
		[Token(Token = "0x40029D8")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115F7C", Offset = "0x1115F7C")]
		public uint gems_cost;

		// Token: 0x040029D9 RID: 10713
		[Token(Token = "0x40029D9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115F90", Offset = "0x1115F90")]
		public uint entry_from;
	}
}
