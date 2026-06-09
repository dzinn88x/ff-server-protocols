using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D9C RID: 7580
	[Token(Token = "0x2001D9C")]
	public class UIModelBounty : UIBaseModel, IBigEventModel
	{
		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x0600A5A4 RID: 42404 RVA: 0x0002C310 File Offset: 0x0002A510
		// (set) Token: 0x0600A5A3 RID: 42403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE7")]
		public int TokenTotal
		{
			[Token(Token = "0x600A5A4")]
			[Address(RVA = "0x22DB39C", Offset = "0x22DB39C", VA = "0x7BBCADB39C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600A5A3")]
			[Address(RVA = "0x22DB394", Offset = "0x22DB394", VA = "0x7BBCADB394")]
			set
			{
			}
		}

		// Token: 0x0600A5A5 RID: 42405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5A5")]
		[Address(RVA = "0x22DB3A4", Offset = "0x22DB3A4", VA = "0x7BBCADB3A4", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x0002C328 File Offset: 0x0002A528
		[Token(Token = "0x600A5A6")]
		[Address(RVA = "0x22DB538", Offset = "0x22DB538", VA = "0x7BBCADB538")]
		public bool IsFirstEnterShop()
		{
			return default(bool);
		}

		// Token: 0x0600A5A7 RID: 42407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5A7")]
		[Address(RVA = "0x22DB540", Offset = "0x22DB540", VA = "0x7BBCADB540")]
		public void SetShopEntered()
		{
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5A8")]
		[Address(RVA = "0x22DB548", Offset = "0x22DB548", VA = "0x7BBCADB548")]
		public CSGetBountyInfoRes GetBountyInfo()
		{
			return null;
		}

		// Token: 0x0600A5A9 RID: 42409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5A9")]
		[Address(RVA = "0x22DB550", Offset = "0x22DB550", VA = "0x7BBCADB550")]
		public CSGetBountySettingRes GetBountyDesc()
		{
			return null;
		}

		// Token: 0x0600A5AA RID: 42410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5AA")]
		[Address(RVA = "0x22DB558", Offset = "0x22DB558", VA = "0x7BBCADB558")]
		public List<BigEventTokenTipsDesc> GetTokenTipsDescList()
		{
			return null;
		}

		// Token: 0x0600A5AB RID: 42411 RVA: 0x0002C340 File Offset: 0x0002A540
		[Token(Token = "0x600A5AB")]
		[Address(RVA = "0x22DB570", Offset = "0x22DB570", VA = "0x7BBCADB570")]
		public uint GetEventEndTime()
		{
			return 0U;
		}

		// Token: 0x0600A5AC RID: 42412 RVA: 0x0002C358 File Offset: 0x0002A558
		[Token(Token = "0x600A5AC")]
		[Address(RVA = "0x22DB69C", Offset = "0x22DB69C", VA = "0x7BBCADB69C")]
		public uint GetEventStartTime()
		{
			return 0U;
		}

		// Token: 0x0600A5AD RID: 42413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5AD")]
		[Address(RVA = "0x22DB7C8", Offset = "0x22DB7C8", VA = "0x7BBCADB7C8")]
		public void RequestBountyInfo(bool force = false)
		{
		}

		// Token: 0x0600A5AE RID: 42414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5AE")]
		[Address(RVA = "0x22DBA3C", Offset = "0x22DBA3C", VA = "0x7BBCADBA3C")]
		public void RequestBountyDesc(bool force = false)
		{
		}

		// Token: 0x0600A5AF RID: 42415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5AF")]
		[Address(RVA = "0x22DBC8C", Offset = "0x22DBC8C", VA = "0x7BBCADBC8C")]
		public void RequestBountyWarmUpStatus()
		{
		}

		// Token: 0x0600A5B0 RID: 42416 RVA: 0x0002C370 File Offset: 0x0002A570
		[Token(Token = "0x600A5B0")]
		[Address(RVA = "0x22DBE78", Offset = "0x22DBE78", VA = "0x7BBCADBE78")]
		public uint GetWarmUpPercent()
		{
			return 0U;
		}

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x0002C388 File Offset: 0x0002A588
		[Token(Token = "0x600A5B1")]
		[Address(RVA = "0x22DBE80", Offset = "0x22DBE80", VA = "0x7BBCADBE80", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A5B2 RID: 42418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5B2")]
		[Address(RVA = "0x22DBE88", Offset = "0x22DBE88", VA = "0x7BBCADBE88", Slot = "14")]
		public void OnProcessEventOpenInfo()
		{
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x0002C3A0 File Offset: 0x0002A5A0
		[Token(Token = "0x600A5B3")]
		[Address(RVA = "0x22DC32C", Offset = "0x22DC32C", VA = "0x7BBCADC32C")]
		public bool IsTaskTipActive()
		{
			return default(bool);
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x0002C3B8 File Offset: 0x0002A5B8
		[Token(Token = "0x600A5B4")]
		[Address(RVA = "0x22DC490", Offset = "0x22DC490", VA = "0x7BBCADC490")]
		public bool IsTipActive(uint taskType)
		{
			return default(bool);
		}

		// Token: 0x0600A5B5 RID: 42421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5B5")]
		[Address(RVA = "0x22DC57C", Offset = "0x22DC57C", VA = "0x7BBCADC57C")]
		public void SetCheckedPoolCnt()
		{
		}

		// Token: 0x0600A5B6 RID: 42422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5B6")]
		[Address(RVA = "0x22DC690", Offset = "0x22DC690", VA = "0x7BBCADC690")]
		public void UpdatePoolState()
		{
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x0002C3D0 File Offset: 0x0002A5D0
		[Token(Token = "0x600A5B7")]
		[Address(RVA = "0x22DC8A4", Offset = "0x22DC8A4", VA = "0x7BBCADC8A4")]
		public bool LimitPoolUnlocked()
		{
			return default(bool);
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x0002C3E8 File Offset: 0x0002A5E8
		[Token(Token = "0x600A5B8")]
		[Address(RVA = "0x22DC920", Offset = "0x22DC920", VA = "0x7BBCADC920")]
		public bool NewPoolUnlocked()
		{
			return default(bool);
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5B9")]
		[Address(RVA = "0x22DCA6C", Offset = "0x22DCA6C", VA = "0x7BBCADCA6C")]
		public void GetIntegrateGachaRewardItemData(int curSelectedIndex, out List<IntegrateGachaRewardItemData> itemDataList)
		{
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x0002C400 File Offset: 0x0002A600
		[Token(Token = "0x600A5BA")]
		[Address(RVA = "0x22DC808", Offset = "0x22DC808", VA = "0x7BBCADC808")]
		private ulong GetLimitPoolUnlockTimeStamp()
		{
			return 0UL;
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5BB")]
		[Address(RVA = "0x22DD3D0", Offset = "0x22DD3D0", VA = "0x7BBCADD3D0")]
		public string[] GetJackPotInfoByIndex(REWARDPOOL_INTEGRATE_TYPE poolType)
		{
			return null;
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5BC")]
		[Address(RVA = "0x22DD450", Offset = "0x22DD450", VA = "0x7BBCADD450")]
		private void ProgressRewardPoolData(List<GachaShowItemsWithJackpot> jackPotList, REWARDPOOL_INTEGRATE_TYPE type)
		{
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x0002C418 File Offset: 0x0002A618
		[Token(Token = "0x600A5BD")]
		[Address(RVA = "0x22DDB08", Offset = "0x22DDB08", VA = "0x7BBCADDB08")]
		public uint GetJackPotIDByIndex(REWARDPOOL_INTEGRATE_TYPE index)
		{
			return 0U;
		}

		// Token: 0x0600A5BE RID: 42430 RVA: 0x0002C430 File Offset: 0x0002A630
		[Token(Token = "0x600A5BE")]
		[Address(RVA = "0x22DDB88", Offset = "0x22DDB88", VA = "0x7BBCADDB88")]
		public REWARDPOOL_INTEGRATE_TYPE GetIndexByJackPotID(uint jackPotID)
		{
			return REWARDPOOL_INTEGRATE_TYPE.LOTTERY_NOLIMIT;
		}

		// Token: 0x0600A5BF RID: 42431 RVA: 0x0002C448 File Offset: 0x0002A648
		[Token(Token = "0x600A5BF")]
		[Address(RVA = "0x22DDBB4", Offset = "0x22DDBB4", VA = "0x7BBCADDBB4")]
		public bool CheckPoolEmpty(REWARDPOOL_INTEGRATE_TYPE type)
		{
			return default(bool);
		}

		// Token: 0x0600A5C0 RID: 42432 RVA: 0x0002C460 File Offset: 0x0002A660
		[Token(Token = "0x600A5C0")]
		[Address(RVA = "0x22DDE08", Offset = "0x22DDE08", VA = "0x7BBCADDE08")]
		public bool CheckJackPoolLockState(uint jackPotID)
		{
			return default(bool);
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5C1")]
		[Address(RVA = "0x22DDF30", Offset = "0x22DDF30", VA = "0x7BBCADDF30")]
		private void ProgressGetRewardInfoData(List<ActIds> hasGetRewards)
		{
		}

		// Token: 0x0600A5C2 RID: 42434 RVA: 0x0002C478 File Offset: 0x0002A678
		[Token(Token = "0x600A5C2")]
		[Address(RVA = "0x22DD260", Offset = "0x22DD260", VA = "0x7BBCADD260")]
		public bool CheckItemIsOwned(REWARDPOOL_INTEGRATE_TYPE jackPotIndex, uint itemID)
		{
			return default(bool);
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5C3")]
		[Address(RVA = "0x22DE0FC", Offset = "0x22DE0FC", VA = "0x7BBCADE0FC")]
		public void GetActivityGachaInfo(REWARDPOOL_INTEGRATE_TYPE type)
		{
		}

		// Token: 0x0600A5C4 RID: 42436 RVA: 0x0002C490 File Offset: 0x0002A690
		[Token(Token = "0x600A5C4")]
		[Address(RVA = "0x22DE3A8", Offset = "0x22DE3A8", VA = "0x7BBCADE3A8")]
		public bool HasGetGachaRewardInfo()
		{
			return default(bool);
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x0002C4A8 File Offset: 0x0002A6A8
		[Token(Token = "0x600A5C5")]
		[Address(RVA = "0x22DE414", Offset = "0x22DE414", VA = "0x7BBCADE414")]
		public uint GetIntegrateGachaCouponCount()
		{
			return 0U;
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x0002C4C0 File Offset: 0x0002A6C0
		[Token(Token = "0x600A5C6")]
		[Address(RVA = "0x22DE508", Offset = "0x22DE508", VA = "0x7BBCADE508")]
		public ResourceID GetPropIconRes()
		{
			return default(ResourceID);
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5C7")]
		[Address(RVA = "0x22DE600", Offset = "0x22DE600", VA = "0x7BBCADE600")]
		public string GetCouponName()
		{
			return null;
		}

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x0002C4D8 File Offset: 0x0002A6D8
		[Token(Token = "0x600A5C8")]
		[Address(RVA = "0x22DE798", Offset = "0x22DE798", VA = "0x7BBCADE798")]
		public uint GetCouponID()
		{
			return 0U;
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5C9")]
		[Address(RVA = "0x22DD258", Offset = "0x22DD258", VA = "0x7BBCADD258")]
		public Dictionary<REWARDPOOL_INTEGRATE_TYPE, Dictionary<CommonRewardItemInfo.RewardLevel, IntegrateRewardLevelInfo>> GetAllRewardPoolInfo()
		{
			return null;
		}

		// Token: 0x0600A5CA RID: 42442 RVA: 0x0002C4F0 File Offset: 0x0002A6F0
		[Token(Token = "0x600A5CA")]
		[Address(RVA = "0x22DE8D0", Offset = "0x22DE8D0", VA = "0x7BBCADE8D0")]
		public bool NeedToShowDrawGuide()
		{
			return default(bool);
		}

		// Token: 0x0600A5CB RID: 42443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5CB")]
		[Address(RVA = "0x22DE9DC", Offset = "0x22DE9DC", VA = "0x7BBCADE9DC")]
		public void SetDrawGuideShowed()
		{
		}

		// Token: 0x0600A5CC RID: 42444 RVA: 0x0002C508 File Offset: 0x0002A708
		[Token(Token = "0x600A5CC")]
		[Address(RVA = "0x22DEAC0", Offset = "0x22DEAC0", VA = "0x7BBCADEAC0")]
		public bool NeedToShowSwitchGuide()
		{
			return default(bool);
		}

		// Token: 0x0600A5CD RID: 42445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5CD")]
		[Address(RVA = "0x22DEBAC", Offset = "0x22DEBAC", VA = "0x7BBCADEBAC")]
		public void SetSwitchGuideShowed()
		{
		}

		// Token: 0x0600A5CE RID: 42446 RVA: 0x0002C520 File Offset: 0x0002A720
		[Token(Token = "0x600A5CE")]
		[Address(RVA = "0x22DEC90", Offset = "0x22DEC90", VA = "0x7BBCADEC90")]
		public bool IsGachaDescReady()
		{
			return default(bool);
		}

		// Token: 0x0600A5CF RID: 42447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5CF")]
		[Address(RVA = "0x22DBFC4", Offset = "0x22DBFC4", VA = "0x7BBCADBFC4")]
		public void InitIntegrateGachaDesc()
		{
		}

		// Token: 0x0600A5D0 RID: 42448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5D0")]
		[Address(RVA = "0x22DEC98", Offset = "0x22DEC98", VA = "0x7BBCADEC98")]
		public Dictionary<REWARDPOOL_INTEGRATE_TYPE, GachaDesc> GetIntegrateGachaDesc()
		{
			return null;
		}

		// Token: 0x0600A5D1 RID: 42449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5D1")]
		[Address(RVA = "0x22DECA0", Offset = "0x22DECA0", VA = "0x7BBCADECA0")]
		public GachaResultInfo GetIntegrateGachaResultInfo(REWARDPOOL_INTEGRATE_TYPE curChest)
		{
			return null;
		}

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5D2")]
		[Address(RVA = "0x22DED98", Offset = "0x22DED98", VA = "0x7BBCADED98")]
		public GachaShowItem GetGachaShowItemInfo(uint itmID, uint rewardPoolID, uint duration)
		{
			return null;
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A5D3")]
		[Address(RVA = "0x22DEE5C", Offset = "0x22DEE5C", VA = "0x7BBCADEE5C")]
		public List<uint> GetGachaRewardIDs(REWARDPOOL_INTEGRATE_TYPE poolType)
		{
			return null;
		}

		// Token: 0x0600A5D4 RID: 42452 RVA: 0x0002C538 File Offset: 0x0002A738
		[Token(Token = "0x600A5D4")]
		[Address(RVA = "0x22DDCDC", Offset = "0x22DDCDC", VA = "0x7BBCADDCDC")]
		public int GetGachaRewardPoolItemsCount(int jackPotIndex)
		{
			return 0;
		}

		// Token: 0x0600A5D5 RID: 42453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D5")]
		[Address(RVA = "0x22DEF5C", Offset = "0x22DEF5C", VA = "0x7BBCADEF5C")]
		public void UpdateIntegrateGachaInfo(REWARDPOOL_INTEGRATE_TYPE poolType)
		{
		}

		// Token: 0x0600A5D6 RID: 42454 RVA: 0x0002C550 File Offset: 0x0002A750
		[Token(Token = "0x600A5D6")]
		[Address(RVA = "0x22DDD68", Offset = "0x22DDD68", VA = "0x7BBCADDD68")]
		public int GetGachaOwenedItemsCount(uint jackPotID)
		{
			return 0;
		}

		// Token: 0x0600A5D7 RID: 42455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D7")]
		[Address(RVA = "0x22DF188", Offset = "0x22DF188", VA = "0x7BBCADF188")]
		public UIModelBounty()
		{
		}

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D8")]
		[Address(RVA = "0x22DF328", Offset = "0x22DF328", VA = "0x7BBCADF328")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145BDC", Offset = "0x1145BDC")]
		private void <RequestBountyInfo>b__43_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D9")]
		[Address(RVA = "0x22DF444", Offset = "0x22DF444", VA = "0x7BBCADF444")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145BEC", Offset = "0x1145BEC")]
		private void <RequestBountyDesc>b__44_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A5DA RID: 42458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5DA")]
		[Address(RVA = "0x22DF550", Offset = "0x22DF550", VA = "0x7BBCADF550")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145BFC", Offset = "0x1145BFC")]
		private void <RequestBountyWarmUpStatus>b__45_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400AB59 RID: 43865
		[Token(Token = "0x400AB59")]
		[FieldOffset(Offset = "0x18")]
		private List<BigEventOpenInfoDesc> m_EventOpenInfos;

		// Token: 0x0400AB5A RID: 43866
		[Token(Token = "0x400AB5A")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<REWARDPOOL_INTEGRATE_TYPE, string[]> m_RewardPoolIconDic;

		// Token: 0x0400AB5B RID: 43867
		[Token(Token = "0x400AB5B")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<REWARDPOOL_INTEGRATE_TYPE, uint> m_RewardPoolTotalCntDic;

		// Token: 0x0400AB5C RID: 43868
		[Token(Token = "0x400AB5C")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<REWARDPOOL_INTEGRATE_TYPE, Dictionary<CommonRewardItemInfo.RewardLevel, IntegrateRewardLevelInfo>> m_RewardPoolDic;

		// Token: 0x0400AB5D RID: 43869
		[Token(Token = "0x400AB5D")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<uint, List<uint>> m_HasGetRewardDic;

		// Token: 0x0400AB5E RID: 43870
		[Token(Token = "0x400AB5E")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<REWARDPOOL_INTEGRATE_TYPE, uint> m_ReawrdPoolIndexToJackPotID;

		// Token: 0x0400AB5F RID: 43871
		[Token(Token = "0x400AB5F")]
		[FieldOffset(Offset = "0x48")]
		private List<uint> m_UnLockPoolIDList;

		// Token: 0x0400AB60 RID: 43872
		[Token(Token = "0x400AB60")]
		[FieldOffset(Offset = "0x50")]
		private bool m_GetGachaDescFlag;

		// Token: 0x0400AB61 RID: 43873
		[Token(Token = "0x400AB61")]
		[FieldOffset(Offset = "0x58")]
		private BitArray m_GachaInfoFlag;

		// Token: 0x0400AB62 RID: 43874
		[Token(Token = "0x400AB62")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<REWARDPOOL_INTEGRATE_TYPE, uint> m_IntegrateGachaID;

		// Token: 0x0400AB63 RID: 43875
		[Token(Token = "0x400AB63")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<REWARDPOOL_INTEGRATE_TYPE, uint> m_IntegrateGachaSubID;

		// Token: 0x0400AB64 RID: 43876
		[Token(Token = "0x400AB64")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<REWARDPOOL_INTEGRATE_TYPE, GachaDesc> m_IntegrateGachaInfo;

		// Token: 0x0400AB65 RID: 43877
		[Token(Token = "0x400AB65")]
		[FieldOffset(Offset = "0x78")]
		private bool m_FirstEnterShop;

		// Token: 0x0400AB66 RID: 43878
		[Token(Token = "0x400AB66")]
		public const uint AFFILIATE_TABLE_PEAK_DAY = 6U;

		// Token: 0x0400AB67 RID: 43879
		[Token(Token = "0x400AB67")]
		public const uint AFFILIATE_TABLE_PROGRESS_AWARD = 5U;

		// Token: 0x0400AB68 RID: 43880
		[Token(Token = "0x400AB68")]
		public const uint AFFILIATE_TABLE_DAILY = 4U;

		// Token: 0x0400AB69 RID: 43881
		[Token(Token = "0x400AB69")]
		public const uint AFFILIATE_TABLE_TASKS = 3U;

		// Token: 0x0400AB6A RID: 43882
		[Token(Token = "0x400AB6A")]
		public const string BOUNTYLOBBYTIP = "BountyLobbyTip";

		// Token: 0x0400AB6B RID: 43883
		[Token(Token = "0x400AB6B")]
		public const uint PropID_UpdateBountyInfo = 2U;

		// Token: 0x0400AB6C RID: 43884
		[Token(Token = "0x400AB6C")]
		public const uint PropID_UpdateBountyDesc = 4U;

		// Token: 0x0400AB6D RID: 43885
		[Token(Token = "0x400AB6D")]
		public const uint PropID_GachaRewardInfoUpdate = 8U;

		// Token: 0x0400AB6E RID: 43886
		[Token(Token = "0x400AB6E")]
		public const uint PropID_WarmUpStatusUpdate = 16U;

		// Token: 0x0400AB6F RID: 43887
		[Token(Token = "0x400AB6F")]
		public const ulong REQUESTINTERVAL = 60UL;

		// Token: 0x0400AB70 RID: 43888
		[Token(Token = "0x400AB70")]
		public const ulong WARMUP_REQUESTINTERVAL = 10UL;

		// Token: 0x0400AB71 RID: 43889
		[Token(Token = "0x400AB71")]
		[FieldOffset(Offset = "0x80")]
		private CSGetBountySettingRes m_BountySettingRes;

		// Token: 0x0400AB72 RID: 43890
		[Token(Token = "0x400AB72")]
		[FieldOffset(Offset = "0x88")]
		private CSGetBountyInfoRes m_BountyInfoRes;

		// Token: 0x0400AB73 RID: 43891
		[Token(Token = "0x400AB73")]
		[FieldOffset(Offset = "0x90")]
		private List<BigEventOpenInfoDesc> m_OpenInfos;

		// Token: 0x0400AB74 RID: 43892
		[Token(Token = "0x400AB74")]
		[FieldOffset(Offset = "0x98")]
		private uint m_WarmUpPercent;

		// Token: 0x0400AB75 RID: 43893
		[Token(Token = "0x400AB75")]
		[FieldOffset(Offset = "0xA0")]
		private ulong m_ExpireTime;

		// Token: 0x0400AB76 RID: 43894
		[Token(Token = "0x400AB76")]
		[FieldOffset(Offset = "0xA8")]
		private ulong m_WarmUpExpireTime;

		// Token: 0x0400AB77 RID: 43895
		[Token(Token = "0x400AB77")]
		[FieldOffset(Offset = "0xB0")]
		private int m_TokenTotal;

		// Token: 0x02001D9D RID: 7581
		[Token(Token = "0x2001D9D")]
		public enum CDNType
		{
			// Token: 0x0400AB79 RID: 43897
			[Token(Token = "0x400AB79")]
			Lobby = 5001,
			// Token: 0x0400AB7A RID: 43898
			[Token(Token = "0x400AB7A")]
			Task,
			// Token: 0x0400AB7B RID: 43899
			[Token(Token = "0x400AB7B")]
			Gacha,
			// Token: 0x0400AB7C RID: 43900
			[Token(Token = "0x400AB7C")]
			Before = 5010,
			// Token: 0x0400AB7D RID: 43901
			[Token(Token = "0x400AB7D")]
			Failed,
			// Token: 0x0400AB7E RID: 43902
			[Token(Token = "0x400AB7E")]
			A,
			// Token: 0x0400AB7F RID: 43903
			[Token(Token = "0x400AB7F")]
			S,
			// Token: 0x0400AB80 RID: 43904
			[Token(Token = "0x400AB80")]
			SS,
			// Token: 0x0400AB81 RID: 43905
			[Token(Token = "0x400AB81")]
			SSS
		}

		// Token: 0x02001D9E RID: 7582
		[Token(Token = "0x2001D9E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBF54", Offset = "0x10FBF54")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A5DC RID: 42460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5DC")]
			[Address(RVA = "0x22DF6F4", Offset = "0x22DF6F4", VA = "0x7BBCADF6F4")]
			public <>c()
			{
			}

			// Token: 0x0600A5DD RID: 42461 RVA: 0x0002C568 File Offset: 0x0002A768
			[Token(Token = "0x600A5DD")]
			[Address(RVA = "0x22DF6FC", Offset = "0x22DF6FC", VA = "0x7BBCADF6FC")]
			internal int <GetIntegrateGachaRewardItemData>b__55_0(IntegrateGachaRewardItemData x, IntegrateGachaRewardItemData y)
			{
				return 0;
			}

			// Token: 0x0400AB82 RID: 43906
			[Token(Token = "0x400AB82")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelBounty.<>c <>9;

			// Token: 0x0400AB83 RID: 43907
			[Token(Token = "0x400AB83")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<IntegrateGachaRewardItemData> <>9__55_0;
		}

		// Token: 0x02001D9F RID: 7583
		[Token(Token = "0x2001D9F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBF64", Offset = "0x10FBF64")]
		private sealed class <>c__DisplayClass65_0
		{
			// Token: 0x0600A5DE RID: 42462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5DE")]
			[Address(RVA = "0x22DE3A0", Offset = "0x22DE3A0", VA = "0x7BBCADE3A0")]
			public <>c__DisplayClass65_0()
			{
			}

			// Token: 0x0600A5DF RID: 42463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5DF")]
			[Address(RVA = "0x22DF744", Offset = "0x22DF744", VA = "0x7BBCADF744")]
			internal void <GetActivityGachaInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AB84 RID: 43908
			[Token(Token = "0x400AB84")]
			[FieldOffset(Offset = "0x10")]
			public UIModelBounty <>4__this;

			// Token: 0x0400AB85 RID: 43909
			[Token(Token = "0x400AB85")]
			[FieldOffset(Offset = "0x18")]
			public REWARDPOOL_INTEGRATE_TYPE type;
		}
	}
}
