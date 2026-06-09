using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020C3 RID: 8387
	[Token(Token = "0x20020C3")]
	public class LadderMatchNavigationView : UIBaseView
	{
		// Token: 0x0600BC97 RID: 48279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC97")]
		[Address(RVA = "0x13FAF28", Offset = "0x13FAF28", VA = "0x7BBBBFAF28", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BC98 RID: 48280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC98")]
		[Address(RVA = "0x13FB6F4", Offset = "0x13FB6F4", VA = "0x7BBBBFB6F4")]
		public LadderMatchNavigationView()
		{
		}

		// Token: 0x0400BD5C RID: 48476
		[Token(Token = "0x400BD5C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject LadderMatchNavigation;

		// Token: 0x0400BD5D RID: 48477
		[Token(Token = "0x400BD5D")]
		[FieldOffset(Offset = "0x28")]
		public Animator Anim;

		// Token: 0x0400BD5E RID: 48478
		[Token(Token = "0x400BD5E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RewardContainer;

		// Token: 0x0400BD5F RID: 48479
		[Token(Token = "0x400BD5F")]
		[FieldOffset(Offset = "0x38")]
		public UINetworkTextureExt CdnReward;

		// Token: 0x0400BD60 RID: 48480
		[Token(Token = "0x400BD60")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnRewardDetail;

		// Token: 0x0400BD61 RID: 48481
		[Token(Token = "0x400BD61")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnViewAll;

		// Token: 0x0400BD62 RID: 48482
		[Token(Token = "0x400BD62")]
		[FieldOffset(Offset = "0x50")]
		public UISprite SpriteRank;

		// Token: 0x0400BD63 RID: 48483
		[Token(Token = "0x400BD63")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Left;

		// Token: 0x0400BD64 RID: 48484
		[Token(Token = "0x400BD64")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Center;

		// Token: 0x0400BD65 RID: 48485
		[Token(Token = "0x400BD65")]
		[FieldOffset(Offset = "0x68")]
		public Transform FirstWinContainer;

		// Token: 0x0400BD66 RID: 48486
		[Token(Token = "0x400BD66")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Right;

		// Token: 0x0400BD67 RID: 48487
		[Token(Token = "0x400BD67")]
		[FieldOffset(Offset = "0x78")]
		public Transform SeasonMiniInfoContainer;

		// Token: 0x0400BD68 RID: 48488
		[Token(Token = "0x400BD68")]
		[FieldOffset(Offset = "0x80")]
		public Transform SeasonStatsContainer;

		// Token: 0x0400BD69 RID: 48489
		[Token(Token = "0x400BD69")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnCSRank;

		// Token: 0x0400BD6A RID: 48490
		[Token(Token = "0x400BD6A")]
		[FieldOffset(Offset = "0x90")]
		public GameObject CSNormal;

		// Token: 0x0400BD6B RID: 48491
		[Token(Token = "0x400BD6B")]
		[FieldOffset(Offset = "0x98")]
		public GameObject CSSelected;

		// Token: 0x0400BD6C RID: 48492
		[Token(Token = "0x400BD6C")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton BtnBRRank;

		// Token: 0x0400BD6D RID: 48493
		[Token(Token = "0x400BD6D")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject BRNormal;

		// Token: 0x0400BD6E RID: 48494
		[Token(Token = "0x400BD6E")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject BRSelect;

		// Token: 0x0400BD6F RID: 48495
		[Token(Token = "0x400BD6F")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject TopRight;

		// Token: 0x0400BD70 RID: 48496
		[Token(Token = "0x400BD70")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton ExchangeCurrencyBtn;

		// Token: 0x0400BD71 RID: 48497
		[Token(Token = "0x400BD71")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel ExchangeCurrencyNum;

		// Token: 0x0400BD72 RID: 48498
		[Token(Token = "0x400BD72")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite ExchangeIcon;

		// Token: 0x0400BD73 RID: 48499
		[Token(Token = "0x400BD73")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject RankCardContainer;

		// Token: 0x0400BD74 RID: 48500
		[Token(Token = "0x400BD74")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton ViewRankCardListBtn;

		// Token: 0x0400BD75 RID: 48501
		[Token(Token = "0x400BD75")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite InUseRankCardIcon;

		// Token: 0x0400BD76 RID: 48502
		[Token(Token = "0x400BD76")]
		[FieldOffset(Offset = "0xF0")]
		public UICheckboxButton CurrentRankCardCheckboxBtn;

		// Token: 0x0400BD77 RID: 48503
		[Token(Token = "0x400BD77")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel RankCardCnt;

		// Token: 0x0400BD78 RID: 48504
		[Token(Token = "0x400BD78")]
		[FieldOffset(Offset = "0x100")]
		public GameObject NoCardInUseIcon;

		// Token: 0x0400BD79 RID: 48505
		[Token(Token = "0x400BD79")]
		[FieldOffset(Offset = "0x108")]
		public UIButton QuickStartBtn;

		// Token: 0x0400BD7A RID: 48506
		[Token(Token = "0x400BD7A")]
		[FieldOffset(Offset = "0x110")]
		public GameObject BgRankOpening;

		// Token: 0x0400BD7B RID: 48507
		[Token(Token = "0x400BD7B")]
		[FieldOffset(Offset = "0x118")]
		public GameObject BgRankUnopen;
	}
}
