using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023D8 RID: 9176
	[Token(Token = "0x20023D8")]
	public class UILeaderBoardNewView : UIBaseView
	{
		// Token: 0x0600C2C0 RID: 49856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C0")]
		[Address(RVA = "0x1E3B9C8", Offset = "0x1E3B9C8", VA = "0x7BBC63B9C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2C1 RID: 49857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C1")]
		[Address(RVA = "0x1E3C2D8", Offset = "0x1E3C2D8", VA = "0x7BBC63C2D8")]
		public UILeaderBoardNewView()
		{
		}

		// Token: 0x0400DFCF RID: 57295
		[Token(Token = "0x400DFCF")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Profile;

		// Token: 0x0400DFD0 RID: 57296
		[Token(Token = "0x400DFD0")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Share;

		// Token: 0x0400DFD1 RID: 57297
		[Token(Token = "0x400DFD1")]
		[FieldOffset(Offset = "0x30")]
		public Transform LeftContainer;

		// Token: 0x0400DFD2 RID: 57298
		[Token(Token = "0x400DFD2")]
		[FieldOffset(Offset = "0x38")]
		public UIScrollView ContentScrollView;

		// Token: 0x0400DFD3 RID: 57299
		[Token(Token = "0x400DFD3")]
		[FieldOffset(Offset = "0x40")]
		public UIEasyList ContentList;

		// Token: 0x0400DFD4 RID: 57300
		[Token(Token = "0x400DFD4")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ListTitleBar;

		// Token: 0x0400DFD5 RID: 57301
		[Token(Token = "0x400DFD5")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ListTitlePersonKills;

		// Token: 0x0400DFD6 RID: 57302
		[Token(Token = "0x400DFD6")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ListTitlePersonWins;

		// Token: 0x0400DFD7 RID: 57303
		[Token(Token = "0x400DFD7")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ListTitleCSPersonKills;

		// Token: 0x0400DFD8 RID: 57304
		[Token(Token = "0x400DFD8")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ListTitleGuildHonor;

		// Token: 0x0400DFD9 RID: 57305
		[Token(Token = "0x400DFD9")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ListTitleGuildRegionHonor;

		// Token: 0x0400DFDA RID: 57306
		[Token(Token = "0x400DFDA")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ListTitlePersonBadges;

		// Token: 0x0400DFDB RID: 57307
		[Token(Token = "0x400DFDB")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ListTitleTeamScore;

		// Token: 0x0400DFDC RID: 57308
		[Token(Token = "0x400DFDC")]
		[FieldOffset(Offset = "0x88")]
		public GameObject ListTitleTeamKills;

		// Token: 0x0400DFDD RID: 57309
		[Token(Token = "0x400DFDD")]
		[FieldOffset(Offset = "0x90")]
		public UISprite BG;

		// Token: 0x0400DFDE RID: 57310
		[Token(Token = "0x400DFDE")]
		[FieldOffset(Offset = "0x98")]
		public UISprite BG01;

		// Token: 0x0400DFDF RID: 57311
		[Token(Token = "0x400DFDF")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject SelfInfo;

		// Token: 0x0400DFE0 RID: 57312
		[Token(Token = "0x400DFE0")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite SelfBG;

		// Token: 0x0400DFE1 RID: 57313
		[Token(Token = "0x400DFE1")]
		[FieldOffset(Offset = "0xB0")]
		public Transform SelfLBContainer;

		// Token: 0x0400DFE2 RID: 57314
		[Token(Token = "0x400DFE2")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel SelfInfoTips;

		// Token: 0x0400DFE3 RID: 57315
		[Token(Token = "0x400DFE3")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton Share2;

		// Token: 0x0400DFE4 RID: 57316
		[Token(Token = "0x400DFE4")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton SeasonTipsBtn;

		// Token: 0x0400DFE5 RID: 57317
		[Token(Token = "0x400DFE5")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite SeasonIcon;

		// Token: 0x0400DFE6 RID: 57318
		[Token(Token = "0x400DFE6")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel SeasonLabel;

		// Token: 0x0400DFE7 RID: 57319
		[Token(Token = "0x400DFE7")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite UnOpen;

		// Token: 0x0400DFE8 RID: 57320
		[Token(Token = "0x400DFE8")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton CSSeasonTipsBtn;

		// Token: 0x0400DFE9 RID: 57321
		[Token(Token = "0x400DFE9")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite CSSeasonIcon;

		// Token: 0x0400DFEA RID: 57322
		[Token(Token = "0x400DFEA")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel CSSeasonLabel;

		// Token: 0x0400DFEB RID: 57323
		[Token(Token = "0x400DFEB")]
		[FieldOffset(Offset = "0x100")]
		public UISprite CSUnOpen;

		// Token: 0x0400DFEC RID: 57324
		[Token(Token = "0x400DFEC")]
		[FieldOffset(Offset = "0x108")]
		public Transform Fliter1;

		// Token: 0x0400DFED RID: 57325
		[Token(Token = "0x400DFED")]
		[FieldOffset(Offset = "0x110")]
		public Transform Fliter2;

		// Token: 0x0400DFEE RID: 57326
		[Token(Token = "0x400DFEE")]
		[FieldOffset(Offset = "0x118")]
		public Transform Fliter3;

		// Token: 0x0400DFEF RID: 57327
		[Token(Token = "0x400DFEF")]
		[FieldOffset(Offset = "0x120")]
		public UILabel GuildWeekTime;

		// Token: 0x0400DFF0 RID: 57328
		[Token(Token = "0x400DFF0")]
		[FieldOffset(Offset = "0x128")]
		public GameObject InteractMask;

		// Token: 0x0400DFF1 RID: 57329
		[Token(Token = "0x400DFF1")]
		[FieldOffset(Offset = "0x130")]
		public UIWidget ItemLeft;

		// Token: 0x0400DFF2 RID: 57330
		[Token(Token = "0x400DFF2")]
		[FieldOffset(Offset = "0x138")]
		public UIWidget ItemRight1;

		// Token: 0x0400DFF3 RID: 57331
		[Token(Token = "0x400DFF3")]
		[FieldOffset(Offset = "0x140")]
		public UIWidget ItemRight2;

		// Token: 0x0400DFF4 RID: 57332
		[Token(Token = "0x400DFF4")]
		[FieldOffset(Offset = "0x148")]
		public GameObject Loading;
	}
}
