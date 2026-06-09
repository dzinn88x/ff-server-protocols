using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001EB9 RID: 7865
	[Token(Token = "0x2001EB9")]
	public class UIModelGift : UIBaseModel
	{
		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x0600AC5E RID: 44126 RVA: 0x0002F958 File Offset: 0x0002DB58
		[Token(Token = "0x17000B59")]
		public uint SendGiftTimeToday
		{
			[Token(Token = "0x600AC5E")]
			[Address(RVA = "0x2320B74", Offset = "0x2320B74", VA = "0x7BBCB20B74")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x0600AC5F RID: 44127 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AC60 RID: 44128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B5A")]
		public List<FriendInfo> AllSelectedList
		{
			[Token(Token = "0x600AC5F")]
			[Address(RVA = "0x2320B7C", Offset = "0x2320B7C", VA = "0x7BBCB20B7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AC60")]
			[Address(RVA = "0x2320B84", Offset = "0x2320B84", VA = "0x7BBCB20B84")]
			set
			{
			}
		}

		// Token: 0x0600AC61 RID: 44129 RVA: 0x0002F970 File Offset: 0x0002DB70
		[Token(Token = "0x600AC61")]
		[Address(RVA = "0x2320B88", Offset = "0x2320B88", VA = "0x7BBCB20B88", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x0600AC63 RID: 44131 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AC62 RID: 44130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B5B")]
		public GiftStoreInfo GiftStore
		{
			[Token(Token = "0x600AC63")]
			[Address(RVA = "0x2320B98", Offset = "0x2320B98", VA = "0x7BBCB20B98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114639C", Offset = "0x114639C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AC62")]
			[Address(RVA = "0x2320B90", Offset = "0x2320B90", VA = "0x7BBCB20B90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114638C", Offset = "0x114638C")]
			private set
			{
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x0600AC65 RID: 44133 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AC64 RID: 44132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B5C")]
		public CSGetGiftStoreDetailsRes GiftStoreDetails
		{
			[Token(Token = "0x600AC65")]
			[Address(RVA = "0x2320BA8", Offset = "0x2320BA8", VA = "0x7BBCB20BA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11463BC", Offset = "0x11463BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AC64")]
			[Address(RVA = "0x2320BA0", Offset = "0x2320BA0", VA = "0x7BBCB20BA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11463AC", Offset = "0x11463AC")]
			private set
			{
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x0600AC66 RID: 44134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5D")]
		public List<GiftItem> GiftItemsList
		{
			[Token(Token = "0x600AC66")]
			[Address(RVA = "0x2320BB0", Offset = "0x2320BB0", VA = "0x7BBCB20BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x0600AC67 RID: 44135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5E")]
		public SortedDictionary<UINavigationUtil.UINavigationMallTabType, List<GiftItem>> GiftItemsDict
		{
			[Token(Token = "0x600AC67")]
			[Address(RVA = "0x2320BB8", Offset = "0x2320BB8", VA = "0x7BBCB20BB8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x0600AC68 RID: 44136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5F")]
		public Dictionary<uint, List<GiftItem>> GiftPetDict
		{
			[Token(Token = "0x600AC68")]
			[Address(RVA = "0x2320BC0", Offset = "0x2320BC0", VA = "0x7BBCB20BC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x0600AC69 RID: 44137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B60")]
		public SortedDictionary<UIModelAvatarBase.EWardrobeType, List<GiftItem>> GiftClothDict
		{
			[Token(Token = "0x600AC69")]
			[Address(RVA = "0x2320BC8", Offset = "0x2320BC8", VA = "0x7BBCB20BC8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x0600AC6A RID: 44138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B61")]
		public SortedDictionary<CSSharedItemDataManager.CollectionSubType, List<GiftItem>> GiftCollectionDict
		{
			[Token(Token = "0x600AC6A")]
			[Address(RVA = "0x2320BD0", Offset = "0x2320BD0", VA = "0x7BBCB20BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x0600AC6B RID: 44139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B62")]
		public SortedDictionary<CSSharedItemDataManager.CharacterSubType, List<GiftItem>> GiftCharacterDict
		{
			[Token(Token = "0x600AC6B")]
			[Address(RVA = "0x2320BD8", Offset = "0x2320BD8", VA = "0x7BBCB20BD8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x0600AC6C RID: 44140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B63")]
		public List<GiftItem> GiftExclusiveItemList
		{
			[Token(Token = "0x600AC6C")]
			[Address(RVA = "0x2320BE0", Offset = "0x2320BE0", VA = "0x7BBCB20BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x0600AC6D RID: 44141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B64")]
		public Dictionary<EStore.GiftRankType, List<GiftRewardDesc>> GiftRewardsList
		{
			[Token(Token = "0x600AC6D")]
			[Address(RVA = "0x2320BE8", Offset = "0x2320BE8", VA = "0x7BBCB20BE8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x0600AC6E RID: 44142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B65")]
		public ClientGiftRankDesc GiftRankDesc
		{
			[Token(Token = "0x600AC6E")]
			[Address(RVA = "0x2320BF0", Offset = "0x2320BF0", VA = "0x7BBCB20BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x0600AC6F RID: 44143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B66")]
		public CSGetGiftRankRewardInfoRes GiftRankRewardInfoRes
		{
			[Token(Token = "0x600AC6F")]
			[Address(RVA = "0x2320BF8", Offset = "0x2320BF8", VA = "0x7BBCB20BF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AC70 RID: 44144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC70")]
		[Address(RVA = "0x2320C00", Offset = "0x2320C00", VA = "0x7BBCB20C00")]
		public void GetGiftStore(bool force = false)
		{
		}

		// Token: 0x0600AC71 RID: 44145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC71")]
		[Address(RVA = "0x2320E84", Offset = "0x2320E84", VA = "0x7BBCB20E84")]
		public void ProcessGiftStore(CSGetGiftStoreRes giftStoreRes)
		{
		}

		// Token: 0x0600AC72 RID: 44146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC72")]
		[Address(RVA = "0x2320FC8", Offset = "0x2320FC8", VA = "0x7BBCB20FC8")]
		public void GetGiftStoreDetails(bool force = false)
		{
		}

		// Token: 0x0600AC73 RID: 44147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC73")]
		[Address(RVA = "0x232124C", Offset = "0x232124C", VA = "0x7BBCB2124C")]
		private void UpdateItemsDict(GiftItem item)
		{
		}

		// Token: 0x0600AC74 RID: 44148 RVA: 0x0002F988 File Offset: 0x0002DB88
		[Token(Token = "0x600AC74")]
		[Address(RVA = "0x232175C", Offset = "0x232175C", VA = "0x7BBCB2175C")]
		public bool IsGiftStoreShow()
		{
			return default(bool);
		}

		// Token: 0x0600AC75 RID: 44149 RVA: 0x0002F9A0 File Offset: 0x0002DBA0
		[Token(Token = "0x600AC75")]
		[Address(RVA = "0x2321470", Offset = "0x2321470", VA = "0x7BBCB21470")]
		private uint GetTabType(uint itemOverrideMallType)
		{
			return 0U;
		}

		// Token: 0x0600AC76 RID: 44150 RVA: 0x0002F9B8 File Offset: 0x0002DBB8
		[Token(Token = "0x600AC76")]
		[Address(RVA = "0x232148C", Offset = "0x232148C", VA = "0x7BBCB2148C")]
		private uint GetSubType(uint itemOverrideMallType)
		{
			return 0U;
		}

		// Token: 0x0600AC77 RID: 44151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC77")]
		[Address(RVA = "0x23217DC", Offset = "0x23217DC", VA = "0x7BBCB217DC")]
		private void AddOverrideItem(Dictionary<uint, List<GiftItem>> dict, uint tabType, GiftItem item)
		{
		}

		// Token: 0x0600AC78 RID: 44152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC78")]
		[Address(RVA = "0x23214B0", Offset = "0x23214B0", VA = "0x7BBCB214B0")]
		private void AddItemToDict(GiftItem item, UINavigationUtil.UINavigationMallTabType mallType, uint mallSubType)
		{
		}

		// Token: 0x0600AC79 RID: 44153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC79")]
		[Address(RVA = "0x23219D4", Offset = "0x23219D4", VA = "0x7BBCB219D4")]
		private void UpdateClothDict(GiftItem item)
		{
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC7A")]
		[Address(RVA = "0x2321CE4", Offset = "0x2321CE4", VA = "0x7BBCB21CE4")]
		private void UpdateCollectionDict(GiftItem item)
		{
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC7B")]
		[Address(RVA = "0x2321F88", Offset = "0x2321F88", VA = "0x7BBCB21F88")]
		public void SendGift(ulong[] receiverIds, EGiftStore_BuddyType buddyType, string message, uint commodityID, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint count = 1U, uint voucherID = 0U)
		{
		}

		// Token: 0x0600AC7C RID: 44156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC7C")]
		[Address(RVA = "0x2322824", Offset = "0x2322824", VA = "0x7BBCB22824")]
		private void RefreshGiftRes()
		{
		}

		// Token: 0x0600AC7D RID: 44157 RVA: 0x0002F9D0 File Offset: 0x0002DBD0
		[Token(Token = "0x600AC7D")]
		[Address(RVA = "0x2322424", Offset = "0x2322424", VA = "0x7BBCB22424")]
		public bool CheckCurrencyStock(GiftItem item, uint itemCount, EInventory.CurrencyType currencyType, uint voucherID)
		{
			return default(bool);
		}

		// Token: 0x0600AC7E RID: 44158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC7E")]
		[Address(RVA = "0x2322850", Offset = "0x2322850", VA = "0x7BBCB22850", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600AC7F RID: 44159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC7F")]
		[Address(RVA = "0x2322880", Offset = "0x2322880", VA = "0x7BBCB22880")]
		public GiftItem FindGiftItemById(uint itemID)
		{
			return null;
		}

		// Token: 0x0600AC80 RID: 44160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC80")]
		[Address(RVA = "0x2322330", Offset = "0x2322330", VA = "0x7BBCB22330")]
		public GiftItem FindGiftItemByCommodityID(uint commodityID)
		{
			return null;
		}

		// Token: 0x0600AC81 RID: 44161 RVA: 0x0002F9E8 File Offset: 0x0002DBE8
		[Token(Token = "0x600AC81")]
		[Address(RVA = "0x2322974", Offset = "0x2322974", VA = "0x7BBCB22974")]
		public int SortGiftItem(GiftItem a, GiftItem b)
		{
			return 0;
		}

		// Token: 0x0600AC82 RID: 44162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC82")]
		[Address(RVA = "0x2322AC0", Offset = "0x2322AC0", VA = "0x7BBCB22AC0")]
		public void RequestGiftRankDesc()
		{
		}

		// Token: 0x0600AC83 RID: 44163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC83")]
		[Address(RVA = "0x2322D38", Offset = "0x2322D38", VA = "0x7BBCB22D38")]
		public void RequestGiftRankRewardInfo(uint rankID)
		{
		}

		// Token: 0x0600AC84 RID: 44164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC84")]
		[Address(RVA = "0x2322EC0", Offset = "0x2322EC0", VA = "0x7BBCB22EC0")]
		public void RequestGetGiftRankReward(uint rankID, EStore.GiftRankType giftRankType, uint giftItemNum)
		{
		}

		// Token: 0x0600AC85 RID: 44165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC85")]
		[Address(RVA = "0x23230D8", Offset = "0x23230D8", VA = "0x7BBCB230D8")]
		public UIModelGift()
		{
		}

		// Token: 0x0600AC86 RID: 44166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC86")]
		[Address(RVA = "0x23232A8", Offset = "0x23232A8", VA = "0x7BBCB232A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11463CC", Offset = "0x11463CC")]
		private void <GetGiftStore>b__56_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AC87 RID: 44167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC87")]
		[Address(RVA = "0x2323390", Offset = "0x2323390", VA = "0x7BBCB23390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11463DC", Offset = "0x11463DC")]
		private void <GetGiftStoreDetails>b__58_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AC88 RID: 44168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC88")]
		[Address(RVA = "0x23236CC", Offset = "0x23236CC", VA = "0x7BBCB236CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11463EC", Offset = "0x11463EC")]
		private void <RequestGiftRankDesc>b__74_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AC89 RID: 44169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC89")]
		[Address(RVA = "0x2323978", Offset = "0x2323978", VA = "0x7BBCB23978")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11463FC", Offset = "0x11463FC")]
		private void <RequestGiftRankRewardInfo>b__75_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B101 RID: 45313
		[Token(Token = "0x400B101")]
		public const uint PropID_UpdateGiftStore = 2U;

		// Token: 0x0400B102 RID: 45314
		[Token(Token = "0x400B102")]
		public const uint PropID_UpdateGiftStoreDetails = 4U;

		// Token: 0x0400B103 RID: 45315
		[Token(Token = "0x400B103")]
		public const uint PropID_SendGift = 8U;

		// Token: 0x0400B104 RID: 45316
		[Token(Token = "0x400B104")]
		public const uint PropID_GetGiftRankDesc = 16U;

		// Token: 0x0400B105 RID: 45317
		[Token(Token = "0x400B105")]
		public const uint PropID_GetGiftRankRewardInfo = 32U;

		// Token: 0x0400B106 RID: 45318
		[Token(Token = "0x400B106")]
		public const uint PropID_GetGiftRankRewardSuccess = 64U;

		// Token: 0x0400B107 RID: 45319
		[Token(Token = "0x400B107")]
		[FieldOffset(Offset = "0x18")]
		private uint m_SendGiftTimeToday;

		// Token: 0x0400B108 RID: 45320
		[Token(Token = "0x400B108")]
		[FieldOffset(Offset = "0x20")]
		private List<FriendInfo> m_AllSelectedList;

		// Token: 0x0400B109 RID: 45321
		[Token(Token = "0x400B109")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113005C", Offset = "0x113005C")]
		private GiftStoreInfo <GiftStore>k__BackingField;

		// Token: 0x0400B10A RID: 45322
		[Token(Token = "0x400B10A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113006C", Offset = "0x113006C")]
		private CSGetGiftStoreDetailsRes <GiftStoreDetails>k__BackingField;

		// Token: 0x0400B10B RID: 45323
		[Token(Token = "0x400B10B")]
		[FieldOffset(Offset = "0x38")]
		private List<GiftItem> m_GiftItemsList;

		// Token: 0x0400B10C RID: 45324
		[Token(Token = "0x400B10C")]
		[FieldOffset(Offset = "0x40")]
		private SortedDictionary<UINavigationUtil.UINavigationMallTabType, List<GiftItem>> m_GiftItemsDict;

		// Token: 0x0400B10D RID: 45325
		[Token(Token = "0x400B10D")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<uint, List<GiftItem>> m_GiftPetDict;

		// Token: 0x0400B10E RID: 45326
		[Token(Token = "0x400B10E")]
		[FieldOffset(Offset = "0x50")]
		private SortedDictionary<UIModelAvatarBase.EWardrobeType, List<GiftItem>> m_GiftClothDict;

		// Token: 0x0400B10F RID: 45327
		[Token(Token = "0x400B10F")]
		[FieldOffset(Offset = "0x58")]
		private SortedDictionary<CSSharedItemDataManager.CollectionSubType, List<GiftItem>> m_GiftCollectionDict;

		// Token: 0x0400B110 RID: 45328
		[Token(Token = "0x400B110")]
		[FieldOffset(Offset = "0x60")]
		private SortedDictionary<CSSharedItemDataManager.CharacterSubType, List<GiftItem>> m_GiftCharacterDict;

		// Token: 0x0400B111 RID: 45329
		[Token(Token = "0x400B111")]
		[FieldOffset(Offset = "0x68")]
		private List<GiftItem> m_GiftExclusiveItemList;

		// Token: 0x0400B112 RID: 45330
		[Token(Token = "0x400B112")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<EStore.GiftRankType, List<GiftRewardDesc>> m_GiftRewardsList;

		// Token: 0x0400B113 RID: 45331
		[Token(Token = "0x400B113")]
		[FieldOffset(Offset = "0x78")]
		private ClientGiftRankDesc m_GiftRankDesc;

		// Token: 0x0400B114 RID: 45332
		[Token(Token = "0x400B114")]
		[FieldOffset(Offset = "0x80")]
		private CSGetGiftRankRewardInfoRes m_GiftRankRewardInfoRes;

		// Token: 0x0400B115 RID: 45333
		[Token(Token = "0x400B115")]
		[FieldOffset(Offset = "0x88")]
		private float m_LastUpdateGiftStoreResTime;

		// Token: 0x0400B116 RID: 45334
		[Token(Token = "0x400B116")]
		[FieldOffset(Offset = "0x8C")]
		private float m_LastUpdateGiftStoreDetailResTime;

		// Token: 0x0400B117 RID: 45335
		[Token(Token = "0x400B117")]
		[FieldOffset(Offset = "0x90")]
		private float m_LastUpdateGiftRankResTime;

		// Token: 0x0400B118 RID: 45336
		[Token(Token = "0x400B118")]
		[FieldOffset(Offset = "0x94")]
		private float m_GetGiftStoreResCoolDown;

		// Token: 0x02001EBA RID: 7866
		[Token(Token = "0x2001EBA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCAC4", Offset = "0x10FCAC4")]
		private sealed class <>c__DisplayClass63_0
		{
			// Token: 0x0600AC8A RID: 44170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC8A")]
			[Address(RVA = "0x23219CC", Offset = "0x23219CC", VA = "0x7BBCB219CC")]
			public <>c__DisplayClass63_0()
			{
			}

			// Token: 0x0600AC8B RID: 44171 RVA: 0x0002FA00 File Offset: 0x0002DC00
			[Token(Token = "0x600AC8B")]
			[Address(RVA = "0x2323A80", Offset = "0x2323A80", VA = "0x7BBCB23A80")]
			internal bool <AddOverrideItem>b__0(GiftItem i)
			{
				return default(bool);
			}

			// Token: 0x0400B119 RID: 45337
			[Token(Token = "0x400B119")]
			[FieldOffset(Offset = "0x10")]
			public GiftItem item;
		}

		// Token: 0x02001EBB RID: 7867
		[Token(Token = "0x2001EBB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCAD4", Offset = "0x10FCAD4")]
		private sealed class <>c__DisplayClass67_0
		{
			// Token: 0x0600AC8C RID: 44172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC8C")]
			[Address(RVA = "0x2322328", Offset = "0x2322328", VA = "0x7BBCB22328")]
			public <>c__DisplayClass67_0()
			{
			}

			// Token: 0x0600AC8D RID: 44173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC8D")]
			[Address(RVA = "0x2323ACC", Offset = "0x2323ACC", VA = "0x7BBCB23ACC")]
			internal void <SendGift>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B11A RID: 45338
			[Token(Token = "0x400B11A")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGift <>4__this;

			// Token: 0x0400B11B RID: 45339
			[Token(Token = "0x400B11B")]
			[FieldOffset(Offset = "0x18")]
			public ulong[] receiverIds;
		}

		// Token: 0x02001EBC RID: 7868
		[Token(Token = "0x2001EBC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCAE4", Offset = "0x10FCAE4")]
		private sealed class <>c__DisplayClass76_0
		{
			// Token: 0x0600AC8E RID: 44174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC8E")]
			[Address(RVA = "0x23230D0", Offset = "0x23230D0", VA = "0x7BBCB230D0")]
			public <>c__DisplayClass76_0()
			{
			}

			// Token: 0x0600AC8F RID: 44175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC8F")]
			[Address(RVA = "0x2323ECC", Offset = "0x2323ECC", VA = "0x7BBCB23ECC")]
			internal void <RequestGetGiftRankReward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B11C RID: 45340
			[Token(Token = "0x400B11C")]
			[FieldOffset(Offset = "0x10")]
			public EStore.GiftRankType giftRankType;

			// Token: 0x0400B11D RID: 45341
			[Token(Token = "0x400B11D")]
			[FieldOffset(Offset = "0x18")]
			public UIModelGift <>4__this;
		}
	}
}
