using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BF1 RID: 7153
	[Token(Token = "0x2001BF1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB34C", Offset = "0x10FB34C")]
	internal class UIWebViewWindowBaseController : UIPopupSpecialWindowController
	{
		// Token: 0x06009B62 RID: 39778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B62")]
		[Address(RVA = "0x1785D00", Offset = "0x1785D00", VA = "0x7BBBF85D00")]
		protected void OpenNativeWebView(string url, WebView.Rect rect)
		{
		}

		// Token: 0x06009B63 RID: 39779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B63")]
		[Address(RVA = "0x17866AC", Offset = "0x17866AC", VA = "0x7BBBF866AC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009B64 RID: 39780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B64")]
		[Address(RVA = "0x178675C", Offset = "0x178675C", VA = "0x7BBBF8675C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009B65 RID: 39781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B65")]
		[Address(RVA = "0x1786950", Offset = "0x1786950", VA = "0x7BBBF86950", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009B66 RID: 39782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B66")]
		[Address(RVA = "0x1786958", Offset = "0x1786958", VA = "0x7BBBF86958", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06009B67 RID: 39783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B67")]
		[Address(RVA = "0x1786A84", Offset = "0x1786A84", VA = "0x7BBBF86A84", Slot = "39")]
		public override void OnPopupWindowListChange()
		{
		}

		// Token: 0x06009B68 RID: 39784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B68")]
		[Address(RVA = "0x1786B20", Offset = "0x1786B20", VA = "0x7BBBF86B20")]
		public UIWebViewWindowBaseController()
		{
		}

		// Token: 0x0400A1BE RID: 41406
		[Token(Token = "0x400A1BE")]
		[FieldOffset(Offset = "0x98")]
		public Action CloseCallBack;

		// Token: 0x0400A1BF RID: 41407
		[Token(Token = "0x400A1BF")]
		[FieldOffset(Offset = "0xA0")]
		protected WebView m_WebView;

		// Token: 0x0400A1C0 RID: 41408
		[Token(Token = "0x400A1C0")]
		[FieldOffset(Offset = "0xA8")]
		public bool NeedResetBGM;

		// Token: 0x0400A1C1 RID: 41409
		[Token(Token = "0x400A1C1")]
		[FieldOffset(Offset = "0xAC")]
		private float volume;
	}
}
