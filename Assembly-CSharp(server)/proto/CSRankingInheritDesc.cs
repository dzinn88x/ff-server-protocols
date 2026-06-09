using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B08 RID: 2824
	[Token(Token = "0x2000B08")]
	[ProtoContract]
	public class CSRankingInheritDesc
	{
		// Token: 0x06002810 RID: 10256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002810")]
		[Address(RVA = "0x21B7110", Offset = "0x21B7110", VA = "0x7BBC9B7110")]
		public CSRankingInheritDesc()
		{
		}

		// Token: 0x0400354A RID: 13642
		[Token(Token = "0x400354A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A468", Offset = "0x112A468")]
		public uint lower_bound;

		// Token: 0x0400354B RID: 13643
		[Token(Token = "0x400354B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A47C", Offset = "0x112A47C")]
		public uint upper_bound;

		// Token: 0x0400354C RID: 13644
		[Token(Token = "0x400354C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A490", Offset = "0x112A490")]
		public uint next_season_ranking_point;
	}
}
