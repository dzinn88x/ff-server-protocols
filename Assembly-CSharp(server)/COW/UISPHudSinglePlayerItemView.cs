using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002539 RID: 9529
	[Token(Token = "0x2002539")]
	internal class UISPHudSinglePlayerItemView : UIBaseView
	{
		// Token: 0x0600C582 RID: 50562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C582")]
		[Address(RVA = "0x1EF42C8", Offset = "0x1EF42C8", VA = "0x7BBC6F42C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C583 RID: 50563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C583")]
		[Address(RVA = "0x1EF4364", Offset = "0x1EF4364", VA = "0x7BBC6F4364")]
		public UISPHudSinglePlayerItemView()
		{
		}

		// Token: 0x0400F386 RID: 62342
		[Token(Token = "0x400F386")]
		[FieldOffset(Offset = "0x20")]
		public UISPHudPlayerItem PlayerItem;
	}
}
