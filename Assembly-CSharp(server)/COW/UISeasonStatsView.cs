using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024EE RID: 9454
	[Token(Token = "0x20024EE")]
	public class UISeasonStatsView : UIBaseView
	{
		// Token: 0x0600C4EC RID: 50412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4EC")]
		[Address(RVA = "0x162E394", Offset = "0x162E394", VA = "0x7BBBE2E394", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4ED RID: 50413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4ED")]
		[Address(RVA = "0x162E664", Offset = "0x162E664", VA = "0x7BBBE2E664")]
		public UISeasonStatsView()
		{
		}

		// Token: 0x0400F0C5 RID: 61637
		[Token(Token = "0x400F0C5")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Content;

		// Token: 0x0400F0C6 RID: 61638
		[Token(Token = "0x400F0C6")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnViewAll;

		// Token: 0x0400F0C7 RID: 61639
		[Token(Token = "0x400F0C7")]
		[FieldOffset(Offset = "0x30")]
		public Transform ItemPos;

		// Token: 0x0400F0C8 RID: 61640
		[Token(Token = "0x400F0C8")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ItemRank;

		// Token: 0x0400F0C9 RID: 61641
		[Token(Token = "0x400F0C9")]
		[FieldOffset(Offset = "0x40")]
		public Transform ItemPos2;

		// Token: 0x0400F0CA RID: 61642
		[Token(Token = "0x400F0CA")]
		[FieldOffset(Offset = "0x48")]
		public UISprite ItemRank2;

		// Token: 0x0400F0CB RID: 61643
		[Token(Token = "0x400F0CB")]
		[FieldOffset(Offset = "0x50")]
		public UIButton DetailBtn;

		// Token: 0x0400F0CC RID: 61644
		[Token(Token = "0x400F0CC")]
		[FieldOffset(Offset = "0x58")]
		public UILabel MatchCountLabel;

		// Token: 0x0400F0CD RID: 61645
		[Token(Token = "0x400F0CD")]
		[FieldOffset(Offset = "0x60")]
		public UILabel KDTitle;

		// Token: 0x0400F0CE RID: 61646
		[Token(Token = "0x400F0CE")]
		[FieldOffset(Offset = "0x68")]
		public UILabel KDLabel;
	}
}
