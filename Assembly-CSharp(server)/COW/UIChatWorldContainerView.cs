using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002157 RID: 8535
	[Token(Token = "0x2002157")]
	public class UIChatWorldContainerView : UIBaseView
	{
		// Token: 0x0600BDBE RID: 48574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDBE")]
		[Address(RVA = "0x1BF18F4", Offset = "0x1BF18F4", VA = "0x7BBC3F18F4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDBF RID: 48575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDBF")]
		[Address(RVA = "0x1BF1B50", Offset = "0x1BF1B50", VA = "0x7BBC3F1B50")]
		public UIChatWorldContainerView()
		{
		}

		// Token: 0x0400C53F RID: 50495
		[Token(Token = "0x400C53F")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget Widget;

		// Token: 0x0400C540 RID: 50496
		[Token(Token = "0x400C540")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ContentNode;

		// Token: 0x0400C541 RID: 50497
		[Token(Token = "0x400C541")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView MessageList;

		// Token: 0x0400C542 RID: 50498
		[Token(Token = "0x400C542")]
		[FieldOffset(Offset = "0x38")]
		public GameObject LiftTopMessage;

		// Token: 0x0400C543 RID: 50499
		[Token(Token = "0x400C543")]
		[FieldOffset(Offset = "0x40")]
		public UIPanel LiftTopMessageClipPanel;

		// Token: 0x0400C544 RID: 50500
		[Token(Token = "0x400C544")]
		[FieldOffset(Offset = "0x48")]
		public BaseChatMessageView LiftTopMessageContent;

		// Token: 0x0400C545 RID: 50501
		[Token(Token = "0x400C545")]
		[FieldOffset(Offset = "0x50")]
		public GameObject EmptyNode;

		// Token: 0x0400C546 RID: 50502
		[Token(Token = "0x400C546")]
		[FieldOffset(Offset = "0x58")]
		public GameObject NoMessageHint;
	}
}
