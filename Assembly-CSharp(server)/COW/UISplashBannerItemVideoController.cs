using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BA3 RID: 7075
	[Token(Token = "0x2001BA3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA91C", Offset = "0x10FA91C")]
	internal class UISplashBannerItemVideoController : UIWebViewWindowBaseController
	{
		// Token: 0x060098B7 RID: 39095 RVA: 0x00028398 File Offset: 0x00026598
		[Token(Token = "0x60098B7")]
		[Address(RVA = "0x163A908", Offset = "0x163A908", VA = "0x7BBBE3A908")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060098B8 RID: 39096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098B8")]
		[Address(RVA = "0x163A958", Offset = "0x163A958", VA = "0x7BBBE3A958", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060098B9 RID: 39097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098B9")]
		[Address(RVA = "0x163AB54", Offset = "0x163AB54", VA = "0x7BBBE3AB54")]
		public void SetData(SplashBannerInfo info)
		{
		}

		// Token: 0x060098BA RID: 39098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098BA")]
		[Address(RVA = "0x163AC38", Offset = "0x163AC38", VA = "0x7BBBE3AC38")]
		public void OnTweenFinish()
		{
		}

		// Token: 0x060098BB RID: 39099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098BB")]
		[Address(RVA = "0x163ACD8", Offset = "0x163ACD8", VA = "0x7BBBE3ACD8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060098BC RID: 39100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098BC")]
		[Address(RVA = "0x163ADB4", Offset = "0x163ADB4", VA = "0x7BBBE3ADB4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060098BD RID: 39101 RVA: 0x000283B0 File Offset: 0x000265B0
		[Token(Token = "0x60098BD")]
		[Address(RVA = "0x163ADBC", Offset = "0x163ADBC", VA = "0x7BBBE3ADBC", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098BE")]
		[Address(RVA = "0x163ADC4", Offset = "0x163ADC4", VA = "0x7BBBE3ADC4")]
		private void OnGotoNavigation()
		{
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098BF")]
		[Address(RVA = "0x163AEE8", Offset = "0x163AEE8", VA = "0x7BBBE3AEE8")]
		public UISplashBannerItemVideoController()
		{
		}

		// Token: 0x0400A053 RID: 41043
		[Token(Token = "0x400A053")]
		[FieldOffset(Offset = "0xB0")]
		private UISplashBannerItemVideoView m_View;

		// Token: 0x0400A054 RID: 41044
		[Token(Token = "0x400A054")]
		[FieldOffset(Offset = "0xB8")]
		private SplashBannerInfo m_SplashBannerInfo;

		// Token: 0x0400A055 RID: 41045
		[Token(Token = "0x400A055")]
		[FieldOffset(Offset = "0xC0")]
		public Action<bool> m_UICloseCallBack;

		// Token: 0x0400A056 RID: 41046
		[Token(Token = "0x400A056")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_WillGotoNavigation;
	}
}
