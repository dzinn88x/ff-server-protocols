using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002338 RID: 9016
	[Token(Token = "0x2002338")]
	public class UIHudPVEReviveInfoView : UIBaseView
	{
		// Token: 0x0600C180 RID: 49536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C180")]
		[Address(RVA = "0x1D6A97C", Offset = "0x1D6A97C", VA = "0x7BBC56A97C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C181 RID: 49537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C181")]
		[Address(RVA = "0x1D6AA9C", Offset = "0x1D6AA9C", VA = "0x7BBC56AA9C")]
		public UIHudPVEReviveInfoView()
		{
		}

		// Token: 0x0400DA90 RID: 55952
		[Token(Token = "0x400DA90")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel Panel;

		// Token: 0x0400DA91 RID: 55953
		[Token(Token = "0x400DA91")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;

		// Token: 0x0400DA92 RID: 55954
		[Token(Token = "0x400DA92")]
		[FieldOffset(Offset = "0x30")]
		public UICountDownLabel CountDown;
	}
}
