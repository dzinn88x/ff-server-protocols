using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022DA RID: 8922
	[Token(Token = "0x20022DA")]
	internal class UIHudGetOnVehicleAsDriverView : UIBaseView
	{
		// Token: 0x0600C0C4 RID: 49348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0C4")]
		[Address(RVA = "0x1C171B4", Offset = "0x1C171B4", VA = "0x7BBC4171B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0C5 RID: 49349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0C5")]
		[Address(RVA = "0x1C17250", Offset = "0x1C17250", VA = "0x7BBC417250")]
		public UIHudGetOnVehicleAsDriverView()
		{
		}

		// Token: 0x0400D6CF RID: 54991
		[Token(Token = "0x400D6CF")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnDriver;
	}
}
