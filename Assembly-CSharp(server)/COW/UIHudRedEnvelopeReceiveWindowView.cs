using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002350 RID: 9040
	[Token(Token = "0x2002350")]
	internal class UIHudRedEnvelopeReceiveWindowView : UIBaseView
	{
		// Token: 0x0600C1B0 RID: 49584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B0")]
		[Address(RVA = "0x17F11F4", Offset = "0x17F11F4", VA = "0x7BBBFF11F4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1B1 RID: 49585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1B1")]
		[Address(RVA = "0x17F1404", Offset = "0x17F1404", VA = "0x7BBBFF1404")]
		public UIHudRedEnvelopeReceiveWindowView()
		{
		}

		// Token: 0x0400DAEF RID: 56047
		[Token(Token = "0x400DAEF")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LabelOwnerInfo;

		// Token: 0x0400DAF0 RID: 56048
		[Token(Token = "0x400DAF0")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ReceiveInfo;

		// Token: 0x0400DAF1 RID: 56049
		[Token(Token = "0x400DAF1")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LabelDone;

		// Token: 0x0400DAF2 RID: 56050
		[Token(Token = "0x400DAF2")]
		[FieldOffset(Offset = "0x38")]
		public RedEnvelopeAwardItemView ReceiveItem;

		// Token: 0x0400DAF3 RID: 56051
		[Token(Token = "0x400DAF3")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnOpen;

		// Token: 0x0400DAF4 RID: 56052
		[Token(Token = "0x400DAF4")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnReceiveInfo;

		// Token: 0x0400DAF5 RID: 56053
		[Token(Token = "0x400DAF5")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnClose;
	}
}
