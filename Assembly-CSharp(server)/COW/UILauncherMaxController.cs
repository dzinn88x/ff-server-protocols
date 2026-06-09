using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019C7 RID: 6599
	[Token(Token = "0x20019C7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F704C", Offset = "0x10F704C")]
	public class UILauncherMaxController : UIPopupSpecialWindowController
	{
		// Token: 0x060087A3 RID: 34723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087A3")]
		[Address(RVA = "0x1E26208", Offset = "0x1E26208", VA = "0x7BBC626208", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060087A4 RID: 34724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087A4")]
		[Address(RVA = "0x1E2644C", Offset = "0x1E2644C", VA = "0x7BBC62644C")]
		private void OnGotoVideoBtnClick()
		{
		}

		// Token: 0x060087A5 RID: 34725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087A5")]
		[Address(RVA = "0x1E26830", Offset = "0x1E26830", VA = "0x7BBC626830")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x060087A6 RID: 34726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087A6")]
		[Address(RVA = "0x1E26874", Offset = "0x1E26874", VA = "0x7BBC626874")]
		public void SetOnClose(Action onclose)
		{
		}

		// Token: 0x060087A7 RID: 34727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087A7")]
		[Address(RVA = "0x1E2687C", Offset = "0x1E2687C", VA = "0x7BBC62687C")]
		public void SetInfo(string max_store, string max_web, string max_video)
		{
		}

		// Token: 0x060087A8 RID: 34728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087A8")]
		[Address(RVA = "0x1E26A04", Offset = "0x1E26A04", VA = "0x7BBC626A04")]
		private void OnGotoWebsiteBtnClick()
		{
		}

		// Token: 0x060087A9 RID: 34729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087A9")]
		[Address(RVA = "0x1E26A10", Offset = "0x1E26A10", VA = "0x7BBC626A10")]
		private void OnNormalUpdateBtnClick()
		{
		}

		// Token: 0x060087AA RID: 34730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087AA")]
		[Address(RVA = "0x1E26A70", Offset = "0x1E26A70", VA = "0x7BBC626A70")]
		private void OnMaxDownloadBtnClick()
		{
		}

		// Token: 0x060087AB RID: 34731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60087AB")]
		[Address(RVA = "0x1E26484", Offset = "0x1E26484", VA = "0x7BBC626484")]
		private UILauncherWebViewLiteController CreateVideoWebView()
		{
			return null;
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087AC")]
		[Address(RVA = "0x1E26A7C", Offset = "0x1E26A7C", VA = "0x7BBC626A7C")]
		public UILauncherMaxController()
		{
		}

		// Token: 0x04009624 RID: 38436
		[Token(Token = "0x4009624")]
		[FieldOffset(Offset = "0x98")]
		private UILauncherMaxView m_View;

		// Token: 0x04009625 RID: 38437
		[Token(Token = "0x4009625")]
		[FieldOffset(Offset = "0xA0")]
		private string m_MaxStore;

		// Token: 0x04009626 RID: 38438
		[Token(Token = "0x4009626")]
		[FieldOffset(Offset = "0xA8")]
		private string m_MaxWebsite;

		// Token: 0x04009627 RID: 38439
		[Token(Token = "0x4009627")]
		[FieldOffset(Offset = "0xB0")]
		private string m_MaxVideo;

		// Token: 0x04009628 RID: 38440
		[Token(Token = "0x4009628")]
		[FieldOffset(Offset = "0xB8")]
		protected Action m_OnClose;

		// Token: 0x04009629 RID: 38441
		[Token(Token = "0x4009629")]
		private const string BG_CDN_URL = "https://freefiremobile-a.akamaihd.net/common/OB23/version/Patch_Max_Bg_<FF_LANGUAGE>.png";
	}
}
