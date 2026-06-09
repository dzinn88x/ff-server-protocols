using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002439 RID: 9273
	[Token(Token = "0x2002439")]
	internal class UIMatchMakingWaitingView : UIBaseView
	{
		// Token: 0x0600C382 RID: 50050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C382")]
		[Address(RVA = "0x1478EA4", Offset = "0x1478EA4", VA = "0x7BBBC78EA4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C383 RID: 50051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C383")]
		[Address(RVA = "0x1478FC4", Offset = "0x1478FC4", VA = "0x7BBBC78FC4")]
		public UIMatchMakingWaitingView()
		{
		}

		// Token: 0x0400E700 RID: 59136
		[Token(Token = "0x400E700")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Time;

		// Token: 0x0400E701 RID: 59137
		[Token(Token = "0x400E701")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnCancel;

		// Token: 0x0400E702 RID: 59138
		[Token(Token = "0x400E702")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LabelOptionalPauseHint;
	}
}
