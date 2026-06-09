using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001FC0 RID: 8128
	[Token(Token = "0x2001FC0")]
	public class DailyBonus
	{
		// Token: 0x0600B452 RID: 46162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B452")]
		[Address(RVA = "0x1600DAC", Offset = "0x1600DAC", VA = "0x7BBBE00DAC")]
		public DailyBonus()
		{
		}

		// Token: 0x0400B6D6 RID: 46806
		[Token(Token = "0x400B6D6")]
		[FieldOffset(Offset = "0x10")]
		public bool m_ExpAchieved;

		// Token: 0x0400B6D7 RID: 46807
		[Token(Token = "0x400B6D7")]
		[FieldOffset(Offset = "0x14")]
		public int m_ExpBonus;

		// Token: 0x0400B6D8 RID: 46808
		[Token(Token = "0x400B6D8")]
		[FieldOffset(Offset = "0x18")]
		public bool m_GoldAchieved;

		// Token: 0x0400B6D9 RID: 46809
		[Token(Token = "0x400B6D9")]
		[FieldOffset(Offset = "0x1C")]
		public int m_GoldBonus;
	}
}
