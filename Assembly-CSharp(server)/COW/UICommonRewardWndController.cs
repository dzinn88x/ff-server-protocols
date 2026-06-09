using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200175B RID: 5979
	[Token(Token = "0x200175B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1ED4", Offset = "0x10F1ED4")]
	public class UICommonRewardWndController : UIPopupWindowController
	{
		// Token: 0x06007091 RID: 28817 RVA: 0x0001F848 File Offset: 0x0001DA48
		[Token(Token = "0x6007091")]
		[Address(RVA = "0x180772C", Offset = "0x180772C", VA = "0x7BBC00772C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007092")]
		[Address(RVA = "0x180777C", Offset = "0x180777C", VA = "0x7BBC00777C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007093")]
		[Address(RVA = "0x1807CD0", Offset = "0x1807CD0", VA = "0x7BBC007CD0", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007094")]
		[Address(RVA = "0x1807D4C", Offset = "0x1807D4C", VA = "0x7BBC007D4C")]
		public void SetRewardsData(List<CommonRewardItemInfo> infoList, [Optional] CommonRewardItemInfo extraRewardInfo, [Optional] CommonRewardItemInfo freeRewardInfo)
		{
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007095")]
		[Address(RVA = "0x180822C", Offset = "0x180822C", VA = "0x7BBC00822C")]
		public void SetOptionalRewardData(List<CommonRewardItemInfo> infoList, List<OptionalBundleShowData> optionalBundleShowDataList)
		{
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007096")]
		[Address(RVA = "0x1808710", Offset = "0x1808710", VA = "0x7BBC008710")]
		public void ShowView(bool enableShowOneByOneAnim = false)
		{
		}

		// Token: 0x06007097 RID: 28823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007097")]
		[Address(RVA = "0x1809634", Offset = "0x1809634", VA = "0x7BBC009634")]
		public void SetWndTitle(string key)
		{
		}

		// Token: 0x06007098 RID: 28824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007098")]
		[Address(RVA = "0x1809724", Offset = "0x1809724", VA = "0x7BBC009724")]
		public void SetTransferHint(string content)
		{
		}

		// Token: 0x06007099 RID: 28825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007099")]
		[Address(RVA = "0x180984C", Offset = "0x180984C", VA = "0x7BBC00984C")]
		public void SetTransferHintLabel(string content)
		{
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600709A")]
		[Address(RVA = "0x1809970", Offset = "0x1809970", VA = "0x7BBC009970")]
		public void SelectWndStyle(UICommonRewardWndController.WndStyleEnum style)
		{
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600709B")]
		[Address(RVA = "0x1809F74", Offset = "0x1809F74", VA = "0x7BBC009F74")]
		public void EnableShowFeature(List<uint> conditions)
		{
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600709C")]
		[Address(RVA = "0x1809FF0", Offset = "0x1809FF0", VA = "0x7BBC009FF0")]
		public void EnableBuyAgain(UICommonRewardWndController.RepurchaseCurrencyType type, ResourceID resID, int price, int repurchaseNum, UICommonRewardWndController.PurchaseDelegate purchase)
		{
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600709D")]
		[Address(RVA = "0x1807DEC", Offset = "0x1807DEC", VA = "0x7BBC007DEC")]
		private void InitRewards(List<CommonRewardItemInfo> infoList, CommonRewardItemInfo extraRewardInfo, CommonRewardItemInfo freeRewardInfo)
		{
		}

		// Token: 0x0600709E RID: 28830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600709E")]
		[Address(RVA = "0x18082B8", Offset = "0x18082B8", VA = "0x7BBC0082B8")]
		private void InitOptionalRewards(List<CommonRewardItemInfo> infoList, List<OptionalBundleShowData> optionalBundleShowDataList)
		{
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600709F")]
		[Address(RVA = "0x1806148", Offset = "0x1806148", VA = "0x7BBC006148")]
		public void OnOptionalBundleSelected(uint order)
		{
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A0")]
		[Address(RVA = "0x180A1D8", Offset = "0x180A1D8", VA = "0x7BBC00A1D8")]
		private void RefreshOptionalToggles(uint order)
		{
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A1")]
		[Address(RVA = "0x180A304", Offset = "0x180A304", VA = "0x7BBC00A304")]
		private void RefreshOptionalViews(uint order)
		{
		}

		// Token: 0x060070A2 RID: 28834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A2")]
		[Address(RVA = "0x18091F4", Offset = "0x18091F4", VA = "0x7BBC0091F4")]
		private void AdjustWindowVFX()
		{
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A3")]
		[Address(RVA = "0x1808808", Offset = "0x1808808", VA = "0x7BBC008808")]
		private void AdjustBGView()
		{
		}

		// Token: 0x060070A4 RID: 28836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A4")]
		[Address(RVA = "0x180BCE0", Offset = "0x180BCE0", VA = "0x7BBC00BCE0")]
		public void SetRewardInstant(bool flag)
		{
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A5")]
		[Address(RVA = "0x180BCEC", Offset = "0x180BCEC", VA = "0x7BBC00BCEC")]
		public void SetShowAll(bool flag)
		{
		}

		// Token: 0x060070A6 RID: 28838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A6")]
		[Address(RVA = "0x180BCF8", Offset = "0x180BCF8", VA = "0x7BBC00BCF8")]
		public void SetCrate(bool flag)
		{
		}

		// Token: 0x060070A7 RID: 28839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A7")]
		[Address(RVA = "0x18092A8", Offset = "0x18092A8", VA = "0x7BBC0092A8")]
		private void ShowRewardsView()
		{
		}

		// Token: 0x060070A8 RID: 28840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A8")]
		[Address(RVA = "0x180D57C", Offset = "0x180D57C", VA = "0x7BBC00D57C")]
		private void RefreshStateAfterShowView()
		{
		}

		// Token: 0x060070A9 RID: 28841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A9")]
		[Address(RVA = "0x1805B10", Offset = "0x1805B10", VA = "0x7BBC005B10")]
		public void OnPetToggle(uint petId = 0U, bool isSkin = false, uint petSkinId = 0U)
		{
		}

		// Token: 0x060070AA RID: 28842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070AA")]
		[Address(RVA = "0x18058A0", Offset = "0x18058A0", VA = "0x7BBC0058A0")]
		public void OnAvatarToggle(uint selectid = 0U)
		{
		}

		// Token: 0x060070AB RID: 28843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070AB")]
		[Address(RVA = "0x180E030", Offset = "0x180E030", VA = "0x7BBC00E030")]
		private void RefreshClothsState()
		{
		}

		// Token: 0x060070AC RID: 28844 RVA: 0x0001F860 File Offset: 0x0001DA60
		[Token(Token = "0x60070AC")]
		[Address(RVA = "0x180DEAC", Offset = "0x180DEAC", VA = "0x7BBC00DEAC")]
		private bool CheckFeatureCanShow(UICommonRewardItemController reward)
		{
			return default(bool);
		}

		// Token: 0x060070AD RID: 28845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070AD")]
		[Address(RVA = "0x180DDA8", Offset = "0x180DDA8", VA = "0x7BBC00DDA8")]
		private void ShowNextRewardView()
		{
		}

		// Token: 0x060070AE RID: 28846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070AE")]
		[Address(RVA = "0x180DB18", Offset = "0x180DB18", VA = "0x7BBC00DB18")]
		private void ShowRewardItemView(UICommonRewardItemController ctrl)
		{
		}

		// Token: 0x060070AF RID: 28847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070AF")]
		[Address(RVA = "0x180DC6C", Offset = "0x180DC6C", VA = "0x7BBC00DC6C")]
		private void ShowRewardFeatureView(UICommonRewardItemController item)
		{
		}

		// Token: 0x060070B0 RID: 28848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B0")]
		[Address(RVA = "0x180E930", Offset = "0x180E930", VA = "0x7BBC00E930")]
		private void ShowExtraRewardView()
		{
		}

		// Token: 0x060070B1 RID: 28849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B1")]
		[Address(RVA = "0x180CA30", Offset = "0x180CA30", VA = "0x7BBC00CA30")]
		private void ShowFreeRewardView()
		{
		}

		// Token: 0x060070B2 RID: 28850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B2")]
		[Address(RVA = "0x180E3D8", Offset = "0x180E3D8", VA = "0x7BBC00E3D8")]
		private void ShowRewardItemVFX(UICommonRewardItemController item)
		{
		}

		// Token: 0x060070B3 RID: 28851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B3")]
		[Address(RVA = "0x180E9F8", Offset = "0x180E9F8", VA = "0x7BBC00E9F8")]
		private void TryCreatePermanentEffect(UICommonRewardItemController item)
		{
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B4")]
		[Address(RVA = "0x180E7FC", Offset = "0x180E7FC", VA = "0x7BBC00E7FC")]
		private void SetRewardToggleState(UICommonRewardItemController item)
		{
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x0001F878 File Offset: 0x0001DA78
		[Token(Token = "0x60070B5")]
		[Address(RVA = "0x180ED50", Offset = "0x180ED50", VA = "0x7BBC00ED50")]
		private bool CheckAvatarBundleEquip(UICommonRewardItemController item)
		{
			return default(bool);
		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x0001F890 File Offset: 0x0001DA90
		[Token(Token = "0x60070B6")]
		[Address(RVA = "0x180EE20", Offset = "0x180EE20", VA = "0x7BBC00EE20")]
		private bool CheckAvatarBundle()
		{
			return default(bool);
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B7")]
		[Address(RVA = "0x180C854", Offset = "0x180C854", VA = "0x7BBC00C854")]
		private void ShowTitleView()
		{
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B8")]
		[Address(RVA = "0x180BDE8", Offset = "0x180BDE8", VA = "0x7BBC00BDE8")]
		private void ShowBtnsView()
		{
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B9")]
		[Address(RVA = "0x180CCE0", Offset = "0x180CCE0", VA = "0x7BBC00CCE0")]
		private void ShowVoucherGroupView()
		{
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070BA")]
		[Address(RVA = "0x180D13C", Offset = "0x180D13C", VA = "0x7BBC00D13C")]
		private void ShowShareView()
		{
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070BB")]
		[Address(RVA = "0x180BD04", Offset = "0x180BD04", VA = "0x7BBC00BD04")]
		private void SetCommonWndVisble(bool flag)
		{
		}

		// Token: 0x060070BC RID: 28860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070BC")]
		[Address(RVA = "0x180D410", Offset = "0x180D410", VA = "0x7BBC00D410")]
		private void ShowVoucherTweenAnim()
		{
		}

		// Token: 0x060070BD RID: 28861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070BD")]
		[Address(RVA = "0x180F3E0", Offset = "0x180F3E0", VA = "0x7BBC00F3E0")]
		public void RefreshCurrencyIcon(ResourceID resID)
		{
		}

		// Token: 0x060070BE RID: 28862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070BE")]
		[Address(RVA = "0x180F47C", Offset = "0x180F47C", VA = "0x7BBC00F47C")]
		public void RefreshCurrencyCountDown(DateTime time)
		{
		}

		// Token: 0x060070BF RID: 28863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070BF")]
		[Address(RVA = "0x180F778", Offset = "0x180F778", VA = "0x7BBC00F778")]
		public void RefreshCurrencyIcon(string spritename)
		{
		}

		// Token: 0x060070C0 RID: 28864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C0")]
		[Address(RVA = "0x180EF68", Offset = "0x180EF68", VA = "0x7BBC00EF68")]
		private void RefreshBuyAgainBtnView()
		{
		}

		// Token: 0x060070C1 RID: 28865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C1")]
		[Address(RVA = "0x180F7C4", Offset = "0x180F7C4", VA = "0x7BBC00F7C4")]
		private void OnBannerEquipResult(params object[] data)
		{
		}

		// Token: 0x060070C2 RID: 28866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C2")]
		[Address(RVA = "0x180FC18", Offset = "0x180FC18", VA = "0x7BBC00FC18")]
		private void OnHeadPicEquipResult(params object[] data)
		{
		}

		// Token: 0x060070C3 RID: 28867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C3")]
		[Address(RVA = "0x180FC1C", Offset = "0x180FC1C", VA = "0x7BBC00FC1C")]
		private void OnCommonEquipResult(params object[] data)
		{
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C4")]
		[Address(RVA = "0x1810030", Offset = "0x1810030", VA = "0x7BBC010030")]
		private void OnEmoteEquipResult(params object[] data)
		{
		}

		// Token: 0x060070C5 RID: 28869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C5")]
		[Address(RVA = "0x1810034", Offset = "0x1810034", VA = "0x7BBC010034")]
		private void OnClothEquipResult(params object[] data)
		{
		}

		// Token: 0x060070C6 RID: 28870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C6")]
		[Address(RVA = "0x1810038", Offset = "0x1810038", VA = "0x7BBC010038")]
		private void OnAvatarEquipResult(params object[] data)
		{
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C7")]
		[Address(RVA = "0x180F980", Offset = "0x180F980", VA = "0x7BBC00F980")]
		private void OnEquipSuccess()
		{
		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C8")]
		[Address(RVA = "0x180FA78", Offset = "0x180FA78", VA = "0x7BBC00FA78")]
		private void OnEquipFail()
		{
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C9")]
		[Address(RVA = "0x1810508", Offset = "0x1810508", VA = "0x7BBC010508")]
		private void ShowResult()
		{
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070CA")]
		[Address(RVA = "0x180FF64", Offset = "0x180FF64", VA = "0x7BBC00FF64")]
		private void AutoClose()
		{
		}

		// Token: 0x060070CB RID: 28875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070CB")]
		[Address(RVA = "0x181070C", Offset = "0x181070C", VA = "0x7BBC01070C")]
		private void OnOKBtnClick()
		{
		}

		// Token: 0x060070CC RID: 28876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070CC")]
		[Address(RVA = "0x1810798", Offset = "0x1810798", VA = "0x7BBC010798")]
		private void OnOpenBtnClick()
		{
		}

		// Token: 0x060070CD RID: 28877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070CD")]
		[Address(RVA = "0x1810F2C", Offset = "0x1810F2C", VA = "0x7BBC010F2C")]
		private void OnChooseBtnClick()
		{
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070CE")]
		[Address(RVA = "0x181115C", Offset = "0x181115C", VA = "0x7BBC01115C", Slot = "38")]
		public override void EnterByReturn()
		{
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070CF")]
		[Address(RVA = "0x181019C", Offset = "0x181019C", VA = "0x7BBC01019C")]
		private void UpdateAvatarClothData(uint itemID)
		{
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D0")]
		[Address(RVA = "0x1805F98", Offset = "0x1805F98", VA = "0x7BBC005F98")]
		public void OnToggleSelected()
		{
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D1")]
		[Address(RVA = "0x1811220", Offset = "0x1811220", VA = "0x7BBC011220")]
		private void OnFastEquipClick()
		{
		}

		// Token: 0x060070D2 RID: 28882 RVA: 0x0001F8A8 File Offset: 0x0001DAA8
		[Token(Token = "0x60070D2")]
		[Address(RVA = "0x18128BC", Offset = "0x18128BC", VA = "0x7BBC0128BC")]
		private bool CheckItemABReady(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D3")]
		[Address(RVA = "0x1812A04", Offset = "0x1812A04", VA = "0x7BBC012A04")]
		private void OnRepurchaseBtnClick()
		{
		}

		// Token: 0x060070D4 RID: 28884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D4")]
		[Address(RVA = "0x1812E78", Offset = "0x1812E78", VA = "0x7BBC012E78")]
		private void OnSkipMaskClick()
		{
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D5")]
		[Address(RVA = "0x1812E80", Offset = "0x1812E80", VA = "0x7BBC012E80")]
		private void OnGoToExchangeClick()
		{
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D6")]
		[Address(RVA = "0x1812F68", Offset = "0x1812F68", VA = "0x7BBC012F68")]
		private void OnGoToSharePreviewClick()
		{
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D7")]
		[Address(RVA = "0x1810868", Offset = "0x1810868", VA = "0x7BBC010868")]
		private void DefOpenAction()
		{
		}

		// Token: 0x060070D8 RID: 28888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D8")]
		[Address(RVA = "0x181320C", Offset = "0x181320C", VA = "0x7BBC01320C")]
		public void SetUseNewItem()
		{
		}

		// Token: 0x060070D9 RID: 28889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D9")]
		[Address(RVA = "0x1809D28", Offset = "0x1809D28", VA = "0x7BBC009D28")]
		private void CreateWndStyle()
		{
		}

		// Token: 0x060070DA RID: 28890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070DA")]
		[Address(RVA = "0x1813218", Offset = "0x1813218", VA = "0x7BBC013218", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070DB")]
		[Address(RVA = "0x18132E8", Offset = "0x18132E8", VA = "0x7BBC0132E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070DC")]
		[Address(RVA = "0x1813624", Offset = "0x1813624", VA = "0x7BBC013624")]
		public UICommonRewardWndController()
		{
		}

		// Token: 0x060070DD RID: 28893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070DD")]
		[Address(RVA = "0x18137A4", Offset = "0x18137A4", VA = "0x7BBC0137A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11415CC", Offset = "0x11415CC")]
		private void <InitOptionalRewards>b__62_0()
		{
		}

		// Token: 0x060070DE RID: 28894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070DE")]
		[Address(RVA = "0x1813810", Offset = "0x1813810", VA = "0x7BBC013810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11415DC", Offset = "0x11415DC")]
		private void <ShowRewardFeatureView>b__83_0()
		{
		}

		// Token: 0x04008A55 RID: 35413
		[Token(Token = "0x4008A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Action m_CloseAction;

		// Token: 0x04008A56 RID: 35414
		[Token(Token = "0x4008A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Action m_OpenAction;

		// Token: 0x04008A57 RID: 35415
		[Token(Token = "0x4008A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool m_EnableFastEquip;

		// Token: 0x04008A58 RID: 35416
		[Token(Token = "0x4008A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool m_IsBigPrice;

		// Token: 0x04008A59 RID: 35417
		[Token(Token = "0x4008A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool m_EnableOptionalSelect;

		// Token: 0x04008A5A RID: 35418
		[Token(Token = "0x4008A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool m_EnableOKBtn;

		// Token: 0x04008A5B RID: 35419
		[Token(Token = "0x4008A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UICommonRewardWndView m_View;

		// Token: 0x04008A5C RID: 35420
		[Token(Token = "0x4008A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CommonRewardWindowStyleBaseController m_StyleBaseController;

		// Token: 0x04008A5D RID: 35421
		[Token(Token = "0x4008A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CommonRewardWnd_BGStyle_CommonView m_StyleView;

		// Token: 0x04008A5E RID: 35422
		[Token(Token = "0x4008A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UICommonRewardItemController m_ExtraReward;

		// Token: 0x04008A5F RID: 35423
		[Token(Token = "0x4008A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<UICommonRewardItemController> m_RewardList;

		// Token: 0x04008A60 RID: 35424
		[Token(Token = "0x4008A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private CommonRewardItemInfo m_FreeRewardInfo;

		// Token: 0x04008A61 RID: 35425
		[Token(Token = "0x4008A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private List<CommonRewardItemInfo> m_RewardInfoList;

		// Token: 0x04008A62 RID: 35426
		[Token(Token = "0x4008A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<OptionalBundleShowData> m_OptionalBundleShowDataList;

		// Token: 0x04008A63 RID: 35427
		[Token(Token = "0x4008A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int m_CurRewardIdx;

		// Token: 0x04008A64 RID: 35428
		[Token(Token = "0x4008A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private uint m_VoucherID;

		// Token: 0x04008A65 RID: 35429
		[Token(Token = "0x4008A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private uint m_ShowRewardDC;

		// Token: 0x04008A66 RID: 35430
		[Token(Token = "0x4008A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private uint m_ScrollviewDC;

		// Token: 0x04008A67 RID: 35431
		[Token(Token = "0x4008A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public uint m_SelectAvatarID;

		// Token: 0x04008A68 RID: 35432
		[Token(Token = "0x4008A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public uint m_SelectPetId;

		// Token: 0x04008A69 RID: 35433
		[Token(Token = "0x4008A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool m_HasBundle;

		// Token: 0x04008A6A RID: 35434
		[Token(Token = "0x4008A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		private bool m_HasTreesureBoxOnlyOne;

		// Token: 0x04008A6B RID: 35435
		[Token(Token = "0x4008A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Dictionary<uint, uint> m_SelectPetSkinDict;

		// Token: 0x04008A6C RID: 35436
		[Token(Token = "0x4008A6C")]
		private const int m_MaxRewardCnt1Row = 5;

		// Token: 0x04008A6D RID: 35437
		[Token(Token = "0x4008A6D")]
		private const int m_MaxRewardCnt2Row = 11;

		// Token: 0x04008A6E RID: 35438
		[Token(Token = "0x4008A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float m_ShowRewardSecondInterval;

		// Token: 0x04008A6F RID: 35439
		[Token(Token = "0x4008A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private bool m_Instant;

		// Token: 0x04008A70 RID: 35440
		[Token(Token = "0x4008A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		private bool m_First;

		// Token: 0x04008A71 RID: 35441
		[Token(Token = "0x4008A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11E")]
		private bool m_IsShowAll;

		// Token: 0x04008A72 RID: 35442
		[Token(Token = "0x4008A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11F")]
		private bool m_IsDestory;

		// Token: 0x04008A73 RID: 35443
		[Token(Token = "0x4008A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool m_IsCrate;

		// Token: 0x04008A74 RID: 35444
		[Token(Token = "0x4008A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
		private bool m_HasShownFinished;

		// Token: 0x04008A75 RID: 35445
		[Token(Token = "0x4008A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x122")]
		private bool m_UseNewItem;

		// Token: 0x04008A76 RID: 35446
		[Token(Token = "0x4008A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private UICommonRewardWndController.WndStyleEnum m_wndStyle;

		// Token: 0x04008A77 RID: 35447
		[Token(Token = "0x4008A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool m_EnableShowFeature;

		// Token: 0x04008A78 RID: 35448
		[Token(Token = "0x4008A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private UICommonRewardWndController.RepurchaseCurrencyType m_RepurchaseCurrencyType;

		// Token: 0x04008A79 RID: 35449
		[Token(Token = "0x4008A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private UICommonRewardWndController.PurchaseDelegate m_PurchaseDelegate;

		// Token: 0x04008A7A RID: 35450
		[Token(Token = "0x4008A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int m_EquippedSuccessNum;

		// Token: 0x04008A7B RID: 35451
		[Token(Token = "0x4008A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool m_HaveShowFailTip;

		// Token: 0x04008A7C RID: 35452
		[Token(Token = "0x4008A7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Dictionary<uint, UICommonRewardItemController> m_SelectedDict;

		// Token: 0x04008A7D RID: 35453
		[Token(Token = "0x4008A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private uint m_AutoCloseDC;

		// Token: 0x04008A7E RID: 35454
		[Token(Token = "0x4008A7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private bool m_EnableOKBtnClick;

		// Token: 0x04008A7F RID: 35455
		[Token(Token = "0x4008A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		private bool m_HasABNotReadyItem;

		// Token: 0x04008A80 RID: 35456
		[Token(Token = "0x4008A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private uint m_EquipAvatar;

		// Token: 0x04008A81 RID: 35457
		[Token(Token = "0x4008A81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private bool m_EquipCloth;

		// Token: 0x04008A82 RID: 35458
		[Token(Token = "0x4008A82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private List<uint> m_EquipClothList;

		// Token: 0x04008A83 RID: 35459
		[Token(Token = "0x4008A83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool m_OwnedSecondConfirm;

		// Token: 0x04008A84 RID: 35460
		[Token(Token = "0x4008A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Dictionary<uint, long> m_ReturnIdNumDic;

		// Token: 0x04008A85 RID: 35461
		[Token(Token = "0x4008A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private long m_ReturnCoinNum;

		// Token: 0x04008A86 RID: 35462
		[Token(Token = "0x4008A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private long m_ReturnDiamondNum;

		// Token: 0x0200175C RID: 5980
		[Token(Token = "0x200175C")]
		public enum WndStyleEnum
		{
			// Token: 0x04008A88 RID: 35464
			[Token(Token = "0x4008A88")]
			COMMON,
			// Token: 0x04008A89 RID: 35465
			[Token(Token = "0x4008A89")]
			BRIGHT1,
			// Token: 0x04008A8A RID: 35466
			[Token(Token = "0x4008A8A")]
			LEGENDDOWBLEROW,
			// Token: 0x04008A8B RID: 35467
			[Token(Token = "0x4008A8B")]
			LEGENDONEROW,
			// Token: 0x04008A8C RID: 35468
			[Token(Token = "0x4008A8C")]
			NEWONEROW,
			// Token: 0x04008A8D RID: 35469
			[Token(Token = "0x4008A8D")]
			NEWDOUBLEROW
		}

		// Token: 0x0200175D RID: 5981
		[Token(Token = "0x200175D")]
		public enum RepurchaseCurrencyType
		{
			// Token: 0x04008A8F RID: 35471
			[Token(Token = "0x4008A8F")]
			NONE,
			// Token: 0x04008A90 RID: 35472
			[Token(Token = "0x4008A90")]
			FREE,
			// Token: 0x04008A91 RID: 35473
			[Token(Token = "0x4008A91")]
			COUPON,
			// Token: 0x04008A92 RID: 35474
			[Token(Token = "0x4008A92")]
			GOLD,
			// Token: 0x04008A93 RID: 35475
			[Token(Token = "0x4008A93")]
			DIAMOND
		}

		// Token: 0x0200175E RID: 5982
		// (Invoke) Token: 0x060070E0 RID: 28896
		[Token(Token = "0x200175E")]
		public delegate void PurchaseDelegate(bool isRepurchase);

		// Token: 0x0200175F RID: 5983
		[Token(Token = "0x200175F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1F0C", Offset = "0x10F1F0C")]
		private sealed class <>c__DisplayClass62_0
		{
			// Token: 0x060070E3 RID: 28899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60070E3")]
			[Address(RVA = "0x180A1D0", Offset = "0x180A1D0", VA = "0x7BBC00A1D0")]
			public <>c__DisplayClass62_0()
			{
			}

			// Token: 0x060070E4 RID: 28900 RVA: 0x0001F8C0 File Offset: 0x0001DAC0
			[Token(Token = "0x60070E4")]
			[Address(RVA = "0x18138AC", Offset = "0x18138AC", VA = "0x7BBC0138AC")]
			internal bool <InitOptionalRewards>b__1(OptionalBundleShowData x)
			{
				return default(bool);
			}

			// Token: 0x04008A94 RID: 35476
			[Token(Token = "0x4008A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CommonRewardItemInfo info;
		}

		// Token: 0x02001760 RID: 5984
		[Token(Token = "0x2001760")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1F1C", Offset = "0x10F1F1C")]
		private sealed class <>c__DisplayClass69_0
		{
			// Token: 0x060070E5 RID: 28901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60070E5")]
			[Address(RVA = "0x180BCD8", Offset = "0x180BCD8", VA = "0x7BBC00BCD8")]
			public <>c__DisplayClass69_0()
			{
			}

			// Token: 0x060070E6 RID: 28902 RVA: 0x0001F8D8 File Offset: 0x0001DAD8
			[Token(Token = "0x60070E6")]
			[Address(RVA = "0x18138F8", Offset = "0x18138F8", VA = "0x7BBC0138F8")]
			internal bool <RefreshOptionalViews>b__0(OptionalBundleShowData x)
			{
				return default(bool);
			}

			// Token: 0x04008A95 RID: 35477
			[Token(Token = "0x4008A95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint order;
		}

		// Token: 0x02001761 RID: 5985
		[Token(Token = "0x2001761")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1F2C", Offset = "0x10F1F2C")]
		private sealed class <>c__DisplayClass117_0
		{
			// Token: 0x060070E7 RID: 28903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60070E7")]
			[Address(RVA = "0x18128AC", Offset = "0x18128AC", VA = "0x7BBC0128AC")]
			public <>c__DisplayClass117_0()
			{
			}

			// Token: 0x060070E8 RID: 28904 RVA: 0x0001F8F0 File Offset: 0x0001DAF0
			[Token(Token = "0x60070E8")]
			[Address(RVA = "0x1813814", Offset = "0x1813814", VA = "0x7BBC013814")]
			internal bool <OnFastEquipClick>b__0(PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x04008A96 RID: 35478
			[Token(Token = "0x4008A96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CSSharedItemData itemData;
		}

		// Token: 0x02001762 RID: 5986
		[Token(Token = "0x2001762")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1F3C", Offset = "0x10F1F3C")]
		private sealed class <>c__DisplayClass117_1
		{
			// Token: 0x060070E9 RID: 28905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60070E9")]
			[Address(RVA = "0x18128B4", Offset = "0x18128B4", VA = "0x7BBC0128B4")]
			public <>c__DisplayClass117_1()
			{
			}

			// Token: 0x060070EA RID: 28906 RVA: 0x0001F908 File Offset: 0x0001DB08
			[Token(Token = "0x60070EA")]
			[Address(RVA = "0x1813860", Offset = "0x1813860", VA = "0x7BBC013860")]
			internal bool <OnFastEquipClick>b__1(PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x04008A97 RID: 35479
			[Token(Token = "0x4008A97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PetSkinData skinData;
		}
	}
}
