using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002540 RID: 9536
	[Token(Token = "0x2002540")]
	public class UISPHudTeamMatchResultView : UIBaseView
	{
		// Token: 0x0600C590 RID: 50576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C590")]
		[Address(RVA = "0x1EF9120", Offset = "0x1EF9120", VA = "0x7BBC6F9120", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C591 RID: 50577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C591")]
		[Address(RVA = "0x1EF9798", Offset = "0x1EF9798", VA = "0x7BBC6F9798")]
		public UISPHudTeamMatchResultView()
		{
		}

		// Token: 0x0400F3EB RID: 62443
		[Token(Token = "0x400F3EB")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BG;

		// Token: 0x0400F3EC RID: 62444
		[Token(Token = "0x400F3EC")]
		[FieldOffset(Offset = "0x28")]
		public UITexture LocalBG;

		// Token: 0x0400F3ED RID: 62445
		[Token(Token = "0x400F3ED")]
		[FieldOffset(Offset = "0x30")]
		public UILabel MatchModeTxt;

		// Token: 0x0400F3EE RID: 62446
		[Token(Token = "0x400F3EE")]
		[FieldOffset(Offset = "0x38")]
		public UILabel MatchMapTxt;

		// Token: 0x0400F3EF RID: 62447
		[Token(Token = "0x400F3EF")]
		[FieldOffset(Offset = "0x40")]
		public UIEasyList ResultListGrid;

		// Token: 0x0400F3F0 RID: 62448
		[Token(Token = "0x400F3F0")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Result;

		// Token: 0x0400F3F1 RID: 62449
		[Token(Token = "0x400F3F1")]
		[FieldOffset(Offset = "0x50")]
		public UIButton NextBtn;

		// Token: 0x0400F3F2 RID: 62450
		[Token(Token = "0x400F3F2")]
		[FieldOffset(Offset = "0x58")]
		public UIButton DetailsBtn;

		// Token: 0x0400F3F3 RID: 62451
		[Token(Token = "0x400F3F3")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Top1;

		// Token: 0x0400F3F4 RID: 62452
		[Token(Token = "0x400F3F4")]
		[FieldOffset(Offset = "0x68")]
		public UISprite Top1FakeIcon;

		// Token: 0x0400F3F5 RID: 62453
		[Token(Token = "0x400F3F5")]
		[FieldOffset(Offset = "0x70")]
		public UISprite Top1TeamIcon;

		// Token: 0x0400F3F6 RID: 62454
		[Token(Token = "0x400F3F6")]
		[FieldOffset(Offset = "0x78")]
		public UILabel Top1ScoreLabel;

		// Token: 0x0400F3F7 RID: 62455
		[Token(Token = "0x400F3F7")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Top1KillCountLabel;

		// Token: 0x0400F3F8 RID: 62456
		[Token(Token = "0x400F3F8")]
		[FieldOffset(Offset = "0x88")]
		public UILabel Top1TeamName;

		// Token: 0x0400F3F9 RID: 62457
		[Token(Token = "0x400F3F9")]
		[FieldOffset(Offset = "0x90")]
		public GameObject Top2;

		// Token: 0x0400F3FA RID: 62458
		[Token(Token = "0x400F3FA")]
		[FieldOffset(Offset = "0x98")]
		public UISprite Top2TeamIcon;

		// Token: 0x0400F3FB RID: 62459
		[Token(Token = "0x400F3FB")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite Top2FakeIcon;

		// Token: 0x0400F3FC RID: 62460
		[Token(Token = "0x400F3FC")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel Top2ScoreLabel;

		// Token: 0x0400F3FD RID: 62461
		[Token(Token = "0x400F3FD")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel Top2KillCountLabel;

		// Token: 0x0400F3FE RID: 62462
		[Token(Token = "0x400F3FE")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel Top2TeamName;

		// Token: 0x0400F3FF RID: 62463
		[Token(Token = "0x400F3FF")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject Top3;

		// Token: 0x0400F400 RID: 62464
		[Token(Token = "0x400F400")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite Top3FakeIcon;

		// Token: 0x0400F401 RID: 62465
		[Token(Token = "0x400F401")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite Top3TeamIcon;

		// Token: 0x0400F402 RID: 62466
		[Token(Token = "0x400F402")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel Top3ScoreLabel;

		// Token: 0x0400F403 RID: 62467
		[Token(Token = "0x400F403")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel Top3KillCountLabel;

		// Token: 0x0400F404 RID: 62468
		[Token(Token = "0x400F404")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel Top3TeamName;
	}
}
