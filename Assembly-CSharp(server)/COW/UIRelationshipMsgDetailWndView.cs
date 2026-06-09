using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024D3 RID: 9427
	[Token(Token = "0x20024D3")]
	public class UIRelationshipMsgDetailWndView : UIBaseView
	{
		// Token: 0x0600C4B6 RID: 50358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B6")]
		[Address(RVA = "0x1E1F028", Offset = "0x1E1F028", VA = "0x7BBC61F028", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4B7 RID: 50359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B7")]
		[Address(RVA = "0x1E1F228", Offset = "0x1E1F228", VA = "0x7BBC61F228")]
		public UIRelationshipMsgDetailWndView()
		{
		}

		// Token: 0x0400EFC8 RID: 61384
		[Token(Token = "0x400EFC8")]
		[FieldOffset(Offset = "0x20")]
		public Animator UIRelationshipMsgDetailWnd;

		// Token: 0x0400EFC9 RID: 61385
		[Token(Token = "0x400EFC9")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ConfirmBtn;

		// Token: 0x0400EFCA RID: 61386
		[Token(Token = "0x400EFCA")]
		[FieldOffset(Offset = "0x30")]
		public UIButton RefuceBtn;

		// Token: 0x0400EFCB RID: 61387
		[Token(Token = "0x400EFCB")]
		[FieldOffset(Offset = "0x38")]
		public UILabel MsgContent;

		// Token: 0x0400EFCC RID: 61388
		[Token(Token = "0x400EFCC")]
		[FieldOffset(Offset = "0x40")]
		public UILabel MsgContent_1;

		// Token: 0x0400EFCD RID: 61389
		[Token(Token = "0x400EFCD")]
		[FieldOffset(Offset = "0x48")]
		public UINetworkTexture CDNTexture;

		// Token: 0x0400EFCE RID: 61390
		[Token(Token = "0x400EFCE")]
		[FieldOffset(Offset = "0x50")]
		public UIButton CloseBtn;
	}
}
