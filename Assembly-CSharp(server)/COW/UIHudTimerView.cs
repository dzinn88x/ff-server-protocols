using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002380 RID: 9088
	[Token(Token = "0x2002380")]
	internal class UIHudTimerView : UIBaseView
	{
		// Token: 0x0600C210 RID: 49680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C210")]
		[Address(RVA = "0x15E62D8", Offset = "0x15E62D8", VA = "0x7BBBDE62D8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C211 RID: 49681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C211")]
		[Address(RVA = "0x15E63C8", Offset = "0x15E63C8", VA = "0x7BBBDE63C8")]
		public UIHudTimerView()
		{
		}

		// Token: 0x0400DC91 RID: 56465
		[Token(Token = "0x400DC91")]
		[FieldOffset(Offset = "0x20")]
		public Animator FX_UI_time;

		// Token: 0x0400DC92 RID: 56466
		[Token(Token = "0x400DC92")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Time;
	}
}
