using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016A9 RID: 5801
	[Token(Token = "0x20016A9")]
	public class AvatarLevelUpItem
	{
		// Token: 0x060069CD RID: 27085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069CD")]
		[Address(RVA = "0x15621F4", Offset = "0x15621F4", VA = "0x7BBBD621F4")]
		public AvatarLevelUpItem()
		{
		}

		// Token: 0x04008687 RID: 34439
		[Token(Token = "0x4008687")]
		[FieldOffset(Offset = "0x10")]
		public BaseItemInfo info;

		// Token: 0x04008688 RID: 34440
		[Token(Token = "0x4008688")]
		[FieldOffset(Offset = "0x18")]
		public int currentlevel;

		// Token: 0x04008689 RID: 34441
		[Token(Token = "0x4008689")]
		[FieldOffset(Offset = "0x1C")]
		public int itemlevel;
	}
}
