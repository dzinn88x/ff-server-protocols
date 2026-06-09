using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001668 RID: 5736
	[Token(Token = "0x2001668")]
	public class UIMorePlatformSettingController : UIBaseController
	{
		// Token: 0x060067BD RID: 26557 RVA: 0x0001D808 File Offset: 0x0001BA08
		[Token(Token = "0x60067BD")]
		[Address(RVA = "0x14CA1FC", Offset = "0x14CA1FC", VA = "0x7BBBCCA1FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060067BE RID: 26558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067BE")]
		[Address(RVA = "0x14CA24C", Offset = "0x14CA24C", VA = "0x7BBBCCA24C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060067BF RID: 26559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067BF")]
		[Address(RVA = "0x14CA920", Offset = "0x14CA920", VA = "0x7BBBCCA920", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060067C0 RID: 26560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C0")]
		[Address(RVA = "0x14CA9EC", Offset = "0x14CA9EC", VA = "0x7BBBCCA9EC")]
		public void SetViewData(MorePlatformPageType pageType, bool showFb, bool showVK, bool showHw, bool showGoogle, bool showApple, bool showTwitter)
		{
		}

		// Token: 0x060067C1 RID: 26561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C1")]
		[Address(RVA = "0x14CB020", Offset = "0x14CB020", VA = "0x7BBBCCB020")]
		private void OnFacebookBindClick()
		{
		}

		// Token: 0x060067C2 RID: 26562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C2")]
		[Address(RVA = "0x14CB054", Offset = "0x14CB054", VA = "0x7BBBCCB054")]
		private void OnAppleBindClick()
		{
		}

		// Token: 0x060067C3 RID: 26563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C3")]
		[Address(RVA = "0x14CB088", Offset = "0x14CB088", VA = "0x7BBBCCB088")]
		private void OnVKontakteBindClick()
		{
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C4")]
		[Address(RVA = "0x14CB0BC", Offset = "0x14CB0BC", VA = "0x7BBBCCB0BC")]
		private void OnTwitterBindClick()
		{
		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C5")]
		[Address(RVA = "0x14CB0F0", Offset = "0x14CB0F0", VA = "0x7BBBCCB0F0")]
		private void OnHuaweiBindClick()
		{
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C6")]
		[Address(RVA = "0x14CB15C", Offset = "0x14CB15C", VA = "0x7BBBCCB15C")]
		private void OnGoogleBindClick()
		{
		}

		// Token: 0x060067C7 RID: 26567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C7")]
		[Address(RVA = "0x14CB190", Offset = "0x14CB190", VA = "0x7BBBCCB190")]
		private void OnMouseClick(params object[] data)
		{
		}

		// Token: 0x060067C8 RID: 26568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C8")]
		[Address(RVA = "0x14CB254", Offset = "0x14CB254", VA = "0x7BBBCCB254")]
		public UIMorePlatformSettingController()
		{
		}

		// Token: 0x060067C9 RID: 26569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C9")]
		[Address(RVA = "0x14CB25C", Offset = "0x14CB25C", VA = "0x7BBBCCB25C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1140B1C", Offset = "0x1140B1C")]
		private void <OnMouseClick>b__13_0()
		{
		}

		// Token: 0x040084F0 RID: 34032
		[Token(Token = "0x40084F0")]
		[FieldOffset(Offset = "0x58")]
		private UIMorePlatformSettingView m_View;

		// Token: 0x040084F1 RID: 34033
		[Token(Token = "0x40084F1")]
		[FieldOffset(Offset = "0x60")]
		private UIModelLogin m_LoginModel;

		// Token: 0x040084F2 RID: 34034
		[Token(Token = "0x40084F2")]
		private const int m_BgAdditionalHeight = 30;
	}
}
