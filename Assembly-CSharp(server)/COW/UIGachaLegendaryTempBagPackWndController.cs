using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017F8 RID: 6136
	[Token(Token = "0x20017F8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F32C4", Offset = "0x10F32C4")]
	public class UIGachaLegendaryTempBagPackWndController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06007723 RID: 30499 RVA: 0x00020F28 File Offset: 0x0001F128
		[Token(Token = "0x6007723")]
		[Address(RVA = "0x2059084", Offset = "0x2059084", VA = "0x7BBC859084")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007724")]
		[Address(RVA = "0x20590D4", Offset = "0x20590D4", VA = "0x7BBC8590D4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007725 RID: 30501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007725")]
		[Address(RVA = "0x205941C", Offset = "0x205941C", VA = "0x7BBC85941C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007726")]
		[Address(RVA = "0x205953C", Offset = "0x205953C", VA = "0x7BBC85953C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007727")]
		[Address(RVA = "0x205957C", Offset = "0x205957C", VA = "0x7BBC85957C", Slot = "28")]
		public override string Rule()
		{
			return null;
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007728")]
		[Address(RVA = "0x2059628", Offset = "0x2059628", VA = "0x7BBC859628")]
		public void SetViewData(uint GachaID, List<uint> itemsInTempBag)
		{
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007729")]
		[Address(RVA = "0x2059964", Offset = "0x2059964", VA = "0x7BBC859964")]
		public void SetNoItemInBagState()
		{
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600772A")]
		[Address(RVA = "0x2059D54", Offset = "0x2059D54", VA = "0x7BBC859D54")]
		public void ClearAllSelectToggle()
		{
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600772B")]
		[Address(RVA = "0x2057B5C", Offset = "0x2057B5C", VA = "0x7BBC857B5C")]
		public void OnToggleSelected()
		{
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600772C")]
		[Address(RVA = "0x2059F80", Offset = "0x2059F80", VA = "0x7BBC859F80")]
		private void OnQuickSelectItemBtnClick()
		{
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600772D")]
		[Address(RVA = "0x205A82C", Offset = "0x205A82C", VA = "0x7BBC85A82C")]
		private void OnRandomClick()
		{
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772E")]
		[Address(RVA = "0x205ACA8", Offset = "0x205ACA8", VA = "0x7BBC85ACA8")]
		private List<uint> AdjustStateList(List<uint> SelectedItems)
		{
			return null;
		}

		// Token: 0x0600772F RID: 30511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600772F")]
		[Address(RVA = "0x205ADEC", Offset = "0x205ADEC", VA = "0x7BBC85ADEC")]
		private void OnGainClick()
		{
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007730")]
		[Address(RVA = "0x2059ACC", Offset = "0x2059ACC", VA = "0x7BBC859ACC")]
		private void RefreshGridView(List<uint> dataList)
		{
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007731")]
		[Address(RVA = "0x205B268", Offset = "0x205B268", VA = "0x7BBC85B268", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007732 RID: 30514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007732")]
		[Address(RVA = "0x205B2FC", Offset = "0x205B2FC", VA = "0x7BBC85B2FC", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007733")]
		[Address(RVA = "0x205B32C", Offset = "0x205B32C", VA = "0x7BBC85B32C")]
		private void RefreshBagItems()
		{
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x00020F40 File Offset: 0x0001F140
		[Token(Token = "0x6007734")]
		[Address(RVA = "0x205B484", Offset = "0x205B484", VA = "0x7BBC85B484", Slot = "43")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007735")]
		[Address(RVA = "0x205B4E8", Offset = "0x205B4E8", VA = "0x7BBC85B4E8", Slot = "42")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007736 RID: 30518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007736")]
		[Address(RVA = "0x205B5CC", Offset = "0x205B5CC", VA = "0x7BBC85B5CC")]
		public UIGachaLegendaryTempBagPackWndController()
		{
		}

		// Token: 0x04008DA5 RID: 36261
		[Token(Token = "0x4008DA5")]
		[FieldOffset(Offset = "0x98")]
		private UIGachaLegendaryTempBagPackWndView m_View;

		// Token: 0x04008DA6 RID: 36262
		[Token(Token = "0x4008DA6")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_QuickSelect;

		// Token: 0x04008DA7 RID: 36263
		[Token(Token = "0x4008DA7")]
		[FieldOffset(Offset = "0xA4")]
		private int m_ItemToChangeNum;

		// Token: 0x04008DA8 RID: 36264
		[Token(Token = "0x4008DA8")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelGacha m_Model;

		// Token: 0x04008DA9 RID: 36265
		[Token(Token = "0x4008DA9")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_GachaID;

		// Token: 0x04008DAA RID: 36266
		[Token(Token = "0x4008DAA")]
		[FieldOffset(Offset = "0xB8")]
		private List<uint> m_CurrentItemsInTempBag;

		// Token: 0x04008DAB RID: 36267
		[Token(Token = "0x4008DAB")]
		[FieldOffset(Offset = "0xC0")]
		public List<UIGachaLegendaryTempBagPackItemState> m_States;
	}
}
