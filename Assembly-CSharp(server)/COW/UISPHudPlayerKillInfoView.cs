using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002525 RID: 9509
	[Token(Token = "0x2002525")]
	public class UISPHudPlayerKillInfoView : UIBaseView
	{
		// Token: 0x0600C55A RID: 50522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C55A")]
		[Address(RVA = "0x1EEE328", Offset = "0x1EEE328", VA = "0x7BBC6EE328", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C55B RID: 50523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C55B")]
		[Address(RVA = "0x1EEE418", Offset = "0x1EEE418", VA = "0x7BBC6EE418")]
		public UISPHudPlayerKillInfoView()
		{
		}

		// Token: 0x0400F300 RID: 62208
		[Token(Token = "0x400F300")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition TotalTWPosition;

		// Token: 0x0400F301 RID: 62209
		[Token(Token = "0x400F301")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid KillInfoGrid;
	}
}
