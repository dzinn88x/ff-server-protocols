using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001805 RID: 6149
	[Token(Token = "0x2001805")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F33EC", Offset = "0x10F33EC")]
	public class UIGachaLimitExtraListItemController : UIBaseController
	{
		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x0600778F RID: 30607 RVA: 0x00021090 File Offset: 0x0001F290
		[Token(Token = "0x1700095D")]
		public UIGachaLimitExtraListItemController.ExtraAwardItemState State
		{
			[Token(Token = "0x600778F")]
			[Address(RVA = "0x2064148", Offset = "0x2064148", VA = "0x7BBC864148")]
			get
			{
				return UIGachaLimitExtraListItemController.ExtraAwardItemState.STATE_NONE;
			}
		}

		// Token: 0x06007790 RID: 30608 RVA: 0x000210A8 File Offset: 0x0001F2A8
		[Token(Token = "0x6007790")]
		[Address(RVA = "0x2064150", Offset = "0x2064150", VA = "0x7BBC864150")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007791 RID: 30609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007791")]
		[Address(RVA = "0x20641A0", Offset = "0x20641A0", VA = "0x7BBC8641A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007792 RID: 30610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007792")]
		[Address(RVA = "0x205ED34", Offset = "0x205ED34", VA = "0x7BBC85ED34")]
		public void TryShowGainEffect()
		{
		}

		// Token: 0x06007793 RID: 30611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007793")]
		[Address(RVA = "0x205F54C", Offset = "0x205F54C", VA = "0x7BBC85F54C")]
		public void SetData(ExtraRewardDesc data, int data_index, uint chestID)
		{
		}

		// Token: 0x06007794 RID: 30612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007794")]
		[Address(RVA = "0x2064284", Offset = "0x2064284", VA = "0x7BBC864284")]
		public void UpdateItemState()
		{
		}

		// Token: 0x06007795 RID: 30613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007795")]
		[Address(RVA = "0x2064400", Offset = "0x2064400", VA = "0x7BBC864400")]
		private void RefreshExtraAwardItem(uint chestID, bool needShowBg)
		{
		}

		// Token: 0x06007796 RID: 30614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007796")]
		[Address(RVA = "0x2064BFC", Offset = "0x2064BFC", VA = "0x7BBC864BFC")]
		public void OnItemBtnSelect()
		{
		}

		// Token: 0x06007797 RID: 30615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007797")]
		[Address(RVA = "0x2064F2C", Offset = "0x2064F2C", VA = "0x7BBC864F2C")]
		private void ReOpenBtnClick()
		{
		}

		// Token: 0x06007798 RID: 30616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007798")]
		[Address(RVA = "0x2064F7C", Offset = "0x2064F7C", VA = "0x7BBC864F7C")]
		private void PlayExchangeRewardSound()
		{
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x000210C0 File Offset: 0x0001F2C0
		[Token(Token = "0x6007799")]
		[Address(RVA = "0x2065018", Offset = "0x2065018", VA = "0x7BBC865018")]
		public uint GetItemCdtValue()
		{
			return 0U;
		}

		// Token: 0x0600779A RID: 30618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600779A")]
		[Address(RVA = "0x2065044", Offset = "0x2065044", VA = "0x7BBC865044", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600779B RID: 30619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600779B")]
		[Address(RVA = "0x20650E8", Offset = "0x20650E8", VA = "0x7BBC8650E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600779C RID: 30620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600779C")]
		[Address(RVA = "0x20650F0", Offset = "0x20650F0", VA = "0x7BBC8650F0")]
		public UIGachaLimitExtraListItemController()
		{
		}

		// Token: 0x04008DE2 RID: 36322
		[Token(Token = "0x4008DE2")]
		[FieldOffset(Offset = "0x58")]
		private UIGachaLimitExtraListItemView m_View;

		// Token: 0x04008DE3 RID: 36323
		[Token(Token = "0x4008DE3")]
		[FieldOffset(Offset = "0x60")]
		private UIGachaLimitExtraListItemController.ExtraAwardItemState m_State;

		// Token: 0x04008DE4 RID: 36324
		[Token(Token = "0x4008DE4")]
		[FieldOffset(Offset = "0x64")]
		private bool isChangeCanReceive;

		// Token: 0x04008DE5 RID: 36325
		[Token(Token = "0x4008DE5")]
		[FieldOffset(Offset = "0x68")]
		private ExtraRewardDesc m_ItemDesc;

		// Token: 0x04008DE6 RID: 36326
		[Token(Token = "0x4008DE6")]
		[FieldOffset(Offset = "0x70")]
		private int m_Indx;

		// Token: 0x04008DE7 RID: 36327
		[Token(Token = "0x4008DE7")]
		[FieldOffset(Offset = "0x74")]
		private uint m_GachaID;

		// Token: 0x04008DE8 RID: 36328
		[Token(Token = "0x4008DE8")]
		[FieldOffset(Offset = "0x78")]
		private uint m_ItemDelayCall;

		// Token: 0x02001806 RID: 6150
		[Token(Token = "0x2001806")]
		public enum ExtraAwardItemState
		{
			// Token: 0x04008DEA RID: 36330
			[Token(Token = "0x4008DEA")]
			STATE_NONE,
			// Token: 0x04008DEB RID: 36331
			[Token(Token = "0x4008DEB")]
			STATE_ALREADY_RECEIVE,
			// Token: 0x04008DEC RID: 36332
			[Token(Token = "0x4008DEC")]
			STATE_CAN_RECEIVE,
			// Token: 0x04008DED RID: 36333
			[Token(Token = "0x4008DED")]
			STATE_CANNOT_RECEIVE
		}
	}
}
