using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000790 RID: 1936
	[Token(Token = "0x2000790")]
	[ProtoContract]
	public class CSRoleDebrisPurchaseReq
	{
		// Token: 0x0600249F RID: 9375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249F")]
		[Address(RVA = "0x21B74F8", Offset = "0x21B74F8", VA = "0x7BBC9B74F8")]
		public CSRoleDebrisPurchaseReq()
		{
		}

		// Token: 0x0400259B RID: 9627
		[Token(Token = "0x400259B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E344", Offset = "0x110E344")]
		public uint debris_id;

		// Token: 0x0400259C RID: 9628
		[Token(Token = "0x400259C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E358", Offset = "0x110E358")]
		public uint purchase_count;

		// Token: 0x0400259D RID: 9629
		[Token(Token = "0x400259D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E36C", Offset = "0x110E36C")]
		public uint cnt;

		// Token: 0x0400259E RID: 9630
		[Token(Token = "0x400259E")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E380", Offset = "0x110E380")]
		public EInventory.CurrencyType currency_type;

		// Token: 0x0400259F RID: 9631
		[Token(Token = "0x400259F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E394", Offset = "0x110E394")]
		public uint price;

		// Token: 0x040025A0 RID: 9632
		[Token(Token = "0x40025A0")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E3A8", Offset = "0x110E3A8")]
		public uint voucher_id;
	}
}
