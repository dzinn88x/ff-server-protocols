using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200252E RID: 9518
	[Token(Token = "0x200252E")]
	public class UISPHudResultNormalLiteTeamItemView : UIBaseView
	{
		// Token: 0x0600C56C RID: 50540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C56C")]
		[Address(RVA = "0x1EF0834", Offset = "0x1EF0834", VA = "0x7BBC6F0834", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C56D RID: 50541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C56D")]
		[Address(RVA = "0x1EF0A1C", Offset = "0x1EF0A1C", VA = "0x7BBC6F0A1C")]
		public UISPHudResultNormalLiteTeamItemView()
		{
		}

		// Token: 0x0400F347 RID: 62279
		[Token(Token = "0x400F347")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UISPHudResultNormalLiteTeamItem;

		// Token: 0x0400F348 RID: 62280
		[Token(Token = "0x400F348")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TeamName;

		// Token: 0x0400F349 RID: 62281
		[Token(Token = "0x400F349")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Rank;

		// Token: 0x0400F34A RID: 62282
		[Token(Token = "0x400F34A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject BG;

		// Token: 0x0400F34B RID: 62283
		[Token(Token = "0x400F34B")]
		[FieldOffset(Offset = "0x40")]
		public UITable Table;

		// Token: 0x0400F34C RID: 62284
		[Token(Token = "0x400F34C")]
		[FieldOffset(Offset = "0x48")]
		public UITable LeagueTable;
	}
}
