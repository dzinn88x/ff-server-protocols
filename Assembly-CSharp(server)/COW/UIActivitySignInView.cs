using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020EA RID: 8426
	[Token(Token = "0x20020EA")]
	internal class UIActivitySignInView : UIBaseView
	{
		// Token: 0x0600BCE5 RID: 48357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE5")]
		[Address(RVA = "0x195E7D0", Offset = "0x195E7D0", VA = "0x7BBC15E7D0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCE6 RID: 48358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE6")]
		[Address(RVA = "0x195EB04", Offset = "0x195EB04", VA = "0x7BBC15EB04")]
		public UIActivitySignInView()
		{
		}

		// Token: 0x0400BF4F RID: 48975
		[Token(Token = "0x400BF4F")]
		[FieldOffset(Offset = "0x20")]
		public UILabel TimeLabel;

		// Token: 0x0400BF50 RID: 48976
		[Token(Token = "0x400BF50")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LabelEndTime;

		// Token: 0x0400BF51 RID: 48977
		[Token(Token = "0x400BF51")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView ListScrollView;

		// Token: 0x0400BF52 RID: 48978
		[Token(Token = "0x400BF52")]
		[FieldOffset(Offset = "0x38")]
		public Transform ItemContainer1;

		// Token: 0x0400BF53 RID: 48979
		[Token(Token = "0x400BF53")]
		[FieldOffset(Offset = "0x40")]
		public Transform ItemContainer2;

		// Token: 0x0400BF54 RID: 48980
		[Token(Token = "0x400BF54")]
		[FieldOffset(Offset = "0x48")]
		public Transform ItemContainer3;

		// Token: 0x0400BF55 RID: 48981
		[Token(Token = "0x400BF55")]
		[FieldOffset(Offset = "0x50")]
		public Transform ItemContainer4;

		// Token: 0x0400BF56 RID: 48982
		[Token(Token = "0x400BF56")]
		[FieldOffset(Offset = "0x58")]
		public Transform ItemContainer5;

		// Token: 0x0400BF57 RID: 48983
		[Token(Token = "0x400BF57")]
		[FieldOffset(Offset = "0x60")]
		public Transform ItemContainer6;

		// Token: 0x0400BF58 RID: 48984
		[Token(Token = "0x400BF58")]
		[FieldOffset(Offset = "0x68")]
		public Transform ItemContainer7;

		// Token: 0x0400BF59 RID: 48985
		[Token(Token = "0x400BF59")]
		[FieldOffset(Offset = "0x70")]
		public UINetworkTextureExt NetworkTexture;

		// Token: 0x0400BF5A RID: 48986
		[Token(Token = "0x400BF5A")]
		[FieldOffset(Offset = "0x78")]
		public UILabel DescTitle;
	}
}
