using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023E3 RID: 9187
	[Token(Token = "0x20023E3")]
	public class UILinkActivityBombView : UIBaseView
	{
		// Token: 0x0600C2D6 RID: 49878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D6")]
		[Address(RVA = "0x1CB98D4", Offset = "0x1CB98D4", VA = "0x7BBC4B98D4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2D7 RID: 49879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D7")]
		[Address(RVA = "0x1CB9CF8", Offset = "0x1CB9CF8", VA = "0x7BBC4B9CF8")]
		public UILinkActivityBombView()
		{
		}

		// Token: 0x0400E091 RID: 57489
		[Token(Token = "0x400E091")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture cdn;

		// Token: 0x0400E092 RID: 57490
		[Token(Token = "0x400E092")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;

		// Token: 0x0400E093 RID: 57491
		[Token(Token = "0x400E093")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Desc;

		// Token: 0x0400E094 RID: 57492
		[Token(Token = "0x400E094")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnClose;

		// Token: 0x0400E095 RID: 57493
		[Token(Token = "0x400E095")]
		[FieldOffset(Offset = "0x40")]
		public GameObject DailyRewardsGot;

		// Token: 0x0400E096 RID: 57494
		[Token(Token = "0x400E096")]
		[FieldOffset(Offset = "0x48")]
		public UILabel RewardTitle;

		// Token: 0x0400E097 RID: 57495
		[Token(Token = "0x400E097")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid RewardList;

		// Token: 0x0400E098 RID: 57496
		[Token(Token = "0x400E098")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BigRewardDesc;

		// Token: 0x0400E099 RID: 57497
		[Token(Token = "0x400E099")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnBox;

		// Token: 0x0400E09A RID: 57498
		[Token(Token = "0x400E09A")]
		[FieldOffset(Offset = "0x68")]
		public UISprite BigRewardIcon;

		// Token: 0x0400E09B RID: 57499
		[Token(Token = "0x400E09B")]
		[FieldOffset(Offset = "0x70")]
		public UILabel FinishCounts;

		// Token: 0x0400E09C RID: 57500
		[Token(Token = "0x400E09C")]
		[FieldOffset(Offset = "0x78")]
		public UILabel FinishCountsTotal;

		// Token: 0x0400E09D RID: 57501
		[Token(Token = "0x400E09D")]
		[FieldOffset(Offset = "0x80")]
		public UILabel FinishCountsCurrent;

		// Token: 0x0400E09E RID: 57502
		[Token(Token = "0x400E09E")]
		[FieldOffset(Offset = "0x88")]
		public UIProgressBar FinishProgress;

		// Token: 0x0400E09F RID: 57503
		[Token(Token = "0x400E09F")]
		[FieldOffset(Offset = "0x90")]
		public UILabel Days;

		// Token: 0x0400E0A0 RID: 57504
		[Token(Token = "0x400E0A0")]
		[FieldOffset(Offset = "0x98")]
		public UIButton BtnGoto;
	}
}
