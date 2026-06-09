using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002429 RID: 9257
	[Token(Token = "0x2002429")]
	internal class UIManualMapEvtView : UIBaseView
	{
		// Token: 0x0600C362 RID: 50018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C362")]
		[Address(RVA = "0x18E36B4", Offset = "0x18E36B4", VA = "0x7BBC0E36B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C363 RID: 50019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C363")]
		[Address(RVA = "0x18E3840", Offset = "0x18E3840", VA = "0x7BBC0E3840")]
		public UIManualMapEvtView()
		{
		}

		// Token: 0x0400E605 RID: 58885
		[Token(Token = "0x400E605")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UIManualMapEvt;

		// Token: 0x0400E606 RID: 58886
		[Token(Token = "0x400E606")]
		[FieldOffset(Offset = "0x28")]
		public Transform RightPos;

		// Token: 0x0400E607 RID: 58887
		[Token(Token = "0x400E607")]
		[FieldOffset(Offset = "0x30")]
		public Transform LeftPos;

		// Token: 0x0400E608 RID: 58888
		[Token(Token = "0x400E608")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnLeftArrow;

		// Token: 0x0400E609 RID: 58889
		[Token(Token = "0x400E609")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnRightArrow;
	}
}
