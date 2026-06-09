using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002375 RID: 9077
	[Token(Token = "0x2002375")]
	public class UIHudSwitchObserverView : UIBaseView
	{
		// Token: 0x0600C1FA RID: 49658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1FA")]
		[Address(RVA = "0x1676DD4", Offset = "0x1676DD4", VA = "0x7BBBE76DD4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1FB RID: 49659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1FB")]
		[Address(RVA = "0x1676EF4", Offset = "0x1676EF4", VA = "0x7BBBE76EF4")]
		public UIHudSwitchObserverView()
		{
		}

		// Token: 0x0400DC03 RID: 56323
		[Token(Token = "0x400DC03")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnSwitchPrev;

		// Token: 0x0400DC04 RID: 56324
		[Token(Token = "0x400DC04")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnSwitchNext;

		// Token: 0x0400DC05 RID: 56325
		[Token(Token = "0x400DC05")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ReviveTips;
	}
}
