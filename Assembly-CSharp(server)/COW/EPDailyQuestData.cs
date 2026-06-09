using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010E6 RID: 4326
	[Token(Token = "0x20010E6")]
	public class EPDailyQuestData : CsvDataIndexedReading
	{
		// Token: 0x06004380 RID: 17280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004380")]
		[Address(RVA = "0x160DF98", Offset = "0x160DF98", VA = "0x7BBBE0DF98", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004381")]
		[Address(RVA = "0x160DFA4", Offset = "0x160DFA4", VA = "0x7BBBE0DFA4", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004382")]
		[Address(RVA = "0x160E498", Offset = "0x160E498", VA = "0x7BBBE0E498", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004383")]
		[Address(RVA = "0x160E860", Offset = "0x160E860", VA = "0x7BBBE0E860")]
		public static void GetDailyData(out List<EPDailyQuestData> dailyQuestLst)
		{
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004384")]
		[Address(RVA = "0x160E9F8", Offset = "0x160E9F8", VA = "0x7BBBE0E9F8")]
		public EPDailyQuestData()
		{
		}

		// Token: 0x04005356 RID: 21334
		[Token(Token = "0x4005356")]
		[FieldOffset(Offset = "0x10")]
		public string ChallengeDesc;

		// Token: 0x04005357 RID: 21335
		[Token(Token = "0x4005357")]
		[FieldOffset(Offset = "0x18")]
		public uint QuestId;

		// Token: 0x04005358 RID: 21336
		[Token(Token = "0x4005358")]
		[FieldOffset(Offset = "0x1C")]
		public uint TargetValue;

		// Token: 0x04005359 RID: 21337
		[Token(Token = "0x4005359")]
		[FieldOffset(Offset = "0x20")]
		public uint TargetValue2;

		// Token: 0x0400535A RID: 21338
		[Token(Token = "0x400535A")]
		[FieldOffset(Offset = "0x24")]
		public byte CountType;
	}
}
