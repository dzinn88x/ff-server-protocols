using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C9A RID: 7322
	[Token(Token = "0x2001C9A")]
	public class UINetworkTextureExt : UINetworkTexture
	{
		// Token: 0x06009FC1 RID: 40897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FC1")]
		[Address(RVA = "0x1AF2BBC", Offset = "0x1AF2BBC", VA = "0x7BBC2F2BBC")]
		public void SetAsyncImageFromUrl(string url, bool isMakePerfect = false, bool showLoading = false, bool adjustLoadingDepth = false)
		{
		}

		// Token: 0x06009FC2 RID: 40898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FC2")]
		[Address(RVA = "0x1AF2EF8", Offset = "0x1AF2EF8", VA = "0x7BBC2F2EF8", Slot = "5")]
		public override void OnDowloadFinished(Texture texture)
		{
		}

		// Token: 0x06009FC3 RID: 40899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FC3")]
		[Address(RVA = "0x1AF30A4", Offset = "0x1AF30A4", VA = "0x7BBC2F30A4")]
		public UINetworkTextureExt()
		{
		}

		// Token: 0x0400A67B RID: 42619
		[Token(Token = "0x400A67B")]
		[FieldOffset(Offset = "0x50")]
		public UISprite LoadingMask;

		// Token: 0x0400A67C RID: 42620
		[Token(Token = "0x400A67C")]
		[FieldOffset(Offset = "0x58")]
		public UISprite Loading;

		// Token: 0x0400A67D RID: 42621
		[Token(Token = "0x400A67D")]
		[FieldOffset(Offset = "0x60")]
		public Action<Texture> Callback;
	}
}
