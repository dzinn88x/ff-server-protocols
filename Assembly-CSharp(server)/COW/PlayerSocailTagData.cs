using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B2D RID: 6957
	[Token(Token = "0x2001B2D")]
	public class PlayerSocailTagData : PlayerTagDataBase
	{
		// Token: 0x0600950E RID: 38158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600950E")]
		[Address(RVA = "0x1EFEE7C", Offset = "0x1EFEE7C", VA = "0x7BBC6FEE7C")]
		public PlayerSocailTagData()
		{
		}

		// Token: 0x04009E67 RID: 40551
		[Token(Token = "0x4009E67")]
		[FieldOffset(Offset = "0x18")]
		public string Title;

		// Token: 0x04009E68 RID: 40552
		[Token(Token = "0x4009E68")]
		[FieldOffset(Offset = "0x20")]
		public string Desc;

		// Token: 0x04009E69 RID: 40553
		[Token(Token = "0x4009E69")]
		[FieldOffset(Offset = "0x28")]
		public bool IsShow;
	}
}
