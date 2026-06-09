using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002376 RID: 9078
	[Token(Token = "0x2002376")]
	public class UIHudTaskNameIconView : UIBaseView
	{
		// Token: 0x0600C1FC RID: 49660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1FC")]
		[Address(RVA = "0x167D148", Offset = "0x167D148", VA = "0x7BBBE7D148", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1FD RID: 49661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1FD")]
		[Address(RVA = "0x167D238", Offset = "0x167D238", VA = "0x7BBBE7D238")]
		public UIHudTaskNameIconView()
		{
		}

		// Token: 0x0400DC06 RID: 56326
		[Token(Token = "0x400DC06")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Normal;

		// Token: 0x0400DC07 RID: 56327
		[Token(Token = "0x400DC07")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Emergency;
	}
}
