using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001528 RID: 5416
	[Token(Token = "0x2001528")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE26C", Offset = "0x10EE26C")]
	public class UIWeaponItemController : UIBaseController, UITable2.IUITable2Item
	{
		// Token: 0x06005D36 RID: 23862 RVA: 0x0001B150 File Offset: 0x00019350
		[Token(Token = "0x6005D36")]
		[Address(RVA = "0x1686ACC", Offset = "0x1686ACC", VA = "0x7BBBE86ACC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005D37 RID: 23863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D37")]
		[Address(RVA = "0x1686B1C", Offset = "0x1686B1C", VA = "0x7BBBE86B1C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005D38 RID: 23864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D38")]
		[Address(RVA = "0x1686FA4", Offset = "0x1686FA4", VA = "0x7BBBE86FA4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005D39 RID: 23865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D39")]
		[Address(RVA = "0x1687070", Offset = "0x1687070", VA = "0x7BBBE87070")]
		private void OnItemBtnClick()
		{
		}

		// Token: 0x06005D3A RID: 23866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D3A")]
		[Address(RVA = "0x168724C", Offset = "0x168724C", VA = "0x7BBBE8724C")]
		public void SelectItem(bool select)
		{
		}

		// Token: 0x06005D3B RID: 23867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D3B")]
		[Address(RVA = "0x1687290", Offset = "0x1687290", VA = "0x7BBBE87290")]
		private void EffectSelect(bool select)
		{
		}

		// Token: 0x06005D3C RID: 23868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D3C")]
		[Address(RVA = "0x16872D8", Offset = "0x16872D8", VA = "0x7BBBE872D8")]
		public void HighLightCurrent()
		{
		}

		// Token: 0x06005D3D RID: 23869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D3D")]
		[Address(RVA = "0x1687568", Offset = "0x1687568", VA = "0x7BBBE87568", Slot = "28")]
		public object SetTable2ItemData(int index, object data, object viewState)
		{
			return null;
		}

		// Token: 0x06005D3E RID: 23870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D3E")]
		[Address(RVA = "0x1688740", Offset = "0x1688740", VA = "0x7BBBE88740")]
		private void OnItemUpdate(object[] param)
		{
		}

		// Token: 0x06005D3F RID: 23871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D3F")]
		[Address(RVA = "0x1688544", Offset = "0x1688544", VA = "0x7BBBE88544")]
		private void SetRankingItemIcon()
		{
		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D40")]
		[Address(RVA = "0x1688744", Offset = "0x1688744", VA = "0x7BBBE88744", Slot = "29")]
		public void SetPosition(Vector2 position)
		{
		}

		// Token: 0x06005D41 RID: 23873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D41")]
		[Address(RVA = "0x168880C", Offset = "0x168880C", VA = "0x7BBBE8880C", Slot = "30")]
		public void SetTable2Visible(bool visible)
		{
		}

		// Token: 0x06005D42 RID: 23874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D42")]
		[Address(RVA = "0x1688848", Offset = "0x1688848", VA = "0x7BBBE88848")]
		public UIWeaponItemController()
		{
		}

		// Token: 0x04007EE8 RID: 32488
		[Token(Token = "0x4007EE8")]
		[FieldOffset(Offset = "0x58")]
		private int m_tableIndex;

		// Token: 0x04007EE9 RID: 32489
		[Token(Token = "0x4007EE9")]
		[FieldOffset(Offset = "0x60")]
		private UIWeaponItemView m_View;

		// Token: 0x04007EEA RID: 32490
		[Token(Token = "0x4007EEA")]
		[FieldOffset(Offset = "0x68")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x04007EEB RID: 32491
		[Token(Token = "0x4007EEB")]
		[FieldOffset(Offset = "0x70")]
		private CollectionBaseInfo m_CollectionInfo;

		// Token: 0x04007EEC RID: 32492
		[Token(Token = "0x4007EEC")]
		[FieldOffset(Offset = "0x78")]
		private uint m_ItemID;

		// Token: 0x04007EED RID: 32493
		[Token(Token = "0x4007EED")]
		[FieldOffset(Offset = "0x80")]
		private object m_Data;

		// Token: 0x04007EEE RID: 32494
		[Token(Token = "0x4007EEE")]
		[FieldOffset(Offset = "0x88")]
		private bool m_CollectionABReady;

		// Token: 0x04007EEF RID: 32495
		[Token(Token = "0x4007EEF")]
		[FieldOffset(Offset = "0x90")]
		private int[] m_DefaultWeaponSize;

		// Token: 0x04007EF0 RID: 32496
		[Token(Token = "0x4007EF0")]
		[FieldOffset(Offset = "0x98")]
		private int[] m_DefaultVehicleSize;

		// Token: 0x04007EF1 RID: 32497
		[Token(Token = "0x4007EF1")]
		[FieldOffset(Offset = "0xA0")]
		public Action<int> OnSelectCallback;

		// Token: 0x04007EF2 RID: 32498
		[Token(Token = "0x4007EF2")]
		[FieldOffset(Offset = "0xA8")]
		private UIWeaponItemController.ViewState m_ViewState;

		// Token: 0x04007EF3 RID: 32499
		[Token(Token = "0x4007EF3")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_ItemIconGrey;

		// Token: 0x02001529 RID: 5417
		[Token(Token = "0x2001529")]
		public class ViewState
		{
			// Token: 0x06005D43 RID: 23875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D43")]
			[Address(RVA = "0x168853C", Offset = "0x168853C", VA = "0x7BBBE8853C")]
			public ViewState()
			{
			}

			// Token: 0x04007EF4 RID: 32500
			[Token(Token = "0x4007EF4")]
			[FieldOffset(Offset = "0x10")]
			public bool m_Selected;
		}
	}
}
