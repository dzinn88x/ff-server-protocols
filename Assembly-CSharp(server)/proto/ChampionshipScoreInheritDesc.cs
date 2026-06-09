using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AE4 RID: 2788
	[Token(Token = "0x2000AE4")]
	[ProtoContract]
	public class ChampionshipScoreInheritDesc
	{
		// Token: 0x060027EC RID: 10220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EC")]
		[Address(RVA = "0x21B811C", Offset = "0x21B811C", VA = "0x7BBC9B811C")]
		public ChampionshipScoreInheritDesc()
		{
		}

		// Token: 0x0400348A RID: 13450
		[Token(Token = "0x400348A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128ADC", Offset = "0x1128ADC")]
		public uint championship_type;

		// Token: 0x0400348B RID: 13451
		[Token(Token = "0x400348B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128AF0", Offset = "0x1128AF0")]
		public uint lower_bound;

		// Token: 0x0400348C RID: 13452
		[Token(Token = "0x400348C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128B04", Offset = "0x1128B04")]
		public uint upper_bound;

		// Token: 0x0400348D RID: 13453
		[Token(Token = "0x400348D")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128B18", Offset = "0x1128B18")]
		public uint next_season_ranking_point;
	}
}
