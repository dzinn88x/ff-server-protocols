using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002187 RID: 8583
	[Token(Token = "0x2002187")]
	public class UICommonTinyMsgBoxView : UIBaseView
	{
		// Token: 0x0600BE1E RID: 48670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE1E")]
		[Address(RVA = "0x1815B20", Offset = "0x1815B20", VA = "0x7BBC015B20", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE1F RID: 48671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE1F")]
		[Address(RVA = "0x1815D40", Offset = "0x1815D40", VA = "0x7BBC015D40")]
		public UICommonTinyMsgBoxView()
		{
		}

		// Token: 0x0400C7C1 RID: 51137
		[Token(Token = "0x400C7C1")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Content;

		// Token: 0x0400C7C2 RID: 51138
		[Token(Token = "0x400C7C2")]
		[FieldOffset(Offset = "0x28")]
		public UIButton CancelBtn;

		// Token: 0x0400C7C3 RID: 51139
		[Token(Token = "0x400C7C3")]
		[FieldOffset(Offset = "0x30")]
		public UILabel CancelTxt;

		// Token: 0x0400C7C4 RID: 51140
		[Token(Token = "0x400C7C4")]
		[FieldOffset(Offset = "0x38")]
		public UIButton OKBtn;

		// Token: 0x0400C7C5 RID: 51141
		[Token(Token = "0x400C7C5")]
		[FieldOffset(Offset = "0x40")]
		public UILabel OKTxt;

		// Token: 0x0400C7C6 RID: 51142
		[Token(Token = "0x400C7C6")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Tips;

		// Token: 0x0400C7C7 RID: 51143
		[Token(Token = "0x400C7C7")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Icon;
	}
}
