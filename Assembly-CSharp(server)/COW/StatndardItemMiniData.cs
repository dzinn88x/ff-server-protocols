using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001670 RID: 5744
	[Token(Token = "0x2001670")]
	public class StatndardItemMiniData
	{
		// Token: 0x0600680F RID: 26639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680F")]
		[Address(RVA = "0x1B3FCB4", Offset = "0x1B3FCB4", VA = "0x7BBC33FCB4")]
		public StatndardItemMiniData()
		{
		}

		// Token: 0x0400850A RID: 34058
		[Token(Token = "0x400850A")]
		[FieldOffset(Offset = "0x10")]
		public bool showLimitedTitle;

		// Token: 0x0400850B RID: 34059
		[Token(Token = "0x400850B")]
		[FieldOffset(Offset = "0x11")]
		public bool showClaim;

		// Token: 0x0400850C RID: 34060
		[Token(Token = "0x400850C")]
		[FieldOffset(Offset = "0x12")]
		public bool showGreyBG;

		// Token: 0x0400850D RID: 34061
		[Token(Token = "0x400850D")]
		[FieldOffset(Offset = "0x13")]
		public bool showHighLight;

		// Token: 0x0400850E RID: 34062
		[Token(Token = "0x400850E")]
		[FieldOffset(Offset = "0x14")]
		public bool showGotReward;

		// Token: 0x0400850F RID: 34063
		[Token(Token = "0x400850F")]
		[FieldOffset(Offset = "0x15")]
		public bool showOwned;

		// Token: 0x04008510 RID: 34064
		[Token(Token = "0x4008510")]
		[FieldOffset(Offset = "0x16")]
		public bool showDownloadInfo;

		// Token: 0x04008511 RID: 34065
		[Token(Token = "0x4008511")]
		[FieldOffset(Offset = "0x18")]
		public BaseItemInfo baseItemInfo;
	}
}
