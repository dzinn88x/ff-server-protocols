using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020010E5 RID: 4325
	[Token(Token = "0x20010E5")]
	internal class EPDailyChallengeData : EPChallengeData
	{
		// Token: 0x06004379 RID: 17273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004379")]
		[Address(RVA = "0x160D654", Offset = "0x160D654", VA = "0x7BBBE0D654", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437A")]
		[Address(RVA = "0x160D7B8", Offset = "0x160D7B8", VA = "0x7BBBE0D7B8", Slot = "9")]
		protected override void DoParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437B")]
		[Address(RVA = "0x160DB54", Offset = "0x160DB54", VA = "0x7BBBE0DB54", Slot = "10")]
		protected override void DoCreateRewardList()
		{
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437C")]
		[Address(RVA = "0x160DD54", Offset = "0x160DD54", VA = "0x7BBBE0DD54")]
		protected BaseItemInfo CreateAwardInfo2()
		{
			return null;
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437D")]
		[Address(RVA = "0x160DDEC", Offset = "0x160DDEC", VA = "0x7BBBE0DDEC")]
		public static List<EPDailyChallengeData> GetDailyChallengeDataByDateOfWeek(uint date)
		{
			return null;
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437E")]
		[Address(RVA = "0x160DF88", Offset = "0x160DF88", VA = "0x7BBBE0DF88")]
		public BaseItemInfo[] GetDailyRewardLst()
		{
			return null;
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437F")]
		[Address(RVA = "0x160DF90", Offset = "0x160DF90", VA = "0x7BBBE0DF90")]
		public EPDailyChallengeData()
		{
		}

		// Token: 0x04005352 RID: 21330
		[Token(Token = "0x4005352")]
		[FieldOffset(Offset = "0x4C")]
		public uint ChallengeDate;

		// Token: 0x04005353 RID: 21331
		[Token(Token = "0x4005353")]
		[FieldOffset(Offset = "0x50")]
		public EInventory.AwardType AwardType2;

		// Token: 0x04005354 RID: 21332
		[Token(Token = "0x4005354")]
		[FieldOffset(Offset = "0x54")]
		public uint AwardID2;

		// Token: 0x04005355 RID: 21333
		[Token(Token = "0x4005355")]
		[FieldOffset(Offset = "0x58")]
		public uint AwardNum2;
	}
}
