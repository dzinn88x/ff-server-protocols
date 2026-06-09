using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001956 RID: 6486
	[Token(Token = "0x2001956")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F60A4", Offset = "0x10F60A4")]
	internal class UIHudShowCaseIntroductionController : UIBaseController
	{
		// Token: 0x060083AF RID: 33711 RVA: 0x00023C58 File Offset: 0x00021E58
		[Token(Token = "0x60083AF")]
		[Address(RVA = "0x1664968", Offset = "0x1664968", VA = "0x7BBBE64968")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060083B0 RID: 33712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083B0")]
		[Address(RVA = "0x16649B8", Offset = "0x16649B8", VA = "0x7BBBE649B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060083B1 RID: 33713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083B1")]
		[Address(RVA = "0x1664A9C", Offset = "0x1664A9C", VA = "0x7BBBE64A9C")]
		private void OnBtnClose()
		{
		}

		// Token: 0x060083B2 RID: 33714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083B2")]
		[Address(RVA = "0x1664AAC", Offset = "0x1664AAC", VA = "0x7BBBE64AAC")]
		public void UpdateContent(string title, string content)
		{
		}

		// Token: 0x060083B3 RID: 33715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083B3")]
		[Address(RVA = "0x1664B34", Offset = "0x1664B34", VA = "0x7BBBE64B34")]
		public UIHudShowCaseIntroductionController()
		{
		}

		// Token: 0x04009462 RID: 37986
		[Token(Token = "0x4009462")]
		[FieldOffset(Offset = "0x58")]
		private UIHudShowCaseIntroductionView m_View;
	}
}
