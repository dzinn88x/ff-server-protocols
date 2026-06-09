using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BF4 RID: 7156
	[Token(Token = "0x2001BF4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB3F4", Offset = "0x10FB3F4")]
	internal class UIWinnerModeEntranceController : UIPopupWindowController
	{
		// Token: 0x06009B81 RID: 39809 RVA: 0x00028DD0 File Offset: 0x00026FD0
		[Token(Token = "0x6009B81")]
		[Address(RVA = "0x1792730", Offset = "0x1792730", VA = "0x7BBBF92730")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009B82 RID: 39810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B82")]
		[Address(RVA = "0x1792780", Offset = "0x1792780", VA = "0x7BBBF92780", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009B83 RID: 39811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B83")]
		[Address(RVA = "0x1792A74", Offset = "0x1792A74", VA = "0x7BBBF92A74")]
		public void SetUIData()
		{
		}

		// Token: 0x06009B84 RID: 39812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B84")]
		[Address(RVA = "0x1792E24", Offset = "0x1792E24", VA = "0x7BBBF92E24")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x06009B85 RID: 39813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B85")]
		[Address(RVA = "0x1792E68", Offset = "0x1792E68", VA = "0x7BBBF92E68")]
		private void OnPurchaseBtnClick()
		{
		}

		// Token: 0x06009B86 RID: 39814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B86")]
		[Address(RVA = "0x1792FD4", Offset = "0x1792FD4", VA = "0x7BBBF92FD4")]
		private void OnExchangeBtnClick()
		{
		}

		// Token: 0x06009B87 RID: 39815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B87")]
		[Address(RVA = "0x17930A8", Offset = "0x17930A8", VA = "0x7BBBF930A8")]
		private void onFreeBtnClick()
		{
		}

		// Token: 0x06009B88 RID: 39816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B88")]
		[Address(RVA = "0x179317C", Offset = "0x179317C", VA = "0x7BBBF9317C")]
		private void OnMoreInfoBtnClick()
		{
		}

		// Token: 0x06009B89 RID: 39817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B89")]
		[Address(RVA = "0x1793350", Offset = "0x1793350", VA = "0x7BBBF93350")]
		public UIWinnerModeEntranceController()
		{
		}

		// Token: 0x0400A1CB RID: 41419
		[Token(Token = "0x400A1CB")]
		[FieldOffset(Offset = "0x98")]
		private UIWinnerModeEntranceView m_View;

		// Token: 0x0400A1CC RID: 41420
		[Token(Token = "0x400A1CC")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x0400A1CD RID: 41421
		[Token(Token = "0x400A1CD")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x0400A1CE RID: 41422
		[Token(Token = "0x400A1CE")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelGroup m_ModelGroup;
	}
}
