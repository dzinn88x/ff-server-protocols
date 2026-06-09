using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200211C RID: 8476
	[Token(Token = "0x200211C")]
	public class UIBigEventChatMsgItemView : UIBaseView
	{
		// Token: 0x0600BD48 RID: 48456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD48")]
		[Address(RVA = "0x1428694", Offset = "0x1428694", VA = "0x7BBBC28694", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD49 RID: 48457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD49")]
		[Address(RVA = "0x14287F0", Offset = "0x14287F0", VA = "0x7BBBC287F0")]
		public UIBigEventChatMsgItemView()
		{
		}

		// Token: 0x0400C23A RID: 49722
		[Token(Token = "0x400C23A")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnJoin;

		// Token: 0x0400C23B RID: 49723
		[Token(Token = "0x400C23B")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TopLeftLabel;

		// Token: 0x0400C23C RID: 49724
		[Token(Token = "0x400C23C")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BottonLeftLabel;

		// Token: 0x0400C23D RID: 49725
		[Token(Token = "0x400C23D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TopRightLabel;
	}
}
