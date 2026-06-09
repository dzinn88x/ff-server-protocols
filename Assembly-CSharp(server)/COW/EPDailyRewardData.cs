using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010E7 RID: 4327
	[Token(Token = "0x20010E7")]
	public class EPDailyRewardData : CSVBaseData
	{
		// Token: 0x06004385 RID: 17285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004385")]
		[Address(RVA = "0x160EA08", Offset = "0x160EA08", VA = "0x7BBBE0EA08", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004386")]
		[Address(RVA = "0x160EA3C", Offset = "0x160EA3C", VA = "0x7BBBE0EA3C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004387")]
		[Address(RVA = "0x160EB60", Offset = "0x160EB60", VA = "0x7BBBE0EB60")]
		public static void GetDailyRewardByEPId(uint epId, out List<EPDailyRewardData> dailyRewardData)
		{
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004388")]
		[Address(RVA = "0x160EDE8", Offset = "0x160EDE8", VA = "0x7BBBE0EDE8")]
		public EPDailyRewardData()
		{
		}

		// Token: 0x0400535B RID: 21339
		[Token(Token = "0x400535B")]
		[FieldOffset(Offset = "0x10")]
		public uint EPEventId;

		// Token: 0x0400535C RID: 21340
		[Token(Token = "0x400535C")]
		[FieldOffset(Offset = "0x14")]
		public uint CountNum;

		// Token: 0x0400535D RID: 21341
		[Token(Token = "0x400535D")]
		[FieldOffset(Offset = "0x18")]
		public uint AwardId;

		// Token: 0x0400535E RID: 21342
		[Token(Token = "0x400535E")]
		[FieldOffset(Offset = "0x1C")]
		public uint AwardNum;

		// Token: 0x0400535F RID: 21343
		[Token(Token = "0x400535F")]
		[FieldOffset(Offset = "0x20")]
		public uint EPAwardNum;

		// Token: 0x020010E8 RID: 4328
		[Token(Token = "0x20010E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAC14", Offset = "0x10EAC14")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600438A RID: 17290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600438A")]
			[Address(RVA = "0x160EEB4", Offset = "0x160EEB4", VA = "0x7BBBE0EEB4")]
			public <>c()
			{
			}

			// Token: 0x0600438B RID: 17291 RVA: 0x00014B98 File Offset: 0x00012D98
			[Token(Token = "0x600438B")]
			[Address(RVA = "0x160EEBC", Offset = "0x160EEBC", VA = "0x7BBBE0EEBC")]
			internal int <GetDailyRewardByEPId>b__7_0(EPDailyRewardData a, EPDailyRewardData b)
			{
				return 0;
			}

			// Token: 0x04005360 RID: 21344
			[Token(Token = "0x4005360")]
			[FieldOffset(Offset = "0x0")]
			public static readonly EPDailyRewardData.<>c <>9;

			// Token: 0x04005361 RID: 21345
			[Token(Token = "0x4005361")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<EPDailyRewardData> <>9__7_0;
		}
	}
}
