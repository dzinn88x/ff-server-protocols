using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200163D RID: 5693
	[Token(Token = "0x200163D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFF14", Offset = "0x10EFF14")]
	public class UIRampageStoreItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x060066A9 RID: 26281 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
		[Token(Token = "0x60066A9")]
		[Address(RVA = "0x1E07774", Offset = "0x1E07774", VA = "0x7BBC607774")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066AA")]
		[Address(RVA = "0x1E077C4", Offset = "0x1E077C4", VA = "0x7BBC6077C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066AB")]
		[Address(RVA = "0x1E079A4", Offset = "0x1E079A4", VA = "0x7BBC6079A4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066AC")]
		[Address(RVA = "0x1E07A58", Offset = "0x1E07A58", VA = "0x7BBC607A58", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060066AD RID: 26285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066AD")]
		[Address(RVA = "0x1E07D10", Offset = "0x1E07D10", VA = "0x7BBC607D10")]
		public void SetItemRank(uint rank)
		{
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066AE")]
		[Address(RVA = "0x1E07D18", Offset = "0x1E07D18", VA = "0x7BBC607D18")]
		public void SetDark(bool dark)
		{
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066AF")]
		[Address(RVA = "0x1E07B30", Offset = "0x1E07B30", VA = "0x7BBC607B30")]
		private void RefreshView()
		{
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B0")]
		[Address(RVA = "0x1E07E30", Offset = "0x1E07E30", VA = "0x7BBC607E30")]
		private void CreateItem()
		{
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B1")]
		[Address(RVA = "0x1E08688", Offset = "0x1E08688", VA = "0x7BBC608688")]
		private void RefreshStandardItemData()
		{
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B2")]
		[Address(RVA = "0x1E07F30", Offset = "0x1E07F30", VA = "0x7BBC607F30")]
		private void RefreshLimitedPurchase()
		{
		}

		// Token: 0x060066B3 RID: 26291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B3")]
		[Address(RVA = "0x1E081FC", Offset = "0x1E081FC", VA = "0x7BBC6081FC")]
		private void RefreshPurchaseBtnState()
		{
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B4")]
		[Address(RVA = "0x1E084F8", Offset = "0x1E084F8", VA = "0x7BBC6084F8")]
		private void RefreshPreviewBtnState()
		{
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B5")]
		[Address(RVA = "0x1E07DE0", Offset = "0x1E07DE0", VA = "0x7BBC607DE0")]
		private void RefreshItemState()
		{
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B6")]
		[Address(RVA = "0x1E08578", Offset = "0x1E08578", VA = "0x7BBC608578")]
		private void RefreshCurrencyIcon()
		{
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B7")]
		[Address(RVA = "0x1E087D8", Offset = "0x1E087D8", VA = "0x7BBC6087D8")]
		private void OnPreviewBtnClick()
		{
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B8")]
		[Address(RVA = "0x1E08910", Offset = "0x1E08910", VA = "0x7BBC608910")]
		private void OnPurchaseBtnClick()
		{
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x0001D4C0 File Offset: 0x0001B6C0
		[Token(Token = "0x60066B9")]
		[Address(RVA = "0x1E08914", Offset = "0x1E08914", VA = "0x7BBC608914", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BA")]
		[Address(RVA = "0x1E08958", Offset = "0x1E08958", VA = "0x7BBC608958", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BB")]
		[Address(RVA = "0x1E089D0", Offset = "0x1E089D0", VA = "0x7BBC6089D0")]
		public UIRampageStoreItemController()
		{
		}

		// Token: 0x04008457 RID: 33879
		[Token(Token = "0x4008457")]
		[FieldOffset(Offset = "0x70")]
		private UIRampageStoreItemView m_View;

		// Token: 0x04008458 RID: 33880
		[Token(Token = "0x4008458")]
		[FieldOffset(Offset = "0x78")]
		private BigEventStoreCommodityDesc m_Data;

		// Token: 0x04008459 RID: 33881
		[Token(Token = "0x4008459")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsUniquedAndOwned;

		// Token: 0x0400845A RID: 33882
		[Token(Token = "0x400845A")]
		[FieldOffset(Offset = "0x81")]
		private bool m_SellOut;

		// Token: 0x0400845B RID: 33883
		[Token(Token = "0x400845B")]
		[FieldOffset(Offset = "0x88")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x0400845C RID: 33884
		[Token(Token = "0x400845C")]
		[FieldOffset(Offset = "0x90")]
		private UIRampageStoreItemController.EItemState m_ItemState;

		// Token: 0x0400845D RID: 33885
		[Token(Token = "0x400845D")]
		[FieldOffset(Offset = "0x98")]
		private UIStandardItemMiniController m_Ctrl;

		// Token: 0x0400845E RID: 33886
		[Token(Token = "0x400845E")]
		[FieldOffset(Offset = "0xA0")]
		private uint m_ItemRank;

		// Token: 0x0400845F RID: 33887
		[Token(Token = "0x400845F")]
		private const uint UNLOCKCOLOR = 2139062271U;

		// Token: 0x0200163E RID: 5694
		[Token(Token = "0x200163E")]
		private enum EItemState
		{
			// Token: 0x04008461 RID: 33889
			[Token(Token = "0x4008461")]
			UnLock,
			// Token: 0x04008462 RID: 33890
			[Token(Token = "0x4008462")]
			NotEnoughToken,
			// Token: 0x04008463 RID: 33891
			[Token(Token = "0x4008463")]
			CanPurchase
		}
	}
}
