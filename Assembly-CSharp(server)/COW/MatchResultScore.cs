using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CEF RID: 7407
	[Token(Token = "0x2001CEF")]
	[Serializable]
	internal class MatchResultScore
	{
		// Token: 0x0600A194 RID: 41364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A194")]
		[Address(RVA = "0x1A5CC6C", Offset = "0x1A5CC6C", VA = "0x7BBC25CC6C")]
		public MatchResultScore()
		{
		}

		// Token: 0x0400A7FE RID: 43006
		[Token(Token = "0x400A7FE")]
		[FieldOffset(Offset = "0x10")]
		public uint groupMode;

		// Token: 0x0400A7FF RID: 43007
		[Token(Token = "0x400A7FF")]
		[FieldOffset(Offset = "0x14")]
		public uint scorePerKill;

		// Token: 0x0400A800 RID: 43008
		[Token(Token = "0x400A800")]
		[FieldOffset(Offset = "0x18")]
		public RankScore[] scoreByRank;
	}
}
