using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001566 RID: 5478
	[Token(Token = "0x2001566")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE7AC", Offset = "0x10EE7AC")]
	public class UIExchangeMallPopWndController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06005F25 RID: 24357 RVA: 0x0001B888 File Offset: 0x00019A88
		[Token(Token = "0x6005F25")]
		[Address(RVA = "0x2270A50", Offset = "0x2270A50", VA = "0x7BBCA70A50")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005F26 RID: 24358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F26")]
		[Address(RVA = "0x2270AA0", Offset = "0x2270AA0", VA = "0x7BBCA70AA0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005F27 RID: 24359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F27")]
		[Address(RVA = "0x2270CFC", Offset = "0x2270CFC", VA = "0x7BBCA70CFC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005F28 RID: 24360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F28")]
		[Address(RVA = "0x2270E30", Offset = "0x2270E30", VA = "0x7BBCA70E30")]
		public void SetViewData(uint currencyId, string titleKey)
		{
		}

		// Token: 0x06005F29 RID: 24361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F29")]
		[Address(RVA = "0x2270FE4", Offset = "0x2270FE4", VA = "0x7BBCA70FE4")]
		private void RefreshViewData(bool needResort = true)
		{
		}

		// Token: 0x06005F2A RID: 24362 RVA: 0x0001B8A0 File Offset: 0x00019AA0
		[Token(Token = "0x6005F2A")]
		[Address(RVA = "0x22712D0", Offset = "0x22712D0", VA = "0x7BBCA712D0", Slot = "43")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005F2B RID: 24363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2B")]
		[Address(RVA = "0x2271314", Offset = "0x2271314", VA = "0x7BBCA71314", Slot = "42")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005F2C RID: 24364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2C")]
		[Address(RVA = "0x22713A8", Offset = "0x22713A8", VA = "0x7BBCA713A8")]
		private void OnRewardWndClose(params object[] data)
		{
		}

		// Token: 0x06005F2D RID: 24365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2D")]
		[Address(RVA = "0x22710E0", Offset = "0x22710E0", VA = "0x7BBCA710E0")]
		private void RefreshExchangeNum()
		{
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2E")]
		[Address(RVA = "0x22715BC", Offset = "0x22715BC", VA = "0x7BBCA715BC")]
		private void OnExchangeItemSelect(params object[] data)
		{
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2F")]
		[Address(RVA = "0x227164C", Offset = "0x227164C", VA = "0x7BBCA7164C")]
		private void RefreshItemView(uint commodityID)
		{
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F30")]
		[Address(RVA = "0x2271960", Offset = "0x2271960", VA = "0x7BBCA71960")]
		private void SetMoneyBtnData(ExchangeStoreItemDesc exchangeItemDesc)
		{
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F31")]
		[Address(RVA = "0x2271BA4", Offset = "0x2271BA4", VA = "0x7BBCA71BA4")]
		private void MoneyBtnColorGrey()
		{
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F32")]
		[Address(RVA = "0x2271CE0", Offset = "0x2271CE0", VA = "0x7BBCA71CE0")]
		private void MoneyBtnColorReset()
		{
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F33")]
		[Address(RVA = "0x2271E04", Offset = "0x2271E04", VA = "0x7BBCA71E04")]
		private void OnBtnExchangeClick()
		{
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F34")]
		[Address(RVA = "0x22722D8", Offset = "0x22722D8", VA = "0x7BBCA722D8", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005F35 RID: 24373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F35")]
		[Address(RVA = "0x227236C", Offset = "0x227236C", VA = "0x7BBCA7236C", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005F36 RID: 24374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F36")]
		[Address(RVA = "0x227239C", Offset = "0x227239C", VA = "0x7BBCA7239C")]
		public UIExchangeMallPopWndController()
		{
		}

		// Token: 0x06005F37 RID: 24375 RVA: 0x0001B8B8 File Offset: 0x00019AB8
		[Token(Token = "0x6005F37")]
		[Address(RVA = "0x22723A4", Offset = "0x22723A4", VA = "0x7BBCA723A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FC30", Offset = "0x113FC30")]
		private bool <OnRewardWndClose>b__15_0(ExchangeStoreItemDesc x)
		{
			return default(bool);
		}

		// Token: 0x04007FE4 RID: 32740
		[Token(Token = "0x4007FE4")]
		[FieldOffset(Offset = "0x98")]
		private UIExchangeMallPopWndView m_View;

		// Token: 0x04007FE5 RID: 32741
		[Token(Token = "0x4007FE5")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelMall m_ModelMall;

		// Token: 0x04007FE6 RID: 32742
		[Token(Token = "0x4007FE6")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_CurrencyId;

		// Token: 0x04007FE7 RID: 32743
		[Token(Token = "0x4007FE7")]
		[FieldOffset(Offset = "0xAC")]
		private uint m_CommodityId;

		// Token: 0x04007FE8 RID: 32744
		[Token(Token = "0x4007FE8")]
		private const uint CURRENCY_BTN_GREY = 2139062271U;

		// Token: 0x04007FE9 RID: 32745
		[Token(Token = "0x4007FE9")]
		private const uint CURRENCY_LABEL_GREY = 2139062271U;

		// Token: 0x04007FEA RID: 32746
		[Token(Token = "0x4007FEA")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_ExchangePurchaseSuccess;

		// Token: 0x04007FEB RID: 32747
		[Token(Token = "0x4007FEB")]
		[FieldOffset(Offset = "0xB8")]
		private List<ExchangeStoreItemDesc> m_CurrentDataList;
	}
}
