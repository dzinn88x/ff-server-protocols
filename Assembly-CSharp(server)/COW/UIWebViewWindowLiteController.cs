using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BF3 RID: 7155
	[Token(Token = "0x2001BF3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB3BC", Offset = "0x10FB3BC")]
	internal class UIWebViewWindowLiteController : UIWebViewWindowBaseController
	{
		// Token: 0x06009B78 RID: 39800 RVA: 0x00028DA0 File Offset: 0x00026FA0
		[Token(Token = "0x6009B78")]
		[Address(RVA = "0x1787D9C", Offset = "0x1787D9C", VA = "0x7BBBF87D9C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009B79 RID: 39801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B79")]
		[Address(RVA = "0x1787DEC", Offset = "0x1787DEC", VA = "0x7BBBF87DEC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009B7A RID: 39802 RVA: 0x00028DB8 File Offset: 0x00026FB8
		[Token(Token = "0x6009B7A")]
		[Address(RVA = "0x1787F94", Offset = "0x1787F94", VA = "0x7BBBF87F94", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x06009B7B RID: 39803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B7B")]
		[Address(RVA = "0x1787F9C", Offset = "0x1787F9C", VA = "0x7BBBF87F9C")]
		public void SetData(string url)
		{
		}

		// Token: 0x06009B7C RID: 39804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B7C")]
		[Address(RVA = "0x1788028", Offset = "0x1788028", VA = "0x7BBBF88028", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009B7D RID: 39805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B7D")]
		[Address(RVA = "0x17880D4", Offset = "0x17880D4", VA = "0x7BBBF880D4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009B7E RID: 39806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B7E")]
		[Address(RVA = "0x178817C", Offset = "0x178817C", VA = "0x7BBBF8817C")]
		private void OnCloseButtonClick()
		{
		}

		// Token: 0x06009B7F RID: 39807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B7F")]
		[Address(RVA = "0x1788224", Offset = "0x1788224", VA = "0x7BBBF88224")]
		public UIWebViewWindowLiteController()
		{
		}

		// Token: 0x06009B80 RID: 39808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B80")]
		[Address(RVA = "0x1788228", Offset = "0x1788228", VA = "0x7BBBF88228")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145244", Offset = "0x1145244")]
		private void <OnUIInit>b__3_0()
		{
		}

		// Token: 0x0400A1C9 RID: 41417
		[Token(Token = "0x400A1C9")]
		[FieldOffset(Offset = "0xB0")]
		private UIWebViewWindowLiteView m_View;

		// Token: 0x0400A1CA RID: 41418
		[Token(Token = "0x400A1CA")]
		[FieldOffset(Offset = "0xB8")]
		private uint m_UpdateDelayCallId;
	}
}
