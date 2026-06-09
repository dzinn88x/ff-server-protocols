using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002434 RID: 9268
	[Token(Token = "0x2002434")]
	internal class UIMaskView : UIBaseView
	{
		// Token: 0x0600C378 RID: 50040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C378")]
		[Address(RVA = "0x1476D0C", Offset = "0x1476D0C", VA = "0x7BBBC76D0C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C379 RID: 50041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C379")]
		[Address(RVA = "0x1476DA8", Offset = "0x1476DA8", VA = "0x7BBBC76DA8")]
		public UIMaskView()
		{
		}

		// Token: 0x0400E6CE RID: 59086
		[Token(Token = "0x400E6CE")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Mask;
	}
}
