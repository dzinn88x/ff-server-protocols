using System;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001B76 RID: 7030
	[Token(Token = "0x2001B76")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA1E4", Offset = "0x10FA1E4")]
	public class UISeasonStatsController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06009765 RID: 38757 RVA: 0x00027F18 File Offset: 0x00026118
		[Token(Token = "0x6009765")]
		[Address(RVA = "0x16291A4", Offset = "0x16291A4", VA = "0x7BBBE291A4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009766 RID: 38758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009766")]
		[Address(RVA = "0x16291F4", Offset = "0x16291F4", VA = "0x7BBBE291F4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009767 RID: 38759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009767")]
		[Address(RVA = "0x16294A0", Offset = "0x16294A0", VA = "0x7BBBE294A0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009768 RID: 38760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009768")]
		[Address(RVA = "0x16295A0", Offset = "0x16295A0", VA = "0x7BBBE295A0")]
		public void SetViewData(f ladderMatchType)
		{
		}

		// Token: 0x06009769 RID: 38761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009769")]
		[Address(RVA = "0x1629718", Offset = "0x1629718", VA = "0x7BBBE29718")]
		private void RefreshCSData()
		{
		}

		// Token: 0x0600976A RID: 38762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600976A")]
		[Address(RVA = "0x1629CA8", Offset = "0x1629CA8", VA = "0x7BBBE29CA8")]
		private void RefreshBRData()
		{
		}

		// Token: 0x0600976B RID: 38763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600976B")]
		[Address(RVA = "0x162A320", Offset = "0x162A320", VA = "0x7BBBE2A320")]
		private void OnDetailsBtnClick()
		{
		}

		// Token: 0x0600976C RID: 38764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600976C")]
		[Address(RVA = "0x162A4D8", Offset = "0x162A4D8", VA = "0x7BBBE2A4D8")]
		private void OnViewAllBtnClicked()
		{
		}

		// Token: 0x0600976D RID: 38765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600976D")]
		[Address(RVA = "0x162A754", Offset = "0x162A754", VA = "0x7BBBE2A754", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600976E RID: 38766 RVA: 0x00027F30 File Offset: 0x00026130
		[Token(Token = "0x600976E")]
		[Address(RVA = "0x162A80C", Offset = "0x162A80C", VA = "0x7BBBE2A80C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600976F RID: 38767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600976F")]
		[Address(RVA = "0x162A870", Offset = "0x162A870", VA = "0x7BBBE2A870")]
		public UISeasonStatsController()
		{
		}

		// Token: 0x04009F94 RID: 40852
		[Token(Token = "0x4009F94")]
		[FieldOffset(Offset = "0x58")]
		private UISeasonStatsView m_View;

		// Token: 0x04009F95 RID: 40853
		[Token(Token = "0x4009F95")]
		[FieldOffset(Offset = "0x60")]
		private f m_LadderMatchType;

		// Token: 0x04009F96 RID: 40854
		[Token(Token = "0x4009F96")]
		[FieldOffset(Offset = "0x68")]
		private UIStandardItemMiniController itemCtrl;

		// Token: 0x04009F97 RID: 40855
		[Token(Token = "0x4009F97")]
		[FieldOffset(Offset = "0x70")]
		private UIStandardItemMiniController itemPeakCtrl;
	}
}
