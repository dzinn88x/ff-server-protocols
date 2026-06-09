using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A4A RID: 2634
	[Token(Token = "0x2000A4A")]
	[ProtoContract]
	public class RankMMRDesc
	{
		// Token: 0x06002754 RID: 10068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002754")]
		[Address(RVA = "0x249FA08", Offset = "0x249FA08", VA = "0x7BBCC9FA08")]
		public RankMMRDesc()
		{
		}

		// Token: 0x04002FF8 RID: 12280
		[Token(Token = "0x4002FF8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120620", Offset = "0x1120620")]
		public uint rank_percent_start;

		// Token: 0x04002FF9 RID: 12281
		[Token(Token = "0x4002FF9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120634", Offset = "0x1120634")]
		public uint rank_percent_end;

		// Token: 0x04002FFA RID: 12282
		[Token(Token = "0x4002FFA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120648", Offset = "0x1120648")]
		public int mmr_delta;

		// Token: 0x04002FFB RID: 12283
		[Token(Token = "0x4002FFB")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112065C", Offset = "0x112065C")]
		public uint con_win_cnt;

		// Token: 0x04002FFC RID: 12284
		[Token(Token = "0x4002FFC")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120670", Offset = "0x1120670")]
		public int con_win_mmr;

		// Token: 0x04002FFD RID: 12285
		[Token(Token = "0x4002FFD")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120684", Offset = "0x1120684")]
		public int bot_point_percent;

		// Token: 0x04002FFE RID: 12286
		[Token(Token = "0x4002FFE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120698", Offset = "0x1120698")]
		public uint game_mode;

		// Token: 0x04002FFF RID: 12287
		[Token(Token = "0x4002FFF")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11206AC", Offset = "0x11206AC")]
		public uint map_id;
	}
}
