using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AE5 RID: 2789
	[Token(Token = "0x2000AE5")]
	[ProtoContract]
	public class ChampionshipScoreRewardDesc
	{
		// Token: 0x060027ED RID: 10221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027ED")]
		[Address(RVA = "0x21B8124", Offset = "0x21B8124", VA = "0x7BBC9B8124")]
		public ChampionshipScoreRewardDesc()
		{
		}

		// Token: 0x0400348E RID: 13454
		[Token(Token = "0x400348E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128B2C", Offset = "0x1128B2C")]
		public uint championship_type;

		// Token: 0x0400348F RID: 13455
		[Token(Token = "0x400348F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128B40", Offset = "0x1128B40")]
		public uint championship_id;

		// Token: 0x04003490 RID: 13456
		[Token(Token = "0x4003490")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128B54", Offset = "0x1128B54")]
		public uint lower_bound;

		// Token: 0x04003491 RID: 13457
		[Token(Token = "0x4003491")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128B68", Offset = "0x1128B68")]
		public uint upper_bound;

		// Token: 0x04003492 RID: 13458
		[Token(Token = "0x4003492")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128B7C", Offset = "0x1128B7C")]
		public List<AwardDesc> end_award;
	}
}
