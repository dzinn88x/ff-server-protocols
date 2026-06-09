using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022D6 RID: 8918
	[Token(Token = "0x20022D6")]
	public class UIHudGamePhaseCountdownHintView : UIBaseView
	{
		// Token: 0x0600C0BC RID: 49340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0BC")]
		[Address(RVA = "0x1C134D8", Offset = "0x1C134D8", VA = "0x7BBC4134D8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0BD RID: 49341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0BD")]
		[Address(RVA = "0x1C135C8", Offset = "0x1C135C8", VA = "0x7BBC4135C8")]
		public UIHudGamePhaseCountdownHintView()
		{
		}

		// Token: 0x0400D6B9 RID: 54969
		[Token(Token = "0x400D6B9")]
		[FieldOffset(Offset = "0x20")]
		public UISprite IconHint;

		// Token: 0x0400D6BA RID: 54970
		[Token(Token = "0x400D6BA")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Label;
	}
}
