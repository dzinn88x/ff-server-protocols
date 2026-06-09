using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B89 RID: 7049
	[Token(Token = "0x2001B89")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA484", Offset = "0x10FA484")]
	public class UISPHudCameraTypeToggleController : UIBaseController
	{
		// Token: 0x06009801 RID: 38913 RVA: 0x00028098 File Offset: 0x00026298
		[Token(Token = "0x6009801")]
		[Address(RVA = "0x1EE62AC", Offset = "0x1EE62AC", VA = "0x7BBC6E62AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009802 RID: 38914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009802")]
		[Address(RVA = "0x1EE62FC", Offset = "0x1EE62FC", VA = "0x7BBC6E62FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009803 RID: 38915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009803")]
		[Address(RVA = "0x1EE64EC", Offset = "0x1EE64EC", VA = "0x7BBC6E64EC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009804 RID: 38916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009804")]
		[Address(RVA = "0x1EE65B8", Offset = "0x1EE65B8", VA = "0x7BBC6E65B8")]
		private void OnSwitchCameraType()
		{
		}

		// Token: 0x06009805 RID: 38917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009805")]
		[Address(RVA = "0x1EE6630", Offset = "0x1EE6630", VA = "0x7BBC6E6630")]
		private void UpdateUIView(object[] data)
		{
		}

		// Token: 0x06009806 RID: 38918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009806")]
		[Address(RVA = "0x1EE67DC", Offset = "0x1EE67DC", VA = "0x7BBC6E67DC")]
		public UISPHudCameraTypeToggleController()
		{
		}

		// Token: 0x0400A00D RID: 40973
		[Token(Token = "0x400A00D")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudCameraTypeToggleView m_View;
	}
}
