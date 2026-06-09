using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009C9 RID: 2505
	[Token(Token = "0x20009C9")]
	[ProtoContract]
	public class ItemDesc
	{
		// Token: 0x060026D3 RID: 9939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x21BB70C", Offset = "0x21BB70C", VA = "0x7BBC9BB70C")]
		public ItemDesc()
		{
		}

		// Token: 0x04002D21 RID: 11553
		[Token(Token = "0x4002D21")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AAF4", Offset = "0x111AAF4")]
		public uint id;

		// Token: 0x04002D22 RID: 11554
		[Token(Token = "0x4002D22")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AB08", Offset = "0x111AB08")]
		public EInventory.ItemType type;

		// Token: 0x04002D23 RID: 11555
		[Token(Token = "0x4002D23")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AB1C", Offset = "0x111AB1C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111AB1C", Offset = "0x111AB1C")]
		public string name;

		// Token: 0x04002D24 RID: 11556
		[Token(Token = "0x4002D24")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AB6C", Offset = "0x111AB6C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111AB6C", Offset = "0x111AB6C")]
		public string desc;

		// Token: 0x04002D25 RID: 11557
		[Token(Token = "0x4002D25")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ABBC", Offset = "0x111ABBC")]
		public uint is_unique;

		// Token: 0x04002D26 RID: 11558
		[Token(Token = "0x4002D26")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ABD0", Offset = "0x111ABD0")]
		public EInventory.GenderType gender;

		// Token: 0x04002D27 RID: 11559
		[Token(Token = "0x4002D27")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ABE4", Offset = "0x111ABE4")]
		public EInventory.CollectionType collection_type;

		// Token: 0x04002D28 RID: 11560
		[Token(Token = "0x4002D28")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ABF8", Offset = "0x111ABF8")]
		public uint Rare;

		// Token: 0x04002D29 RID: 11561
		[Token(Token = "0x4002D29")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AC0C", Offset = "0x111AC0C")]
		public EInventory.AwardType return_type;

		// Token: 0x04002D2A RID: 11562
		[Token(Token = "0x4002D2A")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AC20", Offset = "0x111AC20")]
		public uint return_id;

		// Token: 0x04002D2B RID: 11563
		[Token(Token = "0x4002D2B")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AC34", Offset = "0x111AC34")]
		public uint return_num;

		// Token: 0x04002D2C RID: 11564
		[Token(Token = "0x4002D2C")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AC48", Offset = "0x111AC48")]
		public EInventory.ItemSubType sub_type;

		// Token: 0x04002D2D RID: 11565
		[Token(Token = "0x4002D2D")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AC5C", Offset = "0x111AC5C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111AC5C", Offset = "0x111AC5C")]
		public string end_time;

		// Token: 0x04002D2E RID: 11566
		[Token(Token = "0x4002D2E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ACAC", Offset = "0x111ACAC")]
		public bool test_data;
	}
}
