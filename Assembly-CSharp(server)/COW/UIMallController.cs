using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001586 RID: 5510
	[Token(Token = "0x2001586")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEC24", Offset = "0x10EEC24")]
	public class UIMallController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06006021 RID: 24609 RVA: 0x0001BC60 File Offset: 0x00019E60
		// (set) Token: 0x06006022 RID: 24610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008BA")]
		public EGiftStore_BuddyType FriendType
		{
			[Token(Token = "0x6006021")]
			[Address(RVA = "0x1C57BC0", Offset = "0x1C57BC0", VA = "0x7BBC457BC0")]
			get
			{
				return EGiftStore_BuddyType.BT_NONE;
			}
			[Token(Token = "0x6006022")]
			[Address(RVA = "0x1C57BC8", Offset = "0x1C57BC8", VA = "0x7BBC457BC8")]
			set
			{
			}
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x0001BC78 File Offset: 0x00019E78
		[Token(Token = "0x6006023")]
		[Address(RVA = "0x1C57BD0", Offset = "0x1C57BD0", VA = "0x7BBC457BD0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006024")]
		[Address(RVA = "0x1C57C20", Offset = "0x1C57C20", VA = "0x7BBC457C20", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006025")]
		[Address(RVA = "0x1C58808", Offset = "0x1C58808", VA = "0x7BBC458808")]
		private void DownLoadCDNTexture()
		{
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006026")]
		[Address(RVA = "0x1C5868C", Offset = "0x1C5868C", VA = "0x7BBC45868C")]
		private void InitToggleDict()
		{
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006027")]
		[Address(RVA = "0x1C58DB4", Offset = "0x1C58DB4", VA = "0x7BBC458DB4", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006028")]
		[Address(RVA = "0x1C5A9F4", Offset = "0x1C5A9F4", VA = "0x7BBC45A9F4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113FD34", Offset = "0x113FD34")]
		private IEnumerator PopMysteryCoroutine()
		{
			return null;
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006029")]
		[Address(RVA = "0x1C5A898", Offset = "0x1C5A898", VA = "0x7BBC45A898")]
		private void RefreshMallView()
		{
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602A")]
		[Address(RVA = "0x1C5A28C", Offset = "0x1C5A28C", VA = "0x7BBC45A28C")]
		private void NavigationToItemOnShowed()
		{
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602B")]
		[Address(RVA = "0x1C59B24", Offset = "0x1C59B24", VA = "0x7BBC459B24")]
		private void ShowAvatar()
		{
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602C")]
		[Address(RVA = "0x1C59264", Offset = "0x1C59264", VA = "0x7BBC459264")]
		private void SetNavigationData(UINavigationData navigationData)
		{
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602D")]
		[Address(RVA = "0x1C598CC", Offset = "0x1C598CC", VA = "0x7BBC4598CC")]
		private void SetCommonPanel()
		{
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602E")]
		[Address(RVA = "0x1C5B200", Offset = "0x1C5B200", VA = "0x7BBC45B200", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602F")]
		[Address(RVA = "0x1C5B458", Offset = "0x1C5B458", VA = "0x7BBC45B458")]
		private void ClickBundleItem(params object[] data)
		{
		}

		// Token: 0x06006030 RID: 24624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006030")]
		[Address(RVA = "0x1C5B4B4", Offset = "0x1C5B4B4", VA = "0x7BBC45B4B4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006031")]
		[Address(RVA = "0x1C5B570", Offset = "0x1C5B570", VA = "0x7BBC45B570")]
		private void SendMallItemClickLog()
		{
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006032")]
		[Address(RVA = "0x1C5B9E8", Offset = "0x1C5B9E8", VA = "0x7BBC45B9E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x0001BC90 File Offset: 0x00019E90
		[Token(Token = "0x6006033")]
		[Address(RVA = "0x1C5BE94", Offset = "0x1C5BE94", VA = "0x7BBC45BE94", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x0001BCA8 File Offset: 0x00019EA8
		[Token(Token = "0x6006034")]
		[Address(RVA = "0x1C5BE9C", Offset = "0x1C5BE9C", VA = "0x7BBC45BE9C", Slot = "34")]
		public override AdType GetBackgroundCDNImageType()
		{
			return AdType.AdType_NONE;
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006035")]
		[Address(RVA = "0x1C5BEA4", Offset = "0x1C5BEA4", VA = "0x7BBC45BEA4")]
		private void OnVaultBtnClick()
		{
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006036")]
		[Address(RVA = "0x1C5C108", Offset = "0x1C5C108", VA = "0x7BBC45C108")]
		private void OnChooseCharacter()
		{
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006037")]
		[Address(RVA = "0x1C5ABDC", Offset = "0x1C5ABDC", VA = "0x7BBC45ABDC")]
		public void NavigationToItem(UINavigationUtil.UINavigationMallType mallType, uint storeID)
		{
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006038")]
		[Address(RVA = "0x1C5AA80", Offset = "0x1C5AA80", VA = "0x7BBC45AA80")]
		public void NavigationToItem(UINavigationUtil.UINavigationMallType mallType, uint mallTabType, uint subTabType, uint storeID)
		{
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006039")]
		[Address(RVA = "0x1C5C1F4", Offset = "0x1C5C1F4", VA = "0x7BBC45C1F4")]
		private void OnLabelModelHintChange(params object[] data)
		{
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603A")]
		[Address(RVA = "0x1C5C20C", Offset = "0x1C5C20C", VA = "0x7BBC45C20C")]
		private void OnItemClick(params object[] data)
		{
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603B")]
		[Address(RVA = "0x1C5C57C", Offset = "0x1C5C57C", VA = "0x7BBC45C57C")]
		private void OnItemSelected(params object[] data)
		{
		}

		// Token: 0x0600603C RID: 24636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603C")]
		[Address(RVA = "0x1C5CA18", Offset = "0x1C5CA18", VA = "0x7BBC45CA18")]
		private void PlayFullScreenAnim(FullscreenCgDesc animData)
		{
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603D")]
		[Address(RVA = "0x1C5CC38", Offset = "0x1C5CC38", VA = "0x7BBC45CC38")]
		private void OnAvatarUpdate(params object[] data)
		{
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603E")]
		[Address(RVA = "0x1C5CE0C", Offset = "0x1C5CE0C", VA = "0x7BBC45CE0C")]
		private void ShowMallItemTypeError(params object[] data)
		{
		}

		// Token: 0x0600603F RID: 24639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603F")]
		[Address(RVA = "0x1C5D014", Offset = "0x1C5D014", VA = "0x7BBC45D014")]
		private void RefreshClothPreviewTab(params object[] data)
		{
		}

		// Token: 0x06006040 RID: 24640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006040")]
		[Address(RVA = "0x1C5D190", Offset = "0x1C5D190", VA = "0x7BBC45D190")]
		private void OnHideClothesSlot(params object[] data)
		{
		}

		// Token: 0x06006041 RID: 24641 RVA: 0x0001BCC0 File Offset: 0x00019EC0
		[Token(Token = "0x6006041")]
		[Address(RVA = "0x1C5D360", Offset = "0x1C5D360", VA = "0x7BBC45D360", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006042 RID: 24642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006042")]
		[Address(RVA = "0x1C5D3E4", Offset = "0x1C5D3E4", VA = "0x7BBC45D3E4", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006043 RID: 24643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006043")]
		[Address(RVA = "0x1C5A05C", Offset = "0x1C5A05C", VA = "0x7BBC45A05C")]
		private void InitMallView(bool refreshCurrentMallCtrl = false)
		{
		}

		// Token: 0x06006044 RID: 24644 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		[Token(Token = "0x6006044")]
		[Address(RVA = "0x1C59ADC", Offset = "0x1C59ADC", VA = "0x7BBC459ADC")]
		private bool IsDataReady()
		{
			return default(bool);
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006045")]
		[Address(RVA = "0x1C5D82C", Offset = "0x1C5D82C", VA = "0x7BBC45D82C")]
		private void UpdateTabs()
		{
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x0001BCF0 File Offset: 0x00019EF0
		[Token(Token = "0x6006046")]
		[Address(RVA = "0x1C5DD3C", Offset = "0x1C5DD3C", VA = "0x7BBC45DD3C")]
		private bool IsOpenNavToggle(UINavigationUtil.UINavigationMallType type)
		{
			return default(bool);
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006047")]
		[Address(RVA = "0x1C5DD44", Offset = "0x1C5DD44", VA = "0x7BBC45DD44")]
		public static void SetSpriteWithStoreInfo(uint itemId, UISprite iconSprite, bool isBigIcon = false)
		{
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x0001BD08 File Offset: 0x00019F08
		[Token(Token = "0x6006048")]
		[Address(RVA = "0x1C5E054", Offset = "0x1C5E054", VA = "0x7BBC45E054", Slot = "37")]
		public override bool OverwriteBackButtonLogic()
		{
			return default(bool);
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006049")]
		[Address(RVA = "0x1C5E150", Offset = "0x1C5E150", VA = "0x7BBC45E150")]
		private void OnAnimPlayBtnClick()
		{
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604A")]
		[Address(RVA = "0x1C5E55C", Offset = "0x1C5E55C", VA = "0x7BBC45E55C")]
		private void OnNormalMallToggleClick()
		{
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604B")]
		[Address(RVA = "0x1C5E64C", Offset = "0x1C5E64C", VA = "0x7BBC45E64C")]
		private void OnWeaponMallToggleClick()
		{
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604C")]
		[Address(RVA = "0x1C5E73C", Offset = "0x1C5E73C", VA = "0x7BBC45E73C")]
		private void OnBoxMallToggleClick()
		{
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604D")]
		[Address(RVA = "0x1C5E82C", Offset = "0x1C5E82C", VA = "0x7BBC45E82C")]
		private void OnGiftMallToggleClick()
		{
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604E")]
		[Address(RVA = "0x1C5E91C", Offset = "0x1C5E91C", VA = "0x7BBC45E91C")]
		private void OnExchangeMallToggleClick()
		{
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604F")]
		[Address(RVA = "0x1C5A40C", Offset = "0x1C5A40C", VA = "0x7BBC45A40C")]
		private void SelectMall(UINavigationUtil.UINavigationMallType mallType)
		{
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006050")]
		[Address(RVA = "0x1C5EB3C", Offset = "0x1C5EB3C", VA = "0x7BBC45EB3C")]
		private UIMallDetailBaseController CreateMallDetailController(UINavigationUtil.UINavigationMallType mallType)
		{
			return null;
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006051")]
		[Address(RVA = "0x1C5EDE8", Offset = "0x1C5EDE8", VA = "0x7BBC45EDE8")]
		public void IsShowMallToggle(bool show)
		{
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006052")]
		[Address(RVA = "0x1C5EE48", Offset = "0x1C5EE48", VA = "0x7BBC45EE48")]
		public void IsShowTopBar(bool show)
		{
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006053")]
		[Address(RVA = "0x1C5EE90", Offset = "0x1C5EE90", VA = "0x7BBC45EE90")]
		public void IsShowAnimPlayBtn(bool show)
		{
		}

		// Token: 0x06006054 RID: 24660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006054")]
		[Address(RVA = "0x1C5EEF0", Offset = "0x1C5EEF0", VA = "0x7BBC45EEF0", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06006055 RID: 24661 RVA: 0x0001BD20 File Offset: 0x00019F20
		[Token(Token = "0x6006055")]
		[Address(RVA = "0x1C5F040", Offset = "0x1C5F040", VA = "0x7BBC45F040", Slot = "32")]
		protected override bool NeedWaitDataReady()
		{
			return default(bool);
		}

		// Token: 0x06006056 RID: 24662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006056")]
		[Address(RVA = "0x1C5F048", Offset = "0x1C5F048", VA = "0x7BBC45F048")]
		private void OnHairUpdate(params object[] data)
		{
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006057")]
		[Address(RVA = "0x1C5F304", Offset = "0x1C5F304", VA = "0x7BBC45F304")]
		public UIMallController()
		{
		}

		// Token: 0x04008057 RID: 32855
		[Token(Token = "0x4008057")]
		[FieldOffset(Offset = "0xB0")]
		private List<FriendInfo> m_SelectFriendList;

		// Token: 0x04008058 RID: 32856
		[Token(Token = "0x4008058")]
		[FieldOffset(Offset = "0xB8")]
		private EGiftStore_BuddyType m_FriendType;

		// Token: 0x04008059 RID: 32857
		[Token(Token = "0x4008059")]
		[FieldOffset(Offset = "0xBC")]
		private CollectionDataManager.ECollectionWeaponType m_WeaponPageFilterType;

		// Token: 0x0400805A RID: 32858
		[Token(Token = "0x400805A")]
		[FieldOffset(Offset = "0xC0")]
		private uint m_WeaponPageFilterId;

		// Token: 0x0400805B RID: 32859
		[Token(Token = "0x400805B")]
		[FieldOffset(Offset = "0xC8")]
		private UIMallViewExt m_View;

		// Token: 0x0400805C RID: 32860
		[Token(Token = "0x400805C")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_ADDataInitialized;

		// Token: 0x0400805D RID: 32861
		[Token(Token = "0x400805D")]
		[FieldOffset(Offset = "0xD1")]
		private bool m_DataInitialized;

		// Token: 0x0400805E RID: 32862
		[Token(Token = "0x400805E")]
		[FieldOffset(Offset = "0xD2")]
		private bool m_GiftDataInitialized;

		// Token: 0x0400805F RID: 32863
		[Token(Token = "0x400805F")]
		[FieldOffset(Offset = "0xD3")]
		private bool m_ExchangeDataInitialized;

		// Token: 0x04008060 RID: 32864
		[Token(Token = "0x4008060")]
		[FieldOffset(Offset = "0xD4")]
		private bool m_GiftRankDescDataInitialized;

		// Token: 0x04008061 RID: 32865
		[Token(Token = "0x4008061")]
		[FieldOffset(Offset = "0xD5")]
		private bool m_DiscountDataInitialized;

		// Token: 0x04008062 RID: 32866
		[Token(Token = "0x4008062")]
		[FieldOffset(Offset = "0xD6")]
		private bool m_InstallmentDataInitialized;

		// Token: 0x04008063 RID: 32867
		[Token(Token = "0x4008063")]
		[FieldOffset(Offset = "0xD8")]
		private UIRoot m_UIRoot;

		// Token: 0x04008064 RID: 32868
		[Token(Token = "0x4008064")]
		[FieldOffset(Offset = "0xE0")]
		private UINavigationData m_LastNavigationData;

		// Token: 0x04008065 RID: 32869
		[Token(Token = "0x4008065")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_HasUnFinishNavigation;

		// Token: 0x04008066 RID: 32870
		[Token(Token = "0x4008066")]
		[FieldOffset(Offset = "0xEC")]
		private UINavigationUtil.UINavigationMallType navMallType;

		// Token: 0x04008067 RID: 32871
		[Token(Token = "0x4008067")]
		[FieldOffset(Offset = "0xF0")]
		private uint navMallTabType;

		// Token: 0x04008068 RID: 32872
		[Token(Token = "0x4008068")]
		[FieldOffset(Offset = "0xF4")]
		private uint navMallSubTabType;

		// Token: 0x04008069 RID: 32873
		[Token(Token = "0x4008069")]
		[FieldOffset(Offset = "0xF8")]
		private uint navMallItemId;

		// Token: 0x0400806A RID: 32874
		[Token(Token = "0x400806A")]
		[FieldOffset(Offset = "0x100")]
		private List<uint> navMallItemIdList;

		// Token: 0x0400806B RID: 32875
		[Token(Token = "0x400806B")]
		[FieldOffset(Offset = "0x108")]
		private UIModelMall m_ModelMall;

		// Token: 0x0400806C RID: 32876
		[Token(Token = "0x400806C")]
		[FieldOffset(Offset = "0x110")]
		private UIModelGift m_ModelGift;

		// Token: 0x0400806D RID: 32877
		[Token(Token = "0x400806D")]
		[FieldOffset(Offset = "0x118")]
		private UIModelAvatar m_ModelAvatar;

		// Token: 0x0400806E RID: 32878
		[Token(Token = "0x400806E")]
		[FieldOffset(Offset = "0x120")]
		private bool m_InitMall;

		// Token: 0x0400806F RID: 32879
		[Token(Token = "0x400806F")]
		[FieldOffset(Offset = "0x124")]
		private uint m_SelectedItemId;

		// Token: 0x04008070 RID: 32880
		[Token(Token = "0x4008070")]
		[FieldOffset(Offset = "0x128")]
		private List<UIMallDetailBaseController> m_MallList;

		// Token: 0x04008071 RID: 32881
		[Token(Token = "0x4008071")]
		[FieldOffset(Offset = "0x130")]
		private UIMallDetailBaseController m_CurrentMallController;

		// Token: 0x04008072 RID: 32882
		[Token(Token = "0x4008072")]
		[FieldOffset(Offset = "0x138")]
		private Dictionary<UINavigationUtil.UINavigationMallType, UIToggleButton> m_MallToggleDict;

		// Token: 0x04008073 RID: 32883
		[Token(Token = "0x4008073")]
		[FieldOffset(Offset = "0x140")]
		private bool m_IsInMall;

		// Token: 0x04008074 RID: 32884
		[Token(Token = "0x4008074")]
		[FieldOffset(Offset = "0x148")]
		private FullscreenCgDesc m_AnimData;

		// Token: 0x04008075 RID: 32885
		[Token(Token = "0x4008075")]
		[FieldOffset(Offset = "0x150")]
		private List<string> m_URLList;

		// Token: 0x04008076 RID: 32886
		[Token(Token = "0x4008076")]
		[FieldOffset(Offset = "0x158")]
		private uint m_LastAvatarId;

		// Token: 0x04008077 RID: 32887
		[Token(Token = "0x4008077")]
		[FieldOffset(Offset = "0x15C")]
		private bool m_ChangeAvatar;

		// Token: 0x04008078 RID: 32888
		[Token(Token = "0x4008078")]
		[FieldOffset(Offset = "0x160")]
		private GameObject m_MallGround;

		// Token: 0x04008079 RID: 32889
		[Token(Token = "0x4008079")]
		[FieldOffset(Offset = "0x168")]
		private Dictionary<string, uint> m_MallItemClickLogCache;

		// Token: 0x0400807A RID: 32890
		[Token(Token = "0x400807A")]
		[FieldOffset(Offset = "0x170")]
		private bool m_NeedPopMystery;

		// Token: 0x02001587 RID: 5511
		[Token(Token = "0x2001587")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EEC5C", Offset = "0x10EEC5C")]
		private sealed class <PopMysteryCoroutine>d__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006058 RID: 24664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006058")]
			[Address(RVA = "0x1C5AA54", Offset = "0x1C5AA54", VA = "0x7BBC45AA54")]
			[DebuggerHidden]
			public <PopMysteryCoroutine>d__44(int <>1__state)
			{
			}

			// Token: 0x06006059 RID: 24665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006059")]
			[Address(RVA = "0x1C5F424", Offset = "0x1C5F424", VA = "0x7BBC45F424", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600605A RID: 24666 RVA: 0x0001BD38 File Offset: 0x00019F38
			[Token(Token = "0x600605A")]
			[Address(RVA = "0x1C5F428", Offset = "0x1C5F428", VA = "0x7BBC45F428", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008BB RID: 2235
			// (get) Token: 0x0600605B RID: 24667 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008BB")]
			private object Current
			{
				[Token(Token = "0x600605B")]
				[Address(RVA = "0x1C5F464", Offset = "0x1C5F464", VA = "0x7BBC45F464", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600605C RID: 24668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600605C")]
			[Address(RVA = "0x1C5F46C", Offset = "0x1C5F46C", VA = "0x7BBC45F46C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008BC RID: 2236
			// (get) Token: 0x0600605D RID: 24669 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008BC")]
			private object Current
			{
				[Token(Token = "0x600605D")]
				[Address(RVA = "0x1C5F4D4", Offset = "0x1C5F4D4", VA = "0x7BBC45F4D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400807B RID: 32891
			[Token(Token = "0x400807B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400807C RID: 32892
			[Token(Token = "0x400807C")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;
		}
	}
}
