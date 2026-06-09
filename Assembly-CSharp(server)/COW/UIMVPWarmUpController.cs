using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020013AE RID: 5038
	[Token(Token = "0x20013AE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBAB8", Offset = "0x10EBAB8")]
	internal class UIMVPWarmUpController : UIPopupWindowController
	{
		// Token: 0x060051F6 RID: 20982 RVA: 0x00018AE0 File Offset: 0x00016CE0
		[Token(Token = "0x60051F6")]
		[Address(RVA = "0x1CDDF0C", Offset = "0x1CDDF0C", VA = "0x7BBC4DDF0C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F7")]
		[Address(RVA = "0x1CDDF5C", Offset = "0x1CDDF5C", VA = "0x7BBC4DDF5C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F8")]
		[Address(RVA = "0x1CDE1E8", Offset = "0x1CDE1E8", VA = "0x7BBC4DE1E8")]
		public UIMVPWarmUpController()
		{
		}

		// Token: 0x04007821 RID: 30753
		[Token(Token = "0x4007821")]
		[FieldOffset(Offset = "0x98")]
		private UIMVPWarmUpView m_View;
	}
}
