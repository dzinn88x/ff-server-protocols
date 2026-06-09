using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001EE6 RID: 7910
	[Token(Token = "0x2001EE6")]
	public class RankCard
	{
		// Token: 0x0600ADCD RID: 44493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ADCD")]
		[Address(RVA = "0x174FE80", Offset = "0x174FE80", VA = "0x7BBBF4FE80")]
		public RankCard()
		{
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600ADCE RID: 44494 RVA: 0x00030300 File Offset: 0x0002E500
		[Token(Token = "0x17000B79")]
		public ERankCardType CardType
		{
			[Token(Token = "0x600ADCE")]
			[Address(RVA = "0x174FEA8", Offset = "0x174FEA8", VA = "0x7BBBF4FEA8")]
			get
			{
				return ERankCardType.NONE;
			}
		}

		// Token: 0x0600ADCF RID: 44495 RVA: 0x00030318 File Offset: 0x0002E518
		[Token(Token = "0x600ADCF")]
		[Address(RVA = "0x174FF34", Offset = "0x174FF34", VA = "0x7BBBF4FF34")]
		public bool IsAvalible()
		{
			return default(bool);
		}

		// Token: 0x0400B1E7 RID: 45543
		[Token(Token = "0x400B1E7")]
		[FieldOffset(Offset = "0x10")]
		public int cardId;
	}
}
