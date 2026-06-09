using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000718 RID: 1816
	[Token(Token = "0x2000718")]
	[ProtoContract]
	public class RankingInfo
	{
		// Token: 0x06002425 RID: 9253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002425")]
		[Address(RVA = "0x249FA80", Offset = "0x249FA80", VA = "0x7BBCC9FA80")]
		public RankingInfo()
		{
		}

		// Token: 0x04002432 RID: 9266
		[Token(Token = "0x4002432")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BEC8", Offset = "0x110BEC8")]
		public uint season_id;

		// Token: 0x04002433 RID: 9267
		[Token(Token = "0x4002433")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BEDC", Offset = "0x110BEDC")]
		public uint rank;

		// Token: 0x04002434 RID: 9268
		[Token(Token = "0x4002434")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BEF0", Offset = "0x110BEF0")]
		public uint max_rank;

		// Token: 0x04002435 RID: 9269
		[Token(Token = "0x4002435")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BF04", Offset = "0x110BF04")]
		public uint ranking_points;
	}
}
