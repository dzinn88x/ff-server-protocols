using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ACB RID: 2763
	[Token(Token = "0x2000ACB")]
	[ProtoContract]
	public class PVECardPriceDesc
	{
		// Token: 0x060027D3 RID: 10195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D3")]
		[Address(RVA = "0x249EEF0", Offset = "0x249EEF0", VA = "0x7BBCC9EEF0")]
		public PVECardPriceDesc()
		{
		}

		// Token: 0x040033E6 RID: 13286
		[Token(Token = "0x40033E6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127704", Offset = "0x1127704")]
		public uint game_mode;

		// Token: 0x040033E7 RID: 13287
		[Token(Token = "0x40033E7")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127718", Offset = "0x1127718")]
		public uint map_id;

		// Token: 0x040033E8 RID: 13288
		[Token(Token = "0x40033E8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112772C", Offset = "0x112772C")]
		public uint difficulty;

		// Token: 0x040033E9 RID: 13289
		[Token(Token = "0x40033E9")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127740", Offset = "0x1127740")]
		public uint ai_type;

		// Token: 0x040033EA RID: 13290
		[Token(Token = "0x40033EA")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127754", Offset = "0x1127754")]
		public CardPriceDesc card_price;
	}
}
