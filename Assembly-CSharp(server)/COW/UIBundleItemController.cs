using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016EF RID: 5871
	[Token(Token = "0x20016EF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1114", Offset = "0x10F1114")]
	public class UIBundleItemController : UIEasyListItemController
	{
		// Token: 0x06006CE9 RID: 27881 RVA: 0x0001EB88 File Offset: 0x0001CD88
		[Token(Token = "0x6006CE9")]
		[Address(RVA = "0x1C1CFDC", Offset = "0x1C1CFDC", VA = "0x7BBC41CFDC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006CEA RID: 27882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CEA")]
		[Address(RVA = "0x1C1D02C", Offset = "0x1C1D02C", VA = "0x7BBC41D02C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CEB")]
		[Address(RVA = "0x1C1D1CC", Offset = "0x1C1D1CC", VA = "0x7BBC41D1CC")]
		public void SetRefreshPreviewState(bool flag)
		{
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CEC")]
		[Address(RVA = "0x1C1D1D8", Offset = "0x1C1D1D8", VA = "0x7BBC41D1D8", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CED")]
		[Address(RVA = "0x1C1E320", Offset = "0x1C1E320", VA = "0x7BBC41E320")]
		private void SetTreasureBoxProbabilityState()
		{
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CEE")]
		[Address(RVA = "0x1C1E1D8", Offset = "0x1C1E1D8", VA = "0x7BBC41E1D8")]
		private void SetTreasureBoxProbabilityStateOnUnSelect()
		{
		}

		// Token: 0x06006CEF RID: 27887 RVA: 0x0001EBA0 File Offset: 0x0001CDA0
		[Token(Token = "0x6006CEF")]
		[Address(RVA = "0x1C1E2E0", Offset = "0x1C1E2E0", VA = "0x7BBC41E2E0")]
		public bool CheckIDInvaild(uint itemid)
		{
			return default(bool);
		}

		// Token: 0x06006CF0 RID: 27888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF0")]
		[Address(RVA = "0x1C1E444", Offset = "0x1C1E444", VA = "0x7BBC41E444", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06006CF1 RID: 27889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF1")]
		[Address(RVA = "0x1C1E498", Offset = "0x1C1E498", VA = "0x7BBC41E498")]
		public void RefreshData()
		{
		}

		// Token: 0x06006CF2 RID: 27890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF2")]
		[Address(RVA = "0x1C1E9B8", Offset = "0x1C1E9B8", VA = "0x7BBC41E9B8")]
		public void SetShowBoostAvatarParams(ShowBoostAvatarParams showBoostAvatarParams)
		{
		}

		// Token: 0x06006CF3 RID: 27891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF3")]
		[Address(RVA = "0x1C1E9C0", Offset = "0x1C1E9C0", VA = "0x7BBC41E9C0")]
		public void SetOriginalItemID(uint id)
		{
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF4")]
		[Address(RVA = "0x1C1E9C8", Offset = "0x1C1E9C8", VA = "0x7BBC41E9C8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF5")]
		[Address(RVA = "0x1C1E86C", Offset = "0x1C1E86C", VA = "0x7BBC41E86C")]
		private void CheckItemABReady(uint itemID)
		{
		}

		// Token: 0x06006CF6 RID: 27894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF6")]
		[Address(RVA = "0x1C1EAA0", Offset = "0x1C1EAA0", VA = "0x7BBC41EAA0")]
		public UIBundleItemController()
		{
		}

		// Token: 0x04008857 RID: 34903
		[Token(Token = "0x4008857")]
		[FieldOffset(Offset = "0x70")]
		private UIBundleItemView m_View;

		// Token: 0x04008858 RID: 34904
		[Token(Token = "0x4008858")]
		[FieldOffset(Offset = "0x78")]
		private CSSharedItemData m_itData;

		// Token: 0x04008859 RID: 34905
		[Token(Token = "0x4008859")]
		[FieldOffset(Offset = "0x80")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x0400885A RID: 34906
		[Token(Token = "0x400885A")]
		[FieldOffset(Offset = "0x88")]
		private ShowBoostAvatarParams m_ShowBoostAvatarParmas;

		// Token: 0x0400885B RID: 34907
		[Token(Token = "0x400885B")]
		[FieldOffset(Offset = "0x90")]
		private BaseItemInfo m_Data;

		// Token: 0x0400885C RID: 34908
		[Token(Token = "0x400885C")]
		[FieldOffset(Offset = "0x98")]
		private UIStandardItemMini2Controller ctrl;

		// Token: 0x0400885D RID: 34909
		[Token(Token = "0x400885D")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_IsItemABReady;

		// Token: 0x0400885E RID: 34910
		[Token(Token = "0x400885E")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_RefreshPreview;

		// Token: 0x0400885F RID: 34911
		[Token(Token = "0x400885F")]
		private const uint m_itemClothFemaleMin = 203000578U;

		// Token: 0x04008860 RID: 34912
		[Token(Token = "0x4008860")]
		private const uint m_itemClothFemaleMax = 203999999U;

		// Token: 0x04008861 RID: 34913
		[Token(Token = "0x4008861")]
		private const uint m_itemClothMaleMin = 211000343U;

		// Token: 0x04008862 RID: 34914
		[Token(Token = "0x4008862")]
		private const uint m_itemClothMaleMax = 211999999U;

		// Token: 0x04008863 RID: 34915
		[Token(Token = "0x4008863")]
		[FieldOffset(Offset = "0xA4")]
		private uint m_OriginalItemID;

		// Token: 0x04008864 RID: 34916
		[Token(Token = "0x4008864")]
		[FieldOffset(Offset = "0xA8")]
		private UISmallDetailTipsController m_CurrentTips;
	}
}
