using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E99 RID: 7833
	[Token(Token = "0x2001E99")]
	public class UIModelGacha : UIBaseModel
	{
		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x0600ABA7 RID: 43943 RVA: 0x0002F238 File Offset: 0x0002D438
		// (set) Token: 0x0600ABA8 RID: 43944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B55")]
		public bool NoShowConfirmWnd
		{
			[Token(Token = "0x600ABA7")]
			[Address(RVA = "0x2313EBC", Offset = "0x2313EBC", VA = "0x7BBCB13EBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11462EC", Offset = "0x11462EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600ABA8")]
			[Address(RVA = "0x2313EC4", Offset = "0x2313EC4", VA = "0x7BBCB13EC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11462FC", Offset = "0x11462FC")]
			set
			{
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600ABA9 RID: 43945 RVA: 0x0002F250 File Offset: 0x0002D450
		// (set) Token: 0x0600ABAA RID: 43946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B56")]
		public bool NoShowLengendaryBagPackGainConfirmWnd
		{
			[Token(Token = "0x600ABA9")]
			[Address(RVA = "0x2313ED0", Offset = "0x2313ED0", VA = "0x7BBCB13ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114630C", Offset = "0x114630C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600ABAA")]
			[Address(RVA = "0x2313ED8", Offset = "0x2313ED8", VA = "0x7BBCB13ED8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114631C", Offset = "0x114631C")]
			set
			{
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x0600ABAB RID: 43947 RVA: 0x0002F268 File Offset: 0x0002D468
		// (set) Token: 0x0600ABAC RID: 43948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B57")]
		public bool NoShowLengendaryBagPackReRandomConfirmWnd
		{
			[Token(Token = "0x600ABAB")]
			[Address(RVA = "0x2313EE4", Offset = "0x2313EE4", VA = "0x7BBCB13EE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114632C", Offset = "0x114632C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600ABAC")]
			[Address(RVA = "0x2313EEC", Offset = "0x2313EEC", VA = "0x7BBCB13EEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114633C", Offset = "0x114633C")]
			set
			{
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x0600ABAD RID: 43949 RVA: 0x0002F280 File Offset: 0x0002D480
		// (set) Token: 0x0600ABAE RID: 43950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B58")]
		public bool ShouldNotifyFreeGachas
		{
			[Token(Token = "0x600ABAD")]
			[Address(RVA = "0x2313EF8", Offset = "0x2313EF8", VA = "0x7BBCB13EF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600ABAE")]
			[Address(RVA = "0x2313F5C", Offset = "0x2313F5C", VA = "0x7BBCB13F5C")]
			set
			{
			}
		}

		// Token: 0x0600ABAF RID: 43951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABAF")]
		[Address(RVA = "0x2314888", Offset = "0x2314888", VA = "0x7BBCB14888", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600ABB0 RID: 43952 RVA: 0x0002F298 File Offset: 0x0002D498
		[Token(Token = "0x600ABB0")]
		[Address(RVA = "0x23148F4", Offset = "0x23148F4", VA = "0x7BBCB148F4", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600ABB1 RID: 43953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABB1")]
		[Address(RVA = "0x23148FC", Offset = "0x23148FC", VA = "0x7BBCB148FC")]
		public List<uint> GetAllRemoveItems(uint gachaID)
		{
			return null;
		}

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x0002F2B0 File Offset: 0x0002D4B0
		[Token(Token = "0x600ABB2")]
		[Address(RVA = "0x23149A0", Offset = "0x23149A0", VA = "0x7BBCB149A0")]
		public bool CheckRemoveListFull(uint gachaID)
		{
			return default(bool);
		}

		// Token: 0x0600ABB3 RID: 43955 RVA: 0x0002F2C8 File Offset: 0x0002D4C8
		[Token(Token = "0x600ABB3")]
		[Address(RVA = "0x2314A54", Offset = "0x2314A54", VA = "0x7BBCB14A54")]
		public bool GachaLimitRemoveListContain(uint gachaID, uint itemID)
		{
			return default(bool);
		}

		// Token: 0x0600ABB4 RID: 43956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABB4")]
		[Address(RVA = "0x2314B14", Offset = "0x2314B14", VA = "0x7BBCB14B14")]
		public void SetCurrentShowType(uint gachaID, UIGachaSceneShowType sceneShowType)
		{
		}

		// Token: 0x0600ABB5 RID: 43957 RVA: 0x0002F2E0 File Offset: 0x0002D4E0
		[Token(Token = "0x600ABB5")]
		[Address(RVA = "0x2314BE8", Offset = "0x2314BE8", VA = "0x7BBCB14BE8")]
		public int GetCurrentRemoveCnt(uint gachaID)
		{
			return 0;
		}

		// Token: 0x0600ABB6 RID: 43958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABB6")]
		[Address(RVA = "0x2314C94", Offset = "0x2314C94", VA = "0x7BBCB14C94")]
		public void SetGachaLimitRemoveItems(uint GachaID, uint itemID)
		{
		}

		// Token: 0x0600ABB7 RID: 43959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABB7")]
		[Address(RVA = "0x2314E1C", Offset = "0x2314E1C", VA = "0x7BBCB14E1C")]
		public void CancelGachaLimitRemoveItems(uint GachaID, uint itemID)
		{
		}

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABB8")]
		[Address(RVA = "0x2314F24", Offset = "0x2314F24", VA = "0x7BBCB14F24")]
		public void RequestRemoveGachaLimitItems(uint gachaID, uint subID)
		{
		}

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABB9")]
		[Address(RVA = "0x2315238", Offset = "0x2315238", VA = "0x7BBCB15238")]
		public void GetGachaAdRes()
		{
		}

		// Token: 0x0600ABBA RID: 43962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABBA")]
		[Address(RVA = "0x23152C8", Offset = "0x23152C8", VA = "0x7BBCB152C8")]
		public List<AdvertDesc> GetCurAdList(uint chestID)
		{
			return null;
		}

		// Token: 0x0600ABBB RID: 43963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABBB")]
		[Address(RVA = "0x2315310", Offset = "0x2315310", VA = "0x7BBCB15310")]
		public AdvertDesc GetTabRes(uint chestID)
		{
			return null;
		}

		// Token: 0x0600ABBC RID: 43964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABBC")]
		[Address(RVA = "0x2315358", Offset = "0x2315358", VA = "0x7BBCB15358")]
		public AdvertDesc GetTurntableCDNRes(uint chestID)
		{
			return null;
		}

		// Token: 0x0600ABBD RID: 43965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABBD")]
		[Address(RVA = "0x23153A0", Offset = "0x23153A0", VA = "0x7BBCB153A0")]
		public AdvertDesc GachaCDNBgCDNRes(uint chestID)
		{
			return null;
		}

		// Token: 0x0600ABBE RID: 43966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABBE")]
		[Address(RVA = "0x23153E8", Offset = "0x23153E8", VA = "0x7BBCB153E8")]
		public AdvertDesc GetLuckBagCDNRes(uint chestID)
		{
			return null;
		}

		// Token: 0x0600ABBF RID: 43967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABBF")]
		[Address(RVA = "0x2315430", Offset = "0x2315430", VA = "0x7BBCB15430")]
		public AdvertDesc GetTitleCDNBgRes(uint chestID)
		{
			return null;
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x0002F2F8 File Offset: 0x0002D4F8
		[Token(Token = "0x600ABC0")]
		[Address(RVA = "0x2315478", Offset = "0x2315478", VA = "0x7BBCB15478")]
		public ELottery.Type GetLotteryTypeByID(uint gachaID)
		{
			return ELottery.Type.Type_NORMAL;
		}

		// Token: 0x0600ABC1 RID: 43969 RVA: 0x0002F310 File Offset: 0x0002D510
		[Token(Token = "0x600ABC1")]
		[Address(RVA = "0x23154B0", Offset = "0x23154B0", VA = "0x7BBCB154B0")]
		public UIModelGacha.GachaActivityType GetChestActivityByID(uint chestID)
		{
			return UIModelGacha.GachaActivityType.NONE;
		}

		// Token: 0x0600ABC2 RID: 43970 RVA: 0x0002F328 File Offset: 0x0002D528
		[Token(Token = "0x600ABC2")]
		[Address(RVA = "0x23154F4", Offset = "0x23154F4", VA = "0x7BBCB154F4")]
		public uint GetDefGachaID()
		{
			return 0U;
		}

		// Token: 0x0600ABC3 RID: 43971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABC3")]
		[Address(RVA = "0x2315944", Offset = "0x2315944", VA = "0x7BBCB15944")]
		public GachaResultInfo GetGachaResultInfo(uint chestID)
		{
			return null;
		}

		// Token: 0x0600ABC4 RID: 43972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABC4")]
		[Address(RVA = "0x2315A0C", Offset = "0x2315A0C", VA = "0x7BBCB15A0C")]
		public List<BaseItemInfo> GetGachaRewardPoolList(List<GachaShowItem> list)
		{
			return null;
		}

		// Token: 0x0600ABC5 RID: 43973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABC5")]
		[Address(RVA = "0x2315BA0", Offset = "0x2315BA0", VA = "0x7BBCB15BA0")]
		public List<BaseItemInfo> GetGachaRewardPoolList(uint gachaID, uint rewardPoolID = 0U)
		{
			return null;
		}

		// Token: 0x0600ABC6 RID: 43974 RVA: 0x0002F340 File Offset: 0x0002D540
		[Token(Token = "0x600ABC6")]
		[Address(RVA = "0x2315E20", Offset = "0x2315E20", VA = "0x7BBCB15E20")]
		public CSSharedItemDataManager.StoreQuality GetCurrentGachaMaxQuality(uint chestID)
		{
			return CSSharedItemDataManager.StoreQuality.StoreQuality_NONE;
		}

		// Token: 0x0600ABC7 RID: 43975 RVA: 0x0002F358 File Offset: 0x0002D558
		[Token(Token = "0x600ABC7")]
		[Address(RVA = "0x231606C", Offset = "0x231606C", VA = "0x7BBCB1606C")]
		public int GetGaChaCnt()
		{
			return 0;
		}

		// Token: 0x0600ABC8 RID: 43976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABC8")]
		[Address(RVA = "0x23160CC", Offset = "0x23160CC", VA = "0x7BBCB160CC", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600ABC9 RID: 43977 RVA: 0x0002F370 File Offset: 0x0002D570
		[Token(Token = "0x600ABC9")]
		[Address(RVA = "0x2316218", Offset = "0x2316218", VA = "0x7BBCB16218")]
		public bool GetCurGachaAnimIsPlayed(uint chestID)
		{
			return default(bool);
		}

		// Token: 0x0600ABCA RID: 43978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABCA")]
		[Address(RVA = "0x231642C", Offset = "0x231642C", VA = "0x7BBCB1642C")]
		public FullscreenCgDesc GetCurGachaAnimData(uint gachaID)
		{
			return null;
		}

		// Token: 0x0600ABCB RID: 43979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABCB")]
		[Address(RVA = "0x231668C", Offset = "0x231668C", VA = "0x7BBCB1668C")]
		public void SetCurGachaAnimPlayed(uint chestID)
		{
		}

		// Token: 0x0600ABCC RID: 43980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABCC")]
		[Address(RVA = "0x2316794", Offset = "0x2316794", VA = "0x7BBCB16794")]
		private void InitCacheGachaIdSubId()
		{
		}

		// Token: 0x0600ABCD RID: 43981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABCD")]
		[Address(RVA = "0x23168E4", Offset = "0x23168E4", VA = "0x7BBCB168E4")]
		public void ClearData()
		{
		}

		// Token: 0x0600ABCE RID: 43982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABCE")]
		[Address(RVA = "0x2316994", Offset = "0x2316994", VA = "0x7BBCB16994")]
		public void RequestGachaDescRes(uint httpOption = 0U)
		{
		}

		// Token: 0x0600ABCF RID: 43983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABCF")]
		[Address(RVA = "0x2316BD0", Offset = "0x2316BD0", VA = "0x7BBCB16BD0")]
		public void ProcessGachaDes(CSGetGachaDescRes gachaRes)
		{
		}

		// Token: 0x0600ABD0 RID: 43984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABD0")]
		[Address(RVA = "0x2316E70", Offset = "0x2316E70", VA = "0x7BBCB16E70")]
		public List<GachaDesc> GetSpicalChestDesc(ELottery.Type speicalType)
		{
			return null;
		}

		// Token: 0x0600ABD1 RID: 43985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD1")]
		[Address(RVA = "0x2317080", Offset = "0x2317080", VA = "0x7BBCB17080")]
		public void RequestGachaSpecialExchangeDesc()
		{
		}

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD2")]
		[Address(RVA = "0x2317264", Offset = "0x2317264", VA = "0x7BBCB17264")]
		public void RequestDoGachaSpecialExchange(ChestSpecialExchangeDesc exchangeDes, uint count = 1U)
		{
		}

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABD3")]
		[Address(RVA = "0x2317488", Offset = "0x2317488", VA = "0x7BBCB17488")]
		private List<BaseItemInfo> AssembleAwardList(List<Item> add_list, List<Item> del_list)
		{
			return null;
		}

		// Token: 0x0600ABD4 RID: 43988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD4")]
		[Address(RVA = "0x2317668", Offset = "0x2317668", VA = "0x7BBCB17668")]
		public void RequestGachaInfoRes(uint httpOption = 0U, bool isSpecial = false)
		{
		}

		// Token: 0x0600ABD5 RID: 43989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD5")]
		[Address(RVA = "0x23178CC", Offset = "0x23178CC", VA = "0x7BBCB178CC")]
		public void RequestGachaProbability(uint gachaId, uint httpOption = 0U)
		{
		}

		// Token: 0x0600ABD6 RID: 43990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD6")]
		[Address(RVA = "0x2317C1C", Offset = "0x2317C1C", VA = "0x7BBCB17C1C")]
		public void ExchangeGachaExtraReward(uint chestID, uint condition_num)
		{
		}

		// Token: 0x0600ABD7 RID: 43991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD7")]
		[Address(RVA = "0x2317EF4", Offset = "0x2317EF4", VA = "0x7BBCB17EF4")]
		public void Purchase(uint chestID, UIModelGacha.GachaDrawType drawType, ELottery.ConsumeType consumeType, bool isRepurchase = false, uint jackpotID = 0U)
		{
		}

		// Token: 0x0600ABD8 RID: 43992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD8")]
		[Address(RVA = "0x23182B4", Offset = "0x23182B4", VA = "0x7BBCB182B4")]
		public void UpdateEPDict(uint chestID, bool IsReset)
		{
		}

		// Token: 0x0600ABD9 RID: 43993 RVA: 0x0002F388 File Offset: 0x0002D588
		[Token(Token = "0x600ABD9")]
		[Address(RVA = "0x23183DC", Offset = "0x23183DC", VA = "0x7BBCB183DC")]
		public bool IsEPReset(uint chestID)
		{
			return default(bool);
		}

		// Token: 0x0600ABDA RID: 43994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABDA")]
		[Address(RVA = "0x231848C", Offset = "0x231848C", VA = "0x7BBCB1848C")]
		private void CheckRewardLevel(uint chestID, List<ExchangedAward> awards, ref bool result)
		{
		}

		// Token: 0x0600ABDB RID: 43995 RVA: 0x0002F3A0 File Offset: 0x0002D5A0
		[Token(Token = "0x600ABDB")]
		[Address(RVA = "0x23187C0", Offset = "0x23187C0", VA = "0x7BBCB187C0")]
		public uint GetCouponCount(uint gachaID)
		{
			return 0U;
		}

		// Token: 0x0600ABDC RID: 43996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABDC")]
		[Address(RVA = "0x2318ABC", Offset = "0x2318ABC", VA = "0x7BBCB18ABC")]
		public List<CSSharedItemData> GetCouponItemsInfo(uint gachaID)
		{
			return null;
		}

		// Token: 0x0600ABDD RID: 43997 RVA: 0x0002F3B8 File Offset: 0x0002D5B8
		[Token(Token = "0x600ABDD")]
		[Address(RVA = "0x2318D8C", Offset = "0x2318D8C", VA = "0x7BBCB18D8C")]
		public uint GetSpecialCouponCount(uint gachaID)
		{
			return 0U;
		}

		// Token: 0x0600ABDE RID: 43998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABDE")]
		[Address(RVA = "0x2318EEC", Offset = "0x2318EEC", VA = "0x7BBCB18EEC")]
		public void SetCouponCount(uint gachaID, List<ExchangeItemNum> items)
		{
		}

		// Token: 0x0600ABDF RID: 43999 RVA: 0x0002F3D0 File Offset: 0x0002D5D0
		[Token(Token = "0x600ABDF")]
		[Address(RVA = "0x2319184", Offset = "0x2319184", VA = "0x7BBCB19184")]
		public uint GetExtraListCurCount(uint chestID)
		{
			return 0U;
		}

		// Token: 0x0600ABE0 RID: 44000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABE0")]
		[Address(RVA = "0x23191F4", Offset = "0x23191F4", VA = "0x7BBCB191F4")]
		public ExtraRewardDesc GetExtralRewardDesc(uint chestID, int index)
		{
			return null;
		}

		// Token: 0x0600ABE1 RID: 44001 RVA: 0x0002F3E8 File Offset: 0x0002D5E8
		[Token(Token = "0x600ABE1")]
		[Address(RVA = "0x23192BC", Offset = "0x23192BC", VA = "0x7BBCB192BC")]
		public bool IsExtralRewardExchanged(uint chestID, int index)
		{
			return default(bool);
		}

		// Token: 0x0600ABE2 RID: 44002 RVA: 0x0002F400 File Offset: 0x0002D600
		[Token(Token = "0x600ABE2")]
		[Address(RVA = "0x231954C", Offset = "0x231954C", VA = "0x7BBCB1954C")]
		public uint GetCurrentPrice(uint chestID, UIModelGacha.GachaDrawType type)
		{
			return 0U;
		}

		// Token: 0x0600ABE3 RID: 44003 RVA: 0x0002F418 File Offset: 0x0002D618
		[Token(Token = "0x600ABE3")]
		[Address(RVA = "0x2319D10", Offset = "0x2319D10", VA = "0x7BBCB19D10")]
		public uint GetOriginPrice(uint chestID, UIModelGacha.GachaDrawType type)
		{
			return 0U;
		}

		// Token: 0x0600ABE4 RID: 44004 RVA: 0x0002F430 File Offset: 0x0002D630
		[Token(Token = "0x600ABE4")]
		[Address(RVA = "0x2319C84", Offset = "0x2319C84", VA = "0x7BBCB19C84")]
		public uint GetDiscountPrice(uint chestID, UIModelGacha.GachaDrawType type)
		{
			return 0U;
		}

		// Token: 0x0600ABE5 RID: 44005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABE5")]
		[Address(RVA = "0x2319E78", Offset = "0x2319E78", VA = "0x7BBCB19E78")]
		public List<uint> GetAvatarList(uint chestID)
		{
			return null;
		}

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x0002F448 File Offset: 0x0002D648
		[Token(Token = "0x600ABE6")]
		[Address(RVA = "0x2319EC8", Offset = "0x2319EC8", VA = "0x7BBCB19EC8")]
		public uint GetAvatarModelId(uint chestID, bool isfemale)
		{
			return 0U;
		}

		// Token: 0x0600ABE7 RID: 44007 RVA: 0x0002F460 File Offset: 0x0002D660
		[Token(Token = "0x600ABE7")]
		[Address(RVA = "0x2319A04", Offset = "0x2319A04", VA = "0x7BBCB19A04")]
		public uint GetLimitPrice(uint chestID, UIModelGacha.GachaDrawType type)
		{
			return 0U;
		}

		// Token: 0x0600ABE8 RID: 44008 RVA: 0x0002F478 File Offset: 0x0002D678
		[Token(Token = "0x600ABE8")]
		[Address(RVA = "0x2319934", Offset = "0x2319934", VA = "0x7BBCB19934")]
		public uint GetLimitPurchaseCount(uint chestID, UIModelGacha.GachaDrawType type)
		{
			return 0U;
		}

		// Token: 0x0600ABE9 RID: 44009 RVA: 0x0002F490 File Offset: 0x0002D690
		[Token(Token = "0x600ABE9")]
		[Address(RVA = "0x23197D8", Offset = "0x23197D8", VA = "0x7BBCB197D8")]
		public uint GetLimitPurchaseCurCount(uint chestID, UIModelGacha.GachaDrawType type)
		{
			return 0U;
		}

		// Token: 0x0600ABEA RID: 44010 RVA: 0x0002F4A8 File Offset: 0x0002D6A8
		[Token(Token = "0x600ABEA")]
		[Address(RVA = "0x2315890", Offset = "0x2315890", VA = "0x7BBCB15890")]
		public uint GetEnergyPoint(uint chestID)
		{
			return 0U;
		}

		// Token: 0x0600ABEB RID: 44011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABEB")]
		[Address(RVA = "0x2319FCC", Offset = "0x2319FCC", VA = "0x7BBCB19FCC")]
		public List<uint> GetEnergyRange(uint chestID)
		{
			return null;
		}

		// Token: 0x0600ABEC RID: 44012 RVA: 0x0002F4C0 File Offset: 0x0002D6C0
		[Token(Token = "0x600ABEC")]
		[Address(RVA = "0x231A0FC", Offset = "0x231A0FC", VA = "0x7BBCB1A0FC")]
		public uint GetFirstDrawRewardCount(uint chestID)
		{
			return 0U;
		}

		// Token: 0x0600ABED RID: 44013 RVA: 0x0002F4D8 File Offset: 0x0002D6D8
		[Token(Token = "0x600ABED")]
		[Address(RVA = "0x231A16C", Offset = "0x231A16C", VA = "0x7BBCB1A16C")]
		public UIModelGacha.ChestHintColor GetHintColor(uint chestID)
		{
			return UIModelGacha.ChestHintColor.WHITE;
		}

		// Token: 0x0600ABEE RID: 44014 RVA: 0x0002F4F0 File Offset: 0x0002D6F0
		[Token(Token = "0x600ABEE")]
		[Address(RVA = "0x231A1B0", Offset = "0x231A1B0", VA = "0x7BBCB1A1B0")]
		public UIModelGacha.LotteryTheme GetLotteryTheme(uint chestID)
		{
			return (UIModelGacha.LotteryTheme)0;
		}

		// Token: 0x0600ABEF RID: 44015 RVA: 0x0002F508 File Offset: 0x0002D708
		[Token(Token = "0x600ABEF")]
		[Address(RVA = "0x2319B24", Offset = "0x2319B24", VA = "0x7BBCB19B24")]
		public bool IsInDiscountPeriod(uint chestID)
		{
			return default(bool);
		}

		// Token: 0x0600ABF0 RID: 44016 RVA: 0x0002F520 File Offset: 0x0002D720
		[Token(Token = "0x600ABF0")]
		[Address(RVA = "0x2319678", Offset = "0x2319678", VA = "0x7BBCB19678")]
		public bool IsInLimitPeriod(uint chestID)
		{
			return default(bool);
		}

		// Token: 0x0600ABF1 RID: 44017 RVA: 0x0002F538 File Offset: 0x0002D738
		[Token(Token = "0x600ABF1")]
		[Address(RVA = "0x231A35C", Offset = "0x231A35C", VA = "0x7BBCB1A35C")]
		public bool IsInDropUpPeriod(uint chestID)
		{
			return default(bool);
		}

		// Token: 0x0600ABF2 RID: 44018 RVA: 0x0002F550 File Offset: 0x0002D750
		[Token(Token = "0x600ABF2")]
		[Address(RVA = "0x231A3AC", Offset = "0x231A3AC", VA = "0x7BBCB1A3AC")]
		public bool IsOpenFirstReward(uint chestID)
		{
			return default(bool);
		}

		// Token: 0x0600ABF3 RID: 44019 RVA: 0x0002F568 File Offset: 0x0002D768
		[Token(Token = "0x600ABF3")]
		[Address(RVA = "0x2315900", Offset = "0x2315900", VA = "0x7BBCB15900")]
		public uint GetLimitNum(uint chestID)
		{
			return 0U;
		}

		// Token: 0x0600ABF4 RID: 44020 RVA: 0x0002F580 File Offset: 0x0002D780
		[Token(Token = "0x600ABF4")]
		[Address(RVA = "0x231A3F8", Offset = "0x231A3F8", VA = "0x7BBCB1A3F8")]
		public UIModelGacha.LimitResetType GetLimitResetType(uint chestID)
		{
			return UIModelGacha.LimitResetType.NONE;
		}

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x0002F598 File Offset: 0x0002D798
		[Token(Token = "0x600ABF5")]
		[Address(RVA = "0x231A43C", Offset = "0x231A43C", VA = "0x7BBCB1A43C")]
		public uint GetExchangeNeedCouponCount(uint chestID, UIModelGacha.GachaDrawType type)
		{
			return 0U;
		}

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x0002F5B0 File Offset: 0x0002D7B0
		[Token(Token = "0x600ABF6")]
		[Address(RVA = "0x231A49C", Offset = "0x231A49C", VA = "0x7BBCB1A49C")]
		public EInventory.CurrencyType GetCurrencyType(uint chestID)
		{
			return EInventory.CurrencyType.CurrencyType_NONE;
		}

		// Token: 0x0600ABF7 RID: 44023 RVA: 0x0002F5C8 File Offset: 0x0002D7C8
		[Token(Token = "0x600ABF7")]
		[Address(RVA = "0x231A4E0", Offset = "0x231A4E0", VA = "0x7BBCB1A4E0")]
		public ulong GetGachaEndTime(uint chestID)
		{
			return 0UL;
		}

		// Token: 0x0600ABF8 RID: 44024 RVA: 0x0002F5E0 File Offset: 0x0002D7E0
		[Token(Token = "0x600ABF8")]
		[Address(RVA = "0x231A524", Offset = "0x231A524", VA = "0x7BBCB1A524")]
		public bool CheckIsCurrencyEnough(uint chestID, UIModelGacha.GachaDrawType type)
		{
			return default(bool);
		}

		// Token: 0x0600ABF9 RID: 44025 RVA: 0x0002F5F8 File Offset: 0x0002D7F8
		[Token(Token = "0x600ABF9")]
		[Address(RVA = "0x231A690", Offset = "0x231A690", VA = "0x7BBCB1A690")]
		public bool CheckIsPriceFreeByID(uint chestID)
		{
			return default(bool);
		}

		// Token: 0x0600ABFA RID: 44026 RVA: 0x0002F610 File Offset: 0x0002D810
		[Token(Token = "0x600ABFA")]
		[Address(RVA = "0x231A7CC", Offset = "0x231A7CC", VA = "0x7BBCB1A7CC")]
		public bool CheckIsLimitCDFreeById(uint chestID)
		{
			return default(bool);
		}

		// Token: 0x0600ABFB RID: 44027 RVA: 0x0002F628 File Offset: 0x0002D828
		[Token(Token = "0x600ABFB")]
		[Address(RVA = "0x231A8B4", Offset = "0x231A8B4", VA = "0x7BBCB1A8B4")]
		public bool HasFreeGacha()
		{
			return default(bool);
		}

		// Token: 0x0600ABFC RID: 44028 RVA: 0x0002F640 File Offset: 0x0002D840
		[Token(Token = "0x600ABFC")]
		[Address(RVA = "0x231AA28", Offset = "0x231AA28", VA = "0x7BBCB1AA28")]
		public bool HasNewGacha()
		{
			return default(bool);
		}

		// Token: 0x0600ABFD RID: 44029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABFD")]
		[Address(RVA = "0x231ADA0", Offset = "0x231ADA0", VA = "0x7BBCB1ADA0")]
		public void UpdateCacheGachaIdSubIds()
		{
		}

		// Token: 0x0600ABFE RID: 44030 RVA: 0x0002F658 File Offset: 0x0002D858
		[Token(Token = "0x600ABFE")]
		[Address(RVA = "0x231B0CC", Offset = "0x231B0CC", VA = "0x7BBCB1B0CC")]
		public bool IsHasFreeGacha(uint chestID)
		{
			return default(bool);
		}

		// Token: 0x0600ABFF RID: 44031 RVA: 0x0002F670 File Offset: 0x0002D870
		[Token(Token = "0x600ABFF")]
		[Address(RVA = "0x231B154", Offset = "0x231B154", VA = "0x7BBCB1B154")]
		public bool IsCfgExtraReward(uint chestID)
		{
			return default(bool);
		}

		// Token: 0x0600AC00 RID: 44032 RVA: 0x0002F688 File Offset: 0x0002D888
		[Token(Token = "0x600AC00")]
		[Address(RVA = "0x231B1D8", Offset = "0x231B1D8", VA = "0x7BBCB1B1D8")]
		public ResourceID GetPropIconRes(uint chestID)
		{
			return default(ResourceID);
		}

		// Token: 0x0600AC01 RID: 44033 RVA: 0x0002F6A0 File Offset: 0x0002D8A0
		[Token(Token = "0x600AC01")]
		[Address(RVA = "0x231B420", Offset = "0x231B420", VA = "0x7BBCB1B420")]
		public uint GetPropConsumeCnt(uint chestID, UIModelGacha.GachaDrawType type)
		{
			return 0U;
		}

		// Token: 0x0600AC02 RID: 44034 RVA: 0x0002F6B8 File Offset: 0x0002D8B8
		[Token(Token = "0x600AC02")]
		[Address(RVA = "0x231A2C4", Offset = "0x231A2C4", VA = "0x7BBCB1A2C4")]
		private bool IsInTimePeriod(ulong begin, ulong end)
		{
			return default(bool);
		}

		// Token: 0x0600AC03 RID: 44035 RVA: 0x0002F6D0 File Offset: 0x0002D8D0
		[Token(Token = "0x600AC03")]
		[Address(RVA = "0x23189A4", Offset = "0x23189A4", VA = "0x7BBCB189A4")]
		private uint GetPropsCntByID(uint id)
		{
			return 0U;
		}

		// Token: 0x0600AC04 RID: 44036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC04")]
		[Address(RVA = "0x2319068", Offset = "0x2319068", VA = "0x7BBCB19068")]
		private void SetPropsCntByID(uint id, uint value)
		{
		}

		// Token: 0x0600AC05 RID: 44037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC05")]
		[Address(RVA = "0x23194E0", Offset = "0x23194E0", VA = "0x7BBCB194E0")]
		public GachaInfo GetGachaInfo(uint chestID)
		{
			return null;
		}

		// Token: 0x0600AC06 RID: 44038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC06")]
		public T GetGachaPackageInfo<T>(uint gachaID) where T : GachaInfoDataBase
		{
			return null;
		}

		// Token: 0x0600AC07 RID: 44039 RVA: 0x0002F6E8 File Offset: 0x0002D8E8
		[Token(Token = "0x600AC07")]
		[Address(RVA = "0x231B480", Offset = "0x231B480", VA = "0x7BBCB1B480")]
		public int ChestID2ForgeTabID(uint chestID)
		{
			return 0;
		}

		// Token: 0x0600AC08 RID: 44040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC08")]
		[Address(RVA = "0x2318608", Offset = "0x2318608", VA = "0x7BBCB18608")]
		public GachaShowItem GetGachaShowItemInfo(uint chestID, uint itmID, uint rewardPoolID = 0U, uint duration = 0U)
		{
			return null;
		}

		// Token: 0x0600AC09 RID: 44041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC09")]
		[Address(RVA = "0x231B4D4", Offset = "0x231B4D4", VA = "0x7BBCB1B4D4")]
		public GachaShowItem GetGachaShowItemInfoByID(uint chestID, uint itmID, uint rewardPoolID = 0U)
		{
			return null;
		}

		// Token: 0x0600AC0A RID: 44042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC0A")]
		[Address(RVA = "0x2315D4C", Offset = "0x2315D4C", VA = "0x7BBCB15D4C")]
		public List<GachaShowItem> GetGachaShowItemInfoList(uint chestID, uint rewardPoolID = 0U)
		{
			return null;
		}

		// Token: 0x0600AC0B RID: 44043 RVA: 0x0002F700 File Offset: 0x0002D900
		[Token(Token = "0x600AC0B")]
		[Address(RVA = "0x2316B54", Offset = "0x2316B54", VA = "0x7BBCB16B54")]
		public bool GachaDescHasData()
		{
			return default(bool);
		}

		// Token: 0x0600AC0C RID: 44044 RVA: 0x0002F718 File Offset: 0x0002D918
		[Token(Token = "0x600AC0C")]
		[Address(RVA = "0x231B670", Offset = "0x231B670", VA = "0x7BBCB1B670")]
		public bool GachaSpEchDescHasData()
		{
			return default(bool);
		}

		// Token: 0x0600AC0D RID: 44045 RVA: 0x0002F730 File Offset: 0x0002D930
		[Token(Token = "0x600AC0D")]
		[Address(RVA = "0x23178BC", Offset = "0x23178BC", VA = "0x7BBCB178BC")]
		public bool GachaInfoHasData()
		{
			return default(bool);
		}

		// Token: 0x0600AC0E RID: 44046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC0E")]
		[Address(RVA = "0x231B6EC", Offset = "0x231B6EC", VA = "0x7BBCB1B6EC")]
		public List<ChestSpecialExchangeDesc> GetGachaSpDescList(uint forgeTabID)
		{
			return null;
		}

		// Token: 0x0600AC0F RID: 44047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC0F")]
		[Address(RVA = "0x231B7F0", Offset = "0x231B7F0", VA = "0x7BBCB1B7F0")]
		public ChestSpecialExchangeDesc FindChestSpecialExchangeDesc(uint forgeTabID, uint itemID)
		{
			return null;
		}

		// Token: 0x0600AC10 RID: 44048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC10")]
		[Address(RVA = "0x231B8D4", Offset = "0x231B8D4", VA = "0x7BBCB1B8D4")]
		public Dictionary<uint, GachaSpDescData> GetGachaSpDescDict()
		{
			return null;
		}

		// Token: 0x0600AC11 RID: 44049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC11")]
		[Address(RVA = "0x23163C0", Offset = "0x23163C0", VA = "0x7BBCB163C0")]
		public GachaDesc GetGachaDesc(uint chestID)
		{
			return null;
		}

		// Token: 0x0600AC12 RID: 44050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC12")]
		[Address(RVA = "0x231B900", Offset = "0x231B900", VA = "0x7BBCB1B900")]
		public GachaDesc GetSortedGachaDesc(int index)
		{
			return null;
		}

		// Token: 0x0600AC13 RID: 44051 RVA: 0x0002F748 File Offset: 0x0002D948
		[Token(Token = "0x600AC13")]
		[Address(RVA = "0x231B9C0", Offset = "0x231B9C0", VA = "0x7BBCB1B9C0")]
		public int FindGachaIdListIdx(uint chestID)
		{
			return 0;
		}

		// Token: 0x0600AC14 RID: 44052 RVA: 0x0002F760 File Offset: 0x0002D960
		[Token(Token = "0x600AC14")]
		[Address(RVA = "0x231BA98", Offset = "0x231BA98", VA = "0x7BBCB1BA98")]
		public bool CheckAwardInGacha(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AC15 RID: 44053 RVA: 0x0002F778 File Offset: 0x0002D978
		[Token(Token = "0x600AC15")]
		[Address(RVA = "0x231BE18", Offset = "0x231BE18", VA = "0x7BBCB1BE18")]
		public bool IsItemOwned(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AC16 RID: 44054 RVA: 0x0002F790 File Offset: 0x0002D990
		[Token(Token = "0x600AC16")]
		[Address(RVA = "0x231C0F4", Offset = "0x231C0F4", VA = "0x7BBCB1C0F4")]
		public int CompareLotteryItem(GachaShowItem a, GachaShowItem b)
		{
			return 0;
		}

		// Token: 0x0600AC17 RID: 44055 RVA: 0x0002F7A8 File Offset: 0x0002D9A8
		[Token(Token = "0x600AC17")]
		[Address(RVA = "0x231C18C", Offset = "0x231C18C", VA = "0x7BBCB1C18C")]
		private int CalcLotteryItemSortWeight(GachaShowItem item)
		{
			return 0;
		}

		// Token: 0x0600AC18 RID: 44056 RVA: 0x0002F7C0 File Offset: 0x0002D9C0
		[Token(Token = "0x600AC18")]
		[Address(RVA = "0x231C280", Offset = "0x231C280", VA = "0x7BBCB1C280")]
		private int GetLotteryItemSortTypeWeight(CSSharedItemData baseitem)
		{
			return 0;
		}

		// Token: 0x0600AC19 RID: 44057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC19")]
		[Address(RVA = "0x231C314", Offset = "0x231C314", VA = "0x7BBCB1C314")]
		private string _NotifyUrl(params object[] parameters)
		{
			return null;
		}

		// Token: 0x0600AC1A RID: 44058 RVA: 0x0002F7D8 File Offset: 0x0002D9D8
		[Token(Token = "0x600AC1A")]
		[Address(RVA = "0x231C374", Offset = "0x231C374", VA = "0x7BBCB1C374")]
		private int _NotifyMaxRandomDelay_MS()
		{
			return 0;
		}

		// Token: 0x0600AC1B RID: 44059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC1B")]
		[Address(RVA = "0x231C3E4", Offset = "0x231C3E4", VA = "0x7BBCB1C3E4")]
		private LocalNotificationManager.NotifyInfo GetNotifyInfo(LocalNotificationManager.NotifyType type, GachaDesc gachaDesc)
		{
			return null;
		}

		// Token: 0x0600AC1C RID: 44060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC1C")]
		[Address(RVA = "0x2314004", Offset = "0x2314004", VA = "0x7BBCB14004")]
		private void UpdateNotifies()
		{
		}

		// Token: 0x0600AC1D RID: 44061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC1D")]
		[Address(RVA = "0x231C6EC", Offset = "0x231C6EC", VA = "0x7BBCB1C6EC")]
		public void RequestGetEnergyGachaBuffInfo(uint gachaID)
		{
		}

		// Token: 0x0600AC1E RID: 44062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC1E")]
		[Address(RVA = "0x231C900", Offset = "0x231C900", VA = "0x7BBCB1C900")]
		public void RequestRefreshEnergyGachaBuffInfo(uint gachaID)
		{
		}

		// Token: 0x0600AC1F RID: 44063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC1F")]
		[Address(RVA = "0x231CB14", Offset = "0x231CB14", VA = "0x7BBCB1CB14")]
		public void RequestLegendaryGachaGainItems(uint gachaID, uint[] itemsIDs)
		{
		}

		// Token: 0x0600AC20 RID: 44064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC20")]
		[Address(RVA = "0x231CDB0", Offset = "0x231CDB0", VA = "0x7BBCB1CDB0")]
		public void RequestLegendaryGachaRerandomItems(uint gachaID, uint[] itemsIDs)
		{
		}

		// Token: 0x0600AC21 RID: 44065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC21")]
		[Address(RVA = "0x231D04C", Offset = "0x231D04C", VA = "0x7BBCB1D04C")]
		public ClientChestType GetClientChestTypeByID(uint gachaID)
		{
			return null;
		}

		// Token: 0x0600AC22 RID: 44066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC22")]
		[Address(RVA = "0x231D084", Offset = "0x231D084", VA = "0x7BBCB1D084")]
		public UIModelGacha()
		{
		}

		// Token: 0x0600AC23 RID: 44067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC23")]
		[Address(RVA = "0x231D1EC", Offset = "0x231D1EC", VA = "0x7BBCB1D1EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114634C", Offset = "0x114634C")]
		private void <RequestGachaDescRes>b__87_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AC24 RID: 44068 RVA: 0x0002F7F0 File Offset: 0x0002D9F0
		[Token(Token = "0x600AC24")]
		[Address(RVA = "0x231D2D4", Offset = "0x231D2D4", VA = "0x7BBCB1D2D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114635C", Offset = "0x114635C")]
		private int <ProcessGachaDes>b__88_0(uint idA, uint idB)
		{
			return 0;
		}

		// Token: 0x0600AC25 RID: 44069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC25")]
		[Address(RVA = "0x231D46C", Offset = "0x231D46C", VA = "0x7BBCB1D46C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114636C", Offset = "0x114636C")]
		private void <RequestGachaSpecialExchangeDesc>b__90_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B080 RID: 45184
		[Token(Token = "0x400B080")]
		[FieldOffset(Offset = "0x18")]
		private UIDataModelGacha m_DataModel;

		// Token: 0x0400B081 RID: 45185
		[Token(Token = "0x400B081")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113002C", Offset = "0x113002C")]
		private bool <NoShowConfirmWnd>k__BackingField;

		// Token: 0x0400B082 RID: 45186
		[Token(Token = "0x400B082")]
		[FieldOffset(Offset = "0x21")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113003C", Offset = "0x113003C")]
		private bool <NoShowLengendaryBagPackGainConfirmWnd>k__BackingField;

		// Token: 0x0400B083 RID: 45187
		[Token(Token = "0x400B083")]
		[FieldOffset(Offset = "0x22")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113004C", Offset = "0x113004C")]
		private bool <NoShowLengendaryBagPackReRandomConfirmWnd>k__BackingField;

		// Token: 0x0400B084 RID: 45188
		[Token(Token = "0x400B084")]
		[FieldOffset(Offset = "0x28")]
		private List<uint> m_GachaSortedIDs;

		// Token: 0x0400B085 RID: 45189
		[Token(Token = "0x400B085")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, bool> m_IsResetEPDict;

		// Token: 0x0400B086 RID: 45190
		[Token(Token = "0x400B086")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<uint, List<RareProbability>> m_GachaRareProbability;

		// Token: 0x0400B087 RID: 45191
		[Token(Token = "0x400B087")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<uint, UIGachaSceneShowType> m_CurrentShowTypeDic;

		// Token: 0x0400B088 RID: 45192
		[Token(Token = "0x400B088")]
		[FieldOffset(Offset = "0x48")]
		private List<uint> m_RemoveItems;

		// Token: 0x0400B089 RID: 45193
		[Token(Token = "0x400B089")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<uint, List<uint>> m_RemoveItemsDic;

		// Token: 0x0400B08A RID: 45194
		[Token(Token = "0x400B08A")]
		[FieldOffset(Offset = "0x58")]
		private List<uint> m_TempBagSelectedItems;

		// Token: 0x0400B08B RID: 45195
		[Token(Token = "0x400B08B")]
		public const uint GACHALIMIT_REMOVE_COUNT = 2U;

		// Token: 0x0400B08C RID: 45196
		[Token(Token = "0x400B08C")]
		public const uint GACHALIMIT_ALL_COUNT = 10U;

		// Token: 0x0400B08D RID: 45197
		[Token(Token = "0x400B08D")]
		public const int MAXITEMNUMCANSELECT = 99;

		// Token: 0x0400B08E RID: 45198
		[Token(Token = "0x400B08E")]
		public const int MAXITEMNUMINPACKAGE = 99;

		// Token: 0x0400B08F RID: 45199
		[Token(Token = "0x400B08F")]
		[FieldOffset(Offset = "0x60")]
		private CSGetGachaInfoRes m_InfoRes;

		// Token: 0x0400B090 RID: 45200
		[Token(Token = "0x400B090")]
		[FieldOffset(Offset = "0x68")]
		private UIModelGacha.GachaCachePrefs m_CacheGachaPrefs;

		// Token: 0x0400B091 RID: 45201
		[Token(Token = "0x400B091")]
		private const string Prefs_CacheGachaIdSubIds = "CacheGachaIdSubIds";

		// Token: 0x0400B092 RID: 45202
		[Token(Token = "0x400B092")]
		private const string m_GachaAnimPrefix = "GACHA_FULLSCREEN_ANIM";

		// Token: 0x0400B093 RID: 45203
		[Token(Token = "0x400B093")]
		public const uint PropID_GachaAds_Update = 16U;

		// Token: 0x0400B094 RID: 45204
		[Token(Token = "0x400B094")]
		public const uint PropID_GachaInfo_Update = 32U;

		// Token: 0x0400B095 RID: 45205
		[Token(Token = "0x400B095")]
		public const uint PropID_PurchaseSuccess = 64U;

		// Token: 0x0400B096 RID: 45206
		[Token(Token = "0x400B096")]
		public const uint PropID_GachaDesc_Update = 128U;

		// Token: 0x0400B097 RID: 45207
		[Token(Token = "0x400B097")]
		public const uint PropID_NoGachaData = 256U;

		// Token: 0x0400B098 RID: 45208
		[Token(Token = "0x400B098")]
		public const uint PropID_PurchaseFailed = 512U;

		// Token: 0x0400B099 RID: 45209
		[Token(Token = "0x400B099")]
		public const uint PropID_Gacha_Probability_Getted = 1024U;

		// Token: 0x0400B09A RID: 45210
		[Token(Token = "0x400B09A")]
		public const uint PropID_GachaSpDesc_Update = 2048U;

		// Token: 0x0400B09B RID: 45211
		[Token(Token = "0x400B09B")]
		public const uint PropID_GachaSpExchange_Success = 4096U;

		// Token: 0x0400B09C RID: 45212
		[Token(Token = "0x400B09C")]
		public const uint PropID_ShouldNotifyChange = 8192U;

		// Token: 0x0400B09D RID: 45213
		[Token(Token = "0x400B09D")]
		public const uint PropID_PurchaseBuffSuccess = 16384U;

		// Token: 0x0400B09E RID: 45214
		[Token(Token = "0x400B09E")]
		public const uint PropID_SpicalDrawDataUpdate = 32768U;

		// Token: 0x0400B09F RID: 45215
		[Token(Token = "0x400B09F")]
		public const uint PropID_GachaLimitPoolStateUpdate = 65536U;

		// Token: 0x0400B0A0 RID: 45216
		[Token(Token = "0x400B0A0")]
		public const uint PropID_GachaRefreshEnergyBuff = 131072U;

		// Token: 0x0400B0A1 RID: 45217
		[Token(Token = "0x400B0A1")]
		public const uint PropID_GachaGainBagItems = 262144U;

		// Token: 0x0400B0A2 RID: 45218
		[Token(Token = "0x400B0A2")]
		public const uint PropID_GachaReRandomBagItems = 524288U;

		// Token: 0x02001E9A RID: 7834
		[Token(Token = "0x2001E9A")]
		private class GachaCachePref
		{
			// Token: 0x0600AC26 RID: 44070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC26")]
			[Address(RVA = "0x231B0C4", Offset = "0x231B0C4", VA = "0x7BBCB1B0C4")]
			public GachaCachePref()
			{
			}

			// Token: 0x0400B0A3 RID: 45219
			[Token(Token = "0x400B0A3")]
			[FieldOffset(Offset = "0x10")]
			public uint id;

			// Token: 0x0400B0A4 RID: 45220
			[Token(Token = "0x400B0A4")]
			[FieldOffset(Offset = "0x14")]
			public uint subId;
		}

		// Token: 0x02001E9B RID: 7835
		[Token(Token = "0x2001E9B")]
		private class GachaCachePrefs
		{
			// Token: 0x0600AC27 RID: 44071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC27")]
			[Address(RVA = "0x23168DC", Offset = "0x23168DC", VA = "0x7BBCB168DC")]
			public GachaCachePrefs()
			{
			}

			// Token: 0x0400B0A5 RID: 45221
			[Token(Token = "0x400B0A5")]
			[FieldOffset(Offset = "0x10")]
			public List<UIModelGacha.GachaCachePref> gachaCaches;
		}

		// Token: 0x02001E9C RID: 7836
		[Token(Token = "0x2001E9C")]
		private enum GachaAnimState
		{
			// Token: 0x0400B0A7 RID: 45223
			[Token(Token = "0x400B0A7")]
			NO_PLAYED,
			// Token: 0x0400B0A8 RID: 45224
			[Token(Token = "0x400B0A8")]
			PLAYERD
		}

		// Token: 0x02001E9D RID: 7837
		[Token(Token = "0x2001E9D")]
		private enum GachaFreeType
		{
			// Token: 0x0400B0AA RID: 45226
			[Token(Token = "0x400B0AA")]
			Free = 1
		}

		// Token: 0x02001E9E RID: 7838
		[Token(Token = "0x2001E9E")]
		public enum GachaActivityType
		{
			// Token: 0x0400B0AC RID: 45228
			[Token(Token = "0x400B0AC")]
			NONE,
			// Token: 0x0400B0AD RID: 45229
			[Token(Token = "0x400B0AD")]
			ACTIVITY_TYPE1,
			// Token: 0x0400B0AE RID: 45230
			[Token(Token = "0x400B0AE")]
			ACTIVITY_TYPE2
		}

		// Token: 0x02001E9F RID: 7839
		[Token(Token = "0x2001E9F")]
		public enum LotteryTheme
		{
			// Token: 0x0400B0B0 RID: 45232
			[Token(Token = "0x400B0B0")]
			THEME1 = 1,
			// Token: 0x0400B0B1 RID: 45233
			[Token(Token = "0x400B0B1")]
			THEME2
		}

		// Token: 0x02001EA0 RID: 7840
		[Token(Token = "0x2001EA0")]
		public enum GachaDrawType
		{
			// Token: 0x0400B0B3 RID: 45235
			[Token(Token = "0x400B0B3")]
			TYPE_NONE,
			// Token: 0x0400B0B4 RID: 45236
			[Token(Token = "0x400B0B4")]
			TYPE_SINGLE,
			// Token: 0x0400B0B5 RID: 45237
			[Token(Token = "0x400B0B5")]
			TYPE_MULTI,
			// Token: 0x0400B0B6 RID: 45238
			[Token(Token = "0x400B0B6")]
			TYPE_BUFF_BUY,
			// Token: 0x0400B0B7 RID: 45239
			[Token(Token = "0x400B0B7")]
			TYPE_BUFF_REFRESH,
			// Token: 0x0400B0B8 RID: 45240
			[Token(Token = "0x400B0B8")]
			TYPE_RERANDOM
		}

		// Token: 0x02001EA1 RID: 7841
		[Token(Token = "0x2001EA1")]
		public enum ChestHintColor
		{
			// Token: 0x0400B0BA RID: 45242
			[Token(Token = "0x400B0BA")]
			WHITE,
			// Token: 0x0400B0BB RID: 45243
			[Token(Token = "0x400B0BB")]
			BLACK
		}

		// Token: 0x02001EA2 RID: 7842
		[Token(Token = "0x2001EA2")]
		public enum LimitResetType
		{
			// Token: 0x0400B0BD RID: 45245
			[Token(Token = "0x400B0BD")]
			NONE,
			// Token: 0x0400B0BE RID: 45246
			[Token(Token = "0x400B0BE")]
			DAILY,
			// Token: 0x0400B0BF RID: 45247
			[Token(Token = "0x400B0BF")]
			TERM
		}

		// Token: 0x02001EA3 RID: 7843
		[Token(Token = "0x2001EA3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC994", Offset = "0x10FC994")]
		private sealed class <>c__DisplayClass65_0
		{
			// Token: 0x0600AC28 RID: 44072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC28")]
			[Address(RVA = "0x2315230", Offset = "0x2315230", VA = "0x7BBCB15230")]
			public <>c__DisplayClass65_0()
			{
			}

			// Token: 0x0600AC29 RID: 44073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC29")]
			[Address(RVA = "0x231E7C8", Offset = "0x231E7C8", VA = "0x7BBCB1E7C8")]
			internal void <RequestRemoveGachaLimitItems>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B0C0 RID: 45248
			[Token(Token = "0x400B0C0")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGacha <>4__this;

			// Token: 0x0400B0C1 RID: 45249
			[Token(Token = "0x400B0C1")]
			[FieldOffset(Offset = "0x18")]
			public uint gachaID;

			// Token: 0x0400B0C2 RID: 45250
			[Token(Token = "0x400B0C2")]
			[FieldOffset(Offset = "0x20")]
			public List<uint> removeItems;
		}

		// Token: 0x02001EA4 RID: 7844
		[Token(Token = "0x2001EA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC9A4", Offset = "0x10FC9A4")]
		private sealed class <>c__DisplayClass91_0
		{
			// Token: 0x0600AC2A RID: 44074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC2A")]
			[Address(RVA = "0x2317480", Offset = "0x2317480", VA = "0x7BBCB17480")]
			public <>c__DisplayClass91_0()
			{
			}

			// Token: 0x0600AC2B RID: 44075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC2B")]
			[Address(RVA = "0x231E984", Offset = "0x231E984", VA = "0x7BBCB1E984")]
			internal void <RequestDoGachaSpecialExchange>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600AC2C RID: 44076 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AC2C")]
			[Address(RVA = "0x231ED48", Offset = "0x231ED48", VA = "0x7BBCB1ED48")]
			internal CommonRewardItemInfo <RequestDoGachaSpecialExchange>b__1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0400B0C3 RID: 45251
			[Token(Token = "0x400B0C3")]
			[FieldOffset(Offset = "0x10")]
			public ChestSpecialExchangeDesc exchangeDes;

			// Token: 0x0400B0C4 RID: 45252
			[Token(Token = "0x400B0C4")]
			[FieldOffset(Offset = "0x18")]
			public UIModelGacha <>4__this;

			// Token: 0x0400B0C5 RID: 45253
			[Token(Token = "0x400B0C5")]
			[FieldOffset(Offset = "0x20")]
			public Converter<BaseItemInfo, CommonRewardItemInfo> <>9__1;
		}

		// Token: 0x02001EA5 RID: 7845
		[Token(Token = "0x2001EA5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC9B4", Offset = "0x10FC9B4")]
		private sealed class <>c__DisplayClass93_0
		{
			// Token: 0x0600AC2D RID: 44077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC2D")]
			[Address(RVA = "0x23178B4", Offset = "0x23178B4", VA = "0x7BBCB178B4")]
			public <>c__DisplayClass93_0()
			{
			}

			// Token: 0x0600AC2E RID: 44078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC2E")]
			[Address(RVA = "0x231EDA8", Offset = "0x231EDA8", VA = "0x7BBCB1EDA8")]
			internal void <RequestGachaInfoRes>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B0C6 RID: 45254
			[Token(Token = "0x400B0C6")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGacha <>4__this;

			// Token: 0x0400B0C7 RID: 45255
			[Token(Token = "0x400B0C7")]
			[FieldOffset(Offset = "0x18")]
			public bool isSpecial;
		}

		// Token: 0x02001EA6 RID: 7846
		[Token(Token = "0x2001EA6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC9C4", Offset = "0x10FC9C4")]
		private sealed class <>c__DisplayClass94_0
		{
			// Token: 0x0600AC2F RID: 44079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC2F")]
			[Address(RVA = "0x2317C14", Offset = "0x2317C14", VA = "0x7BBCB17C14")]
			public <>c__DisplayClass94_0()
			{
			}

			// Token: 0x0600AC30 RID: 44080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC30")]
			[Address(RVA = "0x231F54C", Offset = "0x231F54C", VA = "0x7BBCB1F54C")]
			internal void <RequestGachaProbability>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B0C8 RID: 45256
			[Token(Token = "0x400B0C8")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGacha <>4__this;

			// Token: 0x0400B0C9 RID: 45257
			[Token(Token = "0x400B0C9")]
			[FieldOffset(Offset = "0x18")]
			public uint gachaId;
		}

		// Token: 0x02001EA7 RID: 7847
		[Token(Token = "0x2001EA7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC9D4", Offset = "0x10FC9D4")]
		private sealed class <>c__DisplayClass95_0
		{
			// Token: 0x0600AC31 RID: 44081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC31")]
			[Address(RVA = "0x2317EEC", Offset = "0x2317EEC", VA = "0x7BBCB17EEC")]
			public <>c__DisplayClass95_0()
			{
			}

			// Token: 0x0600AC32 RID: 44082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC32")]
			[Address(RVA = "0x231F710", Offset = "0x231F710", VA = "0x7BBCB1F710")]
			internal void <ExchangeGachaExtraReward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B0CA RID: 45258
			[Token(Token = "0x400B0CA")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGacha <>4__this;

			// Token: 0x0400B0CB RID: 45259
			[Token(Token = "0x400B0CB")]
			[FieldOffset(Offset = "0x18")]
			public CSLotteryExtraRewardReq req;

			// Token: 0x0400B0CC RID: 45260
			[Token(Token = "0x400B0CC")]
			[FieldOffset(Offset = "0x20")]
			public uint chestID;

			// Token: 0x0400B0CD RID: 45261
			[Token(Token = "0x400B0CD")]
			[FieldOffset(Offset = "0x24")]
			public uint condition_num;
		}

		// Token: 0x02001EA8 RID: 7848
		[Token(Token = "0x2001EA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC9E4", Offset = "0x10FC9E4")]
		private sealed class <>c__DisplayClass96_0
		{
			// Token: 0x0600AC33 RID: 44083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC33")]
			[Address(RVA = "0x23182AC", Offset = "0x23182AC", VA = "0x7BBCB182AC")]
			public <>c__DisplayClass96_0()
			{
			}

			// Token: 0x0600AC34 RID: 44084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC34")]
			[Address(RVA = "0x231FA2C", Offset = "0x231FA2C", VA = "0x7BBCB1FA2C")]
			internal void <Purchase>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B0CE RID: 45262
			[Token(Token = "0x400B0CE")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGacha <>4__this;

			// Token: 0x0400B0CF RID: 45263
			[Token(Token = "0x400B0CF")]
			[FieldOffset(Offset = "0x18")]
			public uint chestID;

			// Token: 0x0400B0D0 RID: 45264
			[Token(Token = "0x400B0D0")]
			[FieldOffset(Offset = "0x1C")]
			public UIModelGacha.GachaDrawType drawType;

			// Token: 0x0400B0D1 RID: 45265
			[Token(Token = "0x400B0D1")]
			[FieldOffset(Offset = "0x20")]
			public uint jackpotID;

			// Token: 0x0400B0D2 RID: 45266
			[Token(Token = "0x400B0D2")]
			[FieldOffset(Offset = "0x28")]
			public CSLotteryReq req;

			// Token: 0x0400B0D3 RID: 45267
			[Token(Token = "0x400B0D3")]
			[FieldOffset(Offset = "0x30")]
			public bool isRepurchase;
		}

		// Token: 0x02001EA9 RID: 7849
		[Token(Token = "0x2001EA9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC9F4", Offset = "0x10FC9F4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600AC36 RID: 44086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC36")]
			[Address(RVA = "0x231D6FC", Offset = "0x231D6FC", VA = "0x7BBCB1D6FC")]
			public <>c()
			{
			}

			// Token: 0x0600AC37 RID: 44087 RVA: 0x0002F808 File Offset: 0x0002DA08
			[Token(Token = "0x600AC37")]
			[Address(RVA = "0x231D704", Offset = "0x231D704", VA = "0x7BBCB1D704")]
			internal int <GetCouponItemsInfo>b__101_0(CSSharedItemData a, CSSharedItemData b)
			{
				return 0;
			}

			// Token: 0x0600AC38 RID: 44088 RVA: 0x0002F820 File Offset: 0x0002DA20
			[Token(Token = "0x600AC38")]
			[Address(RVA = "0x231D84C", Offset = "0x231D84C", VA = "0x7BBCB1D84C")]
			internal int <IsExtralRewardExchanged>b__106_0(ExtraRewardDesc item)
			{
				return 0;
			}

			// Token: 0x0600AC39 RID: 44089 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AC39")]
			[Address(RVA = "0x231D878", Offset = "0x231D878", VA = "0x7BBCB1D878")]
			internal CommonRewardItemInfo <RequestLegendaryGachaGainItems>b__168_1(ExchangedAward item)
			{
				return null;
			}

			// Token: 0x0400B0D4 RID: 45268
			[Token(Token = "0x400B0D4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelGacha.<>c <>9;

			// Token: 0x0400B0D5 RID: 45269
			[Token(Token = "0x400B0D5")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<CSSharedItemData> <>9__101_0;

			// Token: 0x0400B0D6 RID: 45270
			[Token(Token = "0x400B0D6")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<ExtraRewardDesc, int> <>9__106_0;

			// Token: 0x0400B0D7 RID: 45271
			[Token(Token = "0x400B0D7")]
			[FieldOffset(Offset = "0x18")]
			public static Converter<ExchangedAward, CommonRewardItemInfo> <>9__168_1;
		}

		// Token: 0x02001EAA RID: 7850
		[Token(Token = "0x2001EAA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCA04", Offset = "0x10FCA04")]
		private sealed class <>c__DisplayClass133_0
		{
			// Token: 0x0600AC3A RID: 44090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC3A")]
			[Address(RVA = "0x231AD98", Offset = "0x231AD98", VA = "0x7BBCB1AD98")]
			public <>c__DisplayClass133_0()
			{
			}

			// Token: 0x0600AC3B RID: 44091 RVA: 0x0002F838 File Offset: 0x0002DA38
			[Token(Token = "0x600AC3B")]
			[Address(RVA = "0x231D884", Offset = "0x231D884", VA = "0x7BBCB1D884")]
			internal bool <HasNewGacha>b__0(UIModelGacha.GachaCachePref item)
			{
				return default(bool);
			}

			// Token: 0x0600AC3C RID: 44092 RVA: 0x0002F850 File Offset: 0x0002DA50
			[Token(Token = "0x600AC3C")]
			[Address(RVA = "0x231D8FC", Offset = "0x231D8FC", VA = "0x7BBCB1D8FC")]
			internal bool <HasNewGacha>b__1(UIModelGacha.GachaCachePref item)
			{
				return default(bool);
			}

			// Token: 0x0400B0D8 RID: 45272
			[Token(Token = "0x400B0D8")]
			[FieldOffset(Offset = "0x10")]
			public KeyValuePair<uint, GachaPackageInfoData> gachaDesc;
		}

		// Token: 0x02001EAB RID: 7851
		[Token(Token = "0x2001EAB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCA14", Offset = "0x10FCA14")]
		private sealed class <>c__DisplayClass145_0
		{
			// Token: 0x0600AC3D RID: 44093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC3D")]
			[Address(RVA = "0x231B4CC", Offset = "0x231B4CC", VA = "0x7BBCB1B4CC")]
			public <>c__DisplayClass145_0()
			{
			}

			// Token: 0x0600AC3E RID: 44094 RVA: 0x0002F868 File Offset: 0x0002DA68
			[Token(Token = "0x600AC3E")]
			[Address(RVA = "0x231D9D8", Offset = "0x231D9D8", VA = "0x7BBCB1D9D8")]
			internal bool <GetGachaShowItemInfo>b__0(GachaShowItem item)
			{
				return default(bool);
			}

			// Token: 0x0400B0D9 RID: 45273
			[Token(Token = "0x400B0D9")]
			[FieldOffset(Offset = "0x10")]
			public uint itmID;

			// Token: 0x0400B0DA RID: 45274
			[Token(Token = "0x400B0DA")]
			[FieldOffset(Offset = "0x14")]
			public uint duration;
		}

		// Token: 0x02001EAC RID: 7852
		[Token(Token = "0x2001EAC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCA24", Offset = "0x10FCA24")]
		private sealed class <>c__DisplayClass146_0
		{
			// Token: 0x0600AC3F RID: 44095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC3F")]
			[Address(RVA = "0x231B668", Offset = "0x231B668", VA = "0x7BBCB1B668")]
			public <>c__DisplayClass146_0()
			{
			}

			// Token: 0x0600AC40 RID: 44096 RVA: 0x0002F880 File Offset: 0x0002DA80
			[Token(Token = "0x600AC40")]
			[Address(RVA = "0x231DA2C", Offset = "0x231DA2C", VA = "0x7BBCB1DA2C")]
			internal bool <GetGachaShowItemInfoByID>b__0(GachaShowItem item)
			{
				return default(bool);
			}

			// Token: 0x0400B0DB RID: 45275
			[Token(Token = "0x400B0DB")]
			[FieldOffset(Offset = "0x10")]
			public uint itmID;
		}

		// Token: 0x02001EAD RID: 7853
		[Token(Token = "0x2001EAD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCA34", Offset = "0x10FCA34")]
		private sealed class <>c__DisplayClass152_0
		{
			// Token: 0x0600AC41 RID: 44097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC41")]
			[Address(RVA = "0x231B8CC", Offset = "0x231B8CC", VA = "0x7BBCB1B8CC")]
			public <>c__DisplayClass152_0()
			{
			}

			// Token: 0x0600AC42 RID: 44098 RVA: 0x0002F898 File Offset: 0x0002DA98
			[Token(Token = "0x600AC42")]
			[Address(RVA = "0x231DA68", Offset = "0x231DA68", VA = "0x7BBCB1DA68")]
			internal bool <FindChestSpecialExchangeDesc>b__0(ChestSpecialExchangeDesc item)
			{
				return default(bool);
			}

			// Token: 0x0400B0DC RID: 45276
			[Token(Token = "0x400B0DC")]
			[FieldOffset(Offset = "0x10")]
			public uint itemID;
		}

		// Token: 0x02001EAE RID: 7854
		[Token(Token = "0x2001EAE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCA44", Offset = "0x10FCA44")]
		private sealed class <>c__DisplayClass156_0
		{
			// Token: 0x0600AC43 RID: 44099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC43")]
			[Address(RVA = "0x231BA90", Offset = "0x231BA90", VA = "0x7BBCB1BA90")]
			public <>c__DisplayClass156_0()
			{
			}

			// Token: 0x0600AC44 RID: 44100 RVA: 0x0002F8B0 File Offset: 0x0002DAB0
			[Token(Token = "0x600AC44")]
			[Address(RVA = "0x231DAA4", Offset = "0x231DAA4", VA = "0x7BBCB1DAA4")]
			internal bool <FindGachaIdListIdx>b__0(uint item)
			{
				return default(bool);
			}

			// Token: 0x0400B0DD RID: 45277
			[Token(Token = "0x400B0DD")]
			[FieldOffset(Offset = "0x10")]
			public uint chestID;
		}

		// Token: 0x02001EAF RID: 7855
		[Token(Token = "0x2001EAF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCA54", Offset = "0x10FCA54")]
		private sealed class <>c__DisplayClass157_0
		{
			// Token: 0x0600AC45 RID: 44101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC45")]
			[Address(RVA = "0x231BE10", Offset = "0x231BE10", VA = "0x7BBCB1BE10")]
			public <>c__DisplayClass157_0()
			{
			}

			// Token: 0x0600AC46 RID: 44102 RVA: 0x0002F8C8 File Offset: 0x0002DAC8
			[Token(Token = "0x600AC46")]
			[Address(RVA = "0x231DAD4", Offset = "0x231DAD4", VA = "0x7BBCB1DAD4")]
			internal bool <CheckAwardInGacha>b__0(GachaShowItem item)
			{
				return default(bool);
			}

			// Token: 0x0600AC47 RID: 44103 RVA: 0x0002F8E0 File Offset: 0x0002DAE0
			[Token(Token = "0x600AC47")]
			[Address(RVA = "0x231DB10", Offset = "0x231DB10", VA = "0x7BBCB1DB10")]
			internal bool <CheckAwardInGacha>b__1(GachaShowItem item)
			{
				return default(bool);
			}

			// Token: 0x0400B0DE RID: 45278
			[Token(Token = "0x400B0DE")]
			[FieldOffset(Offset = "0x10")]
			public uint id;

			// Token: 0x0400B0DF RID: 45279
			[Token(Token = "0x400B0DF")]
			[FieldOffset(Offset = "0x18")]
			public Predicate<GachaShowItem> <>9__0;

			// Token: 0x0400B0E0 RID: 45280
			[Token(Token = "0x400B0E0")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<GachaShowItem> <>9__1;
		}

		// Token: 0x02001EB0 RID: 7856
		[Token(Token = "0x2001EB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCA64", Offset = "0x10FCA64")]
		private sealed class <>c__DisplayClass164_0
		{
			// Token: 0x0600AC48 RID: 44104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC48")]
			[Address(RVA = "0x231C6E4", Offset = "0x231C6E4", VA = "0x7BBCB1C6E4")]
			public <>c__DisplayClass164_0()
			{
			}

			// Token: 0x0600AC49 RID: 44105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AC49")]
			[Address(RVA = "0x231DC3C", Offset = "0x231DC3C", VA = "0x7BBCB1DC3C")]
			internal string <GetNotifyInfo>b__0()
			{
				return null;
			}

			// Token: 0x0600AC4A RID: 44106 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AC4A")]
			[Address(RVA = "0x231DD50", Offset = "0x231DD50", VA = "0x7BBCB1DD50")]
			internal string <GetNotifyInfo>b__1()
			{
				return null;
			}

			// Token: 0x0400B0E1 RID: 45281
			[Token(Token = "0x400B0E1")]
			[FieldOffset(Offset = "0x10")]
			public string gachaName;
		}

		// Token: 0x02001EB1 RID: 7857
		[Token(Token = "0x2001EB1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCA74", Offset = "0x10FCA74")]
		private sealed class <>c__DisplayClass166_0
		{
			// Token: 0x0600AC4B RID: 44107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC4B")]
			[Address(RVA = "0x231C8F8", Offset = "0x231C8F8", VA = "0x7BBCB1C8F8")]
			public <>c__DisplayClass166_0()
			{
			}

			// Token: 0x0600AC4C RID: 44108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC4C")]
			[Address(RVA = "0x231DE64", Offset = "0x231DE64", VA = "0x7BBCB1DE64")]
			internal void <RequestGetEnergyGachaBuffInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B0E2 RID: 45282
			[Token(Token = "0x400B0E2")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGacha <>4__this;

			// Token: 0x0400B0E3 RID: 45283
			[Token(Token = "0x400B0E3")]
			[FieldOffset(Offset = "0x18")]
			public uint gachaID;
		}

		// Token: 0x02001EB2 RID: 7858
		[Token(Token = "0x2001EB2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCA84", Offset = "0x10FCA84")]
		private sealed class <>c__DisplayClass167_0
		{
			// Token: 0x0600AC4D RID: 44109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC4D")]
			[Address(RVA = "0x231CB0C", Offset = "0x231CB0C", VA = "0x7BBCB1CB0C")]
			public <>c__DisplayClass167_0()
			{
			}

			// Token: 0x0600AC4E RID: 44110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC4E")]
			[Address(RVA = "0x231E0C4", Offset = "0x231E0C4", VA = "0x7BBCB1E0C4")]
			internal void <RequestRefreshEnergyGachaBuffInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B0E4 RID: 45284
			[Token(Token = "0x400B0E4")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGacha <>4__this;

			// Token: 0x0400B0E5 RID: 45285
			[Token(Token = "0x400B0E5")]
			[FieldOffset(Offset = "0x18")]
			public uint gachaID;
		}

		// Token: 0x02001EB3 RID: 7859
		[Token(Token = "0x2001EB3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCA94", Offset = "0x10FCA94")]
		private sealed class <>c__DisplayClass168_0
		{
			// Token: 0x0600AC4F RID: 44111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC4F")]
			[Address(RVA = "0x231CDA8", Offset = "0x231CDA8", VA = "0x7BBCB1CDA8")]
			public <>c__DisplayClass168_0()
			{
			}

			// Token: 0x0600AC50 RID: 44112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC50")]
			[Address(RVA = "0x231E324", Offset = "0x231E324", VA = "0x7BBCB1E324")]
			internal void <RequestLegendaryGachaGainItems>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B0E6 RID: 45286
			[Token(Token = "0x400B0E6")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGacha <>4__this;

			// Token: 0x0400B0E7 RID: 45287
			[Token(Token = "0x400B0E7")]
			[FieldOffset(Offset = "0x18")]
			public uint gachaID;

			// Token: 0x0400B0E8 RID: 45288
			[Token(Token = "0x400B0E8")]
			[FieldOffset(Offset = "0x20")]
			public uint[] itemsIDs;
		}

		// Token: 0x02001EB4 RID: 7860
		[Token(Token = "0x2001EB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCAA4", Offset = "0x10FCAA4")]
		private sealed class <>c__DisplayClass169_0
		{
			// Token: 0x0600AC51 RID: 44113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC51")]
			[Address(RVA = "0x231D044", Offset = "0x231D044", VA = "0x7BBCB1D044")]
			public <>c__DisplayClass169_0()
			{
			}

			// Token: 0x0600AC52 RID: 44114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC52")]
			[Address(RVA = "0x231E618", Offset = "0x231E618", VA = "0x7BBCB1E618")]
			internal void <RequestLegendaryGachaRerandomItems>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B0E9 RID: 45289
			[Token(Token = "0x400B0E9")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGacha <>4__this;

			// Token: 0x0400B0EA RID: 45290
			[Token(Token = "0x400B0EA")]
			[FieldOffset(Offset = "0x18")]
			public uint gachaID;

			// Token: 0x0400B0EB RID: 45291
			[Token(Token = "0x400B0EB")]
			[FieldOffset(Offset = "0x20")]
			public uint[] itemsIDs;
		}
	}
}
