using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200214C RID: 8524
	[Token(Token = "0x200214C")]
	public class UIChatClanContainerView : UIBaseView
	{
		// Token: 0x0600BDA8 RID: 48552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA8")]
		[Address(RVA = "0x1BE14E4", Offset = "0x1BE14E4", VA = "0x7BBC3E14E4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDA9 RID: 48553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA9")]
		[Address(RVA = "0x1BE17AC", Offset = "0x1BE17AC", VA = "0x7BBC3E17AC")]
		public UIChatClanContainerView()
		{
		}

		// Token: 0x0400C4A8 RID: 50344
		[Token(Token = "0x400C4A8")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget Widget;

		// Token: 0x0400C4A9 RID: 50345
		[Token(Token = "0x400C4A9")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ContentNode;

		// Token: 0x0400C4AA RID: 50346
		[Token(Token = "0x400C4AA")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView MessageList;

		// Token: 0x0400C4AB RID: 50347
		[Token(Token = "0x400C4AB")]
		[FieldOffset(Offset = "0x38")]
		public GameObject LuckyBagMessage;

		// Token: 0x0400C4AC RID: 50348
		[Token(Token = "0x400C4AC")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LuckyBagLabel;

		// Token: 0x0400C4AD RID: 50349
		[Token(Token = "0x400C4AD")]
		[FieldOffset(Offset = "0x48")]
		public UIButton GoToLuckyBagBtn;

		// Token: 0x0400C4AE RID: 50350
		[Token(Token = "0x400C4AE")]
		[FieldOffset(Offset = "0x50")]
		public GameObject EmptyNode;

		// Token: 0x0400C4AF RID: 50351
		[Token(Token = "0x400C4AF")]
		[FieldOffset(Offset = "0x58")]
		public GameObject NoMessageHint;

		// Token: 0x0400C4B0 RID: 50352
		[Token(Token = "0x400C4B0")]
		[FieldOffset(Offset = "0x60")]
		public GameObject NoClanHint;

		// Token: 0x0400C4B1 RID: 50353
		[Token(Token = "0x400C4B1")]
		[FieldOffset(Offset = "0x68")]
		public UIButton GotoSearchClanBtn;
	}
}
