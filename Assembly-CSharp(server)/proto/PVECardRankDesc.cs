using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ACA RID: 2762
	[Token(Token = "0x2000ACA")]
	[ProtoContract]
	public class PVECardRankDesc
	{
		// Token: 0x060027D2 RID: 10194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D2")]
		[Address(RVA = "0x249EEF8", Offset = "0x249EEF8", VA = "0x7BBCC9EEF8")]
		public PVECardRankDesc()
		{
		}

		// Token: 0x040033D9 RID: 13273
		[Token(Token = "0x40033D9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127600", Offset = "0x1127600")]
		public uint game_mode;

		// Token: 0x040033DA RID: 13274
		[Token(Token = "0x40033DA")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127614", Offset = "0x1127614")]
		public uint map_id;

		// Token: 0x040033DB RID: 13275
		[Token(Token = "0x40033DB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127628", Offset = "0x1127628")]
		public uint difficulty;

		// Token: 0x040033DC RID: 13276
		[Token(Token = "0x40033DC")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112763C", Offset = "0x112763C")]
		public uint ai_type;

		// Token: 0x040033DD RID: 13277
		[Token(Token = "0x40033DD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127650", Offset = "0x1127650")]
		public uint match_rank;

		// Token: 0x040033DE RID: 13278
		[Token(Token = "0x40033DE")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127664", Offset = "0x1127664")]
		public uint diamond_card_num;

		// Token: 0x040033DF RID: 13279
		[Token(Token = "0x40033DF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127678", Offset = "0x1127678")]
		public uint gold_card_num;

		// Token: 0x040033E0 RID: 13280
		[Token(Token = "0x40033E0")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112768C", Offset = "0x112768C")]
		public uint silver_card_num;

		// Token: 0x040033E1 RID: 13281
		[Token(Token = "0x40033E1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11276A0", Offset = "0x11276A0")]
		public uint bronze_card_num;

		// Token: 0x040033E2 RID: 13282
		[Token(Token = "0x40033E2")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11276B4", Offset = "0x11276B4")]
		public uint diamond_card_weight;

		// Token: 0x040033E3 RID: 13283
		[Token(Token = "0x40033E3")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11276C8", Offset = "0x11276C8")]
		public uint gold_card_weight;

		// Token: 0x040033E4 RID: 13284
		[Token(Token = "0x40033E4")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11276DC", Offset = "0x11276DC")]
		public uint silver_card_weight;

		// Token: 0x040033E5 RID: 13285
		[Token(Token = "0x40033E5")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11276F0", Offset = "0x11276F0")]
		public uint bronze_card_weight;
	}
}
