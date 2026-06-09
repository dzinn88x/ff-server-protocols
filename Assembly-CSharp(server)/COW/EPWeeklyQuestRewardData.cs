using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010F7 RID: 4343
	[Token(Token = "0x20010F7")]
	public class EPWeeklyQuestRewardData : CSVBaseData
	{
		// Token: 0x060043CC RID: 17356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CC")]
		[Address(RVA = "0x1616500", Offset = "0x1616500", VA = "0x7BBBE16500", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043CD")]
		[Address(RVA = "0x161650C", Offset = "0x161650C", VA = "0x7BBBE1650C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CE")]
		[Address(RVA = "0x1616A58", Offset = "0x1616A58", VA = "0x7BBBE16A58")]
		public BaseItemInfo[] GetRewardLst()
		{
			return null;
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043CF")]
		[Address(RVA = "0x1616A60", Offset = "0x1616A60", VA = "0x7BBBE16A60")]
		public static void GetWeeklyDataByEPId(uint epId, out Dictionary<uint, List<EPWeeklyQuestRewardData>> result)
		{
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D0")]
		[Address(RVA = "0x1616CF8", Offset = "0x1616CF8", VA = "0x7BBBE16CF8")]
		public EPWeeklyQuestRewardData()
		{
		}

		// Token: 0x040053D2 RID: 21458
		[Token(Token = "0x40053D2")]
		[FieldOffset(Offset = "0x10")]
		private BaseItemInfo[] AwardList;

		// Token: 0x040053D3 RID: 21459
		[Token(Token = "0x40053D3")]
		[FieldOffset(Offset = "0x18")]
		public uint ID;

		// Token: 0x040053D4 RID: 21460
		[Token(Token = "0x40053D4")]
		[FieldOffset(Offset = "0x1C")]
		public uint WeekId;

		// Token: 0x040053D5 RID: 21461
		[Token(Token = "0x40053D5")]
		[FieldOffset(Offset = "0x20")]
		public uint EPEventId;

		// Token: 0x040053D6 RID: 21462
		[Token(Token = "0x40053D6")]
		[FieldOffset(Offset = "0x24")]
		public uint NeedQuestNum;
	}
}
