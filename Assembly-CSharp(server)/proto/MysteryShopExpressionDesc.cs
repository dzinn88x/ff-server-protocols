using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AB2 RID: 2738
	[Token(Token = "0x2000AB2")]
	[ProtoContract]
	public class MysteryShopExpressionDesc
	{
		// Token: 0x060027BC RID: 10172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BC")]
		[Address(RVA = "0x249E834", Offset = "0x249E834", VA = "0x7BBCC9E834")]
		public MysteryShopExpressionDesc()
		{
		}

		// Token: 0x04003375 RID: 13173
		[Token(Token = "0x4003375")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126BEC", Offset = "0x1126BEC")]
		public uint mystery_shop_id;

		// Token: 0x04003376 RID: 13174
		[Token(Token = "0x4003376")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126C00", Offset = "0x1126C00")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126C00", Offset = "0x1126C00")]
		public string discount_cdn;

		// Token: 0x04003377 RID: 13175
		[Token(Token = "0x4003377")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126C50", Offset = "0x1126C50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126C50", Offset = "0x1126C50")]
		public string shop_enter_icon;

		// Token: 0x04003378 RID: 13176
		[Token(Token = "0x4003378")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126CA0", Offset = "0x1126CA0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126CA0", Offset = "0x1126CA0")]
		public string web_link;

		// Token: 0x04003379 RID: 13177
		[Token(Token = "0x4003379")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126CF0", Offset = "0x1126CF0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126CF0", Offset = "0x1126CF0")]
		public string web_link_cdn;

		// Token: 0x0400337A RID: 13178
		[Token(Token = "0x400337A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126D40", Offset = "0x1126D40")]
		public long start_timestamp;

		// Token: 0x0400337B RID: 13179
		[Token(Token = "0x400337B")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126D54", Offset = "0x1126D54")]
		public long end_timestamp;

		// Token: 0x0400337C RID: 13180
		[Token(Token = "0x400337C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126D68", Offset = "0x1126D68")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126D68", Offset = "0x1126D68")]
		public string language;
	}
}
