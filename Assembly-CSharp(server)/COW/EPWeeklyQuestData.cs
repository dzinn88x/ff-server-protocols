using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010F4 RID: 4340
	[Token(Token = "0x20010F4")]
	public class EPWeeklyQuestData : CsvDataIndexedReading
	{
		// Token: 0x060043BF RID: 17343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BF")]
		[Address(RVA = "0x161414C", Offset = "0x161414C", VA = "0x7BBBE1414C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C0")]
		[Address(RVA = "0x1614158", Offset = "0x1614158", VA = "0x7BBBE14158", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C1")]
		[Address(RVA = "0x1614C34", Offset = "0x1614C34", VA = "0x7BBBE14C34", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C2")]
		[Address(RVA = "0x1615EF8", Offset = "0x1615EF8", VA = "0x7BBBE15EF8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C3")]
		[Address(RVA = "0x1615FC8", Offset = "0x1615FC8", VA = "0x7BBBE15FC8")]
		public static void GetWeeklyDataByEPId(uint epId, out List<EPWeeklyQuestData> weeklyQuestLst)
		{
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C4")]
		[Address(RVA = "0x1616234", Offset = "0x1616234", VA = "0x7BBBE16234")]
		public BaseItemInfo[] GetRewardList()
		{
			return null;
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C5")]
		[Address(RVA = "0x161623C", Offset = "0x161623C", VA = "0x7BBBE1623C")]
		public EPWeeklyQuestData()
		{
		}

		// Token: 0x040053BC RID: 21436
		[Token(Token = "0x40053BC")]
		[FieldOffset(Offset = "0x10")]
		public BaseItemInfo[] AwardList;

		// Token: 0x040053BD RID: 21437
		[Token(Token = "0x40053BD")]
		[FieldOffset(Offset = "0x18")]
		public string ChallengeName;

		// Token: 0x040053BE RID: 21438
		[Token(Token = "0x40053BE")]
		[FieldOffset(Offset = "0x20")]
		public string ChallengeDesc;

		// Token: 0x040053BF RID: 21439
		[Token(Token = "0x40053BF")]
		[FieldOffset(Offset = "0x28")]
		public DateTime StartTime;

		// Token: 0x040053C0 RID: 21440
		[Token(Token = "0x40053C0")]
		[FieldOffset(Offset = "0x30")]
		public uint QuestGroup;

		// Token: 0x040053C1 RID: 21441
		[Token(Token = "0x40053C1")]
		[FieldOffset(Offset = "0x34")]
		public uint QuestId;

		// Token: 0x040053C2 RID: 21442
		[Token(Token = "0x40053C2")]
		[FieldOffset(Offset = "0x38")]
		public uint EPEventId;

		// Token: 0x040053C3 RID: 21443
		[Token(Token = "0x40053C3")]
		[FieldOffset(Offset = "0x3C")]
		public uint TargetValue;

		// Token: 0x040053C4 RID: 21444
		[Token(Token = "0x40053C4")]
		[FieldOffset(Offset = "0x40")]
		public uint TargetValue2;

		// Token: 0x040053C5 RID: 21445
		[Token(Token = "0x40053C5")]
		[FieldOffset(Offset = "0x44")]
		public uint AwardNum;

		// Token: 0x040053C6 RID: 21446
		[Token(Token = "0x40053C6")]
		[FieldOffset(Offset = "0x48")]
		public byte CountType;

		// Token: 0x040053C7 RID: 21447
		[Token(Token = "0x40053C7")]
		[FieldOffset(Offset = "0x49")]
		public byte ConditionType;

		// Token: 0x040053C8 RID: 21448
		[Token(Token = "0x40053C8")]
		[FieldOffset(Offset = "0x4A")]
		public bool IsEPOnly;

		// Token: 0x040053C9 RID: 21449
		[Token(Token = "0x40053C9")]
		[FieldOffset(Offset = "0x4B")]
		public bool IsTeamWork;

		// Token: 0x020010F5 RID: 4341
		[Token(Token = "0x20010F5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAC34", Offset = "0x10EAC34")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060043C7 RID: 17351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043C7")]
			[Address(RVA = "0x16162A8", Offset = "0x16162A8", VA = "0x7BBBE162A8")]
			public <>c()
			{
			}

			// Token: 0x060043C8 RID: 17352 RVA: 0x00014C88 File Offset: 0x00012E88
			[Token(Token = "0x60043C8")]
			[Address(RVA = "0x16162B0", Offset = "0x16162B0", VA = "0x7BBBE162B0")]
			internal int <GetWeeklyDataByEPId>b__18_0(EPWeeklyQuestData a, EPWeeklyQuestData b)
			{
				return 0;
			}

			// Token: 0x040053CA RID: 21450
			[Token(Token = "0x40053CA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly EPWeeklyQuestData.<>c <>9;

			// Token: 0x040053CB RID: 21451
			[Token(Token = "0x40053CB")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<EPWeeklyQuestData> <>9__18_0;
		}
	}
}
