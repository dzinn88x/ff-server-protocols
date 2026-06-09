using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017FC RID: 6140
	[Token(Token = "0x20017FC")]
	public class UIGachaLengendaryExtraListItemController : UIBaseController
	{
		// Token: 0x06007748 RID: 30536 RVA: 0x00020FB8 File Offset: 0x0001F1B8
		[Token(Token = "0x6007748")]
		[Address(RVA = "0x205B9D0", Offset = "0x205B9D0", VA = "0x7BBC85B9D0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007749")]
		[Address(RVA = "0x205BA20", Offset = "0x205BA20", VA = "0x7BBC85BA20", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600774A")]
		[Address(RVA = "0x205BB34", Offset = "0x205BB34", VA = "0x7BBC85BB34")]
		public void SetViewData(ExtraRewardDesc data, int data_index, uint chestID, bool isLegendCloth = true)
		{
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600774B")]
		[Address(RVA = "0x205BB5C", Offset = "0x205BB5C", VA = "0x7BBC85BB5C")]
		public void UpdateItemState()
		{
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600774C")]
		[Address(RVA = "0x205BC9C", Offset = "0x205BC9C", VA = "0x7BBC85BC9C")]
		private void RefreshExtraAwardItemView(uint chestID)
		{
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600774D")]
		[Address(RVA = "0x205C954", Offset = "0x205C954", VA = "0x7BBC85C954")]
		private void SetQualityBG(int Quality, UISprite QualityBG, UISprite prizeBg)
		{
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600774E")]
		[Address(RVA = "0x205CB54", Offset = "0x205CB54", VA = "0x7BBC85CB54")]
		private void OnItemBtnSelect()
		{
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600774F")]
		[Address(RVA = "0x205D00C", Offset = "0x205D00C", VA = "0x7BBC85D00C")]
		private void ReOpenBtnClick()
		{
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007750")]
		[Address(RVA = "0x205D05C", Offset = "0x205D05C", VA = "0x7BBC85D05C")]
		public UIGachaLengendaryExtraListItemController()
		{
		}

		// Token: 0x04008DB1 RID: 36273
		[Token(Token = "0x4008DB1")]
		[FieldOffset(Offset = "0x58")]
		private ExtraRewardDesc m_ItemDesc;

		// Token: 0x04008DB2 RID: 36274
		[Token(Token = "0x4008DB2")]
		[FieldOffset(Offset = "0x60")]
		private int m_Indx;

		// Token: 0x04008DB3 RID: 36275
		[Token(Token = "0x4008DB3")]
		[FieldOffset(Offset = "0x64")]
		private uint m_GachaID;

		// Token: 0x04008DB4 RID: 36276
		[Token(Token = "0x4008DB4")]
		[FieldOffset(Offset = "0x68")]
		private uint m_ItemDelayCall;

		// Token: 0x04008DB5 RID: 36277
		[Token(Token = "0x4008DB5")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_IsLegendClothGacha;

		// Token: 0x04008DB6 RID: 36278
		[Token(Token = "0x4008DB6")]
		[FieldOffset(Offset = "0x70")]
		private UIGachaLengendaryExtraListItemController.RareRewardState m_RareRewardState;

		// Token: 0x04008DB7 RID: 36279
		[Token(Token = "0x4008DB7")]
		[FieldOffset(Offset = "0x78")]
		private BaseItemInfo m_BaseItemInfo;

		// Token: 0x04008DB8 RID: 36280
		[Token(Token = "0x4008DB8")]
		[FieldOffset(Offset = "0x80")]
		private UIGachaLengendaryExtraListItemController.ExtraAwardItemState m_State;

		// Token: 0x04008DB9 RID: 36281
		[Token(Token = "0x4008DB9")]
		[FieldOffset(Offset = "0x88")]
		private UIGachaLengendaryExtraListItemView m_View;

		// Token: 0x020017FD RID: 6141
		[Token(Token = "0x20017FD")]
		public enum ExtraAwardItemState
		{
			// Token: 0x04008DBB RID: 36283
			[Token(Token = "0x4008DBB")]
			STATE_NONE,
			// Token: 0x04008DBC RID: 36284
			[Token(Token = "0x4008DBC")]
			STATE_ALREADY_RECEIVE,
			// Token: 0x04008DBD RID: 36285
			[Token(Token = "0x4008DBD")]
			STATE_CAN_RECEIVE,
			// Token: 0x04008DBE RID: 36286
			[Token(Token = "0x4008DBE")]
			STATE_CANNOT_RECEIVE
		}

		// Token: 0x020017FE RID: 6142
		[Token(Token = "0x20017FE")]
		public enum RareRewardState
		{
			// Token: 0x04008DC0 RID: 36288
			[Token(Token = "0x4008DC0")]
			Normal,
			// Token: 0x04008DC1 RID: 36289
			[Token(Token = "0x4008DC1")]
			SecondPrize,
			// Token: 0x04008DC2 RID: 36290
			[Token(Token = "0x4008DC2")]
			BigPrize
		}
	}
}
