using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013BB RID: 5051
	[Token(Token = "0x20013BB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBC80", Offset = "0x10EBC80")]
	internal class UISuperCarHelpWndController : UIPopupWindowController
	{
		// Token: 0x0600525D RID: 21085 RVA: 0x00018C00 File Offset: 0x00016E00
		[Token(Token = "0x600525D")]
		[Address(RVA = "0x2144A60", Offset = "0x2144A60", VA = "0x7BBC944A60")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525E")]
		[Address(RVA = "0x2144AB0", Offset = "0x2144AB0", VA = "0x7BBC944AB0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525F")]
		[Address(RVA = "0x2144CC8", Offset = "0x2144CC8", VA = "0x7BBC944CC8")]
		private void OnBtnHelpOtherClick()
		{
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005260")]
		[Address(RVA = "0x2141AE0", Offset = "0x2141AE0", VA = "0x7BBC941AE0")]
		public void Init()
		{
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005261")]
		[Address(RVA = "0x2145218", Offset = "0x2145218", VA = "0x7BBC945218", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005262")]
		[Address(RVA = "0x21452E4", Offset = "0x21452E4", VA = "0x7BBC9452E4")]
		private void ProcessAnimEvt(params object[] data)
		{
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005263")]
		[Address(RVA = "0x21452E8", Offset = "0x21452E8", VA = "0x7BBC9452E8")]
		private void ClickMask()
		{
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005264")]
		[Address(RVA = "0x2145394", Offset = "0x2145394", VA = "0x7BBC945394")]
		public UISuperCarHelpWndController()
		{
		}

		// Token: 0x04007863 RID: 30819
		[Token(Token = "0x4007863")]
		[FieldOffset(Offset = "0x98")]
		private UISuperCarHelpWndView m_View;

		// Token: 0x04007864 RID: 30820
		[Token(Token = "0x4007864")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelSuperCar m_ModelSuperCar;

		// Token: 0x04007865 RID: 30821
		[Token(Token = "0x4007865")]
		[FieldOffset(Offset = "0xA8")]
		private CSGetSupercarInfoRes m_SuperCarInfo;
	}
}
