using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AFB RID: 6907
	[Token(Token = "0x2001AFB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F90D4", Offset = "0x10F90D4")]
	public class UIPetSkinItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x060092C4 RID: 37572 RVA: 0x000270F0 File Offset: 0x000252F0
		[Token(Token = "0x60092C4")]
		[Address(RVA = "0x20E46A0", Offset = "0x20E46A0", VA = "0x7BBC8E46A0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060092C5 RID: 37573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092C5")]
		[Address(RVA = "0x20E46F0", Offset = "0x20E46F0", VA = "0x7BBC8E46F0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060092C6 RID: 37574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092C6")]
		[Address(RVA = "0x20E4908", Offset = "0x20E4908", VA = "0x7BBC8E4908", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060092C7 RID: 37575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092C7")]
		[Address(RVA = "0x20E49BC", Offset = "0x20E49BC", VA = "0x7BBC8E49BC", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060092C8 RID: 37576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092C8")]
		[Address(RVA = "0x20E4D3C", Offset = "0x20E4D3C", VA = "0x7BBC8E4D3C")]
		private void SelectSkin()
		{
		}

		// Token: 0x060092C9 RID: 37577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092C9")]
		[Address(RVA = "0x20E4E40", Offset = "0x20E4E40", VA = "0x7BBC8E4E40", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x060092CA RID: 37578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092CA")]
		[Address(RVA = "0x20E5278", Offset = "0x20E5278", VA = "0x7BBC8E5278", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x060092CB RID: 37579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092CB")]
		[Address(RVA = "0x20E4C84", Offset = "0x20E4C84", VA = "0x7BBC8E4C84")]
		public void SetHighLightBGState(bool show)
		{
		}

		// Token: 0x060092CC RID: 37580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092CC")]
		[Address(RVA = "0x20E52A4", Offset = "0x20E52A4", VA = "0x7BBC8E52A4", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060092CD RID: 37581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092CD")]
		[Address(RVA = "0x20E546C", Offset = "0x20E546C", VA = "0x7BBC8E546C")]
		public void RefreshData()
		{
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x00027108 File Offset: 0x00025308
		[Token(Token = "0x60092CE")]
		[Address(RVA = "0x20E5A08", Offset = "0x20E5A08", VA = "0x7BBC8E5A08", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092CF")]
		[Address(RVA = "0x20E5A4C", Offset = "0x20E5A4C", VA = "0x7BBC8E5A4C")]
		public UIPetSkinItemController()
		{
		}

		// Token: 0x04009D14 RID: 40212
		[Token(Token = "0x4009D14")]
		[FieldOffset(Offset = "0x70")]
		private UIPetSkinItemView m_View;

		// Token: 0x04009D15 RID: 40213
		[Token(Token = "0x4009D15")]
		[FieldOffset(Offset = "0x78")]
		private PetSkinData skin_info;

		// Token: 0x04009D16 RID: 40214
		[Token(Token = "0x4009D16")]
		[FieldOffset(Offset = "0x80")]
		private CSSharedItemData inventoryItem;

		// Token: 0x04009D17 RID: 40215
		[Token(Token = "0x4009D17")]
		[FieldOffset(Offset = "0x88")]
		private UIStandardItemMAXBController m_UIStandardItemMAXBController;

		// Token: 0x04009D18 RID: 40216
		[Token(Token = "0x4009D18")]
		[FieldOffset(Offset = "0x90")]
		private bool m_IsSelected;
	}
}
