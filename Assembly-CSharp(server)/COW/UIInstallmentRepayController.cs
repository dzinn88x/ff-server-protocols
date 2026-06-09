using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001581 RID: 5505
	[Token(Token = "0x2001581")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEB34", Offset = "0x10EEB34")]
	public class UIInstallmentRepayController : UIPopupWindowController
	{
		// Token: 0x06005FF5 RID: 24565 RVA: 0x0001BB88 File Offset: 0x00019D88
		[Token(Token = "0x6005FF5")]
		[Address(RVA = "0x1910424", Offset = "0x1910424", VA = "0x7BBC110424")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005FF6 RID: 24566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF6")]
		[Address(RVA = "0x1910474", Offset = "0x1910474", VA = "0x7BBC110474", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005FF7 RID: 24567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF7")]
		[Address(RVA = "0x19105B0", Offset = "0x19105B0", VA = "0x7BBC1105B0")]
		private void OnOkBtnClick()
		{
		}

		// Token: 0x06005FF8 RID: 24568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF8")]
		[Address(RVA = "0x19105E8", Offset = "0x19105E8", VA = "0x7BBC1105E8")]
		public void RefreshData(uint itemID, string message = "T_17_I_INSTALLPAY_PAID_NOTICE", [Optional] Action okAction)
		{
		}

		// Token: 0x06005FF9 RID: 24569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF9")]
		[Address(RVA = "0x19107AC", Offset = "0x19107AC", VA = "0x7BBC1107AC")]
		public UIInstallmentRepayController()
		{
		}

		// Token: 0x04008047 RID: 32839
		[Token(Token = "0x4008047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIInstallmentRepayView m_View;

		// Token: 0x04008048 RID: 32840
		[Token(Token = "0x4008048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action m_Action;
	}
}
