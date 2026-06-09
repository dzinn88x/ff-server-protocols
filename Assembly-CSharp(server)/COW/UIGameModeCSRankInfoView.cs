using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002234 RID: 8756
	[Token(Token = "0x2002234")]
	public class UIGameModeCSRankInfoView : UIBaseView
	{
		// Token: 0x0600BF79 RID: 49017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF79")]
		[Address(RVA = "0x1FFEFB4", Offset = "0x1FFEFB4", VA = "0x7BBC7FEFB4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF7A RID: 49018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF7A")]
		[Address(RVA = "0x1FFF61C", Offset = "0x1FFF61C", VA = "0x7BBC7FF61C")]
		public UIGameModeCSRankInfoView()
		{
		}

		// Token: 0x0400D114 RID: 53524
		[Token(Token = "0x400D114")]
		[FieldOffset(Offset = "0x20")]
		public UISprite bg;

		// Token: 0x0400D115 RID: 53525
		[Token(Token = "0x400D115")]
		[FieldOffset(Offset = "0x28")]
		public UIButton HelperBtn;

		// Token: 0x0400D116 RID: 53526
		[Token(Token = "0x400D116")]
		[FieldOffset(Offset = "0x30")]
		public GameObject CSRank_Reward;

		// Token: 0x0400D117 RID: 53527
		[Token(Token = "0x400D117")]
		[FieldOffset(Offset = "0x38")]
		public GameObject helpSprite;

		// Token: 0x0400D118 RID: 53528
		[Token(Token = "0x400D118")]
		[FieldOffset(Offset = "0x40")]
		public GameObject NormalView;

		// Token: 0x0400D119 RID: 53529
		[Token(Token = "0x400D119")]
		[FieldOffset(Offset = "0x48")]
		public UILabel gameMode;

		// Token: 0x0400D11A RID: 53530
		[Token(Token = "0x400D11A")]
		[FieldOffset(Offset = "0x50")]
		public UILabel mapMode;

		// Token: 0x0400D11B RID: 53531
		[Token(Token = "0x400D11B")]
		[FieldOffset(Offset = "0x58")]
		public GameObject openTime;

		// Token: 0x0400D11C RID: 53532
		[Token(Token = "0x400D11C")]
		[FieldOffset(Offset = "0x60")]
		public UILabel openPeriod;

		// Token: 0x0400D11D RID: 53533
		[Token(Token = "0x400D11D")]
		[FieldOffset(Offset = "0x68")]
		public UIWidget RankGuideInfo;

		// Token: 0x0400D11E RID: 53534
		[Token(Token = "0x400D11E")]
		[FieldOffset(Offset = "0x70")]
		public GameObject LevelContainer;

		// Token: 0x0400D11F RID: 53535
		[Token(Token = "0x400D11F")]
		[FieldOffset(Offset = "0x78")]
		public UISprite CSMatchLevelSprite;

		// Token: 0x0400D120 RID: 53536
		[Token(Token = "0x400D120")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnCSRank;

		// Token: 0x0400D121 RID: 53537
		[Token(Token = "0x400D121")]
		[FieldOffset(Offset = "0x88")]
		public GameObject StarIcon;

		// Token: 0x0400D122 RID: 53538
		[Token(Token = "0x400D122")]
		[FieldOffset(Offset = "0x90")]
		public UILabel MaxRankTxt;

		// Token: 0x0400D123 RID: 53539
		[Token(Token = "0x400D123")]
		[FieldOffset(Offset = "0x98")]
		public Transform star;

		// Token: 0x0400D124 RID: 53540
		[Token(Token = "0x400D124")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject star1;

		// Token: 0x0400D125 RID: 53541
		[Token(Token = "0x400D125")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject star2;

		// Token: 0x0400D126 RID: 53542
		[Token(Token = "0x400D126")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject star3;

		// Token: 0x0400D127 RID: 53543
		[Token(Token = "0x400D127")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject star4;

		// Token: 0x0400D128 RID: 53544
		[Token(Token = "0x400D128")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject star5;

		// Token: 0x0400D129 RID: 53545
		[Token(Token = "0x400D129")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject blackstar5;

		// Token: 0x0400D12A RID: 53546
		[Token(Token = "0x400D12A")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject blackstar4;

		// Token: 0x0400D12B RID: 53547
		[Token(Token = "0x400D12B")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject blackstar3;

		// Token: 0x0400D12C RID: 53548
		[Token(Token = "0x400D12C")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject blackstar2;

		// Token: 0x0400D12D RID: 53549
		[Token(Token = "0x400D12D")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject blackstar1;

		// Token: 0x0400D12E RID: 53550
		[Token(Token = "0x400D12E")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel seasonName;
	}
}
