using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020FA RID: 8442
	[Token(Token = "0x20020FA")]
	public class UIAvatarConfirmPopView : UIBaseView
	{
		// Token: 0x0600BD05 RID: 48389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD05")]
		[Address(RVA = "0x1B24DC0", Offset = "0x1B24DC0", VA = "0x7BBC324DC0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD06 RID: 48390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD06")]
		[Address(RVA = "0x1B25088", Offset = "0x1B25088", VA = "0x7BBC325088")]
		public UIAvatarConfirmPopView()
		{
		}

		// Token: 0x0400C005 RID: 49157
		[Token(Token = "0x400C005")]
		[FieldOffset(Offset = "0x20")]
		public GameObject PopType1;

		// Token: 0x0400C006 RID: 49158
		[Token(Token = "0x400C006")]
		[FieldOffset(Offset = "0x28")]
		public UIButton CancelBtn;

		// Token: 0x0400C007 RID: 49159
		[Token(Token = "0x400C007")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Tips1;

		// Token: 0x0400C008 RID: 49160
		[Token(Token = "0x400C008")]
		[FieldOffset(Offset = "0x38")]
		public UIButton LevelUpBtn;

		// Token: 0x0400C009 RID: 49161
		[Token(Token = "0x400C009")]
		[FieldOffset(Offset = "0x40")]
		public GameObject PopType2;

		// Token: 0x0400C00A RID: 49162
		[Token(Token = "0x400C00A")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Newtips1;

		// Token: 0x0400C00B RID: 49163
		[Token(Token = "0x400C00B")]
		[FieldOffset(Offset = "0x50")]
		public UILabel NewTips2;

		// Token: 0x0400C00C RID: 49164
		[Token(Token = "0x400C00C")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BuyBtn;

		// Token: 0x0400C00D RID: 49165
		[Token(Token = "0x400C00D")]
		[FieldOffset(Offset = "0x60")]
		public UILabel GemCount;

		// Token: 0x0400C00E RID: 49166
		[Token(Token = "0x400C00E")]
		[FieldOffset(Offset = "0x68")]
		public UIButton CancelBtn1;
	}
}
