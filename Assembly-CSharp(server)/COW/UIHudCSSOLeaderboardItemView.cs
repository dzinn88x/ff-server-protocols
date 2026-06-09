using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022B1 RID: 8881
	[Token(Token = "0x20022B1")]
	public class UIHudCSSOLeaderboardItemView : UIBaseView
	{
		// Token: 0x0600C072 RID: 49266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C072")]
		[Address(RVA = "0x19C6158", Offset = "0x19C6158", VA = "0x7BBC1C6158", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C073 RID: 49267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C073")]
		[Address(RVA = "0x19C67D0", Offset = "0x19C67D0", VA = "0x7BBC1C67D0")]
		public UIHudCSSOLeaderboardItemView()
		{
		}

		// Token: 0x0400D54B RID: 54603
		[Token(Token = "0x400D54B")]
		[FieldOffset(Offset = "0x20")]
		public UIHudCSSOTeamInfoView TeamInfoView;

		// Token: 0x0400D54C RID: 54604
		[Token(Token = "0x400D54C")]
		[FieldOffset(Offset = "0x28")]
		public TweenScale TweenScale;

		// Token: 0x0400D54D RID: 54605
		[Token(Token = "0x400D54D")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TeamTitle;

		// Token: 0x0400D54E RID: 54606
		[Token(Token = "0x400D54E")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelTeam;

		// Token: 0x0400D54F RID: 54607
		[Token(Token = "0x400D54F")]
		[FieldOffset(Offset = "0x40")]
		public GameObject HP;

		// Token: 0x0400D550 RID: 54608
		[Token(Token = "0x400D550")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelPlayer4Name;

		// Token: 0x0400D551 RID: 54609
		[Token(Token = "0x400D551")]
		[FieldOffset(Offset = "0x50")]
		public UILabel LabelPlayer2Name;

		// Token: 0x0400D552 RID: 54610
		[Token(Token = "0x400D552")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LabelPlayer3Name;

		// Token: 0x0400D553 RID: 54611
		[Token(Token = "0x400D553")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LabelPlayer1Name;

		// Token: 0x0400D554 RID: 54612
		[Token(Token = "0x400D554")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LabelPlayer1Kills;

		// Token: 0x0400D555 RID: 54613
		[Token(Token = "0x400D555")]
		[FieldOffset(Offset = "0x70")]
		public UILabel LabelPlayer2Kills;

		// Token: 0x0400D556 RID: 54614
		[Token(Token = "0x400D556")]
		[FieldOffset(Offset = "0x78")]
		public UILabel LabelPlayer3Kills;

		// Token: 0x0400D557 RID: 54615
		[Token(Token = "0x400D557")]
		[FieldOffset(Offset = "0x80")]
		public UILabel LabelPlayer4Kills;

		// Token: 0x0400D558 RID: 54616
		[Token(Token = "0x400D558")]
		[FieldOffset(Offset = "0x88")]
		public GameObject Eliminate;

		// Token: 0x0400D559 RID: 54617
		[Token(Token = "0x400D559")]
		[FieldOffset(Offset = "0x90")]
		public GameObject Up;

		// Token: 0x0400D55A RID: 54618
		[Token(Token = "0x400D55A")]
		[FieldOffset(Offset = "0x98")]
		public UILabel UpRank;

		// Token: 0x0400D55B RID: 54619
		[Token(Token = "0x400D55B")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject Win;

		// Token: 0x0400D55C RID: 54620
		[Token(Token = "0x400D55C")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject Lose;

		// Token: 0x0400D55D RID: 54621
		[Token(Token = "0x400D55D")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject Down;

		// Token: 0x0400D55E RID: 54622
		[Token(Token = "0x400D55E")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel DownRank;

		// Token: 0x0400D55F RID: 54623
		[Token(Token = "0x400D55F")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite BG;

		// Token: 0x0400D560 RID: 54624
		[Token(Token = "0x400D560")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite IndexIcon1;

		// Token: 0x0400D561 RID: 54625
		[Token(Token = "0x400D561")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel Index;

		// Token: 0x0400D562 RID: 54626
		[Token(Token = "0x400D562")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite IndexIcon2;

		// Token: 0x0400D563 RID: 54627
		[Token(Token = "0x400D563")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite IndexIcon3;

		// Token: 0x0400D564 RID: 54628
		[Token(Token = "0x400D564")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject NormalMatch;

		// Token: 0x0400D565 RID: 54629
		[Token(Token = "0x400D565")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject SpecialMatch;
	}
}
