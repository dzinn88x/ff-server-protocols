using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A58 RID: 2648
	[Token(Token = "0x2000A58")]
	[ProtoContract]
	public class RankingScoreCoefLimitation
	{
		// Token: 0x06002762 RID: 10082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002762")]
		[Address(RVA = "0x249FB2C", Offset = "0x249FB2C", VA = "0x7BBCC9FB2C")]
		public RankingScoreCoefLimitation()
		{
		}

		// Token: 0x0400306C RID: 12396
		[Token(Token = "0x400306C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112105C", Offset = "0x112105C")]
		public uint min_score;

		// Token: 0x0400306D RID: 12397
		[Token(Token = "0x400306D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121070", Offset = "0x1121070")]
		public uint max_score;

		// Token: 0x0400306E RID: 12398
		[Token(Token = "0x400306E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121084", Offset = "0x1121084")]
		public double min_coef;

		// Token: 0x0400306F RID: 12399
		[Token(Token = "0x400306F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121098", Offset = "0x1121098")]
		public double max_coef;
	}
}
