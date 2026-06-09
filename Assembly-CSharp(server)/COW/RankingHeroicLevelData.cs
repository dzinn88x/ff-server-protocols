using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001179 RID: 4473
	[Token(Token = "0x2001179")]
	public class RankingHeroicLevelData : CSVBaseData
	{
		// Token: 0x0600459D RID: 17821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459D")]
		[Address(RVA = "0x1750708", Offset = "0x1750708", VA = "0x7BBBF50708", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459E")]
		[Address(RVA = "0x1750714", Offset = "0x1750714", VA = "0x7BBBF50714", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459F")]
		[Address(RVA = "0x17507F4", Offset = "0x17507F4", VA = "0x7BBBF507F4")]
		public RankingHeroicLevelData()
		{
		}

		// Token: 0x0400568E RID: 22158
		[Token(Token = "0x400568E")]
		[FieldOffset(Offset = "0x10")]
		public uint Level;

		// Token: 0x0400568F RID: 22159
		[Token(Token = "0x400568F")]
		[FieldOffset(Offset = "0x14")]
		public bool IsHeroicLevelOpen;

		// Token: 0x04005690 RID: 22160
		[Token(Token = "0x4005690")]
		[FieldOffset(Offset = "0x18")]
		public uint RankScore;
	}
}
