using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200237B RID: 9083
	[Token(Token = "0x200237B")]
	public class UIHUDTeamParachuteActionView : UIBaseView
	{
		// Token: 0x0600C206 RID: 49670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C206")]
		[Address(RVA = "0x1D52320", Offset = "0x1D52320", VA = "0x7BBC552320", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C207 RID: 49671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C207")]
		[Address(RVA = "0x1D5277C", Offset = "0x1D5277C", VA = "0x7BBC55277C")]
		public UIHUDTeamParachuteActionView()
		{
		}

		// Token: 0x0400DC5D RID: 56413
		[Token(Token = "0x400DC5D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ActionBtn;

		// Token: 0x0400DC5E RID: 56414
		[Token(Token = "0x400DC5E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ActionName;

		// Token: 0x0400DC5F RID: 56415
		[Token(Token = "0x400DC5F")]
		[FieldOffset(Offset = "0x30")]
		public UISprite ActionIcon;

		// Token: 0x0400DC60 RID: 56416
		[Token(Token = "0x400DC60")]
		[FieldOffset(Offset = "0x38")]
		public GameObject leaderPanel;

		// Token: 0x0400DC61 RID: 56417
		[Token(Token = "0x400DC61")]
		[FieldOffset(Offset = "0x40")]
		public UIButton bgBtn;

		// Token: 0x0400DC62 RID: 56418
		[Token(Token = "0x400DC62")]
		[FieldOffset(Offset = "0x48")]
		public GameObject teammate1;

		// Token: 0x0400DC63 RID: 56419
		[Token(Token = "0x400DC63")]
		[FieldOffset(Offset = "0x50")]
		public UILabel teamid1Selected;

		// Token: 0x0400DC64 RID: 56420
		[Token(Token = "0x400DC64")]
		[FieldOffset(Offset = "0x58")]
		public UILabel teamid1;

		// Token: 0x0400DC65 RID: 56421
		[Token(Token = "0x400DC65")]
		[FieldOffset(Offset = "0x60")]
		public UIToggleButton btn1;

		// Token: 0x0400DC66 RID: 56422
		[Token(Token = "0x400DC66")]
		[FieldOffset(Offset = "0x68")]
		public GameObject teammate2;

		// Token: 0x0400DC67 RID: 56423
		[Token(Token = "0x400DC67")]
		[FieldOffset(Offset = "0x70")]
		public UILabel teamid2Selected;

		// Token: 0x0400DC68 RID: 56424
		[Token(Token = "0x400DC68")]
		[FieldOffset(Offset = "0x78")]
		public UILabel teamid2;

		// Token: 0x0400DC69 RID: 56425
		[Token(Token = "0x400DC69")]
		[FieldOffset(Offset = "0x80")]
		public UIToggleButton btn2;

		// Token: 0x0400DC6A RID: 56426
		[Token(Token = "0x400DC6A")]
		[FieldOffset(Offset = "0x88")]
		public GameObject teammate3;

		// Token: 0x0400DC6B RID: 56427
		[Token(Token = "0x400DC6B")]
		[FieldOffset(Offset = "0x90")]
		public UILabel teamid3Selected;

		// Token: 0x0400DC6C RID: 56428
		[Token(Token = "0x400DC6C")]
		[FieldOffset(Offset = "0x98")]
		public UILabel teamid3;

		// Token: 0x0400DC6D RID: 56429
		[Token(Token = "0x400DC6D")]
		[FieldOffset(Offset = "0xA0")]
		public UIToggleButton btn3;
	}
}
