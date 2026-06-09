using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001CCC RID: 7372
	[Token(Token = "0x2001CCC")]
	internal class ElitePassDataManager : SingletonModule<ElitePassDataManager>, IUIModelDataChangeObserver
	{
		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x0600A0C6 RID: 41158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A96")]
		public EPEventSettingData CurEPSettingInfo
		{
			[Token(Token = "0x600A0C6")]
			[Address(RVA = "0x161734C", Offset = "0x161734C", VA = "0x7BBBE1734C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x0600A0C7 RID: 41159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A97")]
		public EPUpdateData EPUpdateEntrance
		{
			[Token(Token = "0x600A0C7")]
			[Address(RVA = "0x1617354", Offset = "0x1617354", VA = "0x7BBBE17354")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x0600A0C8 RID: 41160 RVA: 0x0002A108 File Offset: 0x00028308
		[Token(Token = "0x17000A98")]
		public bool ElitePassEnabled
		{
			[Token(Token = "0x600A0C8")]
			[Address(RVA = "0x161735C", Offset = "0x161735C", VA = "0x7BBBE1735C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600A0C9 RID: 41161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0C9")]
		[Address(RVA = "0x1617364", Offset = "0x1617364", VA = "0x7BBBE17364", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A0CA RID: 41162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0CA")]
		[Address(RVA = "0x1617848", Offset = "0x1617848", VA = "0x7BBBE17848", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A0CB RID: 41163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0CB")]
		[Address(RVA = "0x161784C", Offset = "0x161784C", VA = "0x7BBBE1784C", Slot = "10")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600A0CC RID: 41164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0CC")]
		[Address(RVA = "0x161A424", Offset = "0x161A424", VA = "0x7BBBE1A424")]
		private void UpdateBadgeItemCount(bool isTcpNoti = false)
		{
		}

		// Token: 0x0600A0CD RID: 41165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0CD")]
		[Address(RVA = "0x161A9C8", Offset = "0x161A9C8", VA = "0x7BBBE1A9C8")]
		private void UpdateFromServerEPInfo(Dictionary<uint, List<RewardStatus>> RewardStatus, Dictionary<uint, ChallengeStatus> ChallengeStatus, Dictionary<uint, DailyQuestRewardsStatus> DailyQuestRewardStatus, Dictionary<uint, List<WeeklyProcessStatus>> WeeklyQuestRewardStatus)
		{
		}

		// Token: 0x0600A0CE RID: 41166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0CE")]
		[Address(RVA = "0x161BBEC", Offset = "0x161BBEC", VA = "0x7BBBE1BBEC")]
		private void UpdateEPUnlockStatus(Dictionary<uint, List<RewardStatus>> RewardStatus)
		{
		}

		// Token: 0x0600A0CF RID: 41167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0CF")]
		[Address(RVA = "0x161BE84", Offset = "0x161BE84", VA = "0x7BBBE1BE84")]
		private void UpdateEPChallengeStatus()
		{
		}

		// Token: 0x0600A0D0 RID: 41168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D0")]
		[Address(RVA = "0x161C190", Offset = "0x161C190", VA = "0x7BBBE1C190")]
		private void UpdateEPDailyRewardStatus(Dictionary<uint, DailyQuestRewardsStatus> DailyQuestRewardStatus)
		{
		}

		// Token: 0x0600A0D1 RID: 41169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D1")]
		[Address(RVA = "0x161D49C", Offset = "0x161D49C", VA = "0x7BBBE1D49C")]
		private void UpdateEPWeeklyRewardStatus(Dictionary<uint, List<WeeklyProcessStatus>> WeeklyQuestRewardStatus)
		{
		}

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0D2")]
		[Address(RVA = "0x161DB7C", Offset = "0x161DB7C", VA = "0x7BBBE1DB7C")]
		public List<EPWeeklyRewardInfo> GetEPWeeklyRewardByWeekId(uint weekid)
		{
			return null;
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D3")]
		[Address(RVA = "0x161C644", Offset = "0x161C644", VA = "0x7BBBE1C644")]
		private void UpdateEPDailyQuestStatus()
		{
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D4")]
		[Address(RVA = "0x161CDEC", Offset = "0x161CDEC", VA = "0x7BBBE1CDEC")]
		private void UpdateEPMonthlyQuestStatus()
		{
		}

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D5")]
		[Address(RVA = "0x161C86C", Offset = "0x161C86C", VA = "0x7BBBE1C86C")]
		private void UpdateEPWeeklyQuestStatus()
		{
		}

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D6")]
		[Address(RVA = "0x161D0C0", Offset = "0x161D0C0", VA = "0x7BBBE1D0C0")]
		private void UpdateEPWeeklyQuestlockStatus()
		{
		}

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x0002A120 File Offset: 0x00028320
		[Token(Token = "0x600A0D7")]
		[Address(RVA = "0x161E04C", Offset = "0x161E04C", VA = "0x7BBBE1E04C")]
		public bool HasWeekChallengeAward(int week)
		{
			return default(bool);
		}

		// Token: 0x0600A0D8 RID: 41176 RVA: 0x0002A138 File Offset: 0x00028338
		[Token(Token = "0x600A0D8")]
		[Address(RVA = "0x161E1C4", Offset = "0x161E1C4", VA = "0x7BBBE1E1C4")]
		public bool HasWeeklyBoxReward(uint weekId)
		{
			return default(bool);
		}

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x0002A150 File Offset: 0x00028350
		[Token(Token = "0x600A0D9")]
		[Address(RVA = "0x161E534", Offset = "0x161E534", VA = "0x7BBBE1E534")]
		public bool HasDailyChallengeAward()
		{
			return default(bool);
		}

		// Token: 0x0600A0DA RID: 41178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0DA")]
		[Address(RVA = "0x161DF48", Offset = "0x161DF48", VA = "0x7BBBE1DF48")]
		private EPWeeklyQuestInfo CreateWeeklyQuestInfo(EPWeeklyQuestData data)
		{
			return null;
		}

		// Token: 0x0600A0DB RID: 41179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0DB")]
		[Address(RVA = "0x161DC04", Offset = "0x161DC04", VA = "0x7BBBE1DC04")]
		private EPDailyQuestInfo CreateDailyQuestInfo(EPDailyQuestData data)
		{
			return null;
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0DC")]
		[Address(RVA = "0x161DE44", Offset = "0x161DE44", VA = "0x7BBBE1DE44")]
		private EPMonthlyQuestInfo CreateMonthlyQuestInfo(EPMonthlyQuestData data)
		{
			return null;
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0DD")]
		[Address(RVA = "0x161E590", Offset = "0x161E590", VA = "0x7BBBE1E590")]
		private EPChallengeInfo CreateChallengeInfo(EPChallengeData data)
		{
			return null;
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0DE")]
		[Address(RVA = "0x161DA38", Offset = "0x161DA38", VA = "0x7BBBE1DA38")]
		private void ProcessChallengeInfo(EPChallengeData data, Dictionary<ChallengeType, uint> completedCountDic)
		{
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x0002A168 File Offset: 0x00028368
		[Token(Token = "0x600A0DF")]
		[Address(RVA = "0x161E69C", Offset = "0x161E69C", VA = "0x7BBBE1E69C")]
		public bool NeedShowNewVersionEPGuide()
		{
			return default(bool);
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0E0")]
		[Address(RVA = "0x161B8D8", Offset = "0x161B8D8", VA = "0x7BBBE1B8D8")]
		private void UpdateAwardInfoLocal()
		{
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x0002A180 File Offset: 0x00028380
		[Token(Token = "0x600A0E1")]
		[Address(RVA = "0x161E808", Offset = "0x161E808", VA = "0x7BBBE1E808", Slot = "11")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0E2")]
		[Address(RVA = "0x161AE8C", Offset = "0x161AE8C", VA = "0x7BBBE1AE8C")]
		public List<EPChallengeInfo> ChallengeListByType(ChallengeType type)
		{
			return null;
		}

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x0002A198 File Offset: 0x00028398
		[Token(Token = "0x600A0E3")]
		[Address(RVA = "0x161E53C", Offset = "0x161E53C", VA = "0x7BBBE1E53C")]
		public bool HasChallengeToAwardByType(ChallengeType type)
		{
			return default(bool);
		}

		// Token: 0x0600A0E4 RID: 41188 RVA: 0x0002A1B0 File Offset: 0x000283B0
		[Token(Token = "0x600A0E4")]
		[Address(RVA = "0x161E86C", Offset = "0x161E86C", VA = "0x7BBBE1E86C")]
		private bool CheckAwardForChallengeList(List<EPChallengeInfo> infoList)
		{
			return default(bool);
		}

		// Token: 0x0600A0E5 RID: 41189 RVA: 0x0002A1C8 File Offset: 0x000283C8
		[Token(Token = "0x600A0E5")]
		[Address(RVA = "0x161B500", Offset = "0x161B500", VA = "0x7BBBE1B500")]
		public bool HasNewTipsReward()
		{
			return default(bool);
		}

		// Token: 0x0600A0E6 RID: 41190 RVA: 0x0002A1E0 File Offset: 0x000283E0
		[Token(Token = "0x600A0E6")]
		[Address(RVA = "0x161EA2C", Offset = "0x161EA2C", VA = "0x7BBBE1EA2C")]
		public bool HasUnclaimedMaxReward()
		{
			return default(bool);
		}

		// Token: 0x0600A0E7 RID: 41191 RVA: 0x0002A1F8 File Offset: 0x000283F8
		[Token(Token = "0x600A0E7")]
		[Address(RVA = "0x161B630", Offset = "0x161B630", VA = "0x7BBBE1B630")]
		public bool HasNewTipsChallenge()
		{
			return default(bool);
		}

		// Token: 0x0600A0E8 RID: 41192 RVA: 0x0002A210 File Offset: 0x00028410
		[Token(Token = "0x600A0E8")]
		[Address(RVA = "0x161B7D0", Offset = "0x161B7D0", VA = "0x7BBBE1B7D0")]
		public bool HasNewUnlockedTipsChallenge()
		{
			return default(bool);
		}

		// Token: 0x0600A0E9 RID: 41193 RVA: 0x0002A228 File Offset: 0x00028428
		[Token(Token = "0x600A0E9")]
		[Address(RVA = "0x161ECBC", Offset = "0x161ECBC", VA = "0x7BBBE1ECBC")]
		public bool HasNewUnlockedTipsChallengeForType(ChallengeType cType)
		{
			return default(bool);
		}

		// Token: 0x0600A0EA RID: 41194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0EA")]
		[Address(RVA = "0x161AB0C", Offset = "0x161AB0C", VA = "0x7BBBE1AB0C")]
		public EPAwardInfo AwardInfoByUnlockID(uint unlockID)
		{
			return null;
		}

		// Token: 0x0600A0EB RID: 41195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0EB")]
		[Address(RVA = "0x161ED84", Offset = "0x161ED84", VA = "0x7BBBE1ED84")]
		public void UpdateChallengeStatus(ulong[] completeList)
		{
		}

		// Token: 0x0600A0EC RID: 41196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0EC")]
		[Address(RVA = "0x161F008", Offset = "0x161F008", VA = "0x7BBBE1F008")]
		public List<EPChallengeInfo> UnlockedSpecialChallengeList(ChallengeType cType)
		{
			return null;
		}

		// Token: 0x0600A0ED RID: 41197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0ED")]
		[Address(RVA = "0x161E978", Offset = "0x161E978", VA = "0x7BBBE1E978")]
		public List<EPChallengeInfo> AllSpecialChallengeList(ChallengeType cType)
		{
			return null;
		}

		// Token: 0x0600A0EE RID: 41198 RVA: 0x0002A240 File Offset: 0x00028440
		[Token(Token = "0x600A0EE")]
		[Address(RVA = "0x161AF3C", Offset = "0x161AF3C", VA = "0x7BBBE1AF3C")]
		public bool UpdateNewUnlockedSpecialChallengeList()
		{
			return default(bool);
		}

		// Token: 0x0600A0EF RID: 41199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0EF")]
		[Address(RVA = "0x161F1F8", Offset = "0x161F1F8", VA = "0x7BBBE1F1F8")]
		public void ClearNewUnlockedSpecialChallengeIds(ChallengeType cType)
		{
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0F0")]
		[Address(RVA = "0x161F314", Offset = "0x161F314", VA = "0x7BBBE1F314")]
		private void CheckAndAskToUpgrade()
		{
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0F1")]
		[Address(RVA = "0x161EBE8", Offset = "0x161EBE8", VA = "0x7BBBE1EBE8")]
		public EPMaxRewardData CurMaxRewardData()
		{
			return null;
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0F2")]
		[Address(RVA = "0x161ABDC", Offset = "0x161ABDC", VA = "0x7BBBE1ABDC")]
		public EPAwardInfo LastAwardInfo()
		{
			return null;
		}

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x0002A258 File Offset: 0x00028458
		[Token(Token = "0x600A0F3")]
		[Address(RVA = "0x161F9B0", Offset = "0x161F9B0", VA = "0x7BBBE1F9B0")]
		public uint MaxRewardClaimedBadge()
		{
			return 0U;
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x0002A270 File Offset: 0x00028470
		[Token(Token = "0x600A0F4")]
		[Address(RVA = "0x161FA3C", Offset = "0x161FA3C", VA = "0x7BBBE1FA3C")]
		public uint NextMaxRewardBadgeCount()
		{
			return 0U;
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x0002A288 File Offset: 0x00028488
		[Token(Token = "0x600A0F5")]
		[Address(RVA = "0x161FA80", Offset = "0x161FA80", VA = "0x7BBBE1FA80")]
		public uint NextMaxRewardToClaimBadgeNeeded()
		{
			return 0U;
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x0002A2A0 File Offset: 0x000284A0
		[Token(Token = "0x600A0F6")]
		[Address(RVA = "0x161AC94", Offset = "0x161AC94", VA = "0x7BBBE1AC94")]
		public int MaxRewardBadgeStep()
		{
			return 0;
		}

		// Token: 0x0600A0F7 RID: 41207 RVA: 0x0002A2B8 File Offset: 0x000284B8
		[Token(Token = "0x600A0F7")]
		[Address(RVA = "0x161ACC4", Offset = "0x161ACC4", VA = "0x7BBBE1ACC4")]
		public int ClaimedMaxRewardCount()
		{
			return 0;
		}

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x0002A2D0 File Offset: 0x000284D0
		[Token(Token = "0x600A0F8")]
		[Address(RVA = "0x161ADAC", Offset = "0x161ADAC", VA = "0x7BBBE1ADAC")]
		public int CanClaimMaxRewardCount()
		{
			return 0;
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x0002A2E8 File Offset: 0x000284E8
		[Token(Token = "0x600A0F9")]
		[Address(RVA = "0x161FAF8", Offset = "0x161FAF8", VA = "0x7BBBE1FAF8")]
		public int GetMaxRewardShouldShowCount(int BadgeAfter)
		{
			return 0;
		}

		// Token: 0x0600A0FA RID: 41210 RVA: 0x0002A300 File Offset: 0x00028500
		[Token(Token = "0x600A0FA")]
		[Address(RVA = "0x161FC70", Offset = "0x161FC70", VA = "0x7BBBE1FC70")]
		public bool CanBadgeCntClaimAllBaseEPReward(uint badgeCnt)
		{
			return default(bool);
		}

		// Token: 0x0600A0FB RID: 41211 RVA: 0x0002A318 File Offset: 0x00028518
		[Token(Token = "0x600A0FB")]
		[Address(RVA = "0x161FCCC", Offset = "0x161FCCC", VA = "0x7BBBE1FCCC")]
		public ResourceID GetEPPlayerEffect()
		{
			return default(ResourceID);
		}

		// Token: 0x0600A0FC RID: 41212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0FC")]
		[Address(RVA = "0x1620150", Offset = "0x1620150", VA = "0x7BBBE20150")]
		public string GetAutoShowEPPreorderPrefKey()
		{
			return null;
		}

		// Token: 0x0600A0FD RID: 41213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0FD")]
		[Address(RVA = "0x16202C0", Offset = "0x16202C0", VA = "0x7BBBE202C0")]
		public void GetEPWeekTabLockState(ref bool w1, ref bool w2, ref bool w3, ref bool w4)
		{
		}

		// Token: 0x0600A0FE RID: 41214 RVA: 0x0002A330 File Offset: 0x00028530
		[Token(Token = "0x600A0FE")]
		[Address(RVA = "0x16203D0", Offset = "0x16203D0", VA = "0x7BBBE203D0")]
		public EEPTaskTab GetShouldShowGuideEPWeekTab()
		{
			return EEPTaskTab.Daily;
		}

		// Token: 0x0600A0FF RID: 41215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0FF")]
		[Address(RVA = "0x1620538", Offset = "0x1620538", VA = "0x7BBBE20538")]
		public void SetEPWeekTabGuide(int weekId)
		{
		}

		// Token: 0x0600A100 RID: 41216 RVA: 0x0002A348 File Offset: 0x00028548
		[Token(Token = "0x600A100")]
		[Address(RVA = "0x1620614", Offset = "0x1620614", VA = "0x7BBBE20614")]
		public bool HasNewEPTabKey()
		{
			return default(bool);
		}

		// Token: 0x0600A101 RID: 41217 RVA: 0x0002A360 File Offset: 0x00028560
		[Token(Token = "0x600A101")]
		[Address(RVA = "0x1620694", Offset = "0x1620694", VA = "0x7BBBE20694")]
		public int GetEPWeekChallengeClaimedCnt(uint weekId)
		{
			return 0;
		}

		// Token: 0x0600A102 RID: 41218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A102")]
		[Address(RVA = "0x16207E8", Offset = "0x16207E8", VA = "0x7BBBE207E8")]
		public ElitePassDataManager()
		{
		}

		// Token: 0x0400A790 RID: 42896
		[Token(Token = "0x400A790")]
		[FieldOffset(Offset = "0x18")]
		private EPEventSettingData m_CurEPSettingInfo;

		// Token: 0x0400A791 RID: 42897
		[Token(Token = "0x400A791")]
		[FieldOffset(Offset = "0x20")]
		private EPUpdateData m_EPUpdateEntrance;

		// Token: 0x0400A792 RID: 42898
		[Token(Token = "0x400A792")]
		public const int EPDebrisExchangeRate = 10000;

		// Token: 0x0400A793 RID: 42899
		[Token(Token = "0x400A793")]
		[FieldOffset(Offset = "0x28")]
		public List<EPAwardInfo> AwardInfoList;

		// Token: 0x0400A794 RID: 42900
		[Token(Token = "0x400A794")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<ChallengeType, List<EPChallengeInfo>> ChallengeList;

		// Token: 0x0400A795 RID: 42901
		[Token(Token = "0x400A795")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<ChallengeType, List<EPChallengeInfo>> SpecialChallengeList;

		// Token: 0x0400A796 RID: 42902
		[Token(Token = "0x400A796")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<uint, ChallengeStatus> ChallengeStatusChache;

		// Token: 0x0400A797 RID: 42903
		[Token(Token = "0x400A797")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<ChallengeType, List<uint>> newUnlockedSpecialChallengeIds;

		// Token: 0x0400A798 RID: 42904
		[Token(Token = "0x400A798")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<uint, EPDailyRewardInfo> EPDailyRewardDic;

		// Token: 0x0400A799 RID: 42905
		[Token(Token = "0x400A799")]
		[FieldOffset(Offset = "0x58")]
		public List<EPDailyQuestInfo> EPDailyQuestLst;

		// Token: 0x0400A79A RID: 42906
		[Token(Token = "0x400A79A")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<uint, List<EPWeeklyQuestInfo>> EPWeeklyQuestDic;

		// Token: 0x0400A79B RID: 42907
		[Token(Token = "0x400A79B")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<int, int> EPWeeklyQuestTipsCntDic;

		// Token: 0x0400A79C RID: 42908
		[Token(Token = "0x400A79C")]
		[FieldOffset(Offset = "0x70")]
		public List<EPMonthlyQuestInfo> EPMonthlyQuestLst;

		// Token: 0x0400A79D RID: 42909
		[Token(Token = "0x400A79D")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<uint, uint> EPDailyTaskFinishCntCache;

		// Token: 0x0400A79E RID: 42910
		[Token(Token = "0x400A79E")]
		[FieldOffset(Offset = "0x80")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x0400A79F RID: 42911
		[Token(Token = "0x400A79F")]
		[FieldOffset(Offset = "0x88")]
		private UIModelElitePass m_ModelElitePass;

		// Token: 0x0400A7A0 RID: 42912
		[Token(Token = "0x400A7A0")]
		[FieldOffset(Offset = "0x90")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x0400A7A1 RID: 42913
		[Token(Token = "0x400A7A1")]
		[FieldOffset(Offset = "0x98")]
		private uint LastClaimedRewardID;

		// Token: 0x0400A7A2 RID: 42914
		[Token(Token = "0x400A7A2")]
		[FieldOffset(Offset = "0xA0")]
		public string SHOW_NEWEP_GUIDE;

		// Token: 0x0400A7A3 RID: 42915
		[Token(Token = "0x400A7A3")]
		public const string NEW_EP_CHALLENGE_TAB_REDDOT = "NEW_EP_CHALLENGE_TAB_REDDOT";

		// Token: 0x0400A7A4 RID: 42916
		[Token(Token = "0x400A7A4")]
		public const string EP_WEEK_TAB_GUIDE = "EP_WEEK_TAB_GUIDE";

		// Token: 0x0400A7A5 RID: 42917
		[Token(Token = "0x400A7A5")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<uint, List<EPWeeklyRewardInfo>> EPWeeklyRewardDic;

		// Token: 0x0400A7A6 RID: 42918
		[Token(Token = "0x400A7A6")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<uint, bool> EPWeeklyTablockDic;

		// Token: 0x0400A7A7 RID: 42919
		[Token(Token = "0x400A7A7")]
		[FieldOffset(Offset = "0xB8")]
		private string HAS_AUTO_SHOW_SUBSCRIBEWINDOW;

		// Token: 0x0400A7A8 RID: 42920
		[Token(Token = "0x400A7A8")]
		[FieldOffset(Offset = "0xC0")]
		private uint m_CacheRewardCnt;

		// Token: 0x0400A7A9 RID: 42921
		[Token(Token = "0x400A7A9")]
		[FieldOffset(Offset = "0xC8")]
		public Dictionary<uint, uint> EPDailyTaskLastGameFinishCntCache;

		// Token: 0x02001CCD RID: 7373
		[Token(Token = "0x2001CCD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB9A4", Offset = "0x10FB9A4")]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x0600A103 RID: 41219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A103")]
			[Address(RVA = "0x1B845D0", Offset = "0x1B845D0", VA = "0x7BBC3845D0")]
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x0600A104 RID: 41220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A104")]
			[Address(RVA = "0x1B845D8", Offset = "0x1B845D8", VA = "0x7BBC3845D8")]
			internal void <OnDataChanged>b__2()
			{
			}

			// Token: 0x0400A7AA RID: 42922
			[Token(Token = "0x400A7AA")]
			[FieldOffset(Offset = "0x10")]
			public uint challengeGroupId;
		}

		// Token: 0x02001CCE RID: 7374
		[Token(Token = "0x2001CCE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB9B4", Offset = "0x10FB9B4")]
		private sealed class <>c__DisplayClass31_1
		{
			// Token: 0x0600A105 RID: 41221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A105")]
			[Address(RVA = "0x1B84700", Offset = "0x1B84700", VA = "0x7BBC384700")]
			public <>c__DisplayClass31_1()
			{
			}

			// Token: 0x0600A106 RID: 41222 RVA: 0x0002A378 File Offset: 0x00028578
			[Token(Token = "0x600A106")]
			[Address(RVA = "0x1B84708", Offset = "0x1B84708", VA = "0x7BBC384708")]
			internal bool <OnDataChanged>b__3(EPWeeklyQuestInfo e)
			{
				return default(bool);
			}

			// Token: 0x0600A107 RID: 41223 RVA: 0x0002A390 File Offset: 0x00028590
			[Token(Token = "0x600A107")]
			[Address(RVA = "0x1B84754", Offset = "0x1B84754", VA = "0x7BBC384754")]
			internal bool <OnDataChanged>b__4(EPMonthlyQuestInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400A7AB RID: 42923
			[Token(Token = "0x400A7AB")]
			[FieldOffset(Offset = "0x10")]
			public uint questId;
		}

		// Token: 0x02001CCF RID: 7375
		[Token(Token = "0x2001CCF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB9C4", Offset = "0x10FB9C4")]
		private sealed class <>c__DisplayClass31_2
		{
			// Token: 0x0600A108 RID: 41224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A108")]
			[Address(RVA = "0x1B847A0", Offset = "0x1B847A0", VA = "0x7BBC3847A0")]
			public <>c__DisplayClass31_2()
			{
			}

			// Token: 0x0600A109 RID: 41225 RVA: 0x0002A3A8 File Offset: 0x000285A8
			[Token(Token = "0x600A109")]
			[Address(RVA = "0x1B847A8", Offset = "0x1B847A8", VA = "0x7BBC3847A8")]
			internal bool <OnDataChanged>b__6(EPWeeklyRewardInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400A7AC RID: 42924
			[Token(Token = "0x400A7AC")]
			[FieldOffset(Offset = "0x10")]
			public uint boxId;
		}

		// Token: 0x02001CD0 RID: 7376
		[Token(Token = "0x2001CD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB9D4", Offset = "0x10FB9D4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A10B RID: 41227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A10B")]
			[Address(RVA = "0x1B84420", Offset = "0x1B84420", VA = "0x7BBC384420")]
			public <>c()
			{
			}

			// Token: 0x0600A10C RID: 41228 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A10C")]
			[Address(RVA = "0x1B84428", Offset = "0x1B84428", VA = "0x7BBC384428")]
			internal CommonRewardItemInfo <OnDataChanged>b__31_0(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A10D RID: 41229 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A10D")]
			[Address(RVA = "0x1B84434", Offset = "0x1B84434", VA = "0x7BBC384434")]
			internal CommonRewardItemInfo <OnDataChanged>b__31_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A10E RID: 41230 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A10E")]
			[Address(RVA = "0x1B84440", Offset = "0x1B84440", VA = "0x7BBC384440")]
			internal CommonRewardItemInfo <OnDataChanged>b__31_5(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A10F RID: 41231 RVA: 0x0002A3C0 File Offset: 0x000285C0
			[Token(Token = "0x600A10F")]
			[Address(RVA = "0x1B8444C", Offset = "0x1B8444C", VA = "0x7BBC38444C")]
			internal bool <HasNewTipsReward>b__60_0(EPAwardInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600A110 RID: 41232 RVA: 0x0002A3D8 File Offset: 0x000285D8
			[Token(Token = "0x600A110")]
			[Address(RVA = "0x1B8447C", Offset = "0x1B8447C", VA = "0x7BBC38447C")]
			internal int <UnlockedSpecialChallengeList>b__67_0(EPChallengeInfo a, EPChallengeInfo b)
			{
				return 0;
			}

			// Token: 0x0600A111 RID: 41233 RVA: 0x0002A3F0 File Offset: 0x000285F0
			[Token(Token = "0x600A111")]
			[Address(RVA = "0x1B844E4", Offset = "0x1B844E4", VA = "0x7BBC3844E4")]
			internal int <CheckAndAskToUpgrade>b__71_0(EPAwardInfo a, EPAwardInfo b)
			{
				return 0;
			}

			// Token: 0x0600A112 RID: 41234 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A112")]
			[Address(RVA = "0x1B8454C", Offset = "0x1B8454C", VA = "0x7BBC38454C")]
			internal CommonRewardItemInfo <CheckAndAskToUpgrade>b__71_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A113 RID: 41235 RVA: 0x0002A408 File Offset: 0x00028608
			[Token(Token = "0x600A113")]
			[Address(RVA = "0x1B84558", Offset = "0x1B84558", VA = "0x7BBC384558")]
			internal bool <GetEPPlayerEffect>b__82_1(EPInGameEffectConfigData e)
			{
				return default(bool);
			}

			// Token: 0x0400A7AD RID: 42925
			[Token(Token = "0x400A7AD")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ElitePassDataManager.<>c <>9;

			// Token: 0x0400A7AE RID: 42926
			[Token(Token = "0x400A7AE")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__31_0;

			// Token: 0x0400A7AF RID: 42927
			[Token(Token = "0x400A7AF")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__31_1;

			// Token: 0x0400A7B0 RID: 42928
			[Token(Token = "0x400A7B0")]
			[FieldOffset(Offset = "0x18")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__31_5;

			// Token: 0x0400A7B1 RID: 42929
			[Token(Token = "0x400A7B1")]
			[FieldOffset(Offset = "0x20")]
			public static Predicate<EPAwardInfo> <>9__60_0;

			// Token: 0x0400A7B2 RID: 42930
			[Token(Token = "0x400A7B2")]
			[FieldOffset(Offset = "0x28")]
			public static Comparison<EPChallengeInfo> <>9__67_0;

			// Token: 0x0400A7B3 RID: 42931
			[Token(Token = "0x400A7B3")]
			[FieldOffset(Offset = "0x30")]
			public static Comparison<EPAwardInfo> <>9__71_0;

			// Token: 0x0400A7B4 RID: 42932
			[Token(Token = "0x400A7B4")]
			[FieldOffset(Offset = "0x38")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__71_1;

			// Token: 0x0400A7B5 RID: 42933
			[Token(Token = "0x400A7B5")]
			[FieldOffset(Offset = "0x40")]
			public static Predicate<EPInGameEffectConfigData> <>9__82_1;
		}

		// Token: 0x02001CD1 RID: 7377
		[Token(Token = "0x2001CD1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB9E4", Offset = "0x10FB9E4")]
		private sealed class <>c__DisplayClass39_0
		{
			// Token: 0x0600A114 RID: 41236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A114")]
			[Address(RVA = "0x1B847F4", Offset = "0x1B847F4", VA = "0x7BBC3847F4")]
			public <>c__DisplayClass39_0()
			{
			}

			// Token: 0x0400A7B6 RID: 42934
			[Token(Token = "0x400A7B6")]
			[FieldOffset(Offset = "0x10")]
			public List<EPWeeklyQuestRewardData> dataLst;
		}

		// Token: 0x02001CD2 RID: 7378
		[Token(Token = "0x2001CD2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB9F4", Offset = "0x10FB9F4")]
		private sealed class <>c__DisplayClass39_1
		{
			// Token: 0x0600A115 RID: 41237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A115")]
			[Address(RVA = "0x1B847FC", Offset = "0x1B847FC", VA = "0x7BBC3847FC")]
			public <>c__DisplayClass39_1()
			{
			}

			// Token: 0x0600A116 RID: 41238 RVA: 0x0002A420 File Offset: 0x00028620
			[Token(Token = "0x600A116")]
			[Address(RVA = "0x1B84804", Offset = "0x1B84804", VA = "0x7BBC384804")]
			internal bool <UpdateEPWeeklyRewardStatus>b__0(WeeklyProcessStatus e)
			{
				return default(bool);
			}

			// Token: 0x0400A7B7 RID: 42935
			[Token(Token = "0x400A7B7")]
			[FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x0400A7B8 RID: 42936
			[Token(Token = "0x400A7B8")]
			[FieldOffset(Offset = "0x18")]
			public ElitePassDataManager.<>c__DisplayClass39_0 CS$<>8__locals1;
		}

		// Token: 0x02001CD3 RID: 7379
		[Token(Token = "0x2001CD3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBA04", Offset = "0x10FBA04")]
		private sealed class <>c__DisplayClass65_0
		{
			// Token: 0x0600A117 RID: 41239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A117")]
			[Address(RVA = "0x1B848B4", Offset = "0x1B848B4", VA = "0x7BBC3848B4")]
			public <>c__DisplayClass65_0()
			{
			}

			// Token: 0x0600A118 RID: 41240 RVA: 0x0002A438 File Offset: 0x00028638
			[Token(Token = "0x600A118")]
			[Address(RVA = "0x1B848BC", Offset = "0x1B848BC", VA = "0x7BBC3848BC")]
			internal bool <AwardInfoByUnlockID>b__0(EPAwardInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400A7B9 RID: 42937
			[Token(Token = "0x400A7B9")]
			[FieldOffset(Offset = "0x10")]
			public uint unlockID;
		}

		// Token: 0x02001CD4 RID: 7380
		[Token(Token = "0x2001CD4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBA14", Offset = "0x10FBA14")]
		private sealed class <>c__DisplayClass82_0
		{
			// Token: 0x0600A119 RID: 41241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A119")]
			[Address(RVA = "0x1B84908", Offset = "0x1B84908", VA = "0x7BBC384908")]
			public <>c__DisplayClass82_0()
			{
			}

			// Token: 0x0600A11A RID: 41242 RVA: 0x0002A450 File Offset: 0x00028650
			[Token(Token = "0x600A11A")]
			[Address(RVA = "0x1B84910", Offset = "0x1B84910", VA = "0x7BBC384910")]
			internal bool <GetEPPlayerEffect>b__0(EPInGameEffectConfigData e)
			{
				return default(bool);
			}

			// Token: 0x0400A7BA RID: 42938
			[Token(Token = "0x400A7BA")]
			[FieldOffset(Offset = "0x10")]
			public string region;
		}
	}
}
