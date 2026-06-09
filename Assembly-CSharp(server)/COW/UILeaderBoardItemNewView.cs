using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023D6 RID: 9174
	[Token(Token = "0x20023D6")]
	public class UILeaderBoardItemNewView : UIBaseView
	{
		// Token: 0x0600C2BC RID: 49852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2BC")]
		[Address(RVA = "0x1E2CAAC", Offset = "0x1E2CAAC", VA = "0x7BBC62CAAC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2BD RID: 49853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2BD")]
		[Address(RVA = "0x1E2D330", Offset = "0x1E2D330", VA = "0x7BBC62D330")]
		public UILeaderBoardItemNewView()
		{
		}

		// Token: 0x0400DF9B RID: 57243
		[Token(Token = "0x400DF9B")]
		[FieldOffset(Offset = "0x20")]
		public UIButton itembtn;

		// Token: 0x0400DF9C RID: 57244
		[Token(Token = "0x400DF9C")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget Widget;

		// Token: 0x0400DF9D RID: 57245
		[Token(Token = "0x400DF9D")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Bg;

		// Token: 0x0400DF9E RID: 57246
		[Token(Token = "0x400DF9E")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Bg01;

		// Token: 0x0400DF9F RID: 57247
		[Token(Token = "0x400DF9F")]
		[FieldOffset(Offset = "0x40")]
		public UILabel RankLabel;

		// Token: 0x0400DFA0 RID: 57248
		[Token(Token = "0x400DFA0")]
		[FieldOffset(Offset = "0x48")]
		public UISprite CupIcon;

		// Token: 0x0400DFA1 RID: 57249
		[Token(Token = "0x400DFA1")]
		[FieldOffset(Offset = "0x50")]
		public UISprite CupIconTop;

		// Token: 0x0400DFA2 RID: 57250
		[Token(Token = "0x400DFA2")]
		[FieldOffset(Offset = "0x58")]
		public GameObject PersonKills;

		// Token: 0x0400DFA3 RID: 57251
		[Token(Token = "0x400DFA3")]
		[FieldOffset(Offset = "0x60")]
		public GameObject PersonKillsBaseProfile;

		// Token: 0x0400DFA4 RID: 57252
		[Token(Token = "0x400DFA4")]
		[FieldOffset(Offset = "0x68")]
		public UILabel PersonKillsKills;

		// Token: 0x0400DFA5 RID: 57253
		[Token(Token = "0x400DFA5")]
		[FieldOffset(Offset = "0x70")]
		public UILabel PersonKillsCasualKills;

		// Token: 0x0400DFA6 RID: 57254
		[Token(Token = "0x400DFA6")]
		[FieldOffset(Offset = "0x78")]
		public GameObject PersonWins;

		// Token: 0x0400DFA7 RID: 57255
		[Token(Token = "0x400DFA7")]
		[FieldOffset(Offset = "0x80")]
		public GameObject PersonWinsBaseProfile;

		// Token: 0x0400DFA8 RID: 57256
		[Token(Token = "0x400DFA8")]
		[FieldOffset(Offset = "0x88")]
		public UILabel PersonWinsWins;

		// Token: 0x0400DFA9 RID: 57257
		[Token(Token = "0x400DFA9")]
		[FieldOffset(Offset = "0x90")]
		public UILabel PersonWinsCasualWins;

		// Token: 0x0400DFAA RID: 57258
		[Token(Token = "0x400DFAA")]
		[FieldOffset(Offset = "0x98")]
		public GameObject PersonBadges;

		// Token: 0x0400DFAB RID: 57259
		[Token(Token = "0x400DFAB")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject PersonBadgesBaseProfile;

		// Token: 0x0400DFAC RID: 57260
		[Token(Token = "0x400DFAC")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel PersonBadgesBadges;

		// Token: 0x0400DFAD RID: 57261
		[Token(Token = "0x400DFAD")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject PersonBadgesIcon;

		// Token: 0x0400DFAE RID: 57262
		[Token(Token = "0x400DFAE")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel PersonBadgesRegion;

		// Token: 0x0400DFAF RID: 57263
		[Token(Token = "0x400DFAF")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject GuildHonor;

		// Token: 0x0400DFB0 RID: 57264
		[Token(Token = "0x400DFB0")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel GuildHonorName;

		// Token: 0x0400DFB1 RID: 57265
		[Token(Token = "0x400DFB1")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite GuildHonorLevel;

		// Token: 0x0400DFB2 RID: 57266
		[Token(Token = "0x400DFB2")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel GuildHonorHonor;

		// Token: 0x0400DFB3 RID: 57267
		[Token(Token = "0x400DFB3")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject GuildRegionHonor;

		// Token: 0x0400DFB4 RID: 57268
		[Token(Token = "0x400DFB4")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel GuildRegionHonorName;

		// Token: 0x0400DFB5 RID: 57269
		[Token(Token = "0x400DFB5")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite GuildRegionHonorLevel;

		// Token: 0x0400DFB6 RID: 57270
		[Token(Token = "0x400DFB6")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel GuildRegionHonorRegion;

		// Token: 0x0400DFB7 RID: 57271
		[Token(Token = "0x400DFB7")]
		[FieldOffset(Offset = "0x100")]
		public UILabel GuildRegionHonorHonor;

		// Token: 0x0400DFB8 RID: 57272
		[Token(Token = "0x400DFB8")]
		[FieldOffset(Offset = "0x108")]
		public GameObject TeamScore;

		// Token: 0x0400DFB9 RID: 57273
		[Token(Token = "0x400DFB9")]
		[FieldOffset(Offset = "0x110")]
		public GameObject TeamScoreBaseProfile;

		// Token: 0x0400DFBA RID: 57274
		[Token(Token = "0x400DFBA")]
		[FieldOffset(Offset = "0x118")]
		public UILabel TeamScoreScore;

		// Token: 0x0400DFBB RID: 57275
		[Token(Token = "0x400DFBB")]
		[FieldOffset(Offset = "0x120")]
		public GameObject TeamKills;

		// Token: 0x0400DFBC RID: 57276
		[Token(Token = "0x400DFBC")]
		[FieldOffset(Offset = "0x128")]
		public GameObject TeamKillsBaseProfile;

		// Token: 0x0400DFBD RID: 57277
		[Token(Token = "0x400DFBD")]
		[FieldOffset(Offset = "0x130")]
		public UILabel TeamKillsKills;

		// Token: 0x0400DFBE RID: 57278
		[Token(Token = "0x400DFBE")]
		[FieldOffset(Offset = "0x138")]
		public UILabel TeamKillsKD;

		// Token: 0x0400DFBF RID: 57279
		[Token(Token = "0x400DFBF")]
		[FieldOffset(Offset = "0x140")]
		public UISprite HighLight;
	}
}
