using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020CE RID: 8398
	[Token(Token = "0x20020CE")]
	public class TeamScoreBoardItemView : UIBaseView
	{
		// Token: 0x0600BCAD RID: 48301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCAD")]
		[Address(RVA = "0x1B45CF8", Offset = "0x1B45CF8", VA = "0x7BBC345CF8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCAE RID: 48302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCAE")]
		[Address(RVA = "0x1B46098", Offset = "0x1B46098", VA = "0x7BBC346098")]
		public TeamScoreBoardItemView()
		{
		}

		// Token: 0x0400BE32 RID: 48690
		[Token(Token = "0x400BE32")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SelfBG;

		// Token: 0x0400BE33 RID: 48691
		[Token(Token = "0x400BE33")]
		[FieldOffset(Offset = "0x28")]
		public GameObject MVPGrade;

		// Token: 0x0400BE34 RID: 48692
		[Token(Token = "0x400BE34")]
		[FieldOffset(Offset = "0x30")]
		public UILabel NormalGrade;

		// Token: 0x0400BE35 RID: 48693
		[Token(Token = "0x400BE35")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SpecialIcon;

		// Token: 0x0400BE36 RID: 48694
		[Token(Token = "0x400BE36")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FakeBg;

		// Token: 0x0400BE37 RID: 48695
		[Token(Token = "0x400BE37")]
		[FieldOffset(Offset = "0x48")]
		public UIEffectSprite BannerBg;

		// Token: 0x0400BE38 RID: 48696
		[Token(Token = "0x400BE38")]
		[FieldOffset(Offset = "0x50")]
		public UISprite HeadIcon;

		// Token: 0x0400BE39 RID: 48697
		[Token(Token = "0x400BE39")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Nickname;

		// Token: 0x0400BE3A RID: 48698
		[Token(Token = "0x400BE3A")]
		[FieldOffset(Offset = "0x60")]
		public UILabel ClanName;

		// Token: 0x0400BE3B RID: 48699
		[Token(Token = "0x400BE3B")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Icon_Celebrity;

		// Token: 0x0400BE3C RID: 48700
		[Token(Token = "0x400BE3C")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Info1Txt;

		// Token: 0x0400BE3D RID: 48701
		[Token(Token = "0x400BE3D")]
		[FieldOffset(Offset = "0x78")]
		public UILabel Info2Txt;

		// Token: 0x0400BE3E RID: 48702
		[Token(Token = "0x400BE3E")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Info3Txt;

		// Token: 0x0400BE3F RID: 48703
		[Token(Token = "0x400BE3F")]
		[FieldOffset(Offset = "0x88")]
		public GameObject BGGray;
	}
}
