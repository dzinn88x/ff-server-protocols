using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001940 RID: 6464
	[Token(Token = "0x2001940")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5DD4", Offset = "0x10F5DD4")]
	internal class UIHudQuitController : UIBaseController
	{
		// Token: 0x0600831A RID: 33562 RVA: 0x000239B8 File Offset: 0x00021BB8
		[Token(Token = "0x600831A")]
		[Address(RVA = "0x17E77C4", Offset = "0x17E77C4", VA = "0x7BBBFE77C4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600831B RID: 33563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600831B")]
		[Address(RVA = "0x17E7814", Offset = "0x17E7814", VA = "0x7BBBFE7814", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600831C RID: 33564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600831C")]
		[Address(RVA = "0x17E78F8", Offset = "0x17E78F8", VA = "0x7BBBFE78F8")]
		private void OnBtnDrop()
		{
		}

		// Token: 0x0600831D RID: 33565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600831D")]
		[Address(RVA = "0x17E79F8", Offset = "0x17E79F8", VA = "0x7BBBFE79F8")]
		public UIHudQuitController()
		{
		}

		// Token: 0x0400941B RID: 37915
		[Token(Token = "0x400941B")]
		[FieldOffset(Offset = "0x58")]
		private UIHudQuitView m_View;
	}
}
