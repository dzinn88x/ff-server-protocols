using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200172A RID: 5930
	[Token(Token = "0x200172A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F19F4", Offset = "0x10F19F4")]
	public class UIClanRuleController : UIPopupWindowController
	{
		// Token: 0x06006ED8 RID: 28376 RVA: 0x0001F2D8 File Offset: 0x0001D4D8
		[Token(Token = "0x6006ED8")]
		[Address(RVA = "0x1CFF648", Offset = "0x1CFF648", VA = "0x7BBC4FF648")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED9")]
		[Address(RVA = "0x1CFF698", Offset = "0x1CFF698", VA = "0x7BBC4FF698", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EDA")]
		[Address(RVA = "0x1CFF7D4", Offset = "0x1CFF7D4", VA = "0x7BBC4FF7D4")]
		public UIClanRuleController()
		{
		}

		// Token: 0x04008939 RID: 35129
		[Token(Token = "0x4008939")]
		[FieldOffset(Offset = "0x98")]
		private UIClanRuleView m_View;
	}
}
