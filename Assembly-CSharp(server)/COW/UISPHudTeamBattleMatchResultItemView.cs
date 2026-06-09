using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200253D RID: 9533
	[Token(Token = "0x200253D")]
	public class UISPHudTeamBattleMatchResultItemView : UIBaseView
	{
		// Token: 0x0600C58A RID: 50570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C58A")]
		[Address(RVA = "0x1EF62E8", Offset = "0x1EF62E8", VA = "0x7BBC6F62E8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C58B RID: 50571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C58B")]
		[Address(RVA = "0x1EF65F0", Offset = "0x1EF65F0", VA = "0x7BBC6F65F0")]
		public UISPHudTeamBattleMatchResultItemView()
		{
		}

		// Token: 0x0400F3A8 RID: 62376
		[Token(Token = "0x400F3A8")]
		[FieldOffset(Offset = "0x20")]
		public GameObject WinMVPGrade;

		// Token: 0x0400F3A9 RID: 62377
		[Token(Token = "0x400F3A9")]
		[FieldOffset(Offset = "0x28")]
		public GameObject FailMVPGrade;

		// Token: 0x0400F3AA RID: 62378
		[Token(Token = "0x400F3AA")]
		[FieldOffset(Offset = "0x30")]
		public UILabel NormalGrade;

		// Token: 0x0400F3AB RID: 62379
		[Token(Token = "0x400F3AB")]
		[FieldOffset(Offset = "0x38")]
		public GameObject FakeBg;

		// Token: 0x0400F3AC RID: 62380
		[Token(Token = "0x400F3AC")]
		[FieldOffset(Offset = "0x40")]
		public UIEffectSprite BannerBg;

		// Token: 0x0400F3AD RID: 62381
		[Token(Token = "0x400F3AD")]
		[FieldOffset(Offset = "0x48")]
		public UISprite HeadIcon;

		// Token: 0x0400F3AE RID: 62382
		[Token(Token = "0x400F3AE")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Nickname;

		// Token: 0x0400F3AF RID: 62383
		[Token(Token = "0x400F3AF")]
		[FieldOffset(Offset = "0x58")]
		public UILabel ClanName;

		// Token: 0x0400F3B0 RID: 62384
		[Token(Token = "0x400F3B0")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Info1Txt;

		// Token: 0x0400F3B1 RID: 62385
		[Token(Token = "0x400F3B1")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Info2Txt;

		// Token: 0x0400F3B2 RID: 62386
		[Token(Token = "0x400F3B2")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Info3Txt;
	}
}
