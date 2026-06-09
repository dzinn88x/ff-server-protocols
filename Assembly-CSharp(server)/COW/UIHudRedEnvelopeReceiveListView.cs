using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200234F RID: 9039
	[Token(Token = "0x200234F")]
	internal class UIHudRedEnvelopeReceiveListView : UIBaseView
	{
		// Token: 0x0600C1AE RID: 49582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1AE")]
		[Address(RVA = "0x17F1078", Offset = "0x17F1078", VA = "0x7BBBFF1078", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1AF RID: 49583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1AF")]
		[Address(RVA = "0x17F11EC", Offset = "0x17F11EC", VA = "0x7BBBFF11EC")]
		public UIHudRedEnvelopeReceiveListView()
		{
		}

		// Token: 0x0400DAEB RID: 56043
		[Token(Token = "0x400DAEB")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CloseBtn;

		// Token: 0x0400DAEC RID: 56044
		[Token(Token = "0x400DAEC")]
		[FieldOffset(Offset = "0x28")]
		public UILabel OwnerLabel;

		// Token: 0x0400DAED RID: 56045
		[Token(Token = "0x400DAED")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid Grid;

		// Token: 0x0400DAEE RID: 56046
		[Token(Token = "0x400DAEE")]
		[FieldOffset(Offset = "0x38")]
		public RedEnvelopeAwardItemView ReceiveItem;
	}
}
