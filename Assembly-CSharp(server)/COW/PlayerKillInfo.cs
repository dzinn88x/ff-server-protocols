using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001FF1 RID: 8177
	[Token(Token = "0x2001FF1")]
	internal class PlayerKillInfo
	{
		// Token: 0x0600B5FB RID: 46587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5FB")]
		[Address(RVA = "0x1EFED48", Offset = "0x1EFED48", VA = "0x7BBC6FED48")]
		public PlayerKillInfo()
		{
		}

		// Token: 0x0400B818 RID: 47128
		[Token(Token = "0x400B818")]
		[FieldOffset(Offset = "0x10")]
		public string nickname;

		// Token: 0x0400B819 RID: 47129
		[Token(Token = "0x400B819")]
		[FieldOffset(Offset = "0x18")]
		public int weaponID;

		// Token: 0x0400B81A RID: 47130
		[Token(Token = "0x400B81A")]
		[FieldOffset(Offset = "0x1C")]
		public uint headicon;
	}
}
