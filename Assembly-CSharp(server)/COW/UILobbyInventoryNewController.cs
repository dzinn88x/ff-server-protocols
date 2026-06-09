using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020019FA RID: 6650
	[Token(Token = "0x20019FA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F75E4", Offset = "0x10F75E4")]
	internal class UILobbyInventoryNewController : UINavigationController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x060089D5 RID: 35285 RVA: 0x00024F78 File Offset: 0x00023178
		[Token(Token = "0x60089D5")]
		[Address(RVA = "0x15399C8", Offset = "0x15399C8", VA = "0x7BBBD399C8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060089D6 RID: 35286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089D6")]
		[Address(RVA = "0x1539A18", Offset = "0x1539A18", VA = "0x7BBBD39A18", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060089D7 RID: 35287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089D7")]
		[Address(RVA = "0x153B654", Offset = "0x153B654", VA = "0x7BBBD3B654")]
		private void StopNewbieGuide(params object[] args)
		{
		}

		// Token: 0x060089D8 RID: 35288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089D8")]
		[Address(RVA = "0x153AD9C", Offset = "0x153AD9C", VA = "0x7BBBD3AD9C")]
		private void InitClothPreviewTogglesDict()
		{
		}

		// Token: 0x060089D9 RID: 35289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089D9")]
		[Address(RVA = "0x153B6EC", Offset = "0x153B6EC", VA = "0x7BBBD3B6EC")]
		private void OnClothPreviewToggleClick()
		{
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089DA")]
		[Address(RVA = "0x153BD98", Offset = "0x153BD98", VA = "0x7BBBD3BD98")]
		private void NavigationToItem(UIModelAvatarBase.EWardrobeType clothType, uint id)
		{
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089DB")]
		[Address(RVA = "0x153B958", Offset = "0x153B958", VA = "0x7BBBD3B958")]
		private void RefreshClothPreviewToggleState([Optional] UIToggleButton tb)
		{
		}

		// Token: 0x060089DC RID: 35292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089DC")]
		[Address(RVA = "0x153C508", Offset = "0x153C508", VA = "0x7BBBD3C508")]
		private void RefreshClothPreviewTab(params object[] data)
		{
		}

		// Token: 0x060089DD RID: 35293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60089DD")]
		[Address(RVA = "0x153CD14", Offset = "0x153CD14", VA = "0x7BBBD3CD14")]
		private InventoryPreviewTabInfo GetPreviewTab(string slotName)
		{
			return null;
		}

		// Token: 0x060089DE RID: 35294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089DE")]
		[Address(RVA = "0x153C8C0", Offset = "0x153C8C0", VA = "0x7BBBD3C8C0")]
		private void SetClothPreviewTabSpriteName(UIModelAvatarBase.EWardrobeType eType, CSSharedItemData itemData)
		{
		}

		// Token: 0x060089DF RID: 35295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089DF")]
		[Address(RVA = "0x153C334", Offset = "0x153C334", VA = "0x7BBBD3C334")]
		private void ResetClothPreviewTab(InventoryPreviewTabInfo tabInfo)
		{
		}

		// Token: 0x060089E0 RID: 35296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089E0")]
		[Address(RVA = "0x153CB4C", Offset = "0x153CB4C", VA = "0x7BBBD3CB4C")]
		private void ReSetClothPreviewTabColor(InventoryPreviewTabInfo tabInfo)
		{
		}

		// Token: 0x060089E1 RID: 35297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089E1")]
		[Address(RVA = "0x153CC08", Offset = "0x153CC08", VA = "0x7BBBD3CC08")]
		private void FadeClothPreviewTabSprite(InventoryPreviewTabInfo tabInfo)
		{
		}

		// Token: 0x060089E2 RID: 35298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089E2")]
		[Address(RVA = "0x153C284", Offset = "0x153C284", VA = "0x7BBBD3C284")]
		private void HighlightPreviewTab(InventoryPreviewTabInfo tabInfo, bool highlight)
		{
		}

		// Token: 0x060089E3 RID: 35299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089E3")]
		[Address(RVA = "0x153CF04", Offset = "0x153CF04", VA = "0x7BBBD3CF04")]
		private void OnHighlightPreviewTabActiveChange(InventoryPreviewTabInfo tabInfo, bool active)
		{
		}

		// Token: 0x060089E4 RID: 35300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089E4")]
		[Address(RVA = "0x153D0D8", Offset = "0x153D0D8", VA = "0x7BBBD3D0D8")]
		private void SetCommonPanel()
		{
		}

		// Token: 0x060089E5 RID: 35301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089E5")]
		[Address(RVA = "0x153D2E8", Offset = "0x153D2E8", VA = "0x7BBBD3D2E8")]
		private void onGrowthCardClick()
		{
		}

		// Token: 0x060089E6 RID: 35302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089E6")]
		[Address(RVA = "0x153D2EC", Offset = "0x153D2EC", VA = "0x7BBBD3D2EC")]
		private void RefreshGrowthCardView()
		{
		}

		// Token: 0x060089E7 RID: 35303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089E7")]
		[Address(RVA = "0x153D610", Offset = "0x153D610", VA = "0x7BBBD3D610")]
		private void RefreshCommonView(bool isClothPreviewShow = false, bool isEpicClothes = false)
		{
		}

		// Token: 0x060089E8 RID: 35304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089E8")]
		[Address(RVA = "0x153DBB0", Offset = "0x153DBB0", VA = "0x7BBBD3DBB0")]
		private void onBundleToggleClick()
		{
		}

		// Token: 0x060089E9 RID: 35305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089E9")]
		[Address(RVA = "0x153DBB4", Offset = "0x153DBB4", VA = "0x7BBBD3DBB4")]
		private void RefreshBundleView()
		{
		}

		// Token: 0x060089EA RID: 35306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089EA")]
		[Address(RVA = "0x153DFB0", Offset = "0x153DFB0", VA = "0x7BBBD3DFB0")]
		private void OnTreasureBoxToggleClick()
		{
		}

		// Token: 0x060089EB RID: 35307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089EB")]
		[Address(RVA = "0x153DFB4", Offset = "0x153DFB4", VA = "0x7BBBD3DFB4")]
		private void RefreshTreasureBoxView()
		{
		}

		// Token: 0x060089EC RID: 35308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089EC")]
		[Address(RVA = "0x153E3B0", Offset = "0x153E3B0", VA = "0x7BBBD3E3B0")]
		private void OnLoadOutToggleClick()
		{
		}

		// Token: 0x060089ED RID: 35309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089ED")]
		[Address(RVA = "0x153E3B4", Offset = "0x153E3B4", VA = "0x7BBBD3E3B4")]
		private void RefreshLoadOutView()
		{
		}

		// Token: 0x060089EE RID: 35310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089EE")]
		[Address(RVA = "0x153E688", Offset = "0x153E688", VA = "0x7BBBD3E688")]
		private void OnToggleGroupItemSelect(UIToggleButton button)
		{
		}

		// Token: 0x060089EF RID: 35311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089EF")]
		[Address(RVA = "0x153E6CC", Offset = "0x153E6CC", VA = "0x7BBBD3E6CC")]
		private void OnClothToggleClick()
		{
		}

		// Token: 0x060089F0 RID: 35312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089F0")]
		[Address(RVA = "0x153E9B0", Offset = "0x153E9B0", VA = "0x7BBBD3E9B0")]
		private void RefreshAvatar()
		{
		}

		// Token: 0x060089F1 RID: 35313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089F1")]
		[Address(RVA = "0x153E6D0", Offset = "0x153E6D0", VA = "0x7BBBD3E6D0")]
		private void RefreshClothView()
		{
		}

		// Token: 0x060089F2 RID: 35314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089F2")]
		[Address(RVA = "0x153F638", Offset = "0x153F638", VA = "0x7BBBD3F638")]
		private void OnExchangeCurrencyClick()
		{
		}

		// Token: 0x060089F3 RID: 35315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089F3")]
		[Address(RVA = "0x153F63C", Offset = "0x153F63C", VA = "0x7BBBD3F63C")]
		private void RefreshExchangeCurrencyView()
		{
		}

		// Token: 0x060089F4 RID: 35316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089F4")]
		[Address(RVA = "0x153F9E0", Offset = "0x153F9E0", VA = "0x7BBBD3F9E0")]
		private void OnInstallmentClick()
		{
		}

		// Token: 0x060089F5 RID: 35317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089F5")]
		[Address(RVA = "0x153F9E4", Offset = "0x153F9E4", VA = "0x7BBBD3F9E4")]
		private void RefreshInsatllmentView()
		{
		}

		// Token: 0x060089F6 RID: 35318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089F6")]
		[Address(RVA = "0x153FB2C", Offset = "0x153FB2C", VA = "0x7BBBD3FB2C")]
		private void RefreshInstallmentViewAfterDataReady()
		{
		}

		// Token: 0x060089F7 RID: 35319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089F7")]
		[Address(RVA = "0x153F0F8", Offset = "0x153F0F8", VA = "0x7BBBD3F0F8")]
		private void CreateSubTab()
		{
		}

		// Token: 0x060089F8 RID: 35320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089F8")]
		[Address(RVA = "0x1540014", Offset = "0x1540014", VA = "0x7BBBD40014")]
		private void SetSubTabInfo(UIToggleButton tg, SubTabInfo info)
		{
		}

		// Token: 0x060089F9 RID: 35321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089F9")]
		[Address(RVA = "0x1540330", Offset = "0x1540330", VA = "0x7BBBD40330")]
		private void OnSubToggleClick()
		{
		}

		// Token: 0x060089FA RID: 35322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089FA")]
		[Address(RVA = "0x153C004", Offset = "0x153C004", VA = "0x7BBBD3C004")]
		private void SelectSubToggle(bool isActiveClick = true)
		{
		}

		// Token: 0x060089FB RID: 35323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089FB")]
		[Address(RVA = "0x1540338", Offset = "0x1540338", VA = "0x7BBBD40338")]
		private void UpdateClothContents(UIModelAvatarBase.EWardrobeType tabType, bool isActiveClick)
		{
		}

		// Token: 0x060089FC RID: 35324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089FC")]
		[Address(RVA = "0x1540B48", Offset = "0x1540B48", VA = "0x7BBBD40B48", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x060089FD RID: 35325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089FD")]
		[Address(RVA = "0x153EBCC", Offset = "0x153EBCC", VA = "0x7BBBD3EBCC")]
		private void InitClothPreviewToggles()
		{
		}

		// Token: 0x060089FE RID: 35326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089FE")]
		[Address(RVA = "0x153C430", Offset = "0x153C430", VA = "0x7BBBD3C430")]
		private void SetDefaultClothIcon(UIModelAvatarBase.EWardrobeType type)
		{
		}

		// Token: 0x060089FF RID: 35327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089FF")]
		[Address(RVA = "0x1541820", Offset = "0x1541820", VA = "0x7BBBD41820", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008A00 RID: 35328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A00")]
		[Address(RVA = "0x1541D5C", Offset = "0x1541D5C", VA = "0x7BBBD41D5C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008A01 RID: 35329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A01")]
		[Address(RVA = "0x1541E30", Offset = "0x1541E30", VA = "0x7BBBD41E30", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06008A02 RID: 35330 RVA: 0x00024F90 File Offset: 0x00023190
		[Token(Token = "0x6008A02")]
		[Address(RVA = "0x1541F70", Offset = "0x1541F70", VA = "0x7BBBD41F70", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06008A03 RID: 35331 RVA: 0x00024FA8 File Offset: 0x000231A8
		[Token(Token = "0x6008A03")]
		[Address(RVA = "0x1541F78", Offset = "0x1541F78", VA = "0x7BBBD41F78", Slot = "32")]
		protected override bool NeedWaitDataReady()
		{
			return default(bool);
		}

		// Token: 0x06008A04 RID: 35332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A04")]
		[Address(RVA = "0x1540E2C", Offset = "0x1540E2C", VA = "0x7BBBD40E2C")]
		private void InitTabs()
		{
		}

		// Token: 0x06008A05 RID: 35333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A05")]
		[Address(RVA = "0x1541F80", Offset = "0x1541F80", VA = "0x7BBBD41F80")]
		private void SetToggleState(UIToggleButton toggle, int itemCount)
		{
		}

		// Token: 0x06008A06 RID: 35334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A06")]
		[Address(RVA = "0x153D9F4", Offset = "0x153D9F4", VA = "0x7BBBD3D9F4")]
		private void SelectItemByIndex(int idx = 0)
		{
		}

		// Token: 0x06008A07 RID: 35335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A07")]
		private void RefreshViewData<DataType>(List<DataType> dataList, bool needSort = true)
		{
		}

		// Token: 0x06008A08 RID: 35336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A08")]
		[Address(RVA = "0x154231C", Offset = "0x154231C", VA = "0x7BBBD4231C")]
		private void RefreshTreasure()
		{
		}

		// Token: 0x06008A09 RID: 35337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A09")]
		[Address(RVA = "0x1542524", Offset = "0x1542524", VA = "0x7BBBD42524")]
		private void RefreshBundle()
		{
		}

		// Token: 0x06008A0A RID: 35338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A0A")]
		[Address(RVA = "0x154272C", Offset = "0x154272C", VA = "0x7BBBD4272C")]
		private void OnTreasureRemove(object[] data)
		{
		}

		// Token: 0x06008A0B RID: 35339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A0B")]
		[Address(RVA = "0x1542730", Offset = "0x1542730", VA = "0x7BBBD42730")]
		private void OnItemRemoved(object[] data)
		{
		}

		// Token: 0x06008A0C RID: 35340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A0C")]
		[Address(RVA = "0x15427CC", Offset = "0x15427CC", VA = "0x7BBBD427CC")]
		private void OnIfLegendItemChosen(params object[] data)
		{
		}

		// Token: 0x06008A0D RID: 35341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A0D")]
		[Address(RVA = "0x15433D4", Offset = "0x15433D4", VA = "0x7BBBD433D4")]
		private void OnBtnColorPanelClick()
		{
		}

		// Token: 0x06008A0E RID: 35342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A0E")]
		[Address(RVA = "0x15433EC", Offset = "0x15433EC", VA = "0x7BBBD433EC")]
		private void OnBtnLegendVaultClick()
		{
		}

		// Token: 0x06008A0F RID: 35343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A0F")]
		[Address(RVA = "0x15434D4", Offset = "0x15434D4", VA = "0x7BBBD434D4")]
		private void OnSwitchColor(params object[] data)
		{
		}

		// Token: 0x06008A10 RID: 35344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A10")]
		[Address(RVA = "0x15431E0", Offset = "0x15431E0", VA = "0x7BBBD431E0")]
		private void ScrollColorPanel(bool show)
		{
		}

		// Token: 0x06008A11 RID: 35345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A11")]
		[Address(RVA = "0x15435F8", Offset = "0x15435F8", VA = "0x7BBBD435F8")]
		private void SetPanelColorShow(int posY)
		{
		}

		// Token: 0x06008A12 RID: 35346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008A12")]
		[Address(RVA = "0x1543650", Offset = "0x1543650", VA = "0x7BBBD43650")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11439FC", Offset = "0x11439FC")]
		private IEnumerator MovePanelShowColor(int posY)
		{
			return null;
		}

		// Token: 0x06008A13 RID: 35347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A13")]
		[Address(RVA = "0x1542CC0", Offset = "0x1542CC0", VA = "0x7BBBD42CC0")]
		private void RefreshColorPanel(uint legendId)
		{
		}

		// Token: 0x06008A14 RID: 35348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A14")]
		[Address(RVA = "0x15436E8", Offset = "0x15436E8", VA = "0x7BBBD436E8", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008A15 RID: 35349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A15")]
		[Address(RVA = "0x1543C40", Offset = "0x1543C40", VA = "0x7BBBD43C40")]
		private void RefreshView(bool resetTab = true)
		{
		}

		// Token: 0x06008A16 RID: 35350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A16")]
		[Address(RVA = "0x1543C80", Offset = "0x1543C80", VA = "0x7BBBD43C80")]
		private void ShowAvatarExpireInfo()
		{
		}

		// Token: 0x06008A17 RID: 35351 RVA: 0x00024FC0 File Offset: 0x000231C0
		[Token(Token = "0x6008A17")]
		[Address(RVA = "0x1543DB4", Offset = "0x1543DB4", VA = "0x7BBBD43DB4", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008A18 RID: 35352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A18")]
		[Address(RVA = "0x1543E78", Offset = "0x1543E78", VA = "0x7BBBD43E78")]
		private void OnItemIndexChange(params object[] data)
		{
		}

		// Token: 0x06008A19 RID: 35353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A19")]
		[Address(RVA = "0x15449A4", Offset = "0x15449A4", VA = "0x7BBBD449A4")]
		private void OnClothSetRecommendClick()
		{
		}

		// Token: 0x06008A1A RID: 35354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A1A")]
		[Address(RVA = "0x1544768", Offset = "0x1544768", VA = "0x7BBBD44768")]
		private void RefreshRecommendClothSetButton(Item item)
		{
		}

		// Token: 0x06008A1B RID: 35355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A1B")]
		[Address(RVA = "0x1544B54", Offset = "0x1544B54", VA = "0x7BBBD44B54")]
		private void onBtnOpenClick()
		{
		}

		// Token: 0x06008A1C RID: 35356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A1C")]
		[Address(RVA = "0x154500C", Offset = "0x154500C", VA = "0x7BBBD4500C")]
		private void OpenTreasureBox()
		{
		}

		// Token: 0x06008A1D RID: 35357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A1D")]
		[Address(RVA = "0x15452E4", Offset = "0x15452E4", VA = "0x7BBBD452E4")]
		private void OnBtnExchangeClick()
		{
		}

		// Token: 0x06008A1E RID: 35358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A1E")]
		[Address(RVA = "0x154542C", Offset = "0x154542C", VA = "0x7BBBD4542C")]
		private void OnBtnRenameClick()
		{
		}

		// Token: 0x06008A1F RID: 35359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A1F")]
		[Address(RVA = "0x15454E8", Offset = "0x15454E8", VA = "0x7BBBD454E8")]
		private void OnBtnForgeClick()
		{
		}

		// Token: 0x06008A20 RID: 35360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A20")]
		[Address(RVA = "0x1545518", Offset = "0x1545518", VA = "0x7BBBD45518")]
		private void OnUpgradeCardClick()
		{
		}

		// Token: 0x06008A21 RID: 35361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A21")]
		[Address(RVA = "0x154582C", Offset = "0x154582C", VA = "0x7BBBD4582C")]
		private void OnExchangeDebris()
		{
		}

		// Token: 0x06008A22 RID: 35362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A22")]
		[Address(RVA = "0x1545AB0", Offset = "0x1545AB0", VA = "0x7BBBD45AB0")]
		private void OnBtnRepayClick()
		{
		}

		// Token: 0x06008A23 RID: 35363 RVA: 0x00024FD8 File Offset: 0x000231D8
		[Token(Token = "0x6008A23")]
		[Address(RVA = "0x1544D5C", Offset = "0x1544D5C", VA = "0x7BBBD44D5C")]
		private bool CheckUseRank()
		{
			return default(bool);
		}

		// Token: 0x06008A24 RID: 35364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A24")]
		[Address(RVA = "0x1544130", Offset = "0x1544130", VA = "0x7BBBD44130")]
		private void PropSelected(Item item)
		{
		}

		// Token: 0x06008A25 RID: 35365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008A25")]
		[Address(RVA = "0x1545C6C", Offset = "0x1545C6C", VA = "0x7BBBD45C6C", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06008A26 RID: 35366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A26")]
		[Address(RVA = "0x1545D00", Offset = "0x1545D00", VA = "0x7BBBD45D00", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06008A27 RID: 35367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A27")]
		[Address(RVA = "0x1545D30", Offset = "0x1545D30", VA = "0x7BBBD45D30")]
		public void OnGotoCharaBtnClick()
		{
		}

		// Token: 0x06008A28 RID: 35368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A28")]
		[Address(RVA = "0x15410E4", Offset = "0x15410E4", VA = "0x7BBBD410E4")]
		private void RefreshCurrentTabView()
		{
		}

		// Token: 0x06008A29 RID: 35369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A29")]
		[Address(RVA = "0x1546024", Offset = "0x1546024", VA = "0x7BBBD46024", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06008A2A RID: 35370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A2A")]
		[Address(RVA = "0x1546174", Offset = "0x1546174", VA = "0x7BBBD46174")]
		private void OnHairUpdate(params object[] data)
		{
		}

		// Token: 0x06008A2B RID: 35371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A2B")]
		[Address(RVA = "0x154632C", Offset = "0x154632C", VA = "0x7BBBD4632C")]
		private void OnFastEquipClick(params object[] data)
		{
		}

		// Token: 0x06008A2C RID: 35372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A2C")]
		[Address(RVA = "0x154637C", Offset = "0x154637C", VA = "0x7BBBD4637C")]
		private void SetStopEffectForAvatarCloseView(bool v)
		{
		}

		// Token: 0x06008A2D RID: 35373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A2D")]
		[Address(RVA = "0x153DB2C", Offset = "0x153DB2C", VA = "0x7BBBD3DB2C")]
		private void ResetStopEffectForAvatarCloseView()
		{
		}

		// Token: 0x06008A2E RID: 35374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A2E")]
		[Address(RVA = "0x1546404", Offset = "0x1546404", VA = "0x7BBBD46404")]
		private void OnHideBackpackChange()
		{
		}

		// Token: 0x06008A2F RID: 35375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A2F")]
		[Address(RVA = "0x153B1F8", Offset = "0x153B1F8", VA = "0x7BBBD3B1F8")]
		private void RefreshLegendVaultBtnActive()
		{
		}

		// Token: 0x06008A30 RID: 35376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A30")]
		[Address(RVA = "0x154153C", Offset = "0x154153C", VA = "0x7BBBD4153C")]
		private void TrySelectBundle(UINavigationData navigationData)
		{
		}

		// Token: 0x06008A31 RID: 35377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A31")]
		[Address(RVA = "0x1546468", Offset = "0x1546468", VA = "0x7BBBD46468")]
		private void OnPlayFacialAnim(params object[] data)
		{
		}

		// Token: 0x06008A32 RID: 35378 RVA: 0x00024FF0 File Offset: 0x000231F0
		[Token(Token = "0x6008A32")]
		[Address(RVA = "0x1546694", Offset = "0x1546694", VA = "0x7BBBD46694")]
		private bool IsEpicClothes(uint id)
		{
			return default(bool);
		}

		// Token: 0x06008A33 RID: 35379 RVA: 0x00025008 File Offset: 0x00023208
		[Token(Token = "0x6008A33")]
		[Address(RVA = "0x154671C", Offset = "0x154671C", VA = "0x7BBBD4671C")]
		private bool IsEpicClothes(InventoryClothInfo w)
		{
			return default(bool);
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06008A34 RID: 35380 RVA: 0x00025020 File Offset: 0x00023220
		[Token(Token = "0x170009C1")]
		private int EpicClothesCount
		{
			[Token(Token = "0x6008A34")]
			[Address(RVA = "0x15422BC", Offset = "0x15422BC", VA = "0x7BBBD422BC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06008A35 RID: 35381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A35")]
		[Address(RVA = "0x1542054", Offset = "0x1542054", VA = "0x7BBBD42054")]
		public void InitEpicClothes()
		{
		}

		// Token: 0x06008A36 RID: 35382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008A36")]
		[Address(RVA = "0x1546748", Offset = "0x1546748", VA = "0x7BBBD46748")]
		private UILobbyInventoryNewController.EpicClothesData CreateEpicClothesData(InventoryClothInfo info)
		{
			return null;
		}

		// Token: 0x06008A37 RID: 35383 RVA: 0x00025038 File Offset: 0x00023238
		[Token(Token = "0x6008A37")]
		[Address(RVA = "0x15468C4", Offset = "0x15468C4", VA = "0x7BBBD468C4")]
		private ResourceID GetEpicClothesCurrentActionEffect()
		{
			return default(ResourceID);
		}

		// Token: 0x06008A38 RID: 35384 RVA: 0x00025050 File Offset: 0x00023250
		[Token(Token = "0x6008A38")]
		[Address(RVA = "0x1546954", Offset = "0x1546954", VA = "0x7BBBD46954")]
		private ResourceID GetEpicClothesCurrentKillEffect()
		{
			return default(ResourceID);
		}

		// Token: 0x06008A39 RID: 35385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A39")]
		[Address(RVA = "0x15469E4", Offset = "0x15469E4", VA = "0x7BBBD469E4")]
		private void OnClickEpicClothesToggle()
		{
		}

		// Token: 0x06008A3A RID: 35386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A3A")]
		[Address(RVA = "0x15469E8", Offset = "0x15469E8", VA = "0x7BBBD469E8")]
		private void OnClickEpicClothesSubToggle()
		{
		}

		// Token: 0x06008A3B RID: 35387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A3B")]
		[Address(RVA = "0x1546B68", Offset = "0x1546B68", VA = "0x7BBBD46B68")]
		private void OnClickEpicClothesUpBtn()
		{
		}

		// Token: 0x06008A3C RID: 35388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A3C")]
		[Address(RVA = "0x1546E40", Offset = "0x1546E40", VA = "0x7BBBD46E40")]
		private void OnClickEpicClothesEquipBtn()
		{
		}

		// Token: 0x06008A3D RID: 35389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A3D")]
		[Address(RVA = "0x154718C", Offset = "0x154718C", VA = "0x7BBBD4718C")]
		private void OnClickEpicClothesWaitingRoomEffectBtn()
		{
		}

		// Token: 0x06008A3E RID: 35390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A3E")]
		[Address(RVA = "0x1547278", Offset = "0x1547278", VA = "0x7BBBD47278")]
		private void OnClickEpicClothesKillEffectBtn()
		{
		}

		// Token: 0x06008A3F RID: 35391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A3F")]
		[Address(RVA = "0x15472A0", Offset = "0x15472A0", VA = "0x7BBBD472A0")]
		private void OnClickEpicClothesActionEffectBtn()
		{
		}

		// Token: 0x06008A40 RID: 35392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A40")]
		[Address(RVA = "0x15472C8", Offset = "0x15472C8", VA = "0x7BBBD472C8")]
		private void OnClickEpicClothesFlagBtn()
		{
		}

		// Token: 0x06008A41 RID: 35393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A41")]
		[Address(RVA = "0x1547700", Offset = "0x1547700", VA = "0x7BBBD47700")]
		private void OnClickEpicClothesLootBoxBtn()
		{
		}

		// Token: 0x06008A42 RID: 35394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A42")]
		[Address(RVA = "0x154784C", Offset = "0x154784C", VA = "0x7BBBD4784C")]
		private void OnClickEpicClothesScrollDownBtn()
		{
		}

		// Token: 0x06008A43 RID: 35395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A43")]
		[Address(RVA = "0x154789C", Offset = "0x154789C", VA = "0x7BBBD4789C")]
		private void OnEpicClothesScrollDownDragFinish()
		{
		}

		// Token: 0x06008A44 RID: 35396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A44")]
		[Address(RVA = "0x1547008", Offset = "0x1547008", VA = "0x7BBBD47008")]
		private void EquipEpicClothes()
		{
		}

		// Token: 0x06008A45 RID: 35397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A45")]
		[Address(RVA = "0x1545E1C", Offset = "0x1545E1C", VA = "0x7BBBD45E1C")]
		private void RefreshEpicClothesView()
		{
		}

		// Token: 0x06008A46 RID: 35398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A46")]
		private void ResetCameraForAvatar<T>(Action<T> c, T t)
		{
		}

		// Token: 0x06008A47 RID: 35399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A47")]
		[Address(RVA = "0x1547904", Offset = "0x1547904", VA = "0x7BBBD47904")]
		private void CreateEpicClothesToggles()
		{
		}

		// Token: 0x06008A48 RID: 35400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A48")]
		[Address(RVA = "0x1547CE4", Offset = "0x1547CE4", VA = "0x7BBBD47CE4")]
		private void SetSubTabInfo(UIToggleButton tg, UILobbyInventoryNewController.EpicClothesData info)
		{
		}

		// Token: 0x06008A49 RID: 35401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A49")]
		[Address(RVA = "0x1548064", Offset = "0x1548064", VA = "0x7BBBD48064")]
		private void ShowEpicClothesToggleIcon(UISprite sprite, ResourceID res)
		{
		}

		// Token: 0x06008A4A RID: 35402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A4A")]
		[Address(RVA = "0x15481D8", Offset = "0x15481D8", VA = "0x7BBBD481D8")]
		private void ShowEpicClothesTip(UILobbyInventoryNewController.EpicClothesData info, bool show)
		{
		}

		// Token: 0x06008A4B RID: 35403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A4B")]
		[Address(RVA = "0x15482E4", Offset = "0x15482E4", VA = "0x7BBBD482E4")]
		private void SetupEpicClothesView(int index)
		{
		}

		// Token: 0x06008A4C RID: 35404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A4C")]
		[Address(RVA = "0x154858C", Offset = "0x154858C", VA = "0x7BBBD4858C")]
		private void SetupEpicClothesView(UILobbyInventoryNewController.EpicClothesData c)
		{
		}

		// Token: 0x06008A4D RID: 35405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A4D")]
		[Address(RVA = "0x15487D8", Offset = "0x15487D8", VA = "0x7BBBD487D8")]
		private void SetupEpicContents(UILobbyInventoryNewController.EpicClothesData c)
		{
		}

		// Token: 0x06008A4E RID: 35406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A4E")]
		[Address(RVA = "0x1548AE8", Offset = "0x1548AE8", VA = "0x7BBBD48AE8")]
		private void SetupEpicConditions(string[] conditions)
		{
		}

		// Token: 0x06008A4F RID: 35407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A4F")]
		[Address(RVA = "0x1546BA8", Offset = "0x1546BA8", VA = "0x7BBBD46BA8")]
		private void UpdateEpicClothesUpBtnText(int currentLevel)
		{
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A50")]
		[Address(RVA = "0x1549094", Offset = "0x1549094", VA = "0x7BBBD49094")]
		private void UpdateEpicClothesUpEquipBtn(bool canEquip)
		{
		}

		// Token: 0x06008A51 RID: 35409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A51")]
		[Address(RVA = "0x1548A14", Offset = "0x1548A14", VA = "0x7BBBD48A14")]
		private void SetLabel(UILabel lb, string key)
		{
		}

		// Token: 0x06008A52 RID: 35410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A52")]
		[Address(RVA = "0x15490C8", Offset = "0x15490C8", VA = "0x7BBBD490C8")]
		private void EnableBtn(UIButton btn, bool enable)
		{
		}

		// Token: 0x06008A53 RID: 35411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A53")]
		[Address(RVA = "0x1549134", Offset = "0x1549134", VA = "0x7BBBD49134")]
		private void EnableBtnForRes(UIButton btn, ResourceID res)
		{
		}

		// Token: 0x06008A54 RID: 35412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A54")]
		[Address(RVA = "0x1548F98", Offset = "0x1548F98", VA = "0x7BBBD48F98")]
		private void HideBtnContainerForRes(UIButton btn, ResourceID res)
		{
		}

		// Token: 0x06008A55 RID: 35413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A55")]
		[Address(RVA = "0x1549088", Offset = "0x1549088", VA = "0x7BBBD49088")]
		private void EnableBtnForID(UIButton btn, uint id)
		{
		}

		// Token: 0x06008A56 RID: 35414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A56")]
		[Address(RVA = "0x1546D20", Offset = "0x1546D20", VA = "0x7BBBD46D20")]
		private void ShowEpicClothesWithCurrentLevel(bool playEffect)
		{
		}

		// Token: 0x06008A57 RID: 35415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A57")]
		[Address(RVA = "0x1547444", Offset = "0x1547444", VA = "0x7BBBD47444")]
		private void ShowEpicClothesFromReturn()
		{
		}

		// Token: 0x06008A58 RID: 35416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A58")]
		[Address(RVA = "0x15471D0", Offset = "0x15471D0", VA = "0x7BBBD471D0")]
		private void ShowEpicClothesEffect(ResourceID resId)
		{
		}

		// Token: 0x06008A59 RID: 35417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A59")]
		[Address(RVA = "0x1549334", Offset = "0x1549334", VA = "0x7BBBD49334")]
		private void ShowEpicClothesEffect(UIMaleAvatar avatar, ResourceID resId)
		{
		}

		// Token: 0x06008A5A RID: 35418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A5A")]
		[Address(RVA = "0x15491C0", Offset = "0x15491C0", VA = "0x7BBBD491C0")]
		private void ShowEpicClothes(UIMaleAvatar avatar, uint id)
		{
		}

		// Token: 0x06008A5B RID: 35419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A5B")]
		[Address(RVA = "0x15476A0", Offset = "0x15476A0", VA = "0x7BBBD476A0")]
		private void ShowUpdateBtn(bool show)
		{
		}

		// Token: 0x06008A5C RID: 35420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A5C")]
		[Address(RVA = "0x15475BC", Offset = "0x15475BC", VA = "0x7BBBD475BC")]
		private void SetEpicClothesShowBtn(UILabel label, ref bool mark)
		{
		}

		// Token: 0x06008A5D RID: 35421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A5D")]
		[Address(RVA = "0x15474DC", Offset = "0x15474DC", VA = "0x7BBBD474DC")]
		private void ResetEpicClothesShowBtn(UILabel label, ref bool mark)
		{
		}

		// Token: 0x06008A5E RID: 35422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A5E")]
		[Address(RVA = "0x154939C", Offset = "0x154939C", VA = "0x7BBBD4939C")]
		private void ResetFlagLootBoxBtns(bool showClothes = true)
		{
		}

		// Token: 0x06008A5F RID: 35423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A5F")]
		[Address(RVA = "0x15470D4", Offset = "0x15470D4", VA = "0x7BBBD470D4")]
		private void ResetEquipBtn(UILobbyInventoryNewController.EpicClothesData c)
		{
		}

		// Token: 0x06008A60 RID: 35424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A60")]
		[Address(RVA = "0x1549438", Offset = "0x1549438", VA = "0x7BBBD49438")]
		private void ResetEquipBtn(bool enable)
		{
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A61")]
		[Address(RVA = "0x15494D0", Offset = "0x15494D0", VA = "0x7BBBD494D0")]
		public UILobbyInventoryNewController()
		{
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A62")]
		[Address(RVA = "0x1549890", Offset = "0x1549890", VA = "0x7BBBD49890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143A60", Offset = "0x1143A60")]
		private void <OnUIInit>b__27_0()
		{
		}

		// Token: 0x06008A63 RID: 35427 RVA: 0x00025068 File Offset: 0x00023268
		[Token(Token = "0x6008A63")]
		[Address(RVA = "0x15499EC", Offset = "0x15499EC", VA = "0x7BBBD499EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143A70", Offset = "0x1143A70")]
		private bool <RefreshBundleView>b__46_0(InventoryItemInfo item)
		{
			return default(bool);
		}

		// Token: 0x06008A64 RID: 35428 RVA: 0x00025080 File Offset: 0x00023280
		[Token(Token = "0x6008A64")]
		[Address(RVA = "0x1549A38", Offset = "0x1549A38", VA = "0x7BBBD49A38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143A80", Offset = "0x1143A80")]
		private bool <RefreshTreasureBoxView>b__48_0(InventoryItemInfo item)
		{
			return default(bool);
		}

		// Token: 0x06008A65 RID: 35429 RVA: 0x00025098 File Offset: 0x00023298
		[Token(Token = "0x6008A65")]
		[Address(RVA = "0x1549A84", Offset = "0x1549A84", VA = "0x7BBBD49A84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143A90", Offset = "0x1143A90")]
		private int <RefreshInstallmentViewAfterDataReady>b__59_1(InventoryItemInfo x, InventoryItemInfo y)
		{
			return 0;
		}

		// Token: 0x06008A66 RID: 35430 RVA: 0x000250B0 File Offset: 0x000232B0
		[Token(Token = "0x6008A66")]
		[Address(RVA = "0x1549BB4", Offset = "0x1549BB4", VA = "0x7BBBD49BB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143AA0", Offset = "0x1143AA0")]
		private bool <UpdateClothContents>b__64_0(InventoryClothShowingInfo w)
		{
			return default(bool);
		}

		// Token: 0x06008A67 RID: 35431 RVA: 0x000250C8 File Offset: 0x000232C8
		[Token(Token = "0x6008A67")]
		[Address(RVA = "0x1549CF4", Offset = "0x1549CF4", VA = "0x7BBBD49CF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143AB0", Offset = "0x1143AB0")]
		private bool <OnSwitchColor>b__84_0(InventoryClothShowingInfo info)
		{
			return default(bool);
		}

		// Token: 0x06008A68 RID: 35432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008A68")]
		[Address(RVA = "0x1549D38", Offset = "0x1549D38", VA = "0x7BBBD49D38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143AC0", Offset = "0x1143AC0")]
		private void <RefreshColorPanel>b__88_0()
		{
		}

		// Token: 0x06008A69 RID: 35433 RVA: 0x000250E0 File Offset: 0x000232E0
		[Token(Token = "0x6008A69")]
		[Address(RVA = "0x1549D40", Offset = "0x1549D40", VA = "0x7BBBD49D40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143AD0", Offset = "0x1143AD0")]
		private bool <OnDataChanged>b__89_0(InventoryClothShowingInfo item)
		{
			return default(bool);
		}

		// Token: 0x040097BD RID: 38845
		[Token(Token = "0x40097BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UILobbyInventoryNewView m_View;

		// Token: 0x040097BE RID: 38846
		[Token(Token = "0x40097BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x040097BF RID: 38847
		[Token(Token = "0x40097BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Item m_CachedBoxData;

		// Token: 0x040097C0 RID: 38848
		[Token(Token = "0x40097C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Item m_CachedBundleData;

		// Token: 0x040097C1 RID: 38849
		[Token(Token = "0x40097C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Item m_SelectedExchangeCurrencyItem;

		// Token: 0x040097C2 RID: 38850
		[Token(Token = "0x40097C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Item m_SelectedItem;

		// Token: 0x040097C3 RID: 38851
		[Token(Token = "0x40097C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private UIRoot m_UIRoot;

		// Token: 0x040097C4 RID: 38852
		[Token(Token = "0x40097C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<SubTabInfo> m_SubToggleList;

		// Token: 0x040097C5 RID: 38853
		[Token(Token = "0x40097C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<InventoryClothShowingInfo> m_CurrentDataList;

		// Token: 0x040097C6 RID: 38854
		[Token(Token = "0x40097C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private uint m_UseRank;

		// Token: 0x040097C7 RID: 38855
		[Token(Token = "0x40097C7")]
		private const uint CLOTHPREVIEW_ICON_GREY = 1650615039U;

		// Token: 0x040097C8 RID: 38856
		[Token(Token = "0x40097C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private UIModelAvatarProfile m_ModelAvatarProfile;

		// Token: 0x040097C9 RID: 38857
		[Token(Token = "0x40097C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private uint m_LegendClothType;

		// Token: 0x040097CA RID: 38858
		[Token(Token = "0x40097CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Coroutine m_CoroutineMovePanelShowColor;

		// Token: 0x040097CB RID: 38859
		[Token(Token = "0x40097CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool m_IsColorPanelShow;

		// Token: 0x040097CC RID: 38860
		[Token(Token = "0x40097CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private List<SubTabInfo> m_TabClothList;

		// Token: 0x040097CD RID: 38861
		[Token(Token = "0x40097CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private UIModelAvatar m_ModelAvatar;

		// Token: 0x040097CE RID: 38862
		[Token(Token = "0x40097CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public bool m_IsClothSelect;

		// Token: 0x040097CF RID: 38863
		[Token(Token = "0x40097CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		private bool m_IsSelectedSet;

		// Token: 0x040097D0 RID: 38864
		[Token(Token = "0x40097D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		public bool m_IsInstallmentSelect;

		// Token: 0x040097D1 RID: 38865
		[Token(Token = "0x40097D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Dictionary<EMallScrollViewPosType, Vector3> m_MallScrollViewPosDict;

		// Token: 0x040097D2 RID: 38866
		[Token(Token = "0x40097D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Dictionary<UIModelAvatarBase.EWardrobeType, InventoryPreviewTabInfo> m_ClothPreviewToggleDict;

		// Token: 0x040097D3 RID: 38867
		[Token(Token = "0x40097D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool m_UIControllerFirstCreated;

		// Token: 0x040097D4 RID: 38868
		[Token(Token = "0x40097D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private UIGuideTipsController m_GuideTipsCtrl;

		// Token: 0x040097D5 RID: 38869
		[Token(Token = "0x40097D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private UIInventoryClothSetRecommendController m_UIClothSetRecommend;

		// Token: 0x040097D6 RID: 38870
		[Token(Token = "0x40097D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private AvatarWardrobeData m_ClothesDataForHideBackpack;

		// Token: 0x040097D7 RID: 38871
		[Token(Token = "0x40097D7")]
		private const UIModelAvatarBase.EWardrobeType EpicClothesType = UIModelAvatarBase.EWardrobeType.Set;

		// Token: 0x040097D8 RID: 38872
		[Token(Token = "0x40097D8")]
		private const uint MaxEpicClothesLevel = 3U;

		// Token: 0x040097D9 RID: 38873
		[Token(Token = "0x40097D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<UILobbyInventoryNewController.EpicClothesData> m_EpicClothes;

		// Token: 0x040097DA RID: 38874
		[Token(Token = "0x40097DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private UILobbyInventoryNewController.EpicClothesData m_CurrentEpicClothes;

		// Token: 0x040097DB RID: 38875
		[Token(Token = "0x40097DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private uint m_CurrentEpicClothesTargetAvatarID;

		// Token: 0x040097DC RID: 38876
		[Token(Token = "0x40097DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private bool m_CurrentEpicClothesTargetFemale;

		// Token: 0x040097DD RID: 38877
		[Token(Token = "0x40097DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int m_CurrentEpicClothesLevel;

		// Token: 0x040097DE RID: 38878
		[Token(Token = "0x40097DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private int m_CurrentEpicClothesMaxLevel;

		// Token: 0x040097DF RID: 38879
		[Token(Token = "0x40097DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool m_ShowingEpicClothesFlag;

		// Token: 0x040097E0 RID: 38880
		[Token(Token = "0x40097E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
		private bool m_ShowingEpicClothesLootbox;

		// Token: 0x040097E1 RID: 38881
		[Token(Token = "0x40097E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private ShowBoostAvatarParams m_ShowingEpicClothesParams;

		// Token: 0x040097E2 RID: 38882
		[Token(Token = "0x40097E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private UIWidget[] m_EpicClothesCondWidgtes;

		// Token: 0x040097E3 RID: 38883
		[Token(Token = "0x40097E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private UILabel[] m_EpicClothesCondLabels;

		// Token: 0x020019FB RID: 6651
		[Token(Token = "0x20019FB")]
		private class EpicClothesData : IComparable<UILobbyInventoryNewController.EpicClothesData>
		{
			// Token: 0x170009C2 RID: 2498
			// (get) Token: 0x06008A6A RID: 35434 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009C2")]
			public CSSharedItemData ItemData
			{
				[Token(Token = "0x6008A6A")]
				[Address(RVA = "0x143E140", Offset = "0x143E140", VA = "0x7BBBC3E140")]
				get
				{
					return null;
				}
			}

			// Token: 0x170009C3 RID: 2499
			// (get) Token: 0x06008A6B RID: 35435 RVA: 0x000250F8 File Offset: 0x000232F8
			[Token(Token = "0x170009C3")]
			public uint ID
			{
				[Token(Token = "0x6008A6B")]
				[Address(RVA = "0x143DD9C", Offset = "0x143DD9C", VA = "0x7BBBC3DD9C")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x170009C4 RID: 2500
			// (get) Token: 0x06008A6C RID: 35436 RVA: 0x00025110 File Offset: 0x00023310
			[Token(Token = "0x170009C4")]
			public ResourceID Icon
			{
				[Token(Token = "0x6008A6C")]
				[Address(RVA = "0x143E1F8", Offset = "0x143E1F8", VA = "0x7BBBC3E1F8")]
				get
				{
					return default(ResourceID);
				}
			}

			// Token: 0x170009C5 RID: 2501
			// (get) Token: 0x06008A6D RID: 35437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009C5")]
			public string NameKey
			{
				[Token(Token = "0x6008A6D")]
				[Address(RVA = "0x143E28C", Offset = "0x143E28C", VA = "0x7BBBC3E28C")]
				get
				{
					return null;
				}
			}

			// Token: 0x170009C6 RID: 2502
			// (get) Token: 0x06008A6E RID: 35438 RVA: 0x00025128 File Offset: 0x00023328
			[Token(Token = "0x170009C6")]
			public int MaxLevel
			{
				[Token(Token = "0x6008A6E")]
				[Address(RVA = "0x143E308", Offset = "0x143E308", VA = "0x7BBBC3E308")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06008A6F RID: 35439 RVA: 0x00025140 File Offset: 0x00023340
			[Token(Token = "0x6008A6F")]
			[Address(RVA = "0x143E370", Offset = "0x143E370", VA = "0x7BBBC3E370")]
			public bool CanEquip(uint avatarID, bool female)
			{
				return default(bool);
			}

			// Token: 0x06008A70 RID: 35440 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008A70")]
			[Address(RVA = "0x143E388", Offset = "0x143E388", VA = "0x7BBBC3E388")]
			public ClothesUpData GetLevelUpData(int level)
			{
				return null;
			}

			// Token: 0x06008A71 RID: 35441 RVA: 0x00025158 File Offset: 0x00023358
			[Token(Token = "0x6008A71")]
			[Address(RVA = "0x143E438", Offset = "0x143E438", VA = "0x7BBBC3E438")]
			public uint GetClothesID(int level)
			{
				return 0U;
			}

			// Token: 0x06008A72 RID: 35442 RVA: 0x00025170 File Offset: 0x00023370
			[Token(Token = "0x6008A72")]
			[Address(RVA = "0x143E47C", Offset = "0x143E47C", VA = "0x7BBBC3E47C")]
			public ResourceID GetLevelUpEffect(int level, bool female)
			{
				return default(ResourceID);
			}

			// Token: 0x06008A73 RID: 35443 RVA: 0x00025188 File Offset: 0x00023388
			[Token(Token = "0x6008A73")]
			[Address(RVA = "0x143E51C", Offset = "0x143E51C", VA = "0x7BBBC3E51C", Slot = "4")]
			public int CompareTo(UILobbyInventoryNewController.EpicClothesData other)
			{
				return 0;
			}

			// Token: 0x06008A74 RID: 35444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008A74")]
			[Address(RVA = "0x143E564", Offset = "0x143E564", VA = "0x7BBBC3E564")]
			public EpicClothesData()
			{
			}

			// Token: 0x040097E4 RID: 38884
			[Token(Token = "0x40097E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InventoryClothInfo InventoryData;

			// Token: 0x040097E5 RID: 38885
			[Token(Token = "0x40097E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AvatarWardrobeData ClothesData;

			// Token: 0x040097E6 RID: 38886
			[Token(Token = "0x40097E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EpicClothesTextData EpicData;

			// Token: 0x040097E7 RID: 38887
			[Token(Token = "0x40097E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<ClothesUpData> UpdateDatas;

			// Token: 0x040097E8 RID: 38888
			[Token(Token = "0x40097E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UIToggleButton ToggleButton;

			// Token: 0x040097E9 RID: 38889
			[Token(Token = "0x40097E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public UITipsButton Tip;

			// Token: 0x040097EA RID: 38890
			[Token(Token = "0x40097EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private CSSharedItemData m_ItemData;
		}

		// Token: 0x020019FC RID: 6652
		[Token(Token = "0x20019FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F761C", Offset = "0x10F761C")]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06008A75 RID: 35445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008A75")]
			[Address(RVA = "0x143DDC8", Offset = "0x143DDC8", VA = "0x7BBBC3DDC8")]
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x06008A76 RID: 35446 RVA: 0x000251A0 File Offset: 0x000233A0
			[Token(Token = "0x6008A76")]
			[Address(RVA = "0x143DDD0", Offset = "0x143DDD0", VA = "0x7BBBC3DDD0")]
			internal bool <NavigationToItem>b__0(SubTabInfo temp)
			{
				return default(bool);
			}

			// Token: 0x06008A77 RID: 35447 RVA: 0x000251B8 File Offset: 0x000233B8
			[Token(Token = "0x6008A77")]
			[Address(RVA = "0x143DE0C", Offset = "0x143DE0C", VA = "0x7BBBC3DE0C")]
			internal bool <NavigationToItem>b__1(InventoryClothShowingInfo clothInfo)
			{
				return default(bool);
			}

			// Token: 0x040097EB RID: 38891
			[Token(Token = "0x40097EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelAvatarBase.EWardrobeType clothType;

			// Token: 0x040097EC RID: 38892
			[Token(Token = "0x40097EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint id;
		}

		// Token: 0x020019FD RID: 6653
		[Token(Token = "0x20019FD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F762C", Offset = "0x10F762C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008A79 RID: 35449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008A79")]
			[Address(RVA = "0x143D9B4", Offset = "0x143D9B4", VA = "0x7BBBC3D9B4")]
			public <>c()
			{
			}

			// Token: 0x06008A7A RID: 35450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008A7A")]
			[Address(RVA = "0x143D9BC", Offset = "0x143D9BC", VA = "0x7BBBC3D9BC")]
			internal InventoryItemInfo <RefreshExchangeCurrencyView>b__56_0(Item item)
			{
				return null;
			}

			// Token: 0x06008A7B RID: 35451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008A7B")]
			[Address(RVA = "0x143D9C8", Offset = "0x143D9C8", VA = "0x7BBBC3D9C8")]
			internal InventoryItemInfo <RefreshInstallmentViewAfterDataReady>b__59_0(Item item)
			{
				return null;
			}

			// Token: 0x06008A7C RID: 35452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008A7C")]
			[Address(RVA = "0x143DAA0", Offset = "0x143DAA0", VA = "0x7BBBC3DAA0")]
			internal UIToggleButton <CreateSubTab>b__60_0(SubTabInfo info)
			{
				return null;
			}

			// Token: 0x06008A7D RID: 35453 RVA: 0x000251D0 File Offset: 0x000233D0
			[Token(Token = "0x6008A7D")]
			[Address(RVA = "0x143DACC", Offset = "0x143DACC", VA = "0x7BBBC3DACC")]
			internal bool <SelectSubToggle>b__63_0(SubTabInfo temp)
			{
				return default(bool);
			}

			// Token: 0x06008A7E RID: 35454 RVA: 0x000251E8 File Offset: 0x000233E8
			[Token(Token = "0x6008A7E")]
			[Address(RVA = "0x143DB0C", Offset = "0x143DB0C", VA = "0x7BBBC3DB0C")]
			internal bool <OnPlayFacialAnim>b__118_0(SubTabInfo temp)
			{
				return default(bool);
			}

			// Token: 0x06008A7F RID: 35455 RVA: 0x00025200 File Offset: 0x00023400
			[Token(Token = "0x6008A7F")]
			[Address(RVA = "0x143DB4C", Offset = "0x143DB4C", VA = "0x7BBBC3DB4C")]
			internal BoostState <InitEpicClothes>b__137_0(uint id)
			{
				return BoostState.DontChange;
			}

			// Token: 0x06008A80 RID: 35456 RVA: 0x00025218 File Offset: 0x00023418
			[Token(Token = "0x6008A80")]
			[Address(RVA = "0x143DB54", Offset = "0x143DB54", VA = "0x7BBBC3DB54")]
			internal bool <OnClickEpicClothesSubToggle>b__142_0(UILobbyInventoryNewController.EpicClothesData t)
			{
				return default(bool);
			}

			// Token: 0x06008A81 RID: 35457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008A81")]
			[Address(RVA = "0x143DC00", Offset = "0x143DC00", VA = "0x7BBBC3DC00")]
			internal UIToggleButton <CreateEpicClothesToggles>b__155_0(UILobbyInventoryNewController.EpicClothesData info)
			{
				return null;
			}

			// Token: 0x040097ED RID: 38893
			[Token(Token = "0x40097ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UILobbyInventoryNewController.<>c <>9;

			// Token: 0x040097EE RID: 38894
			[Token(Token = "0x40097EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Converter<Item, InventoryItemInfo> <>9__56_0;

			// Token: 0x040097EF RID: 38895
			[Token(Token = "0x40097EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Converter<Item, InventoryItemInfo> <>9__59_0;

			// Token: 0x040097F0 RID: 38896
			[Token(Token = "0x40097F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<SubTabInfo, UIToggleButton> <>9__60_0;

			// Token: 0x040097F1 RID: 38897
			[Token(Token = "0x40097F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Predicate<SubTabInfo> <>9__63_0;

			// Token: 0x040097F2 RID: 38898
			[Token(Token = "0x40097F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Predicate<SubTabInfo> <>9__118_0;

			// Token: 0x040097F3 RID: 38899
			[Token(Token = "0x40097F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static ShowBoostAvatarParams.CheckBoostStateDelegate <>9__137_0;

			// Token: 0x040097F4 RID: 38900
			[Token(Token = "0x40097F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Predicate<UILobbyInventoryNewController.EpicClothesData> <>9__142_0;

			// Token: 0x040097F5 RID: 38901
			[Token(Token = "0x40097F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<UILobbyInventoryNewController.EpicClothesData, UIToggleButton> <>9__155_0;
		}

		// Token: 0x020019FE RID: 6654
		[Token(Token = "0x20019FE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F763C", Offset = "0x10F763C")]
		private sealed class <>c__DisplayClass64_0
		{
			// Token: 0x06008A82 RID: 35458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008A82")]
			[Address(RVA = "0x143DE44", Offset = "0x143DE44", VA = "0x7BBBC3DE44")]
			public <>c__DisplayClass64_0()
			{
			}

			// Token: 0x06008A83 RID: 35459 RVA: 0x00025230 File Offset: 0x00023430
			[Token(Token = "0x6008A83")]
			[Address(RVA = "0x143DE4C", Offset = "0x143DE4C", VA = "0x7BBBC3DE4C")]
			internal bool <UpdateClothContents>b__1(InventoryClothShowingInfo x)
			{
				return default(bool);
			}

			// Token: 0x040097F6 RID: 38902
			[Token(Token = "0x40097F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint legendType;
		}

		// Token: 0x020019FF RID: 6655
		[Token(Token = "0x20019FF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F764C", Offset = "0x10F764C")]
		private sealed class <MovePanelShowColor>d__87 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008A84 RID: 35460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008A84")]
			[Address(RVA = "0x143DEA0", Offset = "0x143DEA0", VA = "0x7BBBC3DEA0")]
			[DebuggerHidden]
			public <MovePanelShowColor>d__87(int <>1__state)
			{
			}

			// Token: 0x06008A85 RID: 35461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008A85")]
			[Address(RVA = "0x143DECC", Offset = "0x143DECC", VA = "0x7BBBC3DECC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008A86 RID: 35462 RVA: 0x00025248 File Offset: 0x00023448
			[Token(Token = "0x6008A86")]
			[Address(RVA = "0x143DED0", Offset = "0x143DED0", VA = "0x7BBBC3DED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009C7 RID: 2503
			// (get) Token: 0x06008A87 RID: 35463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009C7")]
			private object Current
			{
				[Token(Token = "0x6008A87")]
				[Address(RVA = "0x143E0C8", Offset = "0x143E0C8", VA = "0x7BBBC3E0C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008A88 RID: 35464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008A88")]
			[Address(RVA = "0x143E0D0", Offset = "0x143E0D0", VA = "0x7BBBC3E0D0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009C8 RID: 2504
			// (get) Token: 0x06008A89 RID: 35465 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009C8")]
			private object Current
			{
				[Token(Token = "0x6008A89")]
				[Address(RVA = "0x143E138", Offset = "0x143E138", VA = "0x7BBBC3E138", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040097F7 RID: 38903
			[Token(Token = "0x40097F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040097F8 RID: 38904
			[Token(Token = "0x40097F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040097F9 RID: 38905
			[Token(Token = "0x40097F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UILobbyInventoryNewController <>4__this;

			// Token: 0x040097FA RID: 38906
			[Token(Token = "0x40097FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int posY;

			// Token: 0x040097FB RID: 38907
			[Token(Token = "0x40097FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <minDelta>5__2;

			// Token: 0x040097FC RID: 38908
			[Token(Token = "0x40097FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <moveSpeed>5__3;
		}

		// Token: 0x02001A00 RID: 6656
		[Token(Token = "0x2001A00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F765C", Offset = "0x10F765C")]
		private sealed class <>c__DisplayClass101_0
		{
			// Token: 0x06008A8A RID: 35466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008A8A")]
			[Address(RVA = "0x143DC2C", Offset = "0x143DC2C", VA = "0x7BBBC3DC2C")]
			public <>c__DisplayClass101_0()
			{
			}

			// Token: 0x06008A8B RID: 35467 RVA: 0x00025260 File Offset: 0x00023460
			[Token(Token = "0x6008A8B")]
			[Address(RVA = "0x143DC34", Offset = "0x143DC34", VA = "0x7BBBC3DC34")]
			internal bool <OnUpgradeCardClick>b__0(AvatarProfile a)
			{
				return default(bool);
			}

			// Token: 0x040097FD RID: 38909
			[Token(Token = "0x40097FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UILobbyInventoryNewController <>4__this;

			// Token: 0x040097FE RID: 38910
			[Token(Token = "0x40097FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int avatarLevelto;
		}

		// Token: 0x02001A01 RID: 6657
		[Token(Token = "0x2001A01")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F766C", Offset = "0x10F766C")]
		private sealed class <>c__DisplayClass117_0
		{
			// Token: 0x06008A8C RID: 35468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008A8C")]
			[Address(RVA = "0x143DCF4", Offset = "0x143DCF4", VA = "0x7BBBC3DCF4")]
			public <>c__DisplayClass117_0()
			{
			}

			// Token: 0x06008A8D RID: 35469 RVA: 0x00025278 File Offset: 0x00023478
			[Token(Token = "0x6008A8D")]
			[Address(RVA = "0x143DCFC", Offset = "0x143DCFC", VA = "0x7BBBC3DCFC")]
			internal bool <TrySelectBundle>b__0(InventoryItemInfo x)
			{
				return default(bool);
			}

			// Token: 0x040097FF RID: 38911
			[Token(Token = "0x40097FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint itemID;
		}

		// Token: 0x02001A02 RID: 6658
		[Token(Token = "0x2001A02")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F767C", Offset = "0x10F767C")]
		private sealed class <>c__DisplayClass156_0
		{
			// Token: 0x06008A8E RID: 35470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008A8E")]
			[Address(RVA = "0x143DD38", Offset = "0x143DD38", VA = "0x7BBBC3DD38")]
			public <>c__DisplayClass156_0()
			{
			}

			// Token: 0x06008A8F RID: 35471 RVA: 0x00025290 File Offset: 0x00023490
			[Token(Token = "0x6008A8F")]
			[Address(RVA = "0x143DD40", Offset = "0x143DD40", VA = "0x7BBBC3DD40")]
			internal bool <SetSubTabInfo>b__0(InventoryItemInfo a)
			{
				return default(bool);
			}

			// Token: 0x04009800 RID: 38912
			[Token(Token = "0x4009800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UILobbyInventoryNewController.EpicClothesData info;
		}
	}
}
