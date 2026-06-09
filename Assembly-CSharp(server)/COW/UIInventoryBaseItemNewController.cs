using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020019B9 RID: 6585
	[Token(Token = "0x20019B9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6EBC", Offset = "0x10F6EBC")]
	internal class UIInventoryBaseItemNewController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06008719 RID: 34585 RVA: 0x00024870 File Offset: 0x00022A70
		[Token(Token = "0x6008719")]
		[Address(RVA = "0x1913A5C", Offset = "0x1913A5C", VA = "0x7BBC113A5C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600871A RID: 34586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600871A")]
		[Address(RVA = "0x1913AAC", Offset = "0x1913AAC", VA = "0x7BBC113AAC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600871B RID: 34587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600871B")]
		[Address(RVA = "0x1913D7C", Offset = "0x1913D7C", VA = "0x7BBC113D7C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x00024888 File Offset: 0x00022A88
		[Token(Token = "0x600871C")]
		[Address(RVA = "0x1913EB4", Offset = "0x1913EB4", VA = "0x7BBC113EB4")]
		private bool IsDataClothShowingInfo(out InventoryClothShowingInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600871D RID: 34589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600871D")]
		[Address(RVA = "0x1913FC0", Offset = "0x1913FC0", VA = "0x7BBC113FC0")]
		private void RefreshUI(params object[] data)
		{
		}

		// Token: 0x0600871E RID: 34590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600871E")]
		[Address(RVA = "0x191402C", Offset = "0x191402C", VA = "0x7BBC11402C")]
		public void SetUIData(object data)
		{
		}

		// Token: 0x0600871F RID: 34591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600871F")]
		[Address(RVA = "0x1914C44", Offset = "0x1914C44", VA = "0x7BBC114C44")]
		private void HideIconAndBG()
		{
		}

		// Token: 0x06008720 RID: 34592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008720")]
		[Address(RVA = "0x19148CC", Offset = "0x19148CC", VA = "0x7BBC1148CC")]
		private void CheckClothIsInvalid(InventoryClothInfo data)
		{
		}

		// Token: 0x06008721 RID: 34593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008721")]
		[Address(RVA = "0x19149BC", Offset = "0x19149BC", VA = "0x7BBC1149BC")]
		private void SetRankingItemIcon()
		{
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008722")]
		[Address(RVA = "0x191475C", Offset = "0x191475C", VA = "0x7BBC11475C")]
		private void ClearContent()
		{
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008723")]
		[Address(RVA = "0x1914C78", Offset = "0x1914C78", VA = "0x7BBC114C78", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008724 RID: 34596 RVA: 0x000248A0 File Offset: 0x00022AA0
		[Token(Token = "0x6008724")]
		[Address(RVA = "0x1915228", Offset = "0x1915228", VA = "0x7BBC115228", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008725 RID: 34597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008725")]
		[Address(RVA = "0x1914CF0", Offset = "0x1914CF0", VA = "0x7BBC114CF0")]
		private void RefreshItemCount()
		{
		}

		// Token: 0x06008726 RID: 34598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008726")]
		[Address(RVA = "0x191526C", Offset = "0x191526C", VA = "0x7BBC11526C", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06008727 RID: 34599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008727")]
		[Address(RVA = "0x19162DC", Offset = "0x19162DC", VA = "0x7BBC1162DC")]
		private void ClickDefaultHairStyle()
		{
		}

		// Token: 0x06008728 RID: 34600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008728")]
		[Address(RVA = "0x1916104", Offset = "0x1916104", VA = "0x7BBC116104")]
		private void UpdatePreviewAvatarCloth()
		{
		}

		// Token: 0x06008729 RID: 34601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008729")]
		[Address(RVA = "0x1915FE4", Offset = "0x1915FE4", VA = "0x7BBC115FE4")]
		private void UpdatePreviewClothItem()
		{
		}

		// Token: 0x0600872A RID: 34602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600872A")]
		[Address(RVA = "0x191622C", Offset = "0x191622C", VA = "0x7BBC11622C")]
		private void UpdateLocalAvatarCloth()
		{
		}

		// Token: 0x0600872B RID: 34603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600872B")]
		[Address(RVA = "0x19163E0", Offset = "0x19163E0", VA = "0x7BBC1163E0", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x0600872C RID: 34604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600872C")]
		[Address(RVA = "0x1916420", Offset = "0x1916420", VA = "0x7BBC116420", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600872D RID: 34605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600872D")]
		[Address(RVA = "0x1915D38", Offset = "0x1915D38", VA = "0x7BBC115D38")]
		private void ShowNotReachRankUseLevelTips(int rank)
		{
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600872E")]
		[Address(RVA = "0x19146C0", Offset = "0x19146C0", VA = "0x7BBC1146C0")]
		private void InitShowBoostAvatarParams()
		{
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600872F")]
		[Address(RVA = "0x1916430", Offset = "0x1916430", VA = "0x7BBC116430")]
		public UIInventoryBaseItemNewController()
		{
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x000248B8 File Offset: 0x00022AB8
		[Token(Token = "0x6008730")]
		[Address(RVA = "0x1916440", Offset = "0x1916440", VA = "0x7BBC116440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11435DC", Offset = "0x11435DC")]
		private bool <SetUIData>b__21_0(InventoryItemInfo a)
		{
			return default(bool);
		}

		// Token: 0x040095D3 RID: 38355
		[Token(Token = "0x40095D3")]
		[FieldOffset(Offset = "0x70")]
		private UIInventoryBaseItemNewView m_View;

		// Token: 0x040095D4 RID: 38356
		[Token(Token = "0x40095D4")]
		[FieldOffset(Offset = "0x78")]
		private UIStandardItemMAXBController ctrl;

		// Token: 0x040095D5 RID: 38357
		[Token(Token = "0x40095D5")]
		[FieldOffset(Offset = "0x80")]
		public int m_ItemIndex;

		// Token: 0x040095D6 RID: 38358
		[Token(Token = "0x40095D6")]
		[FieldOffset(Offset = "0x88")]
		public Item m_ItemInfo;

		// Token: 0x040095D7 RID: 38359
		[Token(Token = "0x40095D7")]
		[FieldOffset(Offset = "0x90")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x040095D8 RID: 38360
		[Token(Token = "0x40095D8")]
		[FieldOffset(Offset = "0x98")]
		private CSSharedItemData m_ItemData;

		// Token: 0x040095D9 RID: 38361
		[Token(Token = "0x40095D9")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelAvatar m_ModelAvatar;

		// Token: 0x040095DA RID: 38362
		[Token(Token = "0x40095DA")]
		[FieldOffset(Offset = "0xA8")]
		private object m_Data;

		// Token: 0x040095DB RID: 38363
		[Token(Token = "0x40095DB")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_IsItemABReady;

		// Token: 0x040095DC RID: 38364
		[Token(Token = "0x40095DC")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_IsLockItem;

		// Token: 0x040095DD RID: 38365
		[Token(Token = "0x40095DD")]
		[FieldOffset(Offset = "0xB2")]
		private bool m_IsInvalid;

		// Token: 0x040095DE RID: 38366
		[Token(Token = "0x40095DE")]
		[FieldOffset(Offset = "0xB3")]
		private bool m_IsInvalidForAvatar;

		// Token: 0x040095DF RID: 38367
		[Token(Token = "0x40095DF")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_SkipClothesForAvatar;

		// Token: 0x040095E0 RID: 38368
		[Token(Token = "0x40095E0")]
		[FieldOffset(Offset = "0xB8")]
		private uint m_UseRankLevel;

		// Token: 0x040095E1 RID: 38369
		[Token(Token = "0x40095E1")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_IsReachUseRankLevel;

		// Token: 0x040095E2 RID: 38370
		[Token(Token = "0x40095E2")]
		[FieldOffset(Offset = "0xC0")]
		private ShowBoostAvatarParams m_ShowBoostAvatarParams;
	}
}
