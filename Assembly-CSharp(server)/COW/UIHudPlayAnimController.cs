using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200192B RID: 6443
	[Token(Token = "0x200192B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5AB4", Offset = "0x10F5AB4")]
	public class UIHudPlayAnimController : UIBaseController
	{
		// Token: 0x06008231 RID: 33329 RVA: 0x00023748 File Offset: 0x00021948
		[Token(Token = "0x6008231")]
		[Address(RVA = "0x1D74D54", Offset = "0x1D74D54", VA = "0x7BBC574D54")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008232 RID: 33330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008232")]
		[Address(RVA = "0x1D74DA4", Offset = "0x1D74DA4", VA = "0x7BBC574DA4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008233 RID: 33331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008233")]
		[Address(RVA = "0x1D74E88", Offset = "0x1D74E88", VA = "0x7BBC574E88")]
		protected void OnClick()
		{
		}

		// Token: 0x06008234 RID: 33332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008234")]
		[Address(RVA = "0x1D74F08", Offset = "0x1D74F08", VA = "0x7BBC574F08")]
		public UIHudPlayAnimController()
		{
		}

		// Token: 0x0400938D RID: 37773
		[Token(Token = "0x400938D")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPlayAnimView m_View;
	}
}
