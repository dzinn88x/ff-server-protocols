using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200226E RID: 8814
	[Token(Token = "0x200226E")]
	internal class UIHudAssistantTextView : UIBaseView
	{
		// Token: 0x0600BFED RID: 49133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFED")]
		[Address(RVA = "0x1887FFC", Offset = "0x1887FFC", VA = "0x7BBC087FFC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFEE RID: 49134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFEE")]
		[Address(RVA = "0x18880EC", Offset = "0x18880EC", VA = "0x7BBC0880EC")]
		public UIHudAssistantTextView()
		{
		}

		// Token: 0x0400D3AA RID: 54186
		[Token(Token = "0x400D3AA")]
		[FieldOffset(Offset = "0x20")]
		public UILabel NameLabel;

		// Token: 0x0400D3AB RID: 54187
		[Token(Token = "0x400D3AB")]
		[FieldOffset(Offset = "0x28")]
		public UILabel AssistantLabel;
	}
}
