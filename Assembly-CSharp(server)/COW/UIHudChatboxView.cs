using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002297 RID: 8855
	[Token(Token = "0x2002297")]
	public class UIHudChatboxView : UIBaseView
	{
		// Token: 0x0600C03F RID: 49215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C03F")]
		[Address(RVA = "0x1A90DBC", Offset = "0x1A90DBC", VA = "0x7BBC290DBC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C040 RID: 49216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C040")]
		[Address(RVA = "0x1A90E58", Offset = "0x1A90E58", VA = "0x7BBC290E58")]
		public UIHudChatboxView()
		{
		}

		// Token: 0x0400D489 RID: 54409
		[Token(Token = "0x400D489")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Label;
	}
}
