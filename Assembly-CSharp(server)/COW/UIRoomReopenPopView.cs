using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024EA RID: 9450
	[Token(Token = "0x20024EA")]
	public class UIRoomReopenPopView : UIBaseView
	{
		// Token: 0x0600C4E4 RID: 50404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4E4")]
		[Address(RVA = "0x1A2349C", Offset = "0x1A2349C", VA = "0x7BBC22349C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4E5 RID: 50405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4E5")]
		[Address(RVA = "0x1A23640", Offset = "0x1A23640", VA = "0x7BBC223640")]
		public UIRoomReopenPopView()
		{
		}

		// Token: 0x0400F06B RID: 61547
		[Token(Token = "0x400F06B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ReopenGo;

		// Token: 0x0400F06C RID: 61548
		[Token(Token = "0x400F06C")]
		[FieldOffset(Offset = "0x28")]
		public UIInput RoomIdInput;

		// Token: 0x0400F06D RID: 61549
		[Token(Token = "0x400F06D")]
		[FieldOffset(Offset = "0x30")]
		public UILabel InfoTxt;

		// Token: 0x0400F06E RID: 61550
		[Token(Token = "0x400F06E")]
		[FieldOffset(Offset = "0x38")]
		public UIButton ConfirmBtn;

		// Token: 0x0400F06F RID: 61551
		[Token(Token = "0x400F06F")]
		[FieldOffset(Offset = "0x40")]
		public UISprite BtnSprite;
	}
}
