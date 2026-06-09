using System;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x02002B10 RID: 11024
	[Token(Token = "0x2002B10")]
	[Serializable]
	public class BossBGMInfo
	{
		// Token: 0x0600F24D RID: 62029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F24D")]
		[Address(RVA = "0x17C8208", Offset = "0x17C8208", VA = "0x7BBBFC8208")]
		public BossBGMInfo()
		{
		}

		// Token: 0x040117BC RID: 71612
		[Token(Token = "0x40117BC")]
		[FieldOffset(Offset = "0x10")]
		public string BgmResIDStr;

		// Token: 0x040117BD RID: 71613
		[Token(Token = "0x40117BD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1131AA4", Offset = "0x1131AA4")]
		public float Duration;
	}
}
