using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020C1 RID: 8385
	[Token(Token = "0x20020C1")]
	public class LadderMatchLeaderboardView : UIBaseView
	{
		// Token: 0x0600BC93 RID: 48275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC93")]
		[Address(RVA = "0x13FAA18", Offset = "0x13FAA18", VA = "0x7BBBBFAA18", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BC94 RID: 48276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC94")]
		[Address(RVA = "0x13FACB4", Offset = "0x13FACB4", VA = "0x7BBBBFACB4")]
		public LadderMatchLeaderboardView()
		{
		}

		// Token: 0x0400BD4B RID: 48459
		[Token(Token = "0x400BD4B")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition BoardTween;

		// Token: 0x0400BD4C RID: 48460
		[Token(Token = "0x400BD4C")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList EasyList;

		// Token: 0x0400BD4D RID: 48461
		[Token(Token = "0x400BD4D")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnFriend;

		// Token: 0x0400BD4E RID: 48462
		[Token(Token = "0x400BD4E")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnAll;

		// Token: 0x0400BD4F RID: 48463
		[Token(Token = "0x400BD4F")]
		[FieldOffset(Offset = "0x40")]
		public Transform SelfRank;

		// Token: 0x0400BD50 RID: 48464
		[Token(Token = "0x400BD50")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnClose;

		// Token: 0x0400BD51 RID: 48465
		[Token(Token = "0x400BD51")]
		[FieldOffset(Offset = "0x50")]
		public Transform Arrow;

		// Token: 0x0400BD52 RID: 48466
		[Token(Token = "0x400BD52")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BtnHide;

		// Token: 0x0400BD53 RID: 48467
		[Token(Token = "0x400BD53")]
		[FieldOffset(Offset = "0x60")]
		public TweenAlpha Mask;
	}
}
