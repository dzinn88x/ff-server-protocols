using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200214D RID: 8525
	[Token(Token = "0x200214D")]
	public class UIChatCommonContainerView : UIBaseView
	{
		// Token: 0x0600BDAA RID: 48554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDAA")]
		[Address(RVA = "0x1BE1974", Offset = "0x1BE1974", VA = "0x7BBC3E1974", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDAB RID: 48555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDAB")]
		[Address(RVA = "0x1BE1B08", Offset = "0x1BE1B08", VA = "0x7BBC3E1B08")]
		public UIChatCommonContainerView()
		{
		}

		// Token: 0x0400C4B2 RID: 50354
		[Token(Token = "0x400C4B2")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget Widget;

		// Token: 0x0400C4B3 RID: 50355
		[Token(Token = "0x400C4B3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ContentNode;

		// Token: 0x0400C4B4 RID: 50356
		[Token(Token = "0x400C4B4")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView MessageList;

		// Token: 0x0400C4B5 RID: 50357
		[Token(Token = "0x400C4B5")]
		[FieldOffset(Offset = "0x38")]
		public GameObject EmptyNode;

		// Token: 0x0400C4B6 RID: 50358
		[Token(Token = "0x400C4B6")]
		[FieldOffset(Offset = "0x40")]
		public GameObject NoMessageHint;
	}
}
