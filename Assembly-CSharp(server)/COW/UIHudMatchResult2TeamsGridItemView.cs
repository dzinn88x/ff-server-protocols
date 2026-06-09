using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200230C RID: 8972
	[Token(Token = "0x200230C")]
	public class UIHudMatchResult2TeamsGridItemView : UIBaseView
	{
		// Token: 0x0600C128 RID: 49448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C128")]
		[Address(RVA = "0x15C56AC", Offset = "0x15C56AC", VA = "0x7BBBDC56AC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C129 RID: 49449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C129")]
		[Address(RVA = "0x15C5A9C", Offset = "0x15C5A9C", VA = "0x7BBBDC5A9C")]
		public UIHudMatchResult2TeamsGridItemView()
		{
		}

		// Token: 0x0400D8B8 RID: 55480
		[Token(Token = "0x400D8B8")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Self;

		// Token: 0x0400D8B9 RID: 55481
		[Token(Token = "0x400D8B9")]
		[FieldOffset(Offset = "0x28")]
		public UIButton SimpleProfileInfo;

		// Token: 0x0400D8BA RID: 55482
		[Token(Token = "0x400D8BA")]
		[FieldOffset(Offset = "0x30")]
		public GameObject fakeBg;

		// Token: 0x0400D8BB RID: 55483
		[Token(Token = "0x400D8BB")]
		[FieldOffset(Offset = "0x38")]
		public UIEffectSprite bannerBg;

		// Token: 0x0400D8BC RID: 55484
		[Token(Token = "0x400D8BC")]
		[FieldOffset(Offset = "0x40")]
		public UISprite HeadIcon;

		// Token: 0x0400D8BD RID: 55485
		[Token(Token = "0x400D8BD")]
		[FieldOffset(Offset = "0x48")]
		public GameObject infoContainer;

		// Token: 0x0400D8BE RID: 55486
		[Token(Token = "0x400D8BE")]
		[FieldOffset(Offset = "0x50")]
		public UILabel nickname;

		// Token: 0x0400D8BF RID: 55487
		[Token(Token = "0x400D8BF")]
		[FieldOffset(Offset = "0x58")]
		public UILabel clanName;

		// Token: 0x0400D8C0 RID: 55488
		[Token(Token = "0x400D8C0")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Kill;

		// Token: 0x0400D8C1 RID: 55489
		[Token(Token = "0x400D8C1")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Death;

		// Token: 0x0400D8C2 RID: 55490
		[Token(Token = "0x400D8C2")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Assist;

		// Token: 0x0400D8C3 RID: 55491
		[Token(Token = "0x400D8C3")]
		[FieldOffset(Offset = "0x78")]
		public UILabel Damage;

		// Token: 0x0400D8C4 RID: 55492
		[Token(Token = "0x400D8C4")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Evaluation;

		// Token: 0x0400D8C5 RID: 55493
		[Token(Token = "0x400D8C5")]
		[FieldOffset(Offset = "0x88")]
		public GameObject Mvp;

		// Token: 0x0400D8C6 RID: 55494
		[Token(Token = "0x400D8C6")]
		[FieldOffset(Offset = "0x90")]
		public UIButton AddFriendBtn;
	}
}
