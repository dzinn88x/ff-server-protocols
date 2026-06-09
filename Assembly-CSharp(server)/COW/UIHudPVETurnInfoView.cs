using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002339 RID: 9017
	[Token(Token = "0x2002339")]
	internal class UIHudPVETurnInfoView : UIBaseView
	{
		// Token: 0x0600C182 RID: 49538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C182")]
		[Address(RVA = "0x1D6B530", Offset = "0x1D6B530", VA = "0x7BBC56B530", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C183 RID: 49539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C183")]
		[Address(RVA = "0x1D6B650", Offset = "0x1D6B650", VA = "0x7BBC56B650")]
		public UIHudPVETurnInfoView()
		{
		}

		// Token: 0x0400DA93 RID: 55955
		[Token(Token = "0x400DA93")]
		[FieldOffset(Offset = "0x20")]
		public UILabel TurnTxt;

		// Token: 0x0400DA94 RID: 55956
		[Token(Token = "0x400DA94")]
		[FieldOffset(Offset = "0x28")]
		public GameObject MidTurnInfo;

		// Token: 0x0400DA95 RID: 55957
		[Token(Token = "0x400DA95")]
		[FieldOffset(Offset = "0x30")]
		public UILabel MidTurnTxt;
	}
}
