using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024AF RID: 9391
	[Token(Token = "0x20024AF")]
	public class UIProfileTeamBattleMatchResultItemView : UIBaseView
	{
		// Token: 0x0600C46E RID: 50286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C46E")]
		[Address(RVA = "0x1FF210C", Offset = "0x1FF210C", VA = "0x7BBC7F210C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C46F RID: 50287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C46F")]
		[Address(RVA = "0x1FF258C", Offset = "0x1FF258C", VA = "0x7BBC7F258C")]
		public UIProfileTeamBattleMatchResultItemView()
		{
		}

		// Token: 0x0400EDAE RID: 60846
		[Token(Token = "0x400EDAE")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SelfBG;

		// Token: 0x0400EDAF RID: 60847
		[Token(Token = "0x400EDAF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject WinMVPGrade;

		// Token: 0x0400EDB0 RID: 60848
		[Token(Token = "0x400EDB0")]
		[FieldOffset(Offset = "0x30")]
		public GameObject FailMVPGrade;

		// Token: 0x0400EDB1 RID: 60849
		[Token(Token = "0x400EDB1")]
		[FieldOffset(Offset = "0x38")]
		public UILabel NormalGrade;

		// Token: 0x0400EDB2 RID: 60850
		[Token(Token = "0x400EDB2")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FakeBg;

		// Token: 0x0400EDB3 RID: 60851
		[Token(Token = "0x400EDB3")]
		[FieldOffset(Offset = "0x48")]
		public UIEffectSprite BannerBg;

		// Token: 0x0400EDB4 RID: 60852
		[Token(Token = "0x400EDB4")]
		[FieldOffset(Offset = "0x50")]
		public UISprite HeadIcon;

		// Token: 0x0400EDB5 RID: 60853
		[Token(Token = "0x400EDB5")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Icon_Celebrity;

		// Token: 0x0400EDB6 RID: 60854
		[Token(Token = "0x400EDB6")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Nickname;

		// Token: 0x0400EDB7 RID: 60855
		[Token(Token = "0x400EDB7")]
		[FieldOffset(Offset = "0x68")]
		public UILabel ClanName;

		// Token: 0x0400EDB8 RID: 60856
		[Token(Token = "0x400EDB8")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Info1Txt;

		// Token: 0x0400EDB9 RID: 60857
		[Token(Token = "0x400EDB9")]
		[FieldOffset(Offset = "0x78")]
		public UILabel Info2Txt;

		// Token: 0x0400EDBA RID: 60858
		[Token(Token = "0x400EDBA")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Info3Txt;

		// Token: 0x0400EDBB RID: 60859
		[Token(Token = "0x400EDBB")]
		[FieldOffset(Offset = "0x88")]
		public UIButton AddFriendBtn;

		// Token: 0x0400EDBC RID: 60860
		[Token(Token = "0x400EDBC")]
		[FieldOffset(Offset = "0x90")]
		public UIButton ReportBtn;

		// Token: 0x0400EDBD RID: 60861
		[Token(Token = "0x400EDBD")]
		[FieldOffset(Offset = "0x98")]
		public GameObject LikeContainer;

		// Token: 0x0400EDBE RID: 60862
		[Token(Token = "0x400EDBE")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton LikeBtn;

		// Token: 0x0400EDBF RID: 60863
		[Token(Token = "0x400EDBF")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel LikeNum;
	}
}
