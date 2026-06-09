using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002378 RID: 9080
	[Token(Token = "0x2002378")]
	public class UIHudTeamBattleMatchResultView : UIBaseView
	{
		// Token: 0x0600C200 RID: 49664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C200")]
		[Address(RVA = "0x15D8EA8", Offset = "0x15D8EA8", VA = "0x7BBBDD8EA8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C201 RID: 49665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C201")]
		[Address(RVA = "0x15D9D5C", Offset = "0x15D9D5C", VA = "0x7BBBDD9D5C")]
		public UIHudTeamBattleMatchResultView()
		{
		}

		// Token: 0x0400DC1A RID: 56346
		[Token(Token = "0x400DC1A")]
		[FieldOffset(Offset = "0x20")]
		public Animator HudTeamBattleAni;

		// Token: 0x0400DC1B RID: 56347
		[Token(Token = "0x400DC1B")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Defeat;

		// Token: 0x0400DC1C RID: 56348
		[Token(Token = "0x400DC1C")]
		[FieldOffset(Offset = "0x30")]
		public UILabel DefeatTxt;

		// Token: 0x0400DC1D RID: 56349
		[Token(Token = "0x400DC1D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ResultDesc;

		// Token: 0x0400DC1E RID: 56350
		[Token(Token = "0x400DC1E")]
		[FieldOffset(Offset = "0x40")]
		public Transform BaseReward;

		// Token: 0x0400DC1F RID: 56351
		[Token(Token = "0x400DC1F")]
		[FieldOffset(Offset = "0x48")]
		public UILabel GameModeTxt;

		// Token: 0x0400DC20 RID: 56352
		[Token(Token = "0x400DC20")]
		[FieldOffset(Offset = "0x50")]
		public UILabel GameMapTxt;

		// Token: 0x0400DC21 RID: 56353
		[Token(Token = "0x400DC21")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Victory;

		// Token: 0x0400DC22 RID: 56354
		[Token(Token = "0x400DC22")]
		[FieldOffset(Offset = "0x60")]
		public UILabel VictoryTxt;

		// Token: 0x0400DC23 RID: 56355
		[Token(Token = "0x400DC23")]
		[FieldOffset(Offset = "0x68")]
		public GameObject BiaoQianOB;

		// Token: 0x0400DC24 RID: 56356
		[Token(Token = "0x400DC24")]
		[FieldOffset(Offset = "0x70")]
		public UIWidget Biaoqian1;

		// Token: 0x0400DC25 RID: 56357
		[Token(Token = "0x400DC25")]
		[FieldOffset(Offset = "0x78")]
		public UIWidget Biaoqian2;

		// Token: 0x0400DC26 RID: 56358
		[Token(Token = "0x400DC26")]
		[FieldOffset(Offset = "0x80")]
		public UIWidget Biaoqian3;

		// Token: 0x0400DC27 RID: 56359
		[Token(Token = "0x400DC27")]
		[FieldOffset(Offset = "0x88")]
		public UIWidget Biaoqian4;

		// Token: 0x0400DC28 RID: 56360
		[Token(Token = "0x400DC28")]
		[FieldOffset(Offset = "0x90")]
		public UIWidget PlaceHolderBiaoqian;

		// Token: 0x0400DC29 RID: 56361
		[Token(Token = "0x400DC29")]
		[FieldOffset(Offset = "0x98")]
		public UISprite LeftTeamScoreBG;

		// Token: 0x0400DC2A RID: 56362
		[Token(Token = "0x400DC2A")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel LeftTeamScore;

		// Token: 0x0400DC2B RID: 56363
		[Token(Token = "0x400DC2B")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject LeftTeamDividingLine;

		// Token: 0x0400DC2C RID: 56364
		[Token(Token = "0x400DC2C")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject LeftTeamDefaultIconOB;

		// Token: 0x0400DC2D RID: 56365
		[Token(Token = "0x400DC2D")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject LeftTeamDefaultIcon;

		// Token: 0x0400DC2E RID: 56366
		[Token(Token = "0x400DC2E")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite LeftTeamIcon;

		// Token: 0x0400DC2F RID: 56367
		[Token(Token = "0x400DC2F")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel LeftTeamName;

		// Token: 0x0400DC30 RID: 56368
		[Token(Token = "0x400DC30")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite LeftTeamCustomIcon;

		// Token: 0x0400DC31 RID: 56369
		[Token(Token = "0x400DC31")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel LeftTitleInfo1Txt;

		// Token: 0x0400DC32 RID: 56370
		[Token(Token = "0x400DC32")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel LeftTitleInfo2Txt;

		// Token: 0x0400DC33 RID: 56371
		[Token(Token = "0x400DC33")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel LeftTitleInfo3Txt;

		// Token: 0x0400DC34 RID: 56372
		[Token(Token = "0x400DC34")]
		[FieldOffset(Offset = "0xF0")]
		public Transform LeftTeammate1;

		// Token: 0x0400DC35 RID: 56373
		[Token(Token = "0x400DC35")]
		[FieldOffset(Offset = "0xF8")]
		public Transform LeftTeammate2;

		// Token: 0x0400DC36 RID: 56374
		[Token(Token = "0x400DC36")]
		[FieldOffset(Offset = "0x100")]
		public Transform LeftTeammate3;

		// Token: 0x0400DC37 RID: 56375
		[Token(Token = "0x400DC37")]
		[FieldOffset(Offset = "0x108")]
		public Transform LeftTeammate4;

		// Token: 0x0400DC38 RID: 56376
		[Token(Token = "0x400DC38")]
		[FieldOffset(Offset = "0x110")]
		public UISprite RightTeamScoreBG;

		// Token: 0x0400DC39 RID: 56377
		[Token(Token = "0x400DC39")]
		[FieldOffset(Offset = "0x118")]
		public UILabel RightTeamScore;

		// Token: 0x0400DC3A RID: 56378
		[Token(Token = "0x400DC3A")]
		[FieldOffset(Offset = "0x120")]
		public GameObject RightTeamDividingLine;

		// Token: 0x0400DC3B RID: 56379
		[Token(Token = "0x400DC3B")]
		[FieldOffset(Offset = "0x128")]
		public GameObject RightTeamDefaultIconOB;

		// Token: 0x0400DC3C RID: 56380
		[Token(Token = "0x400DC3C")]
		[FieldOffset(Offset = "0x130")]
		public GameObject RightTeamDefaultIcon;

		// Token: 0x0400DC3D RID: 56381
		[Token(Token = "0x400DC3D")]
		[FieldOffset(Offset = "0x138")]
		public UISprite RightTeamIcon;

		// Token: 0x0400DC3E RID: 56382
		[Token(Token = "0x400DC3E")]
		[FieldOffset(Offset = "0x140")]
		public UILabel RightTeamName;

		// Token: 0x0400DC3F RID: 56383
		[Token(Token = "0x400DC3F")]
		[FieldOffset(Offset = "0x148")]
		public UISprite RightTeamCustomIcon;

		// Token: 0x0400DC40 RID: 56384
		[Token(Token = "0x400DC40")]
		[FieldOffset(Offset = "0x150")]
		public UILabel RightTitleInfo1Txt;

		// Token: 0x0400DC41 RID: 56385
		[Token(Token = "0x400DC41")]
		[FieldOffset(Offset = "0x158")]
		public UILabel RightTitleInfo2Txt;

		// Token: 0x0400DC42 RID: 56386
		[Token(Token = "0x400DC42")]
		[FieldOffset(Offset = "0x160")]
		public UILabel RightTitleInfo3Txt;

		// Token: 0x0400DC43 RID: 56387
		[Token(Token = "0x400DC43")]
		[FieldOffset(Offset = "0x168")]
		public Transform RightTeammate1;

		// Token: 0x0400DC44 RID: 56388
		[Token(Token = "0x400DC44")]
		[FieldOffset(Offset = "0x170")]
		public Transform RightTeammate2;

		// Token: 0x0400DC45 RID: 56389
		[Token(Token = "0x400DC45")]
		[FieldOffset(Offset = "0x178")]
		public Transform RightTeammate3;

		// Token: 0x0400DC46 RID: 56390
		[Token(Token = "0x400DC46")]
		[FieldOffset(Offset = "0x180")]
		public Transform RightTeammate4;

		// Token: 0x0400DC47 RID: 56391
		[Token(Token = "0x400DC47")]
		[FieldOffset(Offset = "0x188")]
		public UIButton DetailsBtn;

		// Token: 0x0400DC48 RID: 56392
		[Token(Token = "0x400DC48")]
		[FieldOffset(Offset = "0x190")]
		public GameObject DetailBtnShowIcon;

		// Token: 0x0400DC49 RID: 56393
		[Token(Token = "0x400DC49")]
		[FieldOffset(Offset = "0x198")]
		public GameObject DetailBtnHideIcon;

		// Token: 0x0400DC4A RID: 56394
		[Token(Token = "0x400DC4A")]
		[FieldOffset(Offset = "0x1A0")]
		public UIButton ShareBtn;

		// Token: 0x0400DC4B RID: 56395
		[Token(Token = "0x400DC4B")]
		[FieldOffset(Offset = "0x1A8")]
		public UIButton NextBtn;

		// Token: 0x0400DC4C RID: 56396
		[Token(Token = "0x400DC4C")]
		[FieldOffset(Offset = "0x1B0")]
		public UILabel NextBtnTime;

		// Token: 0x0400DC4D RID: 56397
		[Token(Token = "0x400DC4D")]
		[FieldOffset(Offset = "0x1B8")]
		public UILabel NextBtnLable;

		// Token: 0x0400DC4E RID: 56398
		[Token(Token = "0x400DC4E")]
		[FieldOffset(Offset = "0x1C0")]
		public UIGrid RewardBtnGrid;

		// Token: 0x0400DC4F RID: 56399
		[Token(Token = "0x400DC4F")]
		[FieldOffset(Offset = "0x1C8")]
		public UIButton LikeBtn;

		// Token: 0x0400DC50 RID: 56400
		[Token(Token = "0x400DC50")]
		[FieldOffset(Offset = "0x1D0")]
		public UIButton AddFriendBtn;

		// Token: 0x0400DC51 RID: 56401
		[Token(Token = "0x400DC51")]
		[FieldOffset(Offset = "0x1D8")]
		public UIButton ReportBtn;

		// Token: 0x0400DC52 RID: 56402
		[Token(Token = "0x400DC52")]
		[FieldOffset(Offset = "0x1E0")]
		public UIButton VideoGiftBtn;

		// Token: 0x0400DC53 RID: 56403
		[Token(Token = "0x400DC53")]
		[FieldOffset(Offset = "0x1E8")]
		public UIButton FastSendGiftBtn;

		// Token: 0x0400DC54 RID: 56404
		[Token(Token = "0x400DC54")]
		[FieldOffset(Offset = "0x1F0")]
		public Transform CallSignContainer;

		// Token: 0x0400DC55 RID: 56405
		[Token(Token = "0x400DC55")]
		[FieldOffset(Offset = "0x1F8")]
		public GameObject ShareInfoContainer;

		// Token: 0x0400DC56 RID: 56406
		[Token(Token = "0x400DC56")]
		[FieldOffset(Offset = "0x200")]
		public UIWidget Biaoqian1Share;

		// Token: 0x0400DC57 RID: 56407
		[Token(Token = "0x400DC57")]
		[FieldOffset(Offset = "0x208")]
		public UIWidget Biaoqian2Share;

		// Token: 0x0400DC58 RID: 56408
		[Token(Token = "0x400DC58")]
		[FieldOffset(Offset = "0x210")]
		public UIWidget Biaoqian3Share;

		// Token: 0x0400DC59 RID: 56409
		[Token(Token = "0x400DC59")]
		[FieldOffset(Offset = "0x218")]
		public UIWidget Biaoqian4Share;

		// Token: 0x0400DC5A RID: 56410
		[Token(Token = "0x400DC5A")]
		[FieldOffset(Offset = "0x220")]
		public UILabel ShareGameModeTxt;
	}
}
