using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001D27 RID: 7463
	[Token(Token = "0x2001D27")]
	public class UIManualGrownData : UIManualDataBase
	{
		// Token: 0x0600A293 RID: 41619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A293")]
		[Address(RVA = "0x1DF9274", Offset = "0x1DF9274", VA = "0x7BBC5F9274", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600A294 RID: 41620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A294")]
		[Address(RVA = "0x1DF9280", Offset = "0x1DF9280", VA = "0x7BBC5F9280")]
		public UIManualGrownData()
		{
		}

		// Token: 0x0400A8D4 RID: 43220
		[Token(Token = "0x400A8D4")]
		[FieldOffset(Offset = "0x60")]
		public List<LevelRewardData> m_LevelRewadList;
	}
}
