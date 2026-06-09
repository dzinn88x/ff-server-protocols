using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200214A RID: 8522
	[Token(Token = "0x200214A")]
	public class UIChatBlockListItemView : UIBaseView
	{
		// Token: 0x0600BDA4 RID: 48548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA4")]
		[Address(RVA = "0x1BE0804", Offset = "0x1BE0804", VA = "0x7BBC3E0804", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDA5 RID: 48549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA5")]
		[Address(RVA = "0x1BE0924", Offset = "0x1BE0924", VA = "0x7BBC3E0924")]
		public UIChatBlockListItemView()
		{
		}

		// Token: 0x0400C4A3 RID: 50339
		[Token(Token = "0x400C4A3")]
		[FieldOffset(Offset = "0x20")]
		public UILabel PlayerName;

		// Token: 0x0400C4A4 RID: 50340
		[Token(Token = "0x400C4A4")]
		[FieldOffset(Offset = "0x28")]
		public UILabel PlayerID;

		// Token: 0x0400C4A5 RID: 50341
		[Token(Token = "0x400C4A5")]
		[FieldOffset(Offset = "0x30")]
		public UIButton RemoveBlock;
	}
}
