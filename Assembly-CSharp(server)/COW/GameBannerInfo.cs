using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001960 RID: 6496
	[Token(Token = "0x2001960")]
	public class GameBannerInfo
	{
		// Token: 0x060083F9 RID: 33785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083F9")]
		[Address(RVA = "0x186BA10", Offset = "0x186BA10", VA = "0x7BBC06BA10")]
		public GameBannerInfo(string MainIcon, string desc, float duration)
		{
		}

		// Token: 0x04009489 RID: 38025
		[Token(Token = "0x4009489")]
		[FieldOffset(Offset = "0x10")]
		public string BannerMainIcon;

		// Token: 0x0400948A RID: 38026
		[Token(Token = "0x400948A")]
		[FieldOffset(Offset = "0x18")]
		public string Desc;

		// Token: 0x0400948B RID: 38027
		[Token(Token = "0x400948B")]
		[FieldOffset(Offset = "0x20")]
		public float Duration;
	}
}
