using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020E3 RID: 8419
	[Token(Token = "0x20020E3")]
	internal class UIActivityOverviewItemView : UIBaseView
	{
		// Token: 0x0600BCD7 RID: 48343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD7")]
		[Address(RVA = "0x1957F90", Offset = "0x1957F90", VA = "0x7BBC157F90", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCD8 RID: 48344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD8")]
		[Address(RVA = "0x1958260", Offset = "0x1958260", VA = "0x7BBC158260")]
		public UIActivityOverviewItemView()
		{
		}

		// Token: 0x0400BF1F RID: 48927
		[Token(Token = "0x400BF1F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIActivityOverviewItem;

		// Token: 0x0400BF20 RID: 48928
		[Token(Token = "0x400BF20")]
		[FieldOffset(Offset = "0x28")]
		public UIButton LittleGoTo;

		// Token: 0x0400BF21 RID: 48929
		[Token(Token = "0x400BF21")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BtnTitle;

		// Token: 0x0400BF22 RID: 48930
		[Token(Token = "0x400BF22")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GoToRedpoint;

		// Token: 0x0400BF23 RID: 48931
		[Token(Token = "0x400BF23")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Title;

		// Token: 0x0400BF24 RID: 48932
		[Token(Token = "0x400BF24")]
		[FieldOffset(Offset = "0x48")]
		public UINetworkTexture BGCDN;

		// Token: 0x0400BF25 RID: 48933
		[Token(Token = "0x400BF25")]
		[FieldOffset(Offset = "0x50")]
		public GameObject FinishState;

		// Token: 0x0400BF26 RID: 48934
		[Token(Token = "0x400BF26")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ComingState;

		// Token: 0x0400BF27 RID: 48935
		[Token(Token = "0x400BF27")]
		[FieldOffset(Offset = "0x60")]
		public GameObject NormalState;

		// Token: 0x0400BF28 RID: 48936
		[Token(Token = "0x400BF28")]
		[FieldOffset(Offset = "0x68")]
		public UIButton GotoBtn;
	}
}
