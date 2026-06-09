using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200253A RID: 9530
	[Token(Token = "0x200253A")]
	public class UISPHudTeamAccStatsItemView : UIBaseView
	{
		// Token: 0x0600C584 RID: 50564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C584")]
		[Address(RVA = "0x1EF51B8", Offset = "0x1EF51B8", VA = "0x7BBC6F51B8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C585 RID: 50565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C585")]
		[Address(RVA = "0x1EF5660", Offset = "0x1EF5660", VA = "0x7BBC6F5660")]
		public UISPHudTeamAccStatsItemView()
		{
		}

		// Token: 0x0400F387 RID: 62343
		[Token(Token = "0x400F387")]
		[FieldOffset(Offset = "0x20")]
		public GameObject DeadBg;

		// Token: 0x0400F388 RID: 62344
		[Token(Token = "0x400F388")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget TeamIconGo;

		// Token: 0x0400F389 RID: 62345
		[Token(Token = "0x400F389")]
		[FieldOffset(Offset = "0x30")]
		public UIEffectSprite TeamIcon;

		// Token: 0x0400F38A RID: 62346
		[Token(Token = "0x400F38A")]
		[FieldOffset(Offset = "0x38")]
		public UISprite TeamFakeIcon;

		// Token: 0x0400F38B RID: 62347
		[Token(Token = "0x400F38B")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ParticleGo;

		// Token: 0x0400F38C RID: 62348
		[Token(Token = "0x400F38C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject DownGo;

		// Token: 0x0400F38D RID: 62349
		[Token(Token = "0x400F38D")]
		[FieldOffset(Offset = "0x50")]
		public TweenAlpha DownAlpha;

		// Token: 0x0400F38E RID: 62350
		[Token(Token = "0x400F38E")]
		[FieldOffset(Offset = "0x58")]
		public UILabel DownLbl;

		// Token: 0x0400F38F RID: 62351
		[Token(Token = "0x400F38F")]
		[FieldOffset(Offset = "0x60")]
		public GameObject UpGo;

		// Token: 0x0400F390 RID: 62352
		[Token(Token = "0x400F390")]
		[FieldOffset(Offset = "0x68")]
		public TweenAlpha UpAlpha;

		// Token: 0x0400F391 RID: 62353
		[Token(Token = "0x400F391")]
		[FieldOffset(Offset = "0x70")]
		public UILabel UpLbl;

		// Token: 0x0400F392 RID: 62354
		[Token(Token = "0x400F392")]
		[FieldOffset(Offset = "0x78")]
		public UILabel Name;

		// Token: 0x0400F393 RID: 62355
		[Token(Token = "0x400F393")]
		[FieldOffset(Offset = "0x80")]
		public UISprite P1;

		// Token: 0x0400F394 RID: 62356
		[Token(Token = "0x400F394")]
		[FieldOffset(Offset = "0x88")]
		public UISprite P2;

		// Token: 0x0400F395 RID: 62357
		[Token(Token = "0x400F395")]
		[FieldOffset(Offset = "0x90")]
		public UISprite P3;

		// Token: 0x0400F396 RID: 62358
		[Token(Token = "0x400F396")]
		[FieldOffset(Offset = "0x98")]
		public UISprite P4;

		// Token: 0x0400F397 RID: 62359
		[Token(Token = "0x400F397")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel RankLbl;

		// Token: 0x0400F398 RID: 62360
		[Token(Token = "0x400F398")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel Score;
	}
}
