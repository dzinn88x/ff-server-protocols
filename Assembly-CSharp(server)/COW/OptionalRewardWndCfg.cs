using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001656 RID: 5718
	[Token(Token = "0x2001656")]
	public class OptionalRewardWndCfg : RewardWndCfg
	{
		// Token: 0x06006753 RID: 26451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006753")]
		[Address(RVA = "0x20384BC", Offset = "0x20384BC", VA = "0x7BBC8384BC")]
		public OptionalRewardWndCfg()
		{
		}

		// Token: 0x040084B5 RID: 33973
		[Token(Token = "0x40084B5")]
		[FieldOffset(Offset = "0x58")]
		public List<OptionalBundleShowData> m_OptionalBundleList;
	}
}
