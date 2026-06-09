using System;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001157 RID: 4439
	[Token(Token = "0x2001157")]
	public class PeakRankData : CSVBaseData
	{
		// Token: 0x0600453C RID: 17724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453C")]
		[Address(RVA = "0x204B954", Offset = "0x204B954", VA = "0x7BBC84B954", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600453D")]
		[Address(RVA = "0x204B960", Offset = "0x204B960", VA = "0x7BBC84B960", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600453E")]
		[Address(RVA = "0x204BBE8", Offset = "0x204BBE8", VA = "0x7BBC84BBE8")]
		public PeakRankData()
		{
		}

		// Token: 0x040055E9 RID: 21993
		[Token(Token = "0x40055E9")]
		[FieldOffset(Offset = "0x10")]
		public int MinRequestRank;

		// Token: 0x040055EA RID: 21994
		[Token(Token = "0x40055EA")]
		[FieldOffset(Offset = "0x14")]
		public f RankType;

		// Token: 0x040055EB RID: 21995
		[Token(Token = "0x40055EB")]
		[FieldOffset(Offset = "0x18")]
		public string RankName;

		// Token: 0x040055EC RID: 21996
		[Token(Token = "0x40055EC")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID SmallIconRes;

		// Token: 0x040055ED RID: 21997
		[Token(Token = "0x40055ED")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID BigIconRes;

		// Token: 0x040055EE RID: 21998
		[Token(Token = "0x40055EE")]
		[FieldOffset(Offset = "0x28")]
		public ResourceID LobbyIconRes;

		// Token: 0x040055EF RID: 21999
		[Token(Token = "0x40055EF")]
		[FieldOffset(Offset = "0x2C")]
		public ResourceID LadderSeasonRes;
	}
}
