using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200245D RID: 9309
	[Token(Token = "0x200245D")]
	public class UINewPlayerPathView : UIBaseView
	{
		// Token: 0x0600C3CA RID: 50122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3CA")]
		[Address(RVA = "0x1AFA1D4", Offset = "0x1AFA1D4", VA = "0x7BBC2FA1D4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3CB RID: 50123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3CB")]
		[Address(RVA = "0x1AFA2F4", Offset = "0x1AFA2F4", VA = "0x7BBC2FA2F4")]
		public UINewPlayerPathView()
		{
		}

		// Token: 0x0400E8E5 RID: 59621
		[Token(Token = "0x400E8E5")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView LeftTabScrollView;

		// Token: 0x0400E8E6 RID: 59622
		[Token(Token = "0x400E8E6")]
		[FieldOffset(Offset = "0x28")]
		public UITable LeftTabContainer;

		// Token: 0x0400E8E7 RID: 59623
		[Token(Token = "0x400E8E7")]
		[FieldOffset(Offset = "0x30")]
		public Transform CountDownContainer;
	}
}
