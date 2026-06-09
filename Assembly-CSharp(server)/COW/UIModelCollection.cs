using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E11 RID: 7697
	[Token(Token = "0x2001E11")]
	public class UIModelCollection : UIBaseModel
	{
		// Token: 0x0600A853 RID: 43091 RVA: 0x0002D858 File Offset: 0x0002BA58
		[Token(Token = "0x600A853")]
		[Address(RVA = "0x232DFB0", Offset = "0x232DFB0", VA = "0x7BBCB2DFB0", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A854 RID: 43092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A854")]
		[Address(RVA = "0x232DFB8", Offset = "0x232DFB8", VA = "0x7BBCB2DFB8")]
		public BaseProfileInfo MyProfileInfo()
		{
			return null;
		}

		// Token: 0x0600A855 RID: 43093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A855")]
		[Address(RVA = "0x232DFC0", Offset = "0x232DFC0", VA = "0x7BBCB2DFC0")]
		public List<BannerBaseInfo> SortedListBannerInfo()
		{
			return null;
		}

		// Token: 0x0600A856 RID: 43094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A856")]
		[Address(RVA = "0x232DFC8", Offset = "0x232DFC8", VA = "0x7BBCB2DFC8")]
		public List<HeadPicBaseInfo> SortedListHeadPicInfo()
		{
			return null;
		}

		// Token: 0x0600A857 RID: 43095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A857")]
		[Address(RVA = "0x232DFD0", Offset = "0x232DFD0", VA = "0x7BBCB2DFD0")]
		public List<LootBoxBaseInfo> SortedListLootBoxInfo()
		{
			return null;
		}

		// Token: 0x0600A858 RID: 43096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A858")]
		[Address(RVA = "0x232DFD8", Offset = "0x232DFD8", VA = "0x7BBCB2DFD8")]
		public List<BackPackBaseInfo> SortedListBackPackInfo()
		{
			return null;
		}

		// Token: 0x0600A859 RID: 43097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A859")]
		[Address(RVA = "0x232DFE0", Offset = "0x232DFE0", VA = "0x7BBCB2DFE0")]
		public List<ParachuteBaseInfo> SortedListParachuteInfo()
		{
			return null;
		}

		// Token: 0x0600A85A RID: 43098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A85A")]
		[Address(RVA = "0x232DFE8", Offset = "0x232DFE8", VA = "0x7BBCB2DFE8")]
		public List<SkyboardBaseInfo> SortedListSkyboardInfo()
		{
			return null;
		}

		// Token: 0x0600A85B RID: 43099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A85B")]
		[Address(RVA = "0x232DFF0", Offset = "0x232DFF0", VA = "0x7BBCB2DFF0")]
		public List<FlightBaseInfo> SortedListFlightInfo()
		{
			return null;
		}

		// Token: 0x0600A85C RID: 43100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A85C")]
		[Address(RVA = "0x232DFF8", Offset = "0x232DFF8", VA = "0x7BBCB2DFF8")]
		public List<PinBaseInfo> SortedListPinInfo()
		{
			return null;
		}

		// Token: 0x0600A85D RID: 43101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A85D")]
		[Address(RVA = "0x232E000", Offset = "0x232E000", VA = "0x7BBCB2E000")]
		public Dictionary<uint, List<WeaponSkinBaseInfo>> SortedListWeaponInfo()
		{
			return null;
		}

		// Token: 0x0600A85E RID: 43102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A85E")]
		[Address(RVA = "0x232E008", Offset = "0x232E008", VA = "0x7BBCB2E008")]
		public Dictionary<uint, List<WeaponSkinBaseInfo>> SortedListOfOwnedWeaponInfo()
		{
			return null;
		}

		// Token: 0x0600A85F RID: 43103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A85F")]
		[Address(RVA = "0x232E010", Offset = "0x232E010", VA = "0x7BBCB2E010")]
		public List<WeaponSkinBaseInfo> SortedListWeaponInfo(uint wpId)
		{
			return null;
		}

		// Token: 0x0600A860 RID: 43104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A860")]
		[Address(RVA = "0x232E0B4", Offset = "0x232E0B4", VA = "0x7BBCB2E0B4")]
		public List<WeaponSkinBaseInfo> SortedListOfOwnedWeaponInfo(uint wpId)
		{
			return null;
		}

		// Token: 0x0600A861 RID: 43105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A861")]
		[Address(RVA = "0x232E158", Offset = "0x232E158", VA = "0x7BBCB2E158")]
		public List<VehicleSkinBaseInfo> SortedListVehicleSkinInfo(uint vId)
		{
			return null;
		}

		// Token: 0x0600A862 RID: 43106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A862")]
		[Address(RVA = "0x232E1FC", Offset = "0x232E1FC", VA = "0x7BBCB2E1FC")]
		public List<EmoteBaseInfo> SortedListEmoteInfo()
		{
			return null;
		}

		// Token: 0x0600A863 RID: 43107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A863")]
		[Address(RVA = "0x232E204", Offset = "0x232E204", VA = "0x7BBCB2E204")]
		public Dictionary<CSSharedItemDataManager.CollectionSubType, List<string>> NewCollectionDict()
		{
			return null;
		}

		// Token: 0x0600A864 RID: 43108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A864")]
		[Address(RVA = "0x232E20C", Offset = "0x232E20C", VA = "0x7BBCB2E20C")]
		public List<uint> NewPopMenuTypeList()
		{
			return null;
		}

		// Token: 0x0600A865 RID: 43109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A865")]
		[Address(RVA = "0x232E214", Offset = "0x232E214", VA = "0x7BBCB2E214")]
		public Dictionary<uint, List<uint>> NewPVEWeaponDict()
		{
			return null;
		}

		// Token: 0x0600A866 RID: 43110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A866")]
		[Address(RVA = "0x232E21C", Offset = "0x232E21C", VA = "0x7BBCB2E21C")]
		public List<uint> HideCollectionList()
		{
			return null;
		}

		// Token: 0x0600A867 RID: 43111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A867")]
		[Address(RVA = "0x232E224", Offset = "0x232E224", VA = "0x7BBCB2E224")]
		public List<CollectionDataManager.ECollectionWeaponType> GetAllWeaponTypes()
		{
			return null;
		}

		// Token: 0x0600A868 RID: 43112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A868")]
		[Address(RVA = "0x232E310", Offset = "0x232E310", VA = "0x7BBCB2E310")]
		public List<uint> GetWeaponIdListByWeaponType(CollectionDataManager.ECollectionWeaponType wType)
		{
			return null;
		}

		// Token: 0x0600A869 RID: 43113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A869")]
		[Address(RVA = "0x232E3CC", Offset = "0x232E3CC", VA = "0x7BBCB2E3CC")]
		public List<uint> GetAllOwnedWeaponIdList()
		{
			return null;
		}

		// Token: 0x0600A86A RID: 43114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A86A")]
		[Address(RVA = "0x232E554", Offset = "0x232E554", VA = "0x7BBCB2E554")]
		public List<uint> GetAllOwnedVehicleIdList()
		{
			return null;
		}

		// Token: 0x0600A86B RID: 43115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A86B")]
		[Address(RVA = "0x232E55C", Offset = "0x232E55C", VA = "0x7BBCB2E55C")]
		public void AfterLogin()
		{
		}

		// Token: 0x0600A86C RID: 43116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A86C")]
		[Address(RVA = "0x232E64C", Offset = "0x232E64C", VA = "0x7BBCB2E64C")]
		public void AfterGetBackpack(CSGetBackpackRes backpackData)
		{
		}

		// Token: 0x0600A86D RID: 43117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A86D")]
		[Address(RVA = "0x232E938", Offset = "0x232E938", VA = "0x7BBCB2E938")]
		public void UnlockEP()
		{
		}

		// Token: 0x0600A86E RID: 43118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A86E")]
		[Address(RVA = "0x232E9B4", Offset = "0x232E9B4", VA = "0x7BBCB2E9B4")]
		public void SortCollectionData()
		{
		}

		// Token: 0x0600A86F RID: 43119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A86F")]
		[Address(RVA = "0x2331E98", Offset = "0x2331E98", VA = "0x7BBCB31E98")]
		public void UpdateClanName(string clanname)
		{
		}

		// Token: 0x0600A870 RID: 43120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A870")]
		[Address(RVA = "0x2331F1C", Offset = "0x2331F1C", VA = "0x7BBCB31F1C")]
		public void UpdateLadderRank(int rank, bool showCallsignRank, int rankPoint)
		{
		}

		// Token: 0x0600A871 RID: 43121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A871")]
		[Address(RVA = "0x2331FDC", Offset = "0x2331FDC", VA = "0x7BBCB31FDC")]
		public void UpdateCSLadderRank(int rank, int rankPoint)
		{
		}

		// Token: 0x0600A872 RID: 43122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A872")]
		[Address(RVA = "0x2332078", Offset = "0x2332078", VA = "0x7BBCB32078")]
		public void UpdateUserData(LoginRes userData)
		{
		}

		// Token: 0x0600A873 RID: 43123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A873")]
		[Address(RVA = "0x2332124", Offset = "0x2332124", VA = "0x7BBCB32124")]
		public void UpdateEPInfo()
		{
		}

		// Token: 0x0600A874 RID: 43124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A874")]
		[Address(RVA = "0x233224C", Offset = "0x233224C", VA = "0x7BBCB3224C")]
		public Dictionary<CSSharedItemDataManager.CollectionSubType, Dictionary<uint, Item>> GetCollectionDictInfo()
		{
			return null;
		}

		// Token: 0x0600A875 RID: 43125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A875")]
		[Address(RVA = "0x2332254", Offset = "0x2332254", VA = "0x7BBCB32254")]
		public void UpdateOwnedCollection(CSSharedItemDataManager.CollectionSubType cType, Item it)
		{
		}

		// Token: 0x0600A876 RID: 43126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A876")]
		[Address(RVA = "0x23323B0", Offset = "0x23323B0", VA = "0x7BBCB323B0")]
		public void CheckShowEmoteEffect()
		{
		}

		// Token: 0x0600A877 RID: 43127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A877")]
		[Address(RVA = "0x23323B4", Offset = "0x23323B4", VA = "0x7BBCB323B4")]
		public void AddDefaultWeaponItems()
		{
		}

		// Token: 0x0600A878 RID: 43128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A878")]
		[Address(RVA = "0x2332570", Offset = "0x2332570", VA = "0x7BBCB32570")]
		public WeaponSkinData DefaultItemByWeaponId(uint wpId)
		{
			return null;
		}

		// Token: 0x0600A879 RID: 43129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A879")]
		[Address(RVA = "0x23327E4", Offset = "0x23327E4", VA = "0x7BBCB327E4")]
		public void RequestChooseBanner(uint bannerId)
		{
		}

		// Token: 0x0600A87A RID: 43130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A87A")]
		[Address(RVA = "0x2332A88", Offset = "0x2332A88", VA = "0x7BBCB32A88")]
		private void ShowNotReachRankItemUseLevelTips(uint itemID)
		{
		}

		// Token: 0x0600A87B RID: 43131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A87B")]
		[Address(RVA = "0x2332DAC", Offset = "0x2332DAC", VA = "0x7BBCB32DAC")]
		public void RequestChoosePin(uint pinId)
		{
		}

		// Token: 0x0600A87C RID: 43132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A87C")]
		[Address(RVA = "0x2332FE8", Offset = "0x2332FE8", VA = "0x7BBCB32FE8")]
		public void RequestChooseHeadPic(uint headpic)
		{
		}

		// Token: 0x0600A87D RID: 43133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A87D")]
		[Address(RVA = "0x233328C", Offset = "0x233328C", VA = "0x7BBCB3328C")]
		public void RequestChooseEmote(uint _slotid, uint _emote_id)
		{
		}

		// Token: 0x0600A87E RID: 43134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A87E")]
		[Address(RVA = "0x233375C", Offset = "0x233375C", VA = "0x7BBCB3375C")]
		public void RequestBackpackCollection()
		{
		}

		// Token: 0x0600A87F RID: 43135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A87F")]
		[Address(RVA = "0x23338E4", Offset = "0x23338E4", VA = "0x7BBCB338E4")]
		public void RequestHideCollections()
		{
		}

		// Token: 0x0600A880 RID: 43136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A880")]
		[Address(RVA = "0x2333A58", Offset = "0x2333A58", VA = "0x7BBCB33A58")]
		public void RequestChooseSlots(List<uint> itemIdList)
		{
		}

		// Token: 0x0600A881 RID: 43137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A881")]
		[Address(RVA = "0x2334090", Offset = "0x2334090", VA = "0x7BBCB34090")]
		public void SetSlotReqListValue(List<uint> reqList, uint itemID, uint prevItemId = 0U)
		{
		}

		// Token: 0x0600A882 RID: 43138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A882")]
		[Address(RVA = "0x2334570", Offset = "0x2334570", VA = "0x7BBCB34570")]
		public void RequestChooseSlots(uint prevItemId, uint itemID)
		{
		}

		// Token: 0x0600A883 RID: 43139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A883")]
		[Address(RVA = "0x2334A28", Offset = "0x2334A28", VA = "0x7BBCB34A28")]
		public void RequestEquipWeapon(uint prevSkinId, uint skinid)
		{
		}

		// Token: 0x0600A884 RID: 43140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A884")]
		[Address(RVA = "0x2334C18", Offset = "0x2334C18", VA = "0x7BBCB34C18")]
		public void RequestChooseShow(uint showItemId)
		{
		}

		// Token: 0x0600A885 RID: 43141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A885")]
		[Address(RVA = "0x2334E8C", Offset = "0x2334E8C", VA = "0x7BBCB34E8C", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A886 RID: 43142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A886")]
		[Address(RVA = "0x2334F1C", Offset = "0x2334F1C", VA = "0x7BBCB34F1C", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A887 RID: 43143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A887")]
		[Address(RVA = "0x23352D8", Offset = "0x23352D8", VA = "0x7BBCB352D8")]
		public void UpdateNewOwnedItem(Item[] newInventories)
		{
		}

		// Token: 0x0600A888 RID: 43144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A888")]
		[Address(RVA = "0x2335BA8", Offset = "0x2335BA8", VA = "0x7BBCB35BA8")]
		public void UpdatePreviewItem(CSSharedItemDataManager.CollectionSubType collectionType, uint itemId)
		{
		}

		// Token: 0x0600A889 RID: 43145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A889")]
		[Address(RVA = "0x2335D34", Offset = "0x2335D34", VA = "0x7BBCB35D34")]
		public void UpdatePreviewPVEWeapon(uint wpId, uint itemId)
		{
		}

		// Token: 0x0600A88A RID: 43146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A88A")]
		[Address(RVA = "0x2335F6C", Offset = "0x2335F6C", VA = "0x7BBCB35F6C")]
		public void UpdatePreviewPopMenu(uint popmenuType)
		{
		}

		// Token: 0x0600A88B RID: 43147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A88B")]
		[Address(RVA = "0x2335FDC", Offset = "0x2335FDC", VA = "0x7BBCB35FDC")]
		public void UpdatePreviewTypes(CSSharedItemDataManager.CollectionSubType collectionType)
		{
		}

		// Token: 0x0600A88C RID: 43148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A88C")]
		[Address(RVA = "0x2335AF4", Offset = "0x2335AF4", VA = "0x7BBCB35AF4")]
		public void UpdateTipsNum(bool updateall = true)
		{
		}

		// Token: 0x0600A88D RID: 43149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A88D")]
		[Address(RVA = "0x233605C", Offset = "0x233605C", VA = "0x7BBCB3605C")]
		public void UpdateWeaponTipsNum()
		{
		}

		// Token: 0x0600A88E RID: 43150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A88E")]
		[Address(RVA = "0x2335A00", Offset = "0x2335A00", VA = "0x7BBCB35A00")]
		private void UpdateTipsNum(CSSharedItemDataManager.CollectionSubType collectionType, bool checkNew = false)
		{
		}

		// Token: 0x0600A88F RID: 43151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A88F")]
		[Address(RVA = "0x23362E8", Offset = "0x23362E8", VA = "0x7BBCB362E8")]
		private void SetTipsNum(ETipsType tipsType, int number = 0)
		{
		}

		// Token: 0x0600A890 RID: 43152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A890")]
		[Address(RVA = "0x2336380", Offset = "0x2336380", VA = "0x7BBCB36380")]
		private void SaveNewItems()
		{
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x0600A891 RID: 43153 RVA: 0x0002D870 File Offset: 0x0002BA70
		// (set) Token: 0x0600A892 RID: 43154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B0C")]
		public bool GoNewEmote
		{
			[Token(Token = "0x600A891")]
			[Address(RVA = "0x2336384", Offset = "0x2336384", VA = "0x7BBCB36384")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A892")]
			[Address(RVA = "0x233638C", Offset = "0x233638C", VA = "0x7BBCB3638C")]
			set
			{
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600A893 RID: 43155 RVA: 0x0002D888 File Offset: 0x0002BA88
		[Token(Token = "0x17000B0D")]
		public int EmoteOwnedCount
		{
			[Token(Token = "0x600A893")]
			[Address(RVA = "0x2336398", Offset = "0x2336398", VA = "0x7BBCB36398")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600A894 RID: 43156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A894")]
		[Address(RVA = "0x2336464", Offset = "0x2336464", VA = "0x7BBCB36464")]
		public UIModelCollection()
		{
		}

		// Token: 0x0600A895 RID: 43157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A895")]
		[Address(RVA = "0x2336A68", Offset = "0x2336A68", VA = "0x7BBCB36A68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145E9C", Offset = "0x1145E9C")]
		private void <RequestBackpackCollection>b__89_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A896 RID: 43158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A896")]
		[Address(RVA = "0x2336E00", Offset = "0x2336E00", VA = "0x7BBCB36E00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145EAC", Offset = "0x1145EAC")]
		private void <RequestHideCollections>b__90_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A897")]
		[Address(RVA = "0x2337094", Offset = "0x2337094", VA = "0x7BBCB37094")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145EBC", Offset = "0x1145EBC")]
		private void <RequestChooseShow>b__95_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400ADB7 RID: 44471
		[Token(Token = "0x400ADB7")]
		[FieldOffset(Offset = "0x18")]
		private BaseProfileInfo m_MyProfileInfo;

		// Token: 0x0400ADB8 RID: 44472
		[Token(Token = "0x400ADB8")]
		public const uint PropID_CollectionRetOK = 2U;

		// Token: 0x0400ADB9 RID: 44473
		[Token(Token = "0x400ADB9")]
		public const uint PropID_CollectionEquip = 4U;

		// Token: 0x0400ADBA RID: 44474
		[Token(Token = "0x400ADBA")]
		public const uint PropID_BannerEquipOK = 8U;

		// Token: 0x0400ADBB RID: 44475
		[Token(Token = "0x400ADBB")]
		public const uint PropID_HeadPicEquipOK = 16U;

		// Token: 0x0400ADBC RID: 44476
		[Token(Token = "0x400ADBC")]
		public const uint PropID_ProfileDataUpdate = 32U;

		// Token: 0x0400ADBD RID: 44477
		[Token(Token = "0x400ADBD")]
		public const uint PropID_NewCollection = 64U;

		// Token: 0x0400ADBE RID: 44478
		[Token(Token = "0x400ADBE")]
		public const uint PropID_LootBoxEquipOK = 128U;

		// Token: 0x0400ADBF RID: 44479
		[Token(Token = "0x400ADBF")]
		public const uint PropID_BackPackEquipOK = 256U;

		// Token: 0x0400ADC0 RID: 44480
		[Token(Token = "0x400ADC0")]
		public const uint PropID_CollectionHideDataOK = 512U;

		// Token: 0x0400ADC1 RID: 44481
		[Token(Token = "0x400ADC1")]
		public const uint PropID_EmoteEquipOk = 1024U;

		// Token: 0x0400ADC2 RID: 44482
		[Token(Token = "0x400ADC2")]
		public const uint PropID_ShowEquipOK = 2048U;

		// Token: 0x0400ADC3 RID: 44483
		[Token(Token = "0x400ADC3")]
		[FieldOffset(Offset = "0x20")]
		private List<BannerBaseInfo> m_SortedListBannerInfo;

		// Token: 0x0400ADC4 RID: 44484
		[Token(Token = "0x400ADC4")]
		[FieldOffset(Offset = "0x28")]
		private List<HeadPicBaseInfo> m_SortedListHeadPicInfo;

		// Token: 0x0400ADC5 RID: 44485
		[Token(Token = "0x400ADC5")]
		[FieldOffset(Offset = "0x30")]
		private List<LootBoxBaseInfo> m_SortedListLootBoxInfo;

		// Token: 0x0400ADC6 RID: 44486
		[Token(Token = "0x400ADC6")]
		[FieldOffset(Offset = "0x38")]
		private List<BackPackBaseInfo> m_SortedListBackPackInfo;

		// Token: 0x0400ADC7 RID: 44487
		[Token(Token = "0x400ADC7")]
		[FieldOffset(Offset = "0x40")]
		private List<ParachuteBaseInfo> m_SortedListParachuteInfo;

		// Token: 0x0400ADC8 RID: 44488
		[Token(Token = "0x400ADC8")]
		[FieldOffset(Offset = "0x48")]
		private List<SkyboardBaseInfo> m_SortedListSkyboardInfo;

		// Token: 0x0400ADC9 RID: 44489
		[Token(Token = "0x400ADC9")]
		[FieldOffset(Offset = "0x50")]
		private List<FlightBaseInfo> m_SortedListFilghtInfo;

		// Token: 0x0400ADCA RID: 44490
		[Token(Token = "0x400ADCA")]
		[FieldOffset(Offset = "0x58")]
		private List<EmoteBaseInfo> m_SortedListEmoteInfo;

		// Token: 0x0400ADCB RID: 44491
		[Token(Token = "0x400ADCB")]
		[FieldOffset(Offset = "0x60")]
		private List<PinBaseInfo> m_SortedListPinInfo;

		// Token: 0x0400ADCC RID: 44492
		[Token(Token = "0x400ADCC")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<uint, List<WeaponSkinBaseInfo>> m_SortedListWeaponInfo;

		// Token: 0x0400ADCD RID: 44493
		[Token(Token = "0x400ADCD")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<uint, List<VehicleSkinBaseInfo>> m_SortedListVehicleInfo;

		// Token: 0x0400ADCE RID: 44494
		[Token(Token = "0x400ADCE")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<uint, List<WeaponSkinBaseInfo>> m_SortedListOfOwnedWeaponInfo;

		// Token: 0x0400ADCF RID: 44495
		[Token(Token = "0x400ADCF")]
		private const string COLLECTION_BANNER_KEY = "collection_banner";

		// Token: 0x0400ADD0 RID: 44496
		[Token(Token = "0x400ADD0")]
		private const string COLLECTION_HEADPIC_KEY = "collection_headpic";

		// Token: 0x0400ADD1 RID: 44497
		[Token(Token = "0x400ADD1")]
		public const string COLLECTION_NEW_OPEN = "collection_new_open";

		// Token: 0x0400ADD2 RID: 44498
		[Token(Token = "0x400ADD2")]
		public const string COLLECTION_NEW_LOOTBOX = "collection_new_lootbox";

		// Token: 0x0400ADD3 RID: 44499
		[Token(Token = "0x400ADD3")]
		public const string COLLECTION_NEW_BACKPACK = "collection_new_backpack";

		// Token: 0x0400ADD4 RID: 44500
		[Token(Token = "0x400ADD4")]
		public const string COLLECTION_NEW_PARACHUTE = "collection_new_parachute";

		// Token: 0x0400ADD5 RID: 44501
		[Token(Token = "0x400ADD5")]
		public const string COLLECTION_NEW_SKYBOARD = "collection_new_skyboard";

		// Token: 0x0400ADD6 RID: 44502
		[Token(Token = "0x400ADD6")]
		public const string COLLECTION_NEW_FLIGHT = "collection_new_flight";

		// Token: 0x0400ADD7 RID: 44503
		[Token(Token = "0x400ADD7")]
		public const string COLLECTION_NEW_WEAPON = "collection_new_weapon";

		// Token: 0x0400ADD8 RID: 44504
		[Token(Token = "0x400ADD8")]
		public const string COLLECTION_NEW_VEHICLESKIN = "collection_new_vehicle_skin";

		// Token: 0x0400ADD9 RID: 44505
		[Token(Token = "0x400ADD9")]
		public const string COLLECTION_NEW_EMOTE = "collection_new_emote";

		// Token: 0x0400ADDA RID: 44506
		[Token(Token = "0x400ADDA")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<CSSharedItemDataManager.CollectionSubType, Dictionary<uint, Item>> m_DictCollectionInfo;

		// Token: 0x0400ADDB RID: 44507
		[Token(Token = "0x400ADDB")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<CSSharedItemDataManager.CollectionSubType, ETipsType> CollectionTypeToTipsMap;

		// Token: 0x0400ADDC RID: 44508
		[Token(Token = "0x400ADDC")]
		[FieldOffset(Offset = "0x90")]
		private List<CSSharedItemDataManager.CollectionSubType> m_CollectionTypesList;

		// Token: 0x0400ADDD RID: 44509
		[Token(Token = "0x400ADDD")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<CSSharedItemDataManager.CollectionSubType, List<string>> m_NewCollectionDict;

		// Token: 0x0400ADDE RID: 44510
		[Token(Token = "0x400ADDE")]
		[FieldOffset(Offset = "0xA0")]
		private List<uint> m_NewPopMenuTypeList;

		// Token: 0x0400ADDF RID: 44511
		[Token(Token = "0x400ADDF")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<uint, List<uint>> m_NewPVEWeaponDict;

		// Token: 0x0400ADE0 RID: 44512
		[Token(Token = "0x400ADE0")]
		[FieldOffset(Offset = "0xB0")]
		private List<uint> m_HideCollections;

		// Token: 0x0400ADE1 RID: 44513
		[Token(Token = "0x400ADE1")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<CollectionDataManager.ECollectionWeaponType, List<uint>> m_DictWeaponTypeToWeaponIdList;

		// Token: 0x0400ADE2 RID: 44514
		[Token(Token = "0x400ADE2")]
		[FieldOffset(Offset = "0xC0")]
		private List<uint> m_AllOwnedWeaponIdList;

		// Token: 0x0400ADE3 RID: 44515
		[Token(Token = "0x400ADE3")]
		[FieldOffset(Offset = "0xC8")]
		private List<uint> m_AllOwnedVehicleIdList;

		// Token: 0x0400ADE4 RID: 44516
		[Token(Token = "0x400ADE4")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<uint, WeaponSkinData> m_DefaultItemByWeaponId;

		// Token: 0x0400ADE5 RID: 44517
		[Token(Token = "0x400ADE5")]
		[FieldOffset(Offset = "0xD8")]
		private bool gotNewEmote;

		// Token: 0x02001E12 RID: 7698
		[Token(Token = "0x2001E12")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC344", Offset = "0x10FC344")]
		private sealed class <>c__DisplayClass72_0
		{
			// Token: 0x0600A898 RID: 43160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A898")]
			[Address(RVA = "0x2331E40", Offset = "0x2331E40", VA = "0x7BBCB31E40")]
			public <>c__DisplayClass72_0()
			{
			}

			// Token: 0x0600A899 RID: 43161 RVA: 0x0002D8A0 File Offset: 0x0002BAA0
			[Token(Token = "0x600A899")]
			[Address(RVA = "0x23375F0", Offset = "0x23375F0", VA = "0x7BBCB375F0")]
			internal bool <SortCollectionData>b__9(BannerBaseInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400ADE6 RID: 44518
			[Token(Token = "0x400ADE6")]
			[FieldOffset(Offset = "0x10")]
			public Item cdata;
		}

		// Token: 0x02001E13 RID: 7699
		[Token(Token = "0x2001E13")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC354", Offset = "0x10FC354")]
		private sealed class <>c__DisplayClass72_1
		{
			// Token: 0x0600A89A RID: 43162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A89A")]
			[Address(RVA = "0x2331E48", Offset = "0x2331E48", VA = "0x7BBCB31E48")]
			public <>c__DisplayClass72_1()
			{
			}

			// Token: 0x0600A89B RID: 43163 RVA: 0x0002D8B8 File Offset: 0x0002BAB8
			[Token(Token = "0x600A89B")]
			[Address(RVA = "0x233763C", Offset = "0x233763C", VA = "0x7BBCB3763C")]
			internal bool <SortCollectionData>b__10(HeadPicBaseInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400ADE7 RID: 44519
			[Token(Token = "0x400ADE7")]
			[FieldOffset(Offset = "0x10")]
			public Item cdata;
		}

		// Token: 0x02001E14 RID: 7700
		[Token(Token = "0x2001E14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC364", Offset = "0x10FC364")]
		private sealed class <>c__DisplayClass72_2
		{
			// Token: 0x0600A89C RID: 43164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A89C")]
			[Address(RVA = "0x2331E50", Offset = "0x2331E50", VA = "0x7BBCB31E50")]
			public <>c__DisplayClass72_2()
			{
			}

			// Token: 0x0600A89D RID: 43165 RVA: 0x0002D8D0 File Offset: 0x0002BAD0
			[Token(Token = "0x600A89D")]
			[Address(RVA = "0x23376D4", Offset = "0x23376D4", VA = "0x7BBCB376D4")]
			internal bool <SortCollectionData>b__11(LootBoxBaseInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400ADE8 RID: 44520
			[Token(Token = "0x400ADE8")]
			[FieldOffset(Offset = "0x10")]
			public Item cdata;
		}

		// Token: 0x02001E15 RID: 7701
		[Token(Token = "0x2001E15")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC374", Offset = "0x10FC374")]
		private sealed class <>c__DisplayClass72_3
		{
			// Token: 0x0600A89E RID: 43166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A89E")]
			[Address(RVA = "0x2331E58", Offset = "0x2331E58", VA = "0x7BBCB31E58")]
			public <>c__DisplayClass72_3()
			{
			}

			// Token: 0x0600A89F RID: 43167 RVA: 0x0002D8E8 File Offset: 0x0002BAE8
			[Token(Token = "0x600A89F")]
			[Address(RVA = "0x2337720", Offset = "0x2337720", VA = "0x7BBCB37720")]
			internal bool <SortCollectionData>b__12(BackPackBaseInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400ADE9 RID: 44521
			[Token(Token = "0x400ADE9")]
			[FieldOffset(Offset = "0x10")]
			public Item cdata;
		}

		// Token: 0x02001E16 RID: 7702
		[Token(Token = "0x2001E16")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC384", Offset = "0x10FC384")]
		private sealed class <>c__DisplayClass72_4
		{
			// Token: 0x0600A8A0 RID: 43168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8A0")]
			[Address(RVA = "0x2331E60", Offset = "0x2331E60", VA = "0x7BBCB31E60")]
			public <>c__DisplayClass72_4()
			{
			}

			// Token: 0x0600A8A1 RID: 43169 RVA: 0x0002D900 File Offset: 0x0002BB00
			[Token(Token = "0x600A8A1")]
			[Address(RVA = "0x233776C", Offset = "0x233776C", VA = "0x7BBCB3776C")]
			internal bool <SortCollectionData>b__13(ParachuteBaseInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400ADEA RID: 44522
			[Token(Token = "0x400ADEA")]
			[FieldOffset(Offset = "0x10")]
			public Item cdata;
		}

		// Token: 0x02001E17 RID: 7703
		[Token(Token = "0x2001E17")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC394", Offset = "0x10FC394")]
		private sealed class <>c__DisplayClass72_5
		{
			// Token: 0x0600A8A2 RID: 43170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8A2")]
			[Address(RVA = "0x2331E68", Offset = "0x2331E68", VA = "0x7BBCB31E68")]
			public <>c__DisplayClass72_5()
			{
			}

			// Token: 0x0600A8A3 RID: 43171 RVA: 0x0002D918 File Offset: 0x0002BB18
			[Token(Token = "0x600A8A3")]
			[Address(RVA = "0x23377B8", Offset = "0x23377B8", VA = "0x7BBCB377B8")]
			internal bool <SortCollectionData>b__14(SkyboardBaseInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400ADEB RID: 44523
			[Token(Token = "0x400ADEB")]
			[FieldOffset(Offset = "0x10")]
			public Item cdata;
		}

		// Token: 0x02001E18 RID: 7704
		[Token(Token = "0x2001E18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC3A4", Offset = "0x10FC3A4")]
		private sealed class <>c__DisplayClass72_6
		{
			// Token: 0x0600A8A4 RID: 43172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8A4")]
			[Address(RVA = "0x2331E70", Offset = "0x2331E70", VA = "0x7BBCB31E70")]
			public <>c__DisplayClass72_6()
			{
			}

			// Token: 0x0600A8A5 RID: 43173 RVA: 0x0002D930 File Offset: 0x0002BB30
			[Token(Token = "0x600A8A5")]
			[Address(RVA = "0x2337804", Offset = "0x2337804", VA = "0x7BBCB37804")]
			internal bool <SortCollectionData>b__15(FlightBaseInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400ADEC RID: 44524
			[Token(Token = "0x400ADEC")]
			[FieldOffset(Offset = "0x10")]
			public Item cdata;
		}

		// Token: 0x02001E19 RID: 7705
		[Token(Token = "0x2001E19")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC3B4", Offset = "0x10FC3B4")]
		private sealed class <>c__DisplayClass72_7
		{
			// Token: 0x0600A8A6 RID: 43174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8A6")]
			[Address(RVA = "0x2331E78", Offset = "0x2331E78", VA = "0x7BBCB31E78")]
			public <>c__DisplayClass72_7()
			{
			}

			// Token: 0x0600A8A7 RID: 43175 RVA: 0x0002D948 File Offset: 0x0002BB48
			[Token(Token = "0x600A8A7")]
			[Address(RVA = "0x2337850", Offset = "0x2337850", VA = "0x7BBCB37850")]
			internal bool <SortCollectionData>b__18(WeaponSkinBaseInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400ADED RID: 44525
			[Token(Token = "0x400ADED")]
			[FieldOffset(Offset = "0x10")]
			public Item cdata;
		}

		// Token: 0x02001E1A RID: 7706
		[Token(Token = "0x2001E1A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC3C4", Offset = "0x10FC3C4")]
		private sealed class <>c__DisplayClass72_8
		{
			// Token: 0x0600A8A8 RID: 43176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8A8")]
			[Address(RVA = "0x2331E80", Offset = "0x2331E80", VA = "0x7BBCB31E80")]
			public <>c__DisplayClass72_8()
			{
			}

			// Token: 0x0600A8A9 RID: 43177 RVA: 0x0002D960 File Offset: 0x0002BB60
			[Token(Token = "0x600A8A9")]
			[Address(RVA = "0x233789C", Offset = "0x233789C", VA = "0x7BBCB3789C")]
			internal bool <SortCollectionData>b__20(VehicleSkinBaseInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400ADEE RID: 44526
			[Token(Token = "0x400ADEE")]
			[FieldOffset(Offset = "0x10")]
			public Item cdata;
		}

		// Token: 0x02001E1B RID: 7707
		[Token(Token = "0x2001E1B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC3D4", Offset = "0x10FC3D4")]
		private sealed class <>c__DisplayClass72_9
		{
			// Token: 0x0600A8AA RID: 43178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8AA")]
			[Address(RVA = "0x2331E88", Offset = "0x2331E88", VA = "0x7BBCB31E88")]
			public <>c__DisplayClass72_9()
			{
			}

			// Token: 0x0600A8AB RID: 43179 RVA: 0x0002D978 File Offset: 0x0002BB78
			[Token(Token = "0x600A8AB")]
			[Address(RVA = "0x23378E8", Offset = "0x23378E8", VA = "0x7BBCB378E8")]
			internal bool <SortCollectionData>b__21(EmoteBaseInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400ADEF RID: 44527
			[Token(Token = "0x400ADEF")]
			[FieldOffset(Offset = "0x10")]
			public Item cdata;
		}

		// Token: 0x02001E1C RID: 7708
		[Token(Token = "0x2001E1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC3E4", Offset = "0x10FC3E4")]
		private sealed class <>c__DisplayClass72_10
		{
			// Token: 0x0600A8AC RID: 43180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8AC")]
			[Address(RVA = "0x2331E90", Offset = "0x2331E90", VA = "0x7BBCB31E90")]
			public <>c__DisplayClass72_10()
			{
			}

			// Token: 0x0600A8AD RID: 43181 RVA: 0x0002D990 File Offset: 0x0002BB90
			[Token(Token = "0x600A8AD")]
			[Address(RVA = "0x2337688", Offset = "0x2337688", VA = "0x7BBCB37688")]
			internal bool <SortCollectionData>b__22(PinBaseInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400ADF0 RID: 44528
			[Token(Token = "0x400ADF0")]
			[FieldOffset(Offset = "0x10")]
			public Item cdata;
		}

		// Token: 0x02001E1D RID: 7709
		[Token(Token = "0x2001E1D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC3F4", Offset = "0x10FC3F4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A8AF RID: 43183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8AF")]
			[Address(RVA = "0x2337348", Offset = "0x2337348", VA = "0x7BBCB37348")]
			public <>c()
			{
			}

			// Token: 0x0600A8B0 RID: 43184 RVA: 0x0002D9A8 File Offset: 0x0002BBA8
			[Token(Token = "0x600A8B0")]
			[Address(RVA = "0x2337350", Offset = "0x2337350", VA = "0x7BBCB37350")]
			internal int <SortCollectionData>b__72_0(BannerBaseInfo a, BannerBaseInfo b)
			{
				return 0;
			}

			// Token: 0x0600A8B1 RID: 43185 RVA: 0x0002D9C0 File Offset: 0x0002BBC0
			[Token(Token = "0x600A8B1")]
			[Address(RVA = "0x2337388", Offset = "0x2337388", VA = "0x7BBCB37388")]
			internal int <SortCollectionData>b__72_1(HeadPicBaseInfo a, HeadPicBaseInfo b)
			{
				return 0;
			}

			// Token: 0x0600A8B2 RID: 43186 RVA: 0x0002D9D8 File Offset: 0x0002BBD8
			[Token(Token = "0x600A8B2")]
			[Address(RVA = "0x23373C0", Offset = "0x23373C0", VA = "0x7BBCB373C0")]
			internal int <SortCollectionData>b__72_2(LootBoxBaseInfo a, LootBoxBaseInfo b)
			{
				return 0;
			}

			// Token: 0x0600A8B3 RID: 43187 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
			[Token(Token = "0x600A8B3")]
			[Address(RVA = "0x23373F8", Offset = "0x23373F8", VA = "0x7BBCB373F8")]
			internal int <SortCollectionData>b__72_3(BackPackBaseInfo a, BackPackBaseInfo b)
			{
				return 0;
			}

			// Token: 0x0600A8B4 RID: 43188 RVA: 0x0002DA08 File Offset: 0x0002BC08
			[Token(Token = "0x600A8B4")]
			[Address(RVA = "0x2337430", Offset = "0x2337430", VA = "0x7BBCB37430")]
			internal int <SortCollectionData>b__72_4(ParachuteBaseInfo a, ParachuteBaseInfo b)
			{
				return 0;
			}

			// Token: 0x0600A8B5 RID: 43189 RVA: 0x0002DA20 File Offset: 0x0002BC20
			[Token(Token = "0x600A8B5")]
			[Address(RVA = "0x2337468", Offset = "0x2337468", VA = "0x7BBCB37468")]
			internal int <SortCollectionData>b__72_5(SkyboardBaseInfo a, SkyboardBaseInfo b)
			{
				return 0;
			}

			// Token: 0x0600A8B6 RID: 43190 RVA: 0x0002DA38 File Offset: 0x0002BC38
			[Token(Token = "0x600A8B6")]
			[Address(RVA = "0x23374A0", Offset = "0x23374A0", VA = "0x7BBCB374A0")]
			internal int <SortCollectionData>b__72_6(FlightBaseInfo a, FlightBaseInfo b)
			{
				return 0;
			}

			// Token: 0x0600A8B7 RID: 43191 RVA: 0x0002DA50 File Offset: 0x0002BC50
			[Token(Token = "0x600A8B7")]
			[Address(RVA = "0x23374D8", Offset = "0x23374D8", VA = "0x7BBCB374D8")]
			internal int <SortCollectionData>b__72_16(WeaponSkinBaseInfo a, WeaponSkinBaseInfo b)
			{
				return 0;
			}

			// Token: 0x0600A8B8 RID: 43192 RVA: 0x0002DA68 File Offset: 0x0002BC68
			[Token(Token = "0x600A8B8")]
			[Address(RVA = "0x2337510", Offset = "0x2337510", VA = "0x7BBCB37510")]
			internal int <SortCollectionData>b__72_17(WeaponSkinBaseInfo a, WeaponSkinBaseInfo b)
			{
				return 0;
			}

			// Token: 0x0600A8B9 RID: 43193 RVA: 0x0002DA80 File Offset: 0x0002BC80
			[Token(Token = "0x600A8B9")]
			[Address(RVA = "0x2337548", Offset = "0x2337548", VA = "0x7BBCB37548")]
			internal int <SortCollectionData>b__72_19(VehicleSkinBaseInfo a, VehicleSkinBaseInfo b)
			{
				return 0;
			}

			// Token: 0x0600A8BA RID: 43194 RVA: 0x0002DA98 File Offset: 0x0002BC98
			[Token(Token = "0x600A8BA")]
			[Address(RVA = "0x2337580", Offset = "0x2337580", VA = "0x7BBCB37580")]
			internal int <SortCollectionData>b__72_7(EmoteBaseInfo a, EmoteBaseInfo b)
			{
				return 0;
			}

			// Token: 0x0600A8BB RID: 43195 RVA: 0x0002DAB0 File Offset: 0x0002BCB0
			[Token(Token = "0x600A8BB")]
			[Address(RVA = "0x23375B8", Offset = "0x23375B8", VA = "0x7BBCB375B8")]
			internal int <SortCollectionData>b__72_8(PinBaseInfo x, PinBaseInfo y)
			{
				return 0;
			}

			// Token: 0x0400ADF1 RID: 44529
			[Token(Token = "0x400ADF1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelCollection.<>c <>9;

			// Token: 0x0400ADF2 RID: 44530
			[Token(Token = "0x400ADF2")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<BannerBaseInfo> <>9__72_0;

			// Token: 0x0400ADF3 RID: 44531
			[Token(Token = "0x400ADF3")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<HeadPicBaseInfo> <>9__72_1;

			// Token: 0x0400ADF4 RID: 44532
			[Token(Token = "0x400ADF4")]
			[FieldOffset(Offset = "0x18")]
			public static Comparison<LootBoxBaseInfo> <>9__72_2;

			// Token: 0x0400ADF5 RID: 44533
			[Token(Token = "0x400ADF5")]
			[FieldOffset(Offset = "0x20")]
			public static Comparison<BackPackBaseInfo> <>9__72_3;

			// Token: 0x0400ADF6 RID: 44534
			[Token(Token = "0x400ADF6")]
			[FieldOffset(Offset = "0x28")]
			public static Comparison<ParachuteBaseInfo> <>9__72_4;

			// Token: 0x0400ADF7 RID: 44535
			[Token(Token = "0x400ADF7")]
			[FieldOffset(Offset = "0x30")]
			public static Comparison<SkyboardBaseInfo> <>9__72_5;

			// Token: 0x0400ADF8 RID: 44536
			[Token(Token = "0x400ADF8")]
			[FieldOffset(Offset = "0x38")]
			public static Comparison<FlightBaseInfo> <>9__72_6;

			// Token: 0x0400ADF9 RID: 44537
			[Token(Token = "0x400ADF9")]
			[FieldOffset(Offset = "0x40")]
			public static Comparison<WeaponSkinBaseInfo> <>9__72_16;

			// Token: 0x0400ADFA RID: 44538
			[Token(Token = "0x400ADFA")]
			[FieldOffset(Offset = "0x48")]
			public static Comparison<WeaponSkinBaseInfo> <>9__72_17;

			// Token: 0x0400ADFB RID: 44539
			[Token(Token = "0x400ADFB")]
			[FieldOffset(Offset = "0x50")]
			public static Comparison<VehicleSkinBaseInfo> <>9__72_19;

			// Token: 0x0400ADFC RID: 44540
			[Token(Token = "0x400ADFC")]
			[FieldOffset(Offset = "0x58")]
			public static Comparison<EmoteBaseInfo> <>9__72_7;

			// Token: 0x0400ADFD RID: 44541
			[Token(Token = "0x400ADFD")]
			[FieldOffset(Offset = "0x60")]
			public static Comparison<PinBaseInfo> <>9__72_8;
		}

		// Token: 0x02001E1E RID: 7710
		[Token(Token = "0x2001E1E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC404", Offset = "0x10FC404")]
		private sealed class <>c__DisplayClass84_0
		{
			// Token: 0x0600A8BC RID: 43196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8BC")]
			[Address(RVA = "0x2332A80", Offset = "0x2332A80", VA = "0x7BBCB32A80")]
			public <>c__DisplayClass84_0()
			{
			}

			// Token: 0x0600A8BD RID: 43197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8BD")]
			[Address(RVA = "0x2337934", Offset = "0x2337934", VA = "0x7BBCB37934")]
			internal void <RequestChooseBanner>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400ADFE RID: 44542
			[Token(Token = "0x400ADFE")]
			[FieldOffset(Offset = "0x10")]
			public UIModelCollection <>4__this;

			// Token: 0x0400ADFF RID: 44543
			[Token(Token = "0x400ADFF")]
			[FieldOffset(Offset = "0x18")]
			public uint bannerId;

			// Token: 0x0400AE00 RID: 44544
			[Token(Token = "0x400AE00")]
			[FieldOffset(Offset = "0x20")]
			public CSChooseBannerReq req;
		}

		// Token: 0x02001E1F RID: 7711
		[Token(Token = "0x2001E1F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC414", Offset = "0x10FC414")]
		private sealed class <>c__DisplayClass86_0
		{
			// Token: 0x0600A8BE RID: 43198 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8BE")]
			[Address(RVA = "0x2332FE0", Offset = "0x2332FE0", VA = "0x7BBCB32FE0")]
			public <>c__DisplayClass86_0()
			{
			}

			// Token: 0x0600A8BF RID: 43199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8BF")]
			[Address(RVA = "0x2338018", Offset = "0x2338018", VA = "0x7BBCB38018")]
			internal void <RequestChoosePin>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AE01 RID: 44545
			[Token(Token = "0x400AE01")]
			[FieldOffset(Offset = "0x10")]
			public UIModelCollection <>4__this;

			// Token: 0x0400AE02 RID: 44546
			[Token(Token = "0x400AE02")]
			[FieldOffset(Offset = "0x18")]
			public CSChoosePinReq req;
		}

		// Token: 0x02001E20 RID: 7712
		[Token(Token = "0x2001E20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC424", Offset = "0x10FC424")]
		private sealed class <>c__DisplayClass87_0
		{
			// Token: 0x0600A8C0 RID: 43200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8C0")]
			[Address(RVA = "0x2333284", Offset = "0x2333284", VA = "0x7BBCB33284")]
			public <>c__DisplayClass87_0()
			{
			}

			// Token: 0x0600A8C1 RID: 43201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8C1")]
			[Address(RVA = "0x23386A4", Offset = "0x23386A4", VA = "0x7BBCB386A4")]
			internal void <RequestChooseHeadPic>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AE03 RID: 44547
			[Token(Token = "0x400AE03")]
			[FieldOffset(Offset = "0x10")]
			public UIModelCollection <>4__this;

			// Token: 0x0400AE04 RID: 44548
			[Token(Token = "0x400AE04")]
			[FieldOffset(Offset = "0x18")]
			public uint headpic;

			// Token: 0x0400AE05 RID: 44549
			[Token(Token = "0x400AE05")]
			[FieldOffset(Offset = "0x20")]
			public CSChooseHeadPicReq req;
		}

		// Token: 0x02001E21 RID: 7713
		[Token(Token = "0x2001E21")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC434", Offset = "0x10FC434")]
		private sealed class <>c__DisplayClass88_0
		{
			// Token: 0x0600A8C2 RID: 43202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8C2")]
			[Address(RVA = "0x2333754", Offset = "0x2333754", VA = "0x7BBCB33754")]
			public <>c__DisplayClass88_0()
			{
			}

			// Token: 0x0600A8C3 RID: 43203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8C3")]
			[Address(RVA = "0x2338D70", Offset = "0x2338D70", VA = "0x7BBCB38D70")]
			internal void <RequestChooseEmote>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AE06 RID: 44550
			[Token(Token = "0x400AE06")]
			[FieldOffset(Offset = "0x10")]
			public UIModelCollection <>4__this;

			// Token: 0x0400AE07 RID: 44551
			[Token(Token = "0x400AE07")]
			[FieldOffset(Offset = "0x18")]
			public uint _emote_id;

			// Token: 0x0400AE08 RID: 44552
			[Token(Token = "0x400AE08")]
			[FieldOffset(Offset = "0x1C")]
			public uint _slotid;

			// Token: 0x0400AE09 RID: 44553
			[Token(Token = "0x400AE09")]
			[FieldOffset(Offset = "0x20")]
			public CSChooseEmoteReq req;
		}

		// Token: 0x02001E22 RID: 7714
		[Token(Token = "0x2001E22")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC444", Offset = "0x10FC444")]
		private sealed class <>c__DisplayClass91_0
		{
			// Token: 0x0600A8C4 RID: 43204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8C4")]
			[Address(RVA = "0x2334088", Offset = "0x2334088", VA = "0x7BBCB34088")]
			public <>c__DisplayClass91_0()
			{
			}

			// Token: 0x0600A8C5 RID: 43205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8C5")]
			[Address(RVA = "0x2339554", Offset = "0x2339554", VA = "0x7BBCB39554")]
			internal void <RequestChooseSlots>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AE0A RID: 44554
			[Token(Token = "0x400AE0A")]
			[FieldOffset(Offset = "0x10")]
			public UIModelCollection <>4__this;

			// Token: 0x0400AE0B RID: 44555
			[Token(Token = "0x400AE0B")]
			[FieldOffset(Offset = "0x18")]
			public CSChooseSlotsReq req;

			// Token: 0x0400AE0C RID: 44556
			[Token(Token = "0x400AE0C")]
			[FieldOffset(Offset = "0x20")]
			public List<uint> reqList;
		}

		// Token: 0x02001E23 RID: 7715
		[Token(Token = "0x2001E23")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC454", Offset = "0x10FC454")]
		private sealed class <>c__DisplayClass92_0
		{
			// Token: 0x0600A8C6 RID: 43206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8C6")]
			[Address(RVA = "0x2334560", Offset = "0x2334560", VA = "0x7BBCB34560")]
			public <>c__DisplayClass92_0()
			{
			}

			// Token: 0x0600A8C7 RID: 43207 RVA: 0x0002DAC8 File Offset: 0x0002BCC8
			[Token(Token = "0x600A8C7")]
			[Address(RVA = "0x2339AA0", Offset = "0x2339AA0", VA = "0x7BBCB39AA0")]
			internal bool <SetSlotReqListValue>b__0(uint a)
			{
				return default(bool);
			}

			// Token: 0x0400AE0D RID: 44557
			[Token(Token = "0x400AE0D")]
			[FieldOffset(Offset = "0x10")]
			public WeaponSkinData wSkinData;
		}

		// Token: 0x02001E24 RID: 7716
		[Token(Token = "0x2001E24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC464", Offset = "0x10FC464")]
		private sealed class <>c__DisplayClass92_1
		{
			// Token: 0x0600A8C8 RID: 43208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8C8")]
			[Address(RVA = "0x2334568", Offset = "0x2334568", VA = "0x7BBCB34568")]
			public <>c__DisplayClass92_1()
			{
			}

			// Token: 0x0600A8C9 RID: 43209 RVA: 0x0002DAE0 File Offset: 0x0002BCE0
			[Token(Token = "0x600A8C9")]
			[Address(RVA = "0x2339AD8", Offset = "0x2339AD8", VA = "0x7BBCB39AD8")]
			internal bool <SetSlotReqListValue>b__1(uint a)
			{
				return default(bool);
			}

			// Token: 0x0400AE0E RID: 44558
			[Token(Token = "0x400AE0E")]
			[FieldOffset(Offset = "0x10")]
			public VehicleSkinData vSkinData;
		}

		// Token: 0x02001E25 RID: 7717
		[Token(Token = "0x2001E25")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC474", Offset = "0x10FC474")]
		private sealed class <>c__DisplayClass93_0
		{
			// Token: 0x0600A8CA RID: 43210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8CA")]
			[Address(RVA = "0x2334A20", Offset = "0x2334A20", VA = "0x7BBCB34A20")]
			public <>c__DisplayClass93_0()
			{
			}

			// Token: 0x0600A8CB RID: 43211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8CB")]
			[Address(RVA = "0x2339B10", Offset = "0x2339B10", VA = "0x7BBCB39B10")]
			internal void <RequestChooseSlots>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AE0F RID: 44559
			[Token(Token = "0x400AE0F")]
			[FieldOffset(Offset = "0x10")]
			public UIModelCollection <>4__this;

			// Token: 0x0400AE10 RID: 44560
			[Token(Token = "0x400AE10")]
			[FieldOffset(Offset = "0x18")]
			public CSChooseSlotsReq req;

			// Token: 0x0400AE11 RID: 44561
			[Token(Token = "0x400AE11")]
			[FieldOffset(Offset = "0x20")]
			public List<uint> reqList;

			// Token: 0x0400AE12 RID: 44562
			[Token(Token = "0x400AE12")]
			[FieldOffset(Offset = "0x28")]
			public uint itemID;
		}
	}
}
