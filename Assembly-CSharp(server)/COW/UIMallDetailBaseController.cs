using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001590 RID: 5520
	[Token(Token = "0x2001590")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EECA4", Offset = "0x10EECA4")]
	public class UIMallDetailBaseController : UIBaseController
	{
		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600606E RID: 24686 RVA: 0x0001BD68 File Offset: 0x00019F68
		[Token(Token = "0x170008BD")]
		public bool SwitchPreviewSlot
		{
			[Token(Token = "0x600606E")]
			[Address(RVA = "0x1C5AECC", Offset = "0x1C5AECC", VA = "0x7BBC45AECC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x0600606F RID: 24687 RVA: 0x0001BD80 File Offset: 0x00019F80
		[Token(Token = "0x170008BE")]
		public uint CurrentAvatarId
		{
			[Token(Token = "0x600606F")]
			[Address(RVA = "0x1C5ACDC", Offset = "0x1C5ACDC", VA = "0x7BBC45ACDC")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x0001BD98 File Offset: 0x00019F98
		[Token(Token = "0x170008BF")]
		public UINavigationUtil.UINavigationMallType MallType
		{
			[Token(Token = "0x6006070")]
			[Address(RVA = "0x1C5A404", Offset = "0x1C5A404", VA = "0x7BBC45A404")]
			get
			{
				return UINavigationUtil.UINavigationMallType.MallTypeNone;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06006071 RID: 24689 RVA: 0x0001BDB0 File Offset: 0x00019FB0
		[Token(Token = "0x170008C0")]
		public uint CurrentTab
		{
			[Token(Token = "0x6006071")]
			[Address(RVA = "0x1C5C56C", Offset = "0x1C5C56C", VA = "0x7BBC45C56C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06006072 RID: 24690 RVA: 0x0001BDC8 File Offset: 0x00019FC8
		[Token(Token = "0x170008C1")]
		public uint CurrentSubTab
		{
			[Token(Token = "0x6006072")]
			[Address(RVA = "0x1C5C574", Offset = "0x1C5C574", VA = "0x7BBC45C574")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006073")]
		[Address(RVA = "0x1C60048", Offset = "0x1C60048", VA = "0x7BBC460048", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006074")]
		[Address(RVA = "0x1C603BC", Offset = "0x1C603BC", VA = "0x7BBC4603BC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006075")]
		[Address(RVA = "0x1C60578", Offset = "0x1C60578", VA = "0x7BBC460578")]
		protected void InitClothPreviewToggles()
		{
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006076")]
		[Address(RVA = "0x1C60A58", Offset = "0x1C60A58", VA = "0x7BBC460A58", Slot = "28")]
		protected virtual void InitBuyBtnStyle()
		{
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006077")]
		[Address(RVA = "0x1C60A5C", Offset = "0x1C60A5C", VA = "0x7BBC460A5C", Slot = "29")]
		protected virtual void OnClothPreviewToggleClick()
		{
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006078")]
		[Address(RVA = "0x1C60A60", Offset = "0x1C60A60", VA = "0x7BBC460A60")]
		private void OnUnDressBtnClick()
		{
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006079")]
		[Address(RVA = "0x1C610A4", Offset = "0x1C610A4", VA = "0x7BBC4610A4", Slot = "30")]
		protected virtual void UnSelectItem(uint itemID)
		{
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607A")]
		[Address(RVA = "0x1C5AC24", Offset = "0x1C5AC24", VA = "0x7BBC45AC24")]
		public void ResetAvatarAndSelectedClothData()
		{
		}

		// Token: 0x0600607B RID: 24699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607B")]
		[Address(RVA = "0x1C610F4", Offset = "0x1C610F4", VA = "0x7BBC4610F4")]
		private void ResetClothPreviewTogglesState()
		{
		}

		// Token: 0x0600607C RID: 24700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607C")]
		[Address(RVA = "0x1C61220", Offset = "0x1C61220", VA = "0x7BBC461220")]
		protected void ReSetClothPreviewTabSprite(PreviewTabInfo tabInfo)
		{
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607D")]
		[Address(RVA = "0x1C612DC", Offset = "0x1C612DC", VA = "0x7BBC4612DC")]
		protected void FadeClothPreviewTabSprite(PreviewTabInfo tabInfo)
		{
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607E")]
		[Address(RVA = "0x1C61418", Offset = "0x1C61418", VA = "0x7BBC461418")]
		protected void RefreshClothPreviewToggleState(Dictionary<UIModelAvatarBase.EWardrobeType, SlotClothInfo> selectedClothDict, bool isSelectedSet = false, [Optional] UIToggleButton tb)
		{
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607F")]
		[Address(RVA = "0x1C61A6C", Offset = "0x1C61A6C", VA = "0x7BBC461A6C")]
		protected void CheckSelectedClothState(Dictionary<UIModelAvatarBase.EWardrobeType, SlotClothInfo> selectedClothDict)
		{
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006080")]
		[Address(RVA = "0x1C60EC8", Offset = "0x1C60EC8", VA = "0x7BBC460EC8")]
		private void ResetPreviewTabInfo(PreviewTabInfo tabInfo)
		{
		}

		// Token: 0x06006081 RID: 24705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006081")]
		[Address(RVA = "0x1C5C208", Offset = "0x1C5C208", VA = "0x7BBC45C208")]
		public void OnLabelModelHintChange(params object[] data)
		{
		}

		// Token: 0x06006082 RID: 24706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006082")]
		[Address(RVA = "0x1C5D048", Offset = "0x1C5D048", VA = "0x7BBC45D048")]
		public void RefreshClothPreview(params object[] data)
		{
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006083")]
		[Address(RVA = "0x1C61FD0", Offset = "0x1C61FD0", VA = "0x7BBC461FD0")]
		private void RefreshClothPreview(uint storeID, uint itemID, Dictionary<UIModelAvatarBase.EWardrobeType, SlotClothInfo> selectedClothDict, ref bool isSelectedSet)
		{
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006084")]
		[Address(RVA = "0x1C62B2C", Offset = "0x1C62B2C", VA = "0x7BBC462B2C", Slot = "31")]
		protected virtual void SetClothPreviewTabInfo(PreviewTabInfo tabInfo, CSSharedItemData itemData)
		{
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006085")]
		[Address(RVA = "0x1C62C40", Offset = "0x1C62C40", VA = "0x7BBC462C40")]
		protected void OnSwitchClothPreviewBtnClick()
		{
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006086")]
		[Address(RVA = "0x1C62F8C", Offset = "0x1C62F8C", VA = "0x7BBC462F8C")]
		protected void SetClothPreviewTogglesInfo(Dictionary<UIModelAvatarBase.EWardrobeType, SlotClothInfo> selectedClothDict, bool isSelectedSet)
		{
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006087")]
		[Address(RVA = "0x1C62998", Offset = "0x1C62998", VA = "0x7BBC462998")]
		private void RefreshClothPreviewTabOnSwith(bool trySameGender = false)
		{
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006088")]
		[Address(RVA = "0x1C634C0", Offset = "0x1C634C0", VA = "0x7BBC4634C0")]
		protected void SetSwithClothGenderBtnState(bool isSelfFemale, bool isSwitchPreviewSlot)
		{
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x0001BDE0 File Offset: 0x00019FE0
		[Token(Token = "0x6006089")]
		[Address(RVA = "0x1C633C0", Offset = "0x1C633C0", VA = "0x7BBC4633C0")]
		private bool HasInvalidClothesForHeadAdditive(uint avatarId, Dictionary<UIModelAvatarBase.EWardrobeType, SlotClothInfo> clothes)
		{
			return default(bool);
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x0001BDF8 File Offset: 0x00019FF8
		[Token(Token = "0x600608A")]
		[Address(RVA = "0x1C63388", Offset = "0x1C63388", VA = "0x7BBC463388")]
		protected uint FindDefaultAvatarIDByGender(bool female)
		{
			return 0U;
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608B")]
		[Address(RVA = "0x1C5D1C4", Offset = "0x1C5D1C4", VA = "0x7BBC45D1C4")]
		public void OnHideClothesSlot(params object[] data)
		{
		}

		// Token: 0x0600608C RID: 24716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600608C")]
		[Address(RVA = "0x1C63530", Offset = "0x1C63530", VA = "0x7BBC463530")]
		private PreviewTabInfo GetPreviewTab(string slotName)
		{
			return null;
		}

		// Token: 0x0600608D RID: 24717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608D")]
		[Address(RVA = "0x1C63720", Offset = "0x1C63720", VA = "0x7BBC463720")]
		protected void SetMallController()
		{
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608E")]
		[Address(RVA = "0x1C5EA5C", Offset = "0x1C5EA5C", VA = "0x7BBC45EA5C")]
		public void RefreshMallToInit()
		{
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608F")]
		[Address(RVA = "0x1C5EA0C", Offset = "0x1C5EA0C", VA = "0x7BBC45EA0C")]
		public void PlayToggleMoveAnim()
		{
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006090")]
		[Address(RVA = "0x1C5D7B4", Offset = "0x1C5D7B4", VA = "0x7BBC45D7B4")]
		public void RefreshMallViewAndSelectItem()
		{
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x0001BE10 File Offset: 0x0001A010
		[Token(Token = "0x6006091")]
		[Address(RVA = "0x1C63804", Offset = "0x1C63804", VA = "0x7BBC463804", Slot = "32")]
		protected virtual bool CanFindStoreItem(uint storeID)
		{
			return default(bool);
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006092")]
		[Address(RVA = "0x1C6380C", Offset = "0x1C6380C", VA = "0x7BBC46380C", Slot = "33")]
		public virtual void HighlightCurrent()
		{
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006093")]
		[Address(RVA = "0x1C63810", Offset = "0x1C63810", VA = "0x7BBC463810", Slot = "34")]
		public virtual void ResetCurrentMall()
		{
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x0001BE28 File Offset: 0x0001A028
		[Token(Token = "0x6006094")]
		[Address(RVA = "0x1C63814", Offset = "0x1C63814", VA = "0x7BBC463814", Slot = "35")]
		public virtual bool OverwriteBackButtonLogic()
		{
			return default(bool);
		}

		// Token: 0x06006095 RID: 24725 RVA: 0x0001BE40 File Offset: 0x0001A040
		[Token(Token = "0x6006095")]
		[Address(RVA = "0x1C638F4", Offset = "0x1C638F4", VA = "0x7BBC4638F4")]
		protected bool SelectClothByGender(uint id, EClothGenderType genderType)
		{
			return default(bool);
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006096")]
		[Address(RVA = "0x1C639F0", Offset = "0x1C639F0", VA = "0x7BBC4639F0")]
		protected void CreateMallTab(List<uint> toggleList, bool needFixationTab = false)
		{
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006097")]
		[Address(RVA = "0x1C6426C", Offset = "0x1C6426C", VA = "0x7BBC46426C", Slot = "36")]
		protected virtual void AddMallToggleClickEvent()
		{
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006098")]
		[Address(RVA = "0x1C6449C", Offset = "0x1C6449C", VA = "0x7BBC46449C")]
		protected void HighLightItem(int itemIndex, UIEasyList grid, bool needClick = false, bool needScroll = true, bool showTips = false)
		{
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006099")]
		[Address(RVA = "0x1C64710", Offset = "0x1C64710", VA = "0x7BBC464710", Slot = "37")]
		protected virtual void OnADToggleSelected()
		{
		}

		// Token: 0x0600609A RID: 24730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609A")]
		[Address(RVA = "0x1C64818", Offset = "0x1C64818", VA = "0x7BBC464818", Slot = "38")]
		protected virtual void OnNewsToggleSelected()
		{
		}

		// Token: 0x0600609B RID: 24731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609B")]
		[Address(RVA = "0x1C64BAC", Offset = "0x1C64BAC", VA = "0x7BBC464BAC", Slot = "39")]
		protected virtual void OnBundleToggleSelected()
		{
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609C")]
		[Address(RVA = "0x1C64CE8", Offset = "0x1C64CE8", VA = "0x7BBC464CE8", Slot = "40")]
		protected virtual void OnAvatarToggleSelected()
		{
		}

		// Token: 0x0600609D RID: 24733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609D")]
		[Address(RVA = "0x1C64E10", Offset = "0x1C64E10", VA = "0x7BBC464E10", Slot = "41")]
		protected virtual void OnCustomizeToggleSelected()
		{
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609E")]
		[Address(RVA = "0x1C64FB0", Offset = "0x1C64FB0", VA = "0x7BBC464FB0", Slot = "42")]
		protected virtual void OnPropsToggleSelected()
		{
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609F")]
		[Address(RVA = "0x1C650EC", Offset = "0x1C650EC", VA = "0x7BBC4650EC", Slot = "43")]
		protected virtual void OnCallSignToggleSelected()
		{
		}

		// Token: 0x060060A0 RID: 24736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A0")]
		[Address(RVA = "0x1C65214", Offset = "0x1C65214", VA = "0x7BBC465214", Slot = "44")]
		protected virtual void OnWeaponToggleSelected()
		{
		}

		// Token: 0x060060A1 RID: 24737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A1")]
		[Address(RVA = "0x1C65350", Offset = "0x1C65350", VA = "0x7BBC465350", Slot = "45")]
		protected virtual void OnPetToggleSelected()
		{
		}

		// Token: 0x060060A2 RID: 24738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A2")]
		[Address(RVA = "0x1C65478", Offset = "0x1C65478", VA = "0x7BBC465478", Slot = "46")]
		protected virtual void OnAllToggleSelected()
		{
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A3")]
		[Address(RVA = "0x1C655B4", Offset = "0x1C655B4", VA = "0x7BBC4655B4", Slot = "47")]
		protected virtual void OnExclusiveToggleSelected()
		{
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A4")]
		[Address(RVA = "0x1C656F0", Offset = "0x1C656F0", VA = "0x7BBC4656F0", Slot = "48")]
		protected virtual void OnTreasureBoxToggleSelected()
		{
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x0001BE58 File Offset: 0x0001A058
		[Token(Token = "0x60060A5")]
		[Address(RVA = "0x1C6582C", Offset = "0x1C6582C", VA = "0x7BBC46582C")]
		protected ulong CalculateDiscountRefreshTime()
		{
			return 0UL;
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A6")]
		[Address(RVA = "0x1C6499C", Offset = "0x1C6499C", VA = "0x7BBC46499C")]
		protected void SetMallWidgetPosByType(EMallScrollViewPosType type)
		{
		}

		// Token: 0x060060A7 RID: 24743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A7")]
		[Address(RVA = "0x1C65A0C", Offset = "0x1C65A0C", VA = "0x7BBC465A0C", Slot = "49")]
		protected virtual void RefreshCurrentTabView(UINavigationUtil.UINavigationMallTabType mallTabType)
		{
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A8")]
		[Address(RVA = "0x1C65A10", Offset = "0x1C65A10", VA = "0x7BBC465A10", Slot = "50")]
		public virtual void HideItemEffect()
		{
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A9")]
		[Address(RVA = "0x1C65A14", Offset = "0x1C65A14", VA = "0x7BBC465A14", Slot = "51")]
		protected virtual void CreateSubTab()
		{
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AA")]
		[Address(RVA = "0x1C66384", Offset = "0x1C66384", VA = "0x7BBC466384")]
		private void ResetSubToggleScrollView()
		{
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AB")]
		[Address(RVA = "0x1C6663C", Offset = "0x1C6663C", VA = "0x7BBC46663C")]
		private void SetSubTabInfo(UIToggleButton tg, SubTabInfo info)
		{
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AC")]
		[Address(RVA = "0x1C668E8", Offset = "0x1C668E8", VA = "0x7BBC4668E8", Slot = "52")]
		protected virtual void OnSubToggleClick()
		{
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AD")]
		[Address(RVA = "0x1C66B24", Offset = "0x1C66B24", VA = "0x7BBC466B24", Slot = "53")]
		protected virtual void ResetUIStateOnToggleSelected()
		{
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060AE")]
		[Address(RVA = "0x1C67014", Offset = "0x1C67014", VA = "0x7BBC467014", Slot = "54")]
		protected virtual string GetMallTabName(uint type)
		{
			return null;
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AF")]
		[Address(RVA = "0x1C670A0", Offset = "0x1C670A0", VA = "0x7BBC4670A0", Slot = "55")]
		public virtual void OnItemSelected(params object[] data)
		{
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B0")]
		[Address(RVA = "0x1C6713C", Offset = "0x1C6713C", VA = "0x7BBC46713C")]
		protected void TrySetCDNBG(uint itemID)
		{
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060B1")]
		[Address(RVA = "0x1C67478", Offset = "0x1C67478", VA = "0x7BBC467478")]
		private string GetItemCDNBGURL(uint itemID)
		{
			return null;
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x0001BE70 File Offset: 0x0001A070
		[Token(Token = "0x60060B2")]
		[Address(RVA = "0x1C67628", Offset = "0x1C67628", VA = "0x7BBC467628", Slot = "56")]
		protected virtual bool CanChangeCDNBG()
		{
			return default(bool);
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B3")]
		[Address(RVA = "0x1C66F34", Offset = "0x1C66F34", VA = "0x7BBC466F34")]
		public void UpdateProp()
		{
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B4")]
		[Address(RVA = "0x1C5AED4", Offset = "0x1C5AED4", VA = "0x7BBC45AED4")]
		public void UpdateCloth(uint avatarId, uint selectClothes, uint[] clothes, bool addLobbyClothes, bool playClothesAnim, bool keepHairWhenSameAvatarId)
		{
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B5")]
		[Address(RVA = "0x1C67630", Offset = "0x1C67630", VA = "0x7BBC467630", Slot = "57")]
		public virtual void InitMallView()
		{
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B6")]
		[Address(RVA = "0x1C67634", Offset = "0x1C67634", VA = "0x7BBC467634", Slot = "58")]
		public virtual void RefreshMallView()
		{
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B7")]
		[Address(RVA = "0x1C67638", Offset = "0x1C67638", VA = "0x7BBC467638", Slot = "59")]
		public virtual void NavigationToItem(uint id)
		{
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B8")]
		[Address(RVA = "0x1C680D8", Offset = "0x1C680D8", VA = "0x7BBC4680D8", Slot = "60")]
		public virtual void NavigationToItem(uint mallTabType, uint mallSubType, uint storeID)
		{
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B9")]
		[Address(RVA = "0x1C680DC", Offset = "0x1C680DC", VA = "0x7BBC4680DC")]
		protected void ShowSpecialView(UINavigationUtil.UINavigationMallTabType viewType)
		{
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060BA")]
		[Address(RVA = "0x1C61088", Offset = "0x1C61088", VA = "0x7BBC461088")]
		public Dictionary<UIModelAvatarBase.EWardrobeType, SlotClothInfo> GetCurrentClothDict()
		{
			return null;
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x0001BE88 File Offset: 0x0001A088
		[Token(Token = "0x60060BB")]
		[Address(RVA = "0x1C637E8", Offset = "0x1C637E8", VA = "0x7BBC4637E8")]
		public uint GetLastSelectedCloth()
		{
			return 0U;
		}

		// Token: 0x060060BC RID: 24764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060BC")]
		[Address(RVA = "0x1C5ACE4", Offset = "0x1C5ACE4", VA = "0x7BBC45ACE4")]
		public List<uint> GetCurrentSelectedClothList(bool ingoreSet = false)
		{
			return null;
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BD")]
		[Address(RVA = "0x1C68564", Offset = "0x1C68564", VA = "0x7BBC468564", Slot = "61")]
		public virtual void RefreshCurrentMallView(bool clickItem = true)
		{
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x0001BEA0 File Offset: 0x0001A0A0
		[Token(Token = "0x60060BE")]
		[Address(RVA = "0x1C62B10", Offset = "0x1C62B10", VA = "0x7BBC462B10")]
		public bool GetCurrentSelectedSetState()
		{
			return default(bool);
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BF")]
		[Address(RVA = "0x1C68568", Offset = "0x1C68568", VA = "0x7BBC468568", Slot = "62")]
		public virtual void HighLightSelectedItem()
		{
		}

		// Token: 0x060060C0 RID: 24768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C0")]
		[Address(RVA = "0x1C67CD4", Offset = "0x1C67CD4", VA = "0x7BBC467CD4")]
		protected void GetItemInfo(uint id, out uint storeID, out UINavigationUtil.UINavigationMallType mallType, out uint mallTabType, out uint subType)
		{
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C1")]
		[Address(RVA = "0x1C67B9C", Offset = "0x1C67B9C", VA = "0x7BBC467B9C")]
		protected void GetExchangeItemInfo(uint id, out uint storeID, out uint subType)
		{
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C2")]
		[Address(RVA = "0x1C68644", Offset = "0x1C68644", VA = "0x7BBC468644")]
		private void OnBuyClick()
		{
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C3")]
		[Address(RVA = "0x1C68680", Offset = "0x1C68680", VA = "0x7BBC468680")]
		protected void SetBuyBtnStyle(BuyBtnStyle buyBtnStyle, bool enable)
		{
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C4")]
		[Address(RVA = "0x1C678A0", Offset = "0x1C678A0", VA = "0x7BBC4678A0")]
		protected void GetGiftItemInfo(uint id, out uint mallTabType, out uint subType)
		{
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C5")]
		[Address(RVA = "0x1C5F07C", Offset = "0x1C5F07C", VA = "0x7BBC45F07C")]
		public void OnHairUpdate(params object[] data)
		{
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C6")]
		[Address(RVA = "0x1C68A24", Offset = "0x1C68A24", VA = "0x7BBC468A24", Slot = "63")]
		public virtual void ShowMall()
		{
		}

		// Token: 0x060060C7 RID: 24775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C7")]
		[Address(RVA = "0x1C68A34", Offset = "0x1C68A34", VA = "0x7BBC468A34", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
		[Token(Token = "0x60060C8")]
		[Address(RVA = "0x1C68A3C", Offset = "0x1C68A3C", VA = "0x7BBC468A3C", Slot = "64")]
		protected virtual bool IsCurrentTabHaveSubTab()
		{
			return default(bool);
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C9")]
		[Address(RVA = "0x1C68A70", Offset = "0x1C68A70", VA = "0x7BBC468A70", Slot = "65")]
		protected virtual void OnCommonWndFinish(params object[] data)
		{
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CA")]
		[Address(RVA = "0x1C68A74", Offset = "0x1C68A74", VA = "0x7BBC468A74")]
		private void AnimationEventHandler(params object[] data)
		{
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CB")]
		[Address(RVA = "0x1C68BCC", Offset = "0x1C68BCC", VA = "0x7BBC468BCC")]
		protected void OnGoToWebBtnClick()
		{
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CC")]
		[Address(RVA = "0x1C68CB4", Offset = "0x1C68CB4", VA = "0x7BBC468CB4")]
		protected void OnGoToMysteryMall()
		{
		}

		// Token: 0x060060CD RID: 24781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CD")]
		[Address(RVA = "0x1C68E0C", Offset = "0x1C68E0C", VA = "0x7BBC468E0C", Slot = "66")]
		public virtual void OnNavigationClose()
		{
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CE")]
		[Address(RVA = "0x1C68E18", Offset = "0x1C68E18", VA = "0x7BBC468E18")]
		protected void SaveSelectedInfo(uint storeID, uint itemID)
		{
		}

		// Token: 0x060060CF RID: 24783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CF")]
		[Address(RVA = "0x1C610EC", Offset = "0x1C610EC", VA = "0x7BBC4610EC")]
		protected void ClearSelectedInfo()
		{
		}

		// Token: 0x060060D0 RID: 24784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D0")]
		[Address(RVA = "0x1C68E24", Offset = "0x1C68E24", VA = "0x7BBC468E24")]
		private void OnPlayFacialAnim(params object[] data)
		{
		}

		// Token: 0x060060D1 RID: 24785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D1")]
		[Address(RVA = "0x1C69054", Offset = "0x1C69054", VA = "0x7BBC469054")]
		public UIMallDetailBaseController()
		{
		}

		// Token: 0x040080A1 RID: 32929
		[Token(Token = "0x40080A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected List<SubTabInfo> m_TabClothList;

		// Token: 0x040080A2 RID: 32930
		[Token(Token = "0x40080A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<SubTabInfo> m_TabCallSignList;

		// Token: 0x040080A3 RID: 32931
		[Token(Token = "0x40080A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected List<SubTabInfo> m_TabCharacterList;

		// Token: 0x040080A4 RID: 32932
		[Token(Token = "0x40080A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected List<SubTabInfo> m_TabPetList;

		// Token: 0x040080A5 RID: 32933
		[Token(Token = "0x40080A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Dictionary<uint, string> m_MallTabName;

		// Token: 0x040080A6 RID: 32934
		[Token(Token = "0x40080A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected Dictionary<EMallScrollViewPosType, Vector3> m_MallScrollViewPosDict;

		// Token: 0x040080A7 RID: 32935
		[Token(Token = "0x40080A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected Dictionary<EMallScrollViewPosType, Vector3> m_PurchaseBtnPosDict;

		// Token: 0x040080A8 RID: 32936
		[Token(Token = "0x40080A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected UIModelMall m_ModelMall;

		// Token: 0x040080A9 RID: 32937
		[Token(Token = "0x40080A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected UIModelAvatar m_ModelAvatar;

		// Token: 0x040080AA RID: 32938
		[Token(Token = "0x40080AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected UIModelGift m_ModelGift;

		// Token: 0x040080AB RID: 32939
		[Token(Token = "0x40080AB")]
		protected const uint CURRENCY_GREY = 2139062271U;

		// Token: 0x040080AC RID: 32940
		[Token(Token = "0x40080AC")]
		protected const uint CLOTHPREVIEW_ICON_GREY = 1650615039U;

		// Token: 0x040080AD RID: 32941
		[Token(Token = "0x40080AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected Dictionary<UIModelAvatarBase.EWardrobeType, PreviewTabInfo> m_ClothPreviewToggleDict;

		// Token: 0x040080AE RID: 32942
		[Token(Token = "0x40080AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected UIMallController m_MallController;

		// Token: 0x040080AF RID: 32943
		[Token(Token = "0x40080AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected UINavigationUtil.UINavigationMallType m_MallType;

		// Token: 0x040080B0 RID: 32944
		[Token(Token = "0x40080B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Dictionary<UIModelAvatarBase.EWardrobeType, SlotClothInfo> m_SelectedClothDict;

		// Token: 0x040080B1 RID: 32945
		[Token(Token = "0x40080B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected Dictionary<UIModelAvatarBase.EWardrobeType, SlotClothInfo> m_ViceSelectedClothDict;

		// Token: 0x040080B2 RID: 32946
		[Token(Token = "0x40080B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected bool m_IsSelectedSet;

		// Token: 0x040080B3 RID: 32947
		[Token(Token = "0x40080B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		protected bool m_IsViceSelectedSet;

		// Token: 0x040080B4 RID: 32948
		[Token(Token = "0x40080B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		protected uint m_LastSelectedCloth;

		// Token: 0x040080B5 RID: 32949
		[Token(Token = "0x40080B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected uint m_ViceLastSelectedCloth;

		// Token: 0x040080B6 RID: 32950
		[Token(Token = "0x40080B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		protected uint m_CurrentSubTab;

		// Token: 0x040080B7 RID: 32951
		[Token(Token = "0x40080B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected uint m_CurrentTab;

		// Token: 0x040080B8 RID: 32952
		[Token(Token = "0x40080B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected List<UIToggleButton> m_ToggleList;

		// Token: 0x040080B9 RID: 32953
		[Token(Token = "0x40080B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected Dictionary<uint, UIToggleButton> m_ToggleDict;

		// Token: 0x040080BA RID: 32954
		[Token(Token = "0x40080BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Dictionary<uint, EventDelegate.Callback> m_MallTypeHandleDict;

		// Token: 0x040080BB RID: 32955
		[Token(Token = "0x40080BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected Dictionary<UINavigationUtil.UINavigationMallTabType, UIMallDetailBaseController.SpecialViewHandle> m_MallSpecialViewHandleDict;

		// Token: 0x040080BC RID: 32956
		[Token(Token = "0x40080BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		protected bool m_SwitchPreviewSlot;

		// Token: 0x040080BD RID: 32957
		[Token(Token = "0x40080BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected List<SubTabInfo> m_SubToggleList;

		// Token: 0x040080BE RID: 32958
		[Token(Token = "0x40080BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		protected uint m_SelectedItemId;

		// Token: 0x040080BF RID: 32959
		[Token(Token = "0x40080BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		protected uint m_SelectedItemStoreId;

		// Token: 0x040080C0 RID: 32960
		[Token(Token = "0x40080C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool m_IsCDNJump;

		// Token: 0x040080C1 RID: 32961
		[Token(Token = "0x40080C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool m_NeedCacheBackMallLog;

		// Token: 0x040080C2 RID: 32962
		[Token(Token = "0x40080C2")]
		protected const string FIRSTENTERINSTALLMENT = "FirstEnterInstallment";

		// Token: 0x040080C3 RID: 32963
		[Token(Token = "0x40080C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool m_ForceTrySetCDNBG;

		// Token: 0x040080C4 RID: 32964
		[Token(Token = "0x40080C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected Dictionary<BuyBtnStyle, BuyBtnInfo> m_BuyBtnInfoDict;

		// Token: 0x040080C5 RID: 32965
		[Token(Token = "0x40080C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		protected UIMallDetailView m_View;

		// Token: 0x040080C6 RID: 32966
		[Token(Token = "0x40080C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private BuyBtnInfo m_BuyBtnInfo;

		// Token: 0x040080C7 RID: 32967
		[Token(Token = "0x40080C7")]
		protected const string BUYBTNICON = "UI_Store_Btn_Buy";

		// Token: 0x040080C8 RID: 32968
		[Token(Token = "0x40080C8")]
		protected const string EXCHANGEBTNICON = "UI_Store_Btn_Exchange";

		// Token: 0x040080C9 RID: 32969
		[Token(Token = "0x40080C9")]
		protected const string WEBBTNICON = "UI_Store_Btn_Web";

		// Token: 0x040080CA RID: 32970
		[Token(Token = "0x40080CA")]
		protected const string GIFTBTNICON = "UI_Store_Btn_Gift";

		// Token: 0x040080CB RID: 32971
		[Token(Token = "0x40080CB")]
		protected const string MYSTERYBTNICON = "UI_Store_Btn_Mystery";

		// Token: 0x040080CC RID: 32972
		[Token(Token = "0x40080CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool IsPlayingToggleMoveAnim;

		// Token: 0x040080CD RID: 32973
		[Token(Token = "0x40080CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		protected uint m_CurrentAvatarId;

		// Token: 0x02001591 RID: 5521
		// (Invoke) Token: 0x060060D4 RID: 24788
		[Token(Token = "0x2001591")]
		protected delegate void SpecialViewHandle();

		// Token: 0x02001592 RID: 5522
		[Token(Token = "0x2001592")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EECDC", Offset = "0x10EECDC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060060D8 RID: 24792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60060D8")]
			[Address(RVA = "0x1C6A150", Offset = "0x1C6A150", VA = "0x7BBC46A150")]
			public <>c()
			{
			}

			// Token: 0x060060D9 RID: 24793 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060D9")]
			[Address(RVA = "0x1C6A158", Offset = "0x1C6A158", VA = "0x7BBC46A158")]
			internal UIToggleButton <CreateSubTab>b__110_0(SubTabInfo info)
			{
				return null;
			}

			// Token: 0x060060DA RID: 24794 RVA: 0x0001BED0 File Offset: 0x0001A0D0
			[Token(Token = "0x60060DA")]
			[Address(RVA = "0x1C6A184", Offset = "0x1C6A184", VA = "0x7BBC46A184")]
			internal bool <OnPlayFacialAnim>b__149_0(SubTabInfo temp)
			{
				return default(bool);
			}

			// Token: 0x040080CE RID: 32974
			[Token(Token = "0x40080CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIMallDetailBaseController.<>c <>9;

			// Token: 0x040080CF RID: 32975
			[Token(Token = "0x40080CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<SubTabInfo, UIToggleButton> <>9__110_0;

			// Token: 0x040080D0 RID: 32976
			[Token(Token = "0x40080D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<SubTabInfo> <>9__149_0;
		}

		// Token: 0x02001593 RID: 5523
		[Token(Token = "0x2001593")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EECEC", Offset = "0x10EECEC")]
		private sealed class <>c__DisplayClass134_0
		{
			// Token: 0x060060DB RID: 24795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60060DB")]
			[Address(RVA = "0x1C6863C", Offset = "0x1C6863C", VA = "0x7BBC46863C")]
			public <>c__DisplayClass134_0()
			{
			}

			// Token: 0x060060DC RID: 24796 RVA: 0x0001BEE8 File Offset: 0x0001A0E8
			[Token(Token = "0x60060DC")]
			[Address(RVA = "0x1C6A1C4", Offset = "0x1C6A1C4", VA = "0x7BBC46A1C4")]
			internal bool <GetExchangeItemInfo>b__0(ExchangeStoreItemDesc itemDesc)
			{
				return default(bool);
			}

			// Token: 0x040080D1 RID: 32977
			[Token(Token = "0x40080D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint id;
		}
	}
}
