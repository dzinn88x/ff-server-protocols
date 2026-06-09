using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009DE RID: 2526
	[Token(Token = "0x20009DE")]
	[ProtoContract]
	public class VoucherDesc
	{
		// Token: 0x060026E8 RID: 9960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E8")]
		[Address(RVA = "0x24A1788", Offset = "0x24A1788", VA = "0x7BBCCA1788")]
		public VoucherDesc()
		{
		}

		// Token: 0x04002D9A RID: 11674
		[Token(Token = "0x4002D9A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B8DC", Offset = "0x111B8DC")]
		public uint item_id;

		// Token: 0x04002D9B RID: 11675
		[Token(Token = "0x4002D9B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B8F0", Offset = "0x111B8F0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111B8F0", Offset = "0x111B8F0")]
		public string name;

		// Token: 0x04002D9C RID: 11676
		[Token(Token = "0x4002D9C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B940", Offset = "0x111B940")]
		public EInventory.VoucherType voucher_type;

		// Token: 0x04002D9D RID: 11677
		[Token(Token = "0x4002D9D")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B954", Offset = "0x111B954")]
		public EInventory.ItemType deduct_item_type;

		// Token: 0x04002D9E RID: 11678
		[Token(Token = "0x4002D9E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B968", Offset = "0x111B968")]
		public uint deduct_item_id;

		// Token: 0x04002D9F RID: 11679
		[Token(Token = "0x4002D9F")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B97C", Offset = "0x111B97C")]
		public uint max_mount;

		// Token: 0x04002DA0 RID: 11680
		[Token(Token = "0x4002DA0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B990", Offset = "0x111B990")]
		public uint deduct_mount;
	}
}
