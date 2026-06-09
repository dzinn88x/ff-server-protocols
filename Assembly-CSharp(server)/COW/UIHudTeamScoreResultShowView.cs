using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200237D RID: 9085
	[Token(Token = "0x200237D")]
	public class UIHudTeamScoreResultShowView : UIBaseView
	{
		// Token: 0x0600C20A RID: 49674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C20A")]
		[Address(RVA = "0x15DB5A0", Offset = "0x15DB5A0", VA = "0x7BBBDDB5A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C20B RID: 49675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C20B")]
		[Address(RVA = "0x15DB90C", Offset = "0x15DB90C", VA = "0x7BBBDDB90C")]
		public UIHudTeamScoreResultShowView()
		{
		}

		// Token: 0x0400DC6F RID: 56431
		[Token(Token = "0x400DC6F")]
		[FieldOffset(Offset = "0x20")]
		public GameObject CallSignContainer;

		// Token: 0x0400DC70 RID: 56432
		[Token(Token = "0x400DC70")]
		[FieldOffset(Offset = "0x28")]
		public GameObject TeamInfoContainer;

		// Token: 0x0400DC71 RID: 56433
		[Token(Token = "0x400DC71")]
		[FieldOffset(Offset = "0x30")]
		public GameObject OptTeamIcon;

		// Token: 0x0400DC72 RID: 56434
		[Token(Token = "0x400DC72")]
		[FieldOffset(Offset = "0x38")]
		public GameObject LocalTeamIcon;

		// Token: 0x0400DC73 RID: 56435
		[Token(Token = "0x400DC73")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Team2Icon;

		// Token: 0x0400DC74 RID: 56436
		[Token(Token = "0x400DC74")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Team1Icon;

		// Token: 0x0400DC75 RID: 56437
		[Token(Token = "0x400DC75")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Booyah;

		// Token: 0x0400DC76 RID: 56438
		[Token(Token = "0x400DC76")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Score;

		// Token: 0x0400DC77 RID: 56439
		[Token(Token = "0x400DC77")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnMask;

		// Token: 0x0400DC78 RID: 56440
		[Token(Token = "0x400DC78")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BtnShare;

		// Token: 0x0400DC79 RID: 56441
		[Token(Token = "0x400DC79")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnNext;

		// Token: 0x0400DC7A RID: 56442
		[Token(Token = "0x400DC7A")]
		[FieldOffset(Offset = "0x78")]
		public UILabel EvaluationLabel;

		// Token: 0x0400DC7B RID: 56443
		[Token(Token = "0x400DC7B")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Mvp;
	}
}
