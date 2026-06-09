using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A57 RID: 2647
	[Token(Token = "0x2000A57")]
	[ProtoContract]
	public class RankingTokenGiven
	{
		// Token: 0x06002761 RID: 10081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002761")]
		[Address(RVA = "0x249FB98", Offset = "0x249FB98", VA = "0x7BBCC9FB98")]
		public RankingTokenGiven()
		{
		}

		// Token: 0x04003069 RID: 12393
		[Token(Token = "0x4003069")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121020", Offset = "0x1121020")]
		public uint survival_time_lower;

		// Token: 0x0400306A RID: 12394
		[Token(Token = "0x400306A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121034", Offset = "0x1121034")]
		public uint survival_time_upper;

		// Token: 0x0400306B RID: 12395
		[Token(Token = "0x400306B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121048", Offset = "0x1121048")]
		public uint token_given;
	}
}
