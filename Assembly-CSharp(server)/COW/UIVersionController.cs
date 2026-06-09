using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BC5 RID: 7109
	[Token(Token = "0x2001BC5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAD3C", Offset = "0x10FAD3C")]
	internal class UIVersionController : UIBaseController
	{
		// Token: 0x060099B7 RID: 39351 RVA: 0x00028758 File Offset: 0x00026958
		[Token(Token = "0x60099B7")]
		[Address(RVA = "0x1A09CE8", Offset = "0x1A09CE8", VA = "0x7BBC209CE8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060099B8 RID: 39352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099B8")]
		[Address(RVA = "0x1A09D38", Offset = "0x1A09D38", VA = "0x7BBC209D38", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060099B9 RID: 39353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099B9")]
		[Address(RVA = "0x1A09E10", Offset = "0x1A09E10", VA = "0x7BBC209E10")]
		public UIVersionController()
		{
		}

		// Token: 0x0400A0E1 RID: 41185
		[Token(Token = "0x400A0E1")]
		[FieldOffset(Offset = "0x58")]
		private UIVersionView m_View;
	}
}
