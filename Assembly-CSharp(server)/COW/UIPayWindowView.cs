using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002487 RID: 9351
	[Token(Token = "0x2002487")]
	internal class UIPayWindowView : UIBaseView
	{
		// Token: 0x0600C41E RID: 50206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C41E")]
		[Address(RVA = "0x16EF6B4", Offset = "0x16EF6B4", VA = "0x7BBBEEF6B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C41F RID: 50207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C41F")]
		[Address(RVA = "0x16EFA94", Offset = "0x16EFA94", VA = "0x7BBBEEFA94")]
		public UIPayWindowView()
		{
		}

		// Token: 0x0400EAFD RID: 60157
		[Token(Token = "0x400EAFD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton RebateCardButton;

		// Token: 0x0400EAFE RID: 60158
		[Token(Token = "0x400EAFE")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400EAFF RID: 60159
		[Token(Token = "0x400EAFF")]
		[FieldOffset(Offset = "0x30")]
		public UISprite bg;

		// Token: 0x0400EB00 RID: 60160
		[Token(Token = "0x400EB00")]
		[FieldOffset(Offset = "0x38")]
		public UINetworkTextureExt MainAdNetworkTexture;

		// Token: 0x0400EB01 RID: 60161
		[Token(Token = "0x400EB01")]
		[FieldOffset(Offset = "0x40")]
		public UIButton MainAdButton;

		// Token: 0x0400EB02 RID: 60162
		[Token(Token = "0x400EB02")]
		[FieldOffset(Offset = "0x48")]
		public GameObject IOSPayContainer;

		// Token: 0x0400EB03 RID: 60163
		[Token(Token = "0x400EB03")]
		[FieldOffset(Offset = "0x50")]
		public UIScrollView IOSPayScrollview;

		// Token: 0x0400EB04 RID: 60164
		[Token(Token = "0x400EB04")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid IOSPayGrid;

		// Token: 0x0400EB05 RID: 60165
		[Token(Token = "0x400EB05")]
		[FieldOffset(Offset = "0x60")]
		public GameObject AndroidPayContainer;

		// Token: 0x0400EB06 RID: 60166
		[Token(Token = "0x400EB06")]
		[FieldOffset(Offset = "0x68")]
		public UIButton AndroidBtn1;

		// Token: 0x0400EB07 RID: 60167
		[Token(Token = "0x400EB07")]
		[FieldOffset(Offset = "0x70")]
		public UINetworkTextureExt AndroidImage1;

		// Token: 0x0400EB08 RID: 60168
		[Token(Token = "0x400EB08")]
		[FieldOffset(Offset = "0x78")]
		public UIButton AndroidBtn2;

		// Token: 0x0400EB09 RID: 60169
		[Token(Token = "0x400EB09")]
		[FieldOffset(Offset = "0x80")]
		public UINetworkTextureExt AndroidImage2;

		// Token: 0x0400EB0A RID: 60170
		[Token(Token = "0x400EB0A")]
		[FieldOffset(Offset = "0x88")]
		public UIButton AndroidBtn3;

		// Token: 0x0400EB0B RID: 60171
		[Token(Token = "0x400EB0B")]
		[FieldOffset(Offset = "0x90")]
		public UINetworkTextureExt AndroidImage3;
	}
}
