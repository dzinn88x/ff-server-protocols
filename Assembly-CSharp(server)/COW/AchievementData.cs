using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200108D RID: 4237
	[Token(Token = "0x200108D")]
	public class AchievementData : CSVBaseData
	{
		// Token: 0x06004134 RID: 16692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004134")]
		[Address(RVA = "0x1F97E44", Offset = "0x1F97E44", VA = "0x7BBC797E44", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004135")]
		[Address(RVA = "0x1F97E50", Offset = "0x1F97E50", VA = "0x7BBC797E50", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004136")]
		[Address(RVA = "0x1F9808C", Offset = "0x1F9808C", VA = "0x7BBC79808C")]
		public AchievementData()
		{
		}

		// Token: 0x0400509B RID: 20635
		[Token(Token = "0x400509B")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x0400509C RID: 20636
		[Token(Token = "0x400509C")]
		[FieldOffset(Offset = "0x18")]
		public string Description;

		// Token: 0x0400509D RID: 20637
		[Token(Token = "0x400509D")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID PictureRes;

		// Token: 0x0400509E RID: 20638
		[Token(Token = "0x400509E")]
		[FieldOffset(Offset = "0x24")]
		public int Priority;

		// Token: 0x0400509F RID: 20639
		[Token(Token = "0x400509F")]
		[FieldOffset(Offset = "0x28")]
		public int Param;
	}
}
