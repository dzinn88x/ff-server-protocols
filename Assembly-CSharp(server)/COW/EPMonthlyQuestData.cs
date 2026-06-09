using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010EC RID: 4332
	[Token(Token = "0x20010EC")]
	public class EPMonthlyQuestData : CsvDataIndexedReading
	{
		// Token: 0x0600439B RID: 17307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439B")]
		[Address(RVA = "0x160F730", Offset = "0x160F730", VA = "0x7BBBE0F730", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439C")]
		[Address(RVA = "0x160F73C", Offset = "0x160F73C", VA = "0x7BBBE0F73C", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600439D")]
		[Address(RVA = "0x16100C8", Offset = "0x16100C8", VA = "0x7BBBE100C8", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600439E")]
		[Address(RVA = "0x1610C68", Offset = "0x1610C68", VA = "0x7BBBE10C68")]
		public static void GetMonthlyDataByEPId(uint epID, out List<EPMonthlyQuestData> monthlyQuestLst)
		{
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600439F")]
		[Address(RVA = "0x1610E14", Offset = "0x1610E14", VA = "0x7BBBE10E14")]
		public void GetRewardList(out List<BaseItemInfo> rewardList)
		{
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A0")]
		[Address(RVA = "0x1610FE0", Offset = "0x1610FE0", VA = "0x7BBBE10FE0")]
		public EPMonthlyQuestData()
		{
		}

		// Token: 0x04005377 RID: 21367
		[Token(Token = "0x4005377")]
		[FieldOffset(Offset = "0x10")]
		public string ChallengeName;

		// Token: 0x04005378 RID: 21368
		[Token(Token = "0x4005378")]
		[FieldOffset(Offset = "0x18")]
		public string ChallengeDesc;

		// Token: 0x04005379 RID: 21369
		[Token(Token = "0x4005379")]
		[FieldOffset(Offset = "0x20")]
		public uint QuestId;

		// Token: 0x0400537A RID: 21370
		[Token(Token = "0x400537A")]
		[FieldOffset(Offset = "0x24")]
		public uint EPEventId;

		// Token: 0x0400537B RID: 21371
		[Token(Token = "0x400537B")]
		[FieldOffset(Offset = "0x28")]
		public uint TargetValue;

		// Token: 0x0400537C RID: 21372
		[Token(Token = "0x400537C")]
		[FieldOffset(Offset = "0x2C")]
		public uint TargetValue2;

		// Token: 0x0400537D RID: 21373
		[Token(Token = "0x400537D")]
		[FieldOffset(Offset = "0x30")]
		public uint AwardId;

		// Token: 0x0400537E RID: 21374
		[Token(Token = "0x400537E")]
		[FieldOffset(Offset = "0x34")]
		public uint AwardNum;

		// Token: 0x0400537F RID: 21375
		[Token(Token = "0x400537F")]
		[FieldOffset(Offset = "0x38")]
		public uint AwardId2;

		// Token: 0x04005380 RID: 21376
		[Token(Token = "0x4005380")]
		[FieldOffset(Offset = "0x3C")]
		public uint AwardNum2;

		// Token: 0x04005381 RID: 21377
		[Token(Token = "0x4005381")]
		[FieldOffset(Offset = "0x40")]
		public uint AwardId3;

		// Token: 0x04005382 RID: 21378
		[Token(Token = "0x4005382")]
		[FieldOffset(Offset = "0x44")]
		public uint AwardNum3;

		// Token: 0x04005383 RID: 21379
		[Token(Token = "0x4005383")]
		[FieldOffset(Offset = "0x48")]
		public byte CountType;

		// Token: 0x04005384 RID: 21380
		[Token(Token = "0x4005384")]
		[FieldOffset(Offset = "0x49")]
		public byte ConditionType;

		// Token: 0x04005385 RID: 21381
		[Token(Token = "0x4005385")]
		[FieldOffset(Offset = "0x4A")]
		public byte AwardType;

		// Token: 0x04005386 RID: 21382
		[Token(Token = "0x4005386")]
		[FieldOffset(Offset = "0x4B")]
		public byte AwardType2;

		// Token: 0x04005387 RID: 21383
		[Token(Token = "0x4005387")]
		[FieldOffset(Offset = "0x4C")]
		public byte AwardType3;
	}
}
