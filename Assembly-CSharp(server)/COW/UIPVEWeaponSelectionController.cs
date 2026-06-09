using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001638 RID: 5688
	[Token(Token = "0x2001638")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFE34", Offset = "0x10EFE34")]
	public class UIPVEWeaponSelectionController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06006672 RID: 26226 RVA: 0x0001D3B8 File Offset: 0x0001B5B8
		[Token(Token = "0x6006672")]
		[Address(RVA = "0x16E97C0", Offset = "0x16E97C0", VA = "0x7BBBEE97C0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006673 RID: 26227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006673")]
		[Address(RVA = "0x16E9810", Offset = "0x16E9810", VA = "0x7BBBEE9810", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006674")]
		[Address(RVA = "0x16EA224", Offset = "0x16EA224", VA = "0x7BBBEEA224", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006675 RID: 26229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006675")]
		[Address(RVA = "0x16EA264", Offset = "0x16EA264", VA = "0x7BBBEEA264")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x06006676 RID: 26230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006676")]
		[Address(RVA = "0x16E9FA0", Offset = "0x16E9FA0", VA = "0x7BBBEE9FA0")]
		public void RefreshPrimaryWeapon(uint itemid)
		{
		}

		// Token: 0x06006677 RID: 26231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006677")]
		[Address(RVA = "0x16E7F6C", Offset = "0x16E7F6C", VA = "0x7BBBEE7F6C")]
		public void RefreshSelectedWeaponTypeByID(uint itemid)
		{
		}

		// Token: 0x06006678 RID: 26232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006678")]
		private void RefreshWeaponSkinList<DataType>(List<DataType> dataList, bool needResort = true)
		{
		}

		// Token: 0x06006679 RID: 26233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006679")]
		[Address(RVA = "0x16E9B14", Offset = "0x16E9B14", VA = "0x7BBBEE9B14")]
		private void SetTabsUIData()
		{
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600667A")]
		[Address(RVA = "0x16EA310", Offset = "0x16EA310", VA = "0x7BBBEEA310", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600667B")]
		[Address(RVA = "0x16EA3A4", Offset = "0x16EA3A4", VA = "0x7BBBEEA3A4", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600667C")]
		[Address(RVA = "0x16EA3D4", Offset = "0x16EA3D4", VA = "0x7BBBEEA3D4", Slot = "42")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x0001D3D0 File Offset: 0x0001B5D0
		[Token(Token = "0x600667D")]
		[Address(RVA = "0x16EA4D8", Offset = "0x16EA4D8", VA = "0x7BBBEEA4D8", Slot = "43")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600667E RID: 26238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600667E")]
		[Address(RVA = "0x16EA51C", Offset = "0x16EA51C", VA = "0x7BBBEEA51C")]
		public UIPVEWeaponSelectionController()
		{
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
		[Token(Token = "0x600667F")]
		[Address(RVA = "0x16EA524", Offset = "0x16EA524", VA = "0x7BBBEEA524")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114081C", Offset = "0x114081C")]
		private bool <RefreshSelectedWeaponTypeByID>b__12_0(WeaponSkinBaseInfo wpInfo)
		{
			return default(bool);
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x0001D400 File Offset: 0x0001B600
		[Token(Token = "0x6006680")]
		[Address(RVA = "0x16EA578", Offset = "0x16EA578", VA = "0x7BBBEEA578")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114082C", Offset = "0x114082C")]
		private int <SetTabsUIData>b__14_0(uint a, uint b)
		{
			return 0;
		}

		// Token: 0x04008435 RID: 33845
		[Token(Token = "0x4008435")]
		[FieldOffset(Offset = "0x98")]
		private UIPVEWeaponSelectionView m_View;

		// Token: 0x04008436 RID: 33846
		[Token(Token = "0x4008436")]
		[FieldOffset(Offset = "0xA0")]
		private UIPVEWeaponPropertyController m_SelectedWeaponProperty;

		// Token: 0x04008437 RID: 33847
		[Token(Token = "0x4008437")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x04008438 RID: 33848
		[Token(Token = "0x4008438")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelPVE m_ModelPVE;

		// Token: 0x04008439 RID: 33849
		[Token(Token = "0x4008439")]
		[FieldOffset(Offset = "0xB8")]
		private uint m_SelectedWeaponSkinId;

		// Token: 0x0400843A RID: 33850
		[Token(Token = "0x400843A")]
		[FieldOffset(Offset = "0xBC")]
		private uint m_SelectedWeaponId;

		// Token: 0x0400843B RID: 33851
		[Token(Token = "0x400843B")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelGroup m_ModelGroup;
	}
}
