using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013AC RID: 5036
	[Token(Token = "0x20013AC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBA80", Offset = "0x10EBA80")]
	public class UIMVPStoreItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x060051E4 RID: 20964 RVA: 0x00018AB0 File Offset: 0x00016CB0
		[Token(Token = "0x60051E4")]
		[Address(RVA = "0x1CDB9AC", Offset = "0x1CDB9AC", VA = "0x7BBC4DB9AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E5")]
		[Address(RVA = "0x1CDB9FC", Offset = "0x1CDB9FC", VA = "0x7BBC4DB9FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060051E6 RID: 20966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E6")]
		[Address(RVA = "0x1CDBC08", Offset = "0x1CDBC08", VA = "0x7BBC4DBC08", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E7")]
		[Address(RVA = "0x1CDBCBC", Offset = "0x1CDBCBC", VA = "0x7BBC4DBCBC", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060051E8 RID: 20968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E8")]
		[Address(RVA = "0x1CDB21C", Offset = "0x1CDB21C", VA = "0x7BBC4DB21C")]
		public void SetDark(bool dark)
		{
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E9")]
		[Address(RVA = "0x1CDBD94", Offset = "0x1CDBD94", VA = "0x7BBC4DBD94")]
		private void RefreshView()
		{
		}

		// Token: 0x060051EA RID: 20970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051EA")]
		[Address(RVA = "0x1CDBFFC", Offset = "0x1CDBFFC", VA = "0x7BBC4DBFFC")]
		private void CreateItem()
		{
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051EB")]
		[Address(RVA = "0x1CDC854", Offset = "0x1CDC854", VA = "0x7BBC4DC854")]
		private void RefreshStandardItemData()
		{
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051EC")]
		[Address(RVA = "0x1CDC0FC", Offset = "0x1CDC0FC", VA = "0x7BBC4DC0FC")]
		private void RefreshLimitedPurchase()
		{
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051ED")]
		[Address(RVA = "0x1CDC3C8", Offset = "0x1CDC3C8", VA = "0x7BBC4DC3C8")]
		private void RefreshPurchaseBtnState()
		{
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051EE")]
		[Address(RVA = "0x1CDC6C4", Offset = "0x1CDC6C4", VA = "0x7BBC4DC6C4")]
		private void RefreshPreviewBtnState()
		{
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051EF")]
		[Address(RVA = "0x1CDBF74", Offset = "0x1CDBF74", VA = "0x7BBC4DBF74")]
		private void RefreshItemState()
		{
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F0")]
		[Address(RVA = "0x1CDC744", Offset = "0x1CDC744", VA = "0x7BBC4DC744")]
		private void RefreshCurrencyIcon()
		{
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F1")]
		[Address(RVA = "0x1CDC9A4", Offset = "0x1CDC9A4", VA = "0x7BBC4DC9A4")]
		private void OnPreviewBtnClick()
		{
		}

		// Token: 0x060051F2 RID: 20978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F2")]
		[Address(RVA = "0x1CDCADC", Offset = "0x1CDCADC", VA = "0x7BBC4DCADC")]
		private void OnPurchaseBtnClick()
		{
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x00018AC8 File Offset: 0x00016CC8
		[Token(Token = "0x60051F3")]
		[Address(RVA = "0x1CDCD28", Offset = "0x1CDCD28", VA = "0x7BBC4DCD28", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F4")]
		[Address(RVA = "0x1CDCD6C", Offset = "0x1CDCD6C", VA = "0x7BBC4DCD6C", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F5")]
		[Address(RVA = "0x1CDCDE4", Offset = "0x1CDCDE4", VA = "0x7BBC4DCDE4")]
		public UIMVPStoreItemController()
		{
		}

		// Token: 0x04007814 RID: 30740
		[Token(Token = "0x4007814")]
		[FieldOffset(Offset = "0x70")]
		private UIRampageStoreItemView m_View;

		// Token: 0x04007815 RID: 30741
		[Token(Token = "0x4007815")]
		[FieldOffset(Offset = "0x78")]
		private BigEventStoreCommodityDesc m_Data;

		// Token: 0x04007816 RID: 30742
		[Token(Token = "0x4007816")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsUniquedAndOwned;

		// Token: 0x04007817 RID: 30743
		[Token(Token = "0x4007817")]
		[FieldOffset(Offset = "0x81")]
		private bool m_SellOut;

		// Token: 0x04007818 RID: 30744
		[Token(Token = "0x4007818")]
		[FieldOffset(Offset = "0x88")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x04007819 RID: 30745
		[Token(Token = "0x4007819")]
		[FieldOffset(Offset = "0x90")]
		private UIModelMVP m_ModelMVP;

		// Token: 0x0400781A RID: 30746
		[Token(Token = "0x400781A")]
		[FieldOffset(Offset = "0x98")]
		private UIMVPStoreItemController.EItemState m_ItemState;

		// Token: 0x0400781B RID: 30747
		[Token(Token = "0x400781B")]
		[FieldOffset(Offset = "0xA0")]
		private UIStandardItemMiniController m_Ctrl;

		// Token: 0x0400781C RID: 30748
		[Token(Token = "0x400781C")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_ItemRank;

		// Token: 0x0400781D RID: 30749
		[Token(Token = "0x400781D")]
		private const uint UNLOCKCOLOR = 2139062271U;

		// Token: 0x020013AD RID: 5037
		[Token(Token = "0x20013AD")]
		private enum EItemState
		{
			// Token: 0x0400781F RID: 30751
			[Token(Token = "0x400781F")]
			NotEnoughToken,
			// Token: 0x04007820 RID: 30752
			[Token(Token = "0x4007820")]
			CanPurchase
		}
	}
}
