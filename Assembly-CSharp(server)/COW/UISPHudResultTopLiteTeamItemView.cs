using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002534 RID: 9524
	[Token(Token = "0x2002534")]
	public class UISPHudResultTopLiteTeamItemView : UIBaseView
	{
		// Token: 0x0600C578 RID: 50552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C578")]
		[Address(RVA = "0x1EF24F0", Offset = "0x1EF24F0", VA = "0x7BBC6F24F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C579 RID: 50553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C579")]
		[Address(RVA = "0x1EF26E8", Offset = "0x1EF26E8", VA = "0x7BBC6F26E8")]
		public UISPHudResultTopLiteTeamItemView()
		{
		}

		// Token: 0x0400F363 RID: 62307
		[Token(Token = "0x400F363")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UISPHudResultTopLiteTeamItem;

		// Token: 0x0400F364 RID: 62308
		[Token(Token = "0x400F364")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TeamName;

		// Token: 0x0400F365 RID: 62309
		[Token(Token = "0x400F365")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Rank;

		// Token: 0x0400F366 RID: 62310
		[Token(Token = "0x400F366")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BG;

		// Token: 0x0400F367 RID: 62311
		[Token(Token = "0x400F367")]
		[FieldOffset(Offset = "0x40")]
		public UITable Table;

		// Token: 0x0400F368 RID: 62312
		[Token(Token = "0x400F368")]
		[FieldOffset(Offset = "0x48")]
		public UITable LeagueTable;
	}
}
