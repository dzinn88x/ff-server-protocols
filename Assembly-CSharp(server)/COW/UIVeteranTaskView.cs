using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002589 RID: 9609
	[Token(Token = "0x2002589")]
	internal class UIVeteranTaskView : UIBaseView
	{
		// Token: 0x0600C622 RID: 50722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C622")]
		[Address(RVA = "0x168351C", Offset = "0x168351C", VA = "0x7BBBE8351C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C623 RID: 50723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C623")]
		[Address(RVA = "0x16838F4", Offset = "0x16838F4", VA = "0x7BBBE838F4")]
		public UIVeteranTaskView()
		{
		}

		// Token: 0x0400F717 RID: 63255
		[Token(Token = "0x400F717")]
		[FieldOffset(Offset = "0x20")]
		public UIEasyList List;

		// Token: 0x0400F718 RID: 63256
		[Token(Token = "0x400F718")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BundleImageLocal;

		// Token: 0x0400F719 RID: 63257
		[Token(Token = "0x400F719")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTextureExt BundleImageRemote;

		// Token: 0x0400F71A RID: 63258
		[Token(Token = "0x400F71A")]
		[FieldOffset(Offset = "0x38")]
		public BaseItemView TaskIcon;

		// Token: 0x0400F71B RID: 63259
		[Token(Token = "0x400F71B")]
		[FieldOffset(Offset = "0x40")]
		public UISprite TaskIcon01;

		// Token: 0x0400F71C RID: 63260
		[Token(Token = "0x400F71C")]
		[FieldOffset(Offset = "0x48")]
		public UISprite TaskIcon02;

		// Token: 0x0400F71D RID: 63261
		[Token(Token = "0x400F71D")]
		[FieldOffset(Offset = "0x50")]
		public UIButton RewardIconBtn;

		// Token: 0x0400F71E RID: 63262
		[Token(Token = "0x400F71E")]
		[FieldOffset(Offset = "0x58")]
		public UISprite Sprite_Weapon;

		// Token: 0x0400F71F RID: 63263
		[Token(Token = "0x400F71F")]
		[FieldOffset(Offset = "0x60")]
		public GameObject NormalState;

		// Token: 0x0400F720 RID: 63264
		[Token(Token = "0x400F720")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ClaimedState;

		// Token: 0x0400F721 RID: 63265
		[Token(Token = "0x400F721")]
		[FieldOffset(Offset = "0x70")]
		public GameObject WaitClaimState;

		// Token: 0x0400F722 RID: 63266
		[Token(Token = "0x400F722")]
		[FieldOffset(Offset = "0x78")]
		public UIButton ClaimBtn;

		// Token: 0x0400F723 RID: 63267
		[Token(Token = "0x400F723")]
		[FieldOffset(Offset = "0x80")]
		public UILabel ProgressNum;

		// Token: 0x0400F724 RID: 63268
		[Token(Token = "0x400F724")]
		[FieldOffset(Offset = "0x88")]
		public UIProgressBar ProgressBar;
	}
}
