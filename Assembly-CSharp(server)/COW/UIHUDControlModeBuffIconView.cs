using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200229F RID: 8863
	[Token(Token = "0x200229F")]
	public class UIHUDControlModeBuffIconView : UIBaseView
	{
		// Token: 0x0600C04F RID: 49231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C04F")]
		[Address(RVA = "0x16B877C", Offset = "0x16B877C", VA = "0x7BBBEB877C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C050 RID: 49232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C050")]
		[Address(RVA = "0x16B886C", Offset = "0x16B886C", VA = "0x7BBBEB886C")]
		public UIHUDControlModeBuffIconView()
		{
		}

		// Token: 0x0400D4C3 RID: 54467
		[Token(Token = "0x400D4C3")]
		[FieldOffset(Offset = "0x20")]
		public TweenFill tweenFill;

		// Token: 0x0400D4C4 RID: 54468
		[Token(Token = "0x400D4C4")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Countdown;
	}
}
