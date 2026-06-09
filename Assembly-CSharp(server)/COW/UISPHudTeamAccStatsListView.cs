using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200253B RID: 9531
	[Token(Token = "0x200253B")]
	public class UISPHudTeamAccStatsListView : UIBaseView
	{
		// Token: 0x0600C586 RID: 50566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C586")]
		[Address(RVA = "0x1EF5E64", Offset = "0x1EF5E64", VA = "0x7BBC6F5E64", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C587 RID: 50567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C587")]
		[Address(RVA = "0x1EF5FD8", Offset = "0x1EF5FD8", VA = "0x7BBC6F5FD8")]
		public UISPHudTeamAccStatsListView()
		{
		}

		// Token: 0x0400F399 RID: 62361
		[Token(Token = "0x400F399")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition InfoPanel;

		// Token: 0x0400F39A RID: 62362
		[Token(Token = "0x400F39A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject team;

		// Token: 0x0400F39B RID: 62363
		[Token(Token = "0x400F39B")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView TeamList;

		// Token: 0x0400F39C RID: 62364
		[Token(Token = "0x400F39C")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid TeamGrid;
	}
}
