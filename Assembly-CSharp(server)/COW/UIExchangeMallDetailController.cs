using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001562 RID: 5474
	[Token(Token = "0x2001562")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE71C", Offset = "0x10EE71C")]
	public class UIExchangeMallDetailController : UIMallDetailBaseController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06005EEE RID: 24302 RVA: 0x0001B780 File Offset: 0x00019980
		[Token(Token = "0x6005EEE")]
		[Address(RVA = "0x1E7E6F4", Offset = "0x1E7E6F4", VA = "0x7BBC67E6F4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005EEF RID: 24303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EEF")]
		[Address(RVA = "0x1E7E744", Offset = "0x1E7E744", VA = "0x7BBC67E744", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005EF0 RID: 24304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF0")]
		[Address(RVA = "0x1E7EA14", Offset = "0x1E7EA14", VA = "0x7BBC67EA14", Slot = "28")]
		protected override void InitBuyBtnStyle()
		{
		}

		// Token: 0x06005EF1 RID: 24305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF1")]
		[Address(RVA = "0x1E7EB8C", Offset = "0x1E7EB8C", VA = "0x7BBC67EB8C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005EF2 RID: 24306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF2")]
		[Address(RVA = "0x1E7ED08", Offset = "0x1E7ED08", VA = "0x7BBC67ED08")]
		private void OnExchangeCurrencyBtnClick(params object[] data)
		{
		}

		// Token: 0x06005EF3 RID: 24307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF3")]
		[Address(RVA = "0x1E7EF24", Offset = "0x1E7EF24", VA = "0x7BBC67EF24")]
		private void OnExchangeBuyBtnClick()
		{
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF4")]
		[Address(RVA = "0x1E7EF28", Offset = "0x1E7EF28", VA = "0x7BBC67EF28")]
		private void ExchangeItem()
		{
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x0001B798 File Offset: 0x00019998
		[Token(Token = "0x6005EF5")]
		[Address(RVA = "0x1E7FBF8", Offset = "0x1E7FBF8", VA = "0x7BBC67FBF8", Slot = "32")]
		protected override bool CanFindStoreItem(uint storeID)
		{
			return default(bool);
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF6")]
		[Address(RVA = "0x1E7FA40", Offset = "0x1E7FA40", VA = "0x7BBC67FA40")]
		private void ShowExchangePurchasePopupWnd(ExchangeStoreItemDesc itemDesc)
		{
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x0001B7B0 File Offset: 0x000199B0
		[Token(Token = "0x6005EF7")]
		[Address(RVA = "0x1E7F790", Offset = "0x1E7F790", VA = "0x7BBC67F790")]
		private bool IsReachRankMallBuyCondition()
		{
			return default(bool);
		}

		// Token: 0x06005EF8 RID: 24312 RVA: 0x0001B7C8 File Offset: 0x000199C8
		[Token(Token = "0x6005EF8")]
		[Address(RVA = "0x1E7F464", Offset = "0x1E7F464", VA = "0x7BBC67F464")]
		private bool IsReachClanMallBuyCondition()
		{
			return default(bool);
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF9")]
		[Address(RVA = "0x1E7FDD4", Offset = "0x1E7FDD4", VA = "0x7BBC67FDD4", Slot = "29")]
		protected override void OnClothPreviewToggleClick()
		{
		}

		// Token: 0x06005EFA RID: 24314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EFA")]
		[Address(RVA = "0x1E802A0", Offset = "0x1E802A0", VA = "0x7BBC6802A0", Slot = "55")]
		public override void OnItemSelected(params object[] data)
		{
		}

		// Token: 0x06005EFB RID: 24315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EFB")]
		[Address(RVA = "0x1E80A30", Offset = "0x1E80A30", VA = "0x7BBC680A30", Slot = "30")]
		protected override void UnSelectItem(uint itemID)
		{
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EFC")]
		[Address(RVA = "0x1E80384", Offset = "0x1E80384", VA = "0x7BBC680384")]
		private void RefreshItemView(uint commodityID)
		{
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EFD")]
		[Address(RVA = "0x1E80C94", Offset = "0x1E80C94", VA = "0x7BBC680C94")]
		private void RefreshViewData(List<ExchangeStoreItemDesc> dataList, bool needResort = true)
		{
		}

		// Token: 0x06005EFE RID: 24318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EFE")]
		[Address(RVA = "0x1E80B60", Offset = "0x1E80B60", VA = "0x7BBC680B60")]
		public void CheckRankLevel(uint itemID)
		{
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x0001B7E0 File Offset: 0x000199E0
		[Token(Token = "0x6005EFF")]
		[Address(RVA = "0x1E7FC3C", Offset = "0x1E7FC3C", VA = "0x7BBC67FC3C")]
		private bool IsReachClanLevel(uint commodityID)
		{
			return default(bool);
		}

		// Token: 0x06005F00 RID: 24320 RVA: 0x0001B7F8 File Offset: 0x000199F8
		[Token(Token = "0x6005F00")]
		[Address(RVA = "0x1E80FC8", Offset = "0x1E80FC8", VA = "0x7BBC680FC8", Slot = "68")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F01")]
		[Address(RVA = "0x1E8102C", Offset = "0x1E8102C", VA = "0x7BBC68102C", Slot = "67")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005F02 RID: 24322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F02")]
		[Address(RVA = "0x1E81280", Offset = "0x1E81280", VA = "0x7BBC681280", Slot = "65")]
		protected override void OnCommonWndFinish(params object[] data)
		{
		}

		// Token: 0x06005F03 RID: 24323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F03")]
		[Address(RVA = "0x1E812E8", Offset = "0x1E812E8", VA = "0x7BBC6812E8", Slot = "33")]
		public override void HighlightCurrent()
		{
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F04")]
		[Address(RVA = "0x1E814A8", Offset = "0x1E814A8", VA = "0x7BBC6814A8", Slot = "57")]
		public override void InitMallView()
		{
		}

		// Token: 0x06005F05 RID: 24325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F05")]
		[Address(RVA = "0x1E81598", Offset = "0x1E81598", VA = "0x7BBC681598", Slot = "58")]
		public override void RefreshMallView()
		{
		}

		// Token: 0x06005F06 RID: 24326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F06")]
		[Address(RVA = "0x1E814FC", Offset = "0x1E814FC", VA = "0x7BBC6814FC")]
		private void UpdateTabs()
		{
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F07")]
		[Address(RVA = "0x1E815E0", Offset = "0x1E815E0", VA = "0x7BBC6815E0", Slot = "69")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F08")]
		[Address(RVA = "0x1E817BC", Offset = "0x1E817BC", VA = "0x7BBC6817BC", Slot = "70")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F09")]
		[Address(RVA = "0x1E8112C", Offset = "0x1E8112C", VA = "0x7BBC68112C")]
		private void RefreshExchangeNum()
		{
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0A")]
		[Address(RVA = "0x1E817EC", Offset = "0x1E817EC", VA = "0x7BBC6817EC", Slot = "60")]
		public override void NavigationToItem(uint mallTabType, uint mallSubType, uint storeID)
		{
		}

		// Token: 0x06005F0B RID: 24331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0B")]
		[Address(RVA = "0x1E81E04", Offset = "0x1E81E04", VA = "0x7BBC681E04")]
		private void OnExchangeTabSelected()
		{
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0C")]
		[Address(RVA = "0x1E82958", Offset = "0x1E82958", VA = "0x7BBC682958", Slot = "53")]
		protected override void ResetUIStateOnToggleSelected()
		{
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0D")]
		[Address(RVA = "0x1E82A50", Offset = "0x1E82A50", VA = "0x7BBC682A50", Slot = "31")]
		protected override void SetClothPreviewTabInfo(PreviewTabInfo tabInfo, CSSharedItemData itemData)
		{
		}

		// Token: 0x06005F0E RID: 24334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0E")]
		[Address(RVA = "0x1E82A58", Offset = "0x1E82A58", VA = "0x7BBC682A58", Slot = "36")]
		protected override void AddMallToggleClickEvent()
		{
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F0F")]
		[Address(RVA = "0x1E82C24", Offset = "0x1E82C24", VA = "0x7BBC682C24", Slot = "54")]
		protected override string GetMallTabName(uint type)
		{
			return null;
		}

		// Token: 0x06005F10 RID: 24336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F10")]
		[Address(RVA = "0x1E82D24", Offset = "0x1E82D24", VA = "0x7BBC682D24", Slot = "61")]
		public override void RefreshCurrentMallView(bool clickItem)
		{
		}

		// Token: 0x06005F11 RID: 24337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F11")]
		[Address(RVA = "0x1E82E18", Offset = "0x1E82E18", VA = "0x7BBC682E18", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005F12 RID: 24338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F12")]
		[Address(RVA = "0x1E82EE0", Offset = "0x1E82EE0", VA = "0x7BBC682EE0")]
		public void SetTopBtnGroupCtrl(UITopButtonGroupController uITopButtonGroupController)
		{
		}

		// Token: 0x06005F13 RID: 24339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F13")]
		[Address(RVA = "0x1E82EE8", Offset = "0x1E82EE8", VA = "0x7BBC682EE8")]
		public UIExchangeMallDetailController()
		{
		}

		// Token: 0x06005F14 RID: 24340 RVA: 0x0001B810 File Offset: 0x00019A10
		[Token(Token = "0x6005F14")]
		[Address(RVA = "0x1E82F78", Offset = "0x1E82F78", VA = "0x7BBC682F78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FC10", Offset = "0x113FC10")]
		private bool <HighlightCurrent>b__26_0(ExchangeStoreItemDesc item)
		{
			return default(bool);
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F15")]
		[Address(RVA = "0x1E82FB4", Offset = "0x1E82FB4", VA = "0x7BBC682FB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FC20", Offset = "0x113FC20")]
		private void <OnExchangeTabSelected>b__34_0()
		{
		}

		// Token: 0x04007FDC RID: 32732
		[Token(Token = "0x4007FDC")]
		[FieldOffset(Offset = "0x148")]
		private List<ExchangeStoreItemDesc> m_CurrentDataList;

		// Token: 0x04007FDD RID: 32733
		[Token(Token = "0x4007FDD")]
		[FieldOffset(Offset = "0x150")]
		private uint m_BuyRankLevel;

		// Token: 0x04007FDE RID: 32734
		[Token(Token = "0x4007FDE")]
		[FieldOffset(Offset = "0x154")]
		private bool m_ExchangePurchaseSuccess;

		// Token: 0x04007FDF RID: 32735
		[Token(Token = "0x4007FDF")]
		[FieldOffset(Offset = "0x158")]
		private UICommonGuideController m_GuideCtrl;

		// Token: 0x04007FE0 RID: 32736
		[Token(Token = "0x4007FE0")]
		[FieldOffset(Offset = "0x160")]
		private UITopButtonGroupController m_UITopButtonGroupController;

		// Token: 0x02001563 RID: 5475
		[Token(Token = "0x2001563")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE754", Offset = "0x10EE754")]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06005F16 RID: 24342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005F16")]
			[Address(RVA = "0x227010C", Offset = "0x227010C", VA = "0x7BBCA7010C")]
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x06005F17 RID: 24343 RVA: 0x0001B828 File Offset: 0x00019A28
			[Token(Token = "0x6005F17")]
			[Address(RVA = "0x2270114", Offset = "0x2270114", VA = "0x7BBCA70114")]
			internal bool <UnSelectItem>b__0(ExchangeStoreItemDesc item)
			{
				return default(bool);
			}

			// Token: 0x04007FE1 RID: 32737
			[Token(Token = "0x4007FE1")]
			[FieldOffset(Offset = "0x10")]
			public uint itemID;
		}

		// Token: 0x02001564 RID: 5476
		[Token(Token = "0x2001564")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE764", Offset = "0x10EE764")]
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x06005F18 RID: 24344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005F18")]
			[Address(RVA = "0x2270150", Offset = "0x2270150", VA = "0x7BBCA70150")]
			public <>c__DisplayClass33_0()
			{
			}

			// Token: 0x06005F19 RID: 24345 RVA: 0x0001B840 File Offset: 0x00019A40
			[Token(Token = "0x6005F19")]
			[Address(RVA = "0x2270158", Offset = "0x2270158", VA = "0x7BBCA70158")]
			internal bool <NavigationToItem>b__0(ExchangeStoreItemDesc item)
			{
				return default(bool);
			}

			// Token: 0x06005F1A RID: 24346 RVA: 0x0001B858 File Offset: 0x00019A58
			[Token(Token = "0x6005F1A")]
			[Address(RVA = "0x2270194", Offset = "0x2270194", VA = "0x7BBCA70194")]
			internal bool <NavigationToItem>b__1(ExchangeStoreItemDesc item)
			{
				return default(bool);
			}

			// Token: 0x04007FE2 RID: 32738
			[Token(Token = "0x4007FE2")]
			[FieldOffset(Offset = "0x10")]
			public uint storeID;
		}
	}
}
