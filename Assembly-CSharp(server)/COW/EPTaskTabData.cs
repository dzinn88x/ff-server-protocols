using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001790 RID: 6032
	[Token(Token = "0x2001790")]
	public class EPTaskTabData
	{
		// Token: 0x060072B5 RID: 29365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072B5")]
		[Address(RVA = "0x1612B88", Offset = "0x1612B88", VA = "0x7BBBE12B88")]
		public EPTaskTabData(EEPTaskTab tab, string tabKey)
		{
		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072B6")]
		[Address(RVA = "0x1612BC4", Offset = "0x1612BC4", VA = "0x7BBBE12BC4")]
		public EPTaskTabData()
		{
		}

		// Token: 0x04008B8B RID: 35723
		[Token(Token = "0x4008B8B")]
		[FieldOffset(Offset = "0x10")]
		public EEPTaskTab m_Tab;

		// Token: 0x04008B8C RID: 35724
		[Token(Token = "0x4008B8C")]
		[FieldOffset(Offset = "0x18")]
		public string m_TabKey;

		// Token: 0x04008B8D RID: 35725
		[Token(Token = "0x4008B8D")]
		[FieldOffset(Offset = "0x20")]
		public ETipsType m_RedDot;

		// Token: 0x04008B8E RID: 35726
		[Token(Token = "0x4008B8E")]
		[FieldOffset(Offset = "0x28")]
		public Action m_OnSelectTab;

		// Token: 0x04008B8F RID: 35727
		[Token(Token = "0x4008B8F")]
		[FieldOffset(Offset = "0x30")]
		public List<EEPTaskTab> m_SubTabs;
	}
}
