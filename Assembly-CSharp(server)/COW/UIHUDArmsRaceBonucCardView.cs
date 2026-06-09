using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002264 RID: 8804
	[Token(Token = "0x2002264")]
	public class UIHUDArmsRaceBonucCardView : UIBaseView
	{
		// Token: 0x0600BFD9 RID: 49113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD9")]
		[Address(RVA = "0x16B09E4", Offset = "0x16B09E4", VA = "0x7BBBEB09E4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFDA RID: 49114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFDA")]
		[Address(RVA = "0x16B0AD4", Offset = "0x16B0AD4", VA = "0x7BBBEB0AD4")]
		public UIHUDArmsRaceBonucCardView()
		{
		}

		// Token: 0x0400D368 RID: 54120
		[Token(Token = "0x400D368")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UseBtn;

		// Token: 0x0400D369 RID: 54121
		[Token(Token = "0x400D369")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Btn_cancel;
	}
}
