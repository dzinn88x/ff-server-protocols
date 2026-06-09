using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002153 RID: 8531
	[Token(Token = "0x2002153")]
	public class UIChatSendSpeakerView : UIBaseView
	{
		// Token: 0x0600BDB6 RID: 48566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDB6")]
		[Address(RVA = "0x1BEB048", Offset = "0x1BEB048", VA = "0x7BBC3EB048", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDB7 RID: 48567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDB7")]
		[Address(RVA = "0x1BEB1B4", Offset = "0x1BEB1B4", VA = "0x7BBC3EB1B4")]
		public UIChatSendSpeakerView()
		{
		}

		// Token: 0x0400C4EE RID: 50414
		[Token(Token = "0x400C4EE")]
		[FieldOffset(Offset = "0x20")]
		public UIInput InputField;

		// Token: 0x0400C4EF RID: 50415
		[Token(Token = "0x400C4EF")]
		[FieldOffset(Offset = "0x28")]
		public UILabel SpeakerNum;

		// Token: 0x0400C4F0 RID: 50416
		[Token(Token = "0x400C4F0")]
		[FieldOffset(Offset = "0x30")]
		public UIButton SendBtn;

		// Token: 0x0400C4F1 RID: 50417
		[Token(Token = "0x400C4F1")]
		[FieldOffset(Offset = "0x38")]
		public UILabel StrLength;
	}
}
