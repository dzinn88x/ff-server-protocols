using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002549 RID: 9545
	[Token(Token = "0x2002549")]
	public class UISPMapTeamListItemView : UIBaseView
	{
		// Token: 0x0600C5A2 RID: 50594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A2")]
		[Address(RVA = "0x1627AA8", Offset = "0x1627AA8", VA = "0x7BBBE27AA8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5A3 RID: 50595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A3")]
		[Address(RVA = "0x1627E14", Offset = "0x1627E14", VA = "0x7BBBE27E14")]
		public UISPMapTeamListItemView()
		{
		}

		// Token: 0x0400F448 RID: 62536
		[Token(Token = "0x400F448")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Rank;

		// Token: 0x0400F449 RID: 62537
		[Token(Token = "0x400F449")]
		[FieldOffset(Offset = "0x28")]
		public GameObject RankBGOrdinary;

		// Token: 0x0400F44A RID: 62538
		[Token(Token = "0x400F44A")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RankBGGold;

		// Token: 0x0400F44B RID: 62539
		[Token(Token = "0x400F44B")]
		[FieldOffset(Offset = "0x38")]
		public GameObject RankBGSilver;

		// Token: 0x0400F44C RID: 62540
		[Token(Token = "0x400F44C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject RankBGCopper;

		// Token: 0x0400F44D RID: 62541
		[Token(Token = "0x400F44D")]
		[FieldOffset(Offset = "0x48")]
		public UISprite TeamIcon;

		// Token: 0x0400F44E RID: 62542
		[Token(Token = "0x400F44E")]
		[FieldOffset(Offset = "0x50")]
		public UILabel TeamShortName;

		// Token: 0x0400F44F RID: 62543
		[Token(Token = "0x400F44F")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid PlayerNameList;

		// Token: 0x0400F450 RID: 62544
		[Token(Token = "0x400F450")]
		[FieldOffset(Offset = "0x60")]
		public UILabel PlayerName_1;

		// Token: 0x0400F451 RID: 62545
		[Token(Token = "0x400F451")]
		[FieldOffset(Offset = "0x68")]
		public UILabel PlayerName_2;

		// Token: 0x0400F452 RID: 62546
		[Token(Token = "0x400F452")]
		[FieldOffset(Offset = "0x70")]
		public UILabel PlayerName_3;

		// Token: 0x0400F453 RID: 62547
		[Token(Token = "0x400F453")]
		[FieldOffset(Offset = "0x78")]
		public UILabel PlayerName_4;

		// Token: 0x0400F454 RID: 62548
		[Token(Token = "0x400F454")]
		[FieldOffset(Offset = "0x80")]
		public GameObject TeamDeadMask;
	}
}
