using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02002007 RID: 8199
	[Token(Token = "0x2002007")]
	public class UIModelSplashBanner : UIBaseModel
	{
		// Token: 0x0600B676 RID: 46710 RVA: 0x00034098 File Offset: 0x00032298
		[Token(Token = "0x600B676")]
		[Address(RVA = "0x2302E44", Offset = "0x2302E44", VA = "0x7BBCB02E44", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x0600B677 RID: 46711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8C")]
		public List<SplashBannerInfo> SplashBannerDataList
		{
			[Token(Token = "0x600B677")]
			[Address(RVA = "0x2302E4C", Offset = "0x2302E4C", VA = "0x7BBCB02E4C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x0600B678 RID: 46712 RVA: 0x000340B0 File Offset: 0x000322B0
		// (set) Token: 0x0600B679 RID: 46713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C8D")]
		public bool IsSplanBannerShowed
		{
			[Token(Token = "0x600B678")]
			[Address(RVA = "0x2302E54", Offset = "0x2302E54", VA = "0x7BBCB02E54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11475CC", Offset = "0x11475CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B679")]
			[Address(RVA = "0x2302E5C", Offset = "0x2302E5C", VA = "0x7BBCB02E5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11475DC", Offset = "0x11475DC")]
			set
			{
			}
		}

		// Token: 0x0600B67A RID: 46714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B67A")]
		[Address(RVA = "0x2302E68", Offset = "0x2302E68", VA = "0x7BBCB02E68", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B67B RID: 46715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B67B")]
		[Address(RVA = "0x2302E90", Offset = "0x2302E90", VA = "0x7BBCB02E90")]
		public HttpRequest RequestSplashBannerData()
		{
			return null;
		}

		// Token: 0x0600B67C RID: 46716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B67C")]
		[Address(RVA = "0x2302F38", Offset = "0x2302F38", VA = "0x7BBCB02F38")]
		public void SetSplashBannerData(HttpErrorCode errorCode, SplashBannerDescList res)
		{
		}

		// Token: 0x0600B67D RID: 46717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B67D")]
		[Address(RVA = "0x2303388", Offset = "0x2303388", VA = "0x7BBCB03388")]
		private void RandomPickSplashBannerByWeight(int maxCount, List<SplashBannerDesc> splashBanners)
		{
		}

		// Token: 0x0600B67E RID: 46718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B67E")]
		[Address(RVA = "0x230382C", Offset = "0x230382C", VA = "0x7BBCB0382C")]
		public SplashBannerInfo GetUnShowedSplash()
		{
			return null;
		}

		// Token: 0x0600B67F RID: 46719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B67F")]
		[Address(RVA = "0x230395C", Offset = "0x230395C", VA = "0x7BBCB0395C")]
		public UIModelSplashBanner()
		{
		}

		// Token: 0x0400B89E RID: 47262
		[Token(Token = "0x400B89E")]
		public const uint PropID_SplashBannerRetOK = 2U;

		// Token: 0x0400B89F RID: 47263
		[Token(Token = "0x400B89F")]
		public const uint PropID_SplashBannerRetFail = 4U;

		// Token: 0x0400B8A0 RID: 47264
		[Token(Token = "0x400B8A0")]
		public const uint PropID_SplashBannerRetEmpty = 4U;

		// Token: 0x0400B8A1 RID: 47265
		[Token(Token = "0x400B8A1")]
		public const uint PropID_SplashBannerGetInfo = 8U;

		// Token: 0x0400B8A2 RID: 47266
		[Token(Token = "0x400B8A2")]
		[FieldOffset(Offset = "0x18")]
		private List<SplashBannerInfo> m_SplashBannerDataList;

		// Token: 0x0400B8A3 RID: 47267
		[Token(Token = "0x400B8A3")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113073C", Offset = "0x113073C")]
		private bool <IsSplanBannerShowed>k__BackingField;

		// Token: 0x02002008 RID: 8200
		[Token(Token = "0x2002008")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD764", Offset = "0x10FD764")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B681 RID: 46721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B681")]
			[Address(RVA = "0x2303A50", Offset = "0x2303A50", VA = "0x7BBCB03A50")]
			public <>c()
			{
			}

			// Token: 0x0600B682 RID: 46722 RVA: 0x000340C8 File Offset: 0x000322C8
			[Token(Token = "0x600B682")]
			[Address(RVA = "0x2303A58", Offset = "0x2303A58", VA = "0x7BBCB03A58")]
			internal int <SetSplashBannerData>b__14_0(SplashBannerInfo a, SplashBannerInfo b)
			{
				return 0;
			}

			// Token: 0x0400B8A4 RID: 47268
			[Token(Token = "0x400B8A4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelSplashBanner.<>c <>9;

			// Token: 0x0400B8A5 RID: 47269
			[Token(Token = "0x400B8A5")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<SplashBannerInfo> <>9__14_0;
		}
	}
}
