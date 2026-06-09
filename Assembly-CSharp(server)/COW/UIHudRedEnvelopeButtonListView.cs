using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200234D RID: 9037
	[Token(Token = "0x200234D")]
	internal class UIHudRedEnvelopeButtonListView : UIBaseView
	{
		// Token: 0x0600C1AA RID: 49578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1AA")]
		[Address(RVA = "0x17EF130", Offset = "0x17EF130", VA = "0x7BBBFEF130", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1AB RID: 49579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1AB")]
		[Address(RVA = "0x17EF220", Offset = "0x17EF220", VA = "0x7BBBFEF220")]
		public UIHudRedEnvelopeButtonListView()
		{
		}

		// Token: 0x0400DAE5 RID: 56037
		[Token(Token = "0x400DAE5")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid Grid;

		// Token: 0x0400DAE6 RID: 56038
		[Token(Token = "0x400DAE6")]
		[FieldOffset(Offset = "0x28")]
		public RedEnvelopeItemView RedEnvelopeItem;
	}
}
