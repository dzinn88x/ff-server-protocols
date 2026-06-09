using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B87 RID: 7047
	[Token(Token = "0x2001B87")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA44C", Offset = "0x10FA44C")]
	public class UISPHudCameraLockToggleController : UIBaseController
	{
		// Token: 0x060097F5 RID: 38901 RVA: 0x00028068 File Offset: 0x00026268
		[Token(Token = "0x60097F5")]
		[Address(RVA = "0x1EE55A8", Offset = "0x1EE55A8", VA = "0x7BBC6E55A8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060097F6 RID: 38902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097F6")]
		[Address(RVA = "0x1EE55F8", Offset = "0x1EE55F8", VA = "0x7BBC6E55F8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060097F7 RID: 38903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097F7")]
		[Address(RVA = "0x1EE57E8", Offset = "0x1EE57E8", VA = "0x7BBC6E57E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060097F8 RID: 38904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097F8")]
		[Address(RVA = "0x1EE58B4", Offset = "0x1EE58B4", VA = "0x7BBC6E58B4")]
		private void OnSwitchFixedType()
		{
		}

		// Token: 0x060097F9 RID: 38905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097F9")]
		[Address(RVA = "0x1EE592C", Offset = "0x1EE592C", VA = "0x7BBC6E592C")]
		private void UpdateUIView(object[] data)
		{
		}

		// Token: 0x060097FA RID: 38906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097FA")]
		[Address(RVA = "0x1EE5AD4", Offset = "0x1EE5AD4", VA = "0x7BBC6E5AD4")]
		public UISPHudCameraLockToggleController()
		{
		}

		// Token: 0x0400A00B RID: 40971
		[Token(Token = "0x400A00B")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudCameraLockToggleView m_View;
	}
}
