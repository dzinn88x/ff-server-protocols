using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006D5 RID: 1749
	[Token(Token = "0x20006D5")]
	[ProtoContract]
	public class ReachedHeroicSeason
	{
		// Token: 0x060023E4 RID: 9188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E4")]
		[Address(RVA = "0x249FC04", Offset = "0x249FC04", VA = "0x7BBCC9FC04")]
		public ReachedHeroicSeason()
		{
		}

		// Token: 0x0400227C RID: 8828
		[Token(Token = "0x400227C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109448", Offset = "0x1109448")]
		public uint[] season_ids;
	}
}
