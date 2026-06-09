using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200117A RID: 4474
	[Token(Token = "0x200117A")]
	public class RankingSeasonInfoData : CSVBaseData
	{
		// Token: 0x060045A0 RID: 17824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A0")]
		[Address(RVA = "0x175085C", Offset = "0x175085C", VA = "0x7BBBF5085C")]
		public RankingSeasonInfoData()
		{
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A1")]
		[Address(RVA = "0x175090C", Offset = "0x175090C", VA = "0x7BBBF5090C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A2")]
		[Address(RVA = "0x1750918", Offset = "0x1750918", VA = "0x7BBBF50918", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x04005691 RID: 22161
		[Token(Token = "0x4005691")]
		[FieldOffset(Offset = "0x10")]
		public int Index;

		// Token: 0x04005692 RID: 22162
		[Token(Token = "0x4005692")]
		[FieldOffset(Offset = "0x18")]
		public DateTime StartTime;

		// Token: 0x04005693 RID: 22163
		[Token(Token = "0x4005693")]
		[FieldOffset(Offset = "0x20")]
		public DateTime EndTime;

		// Token: 0x04005694 RID: 22164
		[Token(Token = "0x4005694")]
		[FieldOffset(Offset = "0x28")]
		public bool IsOpen;

		// Token: 0x04005695 RID: 22165
		[Token(Token = "0x4005695")]
		[FieldOffset(Offset = "0x30")]
		public string SeasonName;
	}
}
