using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002377 RID: 9079
	[Token(Token = "0x2002377")]
	public class UIHudTeamBattleMatchResultItemView : UIBaseView
	{
		// Token: 0x0600C1FE RID: 49662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1FE")]
		[Address(RVA = "0x15D8A20", Offset = "0x15D8A20", VA = "0x7BBBDD8A20", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1FF RID: 49663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1FF")]
		[Address(RVA = "0x15D8EA0", Offset = "0x15D8EA0", VA = "0x7BBBDD8EA0")]
		public UIHudTeamBattleMatchResultItemView()
		{
		}

		// Token: 0x0400DC08 RID: 56328
		[Token(Token = "0x400DC08")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SelfBG;

		// Token: 0x0400DC09 RID: 56329
		[Token(Token = "0x400DC09")]
		[FieldOffset(Offset = "0x28")]
		public GameObject WinMVPGrade;

		// Token: 0x0400DC0A RID: 56330
		[Token(Token = "0x400DC0A")]
		[FieldOffset(Offset = "0x30")]
		public GameObject FailMVPGrade;

		// Token: 0x0400DC0B RID: 56331
		[Token(Token = "0x400DC0B")]
		[FieldOffset(Offset = "0x38")]
		public UILabel NormalGrade;

		// Token: 0x0400DC0C RID: 56332
		[Token(Token = "0x400DC0C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FakeBg;

		// Token: 0x0400DC0D RID: 56333
		[Token(Token = "0x400DC0D")]
		[FieldOffset(Offset = "0x48")]
		public UIEffectSprite BannerBg;

		// Token: 0x0400DC0E RID: 56334
		[Token(Token = "0x400DC0E")]
		[FieldOffset(Offset = "0x50")]
		public UISprite HeadIcon;

		// Token: 0x0400DC0F RID: 56335
		[Token(Token = "0x400DC0F")]
		[FieldOffset(Offset = "0x58")]
		public GameObject IconCelebrity;

		// Token: 0x0400DC10 RID: 56336
		[Token(Token = "0x400DC10")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Nickname;

		// Token: 0x0400DC11 RID: 56337
		[Token(Token = "0x400DC11")]
		[FieldOffset(Offset = "0x68")]
		public UILabel ClanName;

		// Token: 0x0400DC12 RID: 56338
		[Token(Token = "0x400DC12")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Info1Txt;

		// Token: 0x0400DC13 RID: 56339
		[Token(Token = "0x400DC13")]
		[FieldOffset(Offset = "0x78")]
		public UILabel Info2Txt;

		// Token: 0x0400DC14 RID: 56340
		[Token(Token = "0x400DC14")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Info3Txt;

		// Token: 0x0400DC15 RID: 56341
		[Token(Token = "0x400DC15")]
		[FieldOffset(Offset = "0x88")]
		public UIButton AddFriendBtn;

		// Token: 0x0400DC16 RID: 56342
		[Token(Token = "0x400DC16")]
		[FieldOffset(Offset = "0x90")]
		public UIButton ReportBtn;

		// Token: 0x0400DC17 RID: 56343
		[Token(Token = "0x400DC17")]
		[FieldOffset(Offset = "0x98")]
		public UIButton LikeBtn;

		// Token: 0x0400DC18 RID: 56344
		[Token(Token = "0x400DC18")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel LikeNum;

		// Token: 0x0400DC19 RID: 56345
		[Token(Token = "0x400DC19")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject VFX_Like;
	}
}
