using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AB5 RID: 2741
	[Token(Token = "0x2000AB5")]
	[ProtoContract]
	public class MysteryShopABtestDesc
	{
		// Token: 0x060027BF RID: 10175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BF")]
		[Address(RVA = "0x249E718", Offset = "0x249E718", VA = "0x7BBCC9E718")]
		public MysteryShopABtestDesc()
		{
		}

		// Token: 0x04003385 RID: 13189
		[Token(Token = "0x4003385")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126E58", Offset = "0x1126E58")]
		public uint mystery_shop_id;

		// Token: 0x04003386 RID: 13190
		[Token(Token = "0x4003386")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126E6C", Offset = "0x1126E6C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126E6C", Offset = "0x1126E6C")]
		public string @class;

		// Token: 0x04003387 RID: 13191
		[Token(Token = "0x4003387")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126EBC", Offset = "0x1126EBC")]
		public uint original_melon_pi;

		// Token: 0x04003388 RID: 13192
		[Token(Token = "0x4003388")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126ED0", Offset = "0x1126ED0")]
		public uint abtest_melon_pi;
	}
}
