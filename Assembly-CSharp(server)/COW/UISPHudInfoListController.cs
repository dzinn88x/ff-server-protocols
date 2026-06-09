using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B8F RID: 7055
	[Token(Token = "0x2001B8F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA5D4", Offset = "0x10FA5D4")]
	internal class UISPHudInfoListController : UIBaseHudInfoListController
	{
		// Token: 0x06009833 RID: 38963 RVA: 0x00028128 File Offset: 0x00026328
		[Token(Token = "0x6009833")]
		[Address(RVA = "0x1EE7C34", Offset = "0x1EE7C34", VA = "0x7BBC6E7C34")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009834 RID: 38964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009834")]
		[Address(RVA = "0x1EE7C84", Offset = "0x1EE7C84", VA = "0x7BBC6E7C84", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009835 RID: 38965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009835")]
		[Address(RVA = "0x1EE7F68", Offset = "0x1EE7F68", VA = "0x7BBC6E7F68")]
		public UISPHudInfoListController()
		{
		}

		// Token: 0x0400A024 RID: 40996
		[Token(Token = "0x400A024")]
		[FieldOffset(Offset = "0xA8")]
		protected UISPHudInfoListView m_View;
	}
}
