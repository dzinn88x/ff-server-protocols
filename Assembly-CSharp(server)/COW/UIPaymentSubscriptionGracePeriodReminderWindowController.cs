using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AD6 RID: 6870
	[Token(Token = "0x2001AD6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8BE4", Offset = "0x10F8BE4")]
	public class UIPaymentSubscriptionGracePeriodReminderWindowController : UIPopupWindowController
	{
		// Token: 0x0600914C RID: 37196 RVA: 0x00026B98 File Offset: 0x00024D98
		[Token(Token = "0x600914C")]
		[Address(RVA = "0x1F326C0", Offset = "0x1F326C0", VA = "0x7BBC7326C0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600914D RID: 37197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600914D")]
		[Address(RVA = "0x1F32710", Offset = "0x1F32710", VA = "0x7BBC732710", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600914E RID: 37198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600914E")]
		[Address(RVA = "0x1F3284C", Offset = "0x1F3284C", VA = "0x7BBC73284C")]
		public void SetData(PayUtility.SubscriptionGracePeriodReminderInfo info)
		{
		}

		// Token: 0x0600914F RID: 37199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600914F")]
		[Address(RVA = "0x1F32854", Offset = "0x1F32854", VA = "0x7BBC732854")]
		private void OnConfirmButtonClick()
		{
		}

		// Token: 0x06009150 RID: 37200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009150")]
		[Address(RVA = "0x1F328C8", Offset = "0x1F328C8", VA = "0x7BBC7328C8")]
		private void OnCancelButtonClick()
		{
		}

		// Token: 0x06009151 RID: 37201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009151")]
		[Address(RVA = "0x1F3293C", Offset = "0x1F3293C", VA = "0x7BBC73293C")]
		public UIPaymentSubscriptionGracePeriodReminderWindowController()
		{
		}

		// Token: 0x04009C81 RID: 40065
		[Token(Token = "0x4009C81")]
		[FieldOffset(Offset = "0x98")]
		private UIPaymentSubscriptionGracePeriodReminderWindowView m_View;

		// Token: 0x04009C82 RID: 40066
		[Token(Token = "0x4009C82")]
		[FieldOffset(Offset = "0xA0")]
		private PayUtility.SubscriptionGracePeriodReminderInfo m_Info;
	}
}
