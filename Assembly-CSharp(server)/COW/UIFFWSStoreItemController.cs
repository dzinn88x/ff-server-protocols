using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001369 RID: 4969
	[Token(Token = "0x2001369")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB438", Offset = "0x10EB438")]
	public class UIFFWSStoreItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06004F78 RID: 20344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F78")]
		[Address(RVA = "0x22875FC", Offset = "0x22875FC", VA = "0x7BBCA875FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F79")]
		[Address(RVA = "0x228788C", Offset = "0x228788C", VA = "0x7BBCA8788C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x00018318 File Offset: 0x00016518
		[Token(Token = "0x6004F7A")]
		[Address(RVA = "0x2287940", Offset = "0x2287940", VA = "0x7BBCA87940")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F7B")]
		[Address(RVA = "0x2287990", Offset = "0x2287990", VA = "0x7BBCA87990", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F7C")]
		[Address(RVA = "0x2285810", Offset = "0x2285810", VA = "0x7BBCA85810")]
		public void SetItemTab(bool isAwakenTab)
		{
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F7D")]
		[Address(RVA = "0x2287C48", Offset = "0x2287C48", VA = "0x7BBCA87C48", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x00018330 File Offset: 0x00016530
		[Token(Token = "0x6004F7E")]
		[Address(RVA = "0x2287E10", Offset = "0x2287E10", VA = "0x7BBCA87E10", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F7F")]
		[Address(RVA = "0x2287E54", Offset = "0x2287E54", VA = "0x7BBCA87E54")]
		private void OnPreviewBtnClick()
		{
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F80")]
		[Address(RVA = "0x2287F8C", Offset = "0x2287F8C", VA = "0x7BBCA87F8C")]
		private void OnPurchaseBtnClick()
		{
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F81")]
		[Address(RVA = "0x2287A68", Offset = "0x2287A68", VA = "0x7BBCA87A68")]
		private void RefreshView()
		{
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F82")]
		[Address(RVA = "0x2288278", Offset = "0x2288278", VA = "0x7BBCA88278")]
		private void RefreshItemState()
		{
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F83")]
		[Address(RVA = "0x2287CC0", Offset = "0x2287CC0", VA = "0x7BBCA87CC0")]
		private void RefreshStandardItemData()
		{
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F84")]
		[Address(RVA = "0x2288338", Offset = "0x2288338", VA = "0x7BBCA88338")]
		private void RefreshLimitedPurchase()
		{
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F85")]
		[Address(RVA = "0x2288604", Offset = "0x2288604", VA = "0x7BBCA88604")]
		private void RefreshPurchaseBtnState()
		{
		}

		// Token: 0x06004F86 RID: 20358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F86")]
		[Address(RVA = "0x2288900", Offset = "0x2288900", VA = "0x7BBCA88900")]
		private void RefreshPreviewBtnState()
		{
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F87")]
		[Address(RVA = "0x2288980", Offset = "0x2288980", VA = "0x7BBCA88980")]
		private void RefreshCurrencyIcon()
		{
		}

		// Token: 0x06004F88 RID: 20360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F88")]
		[Address(RVA = "0x2288A90", Offset = "0x2288A90", VA = "0x7BBCA88A90")]
		public UIFFWSStoreItemController()
		{
		}

		// Token: 0x04007634 RID: 30260
		[Token(Token = "0x4007634")]
		private const uint UNLOCKCOLOR = 2139062271U;

		// Token: 0x04007635 RID: 30261
		[Token(Token = "0x4007635")]
		[FieldOffset(Offset = "0x70")]
		private bool m_IsAwakenTab;

		// Token: 0x04007636 RID: 30262
		[Token(Token = "0x4007636")]
		[FieldOffset(Offset = "0x74")]
		private UIFFWSStoreItemController.EItemState m_ItemState;

		// Token: 0x04007637 RID: 30263
		[Token(Token = "0x4007637")]
		[FieldOffset(Offset = "0x78")]
		private BigEventStoreCommodityDesc m_Data;

		// Token: 0x04007638 RID: 30264
		[Token(Token = "0x4007638")]
		[FieldOffset(Offset = "0x80")]
		private UIFFWSStoreItemView m_View;

		// Token: 0x04007639 RID: 30265
		[Token(Token = "0x4007639")]
		[FieldOffset(Offset = "0x88")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x0400763A RID: 30266
		[Token(Token = "0x400763A")]
		[FieldOffset(Offset = "0x90")]
		private UIModelFFWS m_ModelFFWS;

		// Token: 0x0400763B RID: 30267
		[Token(Token = "0x400763B")]
		[FieldOffset(Offset = "0x98")]
		private UIStandardItemMiniController m_Ctrl;

		// Token: 0x0400763C RID: 30268
		[Token(Token = "0x400763C")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_IsUniquedAndOwned;

		// Token: 0x0400763D RID: 30269
		[Token(Token = "0x400763D")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_SellOut;

		// Token: 0x0200136A RID: 4970
		[Token(Token = "0x200136A")]
		private enum EItemState
		{
			// Token: 0x0400763F RID: 30271
			[Token(Token = "0x400763F")]
			NotEnoughToken,
			// Token: 0x04007640 RID: 30272
			[Token(Token = "0x4007640")]
			CanPurchase,
			// Token: 0x04007641 RID: 30273
			[Token(Token = "0x4007641")]
			PreviewOnly
		}
	}
}
