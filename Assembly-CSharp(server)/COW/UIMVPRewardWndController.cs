using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020013A0 RID: 5024
	[Token(Token = "0x20013A0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB988", Offset = "0x10EB988")]
	public class UIMVPRewardWndController : UIPopupWindowController
	{
		// Token: 0x06005167 RID: 20839 RVA: 0x00018948 File Offset: 0x00016B48
		[Token(Token = "0x6005167")]
		[Address(RVA = "0x1CCD904", Offset = "0x1CCD904", VA = "0x7BBC4CD904")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005168")]
		[Address(RVA = "0x1CCD954", Offset = "0x1CCD954", VA = "0x7BBC4CD954", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005169")]
		[Address(RVA = "0x1CCE5C0", Offset = "0x1CCE5C0", VA = "0x7BBC4CE5C0", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600516A RID: 20842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516A")]
		[Address(RVA = "0x1CCE63C", Offset = "0x1CCE63C", VA = "0x7BBC4CE63C")]
		public void SetRewardsData(List<CommonRewardItemInfo> infoList, [Optional] CommonRewardItemInfo extraRewardInfo, [Optional] CommonRewardItemInfo freeRewardInfo)
		{
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516B")]
		[Address(RVA = "0x1CCE454", Offset = "0x1CCE454", VA = "0x7BBC4CE454")]
		public void InitUI()
		{
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516C")]
		[Address(RVA = "0x1CCEAC8", Offset = "0x1CCEAC8", VA = "0x7BBC4CEAC8")]
		public void SetTitle(string key)
		{
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516D")]
		[Address(RVA = "0x1CCEBD0", Offset = "0x1CCEBD0", VA = "0x7BBC4CEBD0")]
		public void SetDesc(string key)
		{
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516E")]
		[Address(RVA = "0x1CCECD8", Offset = "0x1CCECD8", VA = "0x7BBC4CECD8")]
		public void ShowView(bool enableShowOneByOneAnim = false)
		{
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516F")]
		[Address(RVA = "0x1CCF7D0", Offset = "0x1CCF7D0", VA = "0x7BBC4CF7D0")]
		public void EnableShowFeature(List<uint> conditions)
		{
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005170")]
		[Address(RVA = "0x1CCF84C", Offset = "0x1CCF84C", VA = "0x7BBC4CF84C")]
		public void EnableBuyAgain(UIMVPRewardWndController.RepurchaseCurrencyType type, ResourceID resID, int price, int repurchaseNum, UIMVPRewardWndController.PurchaseDelegate purchase)
		{
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005171")]
		[Address(RVA = "0x1CCE6DC", Offset = "0x1CCE6DC", VA = "0x7BBC4CE6DC")]
		private void InitRewards(List<CommonRewardItemInfo> infoList, CommonRewardItemInfo extraRewardInfo, CommonRewardItemInfo freeRewardInfo)
		{
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005172")]
		[Address(RVA = "0x1CCED08", Offset = "0x1CCED08", VA = "0x7BBC4CED08")]
		private void AdjustBGView()
		{
		}

		// Token: 0x06005173 RID: 20851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005173")]
		[Address(RVA = "0x1CCFA3C", Offset = "0x1CCFA3C", VA = "0x7BBC4CFA3C")]
		public void SetRewardInstant(bool flag)
		{
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005174")]
		[Address(RVA = "0x1CCFA48", Offset = "0x1CCFA48", VA = "0x7BBC4CFA48")]
		public void SetShowAll(bool flag)
		{
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005175")]
		[Address(RVA = "0x1CCFA54", Offset = "0x1CCFA54", VA = "0x7BBC4CFA54")]
		public void SetCrate(bool flag)
		{
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005176")]
		[Address(RVA = "0x1CCF454", Offset = "0x1CCF454", VA = "0x7BBC4CF454")]
		private void ShowRewardsView()
		{
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005177")]
		[Address(RVA = "0x1CD08E8", Offset = "0x1CD08E8", VA = "0x7BBC4D08E8")]
		private void RefreshStateAfterShowView()
		{
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005178")]
		[Address(RVA = "0x1CD19B0", Offset = "0x1CD19B0", VA = "0x7BBC4D19B0")]
		public void OnPetToggle(uint petId = 0U, bool isSkin = false, uint petSkinId = 0U)
		{
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005179")]
		[Address(RVA = "0x1CD1EF8", Offset = "0x1CD1EF8", VA = "0x7BBC4D1EF8")]
		public void OnAvatarToggle(uint selectid = 0U)
		{
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600517A")]
		[Address(RVA = "0x1CD155C", Offset = "0x1CD155C", VA = "0x7BBC4D155C")]
		private void RefreshClothsState()
		{
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x00018960 File Offset: 0x00016B60
		[Token(Token = "0x600517B")]
		[Address(RVA = "0x1CD13D8", Offset = "0x1CD13D8", VA = "0x7BBC4D13D8")]
		private bool CheckFeatureCanShow(UICommonRewardItemController reward)
		{
			return default(bool);
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600517C")]
		[Address(RVA = "0x1CD12D4", Offset = "0x1CD12D4", VA = "0x7BBC4D12D4")]
		private void ShowNextRewardView()
		{
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600517D")]
		[Address(RVA = "0x1CD0F8C", Offset = "0x1CD0F8C", VA = "0x7BBC4D0F8C")]
		private void ShowRewardItemView(UICommonRewardItemController ctrl)
		{
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600517E")]
		[Address(RVA = "0x1CD1198", Offset = "0x1CD1198", VA = "0x7BBC4D1198")]
		private void ShowRewardFeatureView(UICommonRewardItemController item)
		{
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600517F")]
		[Address(RVA = "0x1CD26A0", Offset = "0x1CD26A0", VA = "0x7BBC4D26A0")]
		private void ShowExtraRewardView()
		{
		}

		// Token: 0x06005180 RID: 20864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005180")]
		[Address(RVA = "0x1CCE28C", Offset = "0x1CCE28C", VA = "0x7BBC4CE28C")]
		private void ResetRewardItemVFX()
		{
		}

		// Token: 0x06005181 RID: 20865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005181")]
		[Address(RVA = "0x1CD21C0", Offset = "0x1CD21C0", VA = "0x7BBC4D21C0")]
		private void ShowRewardItemVFX(UICommonRewardItemController item)
		{
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005182")]
		[Address(RVA = "0x1CD2768", Offset = "0x1CD2768", VA = "0x7BBC4D2768")]
		private void TryCreatePermanentEffect(UICommonRewardItemController item)
		{
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005183")]
		[Address(RVA = "0x1CD2530", Offset = "0x1CD2530", VA = "0x7BBC4D2530")]
		private void SetRewardToggleState(UICommonRewardItemController item)
		{
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x00018978 File Offset: 0x00016B78
		[Token(Token = "0x6005184")]
		[Address(RVA = "0x1CD2A60", Offset = "0x1CD2A60", VA = "0x7BBC4D2A60")]
		private bool CheckAvatarBundleEquip(UICommonRewardItemController item)
		{
			return default(bool);
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x00018990 File Offset: 0x00016B90
		[Token(Token = "0x6005185")]
		[Address(RVA = "0x1CD2B40", Offset = "0x1CD2B40", VA = "0x7BBC4D2B40")]
		private bool CheckAvatarBundle()
		{
			return default(bool);
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005186")]
		[Address(RVA = "0x1CCDFA0", Offset = "0x1CCDFA0", VA = "0x7BBC4CDFA0")]
		private void InitWndBG()
		{
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005187")]
		[Address(RVA = "0x1CCFB44", Offset = "0x1CCFB44", VA = "0x7BBC4CFB44")]
		private void ShowBtnsView()
		{
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005188")]
		[Address(RVA = "0x1CD002C", Offset = "0x1CD002C", VA = "0x7BBC4D002C")]
		private void ShowVoucherGroupView()
		{
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005189")]
		[Address(RVA = "0x1CD0490", Offset = "0x1CD0490", VA = "0x7BBC4D0490")]
		private void ShowShareView()
		{
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518A")]
		[Address(RVA = "0x1CCFA60", Offset = "0x1CCFA60", VA = "0x7BBC4CFA60")]
		private void SetCommonWndVisble(bool flag)
		{
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518B")]
		[Address(RVA = "0x1CD0764", Offset = "0x1CD0764", VA = "0x7BBC4D0764")]
		private void ShowVoucherTweenAnim()
		{
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518C")]
		[Address(RVA = "0x1CD3118", Offset = "0x1CD3118", VA = "0x7BBC4D3118")]
		public void RefreshCurrencyIcon(ResourceID resID)
		{
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518D")]
		[Address(RVA = "0x1CD31AC", Offset = "0x1CD31AC", VA = "0x7BBC4D31AC")]
		public void RefreshCurrencyCountDown(DateTime time)
		{
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518E")]
		[Address(RVA = "0x1CD3344", Offset = "0x1CD3344", VA = "0x7BBC4D3344")]
		public void RefreshCurrencyIcon(string spritename)
		{
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518F")]
		[Address(RVA = "0x1CD2C98", Offset = "0x1CD2C98", VA = "0x7BBC4D2C98")]
		private void RefreshBuyAgainBtnView()
		{
		}

		// Token: 0x06005190 RID: 20880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005190")]
		[Address(RVA = "0x1CD338C", Offset = "0x1CD338C", VA = "0x7BBC4D338C")]
		private void OnBannerEquipResult(params object[] data)
		{
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005191")]
		[Address(RVA = "0x1CD37C4", Offset = "0x1CD37C4", VA = "0x7BBC4D37C4")]
		private void OnHeadPicEquipResult(params object[] data)
		{
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005192")]
		[Address(RVA = "0x1CD37C8", Offset = "0x1CD37C8", VA = "0x7BBC4D37C8")]
		private void OnCommonEquipResult(params object[] data)
		{
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005193")]
		[Address(RVA = "0x1CD3B68", Offset = "0x1CD3B68", VA = "0x7BBC4D3B68")]
		private void OnEmoteEquipResult(params object[] data)
		{
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005194")]
		[Address(RVA = "0x1CD3B6C", Offset = "0x1CD3B6C", VA = "0x7BBC4D3B6C")]
		private void OnClothEquipResult(params object[] data)
		{
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005195")]
		[Address(RVA = "0x1CD3B70", Offset = "0x1CD3B70", VA = "0x7BBC4D3B70")]
		private void OnAvatarEquipResult(params object[] data)
		{
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005196")]
		[Address(RVA = "0x1CD352C", Offset = "0x1CD352C", VA = "0x7BBC4D352C")]
		private void OnEquipSuccess()
		{
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005197")]
		[Address(RVA = "0x1CD3624", Offset = "0x1CD3624", VA = "0x7BBC4D3624")]
		private void OnEquipFail()
		{
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005198")]
		[Address(RVA = "0x1CD4038", Offset = "0x1CD4038", VA = "0x7BBC4D4038")]
		private void ShowResult()
		{
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005199")]
		[Address(RVA = "0x1CD3A9C", Offset = "0x1CD3A9C", VA = "0x7BBC4D3A9C")]
		private void AutoClose()
		{
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519A")]
		[Address(RVA = "0x1CD423C", Offset = "0x1CD423C", VA = "0x7BBC4D423C")]
		private void OnOKBtnClick()
		{
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519B")]
		[Address(RVA = "0x1CD42C8", Offset = "0x1CD42C8", VA = "0x7BBC4D42C8")]
		private void OnOpenBtnClick()
		{
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519C")]
		[Address(RVA = "0x1CD4750", Offset = "0x1CD4750", VA = "0x7BBC4D4750", Slot = "38")]
		public override void EnterByReturn()
		{
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519D")]
		[Address(RVA = "0x1CD3CD4", Offset = "0x1CD3CD4", VA = "0x7BBC4D3CD4")]
		private void UpdateAvatarClothData(uint itemID)
		{
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519E")]
		[Address(RVA = "0x1CD4ACC", Offset = "0x1CD4ACC", VA = "0x7BBC4D4ACC")]
		public void OnToggleSelected()
		{
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519F")]
		[Address(RVA = "0x1CD4B74", Offset = "0x1CD4B74", VA = "0x7BBC4D4B74")]
		private void OnFastEquipClick()
		{
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x000189A8 File Offset: 0x00016BA8
		[Token(Token = "0x60051A0")]
		[Address(RVA = "0x1CD622C", Offset = "0x1CD622C", VA = "0x7BBC4D622C")]
		private bool CheckItemABReady(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A1")]
		[Address(RVA = "0x1CD6374", Offset = "0x1CD6374", VA = "0x7BBC4D6374")]
		private void OnRepurchaseBtnClick()
		{
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A2")]
		[Address(RVA = "0x1CD67E8", Offset = "0x1CD67E8", VA = "0x7BBC4D67E8")]
		private void OnGoToExchangeClick()
		{
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A3")]
		[Address(RVA = "0x1CD68D0", Offset = "0x1CD68D0", VA = "0x7BBC4D68D0")]
		private void OnGoToSharePreviewClick()
		{
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A4")]
		[Address(RVA = "0x1CD4398", Offset = "0x1CD4398", VA = "0x7BBC4D4398")]
		private void DefOpenAction()
		{
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A5")]
		[Address(RVA = "0x1CD6B74", Offset = "0x1CD6B74", VA = "0x7BBC4D6B74", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A6")]
		[Address(RVA = "0x1CD6C80", Offset = "0x1CD6C80", VA = "0x7BBC4D6C80", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A7")]
		[Address(RVA = "0x1CD6F58", Offset = "0x1CD6F58", VA = "0x7BBC4D6F58")]
		public UIMVPRewardWndController()
		{
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A8")]
		[Address(RVA = "0x1CD722C", Offset = "0x1CD722C", VA = "0x7BBC4D722C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E160", Offset = "0x113E160")]
		private void <ShowRewardFeatureView>b__67_0()
		{
		}

		// Token: 0x040077C1 RID: 30657
		[Token(Token = "0x40077C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Action m_CloseAction;

		// Token: 0x040077C2 RID: 30658
		[Token(Token = "0x40077C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Action m_OpenAction;

		// Token: 0x040077C3 RID: 30659
		[Token(Token = "0x40077C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool m_EnableFastEquip;

		// Token: 0x040077C4 RID: 30660
		[Token(Token = "0x40077C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool m_IsBigPrice;

		// Token: 0x040077C5 RID: 30661
		[Token(Token = "0x40077C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UIMVPRewardWndView m_View;

		// Token: 0x040077C6 RID: 30662
		[Token(Token = "0x40077C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UICommonRewardItemController m_ExtraReward;

		// Token: 0x040077C7 RID: 30663
		[Token(Token = "0x40077C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<UICommonRewardItemController> m_RewardList;

		// Token: 0x040077C8 RID: 30664
		[Token(Token = "0x40077C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private CommonRewardItemInfo m_FreeRewardInfo;

		// Token: 0x040077C9 RID: 30665
		[Token(Token = "0x40077C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<CommonRewardItemInfo> m_RewardInfoList;

		// Token: 0x040077CA RID: 30666
		[Token(Token = "0x40077CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int m_CurRewardIdx;

		// Token: 0x040077CB RID: 30667
		[Token(Token = "0x40077CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private uint m_VoucherID;

		// Token: 0x040077CC RID: 30668
		[Token(Token = "0x40077CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private uint m_ShowRewardDC;

		// Token: 0x040077CD RID: 30669
		[Token(Token = "0x40077CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public uint m_SelectAvatarID;

		// Token: 0x040077CE RID: 30670
		[Token(Token = "0x40077CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public uint m_SelectPetId;

		// Token: 0x040077CF RID: 30671
		[Token(Token = "0x40077CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Dictionary<uint, uint> m_SelectPetSkinDict;

		// Token: 0x040077D0 RID: 30672
		[Token(Token = "0x40077D0")]
		private const int m_MaxRewardCnt1Row = 5;

		// Token: 0x040077D1 RID: 30673
		[Token(Token = "0x40077D1")]
		private const int m_MaxRewardCnt2Row = 11;

		// Token: 0x040077D2 RID: 30674
		[Token(Token = "0x40077D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float m_ShowRewardSecondInterval;

		// Token: 0x040077D3 RID: 30675
		[Token(Token = "0x40077D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool m_Instant;

		// Token: 0x040077D4 RID: 30676
		[Token(Token = "0x40077D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		private bool m_First;

		// Token: 0x040077D5 RID: 30677
		[Token(Token = "0x40077D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFE")]
		private bool m_IsShowAll;

		// Token: 0x040077D6 RID: 30678
		[Token(Token = "0x40077D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF")]
		private bool m_IsDestory;

		// Token: 0x040077D7 RID: 30679
		[Token(Token = "0x40077D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool m_IsCrate;

		// Token: 0x040077D8 RID: 30680
		[Token(Token = "0x40077D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool m_HasShownFinished;

		// Token: 0x040077D9 RID: 30681
		[Token(Token = "0x40077D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private UIMVPRewardWndController.WndStyleEnum m_wndStyle;

		// Token: 0x040077DA RID: 30682
		[Token(Token = "0x40077DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<float> m_scaleList;

		// Token: 0x040077DB RID: 30683
		[Token(Token = "0x40077DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<GameObject> m_BGList;

		// Token: 0x040077DC RID: 30684
		[Token(Token = "0x40077DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<Transform> m_BGBottomPosList;

		// Token: 0x040077DD RID: 30685
		[Token(Token = "0x40077DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private List<Transform> m_BGTopPosList;

		// Token: 0x040077DE RID: 30686
		[Token(Token = "0x40077DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool m_EnableShowFeature;

		// Token: 0x040077DF RID: 30687
		[Token(Token = "0x40077DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private UIMVPRewardWndController.RepurchaseCurrencyType m_RepurchaseCurrencyType;

		// Token: 0x040077E0 RID: 30688
		[Token(Token = "0x40077E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private UIMVPRewardWndController.PurchaseDelegate m_PurchaseDelegate;

		// Token: 0x040077E1 RID: 30689
		[Token(Token = "0x40077E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int m_EquippedSuccessNum;

		// Token: 0x040077E2 RID: 30690
		[Token(Token = "0x40077E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool m_HaveShowFailTip;

		// Token: 0x040077E3 RID: 30691
		[Token(Token = "0x40077E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Dictionary<uint, UICommonRewardItemController> m_SelectedDict;

		// Token: 0x040077E4 RID: 30692
		[Token(Token = "0x40077E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private uint m_AutoCloseDC;

		// Token: 0x040077E5 RID: 30693
		[Token(Token = "0x40077E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private bool m_EnableOKBtnClick;

		// Token: 0x040077E6 RID: 30694
		[Token(Token = "0x40077E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		private bool m_HasABNotReadyItem;

		// Token: 0x040077E7 RID: 30695
		[Token(Token = "0x40077E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private uint m_EquipAvatar;

		// Token: 0x040077E8 RID: 30696
		[Token(Token = "0x40077E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private bool m_EquipCloth;

		// Token: 0x040077E9 RID: 30697
		[Token(Token = "0x40077E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private List<uint> m_EquipClothList;

		// Token: 0x020013A1 RID: 5025
		[Token(Token = "0x20013A1")]
		public enum WndStyleEnum
		{
			// Token: 0x040077EB RID: 30699
			[Token(Token = "0x40077EB")]
			COMMON,
			// Token: 0x040077EC RID: 30700
			[Token(Token = "0x40077EC")]
			DARK,
			// Token: 0x040077ED RID: 30701
			[Token(Token = "0x40077ED")]
			BRIGHT1,
			// Token: 0x040077EE RID: 30702
			[Token(Token = "0x40077EE")]
			BRIGHT2,
			// Token: 0x040077EF RID: 30703
			[Token(Token = "0x40077EF")]
			LEGENDDOWBLEROW,
			// Token: 0x040077F0 RID: 30704
			[Token(Token = "0x40077F0")]
			LEGENDONEROW
		}

		// Token: 0x020013A2 RID: 5026
		[Token(Token = "0x20013A2")]
		public enum RepurchaseCurrencyType
		{
			// Token: 0x040077F2 RID: 30706
			[Token(Token = "0x40077F2")]
			NONE,
			// Token: 0x040077F3 RID: 30707
			[Token(Token = "0x40077F3")]
			FREE,
			// Token: 0x040077F4 RID: 30708
			[Token(Token = "0x40077F4")]
			COUPON,
			// Token: 0x040077F5 RID: 30709
			[Token(Token = "0x40077F5")]
			GOLD,
			// Token: 0x040077F6 RID: 30710
			[Token(Token = "0x40077F6")]
			DIAMOND
		}

		// Token: 0x020013A3 RID: 5027
		// (Invoke) Token: 0x060051AA RID: 20906
		[Token(Token = "0x20013A3")]
		public delegate void PurchaseDelegate(bool isRepurchase);

		// Token: 0x020013A4 RID: 5028
		[Token(Token = "0x20013A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB9C0", Offset = "0x10EB9C0")]
		private sealed class <>c__DisplayClass100_0
		{
			// Token: 0x060051AD RID: 20909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051AD")]
			[Address(RVA = "0x1CD621C", Offset = "0x1CD621C", VA = "0x7BBC4D621C")]
			public <>c__DisplayClass100_0()
			{
			}

			// Token: 0x060051AE RID: 20910 RVA: 0x000189C0 File Offset: 0x00016BC0
			[Token(Token = "0x60051AE")]
			[Address(RVA = "0x1CD7230", Offset = "0x1CD7230", VA = "0x7BBC4D7230")]
			internal bool <OnFastEquipClick>b__0(PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x040077F7 RID: 30711
			[Token(Token = "0x40077F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CSSharedItemData itemData;
		}

		// Token: 0x020013A5 RID: 5029
		[Token(Token = "0x20013A5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB9D0", Offset = "0x10EB9D0")]
		private sealed class <>c__DisplayClass100_1
		{
			// Token: 0x060051AF RID: 20911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051AF")]
			[Address(RVA = "0x1CD6224", Offset = "0x1CD6224", VA = "0x7BBC4D6224")]
			public <>c__DisplayClass100_1()
			{
			}

			// Token: 0x060051B0 RID: 20912 RVA: 0x000189D8 File Offset: 0x00016BD8
			[Token(Token = "0x60051B0")]
			[Address(RVA = "0x1CD727C", Offset = "0x1CD727C", VA = "0x7BBC4D727C")]
			internal bool <OnFastEquipClick>b__1(PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x040077F8 RID: 30712
			[Token(Token = "0x40077F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PetSkinData skinData;
		}
	}
}
