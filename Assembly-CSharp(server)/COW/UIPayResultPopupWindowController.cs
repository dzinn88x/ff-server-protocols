using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AE3 RID: 6883
	[Token(Token = "0x2001AE3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8D7C", Offset = "0x10F8D7C")]
	internal class UIPayResultPopupWindowController : UIPopupMessageBoxController
	{
		// Token: 0x060091D6 RID: 37334 RVA: 0x00026D30 File Offset: 0x00024F30
		[Token(Token = "0x60091D6")]
		[Address(RVA = "0x16EC924", Offset = "0x16EC924", VA = "0x7BBBEEC924")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091D7")]
		[Address(RVA = "0x16EC974", Offset = "0x16EC974", VA = "0x7BBBEEC974", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060091D8 RID: 37336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091D8")]
		[Address(RVA = "0x16ECA98", Offset = "0x16ECA98", VA = "0x7BBBEECA98")]
		public void SetNote(string note)
		{
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091D9")]
		[Address(RVA = "0x16ECB4C", Offset = "0x16ECB4C", VA = "0x7BBBEECB4C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060091DA RID: 37338 RVA: 0x00026D48 File Offset: 0x00024F48
		[Token(Token = "0x60091DA")]
		[Address(RVA = "0x16ECBAC", Offset = "0x16ECBAC", VA = "0x7BBBEECBAC", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x060091DB RID: 37339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091DB")]
		[Address(RVA = "0x16ECBB4", Offset = "0x16ECBB4", VA = "0x7BBBEECBB4")]
		public UIPayResultPopupWindowController()
		{
		}

		// Token: 0x04009CAF RID: 40111
		[Token(Token = "0x4009CAF")]
		[FieldOffset(Offset = "0x0")]
		private static UIPayResultPopupWindowController _Current;

		// Token: 0x04009CB0 RID: 40112
		[Token(Token = "0x4009CB0")]
		[FieldOffset(Offset = "0xC8")]
		private UIPayResultPopupWindowView m_View;
	}
}
