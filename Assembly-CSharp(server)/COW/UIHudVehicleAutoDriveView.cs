using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002393 RID: 9107
	[Token(Token = "0x2002393")]
	public class UIHudVehicleAutoDriveView : UIBaseView
	{
		// Token: 0x0600C236 RID: 49718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C236")]
		[Address(RVA = "0x15EE904", Offset = "0x15EE904", VA = "0x7BBBDEE904", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C237 RID: 49719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C237")]
		[Address(RVA = "0x15EE9A0", Offset = "0x15EE9A0", VA = "0x7BBBDEE9A0")]
		public UIHudVehicleAutoDriveView()
		{
		}

		// Token: 0x0400DD0E RID: 56590
		[Token(Token = "0x400DD0E")]
		[FieldOffset(Offset = "0x20")]
		public UIButton AutoDriveBtn;
	}
}
