using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002421 RID: 9249
	[Token(Token = "0x2002421")]
	internal class UIMallVoucherView : UIBaseView
	{
		// Token: 0x0600C352 RID: 50002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C352")]
		[Address(RVA = "0x1DF3EC0", Offset = "0x1DF3EC0", VA = "0x7BBC5F3EC0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C353 RID: 50003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C353")]
		[Address(RVA = "0x1DF4034", Offset = "0x1DF4034", VA = "0x7BBC5F4034")]
		public UIMallVoucherView()
		{
		}

		// Token: 0x0400E542 RID: 58690
		[Token(Token = "0x400E542")]
		[FieldOffset(Offset = "0x20")]
		public UIButton VoucherBtn;

		// Token: 0x0400E543 RID: 58691
		[Token(Token = "0x400E543")]
		[FieldOffset(Offset = "0x28")]
		public UILabel VoucherLabel;

		// Token: 0x0400E544 RID: 58692
		[Token(Token = "0x400E544")]
		[FieldOffset(Offset = "0x30")]
		public Transform Arrow;

		// Token: 0x0400E545 RID: 58693
		[Token(Token = "0x400E545")]
		[FieldOffset(Offset = "0x38")]
		public GameObject VoucherListContainer;
	}
}
