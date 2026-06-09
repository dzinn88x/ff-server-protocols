using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BC1 RID: 7105
	[Token(Token = "0x2001BC1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAC84", Offset = "0x10FAC84")]
	internal class UITutorialWebviewController : UIWebViewWindowBaseController
	{
		// Token: 0x06009996 RID: 39318 RVA: 0x000286E0 File Offset: 0x000268E0
		[Token(Token = "0x6009996")]
		[Address(RVA = "0x19FAE00", Offset = "0x19FAE00", VA = "0x7BBC1FAE00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009997 RID: 39319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009997")]
		[Address(RVA = "0x19FAE50", Offset = "0x19FAE50", VA = "0x7BBC1FAE50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009998 RID: 39320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009998")]
		[Address(RVA = "0x19FAEF4", Offset = "0x19FAEF4", VA = "0x7BBC1FAEF4")]
		public void SetData(string url, string title)
		{
		}

		// Token: 0x06009999 RID: 39321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009999")]
		[Address(RVA = "0x19FAFB8", Offset = "0x19FAFB8", VA = "0x7BBC1FAFB8")]
		public UITutorialWebviewController()
		{
		}

		// Token: 0x0400A0CB RID: 41163
		[Token(Token = "0x400A0CB")]
		[FieldOffset(Offset = "0xB0")]
		private UITutorialWebViewView m_View;
	}
}
