using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200218A RID: 8586
	[Token(Token = "0x200218A")]
	public class UIConnectionReportView : UIBaseView
	{
		// Token: 0x0600BE24 RID: 48676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE24")]
		[Address(RVA = "0x18172B8", Offset = "0x18172B8", VA = "0x7BBC0172B8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE25 RID: 48677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE25")]
		[Address(RVA = "0x18173D8", Offset = "0x18173D8", VA = "0x7BBC0173D8")]
		public UIConnectionReportView()
		{
		}

		// Token: 0x0400C7D1 RID: 51153
		[Token(Token = "0x400C7D1")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Desc_Label;

		// Token: 0x0400C7D2 RID: 51154
		[Token(Token = "0x400C7D2")]
		[FieldOffset(Offset = "0x28")]
		public UIButton SendBtn;

		// Token: 0x0400C7D3 RID: 51155
		[Token(Token = "0x400C7D3")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SendingCircleContainer;
	}
}
