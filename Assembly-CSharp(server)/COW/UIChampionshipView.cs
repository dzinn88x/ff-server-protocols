using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002145 RID: 8517
	[Token(Token = "0x2002145")]
	public class UIChampionshipView : UIBaseView
	{
		// Token: 0x0600BD9A RID: 48538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD9A")]
		[Address(RVA = "0x1EDC308", Offset = "0x1EDC308", VA = "0x7BBC6DC308", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD9B RID: 48539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD9B")]
		[Address(RVA = "0x1EDD510", Offset = "0x1EDD510", VA = "0x7BBC6DD510")]
		public UIChampionshipView()
		{
		}

		// Token: 0x0400C431 RID: 50225
		[Token(Token = "0x400C431")]
		[FieldOffset(Offset = "0x20")]
		public UIButton NoticeBtn;

		// Token: 0x0400C432 RID: 50226
		[Token(Token = "0x400C432")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SeasonInfo;

		// Token: 0x0400C433 RID: 50227
		[Token(Token = "0x400C433")]
		[FieldOffset(Offset = "0x30")]
		public UILabel SeasonName;

		// Token: 0x0400C434 RID: 50228
		[Token(Token = "0x400C434")]
		[FieldOffset(Offset = "0x38")]
		public UILabel MatchTime;

		// Token: 0x0400C435 RID: 50229
		[Token(Token = "0x400C435")]
		[FieldOffset(Offset = "0x40")]
		public UIWidget MatchTimeBg;

		// Token: 0x0400C436 RID: 50230
		[Token(Token = "0x400C436")]
		[FieldOffset(Offset = "0x48")]
		public UILabel SeasonNum;

		// Token: 0x0400C437 RID: 50231
		[Token(Token = "0x400C437")]
		[FieldOffset(Offset = "0x50")]
		public UIButton SeasonTipsBtn;

		// Token: 0x0400C438 RID: 50232
		[Token(Token = "0x400C438")]
		[FieldOffset(Offset = "0x58")]
		public Transform LeftTabContainer;

		// Token: 0x0400C439 RID: 50233
		[Token(Token = "0x400C439")]
		[FieldOffset(Offset = "0x60")]
		public GameObject MainPage;

		// Token: 0x0400C43A RID: 50234
		[Token(Token = "0x400C43A")]
		[FieldOffset(Offset = "0x68")]
		public UILabel ModeName;

		// Token: 0x0400C43B RID: 50235
		[Token(Token = "0x400C43B")]
		[FieldOffset(Offset = "0x70")]
		public UILabel PlayerCount;

		// Token: 0x0400C43C RID: 50236
		[Token(Token = "0x400C43C")]
		[FieldOffset(Offset = "0x78")]
		public UILabel MinMatchNum;

		// Token: 0x0400C43D RID: 50237
		[Token(Token = "0x400C43D")]
		[FieldOffset(Offset = "0x80")]
		public UILabel NoWeaponSkinBonus;

		// Token: 0x0400C43E RID: 50238
		[Token(Token = "0x400C43E")]
		[FieldOffset(Offset = "0x88")]
		public UILabel OpenTimeInWeek;

		// Token: 0x0400C43F RID: 50239
		[Token(Token = "0x400C43F")]
		[FieldOffset(Offset = "0x90")]
		public UILabel OpenTimeInDay;

		// Token: 0x0400C440 RID: 50240
		[Token(Token = "0x400C440")]
		[FieldOffset(Offset = "0x98")]
		public Transform ChampionshipReward1;

		// Token: 0x0400C441 RID: 50241
		[Token(Token = "0x400C441")]
		[FieldOffset(Offset = "0xA0")]
		public Transform ChampionshipReward2;

		// Token: 0x0400C442 RID: 50242
		[Token(Token = "0x400C442")]
		[FieldOffset(Offset = "0xA8")]
		public Transform ChampionshipReward3;

		// Token: 0x0400C443 RID: 50243
		[Token(Token = "0x400C443")]
		[FieldOffset(Offset = "0xB0")]
		public Transform ChampionshipReward4;

		// Token: 0x0400C444 RID: 50244
		[Token(Token = "0x400C444")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton BtnGotoLadderPage;

		// Token: 0x0400C445 RID: 50245
		[Token(Token = "0x400C445")]
		[FieldOffset(Offset = "0xC0")]
		public Transform Center;

		// Token: 0x0400C446 RID: 50246
		[Token(Token = "0x400C446")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject SeasonIcon;

		// Token: 0x0400C447 RID: 50247
		[Token(Token = "0x400C447")]
		[FieldOffset(Offset = "0xD0")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400C448 RID: 50248
		[Token(Token = "0x400C448")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject DefaultIcon;

		// Token: 0x0400C449 RID: 50249
		[Token(Token = "0x400C449")]
		[FieldOffset(Offset = "0xE0")]
		public UIToggleButton PrepareBtn;

		// Token: 0x0400C44A RID: 50250
		[Token(Token = "0x400C44A")]
		[FieldOffset(Offset = "0xE8")]
		public UIToggleButton OpenBtn;

		// Token: 0x0400C44B RID: 50251
		[Token(Token = "0x400C44B")]
		[FieldOffset(Offset = "0xF0")]
		public UIToggleButton CheckBtn;

		// Token: 0x0400C44C RID: 50252
		[Token(Token = "0x400C44C")]
		[FieldOffset(Offset = "0xF8")]
		public UIToggleButton SettleBtn;

		// Token: 0x0400C44D RID: 50253
		[Token(Token = "0x400C44D")]
		[FieldOffset(Offset = "0x100")]
		public UILabel CurState;

		// Token: 0x0400C44E RID: 50254
		[Token(Token = "0x400C44E")]
		[FieldOffset(Offset = "0x108")]
		public UITable StateDescTable;

		// Token: 0x0400C44F RID: 50255
		[Token(Token = "0x400C44F")]
		[FieldOffset(Offset = "0x110")]
		public UILabel CurStateDesc;

		// Token: 0x0400C450 RID: 50256
		[Token(Token = "0x400C450")]
		[FieldOffset(Offset = "0x118")]
		public Transform CountDownContainer;

		// Token: 0x0400C451 RID: 50257
		[Token(Token = "0x400C451")]
		[FieldOffset(Offset = "0x120")]
		public Transform BottomRight;

		// Token: 0x0400C452 RID: 50258
		[Token(Token = "0x400C452")]
		[FieldOffset(Offset = "0x128")]
		public UIButton StartMatchBtn;

		// Token: 0x0400C453 RID: 50259
		[Token(Token = "0x400C453")]
		[FieldOffset(Offset = "0x130")]
		public UISprite StartMatchBtnBG;

		// Token: 0x0400C454 RID: 50260
		[Token(Token = "0x400C454")]
		[FieldOffset(Offset = "0x138")]
		public GameObject VFXStartClickable;

		// Token: 0x0400C455 RID: 50261
		[Token(Token = "0x400C455")]
		[FieldOffset(Offset = "0x140")]
		public UIButton BtnMainPageJoin;

		// Token: 0x0400C456 RID: 50262
		[Token(Token = "0x400C456")]
		[FieldOffset(Offset = "0x148")]
		public UITipsButton MainPageJoinBtnRedPoint;

		// Token: 0x0400C457 RID: 50263
		[Token(Token = "0x400C457")]
		[FieldOffset(Offset = "0x150")]
		public GameObject VFX_JoinBlink;

		// Token: 0x0400C458 RID: 50264
		[Token(Token = "0x400C458")]
		[FieldOffset(Offset = "0x158")]
		public UIButton BtnMainPageRecuit;

		// Token: 0x0400C459 RID: 50265
		[Token(Token = "0x400C459")]
		[FieldOffset(Offset = "0x160")]
		public GameObject VFX_RecruitBlink;

		// Token: 0x0400C45A RID: 50266
		[Token(Token = "0x400C45A")]
		[FieldOffset(Offset = "0x168")]
		public UIButton BtnMainPageSignUp;

		// Token: 0x0400C45B RID: 50267
		[Token(Token = "0x400C45B")]
		[FieldOffset(Offset = "0x170")]
		public GameObject VFX_SignUpBlink;

		// Token: 0x0400C45C RID: 50268
		[Token(Token = "0x400C45C")]
		[FieldOffset(Offset = "0x178")]
		public UILabel RemainSessionLabel;

		// Token: 0x0400C45D RID: 50269
		[Token(Token = "0x400C45D")]
		[FieldOffset(Offset = "0x180")]
		public GameObject TeamPage;

		// Token: 0x0400C45E RID: 50270
		[Token(Token = "0x400C45E")]
		[FieldOffset(Offset = "0x188")]
		public GameObject LadderPage;

		// Token: 0x0400C45F RID: 50271
		[Token(Token = "0x400C45F")]
		[FieldOffset(Offset = "0x190")]
		public Transform Left;

		// Token: 0x0400C460 RID: 50272
		[Token(Token = "0x400C460")]
		[FieldOffset(Offset = "0x198")]
		public GameObject Leaderboard;

		// Token: 0x0400C461 RID: 50273
		[Token(Token = "0x400C461")]
		[FieldOffset(Offset = "0x1A0")]
		public UIToggleButtonGroup LeaderBoardTabs;

		// Token: 0x0400C462 RID: 50274
		[Token(Token = "0x400C462")]
		[FieldOffset(Offset = "0x1A8")]
		public UIToggleButton LeaderBoardRegion;

		// Token: 0x0400C463 RID: 50275
		[Token(Token = "0x400C463")]
		[FieldOffset(Offset = "0x1B0")]
		public UIEasyList LeaderBoardEasyList;

		// Token: 0x0400C464 RID: 50276
		[Token(Token = "0x400C464")]
		[FieldOffset(Offset = "0x1B8")]
		public GameObject NoLeaderBoardTips;

		// Token: 0x0400C465 RID: 50277
		[Token(Token = "0x400C465")]
		[FieldOffset(Offset = "0x1C0")]
		public GameObject Checking;

		// Token: 0x0400C466 RID: 50278
		[Token(Token = "0x400C466")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject LeaderBoardSelf;

		// Token: 0x0400C467 RID: 50279
		[Token(Token = "0x400C467")]
		[FieldOffset(Offset = "0x1D0")]
		public UILabel LBTips;

		// Token: 0x0400C468 RID: 50280
		[Token(Token = "0x400C468")]
		[FieldOffset(Offset = "0x1D8")]
		public GameObject RewardInfo;

		// Token: 0x0400C469 RID: 50281
		[Token(Token = "0x400C469")]
		[FieldOffset(Offset = "0x1E0")]
		public Animation RewardAnimation;

		// Token: 0x0400C46A RID: 50282
		[Token(Token = "0x400C46A")]
		[FieldOffset(Offset = "0x1E8")]
		public UIGrid RewardGrid;

		// Token: 0x0400C46B RID: 50283
		[Token(Token = "0x400C46B")]
		[FieldOffset(Offset = "0x1F0")]
		public Transform Rotating01;

		// Token: 0x0400C46C RID: 50284
		[Token(Token = "0x400C46C")]
		[FieldOffset(Offset = "0x1F8")]
		public Transform NewReward1;

		// Token: 0x0400C46D RID: 50285
		[Token(Token = "0x400C46D")]
		[FieldOffset(Offset = "0x200")]
		public Transform Reward1;

		// Token: 0x0400C46E RID: 50286
		[Token(Token = "0x400C46E")]
		[FieldOffset(Offset = "0x208")]
		public Transform Rotating02;

		// Token: 0x0400C46F RID: 50287
		[Token(Token = "0x400C46F")]
		[FieldOffset(Offset = "0x210")]
		public Transform Reward2;

		// Token: 0x0400C470 RID: 50288
		[Token(Token = "0x400C470")]
		[FieldOffset(Offset = "0x218")]
		public Transform NewReward2;

		// Token: 0x0400C471 RID: 50289
		[Token(Token = "0x400C471")]
		[FieldOffset(Offset = "0x220")]
		public Transform Rotating03;

		// Token: 0x0400C472 RID: 50290
		[Token(Token = "0x400C472")]
		[FieldOffset(Offset = "0x228")]
		public Transform Reward3;

		// Token: 0x0400C473 RID: 50291
		[Token(Token = "0x400C473")]
		[FieldOffset(Offset = "0x230")]
		public Transform NewReward3;

		// Token: 0x0400C474 RID: 50292
		[Token(Token = "0x400C474")]
		[FieldOffset(Offset = "0x238")]
		public Transform Rotating04;

		// Token: 0x0400C475 RID: 50293
		[Token(Token = "0x400C475")]
		[FieldOffset(Offset = "0x240")]
		public Transform Reward4;

		// Token: 0x0400C476 RID: 50294
		[Token(Token = "0x400C476")]
		[FieldOffset(Offset = "0x248")]
		public Transform NewReward4;

		// Token: 0x0400C477 RID: 50295
		[Token(Token = "0x400C477")]
		[FieldOffset(Offset = "0x250")]
		public UILabel Ranktips;

		// Token: 0x0400C478 RID: 50296
		[Token(Token = "0x400C478")]
		[FieldOffset(Offset = "0x258")]
		public UILabel Rank;

		// Token: 0x0400C479 RID: 50297
		[Token(Token = "0x400C479")]
		[FieldOffset(Offset = "0x260")]
		public UILabel SeasonTips;

		// Token: 0x0400C47A RID: 50298
		[Token(Token = "0x400C47A")]
		[FieldOffset(Offset = "0x268")]
		public UILabel CompletedTips;

		// Token: 0x0400C47B RID: 50299
		[Token(Token = "0x400C47B")]
		[FieldOffset(Offset = "0x270")]
		public UIButton ShowAllRewardBtn;

		// Token: 0x0400C47C RID: 50300
		[Token(Token = "0x400C47C")]
		[FieldOffset(Offset = "0x278")]
		public GameObject ChampionshipDefaultIcon;

		// Token: 0x0400C47D RID: 50301
		[Token(Token = "0x400C47D")]
		[FieldOffset(Offset = "0x280")]
		public UINetworkTexture ChampionshipTexture;

		// Token: 0x0400C47E RID: 50302
		[Token(Token = "0x400C47E")]
		[FieldOffset(Offset = "0x288")]
		public UIGrid ChampionshipRewardGrid;

		// Token: 0x0400C47F RID: 50303
		[Token(Token = "0x400C47F")]
		[FieldOffset(Offset = "0x290")]
		public UILabel ChampionshipLabel;
	}
}
