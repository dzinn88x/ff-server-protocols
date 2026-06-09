using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200229A RID: 8858
	[Token(Token = "0x200229A")]
	public class UIHudCommonlTipsView : UIBaseView
	{
		// Token: 0x0600C045 RID: 49221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C045")]
		[Address(RVA = "0x1A91ADC", Offset = "0x1A91ADC", VA = "0x7BBC291ADC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C046 RID: 49222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C046")]
		[Address(RVA = "0x1A91C80", Offset = "0x1A91C80", VA = "0x7BBC291C80")]
		public UIHudCommonlTipsView()
		{
		}

		// Token: 0x0400D495 RID: 54421
		[Token(Token = "0x400D495")]
		[FieldOffset(Offset = "0x20")]
		public GameObject PosRoot;

		// Token: 0x0400D496 RID: 54422
		[Token(Token = "0x400D496")]
		[FieldOffset(Offset = "0x28")]
		public UITable ContentTable;

		// Token: 0x0400D497 RID: 54423
		[Token(Token = "0x400D497")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Description;

		// Token: 0x0400D498 RID: 54424
		[Token(Token = "0x400D498")]
		[FieldOffset(Offset = "0x38")]
		public UISprite DescriptionBG;

		// Token: 0x0400D499 RID: 54425
		[Token(Token = "0x400D499")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Mask;
	}
}
