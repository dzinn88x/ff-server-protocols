using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020017B9 RID: 6073
	[Token(Token = "0x20017B9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F29AC", Offset = "0x10F29AC")]
	public class UIFastSendGiftController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06007432 RID: 29746 RVA: 0x00020400 File Offset: 0x0001E600
		[Token(Token = "0x6007432")]
		[Address(RVA = "0x1DB1DE8", Offset = "0x1DB1DE8", VA = "0x7BBC5B1DE8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007433")]
		[Address(RVA = "0x1DB1E38", Offset = "0x1DB1E38", VA = "0x7BBC5B1E38", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007434 RID: 29748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007434")]
		[Address(RVA = "0x1DB218C", Offset = "0x1DB218C", VA = "0x7BBC5B218C")]
		private void OnSendBtnClick()
		{
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007435")]
		[Address(RVA = "0x1DB26C0", Offset = "0x1DB26C0", VA = "0x7BBC5B26C0")]
		private void OnGiftItemSelected(params object[] data)
		{
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007436")]
		[Address(RVA = "0x1DB2940", Offset = "0x1DB2940", VA = "0x7BBC5B2940")]
		private void OnGiftFriendSelected(params object[] data)
		{
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007437")]
		[Address(RVA = "0x1DB2A4C", Offset = "0x1DB2A4C", VA = "0x7BBC5B2A4C")]
		private void RefreshFriendList(FriendInfo info, bool isSelected)
		{
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007438")]
		[Address(RVA = "0x1DB2B7C", Offset = "0x1DB2B7C", VA = "0x7BBC5B2B7C")]
		private void RefreshPrice()
		{
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007439")]
		[Address(RVA = "0x1DB275C", Offset = "0x1DB275C", VA = "0x7BBC5B275C")]
		private void RefreshItemView(uint commodityID)
		{
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600743A")]
		[Address(RVA = "0x1DB2CEC", Offset = "0x1DB2CEC", VA = "0x7BBC5B2CEC")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600743B")]
		[Address(RVA = "0x1DB2CF4", Offset = "0x1DB2CF4", VA = "0x7BBC5B2CF4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600743C")]
		[Address(RVA = "0x1DB2E74", Offset = "0x1DB2E74", VA = "0x7BBC5B2E74")]
		private void RefreshView()
		{
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600743D")]
		[Address(RVA = "0x1DB2EA0", Offset = "0x1DB2EA0", VA = "0x7BBC5B2EA0")]
		private void RefreshHotGiftItem()
		{
		}

		// Token: 0x0600743E RID: 29758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600743E")]
		[Address(RVA = "0x1DB30B0", Offset = "0x1DB30B0", VA = "0x7BBC5B30B0")]
		private void RefreshAllGiftItem()
		{
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600743F")]
		[Address(RVA = "0x1DB3484", Offset = "0x1DB3484", VA = "0x7BBC5B3484")]
		private void RefreshDataListView(List<GiftItem> dataList, bool isHotItem = false, bool needSort = true)
		{
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007440")]
		[Address(RVA = "0x1DB31F0", Offset = "0x1DB31F0", VA = "0x7BBC5B31F0")]
		private void RefreshTeamMateInfo()
		{
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x00020418 File Offset: 0x0001E618
		[Token(Token = "0x6007441")]
		[Address(RVA = "0x1DB3B9C", Offset = "0x1DB3B9C", VA = "0x7BBC5B3B9C", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007442 RID: 29762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007442")]
		[Address(RVA = "0x1DB3BE0", Offset = "0x1DB3BE0", VA = "0x7BBC5B3BE0", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007443")]
		[Address(RVA = "0x1DB3D70", Offset = "0x1DB3D70", VA = "0x7BBC5B3D70", Slot = "42")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007444")]
		[Address(RVA = "0x1DB3EE8", Offset = "0x1DB3EE8", VA = "0x7BBC5B3EE8", Slot = "43")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007445")]
		[Address(RVA = "0x1DB35E4", Offset = "0x1DB35E4", VA = "0x7BBC5B35E4")]
		private void CheckCondition(FriendInfo info)
		{
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007446")]
		[Address(RVA = "0x1DB3F18", Offset = "0x1DB3F18", VA = "0x7BBC5B3F18")]
		public void SetTeamMatesData(List<FriendInfo> teamMatesList)
		{
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007447")]
		[Address(RVA = "0x1DB3F50", Offset = "0x1DB3F50", VA = "0x7BBC5B3F50")]
		public void IsIngame(bool isInGame = false)
		{
		}

		// Token: 0x06007448 RID: 29768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007448")]
		[Address(RVA = "0x1DB3F5C", Offset = "0x1DB3F5C", VA = "0x7BBC5B3F5C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007449")]
		[Address(RVA = "0x1DB4024", Offset = "0x1DB4024", VA = "0x7BBC5B4024")]
		public UIFastSendGiftController()
		{
		}

		// Token: 0x04008C30 RID: 35888
		[Token(Token = "0x4008C30")]
		[FieldOffset(Offset = "0x98")]
		private UIFastSendGiftView m_View;

		// Token: 0x04008C31 RID: 35889
		[Token(Token = "0x4008C31")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelGift m_ModelGift;

		// Token: 0x04008C32 RID: 35890
		[Token(Token = "0x4008C32")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelUser m_ModelUser;

		// Token: 0x04008C33 RID: 35891
		[Token(Token = "0x4008C33")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_SelectedItemId;

		// Token: 0x04008C34 RID: 35892
		[Token(Token = "0x4008C34")]
		[FieldOffset(Offset = "0xB8")]
		private List<FriendInfo> m_ReceiversList;

		// Token: 0x04008C35 RID: 35893
		[Token(Token = "0x4008C35")]
		[FieldOffset(Offset = "0xC0")]
		private List<FriendInfo> m_TeamMatesList;

		// Token: 0x04008C36 RID: 35894
		[Token(Token = "0x4008C36")]
		[FieldOffset(Offset = "0xC8")]
		private uint m_CoinsPrice;

		// Token: 0x04008C37 RID: 35895
		[Token(Token = "0x4008C37")]
		[FieldOffset(Offset = "0xCC")]
		private uint m_GemsPrice;

		// Token: 0x04008C38 RID: 35896
		[Token(Token = "0x4008C38")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_HotItemClick;

		// Token: 0x04008C39 RID: 35897
		[Token(Token = "0x4008C39")]
		[FieldOffset(Offset = "0xD1")]
		private bool m_IsIngame;

		// Token: 0x020017BA RID: 6074
		[Token(Token = "0x20017BA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F29E4", Offset = "0x10F29E4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600744B RID: 29771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600744B")]
			[Address(RVA = "0x1DB4118", Offset = "0x1DB4118", VA = "0x7BBC5B4118")]
			public <>c()
			{
			}

			// Token: 0x0600744C RID: 29772 RVA: 0x00020430 File Offset: 0x0001E630
			[Token(Token = "0x600744C")]
			[Address(RVA = "0x1DB4120", Offset = "0x1DB4120", VA = "0x7BBC5B4120")]
			internal ulong <OnSendBtnClick>b__12_0(FriendInfo a)
			{
				return 0UL;
			}

			// Token: 0x0600744D RID: 29773 RVA: 0x00020448 File Offset: 0x0001E648
			[Token(Token = "0x600744D")]
			[Address(RVA = "0x1DB414C", Offset = "0x1DB414C", VA = "0x7BBC5B414C")]
			internal bool <RefreshHotGiftItem>b__21_0(GiftItem item)
			{
				return default(bool);
			}

			// Token: 0x04008C3A RID: 35898
			[Token(Token = "0x4008C3A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIFastSendGiftController.<>c <>9;

			// Token: 0x04008C3B RID: 35899
			[Token(Token = "0x4008C3B")]
			[FieldOffset(Offset = "0x8")]
			public static Func<FriendInfo, ulong> <>9__12_0;

			// Token: 0x04008C3C RID: 35900
			[Token(Token = "0x4008C3C")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<GiftItem> <>9__21_0;
		}
	}
}
