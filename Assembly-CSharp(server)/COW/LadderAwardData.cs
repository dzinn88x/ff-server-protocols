using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001118 RID: 4376
	[Token(Token = "0x2001118")]
	public class LadderAwardData : CSVBaseData
	{
		// Token: 0x0600447E RID: 17534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600447E")]
		[Address(RVA = "0x13F7620", Offset = "0x13F7620", VA = "0x7BBBBF7620", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447F")]
		[Address(RVA = "0x13F762C", Offset = "0x13F762C", VA = "0x7BBBBF762C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004480")]
		[Address(RVA = "0x13F79C4", Offset = "0x13F79C4", VA = "0x7BBBBF79C4")]
		public LadderAwardData()
		{
		}

		// Token: 0x04005482 RID: 21634
		[Token(Token = "0x4005482")]
		[FieldOffset(Offset = "0x10")]
		public int Rank;

		// Token: 0x04005483 RID: 21635
		[Token(Token = "0x4005483")]
		[FieldOffset(Offset = "0x18")]
		public List<BaseItemInfo> AchieveAwardItemList;

		// Token: 0x04005484 RID: 21636
		[Token(Token = "0x4005484")]
		[FieldOffset(Offset = "0x20")]
		public List<BaseItemInfo> SeasonEndAwardItemList;
	}
}
