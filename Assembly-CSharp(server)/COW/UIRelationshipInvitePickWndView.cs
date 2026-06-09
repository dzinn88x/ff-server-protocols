using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024D1 RID: 9425
	[Token(Token = "0x20024D1")]
	public class UIRelationshipInvitePickWndView : UIBaseView
	{
		// Token: 0x0600C4B2 RID: 50354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B2")]
		[Address(RVA = "0x1E1E194", Offset = "0x1E1E194", VA = "0x7BBC61E194", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4B3 RID: 50355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B3")]
		[Address(RVA = "0x1E1E2B4", Offset = "0x1E1E2B4", VA = "0x7BBC61E2B4")]
		public UIRelationshipInvitePickWndView()
		{
		}

		// Token: 0x0400EFC0 RID: 61376
		[Token(Token = "0x400EFC0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject NoneLabel;

		// Token: 0x0400EFC1 RID: 61377
		[Token(Token = "0x400EFC1")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ScorllContainer;

		// Token: 0x0400EFC2 RID: 61378
		[Token(Token = "0x400EFC2")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList profileGrid;
	}
}
