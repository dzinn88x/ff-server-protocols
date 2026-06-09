using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BA1 RID: 7073
	[Token(Token = "0x2001BA1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA8AC", Offset = "0x10FA8AC")]
	internal class UISplashBannerItemCDNController : UIPopupWindowController
	{
		// Token: 0x060098A4 RID: 39076 RVA: 0x00028338 File Offset: 0x00026538
		[Token(Token = "0x60098A4")]
		[Address(RVA = "0x1639100", Offset = "0x1639100", VA = "0x7BBBE39100")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A5")]
		[Address(RVA = "0x1639150", Offset = "0x1639150", VA = "0x7BBBE39150", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A6")]
		[Address(RVA = "0x163928C", Offset = "0x163928C", VA = "0x7BBBE3928C")]
		public void SetData(SplashBannerInfo info)
		{
		}

		// Token: 0x060098A7 RID: 39079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A7")]
		[Address(RVA = "0x1639368", Offset = "0x1639368", VA = "0x7BBBE39368", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060098A8 RID: 39080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098A8")]
		[Address(RVA = "0x16393D8", Offset = "0x16393D8", VA = "0x7BBBE393D8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x00028350 File Offset: 0x00026550
		[Token(Token = "0x60098A9")]
		[Address(RVA = "0x16393E0", Offset = "0x16393E0", VA = "0x7BBBE393E0", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098AA")]
		[Address(RVA = "0x16393E8", Offset = "0x16393E8", VA = "0x7BBBE393E8")]
		private void OnGotoNavigation()
		{
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098AB")]
		[Address(RVA = "0x16394BC", Offset = "0x16394BC", VA = "0x7BBBE394BC")]
		public UISplashBannerItemCDNController()
		{
		}

		// Token: 0x0400A04C RID: 41036
		[Token(Token = "0x400A04C")]
		[FieldOffset(Offset = "0x98")]
		private UISplashBannerItemCDNView m_View;

		// Token: 0x0400A04D RID: 41037
		[Token(Token = "0x400A04D")]
		[FieldOffset(Offset = "0xA0")]
		private SplashBannerInfo m_SplashBannerInfo;

		// Token: 0x0400A04E RID: 41038
		[Token(Token = "0x400A04E")]
		[FieldOffset(Offset = "0xA8")]
		public Action<bool> m_UICloseCallBack;
	}
}
