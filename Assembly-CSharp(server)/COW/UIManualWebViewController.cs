using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A5F RID: 6751
	[Token(Token = "0x2001A5F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8084", Offset = "0x10F8084")]
	internal class UIManualWebViewController : UIWebViewWindowBaseController
	{
		// Token: 0x06008E15 RID: 36373 RVA: 0x00025EC0 File Offset: 0x000240C0
		[Token(Token = "0x6008E15")]
		[Address(RVA = "0x18EB5F4", Offset = "0x18EB5F4", VA = "0x7BBC0EB5F4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008E16 RID: 36374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E16")]
		[Address(RVA = "0x18EB644", Offset = "0x18EB644", VA = "0x7BBC0EB644", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008E17 RID: 36375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E17")]
		[Address(RVA = "0x18EB7B0", Offset = "0x18EB7B0", VA = "0x7BBC0EB7B0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008E18 RID: 36376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E18")]
		[Address(RVA = "0x18EB85C", Offset = "0x18EB85C", VA = "0x7BBC0EB85C")]
		private void OnCloseButtonClick()
		{
		}

		// Token: 0x06008E19 RID: 36377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E19")]
		[Address(RVA = "0x18EB968", Offset = "0x18EB968", VA = "0x7BBC0EB968")]
		public UIManualWebViewController()
		{
		}

		// Token: 0x06008E1A RID: 36378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E1A")]
		[Address(RVA = "0x18EB970", Offset = "0x18EB970", VA = "0x7BBC0EB970")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144600", Offset = "0x1144600")]
		private void <OnUIInit>b__3_0()
		{
		}

		// Token: 0x040099D2 RID: 39378
		[Token(Token = "0x40099D2")]
		[FieldOffset(Offset = "0xB0")]
		private UIManualWebViewView m_View;

		// Token: 0x040099D3 RID: 39379
		[Token(Token = "0x40099D3")]
		[FieldOffset(Offset = "0xB8")]
		private uint m_UpdateDelayCallId;
	}
}
