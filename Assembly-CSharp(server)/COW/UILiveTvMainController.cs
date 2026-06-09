using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019E3 RID: 6627
	[Token(Token = "0x20019E3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7294", Offset = "0x10F7294")]
	public class UILiveTvMainController : UINavigationController
	{
		// Token: 0x060088E6 RID: 35046 RVA: 0x00024D20 File Offset: 0x00022F20
		[Token(Token = "0x60088E6")]
		[Address(RVA = "0x1CC3004", Offset = "0x1CC3004", VA = "0x7BBC4C3004", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060088E7 RID: 35047 RVA: 0x00024D38 File Offset: 0x00022F38
		[Token(Token = "0x60088E7")]
		[Address(RVA = "0x1CC300C", Offset = "0x1CC300C", VA = "0x7BBC4C300C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060088E8 RID: 35048 RVA: 0x00024D50 File Offset: 0x00022F50
		[Token(Token = "0x60088E8")]
		[Address(RVA = "0x1CC305C", Offset = "0x1CC305C", VA = "0x7BBC4C305C", Slot = "35")]
		public override EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x060088E9 RID: 35049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088E9")]
		[Address(RVA = "0x1CC3064", Offset = "0x1CC3064", VA = "0x7BBC4C3064", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060088EA RID: 35050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088EA")]
		[Address(RVA = "0x1CC379C", Offset = "0x1CC379C", VA = "0x7BBC4C379C", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x060088EB RID: 35051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088EB")]
		[Address(RVA = "0x1CC383C", Offset = "0x1CC383C", VA = "0x7BBC4C383C", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x060088EC RID: 35052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088EC")]
		[Address(RVA = "0x1CC387C", Offset = "0x1CC387C", VA = "0x7BBC4C387C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060088ED RID: 35053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088ED")]
		[Address(RVA = "0x1CC38D4", Offset = "0x1CC38D4", VA = "0x7BBC4C38D4")]
		private void OnBooyahTVBtnClick()
		{
		}

		// Token: 0x060088EE RID: 35054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088EE")]
		[Address(RVA = "0x1CC3A64", Offset = "0x1CC3A64", VA = "0x7BBC4C3A64")]
		private void OnLiveBtnClick()
		{
		}

		// Token: 0x060088EF RID: 35055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60088EF")]
		[Address(RVA = "0x1CC360C", Offset = "0x1CC360C", VA = "0x7BBC4C360C")]
		private WebView.Rect WebViewRect()
		{
			return null;
		}

		// Token: 0x060088F0 RID: 35056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088F0")]
		[Address(RVA = "0x1CC3BF4", Offset = "0x1CC3BF4", VA = "0x7BBC4C3BF4")]
		private void CloseNaviPop()
		{
		}

		// Token: 0x060088F1 RID: 35057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088F1")]
		[Address(RVA = "0x1CC3C90", Offset = "0x1CC3C90", VA = "0x7BBC4C3C90")]
		private void RefreshWebView()
		{
		}

		// Token: 0x060088F2 RID: 35058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088F2")]
		[Address(RVA = "0x1CC3CC0", Offset = "0x1CC3CC0", VA = "0x7BBC4C3CC0", Slot = "30")]
		protected override void OnPopupWindowListChange()
		{
		}

		// Token: 0x060088F3 RID: 35059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60088F3")]
		[Address(RVA = "0x1CC37E0", Offset = "0x1CC37E0", VA = "0x7BBC4C37E0")]
		private WebView CurrentWebView()
		{
			return null;
		}

		// Token: 0x060088F4 RID: 35060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088F4")]
		[Address(RVA = "0x1CC3DB0", Offset = "0x1CC3DB0", VA = "0x7BBC4C3DB0")]
		public UILiveTvMainController()
		{
		}

		// Token: 0x04009726 RID: 38694
		[Token(Token = "0x4009726")]
		[FieldOffset(Offset = "0xB0")]
		private UILiveTvView m_View;

		// Token: 0x04009727 RID: 38695
		[Token(Token = "0x4009727")]
		[FieldOffset(Offset = "0xB8")]
		private WebView m_WebViewLiveTV;

		// Token: 0x04009728 RID: 38696
		[Token(Token = "0x4009728")]
		[FieldOffset(Offset = "0xC0")]
		private WebView m_WebViewBooyahTv;

		// Token: 0x04009729 RID: 38697
		[Token(Token = "0x4009729")]
		[FieldOffset(Offset = "0xC8")]
		private WebView.Rect m_WebViewRect;
	}
}
