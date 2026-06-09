using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B96 RID: 7062
	[Token(Token = "0x2001B96")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA6EC", Offset = "0x10FA6EC")]
	public class UISPHudOBInfoBarController : UIBaseController
	{
		// Token: 0x0600984C RID: 38988 RVA: 0x000281E8 File Offset: 0x000263E8
		[Token(Token = "0x600984C")]
		[Address(RVA = "0x1EEC18C", Offset = "0x1EEC18C", VA = "0x7BBC6EC18C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600984D RID: 38989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600984D")]
		[Address(RVA = "0x1EEC1DC", Offset = "0x1EEC1DC", VA = "0x7BBC6EC1DC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600984E RID: 38990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600984E")]
		[Address(RVA = "0x1EEC2F4", Offset = "0x1EEC2F4", VA = "0x7BBC6EC2F4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600984F RID: 38991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600984F")]
		[Address(RVA = "0x1EEC3C0", Offset = "0x1EEC3C0", VA = "0x7BBC6EC3C0")]
		private void CtrlMode(object[] data)
		{
		}

		// Token: 0x06009850 RID: 38992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009850")]
		[Address(RVA = "0x1EEC4C4", Offset = "0x1EEC4C4", VA = "0x7BBC6EC4C4")]
		public UISPHudOBInfoBarController()
		{
		}

		// Token: 0x0400A02A RID: 41002
		[Token(Token = "0x400A02A")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudOBInfoBarView m_View;
	}
}
