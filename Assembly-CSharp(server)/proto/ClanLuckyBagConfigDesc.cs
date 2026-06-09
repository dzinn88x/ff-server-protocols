using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A45 RID: 2629
	[Token(Token = "0x2000A45")]
	[ProtoContract]
	public class ClanLuckyBagConfigDesc
	{
		// Token: 0x0600274F RID: 10063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274F")]
		[Address(RVA = "0x21B8860", Offset = "0x21B8860", VA = "0x7BBC9B8860")]
		public ClanLuckyBagConfigDesc()
		{
		}

		// Token: 0x04002FEE RID: 12270
		[Token(Token = "0x4002FEE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120558", Offset = "0x1120558")]
		public uint effective_hours;

		// Token: 0x04002FEF RID: 12271
		[Token(Token = "0x4002FEF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112056C", Offset = "0x112056C")]
		public uint max_draw_num_per_day;

		// Token: 0x04002FF0 RID: 12272
		[Token(Token = "0x4002FF0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120580", Offset = "0x1120580")]
		public uint max_bags_per_clan;

		// Token: 0x04002FF1 RID: 12273
		[Token(Token = "0x4002FF1")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120594", Offset = "0x1120594")]
		public uint guild_token_item_id;
	}
}
