using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200252B RID: 9515
	[Token(Token = "0x200252B")]
	public class UISPHudReplayFilterItemView : UIBaseView
	{
		// Token: 0x0600C566 RID: 50534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C566")]
		[Address(RVA = "0x1EF0408", Offset = "0x1EF0408", VA = "0x7BBC6F0408", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C567 RID: 50535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C567")]
		[Address(RVA = "0x1EF0528", Offset = "0x1EF0528", VA = "0x7BBC6F0528")]
		public UISPHudReplayFilterItemView()
		{
		}

		// Token: 0x0400F33E RID: 62270
		[Token(Token = "0x400F33E")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Icon;

		// Token: 0x0400F33F RID: 62271
		[Token(Token = "0x400F33F")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;

		// Token: 0x0400F340 RID: 62272
		[Token(Token = "0x400F340")]
		[FieldOffset(Offset = "0x30")]
		public UIToggle CheckToggle;
	}
}
