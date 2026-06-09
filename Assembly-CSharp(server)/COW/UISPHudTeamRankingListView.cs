using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002543 RID: 9539
	[Token(Token = "0x2002543")]
	internal class UISPHudTeamRankingListView : UIBaseView
	{
		// Token: 0x0600C596 RID: 50582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C596")]
		[Address(RVA = "0x1EFB758", Offset = "0x1EFB758", VA = "0x7BBC6FB758", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C597 RID: 50583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C597")]
		[Address(RVA = "0x1EFB950", Offset = "0x1EFB950", VA = "0x7BBC6FB950")]
		public UISPHudTeamRankingListView()
		{
		}

		// Token: 0x0400F41B RID: 62491
		[Token(Token = "0x400F41B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject InfoPanel;

		// Token: 0x0400F41C RID: 62492
		[Token(Token = "0x400F41C")]
		[FieldOffset(Offset = "0x28")]
		public TweenPosition TweenPosition;

		// Token: 0x0400F41D RID: 62493
		[Token(Token = "0x400F41D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject team;

		// Token: 0x0400F41E RID: 62494
		[Token(Token = "0x400F41E")]
		[FieldOffset(Offset = "0x38")]
		public UIScrollView TeamList;

		// Token: 0x0400F41F RID: 62495
		[Token(Token = "0x400F41F")]
		[FieldOffset(Offset = "0x40")]
		public UIEasyList TeamGrid;

		// Token: 0x0400F420 RID: 62496
		[Token(Token = "0x400F420")]
		[FieldOffset(Offset = "0x48")]
		public GameObject CombatLevelGo;
	}
}
