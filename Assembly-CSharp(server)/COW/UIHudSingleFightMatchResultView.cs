using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002363 RID: 9059
	[Token(Token = "0x2002363")]
	public class UIHudSingleFightMatchResultView : UIBaseView
	{
		// Token: 0x0600C1D6 RID: 49622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D6")]
		[Address(RVA = "0x1667D50", Offset = "0x1667D50", VA = "0x7BBBE67D50", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1D7 RID: 49623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D7")]
		[Address(RVA = "0x1668678", Offset = "0x1668678", VA = "0x7BBBE68678")]
		public UIHudSingleFightMatchResultView()
		{
		}

		// Token: 0x0400DB99 RID: 56217
		[Token(Token = "0x400DB99")]
		[FieldOffset(Offset = "0x20")]
		public Animator HudSingleFightAni;

		// Token: 0x0400DB9A RID: 56218
		[Token(Token = "0x400DB9A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject RankInfo;

		// Token: 0x0400DB9B RID: 56219
		[Token(Token = "0x400DB9B")]
		[FieldOffset(Offset = "0x30")]
		public UILabel RankNum;

		// Token: 0x0400DB9C RID: 56220
		[Token(Token = "0x400DB9C")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TotalNum;

		// Token: 0x0400DB9D RID: 56221
		[Token(Token = "0x400DB9D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject WinnerInfo;

		// Token: 0x0400DB9E RID: 56222
		[Token(Token = "0x400DB9E")]
		[FieldOffset(Offset = "0x48")]
		public UILabel WinnerTxt;

		// Token: 0x0400DB9F RID: 56223
		[Token(Token = "0x400DB9F")]
		[FieldOffset(Offset = "0x50")]
		public UILabel GameMapTxt;

		// Token: 0x0400DBA0 RID: 56224
		[Token(Token = "0x400DBA0")]
		[FieldOffset(Offset = "0x58")]
		public UILabel GameModeTxt;

		// Token: 0x0400DBA1 RID: 56225
		[Token(Token = "0x400DBA1")]
		[FieldOffset(Offset = "0x60")]
		public Transform BaseReward;

		// Token: 0x0400DBA2 RID: 56226
		[Token(Token = "0x400DBA2")]
		[FieldOffset(Offset = "0x68")]
		public UILabel ResultDesc;

		// Token: 0x0400DBA3 RID: 56227
		[Token(Token = "0x400DBA3")]
		[FieldOffset(Offset = "0x70")]
		public GameObject BiaoQianOB;

		// Token: 0x0400DBA4 RID: 56228
		[Token(Token = "0x400DBA4")]
		[FieldOffset(Offset = "0x78")]
		public UIWidget Biaoqian1;

		// Token: 0x0400DBA5 RID: 56229
		[Token(Token = "0x400DBA5")]
		[FieldOffset(Offset = "0x80")]
		public UIWidget Biaoqian2;

		// Token: 0x0400DBA6 RID: 56230
		[Token(Token = "0x400DBA6")]
		[FieldOffset(Offset = "0x88")]
		public UIWidget Biaoqian3;

		// Token: 0x0400DBA7 RID: 56231
		[Token(Token = "0x400DBA7")]
		[FieldOffset(Offset = "0x90")]
		public UIWidget Biaoqian4;

		// Token: 0x0400DBA8 RID: 56232
		[Token(Token = "0x400DBA8")]
		[FieldOffset(Offset = "0x98")]
		public UIWidget PlaceHolderBiaoqian;

		// Token: 0x0400DBA9 RID: 56233
		[Token(Token = "0x400DBA9")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel TitleInfo1Txt;

		// Token: 0x0400DBAA RID: 56234
		[Token(Token = "0x400DBAA")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel TitleInfo2Txt;

		// Token: 0x0400DBAB RID: 56235
		[Token(Token = "0x400DBAB")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel TitleInfo3Txt;

		// Token: 0x0400DBAC RID: 56236
		[Token(Token = "0x400DBAC")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel TitleInfo4Txt;

		// Token: 0x0400DBAD RID: 56237
		[Token(Token = "0x400DBAD")]
		[FieldOffset(Offset = "0xC0")]
		public UIEasyList PlayerList;

		// Token: 0x0400DBAE RID: 56238
		[Token(Token = "0x400DBAE")]
		[FieldOffset(Offset = "0xC8")]
		public Transform LocalPlayerInfo;

		// Token: 0x0400DBAF RID: 56239
		[Token(Token = "0x400DBAF")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton DetailsBtn;

		// Token: 0x0400DBB0 RID: 56240
		[Token(Token = "0x400DBB0")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject DetailBtnShowIcon;

		// Token: 0x0400DBB1 RID: 56241
		[Token(Token = "0x400DBB1")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject DetailBtnHideIcon;

		// Token: 0x0400DBB2 RID: 56242
		[Token(Token = "0x400DBB2")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton ShareBtn;

		// Token: 0x0400DBB3 RID: 56243
		[Token(Token = "0x400DBB3")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton NextBtn;

		// Token: 0x0400DBB4 RID: 56244
		[Token(Token = "0x400DBB4")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel NextBtnTime;

		// Token: 0x0400DBB5 RID: 56245
		[Token(Token = "0x400DBB5")]
		[FieldOffset(Offset = "0x100")]
		public UILabel NextBtnLable;

		// Token: 0x0400DBB6 RID: 56246
		[Token(Token = "0x400DBB6")]
		[FieldOffset(Offset = "0x108")]
		public UIGrid RewardBtnGrid;

		// Token: 0x0400DBB7 RID: 56247
		[Token(Token = "0x400DBB7")]
		[FieldOffset(Offset = "0x110")]
		public UIButton VideoGiftBtn;

		// Token: 0x0400DBB8 RID: 56248
		[Token(Token = "0x400DBB8")]
		[FieldOffset(Offset = "0x118")]
		public UIButton FastSendGiftBtn;

		// Token: 0x0400DBB9 RID: 56249
		[Token(Token = "0x400DBB9")]
		[FieldOffset(Offset = "0x120")]
		public Transform CallSignContainer;

		// Token: 0x0400DBBA RID: 56250
		[Token(Token = "0x400DBBA")]
		[FieldOffset(Offset = "0x128")]
		public GameObject ShareInfoContainer;

		// Token: 0x0400DBBB RID: 56251
		[Token(Token = "0x400DBBB")]
		[FieldOffset(Offset = "0x130")]
		public UIWidget Biaoqian1Share;

		// Token: 0x0400DBBC RID: 56252
		[Token(Token = "0x400DBBC")]
		[FieldOffset(Offset = "0x138")]
		public UIWidget Biaoqian2Share;

		// Token: 0x0400DBBD RID: 56253
		[Token(Token = "0x400DBBD")]
		[FieldOffset(Offset = "0x140")]
		public UIWidget Biaoqian3Share;

		// Token: 0x0400DBBE RID: 56254
		[Token(Token = "0x400DBBE")]
		[FieldOffset(Offset = "0x148")]
		public UIWidget Biaoqian4Share;

		// Token: 0x0400DBBF RID: 56255
		[Token(Token = "0x400DBBF")]
		[FieldOffset(Offset = "0x150")]
		public UILabel ShareGameModeTxt;
	}
}
