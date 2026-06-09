using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200169A RID: 5786
	[Token(Token = "0x200169A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0684", Offset = "0x10F0684")]
	public class UIAccountForbiddenPopWndController : UIPopupWindowController
	{
		// Token: 0x0600693C RID: 26940 RVA: 0x0001DC88 File Offset: 0x0001BE88
		[Token(Token = "0x600693C")]
		[Address(RVA = "0x1A3ABA0", Offset = "0x1A3ABA0", VA = "0x7BBC23ABA0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600693D")]
		[Address(RVA = "0x1A3ABF0", Offset = "0x1A3ABF0", VA = "0x7BBC23ABF0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600693E")]
		[Address(RVA = "0x1A3AD94", Offset = "0x1A3AD94", VA = "0x7BBC23AD94")]
		private void RefreshCountDownLabel(uint timeStamp)
		{
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600693F")]
		[Address(RVA = "0x1A3AFB8", Offset = "0x1A3AFB8", VA = "0x7BBC23AFB8")]
		public void SetMessageKey(BlacklistInfoRes blackList)
		{
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006940")]
		[Address(RVA = "0x1A3B144", Offset = "0x1A3B144", VA = "0x7BBC23B144")]
		private void OnConfirmBtnClick()
		{
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006941")]
		[Address(RVA = "0x1A3B14C", Offset = "0x1A3B14C", VA = "0x7BBC23B14C")]
		private void OnHelpBtnClick()
		{
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006942")]
		[Address(RVA = "0x1A3B1E8", Offset = "0x1A3B1E8", VA = "0x7BBC23B1E8")]
		public UIAccountForbiddenPopWndController()
		{
		}

		// Token: 0x0400863F RID: 34367
		[Token(Token = "0x400863F")]
		[FieldOffset(Offset = "0x98")]
		private UIAccountForbiddenPopWndView m_View;

		// Token: 0x04008640 RID: 34368
		[Token(Token = "0x4008640")]
		[FieldOffset(Offset = "0xA0")]
		private string m_InfoUrl;

		// Token: 0x04008641 RID: 34369
		[Token(Token = "0x4008641")]
		[FieldOffset(Offset = "0xA8")]
		private UICountDownController m_CountDownCtrl;
	}
}
