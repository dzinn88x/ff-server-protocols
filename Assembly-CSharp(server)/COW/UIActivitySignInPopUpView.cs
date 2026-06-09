using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020E9 RID: 8425
	[Token(Token = "0x20020E9")]
	public class UIActivitySignInPopUpView : UIBaseView
	{
		// Token: 0x0600BCE3 RID: 48355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE3")]
		[Address(RVA = "0x195E464", Offset = "0x195E464", VA = "0x7BBC15E464", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCE4 RID: 48356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE4")]
		[Address(RVA = "0x195E7C8", Offset = "0x195E7C8", VA = "0x7BBC15E7C8")]
		public UIActivitySignInPopUpView()
		{
		}

		// Token: 0x0400BF42 RID: 48962
		[Token(Token = "0x400BF42")]
		[FieldOffset(Offset = "0x20")]
		public UILabel TimeLabel;

		// Token: 0x0400BF43 RID: 48963
		[Token(Token = "0x400BF43")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LabelEndTime;

		// Token: 0x0400BF44 RID: 48964
		[Token(Token = "0x400BF44")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView ListScrollView;

		// Token: 0x0400BF45 RID: 48965
		[Token(Token = "0x400BF45")]
		[FieldOffset(Offset = "0x38")]
		public Transform ItemContainer1;

		// Token: 0x0400BF46 RID: 48966
		[Token(Token = "0x400BF46")]
		[FieldOffset(Offset = "0x40")]
		public Transform ItemContainer2;

		// Token: 0x0400BF47 RID: 48967
		[Token(Token = "0x400BF47")]
		[FieldOffset(Offset = "0x48")]
		public Transform ItemContainer3;

		// Token: 0x0400BF48 RID: 48968
		[Token(Token = "0x400BF48")]
		[FieldOffset(Offset = "0x50")]
		public Transform ItemContainer4;

		// Token: 0x0400BF49 RID: 48969
		[Token(Token = "0x400BF49")]
		[FieldOffset(Offset = "0x58")]
		public Transform ItemContainer5;

		// Token: 0x0400BF4A RID: 48970
		[Token(Token = "0x400BF4A")]
		[FieldOffset(Offset = "0x60")]
		public Transform ItemContainer6;

		// Token: 0x0400BF4B RID: 48971
		[Token(Token = "0x400BF4B")]
		[FieldOffset(Offset = "0x68")]
		public Transform ItemContainer7;

		// Token: 0x0400BF4C RID: 48972
		[Token(Token = "0x400BF4C")]
		[FieldOffset(Offset = "0x70")]
		public UINetworkTextureExt NetworkTexture;

		// Token: 0x0400BF4D RID: 48973
		[Token(Token = "0x400BF4D")]
		[FieldOffset(Offset = "0x78")]
		public UILabel DescTitle;

		// Token: 0x0400BF4E RID: 48974
		[Token(Token = "0x400BF4E")]
		[FieldOffset(Offset = "0x80")]
		public UIButton CloseBtn;
	}
}
