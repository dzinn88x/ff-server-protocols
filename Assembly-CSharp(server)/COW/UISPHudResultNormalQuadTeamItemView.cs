using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200252F RID: 9519
	[Token(Token = "0x200252F")]
	public class UISPHudResultNormalQuadTeamItemView : UIBaseView
	{
		// Token: 0x0600C56E RID: 50542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C56E")]
		[Address(RVA = "0x1EF0A24", Offset = "0x1EF0A24", VA = "0x7BBC6F0A24", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C56F RID: 50543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C56F")]
		[Address(RVA = "0x1EF0C14", Offset = "0x1EF0C14", VA = "0x7BBC6F0C14")]
		public UISPHudResultNormalQuadTeamItemView()
		{
		}

		// Token: 0x0400F34D RID: 62285
		[Token(Token = "0x400F34D")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UISPHudResultNormalQuadTeamItem;

		// Token: 0x0400F34E RID: 62286
		[Token(Token = "0x400F34E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TeamName;

		// Token: 0x0400F34F RID: 62287
		[Token(Token = "0x400F34F")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BG;

		// Token: 0x0400F350 RID: 62288
		[Token(Token = "0x400F350")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Rank;

		// Token: 0x0400F351 RID: 62289
		[Token(Token = "0x400F351")]
		[FieldOffset(Offset = "0x40")]
		public UITable Table;

		// Token: 0x0400F352 RID: 62290
		[Token(Token = "0x400F352")]
		[FieldOffset(Offset = "0x48")]
		public UITable LeagueTable;
	}
}
