using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002258 RID: 8792
	[Token(Token = "0x2002258")]
	internal class UIHudAcceleratorView : UIBaseView
	{
		// Token: 0x0600BFC1 RID: 49089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC1")]
		[Address(RVA = "0x1D65FF4", Offset = "0x1D65FF4", VA = "0x7BBC565FF4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFC2 RID: 49090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC2")]
		[Address(RVA = "0x1D660E4", Offset = "0x1D660E4", VA = "0x7BBC5660E4")]
		public UIHudAcceleratorView()
		{
		}

		// Token: 0x0400D326 RID: 54054
		[Token(Token = "0x400D326")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnAccelerator;

		// Token: 0x0400D327 RID: 54055
		[Token(Token = "0x400D327")]
		[FieldOffset(Offset = "0x28")]
		public UILabel BtnName;
	}
}
