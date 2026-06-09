using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A55 RID: 2645
	[Token(Token = "0x2000A55")]
	[ProtoContract]
	public class RankingInheritDesc
	{
		// Token: 0x0600275F RID: 10079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275F")]
		[Address(RVA = "0x249FA88", Offset = "0x249FA88", VA = "0x7BBCC9FA88")]
		public RankingInheritDesc()
		{
		}

		// Token: 0x04003049 RID: 12361
		[Token(Token = "0x4003049")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120DA0", Offset = "0x1120DA0")]
		public uint lower_bound;

		// Token: 0x0400304A RID: 12362
		[Token(Token = "0x400304A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120DB4", Offset = "0x1120DB4")]
		public uint upper_bound;

		// Token: 0x0400304B RID: 12363
		[Token(Token = "0x400304B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120DC8", Offset = "0x1120DC8")]
		public uint next_season_ranking_point;

		// Token: 0x0400304C RID: 12364
		[Token(Token = "0x400304C")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120DDC", Offset = "0x1120DDC")]
		public uint mmr_correction;
	}
}
