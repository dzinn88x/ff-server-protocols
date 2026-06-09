using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001955 RID: 6485
	[Token(Token = "0x2001955")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F606C", Offset = "0x10F606C")]
	public class UIHudSettingController : UIBaseController
	{
		// Token: 0x060083AB RID: 33707 RVA: 0x00023C40 File Offset: 0x00021E40
		[Token(Token = "0x60083AB")]
		[Address(RVA = "0x16646CC", Offset = "0x16646CC", VA = "0x7BBBE646CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060083AC RID: 33708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083AC")]
		[Address(RVA = "0x166471C", Offset = "0x166471C", VA = "0x7BBBE6471C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060083AD RID: 33709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083AD")]
		[Address(RVA = "0x1664800", Offset = "0x1664800", VA = "0x7BBBE64800")]
		private void OnBtnClick()
		{
		}

		// Token: 0x060083AE RID: 33710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083AE")]
		[Address(RVA = "0x16648BC", Offset = "0x16648BC", VA = "0x7BBBE648BC")]
		public UIHudSettingController()
		{
		}

		// Token: 0x04009461 RID: 37985
		[Token(Token = "0x4009461")]
		[FieldOffset(Offset = "0x58")]
		private UIHudSettingView m_View;
	}
}
