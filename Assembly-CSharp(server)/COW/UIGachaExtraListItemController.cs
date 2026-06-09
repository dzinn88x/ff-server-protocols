using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017E8 RID: 6120
	[Token(Token = "0x20017E8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F30B4", Offset = "0x10F30B4")]
	public class UIGachaExtraListItemController : UIBaseController
	{
		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x0600766E RID: 30318 RVA: 0x00020D48 File Offset: 0x0001EF48
		[Token(Token = "0x17000954")]
		public UIGachaExtraListItemController.ExtraAwardItemState State
		{
			[Token(Token = "0x600766E")]
			[Address(RVA = "0x21627F8", Offset = "0x21627F8", VA = "0x7BBC9627F8")]
			get
			{
				return UIGachaExtraListItemController.ExtraAwardItemState.STATE_NONE;
			}
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x00020D60 File Offset: 0x0001EF60
		[Token(Token = "0x600766F")]
		[Address(RVA = "0x2162800", Offset = "0x2162800", VA = "0x7BBC962800")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007670 RID: 30320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007670")]
		[Address(RVA = "0x2162850", Offset = "0x2162850", VA = "0x7BBC962850", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007671 RID: 30321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007671")]
		[Address(RVA = "0x2162934", Offset = "0x2162934", VA = "0x7BBC962934")]
		public void SetData(ExtraRewardDesc data, int data_index, uint chestID)
		{
		}

		// Token: 0x06007672 RID: 30322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007672")]
		[Address(RVA = "0x2162948", Offset = "0x2162948", VA = "0x7BBC962948")]
		public void UpdateItemState()
		{
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007673")]
		[Address(RVA = "0x2162AB8", Offset = "0x2162AB8", VA = "0x7BBC962AB8")]
		private void RefreshExtraAwardItem(uint chestID, bool needShowBg)
		{
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007674")]
		[Address(RVA = "0x21633F4", Offset = "0x21633F4", VA = "0x7BBC9633F4")]
		public void OnItemBtnSelect()
		{
		}

		// Token: 0x06007675 RID: 30325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007675")]
		[Address(RVA = "0x2163724", Offset = "0x2163724", VA = "0x7BBC963724")]
		private void ReOpenBtnClick()
		{
		}

		// Token: 0x06007676 RID: 30326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007676")]
		[Address(RVA = "0x2163774", Offset = "0x2163774", VA = "0x7BBC963774")]
		private void PlayExchangeRewardSound()
		{
		}

		// Token: 0x06007677 RID: 30327 RVA: 0x00020D78 File Offset: 0x0001EF78
		[Token(Token = "0x6007677")]
		[Address(RVA = "0x2163810", Offset = "0x2163810", VA = "0x7BBC963810")]
		public uint GetItemCdtValue()
		{
			return 0U;
		}

		// Token: 0x06007678 RID: 30328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007678")]
		[Address(RVA = "0x216383C", Offset = "0x216383C", VA = "0x7BBC96383C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007679")]
		[Address(RVA = "0x21638E0", Offset = "0x21638E0", VA = "0x7BBC9638E0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767A")]
		[Address(RVA = "0x21638E8", Offset = "0x21638E8", VA = "0x7BBC9638E8")]
		public UIGachaExtraListItemController()
		{
		}

		// Token: 0x04008D40 RID: 36160
		[Token(Token = "0x4008D40")]
		[FieldOffset(Offset = "0x58")]
		private UIGachaExtraListItemView m_View;

		// Token: 0x04008D41 RID: 36161
		[Token(Token = "0x4008D41")]
		[FieldOffset(Offset = "0x60")]
		private UIGachaExtraListItemController.ExtraAwardItemState m_State;

		// Token: 0x04008D42 RID: 36162
		[Token(Token = "0x4008D42")]
		[FieldOffset(Offset = "0x68")]
		private ExtraRewardDesc m_ItemDesc;

		// Token: 0x04008D43 RID: 36163
		[Token(Token = "0x4008D43")]
		[FieldOffset(Offset = "0x70")]
		private int m_Indx;

		// Token: 0x04008D44 RID: 36164
		[Token(Token = "0x4008D44")]
		[FieldOffset(Offset = "0x74")]
		private uint m_GachaID;

		// Token: 0x04008D45 RID: 36165
		[Token(Token = "0x4008D45")]
		[FieldOffset(Offset = "0x78")]
		private uint m_ItemDelayCall;

		// Token: 0x020017E9 RID: 6121
		[Token(Token = "0x20017E9")]
		public enum ExtraAwardItemState
		{
			// Token: 0x04008D47 RID: 36167
			[Token(Token = "0x4008D47")]
			STATE_NONE,
			// Token: 0x04008D48 RID: 36168
			[Token(Token = "0x4008D48")]
			STATE_ALREADY_RECEIVE,
			// Token: 0x04008D49 RID: 36169
			[Token(Token = "0x4008D49")]
			STATE_CAN_RECEIVE,
			// Token: 0x04008D4A RID: 36170
			[Token(Token = "0x4008D4A")]
			STATE_CANNOT_RECEIVE
		}
	}
}
