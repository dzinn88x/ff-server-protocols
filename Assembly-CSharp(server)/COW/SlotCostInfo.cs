using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CA9 RID: 7337
	[Token(Token = "0x2001CA9")]
	public class SlotCostInfo
	{
		// Token: 0x0600A02E RID: 41006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A02E")]
		[Address(RVA = "0x1B39CF4", Offset = "0x1B39CF4", VA = "0x7BBC339CF4")]
		public SlotCostInfo(int _slot, int _coin, int _gem)
		{
		}

		// Token: 0x0400A6FC RID: 42748
		[Token(Token = "0x400A6FC")]
		[FieldOffset(Offset = "0x10")]
		public int slot_id;

		// Token: 0x0400A6FD RID: 42749
		[Token(Token = "0x400A6FD")]
		[FieldOffset(Offset = "0x14")]
		public int coins;

		// Token: 0x0400A6FE RID: 42750
		[Token(Token = "0x400A6FE")]
		[FieldOffset(Offset = "0x18")]
		public int gems;
	}
}
