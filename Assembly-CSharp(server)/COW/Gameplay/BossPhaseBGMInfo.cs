using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x02002B11 RID: 11025
	[Token(Token = "0x2002B11")]
	[Serializable]
	public class BossPhaseBGMInfo
	{
		// Token: 0x0600F24E RID: 62030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F24E")]
		[Address(RVA = "0x17C8210", Offset = "0x17C8210", VA = "0x7BBBFC8210")]
		public BossPhaseBGMInfo()
		{
		}

		// Token: 0x040117BE RID: 71614
		[Token(Token = "0x40117BE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1131ADC", Offset = "0x1131ADC")]
		public int phase;

		// Token: 0x040117BF RID: 71615
		[Token(Token = "0x40117BF")]
		[FieldOffset(Offset = "0x18")]
		public List<BossBGMInfo> BgmInfos;
	}
}
