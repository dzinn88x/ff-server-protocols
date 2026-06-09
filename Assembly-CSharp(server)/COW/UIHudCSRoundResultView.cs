using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022AB RID: 8875
	[Token(Token = "0x20022AB")]
	public class UIHudCSRoundResultView : UIBaseView
	{
		// Token: 0x0600C066 RID: 49254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C066")]
		[Address(RVA = "0x19C29F0", Offset = "0x19C29F0", VA = "0x7BBC1C29F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C067 RID: 49255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C067")]
		[Address(RVA = "0x19C2CD0", Offset = "0x19C2CD0", VA = "0x7BBC1C2CD0")]
		public UIHudCSRoundResultView()
		{
		}

		// Token: 0x0400D52A RID: 54570
		[Token(Token = "0x400D52A")]
		[FieldOffset(Offset = "0x20")]
		public UISprite wolf;

		// Token: 0x0400D52B RID: 54571
		[Token(Token = "0x400D52B")]
		[FieldOffset(Offset = "0x28")]
		public GameObject LeftTeam;

		// Token: 0x0400D52C RID: 54572
		[Token(Token = "0x400D52C")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RightTeam;

		// Token: 0x0400D52D RID: 54573
		[Token(Token = "0x400D52D")]
		[FieldOffset(Offset = "0x38")]
		public GameObject winSprite;

		// Token: 0x0400D52E RID: 54574
		[Token(Token = "0x400D52E")]
		[FieldOffset(Offset = "0x40")]
		public GameObject loseSprite;

		// Token: 0x0400D52F RID: 54575
		[Token(Token = "0x400D52F")]
		[FieldOffset(Offset = "0x48")]
		public UILabel roundInfo;

		// Token: 0x0400D530 RID: 54576
		[Token(Token = "0x400D530")]
		[FieldOffset(Offset = "0x50")]
		public GameObject coinsContainer;

		// Token: 0x0400D531 RID: 54577
		[Token(Token = "0x400D531")]
		[FieldOffset(Offset = "0x58")]
		public UILabel coins;

		// Token: 0x0400D532 RID: 54578
		[Token(Token = "0x400D532")]
		[FieldOffset(Offset = "0x60")]
		public UIGrid bonusGrid;

		// Token: 0x0400D533 RID: 54579
		[Token(Token = "0x400D533")]
		[FieldOffset(Offset = "0x68")]
		public GameObject bonusItem;

		// Token: 0x0400D534 RID: 54580
		[Token(Token = "0x400D534")]
		[FieldOffset(Offset = "0x70")]
		public UILabel LabelReason;
	}
}
