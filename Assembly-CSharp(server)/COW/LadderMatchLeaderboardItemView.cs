using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020C0 RID: 8384
	[Token(Token = "0x20020C0")]
	public class LadderMatchLeaderboardItemView : UIBaseView
	{
		// Token: 0x0600BC91 RID: 48273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC91")]
		[Address(RVA = "0x13FA6D4", Offset = "0x13FA6D4", VA = "0x7BBBBFA6D4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BC92 RID: 48274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC92")]
		[Address(RVA = "0x13FAA10", Offset = "0x13FAA10", VA = "0x7BBBBFAA10")]
		public LadderMatchLeaderboardItemView()
		{
		}

		// Token: 0x0400BD3F RID: 48447
		[Token(Token = "0x400BD3F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400BD40 RID: 48448
		[Token(Token = "0x400BD40")]
		[FieldOffset(Offset = "0x28")]
		public GameObject FirstCupIcon;

		// Token: 0x0400BD41 RID: 48449
		[Token(Token = "0x400BD41")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SecondCupIcon;

		// Token: 0x0400BD42 RID: 48450
		[Token(Token = "0x400BD42")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ThirdCupIcon;

		// Token: 0x0400BD43 RID: 48451
		[Token(Token = "0x400BD43")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FirstBg;

		// Token: 0x0400BD44 RID: 48452
		[Token(Token = "0x400BD44")]
		[FieldOffset(Offset = "0x48")]
		public GameObject SecondBg;

		// Token: 0x0400BD45 RID: 48453
		[Token(Token = "0x400BD45")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ThirdBg;

		// Token: 0x0400BD46 RID: 48454
		[Token(Token = "0x400BD46")]
		[FieldOffset(Offset = "0x58")]
		public UISprite NormalBg;

		// Token: 0x0400BD47 RID: 48455
		[Token(Token = "0x400BD47")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LabelNormalCup;

		// Token: 0x0400BD48 RID: 48456
		[Token(Token = "0x400BD48")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LabelRankPoints;

		// Token: 0x0400BD49 RID: 48457
		[Token(Token = "0x400BD49")]
		[FieldOffset(Offset = "0x70")]
		public Transform ProfileContainer;

		// Token: 0x0400BD4A RID: 48458
		[Token(Token = "0x400BD4A")]
		[FieldOffset(Offset = "0x78")]
		public UISprite SelfBg;
	}
}
