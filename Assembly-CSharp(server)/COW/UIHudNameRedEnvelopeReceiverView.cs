using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200231C RID: 8988
	[Token(Token = "0x200231C")]
	internal class UIHudNameRedEnvelopeReceiverView : UIBaseView
	{
		// Token: 0x0600C148 RID: 49480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C148")]
		[Address(RVA = "0x17B8350", Offset = "0x17B8350", VA = "0x7BBBFB8350", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C149 RID: 49481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C149")]
		[Address(RVA = "0x17B8440", Offset = "0x17B8440", VA = "0x7BBBFB8440")]
		public UIHudNameRedEnvelopeReceiverView()
		{
		}

		// Token: 0x0400D99F RID: 55711
		[Token(Token = "0x400D99F")]
		[FieldOffset(Offset = "0x20")]
		public UILabel ThanksLabel;

		// Token: 0x0400D9A0 RID: 55712
		[Token(Token = "0x400D9A0")]
		[FieldOffset(Offset = "0x28")]
		public GameObject LuckyIcon;
	}
}
