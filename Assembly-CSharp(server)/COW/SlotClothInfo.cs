using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200158F RID: 5519
	[Token(Token = "0x200158F")]
	public class SlotClothInfo
	{
		// Token: 0x0600606D RID: 24685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606D")]
		[Address(RVA = "0x1B39CBC", Offset = "0x1B39CBC", VA = "0x7BBC339CBC")]
		public SlotClothInfo(uint clothID, uint tabType)
		{
		}

		// Token: 0x0400809F RID: 32927
		[Token(Token = "0x400809F")]
		[FieldOffset(Offset = "0x10")]
		public uint clothID;

		// Token: 0x040080A0 RID: 32928
		[Token(Token = "0x40080A0")]
		[FieldOffset(Offset = "0x14")]
		public uint tabType;
	}
}
