using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02002006 RID: 8198
	[Token(Token = "0x2002006")]
	public class SplashBannerInfo
	{
		// Token: 0x0600B674 RID: 46708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B674")]
		[Address(RVA = "0x1B3F6A8", Offset = "0x1B3F6A8", VA = "0x7BBC33F6A8")]
		public static implicit operator SplashBannerInfo(SplashBannerDesc data)
		{
			return null;
		}

		// Token: 0x0600B675 RID: 46709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B675")]
		[Address(RVA = "0x1B3F864", Offset = "0x1B3F864", VA = "0x7BBC33F864")]
		public SplashBannerInfo()
		{
		}

		// Token: 0x0400B891 RID: 47249
		[Token(Token = "0x400B891")]
		[FieldOffset(Offset = "0x10")]
		public uint Id;

		// Token: 0x0400B892 RID: 47250
		[Token(Token = "0x400B892")]
		[FieldOffset(Offset = "0x14")]
		public uint Type;

		// Token: 0x0400B893 RID: 47251
		[Token(Token = "0x400B893")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x0400B894 RID: 47252
		[Token(Token = "0x400B894")]
		[FieldOffset(Offset = "0x20")]
		public uint SortId;

		// Token: 0x0400B895 RID: 47253
		[Token(Token = "0x400B895")]
		[FieldOffset(Offset = "0x28")]
		public string ImageUrl;

		// Token: 0x0400B896 RID: 47254
		[Token(Token = "0x400B896")]
		[FieldOffset(Offset = "0x30")]
		public uint GosPos;

		// Token: 0x0400B897 RID: 47255
		[Token(Token = "0x400B897")]
		[FieldOffset(Offset = "0x38")]
		public string GosUrl;

		// Token: 0x0400B898 RID: 47256
		[Token(Token = "0x400B898")]
		[FieldOffset(Offset = "0x40")]
		public bool UseEmbeddedBrowser;

		// Token: 0x0400B899 RID: 47257
		[Token(Token = "0x400B899")]
		[FieldOffset(Offset = "0x48")]
		public string SubGoPos;

		// Token: 0x0400B89A RID: 47258
		[Token(Token = "0x400B89A")]
		[FieldOffset(Offset = "0x50")]
		public string VideoUrl;

		// Token: 0x0400B89B RID: 47259
		[Token(Token = "0x400B89B")]
		[FieldOffset(Offset = "0x58")]
		public string BGImgUrl;

		// Token: 0x0400B89C RID: 47260
		[Token(Token = "0x400B89C")]
		[FieldOffset(Offset = "0x60")]
		public EAnnouncement.Platform Platform;

		// Token: 0x0400B89D RID: 47261
		[Token(Token = "0x400B89D")]
		[FieldOffset(Offset = "0x64")]
		public bool Showed;
	}
}
