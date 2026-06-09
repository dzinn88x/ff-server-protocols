using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002527 RID: 9511
	[Token(Token = "0x2002527")]
	public class UISPHudRankListItemView : UIBaseView
	{
		// Token: 0x0600C55E RID: 50526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C55E")]
		[Address(RVA = "0x1EEE548", Offset = "0x1EEE548", VA = "0x7BBC6EE548", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C55F RID: 50527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C55F")]
		[Address(RVA = "0x1EEE7C4", Offset = "0x1EEE7C4", VA = "0x7BBC6EE7C4")]
		public UISPHudRankListItemView()
		{
		}

		// Token: 0x0400F305 RID: 62213
		[Token(Token = "0x400F305")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UISPHudRankListItem;

		// Token: 0x0400F306 RID: 62214
		[Token(Token = "0x400F306")]
		[FieldOffset(Offset = "0x28")]
		public UILabel RankLabel;

		// Token: 0x0400F307 RID: 62215
		[Token(Token = "0x400F307")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Grade1;

		// Token: 0x0400F308 RID: 62216
		[Token(Token = "0x400F308")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Grade2;

		// Token: 0x0400F309 RID: 62217
		[Token(Token = "0x400F309")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Grade3;

		// Token: 0x0400F30A RID: 62218
		[Token(Token = "0x400F30A")]
		[FieldOffset(Offset = "0x48")]
		public UISprite TeamIcon;

		// Token: 0x0400F30B RID: 62219
		[Token(Token = "0x400F30B")]
		[FieldOffset(Offset = "0x50")]
		public UISprite FakeIcon;

		// Token: 0x0400F30C RID: 62220
		[Token(Token = "0x400F30C")]
		[FieldOffset(Offset = "0x58")]
		public UILabel TeamName;

		// Token: 0x0400F30D RID: 62221
		[Token(Token = "0x400F30D")]
		[FieldOffset(Offset = "0x60")]
		public UILabel ScoreLabel;
	}
}
