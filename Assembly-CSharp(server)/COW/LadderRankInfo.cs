using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001EE3 RID: 7907
	[Token(Token = "0x2001EE3")]
	public class LadderRankInfo
	{
		// Token: 0x0600ADCB RID: 44491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADCB")]
		[Address(RVA = "0x13FEA58", Offset = "0x13FEA58", VA = "0x7BBBBFEA58")]
		public LadderRankInfo()
		{
		}

		// Token: 0x0400B1DA RID: 45530
		[Token(Token = "0x400B1DA")]
		[FieldOffset(Offset = "0x10")]
		public int Rank;

		// Token: 0x0400B1DB RID: 45531
		[Token(Token = "0x400B1DB")]
		[FieldOffset(Offset = "0x14")]
		public int LadderScore;

		// Token: 0x0400B1DC RID: 45532
		[Token(Token = "0x400B1DC")]
		[FieldOffset(Offset = "0x18")]
		public bool GotNextRankAwards;

		// Token: 0x0400B1DD RID: 45533
		[Token(Token = "0x400B1DD")]
		[FieldOffset(Offset = "0x1C")]
		public int MaxRank;
	}
}
