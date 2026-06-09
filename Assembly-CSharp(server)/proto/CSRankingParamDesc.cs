using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B06 RID: 2822
	[Token(Token = "0x2000B06")]
	[ProtoContract]
	public class CSRankingParamDesc
	{
		// Token: 0x0600280E RID: 10254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280E")]
		[Address(RVA = "0x21B7118", Offset = "0x21B7118", VA = "0x7BBC9B7118")]
		public CSRankingParamDesc()
		{
		}

		// Token: 0x04003541 RID: 13633
		[Token(Token = "0x4003541")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A3B4", Offset = "0x112A3B4")]
		public uint games_played;

		// Token: 0x04003542 RID: 13634
		[Token(Token = "0x4003542")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A3C8", Offset = "0x112A3C8")]
		public float KDA;

		// Token: 0x04003543 RID: 13635
		[Token(Token = "0x4003543")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A3DC", Offset = "0x112A3DC")]
		public float win_rate;

		// Token: 0x04003544 RID: 13636
		[Token(Token = "0x4003544")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A3F0", Offset = "0x112A3F0")]
		public uint min_games;

		// Token: 0x04003545 RID: 13637
		[Token(Token = "0x4003545")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A404", Offset = "0x112A404")]
		public uint mail_warning;

		// Token: 0x04003546 RID: 13638
		[Token(Token = "0x4003546")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A418", Offset = "0x112A418")]
		public uint ban_cs_ranking;

		// Token: 0x04003547 RID: 13639
		[Token(Token = "0x4003547")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A42C", Offset = "0x112A42C")]
		public float combine_KD;

		// Token: 0x04003548 RID: 13640
		[Token(Token = "0x4003548")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A440", Offset = "0x112A440")]
		public float combine_Headshot;
	}
}
