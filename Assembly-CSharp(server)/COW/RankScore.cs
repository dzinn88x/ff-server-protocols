using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CF0 RID: 7408
	[Token(Token = "0x2001CF0")]
	[Serializable]
	internal class RankScore
	{
		// Token: 0x0600A195 RID: 41365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A195")]
		[Address(RVA = "0x17506D0", Offset = "0x17506D0", VA = "0x7BBBF506D0")]
		public RankScore(uint rank, uint score)
		{
		}

		// Token: 0x0400A801 RID: 43009
		[Token(Token = "0x400A801")]
		[FieldOffset(Offset = "0x10")]
		public uint rank;

		// Token: 0x0400A802 RID: 43010
		[Token(Token = "0x400A802")]
		[FieldOffset(Offset = "0x14")]
		public uint score;
	}
}
