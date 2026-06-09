using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002571 RID: 9585
	[Token(Token = "0x2002571")]
	public class UITaskView : UIBaseView
	{
		// Token: 0x0600C5F2 RID: 50674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5F2")]
		[Address(RVA = "0x1F529D4", Offset = "0x1F529D4", VA = "0x7BBC7529D4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5F3 RID: 50675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5F3")]
		[Address(RVA = "0x1F52B60", Offset = "0x1F52B60", VA = "0x7BBC752B60")]
		public UITaskView()
		{
		}

		// Token: 0x0400F623 RID: 63011
		[Token(Token = "0x400F623")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BGMASK;

		// Token: 0x0400F624 RID: 63012
		[Token(Token = "0x400F624")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BGTask;

		// Token: 0x0400F625 RID: 63013
		[Token(Token = "0x400F625")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BGEP;

		// Token: 0x0400F626 RID: 63014
		[Token(Token = "0x400F626")]
		[FieldOffset(Offset = "0x38")]
		public Transform TopTabContainer;

		// Token: 0x0400F627 RID: 63015
		[Token(Token = "0x400F627")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Content;
	}
}
