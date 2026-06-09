using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024E5 RID: 9445
	[Token(Token = "0x20024E5")]
	public class UIRoomPasswordConfirmView : UIBaseView
	{
		// Token: 0x0600C4DA RID: 50394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4DA")]
		[Address(RVA = "0x1A1EB2C", Offset = "0x1A1EB2C", VA = "0x7BBC21EB2C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4DB RID: 50395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4DB")]
		[Address(RVA = "0x1A1ED78", Offset = "0x1A1ED78", VA = "0x7BBC21ED78")]
		public UIRoomPasswordConfirmView()
		{
		}

		// Token: 0x0400F03F RID: 61503
		[Token(Token = "0x400F03F")]
		[FieldOffset(Offset = "0x20")]
		public GameObject GroupNameGo;

		// Token: 0x0400F040 RID: 61504
		[Token(Token = "0x400F040")]
		[FieldOffset(Offset = "0x28")]
		public UIInput GroupNameInput;

		// Token: 0x0400F041 RID: 61505
		[Token(Token = "0x400F041")]
		[FieldOffset(Offset = "0x30")]
		public UIInput GroupNameAbbrInput;

		// Token: 0x0400F042 RID: 61506
		[Token(Token = "0x400F042")]
		[FieldOffset(Offset = "0x38")]
		public GameObject PasswordGo;

		// Token: 0x0400F043 RID: 61507
		[Token(Token = "0x400F043")]
		[FieldOffset(Offset = "0x40")]
		public UIInput PasswordInput;

		// Token: 0x0400F044 RID: 61508
		[Token(Token = "0x400F044")]
		[FieldOffset(Offset = "0x48")]
		public UIButton CancelBtn;

		// Token: 0x0400F045 RID: 61509
		[Token(Token = "0x400F045")]
		[FieldOffset(Offset = "0x50")]
		public UIButton ConfirmBtn;

		// Token: 0x0400F046 RID: 61510
		[Token(Token = "0x400F046")]
		[FieldOffset(Offset = "0x58")]
		public UISprite BtnSprite;
	}
}
