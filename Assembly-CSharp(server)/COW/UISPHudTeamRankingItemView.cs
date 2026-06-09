using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002542 RID: 9538
	[Token(Token = "0x2002542")]
	public class UISPHudTeamRankingItemView : UIBaseView
	{
		// Token: 0x0600C594 RID: 50580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C594")]
		[Address(RVA = "0x1EFA58C", Offset = "0x1EFA58C", VA = "0x7BBC6FA58C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C595 RID: 50581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C595")]
		[Address(RVA = "0x1EFA924", Offset = "0x1EFA924", VA = "0x7BBC6FA924")]
		public UISPHudTeamRankingItemView()
		{
		}

		// Token: 0x0400F40D RID: 62477
		[Token(Token = "0x400F40D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject DeadBg;

		// Token: 0x0400F40E RID: 62478
		[Token(Token = "0x400F40E")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget TeamIconGo;

		// Token: 0x0400F40F RID: 62479
		[Token(Token = "0x400F40F")]
		[FieldOffset(Offset = "0x30")]
		public UIEffectSprite TeamIcon;

		// Token: 0x0400F410 RID: 62480
		[Token(Token = "0x400F410")]
		[FieldOffset(Offset = "0x38")]
		public UISprite TeamFakeIcon;

		// Token: 0x0400F411 RID: 62481
		[Token(Token = "0x400F411")]
		[FieldOffset(Offset = "0x40")]
		public UISprite TeamBg;

		// Token: 0x0400F412 RID: 62482
		[Token(Token = "0x400F412")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TeamId;

		// Token: 0x0400F413 RID: 62483
		[Token(Token = "0x400F413")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Name;

		// Token: 0x0400F414 RID: 62484
		[Token(Token = "0x400F414")]
		[FieldOffset(Offset = "0x58")]
		public UISprite P1;

		// Token: 0x0400F415 RID: 62485
		[Token(Token = "0x400F415")]
		[FieldOffset(Offset = "0x60")]
		public UISprite P2;

		// Token: 0x0400F416 RID: 62486
		[Token(Token = "0x400F416")]
		[FieldOffset(Offset = "0x68")]
		public UISprite P3;

		// Token: 0x0400F417 RID: 62487
		[Token(Token = "0x400F417")]
		[FieldOffset(Offset = "0x70")]
		public UISprite P4;

		// Token: 0x0400F418 RID: 62488
		[Token(Token = "0x400F418")]
		[FieldOffset(Offset = "0x78")]
		public UILabel LiveCnt;

		// Token: 0x0400F419 RID: 62489
		[Token(Token = "0x400F419")]
		[FieldOffset(Offset = "0x80")]
		public UILabel KillCnt;

		// Token: 0x0400F41A RID: 62490
		[Token(Token = "0x400F41A")]
		[FieldOffset(Offset = "0x88")]
		public UILabel CombatLevel;
	}
}
