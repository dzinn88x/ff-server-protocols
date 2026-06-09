using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010F6 RID: 4342
	[Token(Token = "0x20010F6")]
	public class EPWeeklyQuestGroupData : CSVBaseData
	{
		// Token: 0x060043C9 RID: 17353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C9")]
		[Address(RVA = "0x16162F8", Offset = "0x16162F8", VA = "0x7BBBE162F8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CA")]
		[Address(RVA = "0x1616484", Offset = "0x1616484", VA = "0x7BBBE16484", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043CB")]
		[Address(RVA = "0x1616490", Offset = "0x1616490", VA = "0x7BBBE16490")]
		public EPWeeklyQuestGroupData()
		{
		}

		// Token: 0x040053CC RID: 21452
		[Token(Token = "0x40053CC")]
		[FieldOffset(Offset = "0x10")]
		public string ChallengeName;

		// Token: 0x040053CD RID: 21453
		[Token(Token = "0x40053CD")]
		[FieldOffset(Offset = "0x18")]
		public string CdnUrl;

		// Token: 0x040053CE RID: 21454
		[Token(Token = "0x40053CE")]
		[FieldOffset(Offset = "0x20")]
		public DateTime StartTime;

		// Token: 0x040053CF RID: 21455
		[Token(Token = "0x40053CF")]
		[FieldOffset(Offset = "0x28")]
		public uint ID;

		// Token: 0x040053D0 RID: 21456
		[Token(Token = "0x40053D0")]
		[FieldOffset(Offset = "0x2C")]
		public uint QuestGroup;

		// Token: 0x040053D1 RID: 21457
		[Token(Token = "0x40053D1")]
		[FieldOffset(Offset = "0x30")]
		public uint EPEventId;
	}
}
