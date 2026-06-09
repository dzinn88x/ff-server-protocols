using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002353 RID: 9043
	[Token(Token = "0x2002353")]
	public class UIHudReportView : UIBaseView
	{
		// Token: 0x0600C1B6 RID: 49590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B6")]
		[Address(RVA = "0x17F35F4", Offset = "0x17F35F4", VA = "0x7BBBFF35F4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1B7 RID: 49591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B7")]
		[Address(RVA = "0x17F39B4", Offset = "0x17F39B4", VA = "0x7BBBFF39B4")]
		public UIHudReportView()
		{
		}

		// Token: 0x0400DAFD RID: 56061
		[Token(Token = "0x400DAFD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400DAFE RID: 56062
		[Token(Token = "0x400DAFE")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LabelTitle;

		// Token: 0x0400DAFF RID: 56063
		[Token(Token = "0x400DAFF")]
		[FieldOffset(Offset = "0x30")]
		public UISprite mask;

		// Token: 0x0400DB00 RID: 56064
		[Token(Token = "0x400DB00")]
		[FieldOffset(Offset = "0x38")]
		public UILabel name;

		// Token: 0x0400DB01 RID: 56065
		[Token(Token = "0x400DB01")]
		[FieldOffset(Offset = "0x40")]
		public UILabel playerId;

		// Token: 0x0400DB02 RID: 56066
		[Token(Token = "0x400DB02")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid ToggleBtnGrid;

		// Token: 0x0400DB03 RID: 56067
		[Token(Token = "0x400DB03")]
		[FieldOffset(Offset = "0x50")]
		public UIToggleButton CheatToggle;

		// Token: 0x0400DB04 RID: 56068
		[Token(Token = "0x400DB04")]
		[FieldOffset(Offset = "0x58")]
		public UIToggleButton DirtyNameToggle;

		// Token: 0x0400DB05 RID: 56069
		[Token(Token = "0x400DB05")]
		[FieldOffset(Offset = "0x60")]
		public UIToggleButton NegativeToggle;

		// Token: 0x0400DB06 RID: 56070
		[Token(Token = "0x400DB06")]
		[FieldOffset(Offset = "0x68")]
		public UIToggleButton TeamToggle;

		// Token: 0x0400DB07 RID: 56071
		[Token(Token = "0x400DB07")]
		[FieldOffset(Offset = "0x70")]
		public UIToggleButton HangUpToggle;

		// Token: 0x0400DB08 RID: 56072
		[Token(Token = "0x400DB08")]
		[FieldOffset(Offset = "0x78")]
		public UILabel description;

		// Token: 0x0400DB09 RID: 56073
		[Token(Token = "0x400DB09")]
		[FieldOffset(Offset = "0x80")]
		public UIButton btnConfirm;

		// Token: 0x0400DB0A RID: 56074
		[Token(Token = "0x400DB0A")]
		[FieldOffset(Offset = "0x88")]
		public UIButton btnCancel;
	}
}
