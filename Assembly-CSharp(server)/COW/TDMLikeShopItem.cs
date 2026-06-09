using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x0200118F RID: 4495
	[Token(Token = "0x200118F")]
	internal class TDMLikeShopItem
	{
		// Token: 0x060045F9 RID: 17913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F9")]
		[Address(RVA = "0x1B41DD8", Offset = "0x1B41DD8", VA = "0x7BBC341DD8")]
		public TDMLikeShopItem()
		{
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FA")]
		[Address(RVA = "0x1B4272C", Offset = "0x1B4272C", VA = "0x7BBC34272C")]
		public TDMLikeShopItem(PBQxFMp syncData)
		{
		}

		// Token: 0x04005713 RID: 22291
		[Token(Token = "0x4005713")]
		[FieldOffset(Offset = "0x10")]
		public uint ItemId;

		// Token: 0x04005714 RID: 22292
		[Token(Token = "0x4005714")]
		[FieldOffset(Offset = "0x14")]
		public uint Count;
	}
}
