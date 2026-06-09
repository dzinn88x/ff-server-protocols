using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200221B RID: 8731
	[Token(Token = "0x200221B")]
	public class UIGachaLimitBuyBtnView : UIBaseView
	{
		// Token: 0x0600BF47 RID: 48967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF47")]
		[Address(RVA = "0x205D6A0", Offset = "0x205D6A0", VA = "0x7BBC85D6A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF48 RID: 48968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF48")]
		[Address(RVA = "0x205D790", Offset = "0x205D790", VA = "0x7BBC85D790")]
		public UIGachaLimitBuyBtnView()
		{
		}

		// Token: 0x0400CF45 RID: 53061
		[Token(Token = "0x400CF45")]
		[FieldOffset(Offset = "0x20")]
		public UIGachaBuyBtnBaseView UIGachaBuyBtnBaseView;

		// Token: 0x0400CF46 RID: 53062
		[Token(Token = "0x400CF46")]
		[FieldOffset(Offset = "0x28")]
		public GameObject FreeTip;
	}
}
