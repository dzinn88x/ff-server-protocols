using System;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x02002851 RID: 10321
	[Token(Token = "0x2002851")]
	public class LevelEscortBossMovePlatform : LevelMovePlatform
	{
		// Token: 0x0600D9B0 RID: 55728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9B0")]
		[Address(RVA = "0x1EAAB1C", Offset = "0x1EAAB1C", VA = "0x7BBC6AAB1C")]
		public LevelEscortBossMovePlatform()
		{
		}

		// Token: 0x040109AE RID: 68014
		[Token(Token = "0x40109AE")]
		[FieldOffset(Offset = "0x90")]
		public LevelEscortBossMovePlatform.pwe m_EscortBossMovePlatformPos;

		// Token: 0x02002852 RID: 10322
		[Token(Token = "0x2002852")]
		public enum pwe
		{
			// Token: 0x040109B0 RID: 68016
			[Token(Token = "0x40109B0")]
			Front,
			// Token: 0x040109B1 RID: 68017
			[Token(Token = "0x40109B1")]
			Back
		}
	}
}
