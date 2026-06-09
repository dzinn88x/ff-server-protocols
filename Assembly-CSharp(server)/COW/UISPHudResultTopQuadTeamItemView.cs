using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002535 RID: 9525
	[Token(Token = "0x2002535")]
	public class UISPHudResultTopQuadTeamItemView : UIBaseView
	{
		// Token: 0x0600C57A RID: 50554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C57A")]
		[Address(RVA = "0x1EF26F0", Offset = "0x1EF26F0", VA = "0x7BBC6F26F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C57B RID: 50555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C57B")]
		[Address(RVA = "0x1EF297C", Offset = "0x1EF297C", VA = "0x7BBC6F297C")]
		public UISPHudResultTopQuadTeamItemView()
		{
		}

		// Token: 0x0400F369 RID: 62313
		[Token(Token = "0x400F369")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UISPHudResultTopQuadTeamItem;

		// Token: 0x0400F36A RID: 62314
		[Token(Token = "0x400F36A")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TeamName;

		// Token: 0x0400F36B RID: 62315
		[Token(Token = "0x400F36B")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BG;

		// Token: 0x0400F36C RID: 62316
		[Token(Token = "0x400F36C")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Rank;

		// Token: 0x0400F36D RID: 62317
		[Token(Token = "0x400F36D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject IconBG;

		// Token: 0x0400F36E RID: 62318
		[Token(Token = "0x400F36E")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Icon;

		// Token: 0x0400F36F RID: 62319
		[Token(Token = "0x400F36F")]
		[FieldOffset(Offset = "0x50")]
		public UISprite FakeIcon;

		// Token: 0x0400F370 RID: 62320
		[Token(Token = "0x400F370")]
		[FieldOffset(Offset = "0x58")]
		public UITable Table;

		// Token: 0x0400F371 RID: 62321
		[Token(Token = "0x400F371")]
		[FieldOffset(Offset = "0x60")]
		public UITable LeagueTable;
	}
}
