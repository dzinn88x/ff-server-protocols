using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001A2D RID: 6701
	[Token(Token = "0x2001A2D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7AEC", Offset = "0x10F7AEC")]
	public class UILuckyBagItemController : UIEasyListItemController
	{
		// Token: 0x06008C9A RID: 35994 RVA: 0x00025830 File Offset: 0x00023A30
		[Token(Token = "0x6008C9A")]
		[Address(RVA = "0x19EABB4", Offset = "0x19EABB4", VA = "0x7BBC1EABB4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008C9B RID: 35995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C9B")]
		[Address(RVA = "0x19EAC04", Offset = "0x19EAC04", VA = "0x7BBC1EAC04", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008C9C RID: 35996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C9C")]
		[Address(RVA = "0x19EAD40", Offset = "0x19EAD40", VA = "0x7BBC1EAD40", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06008C9D RID: 35997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C9D")]
		[Address(RVA = "0x19EADE4", Offset = "0x19EADE4", VA = "0x7BBC1EADE4")]
		private void RefreshView()
		{
		}

		// Token: 0x06008C9E RID: 35998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C9E")]
		[Address(RVA = "0x19EAE40", Offset = "0x19EAE40", VA = "0x7BBC1EAE40")]
		private void ResetItemState()
		{
		}

		// Token: 0x06008C9F RID: 35999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C9F")]
		[Address(RVA = "0x19EAFA8", Offset = "0x19EAFA8", VA = "0x7BBC1EAFA8")]
		private void SetLuckyBagState()
		{
		}

		// Token: 0x06008CA0 RID: 36000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CA0")]
		[Address(RVA = "0x19EB04C", Offset = "0x19EB04C", VA = "0x7BBC1EB04C")]
		private void RefreshDrawBtnByState()
		{
		}

		// Token: 0x06008CA1 RID: 36001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CA1")]
		[Address(RVA = "0x19EB340", Offset = "0x19EB340", VA = "0x7BBC1EB340")]
		private void RefreshDrawTimes()
		{
		}

		// Token: 0x06008CA2 RID: 36002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CA2")]
		[Address(RVA = "0x19EB400", Offset = "0x19EB400", VA = "0x7BBC1EB400")]
		private void RefreshCountDownLabel()
		{
		}

		// Token: 0x06008CA3 RID: 36003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CA3")]
		[Address(RVA = "0x19EB54C", Offset = "0x19EB54C", VA = "0x7BBC1EB54C")]
		private void RefreshLuckyBagMessage()
		{
		}

		// Token: 0x06008CA4 RID: 36004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CA4")]
		[Address(RVA = "0x19EB744", Offset = "0x19EB744", VA = "0x7BBC1EB744")]
		private void OnDrawBtnClick()
		{
		}

		// Token: 0x06008CA5 RID: 36005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CA5")]
		[Address(RVA = "0x19EB8E0", Offset = "0x19EB8E0", VA = "0x7BBC1EB8E0")]
		public UILuckyBagItemController()
		{
		}

		// Token: 0x04009902 RID: 39170
		[Token(Token = "0x4009902")]
		[FieldOffset(Offset = "0x70")]
		private UILuckyBagItemView m_View;

		// Token: 0x04009903 RID: 39171
		[Token(Token = "0x4009903")]
		[FieldOffset(Offset = "0x78")]
		private ClanLuckyBag m_Data;

		// Token: 0x04009904 RID: 39172
		[Token(Token = "0x4009904")]
		[FieldOffset(Offset = "0x80")]
		private UILuckyBagItemController.LuckyBagState m_LuckyBagState;

		// Token: 0x04009905 RID: 39173
		[Token(Token = "0x4009905")]
		[FieldOffset(Offset = "0x88")]
		private UIModelClan m_ModelClan;

		// Token: 0x04009906 RID: 39174
		[Token(Token = "0x4009906")]
		[FieldOffset(Offset = "0x90")]
		private uint m_BtnGreyColor;

		// Token: 0x04009907 RID: 39175
		[Token(Token = "0x4009907")]
		[FieldOffset(Offset = "0x94")]
		private uint m_BtnYellowColor;

		// Token: 0x02001A2E RID: 6702
		[Token(Token = "0x2001A2E")]
		private enum LuckyBagState
		{
			// Token: 0x04009909 RID: 39177
			[Token(Token = "0x4009909")]
			None,
			// Token: 0x0400990A RID: 39178
			[Token(Token = "0x400990A")]
			CanDraw,
			// Token: 0x0400990B RID: 39179
			[Token(Token = "0x400990B")]
			Drawed,
			// Token: 0x0400990C RID: 39180
			[Token(Token = "0x400990C")]
			DrawOver
		}
	}
}
