using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001EE5 RID: 7909
	[Token(Token = "0x2001EE5")]
	public struct LatestRankInfo
	{
		// Token: 0x0400B1E2 RID: 45538
		[Token(Token = "0x400B1E2")]
		[FieldOffset(Offset = "0x0")]
		public bool IsRanking;

		// Token: 0x0400B1E3 RID: 45539
		[Token(Token = "0x400B1E3")]
		[FieldOffset(Offset = "0x4")]
		public uint RankBefore;

		// Token: 0x0400B1E4 RID: 45540
		[Token(Token = "0x400B1E4")]
		[FieldOffset(Offset = "0x8")]
		public uint RankAfter;

		// Token: 0x0400B1E5 RID: 45541
		[Token(Token = "0x400B1E5")]
		[FieldOffset(Offset = "0xC")]
		public int PointsBefore;

		// Token: 0x0400B1E6 RID: 45542
		[Token(Token = "0x400B1E6")]
		[FieldOffset(Offset = "0x10")]
		public int PointsAfter;
	}
}
