using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020C5 RID: 8389
	[Token(Token = "0x20020C5")]
	public class LadderMatchReviewRewardItemView : UIBaseView
	{
		// Token: 0x0600BC9B RID: 48283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC9B")]
		[Address(RVA = "0x13FBFA8", Offset = "0x13FBFA8", VA = "0x7BBBBFBFA8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BC9C RID: 48284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC9C")]
		[Address(RVA = "0x13FC190", Offset = "0x13FC190", VA = "0x7BBBBFC190")]
		public LadderMatchReviewRewardItemView()
		{
		}

		// Token: 0x0400BDA1 RID: 48545
		[Token(Token = "0x400BDA1")]
		[FieldOffset(Offset = "0x20")]
		public UISprite RankIconNext;

		// Token: 0x0400BDA2 RID: 48546
		[Token(Token = "0x400BDA2")]
		[FieldOffset(Offset = "0x28")]
		public UILabel NextRankName;

		// Token: 0x0400BDA3 RID: 48547
		[Token(Token = "0x400BDA3")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid LevelRewardGrid;

		// Token: 0x0400BDA4 RID: 48548
		[Token(Token = "0x400BDA4")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid SeasonRewardGrid;

		// Token: 0x0400BDA5 RID: 48549
		[Token(Token = "0x400BDA5")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TopRewardTips;

		// Token: 0x0400BDA6 RID: 48550
		[Token(Token = "0x400BDA6")]
		[FieldOffset(Offset = "0x48")]
		public GameObject SpriteCurRank;
	}
}
