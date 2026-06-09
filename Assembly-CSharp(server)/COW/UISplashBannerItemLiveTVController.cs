using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BA2 RID: 7074
	[Token(Token = "0x2001BA2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA8E4", Offset = "0x10FA8E4")]
	internal class UISplashBannerItemLiveTVController : UIWebViewWindowBaseController
	{
		// Token: 0x060098AC RID: 39084 RVA: 0x00028368 File Offset: 0x00026568
		[Token(Token = "0x60098AC")]
		[Address(RVA = "0x16396BC", Offset = "0x16396BC", VA = "0x7BBBE396BC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060098AD RID: 39085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098AD")]
		[Address(RVA = "0x163970C", Offset = "0x163970C", VA = "0x7BBBE3970C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060098AE RID: 39086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098AE")]
		[Address(RVA = "0x1639B08", Offset = "0x1639B08", VA = "0x7BBBE39B08")]
		public void SetData(SplashBannerInfo info)
		{
		}

		// Token: 0x060098AF RID: 39087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098AF")]
		[Address(RVA = "0x1639DA0", Offset = "0x1639DA0", VA = "0x7BBBE39DA0")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x060098B0 RID: 39088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098B0")]
		[Address(RVA = "0x163A180", Offset = "0x163A180", VA = "0x7BBBE3A180")]
		private void OnScaleTweenFinish()
		{
		}

		// Token: 0x060098B1 RID: 39089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098B1")]
		[Address(RVA = "0x163A188", Offset = "0x163A188", VA = "0x7BBBE3A188", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098B2")]
		[Address(RVA = "0x163A264", Offset = "0x163A264", VA = "0x7BBBE3A264", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060098B3 RID: 39091 RVA: 0x00028380 File Offset: 0x00026580
		[Token(Token = "0x60098B3")]
		[Address(RVA = "0x163A26C", Offset = "0x163A26C", VA = "0x7BBBE3A26C", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x060098B4 RID: 39092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098B4")]
		[Address(RVA = "0x163A274", Offset = "0x163A274", VA = "0x7BBBE3A274")]
		private void OnGotoNavigation()
		{
		}

		// Token: 0x060098B5 RID: 39093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098B5")]
		[Address(RVA = "0x163A398", Offset = "0x163A398", VA = "0x7BBBE3A398")]
		private void OnPlayFullScreen()
		{
		}

		// Token: 0x060098B6 RID: 39094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098B6")]
		[Address(RVA = "0x163A44C", Offset = "0x163A44C", VA = "0x7BBBE3A44C")]
		public UISplashBannerItemLiveTVController()
		{
		}

		// Token: 0x0400A04F RID: 41039
		[Token(Token = "0x400A04F")]
		[FieldOffset(Offset = "0xB0")]
		private UISplashBannerItemLiveTVView m_View;

		// Token: 0x0400A050 RID: 41040
		[Token(Token = "0x400A050")]
		[FieldOffset(Offset = "0xB8")]
		private SplashBannerInfo m_SplashBannerInfo;

		// Token: 0x0400A051 RID: 41041
		[Token(Token = "0x400A051")]
		[FieldOffset(Offset = "0xC0")]
		public Action<bool> m_UICloseCallBack;

		// Token: 0x0400A052 RID: 41042
		[Token(Token = "0x400A052")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_WillGotoNavigation;
	}
}
