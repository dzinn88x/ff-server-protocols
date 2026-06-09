using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005D5 RID: 1493
	[Token(Token = "0x20005D5")]
	[ProtoContract]
	public class Item
	{
		// Token: 0x06002355 RID: 9045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002355")]
		[Address(RVA = "0x21BB6A0", Offset = "0x21BB6A0", VA = "0x7BBC9BB6A0")]
		public Item()
		{
		}

		// Token: 0x04001D98 RID: 7576
		[Token(Token = "0x4001D98")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11050C8", Offset = "0x11050C8")]
		public uint id;

		// Token: 0x04001D99 RID: 7577
		[Token(Token = "0x4001D99")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11050DC", Offset = "0x11050DC")]
		public uint cnt;

		// Token: 0x04001D9A RID: 7578
		[Token(Token = "0x4001D9A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11050F0", Offset = "0x11050F0")]
		public uint expire_time;

		// Token: 0x04001D9B RID: 7579
		[Token(Token = "0x4001D9B")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105104", Offset = "0x1105104")]
		public int left_use_times;

		// Token: 0x04001D9C RID: 7580
		[Token(Token = "0x4001D9C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105118", Offset = "0x1105118")]
		public uint history_owned_cnt;

		// Token: 0x04001D9D RID: 7581
		[Token(Token = "0x4001D9D")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110512C", Offset = "0x110512C")]
		public uint left_expire_time;

		// Token: 0x04001D9E RID: 7582
		[Token(Token = "0x4001D9E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105140", Offset = "0x1105140")]
		public EInventory.ItemStatus item_status;

		// Token: 0x04001D9F RID: 7583
		[Token(Token = "0x4001D9F")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105154", Offset = "0x1105154")]
		public EInventory.ItemType item_type;

		// Token: 0x04001DA0 RID: 7584
		[Token(Token = "0x4001DA0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105168", Offset = "0x1105168")]
		public EInventory.ItemSubType item_sub_type;

		// Token: 0x04001DA1 RID: 7585
		[Token(Token = "0x4001DA1")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110517C", Offset = "0x110517C")]
		public EInventory.InstallmentStatus installment_status;

		// Token: 0x04001DA2 RID: 7586
		[Token(Token = "0x4001DA2")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105190", Offset = "0x1105190")]
		public uint installment_term;

		// Token: 0x04001DA3 RID: 7587
		[Token(Token = "0x4001DA3")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11051A4", Offset = "0x11051A4")]
		public uint installment_create_time;

		// Token: 0x04001DA4 RID: 7588
		[Token(Token = "0x4001DA4")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11051B8", Offset = "0x11051B8")]
		public uint installment_next_pay_time;
	}
}
