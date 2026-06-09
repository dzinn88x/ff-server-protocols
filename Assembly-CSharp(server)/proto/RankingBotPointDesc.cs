using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A78 RID: 2680
	[Token(Token = "0x2000A78")]
	[ProtoContract]
	public class RankingBotPointDesc
	{
		// Token: 0x06002782 RID: 10114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x249FA70", Offset = "0x249FA70", VA = "0x7BBCC9FA70")]
		public RankingBotPointDesc()
		{
		}

		// Token: 0x0400311B RID: 12571
		[Token(Token = "0x400311B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122434", Offset = "0x1122434")]
		public int rank_point_add_lower;

		// Token: 0x0400311C RID: 12572
		[Token(Token = "0x400311C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122448", Offset = "0x1122448")]
		public int rank_point_add_upper;

		// Token: 0x0400311D RID: 12573
		[Token(Token = "0x400311D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112245C", Offset = "0x112245C")]
		public int bot_point;
	}
}
