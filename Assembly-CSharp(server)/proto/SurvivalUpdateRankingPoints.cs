using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A54 RID: 2644
	[Token(Token = "0x2000A54")]
	[ProtoContract]
	public class SurvivalUpdateRankingPoints
	{
		// Token: 0x0600275E RID: 10078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275E")]
		[Address(RVA = "0x24A0CA4", Offset = "0x24A0CA4", VA = "0x7BBCCA0CA4")]
		public SurvivalUpdateRankingPoints()
		{
		}

		// Token: 0x04003045 RID: 12357
		[Token(Token = "0x4003045")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120D50", Offset = "0x1120D50")]
		public uint index;

		// Token: 0x04003046 RID: 12358
		[Token(Token = "0x4003046")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120D64", Offset = "0x1120D64")]
		public int solo;

		// Token: 0x04003047 RID: 12359
		[Token(Token = "0x4003047")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120D78", Offset = "0x1120D78")]
		public int dual;

		// Token: 0x04003048 RID: 12360
		[Token(Token = "0x4003048")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120D8C", Offset = "0x1120D8C")]
		public int squad;
	}
}
