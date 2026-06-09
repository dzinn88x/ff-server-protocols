using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200180B RID: 6155
	[Token(Token = "0x200180B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3494", Offset = "0x10F3494")]
	internal class UIGachaLimitRuleShowWndController : UIPopupWindowController
	{
		// Token: 0x060077B3 RID: 30643 RVA: 0x00021150 File Offset: 0x0001F350
		[Token(Token = "0x60077B3")]
		[Address(RVA = "0x2066668", Offset = "0x2066668", VA = "0x7BBC866668")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077B4")]
		[Address(RVA = "0x20666B8", Offset = "0x20666B8", VA = "0x7BBC8666B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077B5")]
		[Address(RVA = "0x205F8D4", Offset = "0x205F8D4", VA = "0x7BBC85F8D4")]
		public void SetViewData(string rareProbability, string priceLine)
		{
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077B6")]
		[Address(RVA = "0x206671C", Offset = "0x206671C", VA = "0x7BBC86671C")]
		public UIGachaLimitRuleShowWndController()
		{
		}

		// Token: 0x04008E04 RID: 36356
		[Token(Token = "0x4008E04")]
		[FieldOffset(Offset = "0x98")]
		private UIGachaLimitRuleShowWndView m_View;
	}
}
