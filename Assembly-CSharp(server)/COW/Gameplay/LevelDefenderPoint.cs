using System;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x020028E9 RID: 10473
	[Token(Token = "0x20028E9")]
	public class LevelDefenderPoint : BaseLevelObject
	{
		// Token: 0x0600DDD2 RID: 56786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DDD2")]
		[Address(RVA = "0x1EA747C", Offset = "0x1EA747C", VA = "0x7BBC6A747C", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DDD3 RID: 56787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDD3")]
		[Address(RVA = "0x1EA74C4", Offset = "0x1EA74C4", VA = "0x7BBC6A74C4")]
		public LevelDefenderPoint()
		{
		}

		// Token: 0x04010DC9 RID: 69065
		[Token(Token = "0x4010DC9")]
		[FieldOffset(Offset = "0x68")]
		public int m_RoundID;

		// Token: 0x04010DCA RID: 69066
		[Token(Token = "0x4010DCA")]
		[FieldOffset(Offset = "0x6C")]
		public int m_HP;
	}
}
