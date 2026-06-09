using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020CD RID: 8397
	[Token(Token = "0x20020CD")]
	internal class ResultBtnContainerView : UIBaseView
	{
		// Token: 0x0600BCAB RID: 48299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCAB")]
		[Address(RVA = "0x175D658", Offset = "0x175D658", VA = "0x7BBBF5D658", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCAC RID: 48300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCAC")]
		[Address(RVA = "0x175D8EC", Offset = "0x175D8EC", VA = "0x7BBBF5D8EC")]
		public ResultBtnContainerView()
		{
		}

		// Token: 0x0400BE29 RID: 48681
		[Token(Token = "0x400BE29")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ResultBtnContainer;

		// Token: 0x0400BE2A RID: 48682
		[Token(Token = "0x400BE2A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject RewardBtns;

		// Token: 0x0400BE2B RID: 48683
		[Token(Token = "0x400BE2B")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnShareLittle;

		// Token: 0x0400BE2C RID: 48684
		[Token(Token = "0x400BE2C")]
		[FieldOffset(Offset = "0x38")]
		public Animator ShareIconAnimatorLittle;

		// Token: 0x0400BE2D RID: 48685
		[Token(Token = "0x400BE2D")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnReward;

		// Token: 0x0400BE2E RID: 48686
		[Token(Token = "0x400BE2E")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BackToLobbyButton;

		// Token: 0x0400BE2F RID: 48687
		[Token(Token = "0x400BE2F")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnShare;

		// Token: 0x0400BE30 RID: 48688
		[Token(Token = "0x400BE30")]
		[FieldOffset(Offset = "0x58")]
		public Animator ShareIconAnimator;

		// Token: 0x0400BE31 RID: 48689
		[Token(Token = "0x400BE31")]
		[FieldOffset(Offset = "0x60")]
		public UILabel CountdownInfo;
	}
}
