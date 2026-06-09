using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020010E4 RID: 4324
	[Token(Token = "0x20010E4")]
	public class EPChallengeData : CsvDataIndexedReading
	{
		// Token: 0x06004370 RID: 17264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004370")]
		[Address(RVA = "0x160C51C", Offset = "0x160C51C", VA = "0x7BBBE0C51C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004371")]
		[Address(RVA = "0x160C528", Offset = "0x160C528", VA = "0x7BBBE0C528", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004372")]
		[Address(RVA = "0x160C9C8", Offset = "0x160C9C8", VA = "0x7BBBE0C9C8", Slot = "9")]
		protected virtual void DoParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004373")]
		[Address(RVA = "0x160D2C4", Offset = "0x160D2C4", VA = "0x7BBBE0D2C4", Slot = "10")]
		protected virtual void DoCreateRewardList()
		{
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004374")]
		[Address(RVA = "0x160D3C0", Offset = "0x160D3C0", VA = "0x7BBBE0D3C0")]
		protected BaseItemInfo CreateAwardInfo()
		{
			return null;
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004375")]
		[Address(RVA = "0x160D45C", Offset = "0x160D45C", VA = "0x7BBBE0D45C", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004376")]
		[Address(RVA = "0x160D490", Offset = "0x160D490", VA = "0x7BBBE0D490")]
		public BaseItemInfo[] GetRewardLst()
		{
			return null;
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004377")]
		[Address(RVA = "0x160D498", Offset = "0x160D498", VA = "0x7BBBE0D498")]
		public static implicit operator EPChallengeData(EPWeeklyQuestData weekData)
		{
			return null;
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004378")]
		[Address(RVA = "0x160D63C", Offset = "0x160D63C", VA = "0x7BBBE0D63C")]
		public EPChallengeData()
		{
		}

		// Token: 0x04005342 RID: 21314
		[Token(Token = "0x4005342")]
		[FieldOffset(Offset = "0x10")]
		protected BaseItemInfo[] RewardLst;

		// Token: 0x04005343 RID: 21315
		[Token(Token = "0x4005343")]
		[FieldOffset(Offset = "0x18")]
		public string ChallengeDesc;

		// Token: 0x04005344 RID: 21316
		[Token(Token = "0x4005344")]
		[FieldOffset(Offset = "0x20")]
		public uint EPEventID;

		// Token: 0x04005345 RID: 21317
		[Token(Token = "0x4005345")]
		[FieldOffset(Offset = "0x24")]
		public uint ChallengeId;

		// Token: 0x04005346 RID: 21318
		[Token(Token = "0x4005346")]
		[FieldOffset(Offset = "0x28")]
		public int TargetValue;

		// Token: 0x04005347 RID: 21319
		[Token(Token = "0x4005347")]
		[FieldOffset(Offset = "0x2C")]
		public int TargetValue2;

		// Token: 0x04005348 RID: 21320
		[Token(Token = "0x4005348")]
		[FieldOffset(Offset = "0x30")]
		public uint AwardID;

		// Token: 0x04005349 RID: 21321
		[Token(Token = "0x4005349")]
		[FieldOffset(Offset = "0x34")]
		public int AwardNum;

		// Token: 0x0400534A RID: 21322
		[Token(Token = "0x400534A")]
		[FieldOffset(Offset = "0x38")]
		public int SpecialChallenge;

		// Token: 0x0400534B RID: 21323
		[Token(Token = "0x400534B")]
		[FieldOffset(Offset = "0x3C")]
		public uint Group;

		// Token: 0x0400534C RID: 21324
		[Token(Token = "0x400534C")]
		[FieldOffset(Offset = "0x40")]
		public EInventory.AwardType AwardType;

		// Token: 0x0400534D RID: 21325
		[Token(Token = "0x400534D")]
		[FieldOffset(Offset = "0x44")]
		public ChallengeType ChallengeType;

		// Token: 0x0400534E RID: 21326
		[Token(Token = "0x400534E")]
		[FieldOffset(Offset = "0x45")]
		public byte CountType;

		// Token: 0x0400534F RID: 21327
		[Token(Token = "0x400534F")]
		[FieldOffset(Offset = "0x46")]
		public byte DisplayType;

		// Token: 0x04005350 RID: 21328
		[Token(Token = "0x4005350")]
		[FieldOffset(Offset = "0x47")]
		public bool isTeamWork;

		// Token: 0x04005351 RID: 21329
		[Token(Token = "0x4005351")]
		[FieldOffset(Offset = "0x48")]
		public bool isEPOnly;
	}
}
