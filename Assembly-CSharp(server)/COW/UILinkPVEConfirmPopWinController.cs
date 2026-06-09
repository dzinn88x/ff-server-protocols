using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001559 RID: 5465
	[Token(Token = "0x2001559")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE5AC", Offset = "0x10EE5AC")]
	public class UILinkPVEConfirmPopWinController : UIPopupWindowController
	{
		// Token: 0x06005E87 RID: 24199 RVA: 0x0001B600 File Offset: 0x00019800
		[Token(Token = "0x6005E87")]
		[Address(RVA = "0x1CC2E6C", Offset = "0x1CC2E6C", VA = "0x7BBC4C2E6C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E88")]
		[Address(RVA = "0x1CC2EBC", Offset = "0x1CC2EBC", VA = "0x7BBC4C2EBC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E89")]
		[Address(RVA = "0x1CC0AE0", Offset = "0x1CC0AE0", VA = "0x7BBC4C0AE0")]
		public void SetCallback(Action callback)
		{
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8A")]
		[Address(RVA = "0x1CC2FA0", Offset = "0x1CC2FA0", VA = "0x7BBC4C2FA0")]
		public void OnConfirmClick()
		{
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8B")]
		[Address(RVA = "0x1CC2FD4", Offset = "0x1CC2FD4", VA = "0x7BBC4C2FD4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8C")]
		[Address(RVA = "0x1CC2FFC", Offset = "0x1CC2FFC", VA = "0x7BBC4C2FFC")]
		public UILinkPVEConfirmPopWinController()
		{
		}

		// Token: 0x04007FC5 RID: 32709
		[Token(Token = "0x4007FC5")]
		[FieldOffset(Offset = "0x98")]
		private UILinkActivityPVEConfimPopWindowView m_View;

		// Token: 0x04007FC6 RID: 32710
		[Token(Token = "0x4007FC6")]
		[FieldOffset(Offset = "0xA0")]
		private Action m_confirmCallback;
	}
}
