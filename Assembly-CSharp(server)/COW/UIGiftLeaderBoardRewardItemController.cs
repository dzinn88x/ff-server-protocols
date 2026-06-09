using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001570 RID: 5488
	[Token(Token = "0x2001570")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE90C", Offset = "0x10EE90C")]
	public class UIGiftLeaderBoardRewardItemController : UIEasyListItemController
	{
		// Token: 0x06005F6E RID: 24430 RVA: 0x0001B9A8 File Offset: 0x00019BA8
		[Token(Token = "0x6005F6E")]
		[Address(RVA = "0x2010F30", Offset = "0x2010F30", VA = "0x7BBC810F30")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005F6F RID: 24431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6F")]
		[Address(RVA = "0x2010F80", Offset = "0x2010F80", VA = "0x7BBC810F80", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F70")]
		[Address(RVA = "0x20110E8", Offset = "0x20110E8", VA = "0x7BBC8110E8", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06005F71 RID: 24433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F71")]
		[Address(RVA = "0x2011438", Offset = "0x2011438", VA = "0x7BBC811438", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F72")]
		[Address(RVA = "0x2011440", Offset = "0x2011440", VA = "0x7BBC811440", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F73")]
		[Address(RVA = "0x200FAE4", Offset = "0x200FAE4", VA = "0x7BBC80FAE4")]
		public void SetRewardInfo(uint giftItemCount, int rewardCount)
		{
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F74")]
		[Address(RVA = "0x20115D8", Offset = "0x20115D8", VA = "0x7BBC8115D8")]
		private void RefreshView()
		{
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F75")]
		[Address(RVA = "0x2011EA4", Offset = "0x2011EA4", VA = "0x7BBC811EA4")]
		private void SetItemCanClaimState()
		{
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F76")]
		[Address(RVA = "0x2011CA4", Offset = "0x2011CA4", VA = "0x7BBC811CA4")]
		private void ResetItemView()
		{
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F77")]
		[Address(RVA = "0x2011F4C", Offset = "0x2011F4C", VA = "0x7BBC811F4C")]
		private void SetItemIconColor(uint color)
		{
		}

		// Token: 0x06005F78 RID: 24440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F78")]
		[Address(RVA = "0x2012190", Offset = "0x2012190", VA = "0x7BBC812190")]
		public UIGiftLeaderBoardRewardItemController()
		{
		}

		// Token: 0x0400800D RID: 32781
		[Token(Token = "0x400800D")]
		[FieldOffset(Offset = "0x70")]
		private UIGiftLeaderBoardRewardItemView m_View;

		// Token: 0x0400800E RID: 32782
		[Token(Token = "0x400800E")]
		[FieldOffset(Offset = "0x78")]
		private GiftRewardDesc m_RewardDesc;

		// Token: 0x0400800F RID: 32783
		[Token(Token = "0x400800F")]
		[FieldOffset(Offset = "0x80")]
		private UIGiftLeaderBoardController m_ParentController;

		// Token: 0x04008010 RID: 32784
		[Token(Token = "0x4008010")]
		[FieldOffset(Offset = "0x88")]
		private UIModelGift m_ModelGift;

		// Token: 0x04008011 RID: 32785
		[Token(Token = "0x4008011")]
		[FieldOffset(Offset = "0x90")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x04008012 RID: 32786
		[Token(Token = "0x4008012")]
		[FieldOffset(Offset = "0x98")]
		private UIGiftLeaderBoardRewardItemController.ERewardState m_State;

		// Token: 0x04008013 RID: 32787
		[Token(Token = "0x4008013")]
		[FieldOffset(Offset = "0xA0")]
		private BaseItemInfo m_ItemInfo;

		// Token: 0x04008014 RID: 32788
		[Token(Token = "0x4008014")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_GiftItemCount;

		// Token: 0x04008015 RID: 32789
		[Token(Token = "0x4008015")]
		[FieldOffset(Offset = "0xAC")]
		private int m_RewardCount;

		// Token: 0x04008016 RID: 32790
		[Token(Token = "0x4008016")]
		private const uint CLAIMED_ITEM_GREY = 2526451455U;

		// Token: 0x04008017 RID: 32791
		[Token(Token = "0x4008017")]
		private const uint ITEM_WHITE = 4294967295U;

		// Token: 0x02001571 RID: 5489
		[Token(Token = "0x2001571")]
		private enum ERewardState
		{
			// Token: 0x04008019 RID: 32793
			[Token(Token = "0x4008019")]
			None,
			// Token: 0x0400801A RID: 32794
			[Token(Token = "0x400801A")]
			UnClaimed,
			// Token: 0x0400801B RID: 32795
			[Token(Token = "0x400801B")]
			Claimed,
			// Token: 0x0400801C RID: 32796
			[Token(Token = "0x400801C")]
			Cant
		}
	}
}
