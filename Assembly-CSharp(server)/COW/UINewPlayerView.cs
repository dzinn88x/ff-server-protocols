using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002462 RID: 9314
	[Token(Token = "0x2002462")]
	internal class UINewPlayerView : UIBaseView
	{
		// Token: 0x0600C3D4 RID: 50132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3D4")]
		[Address(RVA = "0x1AFEDC0", Offset = "0x1AFEDC0", VA = "0x7BBC2FEDC0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3D5 RID: 50133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3D5")]
		[Address(RVA = "0x1AFF0B0", Offset = "0x1AFF0B0", VA = "0x7BBC2FF0B0")]
		public UINewPlayerView()
		{
		}

		// Token: 0x0400E916 RID: 59670
		[Token(Token = "0x400E916")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Mask;

		// Token: 0x0400E917 RID: 59671
		[Token(Token = "0x400E917")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid Tabs;

		// Token: 0x0400E918 RID: 59672
		[Token(Token = "0x400E918")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButton SigninBtn;

		// Token: 0x0400E919 RID: 59673
		[Token(Token = "0x400E919")]
		[FieldOffset(Offset = "0x38")]
		public GameObject SigninRedDot;

		// Token: 0x0400E91A RID: 59674
		[Token(Token = "0x400E91A")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButton PathBtn;

		// Token: 0x0400E91B RID: 59675
		[Token(Token = "0x400E91B")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PathRedDot;

		// Token: 0x0400E91C RID: 59676
		[Token(Token = "0x400E91C")]
		[FieldOffset(Offset = "0x50")]
		public UIToggleButton UpGradeBtn;

		// Token: 0x0400E91D RID: 59677
		[Token(Token = "0x400E91D")]
		[FieldOffset(Offset = "0x58")]
		public GameObject UpGradeRedDot;

		// Token: 0x0400E91E RID: 59678
		[Token(Token = "0x400E91E")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnClose;

		// Token: 0x0400E91F RID: 59679
		[Token(Token = "0x400E91F")]
		[FieldOffset(Offset = "0x68")]
		public UILabel TitleLabel;
	}
}
