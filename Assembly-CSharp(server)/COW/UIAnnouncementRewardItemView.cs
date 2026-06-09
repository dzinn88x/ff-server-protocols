using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020F4 RID: 8436
	[Token(Token = "0x20020F4")]
	internal class UIAnnouncementRewardItemView : UIBaseView
	{
		// Token: 0x0600BCF9 RID: 48377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF9")]
		[Address(RVA = "0x1B150F4", Offset = "0x1B150F4", VA = "0x7BBC3150F4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCFA RID: 48378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCFA")]
		[Address(RVA = "0x1B153C4", Offset = "0x1B153C4", VA = "0x7BBC3153C4")]
		public UIAnnouncementRewardItemView()
		{
		}

		// Token: 0x0400BFB4 RID: 49076
		[Token(Token = "0x400BFB4")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400BFB5 RID: 49077
		[Token(Token = "0x400BFB5")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Container;

		// Token: 0x0400BFB6 RID: 49078
		[Token(Token = "0x400BFB6")]
		[FieldOffset(Offset = "0x30")]
		public GameObject CheckedContainer;

		// Token: 0x0400BFB7 RID: 49079
		[Token(Token = "0x400BFB7")]
		[FieldOffset(Offset = "0x38")]
		public GameObject UnCheckedContainer;

		// Token: 0x0400BFB8 RID: 49080
		[Token(Token = "0x400BFB8")]
		[FieldOffset(Offset = "0x40")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400BFB9 RID: 49081
		[Token(Token = "0x400BFB9")]
		[FieldOffset(Offset = "0x48")]
		public UILabel IndexLabel;

		// Token: 0x0400BFBA RID: 49082
		[Token(Token = "0x400BFBA")]
		[FieldOffset(Offset = "0x50")]
		public UISprite IconSprite;

		// Token: 0x0400BFBB RID: 49083
		[Token(Token = "0x400BFBB")]
		[FieldOffset(Offset = "0x58")]
		public UISprite ChooseSprite;

		// Token: 0x0400BFBC RID: 49084
		[Token(Token = "0x400BFBC")]
		[FieldOffset(Offset = "0x60")]
		public UISprite IconSprite_car;

		// Token: 0x0400BFBD RID: 49085
		[Token(Token = "0x400BFBD")]
		[FieldOffset(Offset = "0x68")]
		public UISprite IconSprite_weapon;
	}
}
