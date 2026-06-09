using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001090 RID: 4240
	[Token(Token = "0x2001090")]
	public class AgeVerifiedManager
	{
		// Token: 0x0600414C RID: 16716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414C")]
		[Address(RVA = "0x154BBA0", Offset = "0x154BBA0", VA = "0x7BBBD4BBA0")]
		public AgeVerifiedManager()
		{
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x000140A0 File Offset: 0x000122A0
		[Token(Token = "0x600414D")]
		[Address(RVA = "0x154BDEC", Offset = "0x154BDEC", VA = "0x7BBBD4BDEC")]
		public uint GetAge(string country)
		{
			return 0U;
		}

		// Token: 0x040050AA RID: 20650
		[Token(Token = "0x40050AA")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, uint> m_Age;
	}
}
