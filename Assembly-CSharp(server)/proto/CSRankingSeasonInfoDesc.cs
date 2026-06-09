using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B03 RID: 2819
	[Token(Token = "0x2000B03")]
	[ProtoContract]
	public class CSRankingSeasonInfoDesc
	{
		// Token: 0x0600280B RID: 10251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280B")]
		[Address(RVA = "0x21B7120", Offset = "0x21B7120", VA = "0x7BBC9B7120")]
		public CSRankingSeasonInfoDesc()
		{
		}

		// Token: 0x04003527 RID: 13607
		[Token(Token = "0x4003527")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A044", Offset = "0x112A044")]
		public uint id;

		// Token: 0x04003528 RID: 13608
		[Token(Token = "0x4003528")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A058", Offset = "0x112A058")]
		public long open_time;

		// Token: 0x04003529 RID: 13609
		[Token(Token = "0x4003529")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A06C", Offset = "0x112A06C")]
		public long end_time;

		// Token: 0x0400352A RID: 13610
		[Token(Token = "0x400352A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A080", Offset = "0x112A080")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A080", Offset = "0x112A080")]
		public string season_name;

		// Token: 0x0400352B RID: 13611
		[Token(Token = "0x400352B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A0D0", Offset = "0x112A0D0")]
		public uint starting_ranking_point;

		// Token: 0x0400352C RID: 13612
		[Token(Token = "0x400352C")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A0E4", Offset = "0x112A0E4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A0E4", Offset = "0x112A0E4")]
		public string map_id;

		// Token: 0x0400352D RID: 13613
		[Token(Token = "0x400352D")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A134", Offset = "0x112A134")]
		public uint season_award_id;

		// Token: 0x0400352E RID: 13614
		[Token(Token = "0x400352E")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A148", Offset = "0x112A148")]
		public uint season_award_rank;

		// Token: 0x0400352F RID: 13615
		[Token(Token = "0x400352F")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A15C", Offset = "0x112A15C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A15C", Offset = "0x112A15C")]
		public string season_award_url;

		// Token: 0x04003530 RID: 13616
		[Token(Token = "0x4003530")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A1AC", Offset = "0x112A1AC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A1AC", Offset = "0x112A1AC")]
		public string season_bg_url;

		// Token: 0x04003531 RID: 13617
		[Token(Token = "0x4003531")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A1FC", Offset = "0x112A1FC")]
		public uint season_peak_award_id;

		// Token: 0x04003532 RID: 13618
		[Token(Token = "0x4003532")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A210", Offset = "0x112A210")]
		public uint season_peak_award_rank;

		// Token: 0x04003533 RID: 13619
		[Token(Token = "0x4003533")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A224", Offset = "0x112A224")]
		public bool heroic_mark_switch;
	}
}
