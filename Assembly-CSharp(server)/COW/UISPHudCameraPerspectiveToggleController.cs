using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B88 RID: 7048
	[Token(Token = "0x2001B88")]
	public class UISPHudCameraPerspectiveToggleController : UIBaseController
	{
		// Token: 0x060097FB RID: 38907 RVA: 0x00028080 File Offset: 0x00026280
		[Token(Token = "0x60097FB")]
		[Address(RVA = "0x1EE5C40", Offset = "0x1EE5C40", VA = "0x7BBC6E5C40")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060097FC RID: 38908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097FC")]
		[Address(RVA = "0x1EE5C90", Offset = "0x1EE5C90", VA = "0x7BBC6E5C90", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060097FD RID: 38909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097FD")]
		[Address(RVA = "0x1EE5ED4", Offset = "0x1EE5ED4", VA = "0x7BBC6E5ED4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060097FE RID: 38910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097FE")]
		[Address(RVA = "0x1EE5FA0", Offset = "0x1EE5FA0", VA = "0x7BBC6E5FA0")]
		private void OnSwitchCameraPerspective()
		{
		}

		// Token: 0x060097FF RID: 38911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097FF")]
		[Address(RVA = "0x1EE601C", Offset = "0x1EE601C", VA = "0x7BBC6E601C")]
		private void UpdateUIView(object[] data)
		{
		}

		// Token: 0x06009800 RID: 38912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009800")]
		[Address(RVA = "0x1EE6140", Offset = "0x1EE6140", VA = "0x7BBC6E6140")]
		public UISPHudCameraPerspectiveToggleController()
		{
		}

		// Token: 0x0400A00C RID: 40972
		[Token(Token = "0x400A00C")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudCameraPerspectiveToggleView m_View;
	}
}
