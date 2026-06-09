using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022DB RID: 8923
	[Token(Token = "0x20022DB")]
	internal class UIHudGetOnVehicleAsPassengerView : UIBaseView
	{
		// Token: 0x0600C0C6 RID: 49350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0C6")]
		[Address(RVA = "0x1C17378", Offset = "0x1C17378", VA = "0x7BBC417378", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0C7 RID: 49351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0C7")]
		[Address(RVA = "0x1C17414", Offset = "0x1C17414", VA = "0x7BBC417414")]
		public UIHudGetOnVehicleAsPassengerView()
		{
		}

		// Token: 0x0400D6D0 RID: 54992
		[Token(Token = "0x400D6D0")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnPassenger;
	}
}
