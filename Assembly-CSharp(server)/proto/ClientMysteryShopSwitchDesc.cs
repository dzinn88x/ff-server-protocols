using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008CC RID: 2252
	[Token(Token = "0x20008CC")]
	[ProtoContract]
	public class ClientMysteryShopSwitchDesc
	{
		// Token: 0x060025DA RID: 9690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x21B8D20", Offset = "0x21B8D20", VA = "0x7BBC9B8D20")]
		public ClientMysteryShopSwitchDesc()
		{
		}

		// Token: 0x04002A41 RID: 10817
		[Token(Token = "0x4002A41")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116ABC", Offset = "0x1116ABC")]
		public uint pool_id;

		// Token: 0x04002A42 RID: 10818
		[Token(Token = "0x4002A42")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116AD0", Offset = "0x1116AD0")]
		public uint unlock_amount;

		// Token: 0x04002A43 RID: 10819
		[Token(Token = "0x4002A43")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116AE4", Offset = "0x1116AE4")]
		public uint switch_amount;

		// Token: 0x04002A44 RID: 10820
		[Token(Token = "0x4002A44")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116AF8", Offset = "0x1116AF8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1116AF8", Offset = "0x1116AF8")]
		public string shop_cdn;

		// Token: 0x04002A45 RID: 10821
		[Token(Token = "0x4002A45")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1116B48", Offset = "0x1116B48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116B48", Offset = "0x1116B48")]
		public string switch_cdn;

		// Token: 0x04002A46 RID: 10822
		[Token(Token = "0x4002A46")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116B98", Offset = "0x1116B98")]
		public uint cost_gems;

		// Token: 0x04002A47 RID: 10823
		[Token(Token = "0x4002A47")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1116BAC", Offset = "0x1116BAC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116BAC", Offset = "0x1116BAC")]
		public string pool_center_cdn;
	}
}
