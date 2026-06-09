using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x02002A4B RID: 10827
	[Token(Token = "0x2002A4B")]
	[Serializable]
	public class AIAttachEffects
	{
		// Token: 0x0600E8DC RID: 59612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8DC")]
		[Address(RVA = "0x1880784", Offset = "0x1880784", VA = "0x7BBC080784")]
		public AIAttachEffects()
		{
		}

		// Token: 0x040113A0 RID: 70560
		[Token(Token = "0x40113A0")]
		[FieldOffset(Offset = "0x10")]
		public List<AIAttachEffect> ActiveEffects;

		// Token: 0x040113A1 RID: 70561
		[Token(Token = "0x40113A1")]
		[FieldOffset(Offset = "0x18")]
		public List<AIAttachEffect> DisActiveEffects;
	}
}
