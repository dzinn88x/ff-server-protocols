using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001512 RID: 5394
	[Token(Token = "0x2001512")]
	internal class UIHudTxtOnlyNotificationController : UIBaseController
	{
		// Token: 0x06005CAC RID: 23724 RVA: 0x0001AF88 File Offset: 0x00019188
		[Token(Token = "0x6005CAC")]
		[Address(RVA = "0x15EDC40", Offset = "0x15EDC40", VA = "0x7BBBDEDC40")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAD")]
		[Address(RVA = "0x15EDC90", Offset = "0x15EDC90", VA = "0x7BBBDEDC90", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005CAE RID: 23726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAE")]
		[Address(RVA = "0x15EDD74", Offset = "0x15EDD74", VA = "0x7BBBDEDD74", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005CAF RID: 23727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAF")]
		[Address(RVA = "0x15EDE9C", Offset = "0x15EDE9C", VA = "0x7BBBDEDE9C", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB0")]
		[Address(RVA = "0x15EDEEC", Offset = "0x15EDEEC", VA = "0x7BBBDEDEEC")]
		private void ShowMessage(params object[] data)
		{
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB1")]
		[Address(RVA = "0x15EDFC0", Offset = "0x15EDFC0", VA = "0x7BBBDEDFC0")]
		protected void Show(float secs)
		{
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB2")]
		[Address(RVA = "0x15EE118", Offset = "0x15EE118", VA = "0x7BBBDEE118")]
		protected void WaitAndHide()
		{
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB3")]
		[Address(RVA = "0x15EE160", Offset = "0x15EE160", VA = "0x7BBBDEE160")]
		public UIHudTxtOnlyNotificationController()
		{
		}

		// Token: 0x04007EBB RID: 32443
		[Token(Token = "0x4007EBB")]
		[FieldOffset(Offset = "0x58")]
		private UIHudTxtOnlyNotificationView m_View;

		// Token: 0x04007EBC RID: 32444
		[Token(Token = "0x4007EBC")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallID;
	}
}
