using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024E2 RID: 9442
	[Token(Token = "0x20024E2")]
	public class UIRoomModeSelectPopupItemView : UIBaseView
	{
		// Token: 0x0600C4D4 RID: 50388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4D4")]
		[Address(RVA = "0x1A1B7F0", Offset = "0x1A1B7F0", VA = "0x7BBC21B7F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4D5 RID: 50389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4D5")]
		[Address(RVA = "0x1A1B954", Offset = "0x1A1B954", VA = "0x7BBC21B954")]
		public UIRoomModeSelectPopupItemView()
		{
		}

		// Token: 0x0400F02D RID: 61485
		[Token(Token = "0x400F02D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton SelectBtn;

		// Token: 0x0400F02E RID: 61486
		[Token(Token = "0x400F02E")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Select;

		// Token: 0x0400F02F RID: 61487
		[Token(Token = "0x400F02F")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Unselect;

		// Token: 0x0400F030 RID: 61488
		[Token(Token = "0x400F030")]
		[FieldOffset(Offset = "0x38")]
		public UILabel NameTxt;
	}
}
