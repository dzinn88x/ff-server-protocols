using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024EF RID: 9455
	[Token(Token = "0x20024EF")]
	public class UISecondConfirmSmallView : UIBaseView
	{
		// Token: 0x0600C4EE RID: 50414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4EE")]
		[Address(RVA = "0x162F930", Offset = "0x162F930", VA = "0x7BBBE2F930", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4EF RID: 50415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4EF")]
		[Address(RVA = "0x162FAA4", Offset = "0x162FAA4", VA = "0x7BBBE2FAA4")]
		public UISecondConfirmSmallView()
		{
		}

		// Token: 0x0400F0CF RID: 61647
		[Token(Token = "0x400F0CF")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CancelBtn;

		// Token: 0x0400F0D0 RID: 61648
		[Token(Token = "0x400F0D0")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ConfirmBtn;

		// Token: 0x0400F0D1 RID: 61649
		[Token(Token = "0x400F0D1")]
		[FieldOffset(Offset = "0x30")]
		public GameObject OneTextStyle;

		// Token: 0x0400F0D2 RID: 61650
		[Token(Token = "0x400F0D2")]
		[FieldOffset(Offset = "0x38")]
		public UILabel OneTextContent;
	}
}
