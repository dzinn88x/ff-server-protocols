using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002505 RID: 9477
	[Token(Token = "0x2002505")]
	public class UISPHudCSRoundResultListView : UIBaseView
	{
		// Token: 0x0600C51C RID: 50460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C51C")]
		[Address(RVA = "0x1EE33B0", Offset = "0x1EE33B0", VA = "0x7BBC6E33B0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C51D RID: 50461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C51D")]
		[Address(RVA = "0x1EE3524", Offset = "0x1EE3524", VA = "0x7BBC6E3524")]
		public UISPHudCSRoundResultListView()
		{
		}

		// Token: 0x0400F1BE RID: 61886
		[Token(Token = "0x400F1BE")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition TWTitle;

		// Token: 0x0400F1BF RID: 61887
		[Token(Token = "0x400F1BF")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid ItemListGrid;

		// Token: 0x0400F1C0 RID: 61888
		[Token(Token = "0x400F1C0")]
		[FieldOffset(Offset = "0x30")]
		public TweenPosition TWGrid;

		// Token: 0x0400F1C1 RID: 61889
		[Token(Token = "0x400F1C1")]
		[FieldOffset(Offset = "0x38")]
		public UISprite GlassBG;
	}
}
