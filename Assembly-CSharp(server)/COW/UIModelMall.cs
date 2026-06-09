using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F28 RID: 7976
	[Token(Token = "0x2001F28")]
	public class UIModelMall : UIBaseModel
	{
		// Token: 0x0600AF76 RID: 44918 RVA: 0x00030C78 File Offset: 0x0002EE78
		[Token(Token = "0x600AF76")]
		[Address(RVA = "0x1658A94", Offset = "0x1658A94", VA = "0x7BBBE58A94", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x0600AF77 RID: 44919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA4")]
		public List<AdItemInfo> AdsItemList
		{
			[Token(Token = "0x600AF77")]
			[Address(RVA = "0x1658A9C", Offset = "0x1658A9C", VA = "0x7BBBE58A9C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x0600AF78 RID: 44920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA5")]
		public List<StoreDesc> StoreItemList
		{
			[Token(Token = "0x600AF78")]
			[Address(RVA = "0x1658AA4", Offset = "0x1658AA4", VA = "0x7BBBE58AA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x0600AF79 RID: 44921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA6")]
		public SortedDictionary<UINavigationUtil.UINavigationMallTabType, List<StoreDesc>> StoreItemsDict
		{
			[Token(Token = "0x600AF79")]
			[Address(RVA = "0x1658AAC", Offset = "0x1658AAC", VA = "0x7BBBE58AAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x0600AF7A RID: 44922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA7")]
		public SortedDictionary<UIModelAvatarBase.EWardrobeType, List<StoreDesc>> StoreClothDict
		{
			[Token(Token = "0x600AF7A")]
			[Address(RVA = "0x1658AB4", Offset = "0x1658AB4", VA = "0x7BBBE58AB4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x0600AF7B RID: 44923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA8")]
		public SortedDictionary<CSSharedItemDataManager.CollectionSubType, List<StoreDesc>> StoreCollectionDict
		{
			[Token(Token = "0x600AF7B")]
			[Address(RVA = "0x1658ABC", Offset = "0x1658ABC", VA = "0x7BBBE58ABC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x0600AF7C RID: 44924 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AF7D RID: 44925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BA9")]
		public SortedDictionary<CSSharedItemDataManager.CharacterSubType, List<StoreDesc>> StoreCharacterDict
		{
			[Token(Token = "0x600AF7C")]
			[Address(RVA = "0x1658AC4", Offset = "0x1658AC4", VA = "0x7BBBE58AC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AF7D")]
			[Address(RVA = "0x1658ACC", Offset = "0x1658ACC", VA = "0x7BBBE58ACC")]
			set
			{
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x0600AF7E RID: 44926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BAA")]
		public List<StoreDesc> NewItemList
		{
			[Token(Token = "0x600AF7E")]
			[Address(RVA = "0x1658AD4", Offset = "0x1658AD4", VA = "0x7BBBE58AD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x0600AF7F RID: 44927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BAB")]
		public Dictionary<uint, List<StoreDesc>> StoreWeaponDict
		{
			[Token(Token = "0x600AF7F")]
			[Address(RVA = "0x1658ADC", Offset = "0x1658ADC", VA = "0x7BBBE58ADC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600AF80 RID: 44928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BAC")]
		public Dictionary<uint, List<StoreDesc>> StorePetDict
		{
			[Token(Token = "0x600AF80")]
			[Address(RVA = "0x1658AE4", Offset = "0x1658AE4", VA = "0x7BBBE58AE4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x0600AF81 RID: 44929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BAD")]
		public Dictionary<uint, List<StoreDesc>> StoreBoxDict
		{
			[Token(Token = "0x600AF81")]
			[Address(RVA = "0x1658AEC", Offset = "0x1658AEC", VA = "0x7BBBE58AEC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600AF82 RID: 44930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BAE")]
		public Dictionary<uint, List<ExchangeStoreItemDesc>> ExchangeStoreItemDict
		{
			[Token(Token = "0x600AF82")]
			[Address(RVA = "0x1658AF4", Offset = "0x1658AF4", VA = "0x7BBBE58AF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600AF83 RID: 44931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BAF")]
		public Dictionary<uint, ExchangeStoreDesc> ExchangeStoreDict
		{
			[Token(Token = "0x600AF83")]
			[Address(RVA = "0x1658AFC", Offset = "0x1658AFC", VA = "0x7BBBE58AFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x0600AF84 RID: 44932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB0")]
		public List<ExchangeStoreItemDesc> ExchangeStoreItemList
		{
			[Token(Token = "0x600AF84")]
			[Address(RVA = "0x1658B04", Offset = "0x1658B04", VA = "0x7BBBE58B04")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x0600AF85 RID: 44933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB1")]
		public List<DiscountStoreDesc> StoreDiscountItemList
		{
			[Token(Token = "0x600AF85")]
			[Address(RVA = "0x1658B0C", Offset = "0x1658B0C", VA = "0x7BBBE58B0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x0600AF86 RID: 44934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB2")]
		public List<InstallmentStoreDesc> StoreInstallmentItemList
		{
			[Token(Token = "0x600AF86")]
			[Address(RVA = "0x1658B14", Offset = "0x1658B14", VA = "0x7BBBE58B14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x0600AF87 RID: 44935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB3")]
		public Dictionary<uint, AvatarDebrisInfo> AvatarDebrisInfoDict
		{
			[Token(Token = "0x600AF87")]
			[Address(RVA = "0x1658B1C", Offset = "0x1658B1C", VA = "0x7BBBE58B1C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AF88 RID: 44936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF88")]
		[Address(RVA = "0x1658B24", Offset = "0x1658B24", VA = "0x7BBBE58B24")]
		public void GetStoreRes(bool refreshByItemInfoWrong = false)
		{
		}

		// Token: 0x0600AF89 RID: 44937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF89")]
		[Address(RVA = "0x164E570", Offset = "0x164E570", VA = "0x7BBBE4E570")]
		public void GetDiscountStoreDesc(bool force = false, uint option = 0U)
		{
		}

		// Token: 0x0600AF8A RID: 44938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF8A")]
		[Address(RVA = "0x1658DF8", Offset = "0x1658DF8", VA = "0x7BBBE58DF8")]
		public void PurchaseDiscountItem(uint storeID, bool isFreeItem = false, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint count = 1U, uint voucherID = 0U)
		{
		}

		// Token: 0x0600AF8B RID: 44939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF8B")]
		[Address(RVA = "0x1659714", Offset = "0x1659714", VA = "0x7BBBE59714")]
		public void RequestInstallmentStoreDesc(bool force = false)
		{
		}

		// Token: 0x0600AF8C RID: 44940 RVA: 0x00030C90 File Offset: 0x0002EE90
		[Token(Token = "0x600AF8C")]
		[Address(RVA = "0x1659A04", Offset = "0x1659A04", VA = "0x7BBBE59A04")]
		private bool IsInstallmentTimeVaild(InstallmentStoreDesc desc)
		{
			return default(bool);
		}

		// Token: 0x0600AF8D RID: 44941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF8D")]
		[Address(RVA = "0x1659AE0", Offset = "0x1659AE0", VA = "0x7BBBE59AE0")]
		public void RequestPurchaseInstallmentItem(uint itemID, bool isOneTimePayment = false, bool isRepay = false)
		{
		}

		// Token: 0x0600AF8E RID: 44942 RVA: 0x00030CA8 File Offset: 0x0002EEA8
		[Token(Token = "0x600AF8E")]
		[Address(RVA = "0x1659FA4", Offset = "0x1659FA4", VA = "0x7BBBE59FA4")]
		public uint CalInstallmentItemPerTermPrice(uint itemID)
		{
			return 0U;
		}

		// Token: 0x0600AF8F RID: 44943 RVA: 0x00030CC0 File Offset: 0x0002EEC0
		[Token(Token = "0x600AF8F")]
		[Address(RVA = "0x1659EA8", Offset = "0x1659EA8", VA = "0x7BBBE59EA8")]
		public uint CalInstallmentItemOnePaymentPrice(uint itemID)
		{
			return 0U;
		}

		// Token: 0x0600AF90 RID: 44944 RVA: 0x00030CD8 File Offset: 0x0002EED8
		[Token(Token = "0x600AF90")]
		[Address(RVA = "0x165A048", Offset = "0x165A048", VA = "0x7BBBE5A048")]
		public uint GetInstallmetItemPrice(uint itemID)
		{
			return 0U;
		}

		// Token: 0x0600AF91 RID: 44945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF91")]
		[Address(RVA = "0x165A19C", Offset = "0x165A19C", VA = "0x7BBBE5A19C")]
		private void UpdateMallTipsNum()
		{
		}

		// Token: 0x0600AF92 RID: 44946 RVA: 0x00030CF0 File Offset: 0x0002EEF0
		[Token(Token = "0x600AF92")]
		[Address(RVA = "0x165A238", Offset = "0x165A238", VA = "0x7BBBE5A238")]
		private int NormalMallTipsNum()
		{
			return 0;
		}

		// Token: 0x0600AF93 RID: 44947 RVA: 0x00030D08 File Offset: 0x0002EF08
		[Token(Token = "0x600AF93")]
		[Address(RVA = "0x165A2DC", Offset = "0x165A2DC", VA = "0x7BBBE5A2DC")]
		private int DiscountMallTipsNum()
		{
			return 0;
		}

		// Token: 0x0600AF94 RID: 44948 RVA: 0x00030D20 File Offset: 0x0002EF20
		[Token(Token = "0x600AF94")]
		[Address(RVA = "0x165A380", Offset = "0x165A380", VA = "0x7BBBE5A380")]
		private int DiscountMallFreeItemTipsNum()
		{
			return 0;
		}

		// Token: 0x0600AF95 RID: 44949 RVA: 0x00030D38 File Offset: 0x0002EF38
		[Token(Token = "0x600AF95")]
		[Address(RVA = "0x165A424", Offset = "0x165A424", VA = "0x7BBBE5A424")]
		public int DiscountMallUnClaimFreeItemNum()
		{
			return 0;
		}

		// Token: 0x0600AF96 RID: 44950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF96")]
		[Address(RVA = "0x164CDAC", Offset = "0x164CDAC", VA = "0x7BBBE4CDAC")]
		public void ProcessDiscountStoreDesc(CSGetDiscountStoreDescRes res)
		{
		}

		// Token: 0x0600AF97 RID: 44951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF97")]
		[Address(RVA = "0x164CF28", Offset = "0x164CF28", VA = "0x7BBBE4CF28")]
		public void ProcessMallTabInfoDict(CSGetStoreTabRes res)
		{
		}

		// Token: 0x0600AF98 RID: 44952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AF98")]
		[Address(RVA = "0x165A568", Offset = "0x165A568", VA = "0x7BBBE5A568")]
		public string GetTabName(UINavigationUtil.UINavigationMallType mallType, uint tabID)
		{
			return null;
		}

		// Token: 0x0600AF99 RID: 44953 RVA: 0x00030D50 File Offset: 0x0002EF50
		[Token(Token = "0x600AF99")]
		[Address(RVA = "0x165A6FC", Offset = "0x165A6FC", VA = "0x7BBBE5A6FC")]
		public int SortWeaponTab(uint typea, uint typeb)
		{
			return 0;
		}

		// Token: 0x0600AF9A RID: 44954 RVA: 0x00030D68 File Offset: 0x0002EF68
		[Token(Token = "0x600AF9A")]
		[Address(RVA = "0x165A880", Offset = "0x165A880", VA = "0x7BBBE5A880")]
		public int SortBoxTab(uint typea, uint typeb)
		{
			return 0;
		}

		// Token: 0x0600AF9B RID: 44955 RVA: 0x00030D80 File Offset: 0x0002EF80
		[Token(Token = "0x600AF9B")]
		[Address(RVA = "0x165A714", Offset = "0x165A714", VA = "0x7BBBE5A714")]
		private int SortTab(UINavigationUtil.UINavigationMallType mallType, uint typea, uint typeb)
		{
			return 0;
		}

		// Token: 0x0600AF9C RID: 44956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF9C")]
		[Address(RVA = "0x165A898", Offset = "0x165A898", VA = "0x7BBBE5A898")]
		private void ResetRefreshStoreItemColdData()
		{
		}

		// Token: 0x0600AF9D RID: 44957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF9D")]
		[Address(RVA = "0x165A93C", Offset = "0x165A93C", VA = "0x7BBBE5A93C")]
		private void ClearStoreCacheData()
		{
		}

		// Token: 0x0600AF9E RID: 44958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF9E")]
		[Address(RVA = "0x165AAAC", Offset = "0x165AAAC", VA = "0x7BBBE5AAAC")]
		public void RequestTreasureBoxProbability(uint id)
		{
		}

		// Token: 0x0600AF9F RID: 44959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF9F")]
		[Address(RVA = "0x165ACF8", Offset = "0x165ACF8", VA = "0x7BBBE5ACF8")]
		private void ClearTreasureBoxProbabilityCache()
		{
		}

		// Token: 0x0600AFA0 RID: 44960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA0")]
		[Address(RVA = "0x165AD58", Offset = "0x165AD58", VA = "0x7BBBE5AD58")]
		private void UpdateItemsDict(StoreDesc item, ref List<uint> unKnowTypeItemIDList)
		{
		}

		// Token: 0x0600AFA1 RID: 44961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFA1")]
		[Address(RVA = "0x165B08C", Offset = "0x165B08C", VA = "0x7BBBE5B08C")]
		public uint[] GetOverrideTypeList(string overrideType)
		{
			return null;
		}

		// Token: 0x0600AFA2 RID: 44962 RVA: 0x00030D98 File Offset: 0x0002EF98
		[Token(Token = "0x600AFA2")]
		[Address(RVA = "0x165B1E4", Offset = "0x165B1E4", VA = "0x7BBBE5B1E4")]
		public uint GetTabType(uint itemOverrideMallType)
		{
			return 0U;
		}

		// Token: 0x0600AFA3 RID: 44963 RVA: 0x00030DB0 File Offset: 0x0002EFB0
		[Token(Token = "0x600AFA3")]
		[Address(RVA = "0x165B200", Offset = "0x165B200", VA = "0x7BBBE5B200")]
		public uint GetSubType(uint itemOverrideMallType)
		{
			return 0U;
		}

		// Token: 0x0600AFA4 RID: 44964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA4")]
		[Address(RVA = "0x165B224", Offset = "0x165B224", VA = "0x7BBBE5B224")]
		private void AddItemToDict(UINavigationUtil.UINavigationMallTabType tabType, uint tabSubType, StoreDesc item)
		{
		}

		// Token: 0x0600AFA5 RID: 44965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA5")]
		[Address(RVA = "0x165B62C", Offset = "0x165B62C", VA = "0x7BBBE5B62C")]
		private void AddOverrideItem(Dictionary<uint, List<StoreDesc>> dict, uint tabType, StoreDesc item)
		{
		}

		// Token: 0x0600AFA6 RID: 44966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA6")]
		[Address(RVA = "0x165B81C", Offset = "0x165B81C", VA = "0x7BBBE5B81C")]
		private void UpdateClothDict(StoreDesc item)
		{
		}

		// Token: 0x0600AFA7 RID: 44967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA7")]
		[Address(RVA = "0x165BB30", Offset = "0x165BB30", VA = "0x7BBBE5BB30")]
		private void UpdateCollectionDict(StoreDesc item)
		{
		}

		// Token: 0x0600AFA8 RID: 44968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA8")]
		[Address(RVA = "0x165BDF4", Offset = "0x165BDF4", VA = "0x7BBBE5BDF4")]
		public void GetExchangeStoreRes(bool force = false, bool refreshByItemInfoWrong = false)
		{
		}

		// Token: 0x0600AFA9 RID: 44969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFA9")]
		[Address(RVA = "0x165C134", Offset = "0x165C134", VA = "0x7BBBE5C134")]
		public ExchangeStoreDesc GetExchangeDescByBoxId(uint boxId)
		{
			return null;
		}

		// Token: 0x0600AFAA RID: 44970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFAA")]
		[Address(RVA = "0x165C1B4", Offset = "0x165C1B4", VA = "0x7BBBE5C1B4")]
		public ExchangeStoreItemDesc GetExchangeItemDescBySotreId(uint storeId)
		{
			return null;
		}

		// Token: 0x0600AFAB RID: 44971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFAB")]
		[Address(RVA = "0x165C29C", Offset = "0x165C29C", VA = "0x7BBBE5C29C")]
		private void UpdateExchangeStore(ExchangeStore exchangeStore)
		{
		}

		// Token: 0x0600AFAC RID: 44972 RVA: 0x00030DC8 File Offset: 0x0002EFC8
		[Token(Token = "0x600AFAC")]
		[Address(RVA = "0x165C7B8", Offset = "0x165C7B8", VA = "0x7BBBE5C7B8")]
		public static long GuidToLongID()
		{
			return 0L;
		}

		// Token: 0x0600AFAD RID: 44973 RVA: 0x00030DE0 File Offset: 0x0002EFE0
		[Token(Token = "0x600AFAD")]
		[Address(RVA = "0x16592A8", Offset = "0x16592A8", VA = "0x7BBBE592A8")]
		public bool CheckHasEnoughCurrency(EInventory.CurrencyType currencyType, uint totalPrice)
		{
			return default(bool);
		}

		// Token: 0x0600AFAE RID: 44974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFAE")]
		[Address(RVA = "0x165C870", Offset = "0x165C870", VA = "0x7BBBE5C870")]
		public void Purchase(uint itemId, uint itemCount = 1U, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint voucherID = 0U, bool isOffer = true, bool isItemId = true)
		{
		}

		// Token: 0x0600AFAF RID: 44975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFAF")]
		[Address(RVA = "0x165CE54", Offset = "0x165CE54", VA = "0x7BBBE5CE54")]
		public void OfferPurchase(OfferGoodsDesc offerGoods)
		{
		}

		// Token: 0x0600AFB0 RID: 44976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFB0")]
		[Address(RVA = "0x165D0E0", Offset = "0x165D0E0", VA = "0x7BBBE5D0E0")]
		public void Exchange(ExchangeStoreItemDesc exchangeStoreItem, uint count = 1U, uint entryFrom = 1U)
		{
		}

		// Token: 0x0600AFB1 RID: 44977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFB1")]
		[Address(RVA = "0x1655EA4", Offset = "0x1655EA4", VA = "0x7BBBE55EA4")]
		public void ShowPurchaseReward(uint itemId, List<BaseItemInfo> awardlist, uint count)
		{
		}

		// Token: 0x0600AFB2 RID: 44978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFB2")]
		[Address(RVA = "0x165D6B0", Offset = "0x165D6B0", VA = "0x7BBBE5D6B0")]
		public void RefreshStoreRes()
		{
		}

		// Token: 0x0600AFB3 RID: 44979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFB3")]
		[Address(RVA = "0x165D6C0", Offset = "0x165D6C0", VA = "0x7BBBE5D6C0")]
		public void RefreshExchangeStoreRes()
		{
		}

		// Token: 0x0600AFB4 RID: 44980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFB4")]
		[Address(RVA = "0x165D6CC", Offset = "0x165D6CC", VA = "0x7BBBE5D6CC")]
		public void RefreshDiscountStoreRes()
		{
		}

		// Token: 0x0600AFB5 RID: 44981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFB5")]
		[Address(RVA = "0x165CBDC", Offset = "0x165CBDC", VA = "0x7BBBE5CBDC")]
		public StoreDesc FindStoreItemDescById(uint id, uint awardTime = 0U)
		{
			return null;
		}

		// Token: 0x0600AFB6 RID: 44982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFB6")]
		[Address(RVA = "0x165CCC8", Offset = "0x165CCC8", VA = "0x7BBBE5CCC8")]
		public StoreDesc FindStoreItemDescByStoreId(uint storeId)
		{
			return null;
		}

		// Token: 0x0600AFB7 RID: 44983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFB7")]
		[Address(RVA = "0x165D6D8", Offset = "0x165D6D8", VA = "0x7BBBE5D6D8")]
		public ExchangeStoreItemDesc FindExchagneItemDescById(uint id)
		{
			return null;
		}

		// Token: 0x0600AFB8 RID: 44984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFB8")]
		[Address(RVA = "0x165D7A8", Offset = "0x165D7A8", VA = "0x7BBBE5D7A8")]
		public ExchangeStoreItemDesc FindExchagneItemDescByCommodityID(uint id)
		{
			return null;
		}

		// Token: 0x0600AFB9 RID: 44985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFB9")]
		[Address(RVA = "0x165D878", Offset = "0x165D878", VA = "0x7BBBE5D878")]
		public DiscountStoreDesc FindDiscountItemDescById(uint id)
		{
			return null;
		}

		// Token: 0x0600AFBA RID: 44986 RVA: 0x00030DF8 File Offset: 0x0002EFF8
		[Token(Token = "0x600AFBA")]
		[Address(RVA = "0x165D948", Offset = "0x165D948", VA = "0x7BBBE5D948")]
		public bool IsSameAndCanPurchaseDiscountItem(uint id, uint storeId)
		{
			return default(bool);
		}

		// Token: 0x0600AFBB RID: 44987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFBB")]
		[Address(RVA = "0x16591D8", Offset = "0x16591D8", VA = "0x7BBBE591D8")]
		public DiscountStoreDesc FindDiscountItemDescByStoreId(uint id)
		{
			return null;
		}

		// Token: 0x0600AFBC RID: 44988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFBC")]
		[Address(RVA = "0x1659DD8", Offset = "0x1659DD8", VA = "0x7BBBE59DD8")]
		public InstallmentStoreDesc FindInstallmentItemDescById(uint id)
		{
			return null;
		}

		// Token: 0x0600AFBD RID: 44989 RVA: 0x00030E10 File Offset: 0x0002F010
		[Token(Token = "0x600AFBD")]
		[Address(RVA = "0x165D9C8", Offset = "0x165D9C8", VA = "0x7BBBE5D9C8")]
		public bool CheckIsUniqueAndOwned(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AFBE RID: 44990 RVA: 0x00030E28 File Offset: 0x0002F028
		[Token(Token = "0x600AFBE")]
		[Address(RVA = "0x165DA70", Offset = "0x165DA70", VA = "0x7BBBE5DA70")]
		public bool ItemCanPurchase(StoreDesc storeDesc)
		{
			return default(bool);
		}

		// Token: 0x0600AFBF RID: 44991 RVA: 0x00030E40 File Offset: 0x0002F040
		[Token(Token = "0x600AFBF")]
		[Address(RVA = "0x165DAD8", Offset = "0x165DAD8", VA = "0x7BBBE5DAD8")]
		public bool ItemCanPurchase(ExchangeStoreItemDesc exchangeItemDesc)
		{
			return default(bool);
		}

		// Token: 0x0600AFC0 RID: 44992 RVA: 0x00030E58 File Offset: 0x0002F058
		[Token(Token = "0x600AFC0")]
		[Address(RVA = "0x165DAC0", Offset = "0x165DAC0", VA = "0x7BBBE5DAC0")]
		public bool CheckItemCanPurchase(uint limited_purchase_times, uint purchase_times)
		{
			return default(bool);
		}

		// Token: 0x0600AFC1 RID: 44993 RVA: 0x00030E70 File Offset: 0x0002F070
		[Token(Token = "0x600AFC1")]
		[Address(RVA = "0x165DB28", Offset = "0x165DB28", VA = "0x7BBBE5DB28")]
		public int ChangeInstallmentType2Days(EInventory.InstallmentType type)
		{
			return 0;
		}

		// Token: 0x0600AFC2 RID: 44994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFC2")]
		[Address(RVA = "0x1640DC8", Offset = "0x1640DC8", VA = "0x7BBBE40DC8")]
		public static List<BaseItemInfo> AssembleAwardList(List<Item> add_list, List<Item> del_list)
		{
			return null;
		}

		// Token: 0x0600AFC3 RID: 44995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC3")]
		[Address(RVA = "0x165DB48", Offset = "0x165DB48", VA = "0x7BBBE5DB48")]
		public void OpenGrate(uint item_id, uint count = 1U, bool iscrate = false, UIModelMall.ERewardWndType rewardWndType = UIModelMall.ERewardWndType.COMMON)
		{
		}

		// Token: 0x0600AFC4 RID: 44996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC4")]
		[Address(RVA = "0x165DD9C", Offset = "0x165DD9C", VA = "0x7BBBE5DD9C")]
		public void OpenBountyGrate(uint item_id, uint count = 1U, bool iscrate = false)
		{
		}

		// Token: 0x0600AFC5 RID: 44997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC5")]
		[Address(RVA = "0x165DDA8", Offset = "0x165DDA8", VA = "0x7BBBE5DDA8")]
		public void OpenMegaPunchGrate(uint item_id, uint count = 1U, bool iscrate = false)
		{
		}

		// Token: 0x0600AFC6 RID: 44998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC6")]
		[Address(RVA = "0x165DDB4", Offset = "0x165DDB4", VA = "0x7BBBE5DDB4")]
		public void OpenOptionalBundle(uint item_id)
		{
		}

		// Token: 0x0600AFC7 RID: 44999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC7")]
		[Address(RVA = "0x165E1E4", Offset = "0x165E1E4", VA = "0x7BBBE5E1E4")]
		public void SelectOptionalBundle(uint order)
		{
		}

		// Token: 0x0600AFC8 RID: 45000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC8")]
		[Address(RVA = "0x165E1EC", Offset = "0x165E1EC", VA = "0x7BBBE5E1EC")]
		public void PickOptionalBundle(uint item_id, UIModelMall.ERewardWndType rewardWndType = UIModelMall.ERewardWndType.COMMON)
		{
		}

		// Token: 0x0600AFC9 RID: 45001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC9")]
		[Address(RVA = "0x165E420", Offset = "0x165E420", VA = "0x7BBBE5E420")]
		public void OpenBundle(uint item_id, UIModelMall.ERewardWndType rewardWndType = UIModelMall.ERewardWndType.COMMON)
		{
		}

		// Token: 0x0600AFCA RID: 45002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFCA")]
		[Address(RVA = "0x165E96C", Offset = "0x165E96C", VA = "0x7BBBE5E96C")]
		public void OpenBountyBundle(uint item_id)
		{
		}

		// Token: 0x0600AFCB RID: 45003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFCB")]
		[Address(RVA = "0x165E974", Offset = "0x165E974", VA = "0x7BBBE5E974")]
		public void OpenMegaPunchBundle(uint item_id)
		{
		}

		// Token: 0x0600AFCC RID: 45004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFCC")]
		[Address(RVA = "0x165E97C", Offset = "0x165E97C", VA = "0x7BBBE5E97C")]
		public void GetMallAdRes()
		{
		}

		// Token: 0x0600AFCD RID: 45005 RVA: 0x00030E88 File Offset: 0x0002F088
		[Token(Token = "0x600AFCD")]
		[Address(RVA = "0x165EBD4", Offset = "0x165EBD4", VA = "0x7BBBE5EBD4")]
		public bool MallItemIsSoldOut(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x0600AFCE RID: 45006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFCE")]
		[Address(RVA = "0x165ED0C", Offset = "0x165ED0C", VA = "0x7BBBE5ED0C", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600AFCF RID: 45007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFCF")]
		[Address(RVA = "0x165ED44", Offset = "0x165ED44", VA = "0x7BBBE5ED44")]
		private void ResetData()
		{
		}

		// Token: 0x0600AFD0 RID: 45008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFD0")]
		[Address(RVA = "0x165ED5C", Offset = "0x165ED5C", VA = "0x7BBBE5ED5C")]
		public StoreDesc GetLoadoutStoreItemInfo(uint id)
		{
			return null;
		}

		// Token: 0x0600AFD1 RID: 45009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFD1")]
		[Address(RVA = "0x165EE84", Offset = "0x165EE84", VA = "0x7BBBE5EE84")]
		public FullscreenCgDesc GetFullScreenAnimdata(uint id)
		{
			return null;
		}

		// Token: 0x0600AFD2 RID: 45010 RVA: 0x00030EA0 File Offset: 0x0002F0A0
		[Token(Token = "0x600AFD2")]
		[Address(RVA = "0x165F020", Offset = "0x165F020", VA = "0x7BBBE5F020")]
		public bool GetMallItemAnimIsPlayed(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x0600AFD3 RID: 45011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFD3")]
		[Address(RVA = "0x165F178", Offset = "0x165F178", VA = "0x7BBBE5F178")]
		public void SetMallItemAnimPlayed(uint itemID)
		{
		}

		// Token: 0x0600AFD4 RID: 45012 RVA: 0x00030EB8 File Offset: 0x0002F0B8
		[Token(Token = "0x600AFD4")]
		[Address(RVA = "0x165F230", Offset = "0x165F230", VA = "0x7BBBE5F230")]
		public int SortItem(object x, object y)
		{
			return 0;
		}

		// Token: 0x0600AFD5 RID: 45013 RVA: 0x00030ED0 File Offset: 0x0002F0D0
		[Token(Token = "0x600AFD5")]
		[Address(RVA = "0x165F820", Offset = "0x165F820", VA = "0x7BBBE5F820")]
		public int SortItemWithCheckClothCanEquip(object x, object y)
		{
			return 0;
		}

		// Token: 0x0600AFD6 RID: 45014 RVA: 0x00030EE8 File Offset: 0x0002F0E8
		[Token(Token = "0x600AFD6")]
		[Address(RVA = "0x165FAB8", Offset = "0x165FAB8", VA = "0x7BBBE5FAB8")]
		public int SortItemWithCheckBundleAllItemOwned(object x, object y)
		{
			return 0;
		}

		// Token: 0x0600AFD7 RID: 45015 RVA: 0x00030F00 File Offset: 0x0002F100
		[Token(Token = "0x600AFD7")]
		[Address(RVA = "0x165F4C8", Offset = "0x165F4C8", VA = "0x7BBBE5F4C8")]
		private int SortStoreItem(UIModelMall.CompareData x, UIModelMall.CompareData y, bool checkCanEquipCloth = false, bool checkBundleOwned = false)
		{
			return 0;
		}

		// Token: 0x0600AFD8 RID: 45016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFD8")]
		[Address(RVA = "0x1640FA8", Offset = "0x1640FA8", VA = "0x7BBBE40FA8")]
		public static List<CommonRewardItemInfo> FixPetRewardLevel(List<CommonRewardItemInfo> list)
		{
			return null;
		}

		// Token: 0x0600AFD9 RID: 45017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFD9")]
		[Address(RVA = "0x165FE80", Offset = "0x165FE80", VA = "0x7BBBE5FE80")]
		private void FixTreasureBoxRewardLevel(uint treasureboxID, List<CommonRewardItemInfo> list)
		{
		}

		// Token: 0x0600AFDA RID: 45018 RVA: 0x00030F18 File Offset: 0x0002F118
		[Token(Token = "0x600AFDA")]
		[Address(RVA = "0x16601C8", Offset = "0x16601C8", VA = "0x7BBBE601C8")]
		public bool BoxContainsItemAllOwned(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x0600AFDB RID: 45019 RVA: 0x00030F30 File Offset: 0x0002F130
		[Token(Token = "0x600AFDB")]
		[Address(RVA = "0x165FD50", Offset = "0x165FD50", VA = "0x7BBBE5FD50")]
		public bool CheckBundleOwned(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x0600AFDC RID: 45020 RVA: 0x00030F48 File Offset: 0x0002F148
		[Token(Token = "0x600AFDC")]
		[Address(RVA = "0x1660978", Offset = "0x1660978", VA = "0x7BBBE60978")]
		public uint GetRealGemPrice(StoreDesc storeDesc)
		{
			return 0U;
		}

		// Token: 0x0600AFDD RID: 45021 RVA: 0x00030F60 File Offset: 0x0002F160
		[Token(Token = "0x600AFDD")]
		[Address(RVA = "0x16605A0", Offset = "0x16605A0", VA = "0x7BBBE605A0")]
		public bool BundleContainsItemAllOwned(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AFDE RID: 45022 RVA: 0x00030F78 File Offset: 0x0002F178
		[Token(Token = "0x600AFDE")]
		[Address(RVA = "0x16609BC", Offset = "0x16609BC", VA = "0x7BBBE609BC")]
		public bool OptionalBundleContainsItemAllOwned(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AFDF RID: 45023 RVA: 0x00030F90 File Offset: 0x0002F190
		[Token(Token = "0x600AFDF")]
		[Address(RVA = "0x1660D94", Offset = "0x1660D94", VA = "0x7BBBE60D94")]
		public int GetDiscountItemPrice(uint price, float discountValue)
		{
			return 0;
		}

		// Token: 0x0600AFE0 RID: 45024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFE0")]
		[Address(RVA = "0x1660E60", Offset = "0x1660E60", VA = "0x7BBBE60E60")]
		public FullScreenAnimParams CreateFullScreenAnimParams(FullscreenCgDesc animData)
		{
			return null;
		}

		// Token: 0x0600AFE1 RID: 45025 RVA: 0x00030FA8 File Offset: 0x0002F1A8
		[Token(Token = "0x600AFE1")]
		[Address(RVA = "0x1661090", Offset = "0x1661090", VA = "0x7BBBE61090")]
		public bool HasOfferPurchase()
		{
			return default(bool);
		}

		// Token: 0x0600AFE2 RID: 45026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFE2")]
		[Address(RVA = "0x16610A0", Offset = "0x16610A0", VA = "0x7BBBE610A0")]
		public OfferGoodsDesc GetOfferGoods()
		{
			return null;
		}

		// Token: 0x0600AFE3 RID: 45027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFE3")]
		[Address(RVA = "0x165D0D8", Offset = "0x165D0D8", VA = "0x7BBBE5D0D8")]
		public void ClearOfferGoods()
		{
		}

		// Token: 0x0600AFE4 RID: 45028 RVA: 0x00030FC0 File Offset: 0x0002F1C0
		[Token(Token = "0x600AFE4")]
		[Address(RVA = "0x16610A8", Offset = "0x16610A8", VA = "0x7BBBE610A8")]
		public bool IsShowDiscountTag(StoreDesc desc)
		{
			return default(bool);
		}

		// Token: 0x0600AFE5 RID: 45029 RVA: 0x00030FD8 File Offset: 0x0002F1D8
		[Token(Token = "0x600AFE5")]
		[Address(RVA = "0x165CD98", Offset = "0x165CD98", VA = "0x7BBBE5CD98")]
		public bool IsDiscountItem(StoreDesc desc)
		{
			return default(bool);
		}

		// Token: 0x0600AFE6 RID: 45030 RVA: 0x00030FF0 File Offset: 0x0002F1F0
		[Token(Token = "0x600AFE6")]
		[Address(RVA = "0x1661158", Offset = "0x1661158", VA = "0x7BBBE61158")]
		public int SortDiscountItem(DiscountStoreDesc x, DiscountStoreDesc y)
		{
			return 0;
		}

		// Token: 0x0600AFE7 RID: 45031 RVA: 0x00031008 File Offset: 0x0002F208
		[Token(Token = "0x600AFE7")]
		[Address(RVA = "0x1661364", Offset = "0x1661364", VA = "0x7BBBE61364")]
		public int SortInstallmentItem(InstallmentStoreDesc x, InstallmentStoreDesc y)
		{
			return 0;
		}

		// Token: 0x0600AFE8 RID: 45032 RVA: 0x00031020 File Offset: 0x0002F220
		[Token(Token = "0x600AFE8")]
		[Address(RVA = "0x16617C8", Offset = "0x16617C8", VA = "0x7BBBE617C8")]
		public bool IsItemHideInMall(uint itemId)
		{
			return default(bool);
		}

		// Token: 0x0600AFE9 RID: 45033 RVA: 0x00031038 File Offset: 0x0002F238
		[Token(Token = "0x600AFE9")]
		[Address(RVA = "0x16616B0", Offset = "0x16616B0", VA = "0x7BBBE616B0")]
		private int CompareRare(uint itemIDx, uint itemIDy)
		{
			return 0;
		}

		// Token: 0x0600AFEA RID: 45034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFEA")]
		[Address(RVA = "0x164D19C", Offset = "0x164D19C", VA = "0x7BBBE4D19C")]
		public void ProcessAvatarDebris(CSGetRoleDebrisDescRes debrisDescRes)
		{
		}

		// Token: 0x0600AFEB RID: 45035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFEB")]
		[Address(RVA = "0x166184C", Offset = "0x166184C", VA = "0x7BBBE6184C")]
		public void PurchaseAvatarDebrisCallback(uint id, uint itemCount, uint itemInterval, EInventory.CurrencyType currencyType, uint price, Action Callback)
		{
		}

		// Token: 0x0600AFEC RID: 45036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFEC")]
		[Address(RVA = "0x1661AEC", Offset = "0x1661AEC", VA = "0x7BBBE61AEC")]
		public void PurchaseAvatarDebris(uint id, uint itemCount, uint itemInterval, EInventory.CurrencyType currencyType, uint price, uint voucherID = 0U)
		{
		}

		// Token: 0x0600AFED RID: 45037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFED")]
		[Address(RVA = "0x1661DF4", Offset = "0x1661DF4", VA = "0x7BBBE61DF4")]
		public UIModelMall()
		{
		}

		// Token: 0x0600AFEE RID: 45038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFEE")]
		[Address(RVA = "0x1662144", Offset = "0x1662144", VA = "0x7BBBE62144")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114670C", Offset = "0x114670C")]
		private void <GetDiscountStoreDesc>b__81_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AFEF RID: 45039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFEF")]
		[Address(RVA = "0x1662254", Offset = "0x1662254", VA = "0x7BBBE62254")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114671C", Offset = "0x114671C")]
		private void <RequestInstallmentStoreDesc>b__83_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B35B RID: 45915
		[Token(Token = "0x400B35B")]
		[FieldOffset(Offset = "0x18")]
		private List<AdItemInfo> m_AdsItemList;

		// Token: 0x0400B35C RID: 45916
		[Token(Token = "0x400B35C")]
		[FieldOffset(Offset = "0x20")]
		private List<StoreDesc> m_StoreItemList;

		// Token: 0x0400B35D RID: 45917
		[Token(Token = "0x400B35D")]
		[FieldOffset(Offset = "0x28")]
		private SortedDictionary<UINavigationUtil.UINavigationMallTabType, List<StoreDesc>> m_StoreItemsDict;

		// Token: 0x0400B35E RID: 45918
		[Token(Token = "0x400B35E")]
		[FieldOffset(Offset = "0x30")]
		private SortedDictionary<UIModelAvatarBase.EWardrobeType, List<StoreDesc>> m_StoreClothDict;

		// Token: 0x0400B35F RID: 45919
		[Token(Token = "0x400B35F")]
		[FieldOffset(Offset = "0x38")]
		private SortedDictionary<CSSharedItemDataManager.CollectionSubType, List<StoreDesc>> m_StoreCollectionDict;

		// Token: 0x0400B360 RID: 45920
		[Token(Token = "0x400B360")]
		[FieldOffset(Offset = "0x40")]
		private SortedDictionary<CSSharedItemDataManager.CharacterSubType, List<StoreDesc>> m_StoreCharacterDict;

		// Token: 0x0400B361 RID: 45921
		[Token(Token = "0x400B361")]
		[FieldOffset(Offset = "0x48")]
		private List<StoreDesc> m_StoreNewItemList;

		// Token: 0x0400B362 RID: 45922
		[Token(Token = "0x400B362")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<uint, List<StoreDesc>> m_StoreWeaponDict;

		// Token: 0x0400B363 RID: 45923
		[Token(Token = "0x400B363")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<uint, List<StoreDesc>> m_StorePetDict;

		// Token: 0x0400B364 RID: 45924
		[Token(Token = "0x400B364")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<uint, List<StoreDesc>> m_StoreBoxDict;

		// Token: 0x0400B365 RID: 45925
		[Token(Token = "0x400B365")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<uint, List<ExchangeStoreItemDesc>> m_ExchangeStoreItemIdDict;

		// Token: 0x0400B366 RID: 45926
		[Token(Token = "0x400B366")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<uint, ExchangeStoreDesc> m_ExchangeStoreDict;

		// Token: 0x0400B367 RID: 45927
		[Token(Token = "0x400B367")]
		[FieldOffset(Offset = "0x78")]
		private List<ExchangeStoreItemDesc> m_ExchangeStoreItemList;

		// Token: 0x0400B368 RID: 45928
		[Token(Token = "0x400B368")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<uint, ExchangeStoreDesc> m_ExchangeStoreBoxDict;

		// Token: 0x0400B369 RID: 45929
		[Token(Token = "0x400B369")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<uint, List<RareProbability>> m_TreasureBoxProbabilityDict;

		// Token: 0x0400B36A RID: 45930
		[Token(Token = "0x400B36A")]
		[FieldOffset(Offset = "0x90")]
		public List<DiscountStoreDesc> m_StoreDiscountItemList;

		// Token: 0x0400B36B RID: 45931
		[Token(Token = "0x400B36B")]
		[FieldOffset(Offset = "0x98")]
		private List<InstallmentStoreDesc> m_StoreInstallmentItemList;

		// Token: 0x0400B36C RID: 45932
		[Token(Token = "0x400B36C")]
		[FieldOffset(Offset = "0xA0")]
		private List<InstallmentStoreDesc> m_AllInstallmentItemList;

		// Token: 0x0400B36D RID: 45933
		[Token(Token = "0x400B36D")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<uint, AvatarDebrisInfo> m_AvatarDebrisInfoDict;

		// Token: 0x0400B36E RID: 45934
		[Token(Token = "0x400B36E")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<UINavigationUtil.UINavigationMallType, Dictionary<uint, StoreTableDesc>> m_MallTabInfoDict;

		// Token: 0x0400B36F RID: 45935
		[Token(Token = "0x400B36F")]
		public const uint PropID_StoreItemListUpdate = 2U;

		// Token: 0x0400B370 RID: 45936
		[Token(Token = "0x400B370")]
		public const uint PropID_PurchaseSuccess = 4U;

		// Token: 0x0400B371 RID: 45937
		[Token(Token = "0x400B371")]
		public const uint PropID_GetAds = 16U;

		// Token: 0x0400B372 RID: 45938
		[Token(Token = "0x400B372")]
		public const uint PropID_ExchangeStoreItemListUpdate = 32U;

		// Token: 0x0400B373 RID: 45939
		[Token(Token = "0x400B373")]
		public const uint PropID_ExchangePurchaseSuccess = 64U;

		// Token: 0x0400B374 RID: 45940
		[Token(Token = "0x400B374")]
		public const uint PropID_TreasureBoxProbability_Update = 128U;

		// Token: 0x0400B375 RID: 45941
		[Token(Token = "0x400B375")]
		public const uint PropID_DiscountStoreItemListUpdate = 256U;

		// Token: 0x0400B376 RID: 45942
		[Token(Token = "0x400B376")]
		public const uint PropID_DiscountItemPurchaseSuccess = 512U;

		// Token: 0x0400B377 RID: 45943
		[Token(Token = "0x400B377")]
		public const uint PropID_InstallmentStoreItemListUpdate = 1024U;

		// Token: 0x0400B378 RID: 45944
		[Token(Token = "0x400B378")]
		public const uint PropID_InstallmentItemPurchaseSuccess = 2048U;

		// Token: 0x0400B379 RID: 45945
		[Token(Token = "0x400B379")]
		public const uint PropID_TreasureBoxOpenSuccess = 4096U;

		// Token: 0x0400B37A RID: 45946
		[Token(Token = "0x400B37A")]
		public const uint PropID_TreasureBoxOpenFailed = 8192U;

		// Token: 0x0400B37B RID: 45947
		[Token(Token = "0x400B37B")]
		public const uint PropID_BundleOpenFailed = 16384U;

		// Token: 0x0400B37C RID: 45948
		[Token(Token = "0x400B37C")]
		public const uint PropID_BundleOpenSuccess = 32768U;

		// Token: 0x0400B37D RID: 45949
		[Token(Token = "0x400B37D")]
		public const uint PropID_PickOptionBundleSuccess = 65536U;

		// Token: 0x0400B37E RID: 45950
		[Token(Token = "0x400B37E")]
		[FieldOffset(Offset = "0xB8")]
		private float m_LastUpdateStoreResTime;

		// Token: 0x0400B37F RID: 45951
		[Token(Token = "0x400B37F")]
		[FieldOffset(Offset = "0xBC")]
		private float m_LastUpdateDiscountResTime;

		// Token: 0x0400B380 RID: 45952
		[Token(Token = "0x400B380")]
		[FieldOffset(Offset = "0xC0")]
		private float m_LastUpdateExchangeResTime;

		// Token: 0x0400B381 RID: 45953
		[Token(Token = "0x400B381")]
		[FieldOffset(Offset = "0xC4")]
		private float m_LastUpdateInstallmentResTime;

		// Token: 0x0400B382 RID: 45954
		[Token(Token = "0x400B382")]
		[FieldOffset(Offset = "0xC8")]
		private float m_GetStoreResCoolDown;

		// Token: 0x0400B383 RID: 45955
		[Token(Token = "0x400B383")]
		[FieldOffset(Offset = "0xCC")]
		public bool m_ActiveRefreshStoreRes;

		// Token: 0x0400B384 RID: 45956
		[Token(Token = "0x400B384")]
		private const string m_MallItemAnimPrefix = "MALLITEM_FULLSCREEN_ANIM";

		// Token: 0x0400B385 RID: 45957
		[Token(Token = "0x400B385")]
		public const string CLANMALLGUIDE = "ClanMallGuide";

		// Token: 0x0400B386 RID: 45958
		[Token(Token = "0x400B386")]
		[FieldOffset(Offset = "0xD0")]
		private OfferGoodsDesc m_OfferGoods;

		// Token: 0x0400B387 RID: 45959
		[Token(Token = "0x400B387")]
		[FieldOffset(Offset = "0xD8")]
		private uint m_SelectedOrder;

		// Token: 0x02001F29 RID: 7977
		[Token(Token = "0x2001F29")]
		private enum MallItemAnimState
		{
			// Token: 0x0400B389 RID: 45961
			[Token(Token = "0x400B389")]
			NO_PLAYED,
			// Token: 0x0400B38A RID: 45962
			[Token(Token = "0x400B38A")]
			PLAYERD
		}

		// Token: 0x02001F2A RID: 7978
		[Token(Token = "0x2001F2A")]
		public enum ERewardWndType
		{
			// Token: 0x0400B38C RID: 45964
			[Token(Token = "0x400B38C")]
			COMMON,
			// Token: 0x0400B38D RID: 45965
			[Token(Token = "0x400B38D")]
			BOUNTY,
			// Token: 0x0400B38E RID: 45966
			[Token(Token = "0x400B38E")]
			MEGAPUNCH
		}

		// Token: 0x02001F2B RID: 7979
		[Token(Token = "0x2001F2B")]
		public class CompareData
		{
			// Token: 0x0600AFF0 RID: 45040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AFF0")]
			[Address(RVA = "0x1503EA8", Offset = "0x1503EA8", VA = "0x7BBBD03EA8")]
			public CompareData(StoreDesc desc)
			{
			}

			// Token: 0x0600AFF1 RID: 45041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AFF1")]
			[Address(RVA = "0x1504014", Offset = "0x1504014", VA = "0x7BBBD04014")]
			public CompareData(ExchangeStoreItemDesc desc)
			{
			}

			// Token: 0x0400B38F RID: 45967
			[Token(Token = "0x400B38F")]
			[FieldOffset(Offset = "0x10")]
			public uint m_itemId;

			// Token: 0x0400B390 RID: 45968
			[Token(Token = "0x400B390")]
			[FieldOffset(Offset = "0x14")]
			public uint m_sortId;

			// Token: 0x0400B391 RID: 45969
			[Token(Token = "0x400B391")]
			[FieldOffset(Offset = "0x18")]
			public bool m_CanPurchase;

			// Token: 0x0400B392 RID: 45970
			[Token(Token = "0x400B392")]
			[FieldOffset(Offset = "0x1C")]
			public uint m_quality;
		}

		// Token: 0x02001F2C RID: 7980
		[Token(Token = "0x2001F2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCEF4", Offset = "0x10FCEF4")]
		private sealed class <>c__DisplayClass80_0
		{
			// Token: 0x0600AFF2 RID: 45042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AFF2")]
			[Address(RVA = "0x1503040", Offset = "0x1503040", VA = "0x7BBBD03040")]
			public <>c__DisplayClass80_0()
			{
			}

			// Token: 0x0600AFF3 RID: 45043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AFF3")]
			[Address(RVA = "0x1503048", Offset = "0x1503048", VA = "0x7BBBD03048")]
			internal void <GetStoreRes>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B393 RID: 45971
			[Token(Token = "0x400B393")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMall <>4__this;

			// Token: 0x0400B394 RID: 45972
			[Token(Token = "0x400B394")]
			[FieldOffset(Offset = "0x18")]
			public bool refreshByItemInfoWrong;
		}

		// Token: 0x02001F2D RID: 7981
		[Token(Token = "0x2001F2D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCF04", Offset = "0x10FCF04")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600AFF5 RID: 45045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AFF5")]
			[Address(RVA = "0x14FFCAC", Offset = "0x14FFCAC", VA = "0x7BBBCFFCAC")]
			public <>c()
			{
			}

			// Token: 0x0600AFF6 RID: 45046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AFF6")]
			[Address(RVA = "0x14FFCB4", Offset = "0x14FFCB4", VA = "0x7BBBCFFCB4")]
			internal string <GetStoreRes>b__80_1(uint storeID)
			{
				return null;
			}

			// Token: 0x0600AFF7 RID: 45047 RVA: 0x00031050 File Offset: 0x0002F250
			[Token(Token = "0x600AFF7")]
			[Address(RVA = "0x14FFCDC", Offset = "0x14FFCDC", VA = "0x7BBBCFFCDC")]
			internal uint <GetOverrideTypeList>b__105_0(string type)
			{
				return 0U;
			}

			// Token: 0x0600AFF8 RID: 45048 RVA: 0x00031068 File Offset: 0x0002F268
			[Token(Token = "0x600AFF8")]
			[Address(RVA = "0x14FFD10", Offset = "0x14FFD10", VA = "0x7BBBCFFD10")]
			internal int <GetExchangeStoreRes>b__112_1(ExchangeStore a, ExchangeStore b)
			{
				return 0;
			}

			// Token: 0x0600AFF9 RID: 45049 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AFF9")]
			[Address(RVA = "0x14FFD78", Offset = "0x14FFD78", VA = "0x7BBBCFFD78")]
			internal CommonRewardItemInfo <ShowPurchaseReward>b__121_4(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600AFFA RID: 45050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AFFA")]
			[Address(RVA = "0x14FFD84", Offset = "0x14FFD84", VA = "0x7BBBCFFD84")]
			internal CommonRewardItemInfo <OpenGrate>b__139_1(ExchangedAward item)
			{
				return null;
			}

			// Token: 0x0600AFFB RID: 45051 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AFFB")]
			[Address(RVA = "0x14FFD90", Offset = "0x14FFD90", VA = "0x7BBBCFFD90")]
			internal CommonRewardItemInfo <PickOptionalBundle>b__145_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600AFFC RID: 45052 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AFFC")]
			[Address(RVA = "0x14FFD9C", Offset = "0x14FFD9C", VA = "0x7BBBCFFD9C")]
			internal CommonRewardItemInfo <OpenBundle>b__146_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600AFFD RID: 45053 RVA: 0x00031080 File Offset: 0x0002F280
			[Token(Token = "0x600AFFD")]
			[Address(RVA = "0x14FFDA8", Offset = "0x14FFDA8", VA = "0x7BBBCFFDA8")]
			internal uint <BoxContainsItemAllOwned>b__164_0(TreasureBoxShowData item)
			{
				return 0U;
			}

			// Token: 0x0600AFFE RID: 45054 RVA: 0x00031098 File Offset: 0x0002F298
			[Token(Token = "0x600AFFE")]
			[Address(RVA = "0x14FFDD4", Offset = "0x14FFDD4", VA = "0x7BBBCFFDD4")]
			internal uint <BundleContainsItemAllOwned>b__167_0(BundleShowData item)
			{
				return 0U;
			}

			// Token: 0x0600AFFF RID: 45055 RVA: 0x000310B0 File Offset: 0x0002F2B0
			[Token(Token = "0x600AFFF")]
			[Address(RVA = "0x14FFE00", Offset = "0x14FFE00", VA = "0x7BBBCFFE00")]
			internal uint <OptionalBundleContainsItemAllOwned>b__168_0(OptionalBundleShowData item)
			{
				return 0U;
			}

			// Token: 0x0400B395 RID: 45973
			[Token(Token = "0x400B395")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelMall.<>c <>9;

			// Token: 0x0400B396 RID: 45974
			[Token(Token = "0x400B396")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<uint, string> <>9__80_1;

			// Token: 0x0400B397 RID: 45975
			[Token(Token = "0x400B397")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<string, uint> <>9__105_0;

			// Token: 0x0400B398 RID: 45976
			[Token(Token = "0x400B398")]
			[FieldOffset(Offset = "0x18")]
			public static Comparison<ExchangeStore> <>9__112_1;

			// Token: 0x0400B399 RID: 45977
			[Token(Token = "0x400B399")]
			[FieldOffset(Offset = "0x20")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__121_4;

			// Token: 0x0400B39A RID: 45978
			[Token(Token = "0x400B39A")]
			[FieldOffset(Offset = "0x28")]
			public static Converter<ExchangedAward, CommonRewardItemInfo> <>9__139_1;

			// Token: 0x0400B39B RID: 45979
			[Token(Token = "0x400B39B")]
			[FieldOffset(Offset = "0x30")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__145_1;

			// Token: 0x0400B39C RID: 45980
			[Token(Token = "0x400B39C")]
			[FieldOffset(Offset = "0x38")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__146_1;

			// Token: 0x0400B39D RID: 45981
			[Token(Token = "0x400B39D")]
			[FieldOffset(Offset = "0x40")]
			public static Converter<TreasureBoxShowData, uint> <>9__164_0;

			// Token: 0x0400B39E RID: 45982
			[Token(Token = "0x400B39E")]
			[FieldOffset(Offset = "0x48")]
			public static Converter<BundleShowData, uint> <>9__167_0;

			// Token: 0x0400B39F RID: 45983
			[Token(Token = "0x400B39F")]
			[FieldOffset(Offset = "0x50")]
			public static Converter<OptionalBundleShowData, uint> <>9__168_0;
		}

		// Token: 0x02001F2E RID: 7982
		[Token(Token = "0x2001F2E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCF14", Offset = "0x10FCF14")]
		private sealed class <>c__DisplayClass82_0
		{
			// Token: 0x0600B000 RID: 45056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B000")]
			[Address(RVA = "0x1503624", Offset = "0x1503624", VA = "0x7BBBD03624")]
			public <>c__DisplayClass82_0()
			{
			}

			// Token: 0x0600B001 RID: 45057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B001")]
			[Address(RVA = "0x150362C", Offset = "0x150362C", VA = "0x7BBBD0362C")]
			internal void <PurchaseDiscountItem>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B3A0 RID: 45984
			[Token(Token = "0x400B3A0")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMall <>4__this;

			// Token: 0x0400B3A1 RID: 45985
			[Token(Token = "0x400B3A1")]
			[FieldOffset(Offset = "0x18")]
			public DiscountStoreDesc desc;

			// Token: 0x0400B3A2 RID: 45986
			[Token(Token = "0x400B3A2")]
			[FieldOffset(Offset = "0x20")]
			public uint count;
		}

		// Token: 0x02001F2F RID: 7983
		[Token(Token = "0x2001F2F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCF24", Offset = "0x10FCF24")]
		private sealed class <>c__DisplayClass85_0
		{
			// Token: 0x0600B002 RID: 45058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B002")]
			[Address(RVA = "0x1503BA0", Offset = "0x1503BA0", VA = "0x7BBBD03BA0")]
			public <>c__DisplayClass85_0()
			{
			}

			// Token: 0x0600B003 RID: 45059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B003")]
			[Address(RVA = "0x1503BA8", Offset = "0x1503BA8", VA = "0x7BBBD03BA8")]
			internal void <RequestPurchaseInstallmentItem>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B3A3 RID: 45987
			[Token(Token = "0x400B3A3")]
			[FieldOffset(Offset = "0x10")]
			public bool isRepay;

			// Token: 0x0400B3A4 RID: 45988
			[Token(Token = "0x400B3A4")]
			[FieldOffset(Offset = "0x14")]
			public uint itemID;

			// Token: 0x0400B3A5 RID: 45989
			[Token(Token = "0x400B3A5")]
			[FieldOffset(Offset = "0x18")]
			public InstallmentStoreDesc itemDesc;

			// Token: 0x0400B3A6 RID: 45990
			[Token(Token = "0x400B3A6")]
			[FieldOffset(Offset = "0x20")]
			public UIModelMall <>4__this;
		}

		// Token: 0x02001F30 RID: 7984
		[Token(Token = "0x2001F30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCF34", Offset = "0x10FCF34")]
		private sealed class <>c__DisplayClass102_0
		{
			// Token: 0x0600B004 RID: 45060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B004")]
			[Address(RVA = "0x14FFE2C", Offset = "0x14FFE2C", VA = "0x7BBBCFFE2C")]
			public <>c__DisplayClass102_0()
			{
			}

			// Token: 0x0600B005 RID: 45061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B005")]
			[Address(RVA = "0x14FFE34", Offset = "0x14FFE34", VA = "0x7BBBCFFE34")]
			internal void <RequestTreasureBoxProbability>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B3A7 RID: 45991
			[Token(Token = "0x400B3A7")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMall <>4__this;

			// Token: 0x0400B3A8 RID: 45992
			[Token(Token = "0x400B3A8")]
			[FieldOffset(Offset = "0x18")]
			public uint id;
		}

		// Token: 0x02001F31 RID: 7985
		[Token(Token = "0x2001F31")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCF44", Offset = "0x10FCF44")]
		private sealed class <>c__DisplayClass109_0
		{
			// Token: 0x0600B006 RID: 45062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B006")]
			[Address(RVA = "0x1500028", Offset = "0x1500028", VA = "0x7BBBD00028")]
			public <>c__DisplayClass109_0()
			{
			}

			// Token: 0x0600B007 RID: 45063 RVA: 0x000310C8 File Offset: 0x0002F2C8
			[Token(Token = "0x600B007")]
			[Address(RVA = "0x1500030", Offset = "0x1500030", VA = "0x7BBBD00030")]
			internal bool <AddOverrideItem>b__0(StoreDesc i)
			{
				return default(bool);
			}

			// Token: 0x0400B3A9 RID: 45993
			[Token(Token = "0x400B3A9")]
			[FieldOffset(Offset = "0x10")]
			public StoreDesc item;
		}

		// Token: 0x02001F32 RID: 7986
		[Token(Token = "0x2001F32")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCF54", Offset = "0x10FCF54")]
		private sealed class <>c__DisplayClass112_0
		{
			// Token: 0x0600B008 RID: 45064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B008")]
			[Address(RVA = "0x150007C", Offset = "0x150007C", VA = "0x7BBBD0007C")]
			public <>c__DisplayClass112_0()
			{
			}

			// Token: 0x0600B009 RID: 45065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B009")]
			[Address(RVA = "0x1500084", Offset = "0x1500084", VA = "0x7BBBD00084")]
			internal void <GetExchangeStoreRes>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B3AA RID: 45994
			[Token(Token = "0x400B3AA")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMall <>4__this;

			// Token: 0x0400B3AB RID: 45995
			[Token(Token = "0x400B3AB")]
			[FieldOffset(Offset = "0x18")]
			public bool refreshByItemInfoWrong;
		}

		// Token: 0x02001F33 RID: 7987
		[Token(Token = "0x2001F33")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCF64", Offset = "0x10FCF64")]
		private sealed class <>c__DisplayClass114_0
		{
			// Token: 0x0600B00A RID: 45066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B00A")]
			[Address(RVA = "0x150043C", Offset = "0x150043C", VA = "0x7BBBD0043C")]
			public <>c__DisplayClass114_0()
			{
			}

			// Token: 0x0600B00B RID: 45067 RVA: 0x000310E0 File Offset: 0x0002F2E0
			[Token(Token = "0x600B00B")]
			[Address(RVA = "0x1500444", Offset = "0x1500444", VA = "0x7BBBD00444")]
			internal bool <GetExchangeItemDescBySotreId>b__0(ExchangeStoreItemDesc x)
			{
				return default(bool);
			}

			// Token: 0x0400B3AC RID: 45996
			[Token(Token = "0x400B3AC")]
			[FieldOffset(Offset = "0x10")]
			public uint storeId;
		}

		// Token: 0x02001F34 RID: 7988
		[Token(Token = "0x2001F34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCF74", Offset = "0x10FCF74")]
		private sealed class <>c__DisplayClass118_0
		{
			// Token: 0x0600B00C RID: 45068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B00C")]
			[Address(RVA = "0x1500480", Offset = "0x1500480", VA = "0x7BBBD00480")]
			public <>c__DisplayClass118_0()
			{
			}

			// Token: 0x0600B00D RID: 45069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B00D")]
			[Address(RVA = "0x1500488", Offset = "0x1500488", VA = "0x7BBBD00488")]
			internal void <Purchase>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B3AD RID: 45997
			[Token(Token = "0x400B3AD")]
			[FieldOffset(Offset = "0x10")]
			public StoreDesc storeDesc;

			// Token: 0x0400B3AE RID: 45998
			[Token(Token = "0x400B3AE")]
			[FieldOffset(Offset = "0x18")]
			public uint itemCount;

			// Token: 0x0400B3AF RID: 45999
			[Token(Token = "0x400B3AF")]
			[FieldOffset(Offset = "0x20")]
			public UIModelMall <>4__this;
		}

		// Token: 0x02001F35 RID: 7989
		[Token(Token = "0x2001F35")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCF84", Offset = "0x10FCF84")]
		private sealed class <>c__DisplayClass119_0
		{
			// Token: 0x0600B00E RID: 45070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B00E")]
			[Address(RVA = "0x1500CB8", Offset = "0x1500CB8", VA = "0x7BBBD00CB8")]
			public <>c__DisplayClass119_0()
			{
			}

			// Token: 0x0600B00F RID: 45071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B00F")]
			[Address(RVA = "0x1500CC0", Offset = "0x1500CC0", VA = "0x7BBBD00CC0")]
			internal void <OfferPurchase>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B3B0 RID: 46000
			[Token(Token = "0x400B3B0")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMall <>4__this;

			// Token: 0x0400B3B1 RID: 46001
			[Token(Token = "0x400B3B1")]
			[FieldOffset(Offset = "0x18")]
			public uint itemId;

			// Token: 0x0400B3B2 RID: 46002
			[Token(Token = "0x400B3B2")]
			[FieldOffset(Offset = "0x1C")]
			public uint num;
		}

		// Token: 0x02001F36 RID: 7990
		[Token(Token = "0x2001F36")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCF94", Offset = "0x10FCF94")]
		private sealed class <>c__DisplayClass120_0
		{
			// Token: 0x0600B010 RID: 45072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B010")]
			[Address(RVA = "0x1500F7C", Offset = "0x1500F7C", VA = "0x7BBBD00F7C")]
			public <>c__DisplayClass120_0()
			{
			}

			// Token: 0x0600B011 RID: 45073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B011")]
			[Address(RVA = "0x1500F84", Offset = "0x1500F84", VA = "0x7BBBD00F84")]
			internal void <Exchange>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B3B3 RID: 46003
			[Token(Token = "0x400B3B3")]
			[FieldOffset(Offset = "0x10")]
			public ExchangeStoreItemDesc exchangeStoreItem;

			// Token: 0x0400B3B4 RID: 46004
			[Token(Token = "0x400B3B4")]
			[FieldOffset(Offset = "0x18")]
			public UIModelMall <>4__this;

			// Token: 0x0400B3B5 RID: 46005
			[Token(Token = "0x400B3B5")]
			[FieldOffset(Offset = "0x20")]
			public uint count;
		}

		// Token: 0x02001F37 RID: 7991
		[Token(Token = "0x2001F37")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCFA4", Offset = "0x10FCFA4")]
		private sealed class <>c__DisplayClass121_0
		{
			// Token: 0x0600B012 RID: 45074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B012")]
			[Address(RVA = "0x150148C", Offset = "0x150148C", VA = "0x7BBBD0148C")]
			public <>c__DisplayClass121_0()
			{
			}

			// Token: 0x0600B013 RID: 45075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B013")]
			[Address(RVA = "0x1501494", Offset = "0x1501494", VA = "0x7BBBD01494")]
			internal void <ShowPurchaseReward>b__0()
			{
			}

			// Token: 0x0600B014 RID: 45076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B014")]
			[Address(RVA = "0x15014D0", Offset = "0x15014D0", VA = "0x7BBBD014D0")]
			internal void <ShowPurchaseReward>b__1()
			{
			}

			// Token: 0x0600B015 RID: 45077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B015")]
			[Address(RVA = "0x1501508", Offset = "0x1501508", VA = "0x7BBBD01508")]
			internal void <ShowPurchaseReward>b__2()
			{
			}

			// Token: 0x0600B016 RID: 45078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B016")]
			[Address(RVA = "0x150157C", Offset = "0x150157C", VA = "0x7BBBD0157C")]
			internal void <ShowPurchaseReward>b__3()
			{
			}

			// Token: 0x0400B3B6 RID: 46006
			[Token(Token = "0x400B3B6")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMall <>4__this;

			// Token: 0x0400B3B7 RID: 46007
			[Token(Token = "0x400B3B7")]
			[FieldOffset(Offset = "0x18")]
			public uint itemId;

			// Token: 0x0400B3B8 RID: 46008
			[Token(Token = "0x400B3B8")]
			[FieldOffset(Offset = "0x1C")]
			public uint count;
		}

		// Token: 0x02001F38 RID: 7992
		[Token(Token = "0x2001F38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCFB4", Offset = "0x10FCFB4")]
		private sealed class <>c__DisplayClass125_0
		{
			// Token: 0x0600B017 RID: 45079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B017")]
			[Address(RVA = "0x15015C8", Offset = "0x15015C8", VA = "0x7BBBD015C8")]
			public <>c__DisplayClass125_0()
			{
			}

			// Token: 0x0600B018 RID: 45080 RVA: 0x000310F8 File Offset: 0x0002F2F8
			[Token(Token = "0x600B018")]
			[Address(RVA = "0x15015D0", Offset = "0x15015D0", VA = "0x7BBBD015D0")]
			internal bool <FindStoreItemDescById>b__0(StoreDesc desc)
			{
				return default(bool);
			}

			// Token: 0x0400B3B9 RID: 46009
			[Token(Token = "0x400B3B9")]
			[FieldOffset(Offset = "0x10")]
			public uint id;

			// Token: 0x0400B3BA RID: 46010
			[Token(Token = "0x400B3BA")]
			[FieldOffset(Offset = "0x14")]
			public uint awardTime;
		}

		// Token: 0x02001F39 RID: 7993
		[Token(Token = "0x2001F39")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCFC4", Offset = "0x10FCFC4")]
		private sealed class <>c__DisplayClass126_0
		{
			// Token: 0x0600B019 RID: 45081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B019")]
			[Address(RVA = "0x1501624", Offset = "0x1501624", VA = "0x7BBBD01624")]
			public <>c__DisplayClass126_0()
			{
			}

			// Token: 0x0600B01A RID: 45082 RVA: 0x00031110 File Offset: 0x0002F310
			[Token(Token = "0x600B01A")]
			[Address(RVA = "0x150162C", Offset = "0x150162C", VA = "0x7BBBD0162C")]
			internal bool <FindStoreItemDescByStoreId>b__0(StoreDesc desc)
			{
				return default(bool);
			}

			// Token: 0x0400B3BB RID: 46011
			[Token(Token = "0x400B3BB")]
			[FieldOffset(Offset = "0x10")]
			public uint storeId;
		}

		// Token: 0x02001F3A RID: 7994
		[Token(Token = "0x2001F3A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCFD4", Offset = "0x10FCFD4")]
		private sealed class <>c__DisplayClass127_0
		{
			// Token: 0x0600B01B RID: 45083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B01B")]
			[Address(RVA = "0x1501668", Offset = "0x1501668", VA = "0x7BBBD01668")]
			public <>c__DisplayClass127_0()
			{
			}

			// Token: 0x0600B01C RID: 45084 RVA: 0x00031128 File Offset: 0x0002F328
			[Token(Token = "0x600B01C")]
			[Address(RVA = "0x1501670", Offset = "0x1501670", VA = "0x7BBBD01670")]
			internal bool <FindExchagneItemDescById>b__0(ExchangeStoreItemDesc desc)
			{
				return default(bool);
			}

			// Token: 0x0400B3BC RID: 46012
			[Token(Token = "0x400B3BC")]
			[FieldOffset(Offset = "0x10")]
			public uint id;
		}

		// Token: 0x02001F3B RID: 7995
		[Token(Token = "0x2001F3B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCFE4", Offset = "0x10FCFE4")]
		private sealed class <>c__DisplayClass128_0
		{
			// Token: 0x0600B01D RID: 45085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B01D")]
			[Address(RVA = "0x15016AC", Offset = "0x15016AC", VA = "0x7BBBD016AC")]
			public <>c__DisplayClass128_0()
			{
			}

			// Token: 0x0600B01E RID: 45086 RVA: 0x00031140 File Offset: 0x0002F340
			[Token(Token = "0x600B01E")]
			[Address(RVA = "0x15016B4", Offset = "0x15016B4", VA = "0x7BBBD016B4")]
			internal bool <FindExchagneItemDescByCommodityID>b__0(ExchangeStoreItemDesc desc)
			{
				return default(bool);
			}

			// Token: 0x0400B3BD RID: 46013
			[Token(Token = "0x400B3BD")]
			[FieldOffset(Offset = "0x10")]
			public uint id;
		}

		// Token: 0x02001F3C RID: 7996
		[Token(Token = "0x2001F3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCFF4", Offset = "0x10FCFF4")]
		private sealed class <>c__DisplayClass129_0
		{
			// Token: 0x0600B01F RID: 45087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B01F")]
			[Address(RVA = "0x15016F0", Offset = "0x15016F0", VA = "0x7BBBD016F0")]
			public <>c__DisplayClass129_0()
			{
			}

			// Token: 0x0600B020 RID: 45088 RVA: 0x00031158 File Offset: 0x0002F358
			[Token(Token = "0x600B020")]
			[Address(RVA = "0x15016F8", Offset = "0x15016F8", VA = "0x7BBBD016F8")]
			internal bool <FindDiscountItemDescById>b__0(DiscountStoreDesc desc)
			{
				return default(bool);
			}

			// Token: 0x0400B3BE RID: 46014
			[Token(Token = "0x400B3BE")]
			[FieldOffset(Offset = "0x10")]
			public uint id;
		}

		// Token: 0x02001F3D RID: 7997
		[Token(Token = "0x2001F3D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD004", Offset = "0x10FD004")]
		private sealed class <>c__DisplayClass131_0
		{
			// Token: 0x0600B021 RID: 45089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B021")]
			[Address(RVA = "0x1501734", Offset = "0x1501734", VA = "0x7BBBD01734")]
			public <>c__DisplayClass131_0()
			{
			}

			// Token: 0x0600B022 RID: 45090 RVA: 0x00031170 File Offset: 0x0002F370
			[Token(Token = "0x600B022")]
			[Address(RVA = "0x150173C", Offset = "0x150173C", VA = "0x7BBBD0173C")]
			internal bool <FindDiscountItemDescByStoreId>b__0(DiscountStoreDesc desc)
			{
				return default(bool);
			}

			// Token: 0x0400B3BF RID: 46015
			[Token(Token = "0x400B3BF")]
			[FieldOffset(Offset = "0x10")]
			public uint id;
		}

		// Token: 0x02001F3E RID: 7998
		[Token(Token = "0x2001F3E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD014", Offset = "0x10FD014")]
		private sealed class <>c__DisplayClass132_0
		{
			// Token: 0x0600B023 RID: 45091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B023")]
			[Address(RVA = "0x1501778", Offset = "0x1501778", VA = "0x7BBBD01778")]
			public <>c__DisplayClass132_0()
			{
			}

			// Token: 0x0600B024 RID: 45092 RVA: 0x00031188 File Offset: 0x0002F388
			[Token(Token = "0x600B024")]
			[Address(RVA = "0x1501780", Offset = "0x1501780", VA = "0x7BBBD01780")]
			internal bool <FindInstallmentItemDescById>b__0(InstallmentStoreDesc desc)
			{
				return default(bool);
			}

			// Token: 0x0400B3C0 RID: 46016
			[Token(Token = "0x400B3C0")]
			[FieldOffset(Offset = "0x10")]
			public uint id;
		}

		// Token: 0x02001F3F RID: 7999
		[Token(Token = "0x2001F3F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD024", Offset = "0x10FD024")]
		private sealed class <>c__DisplayClass139_0
		{
			// Token: 0x0600B025 RID: 45093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B025")]
			[Address(RVA = "0x15017BC", Offset = "0x15017BC", VA = "0x7BBBD017BC")]
			public <>c__DisplayClass139_0()
			{
			}

			// Token: 0x0600B026 RID: 45094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B026")]
			[Address(RVA = "0x15017C4", Offset = "0x15017C4", VA = "0x7BBBD017C4")]
			internal void <OpenGrate>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B3C1 RID: 46017
			[Token(Token = "0x400B3C1")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMall <>4__this;

			// Token: 0x0400B3C2 RID: 46018
			[Token(Token = "0x400B3C2")]
			[FieldOffset(Offset = "0x18")]
			public uint item_id;

			// Token: 0x0400B3C3 RID: 46019
			[Token(Token = "0x400B3C3")]
			[FieldOffset(Offset = "0x1C")]
			public UIModelMall.ERewardWndType rewardWndType;
		}

		// Token: 0x02001F40 RID: 8000
		[Token(Token = "0x2001F40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD034", Offset = "0x10FD034")]
		private sealed class <>c__DisplayClass142_0
		{
			// Token: 0x0600B027 RID: 45095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B027")]
			[Address(RVA = "0x1501B7C", Offset = "0x1501B7C", VA = "0x7BBBD01B7C")]
			public <>c__DisplayClass142_0()
			{
			}

			// Token: 0x0600B028 RID: 45096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B028")]
			[Address(RVA = "0x1501B84", Offset = "0x1501B84", VA = "0x7BBBD01B84")]
			internal void <OpenOptionalBundle>b__0()
			{
			}

			// Token: 0x0400B3C4 RID: 46020
			[Token(Token = "0x400B3C4")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMall <>4__this;

			// Token: 0x0400B3C5 RID: 46021
			[Token(Token = "0x400B3C5")]
			[FieldOffset(Offset = "0x18")]
			public uint item_id;
		}

		// Token: 0x02001F41 RID: 8001
		[Token(Token = "0x2001F41")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD044", Offset = "0x10FD044")]
		private sealed class <>c__DisplayClass145_0
		{
			// Token: 0x0600B029 RID: 45097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B029")]
			[Address(RVA = "0x1501BC0", Offset = "0x1501BC0", VA = "0x7BBBD01BC0")]
			public <>c__DisplayClass145_0()
			{
			}

			// Token: 0x0600B02A RID: 45098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B02A")]
			[Address(RVA = "0x1501BC8", Offset = "0x1501BC8", VA = "0x7BBBD01BC8")]
			internal void <PickOptionalBundle>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B3C6 RID: 46022
			[Token(Token = "0x400B3C6")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMall.ERewardWndType rewardWndType;

			// Token: 0x0400B3C7 RID: 46023
			[Token(Token = "0x400B3C7")]
			[FieldOffset(Offset = "0x18")]
			public UIModelMall <>4__this;

			// Token: 0x0400B3C8 RID: 46024
			[Token(Token = "0x400B3C8")]
			[FieldOffset(Offset = "0x20")]
			public uint item_id;
		}

		// Token: 0x02001F42 RID: 8002
		[Token(Token = "0x2001F42")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD054", Offset = "0x10FD054")]
		private sealed class <>c__DisplayClass146_0
		{
			// Token: 0x0600B02B RID: 45099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B02B")]
			[Address(RVA = "0x1502414", Offset = "0x1502414", VA = "0x7BBBD02414")]
			public <>c__DisplayClass146_0()
			{
			}

			// Token: 0x0600B02C RID: 45100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B02C")]
			[Address(RVA = "0x150241C", Offset = "0x150241C", VA = "0x7BBBD0241C")]
			internal void <OpenBundle>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B3C9 RID: 46025
			[Token(Token = "0x400B3C9")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMall.ERewardWndType rewardWndType;

			// Token: 0x0400B3CA RID: 46026
			[Token(Token = "0x400B3CA")]
			[FieldOffset(Offset = "0x18")]
			public UIModelMall <>4__this;
		}

		// Token: 0x02001F43 RID: 8003
		[Token(Token = "0x2001F43")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD064", Offset = "0x10FD064")]
		private sealed class <>c__DisplayClass150_0
		{
			// Token: 0x0600B02D RID: 45101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B02D")]
			[Address(RVA = "0x1502CD4", Offset = "0x1502CD4", VA = "0x7BBBD02CD4")]
			public <>c__DisplayClass150_0()
			{
			}

			// Token: 0x0600B02E RID: 45102 RVA: 0x000311A0 File Offset: 0x0002F3A0
			[Token(Token = "0x600B02E")]
			[Address(RVA = "0x1502CDC", Offset = "0x1502CDC", VA = "0x7BBBD02CDC")]
			internal bool <MallItemIsSoldOut>b__0(StoreDesc info)
			{
				return default(bool);
			}

			// Token: 0x0400B3CB RID: 46027
			[Token(Token = "0x400B3CB")]
			[FieldOffset(Offset = "0x10")]
			public uint itemID;
		}

		// Token: 0x02001F44 RID: 8004
		[Token(Token = "0x2001F44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD074", Offset = "0x10FD074")]
		private sealed class <>c__DisplayClass181_0
		{
			// Token: 0x0600B02F RID: 45103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B02F")]
			[Address(RVA = "0x1502D18", Offset = "0x1502D18", VA = "0x7BBBD02D18")]
			public <>c__DisplayClass181_0()
			{
			}

			// Token: 0x0600B030 RID: 45104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B030")]
			[Address(RVA = "0x1502D20", Offset = "0x1502D20", VA = "0x7BBBD02D20")]
			internal void <PurchaseAvatarDebrisCallback>b__0(HttpErrorCode errerCode, object res)
			{
			}

			// Token: 0x0400B3CC RID: 46028
			[Token(Token = "0x400B3CC")]
			[FieldOffset(Offset = "0x10")]
			public Action Callback;
		}

		// Token: 0x02001F45 RID: 8005
		[Token(Token = "0x2001F45")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD084", Offset = "0x10FD084")]
		private sealed class <>c__DisplayClass182_0
		{
			// Token: 0x0600B031 RID: 45105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B031")]
			[Address(RVA = "0x1502E28", Offset = "0x1502E28", VA = "0x7BBBD02E28")]
			public <>c__DisplayClass182_0()
			{
			}

			// Token: 0x0600B032 RID: 45106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B032")]
			[Address(RVA = "0x1502E30", Offset = "0x1502E30", VA = "0x7BBBD02E30")]
			internal void <PurchaseAvatarDebris>b__0(HttpErrorCode errerCode, object res)
			{
			}

			// Token: 0x0400B3CD RID: 46029
			[Token(Token = "0x400B3CD")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMall <>4__this;

			// Token: 0x0400B3CE RID: 46030
			[Token(Token = "0x400B3CE")]
			[FieldOffset(Offset = "0x18")]
			public uint id;

			// Token: 0x0400B3CF RID: 46031
			[Token(Token = "0x400B3CF")]
			[FieldOffset(Offset = "0x1C")]
			public uint itemCount;

			// Token: 0x0400B3D0 RID: 46032
			[Token(Token = "0x400B3D0")]
			[FieldOffset(Offset = "0x20")]
			public uint itemInterval;
		}
	}
}
