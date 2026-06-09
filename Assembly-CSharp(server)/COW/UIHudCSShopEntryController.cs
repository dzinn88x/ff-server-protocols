using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014C3 RID: 5315
	[Token(Token = "0x20014C3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED7F4", Offset = "0x10ED7F4")]
	internal class UIHudCSShopEntryController : UIBaseController
	{
		// Token: 0x06005A67 RID: 23143 RVA: 0x0001A910 File Offset: 0x00018B10
		[Token(Token = "0x6005A67")]
		[Address(RVA = "0x19CE584", Offset = "0x19CE584", VA = "0x7BBC1CE584")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A68")]
		[Address(RVA = "0x19CE5D4", Offset = "0x19CE5D4", VA = "0x7BBC1CE5D4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005A69 RID: 23145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A69")]
		[Address(RVA = "0x19CE6B8", Offset = "0x19CE6B8", VA = "0x7BBC1CE6B8")]
		private void OnShopBtnClick()
		{
		}

		// Token: 0x06005A6A RID: 23146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6A")]
		[Address(RVA = "0x19CE91C", Offset = "0x19CE91C", VA = "0x7BBC1CE91C")]
		public UIHudCSShopEntryController()
		{
		}

		// Token: 0x04007D61 RID: 32097
		[Token(Token = "0x4007D61")]
		[FieldOffset(Offset = "0x58")]
		private UIHudCSShopEntryView m_View;
	}
}
