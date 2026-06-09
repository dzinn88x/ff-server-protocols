using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001117 RID: 4375
	[Token(Token = "0x2001117")]
	public class RankData : CSVBaseData
	{
		// Token: 0x0600447B RID: 17531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600447B")]
		[Address(RVA = "0x17501D4", Offset = "0x17501D4", VA = "0x7BBBF501D4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447C")]
		[Address(RVA = "0x17501E0", Offset = "0x17501E0", VA = "0x7BBBF501E0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600447D RID: 17533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447D")]
		[Address(RVA = "0x1750668", Offset = "0x1750668", VA = "0x7BBBF50668")]
		public RankData()
		{
		}

		// Token: 0x0400547A RID: 21626
		[Token(Token = "0x400547A")]
		[FieldOffset(Offset = "0x10")]
		public int Rank;

		// Token: 0x0400547B RID: 21627
		[Token(Token = "0x400547B")]
		[FieldOffset(Offset = "0x18")]
		public string RankName;

		// Token: 0x0400547C RID: 21628
		[Token(Token = "0x400547C")]
		[FieldOffset(Offset = "0x20")]
		public int LowerBound;

		// Token: 0x0400547D RID: 21629
		[Token(Token = "0x400547D")]
		[FieldOffset(Offset = "0x24")]
		public int UpperBound;

		// Token: 0x0400547E RID: 21630
		[Token(Token = "0x400547E")]
		[FieldOffset(Offset = "0x28")]
		public ResourceID IconRes;

		// Token: 0x0400547F RID: 21631
		[Token(Token = "0x400547F")]
		[FieldOffset(Offset = "0x2C")]
		public ResourceID BigIconRes;

		// Token: 0x04005480 RID: 21632
		[Token(Token = "0x4005480")]
		[FieldOffset(Offset = "0x30")]
		public ResourceID LobbyIconRes;

		// Token: 0x04005481 RID: 21633
		[Token(Token = "0x4005481")]
		[FieldOffset(Offset = "0x34")]
		public ResourceID LadderSeasonRes;
	}
}
