using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002317 RID: 8983
	[Token(Token = "0x2002317")]
	public class UIHudMovingJoystickView : UIBaseView
	{
		// Token: 0x0600C13E RID: 49470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C13E")]
		[Address(RVA = "0x17B5F9C", Offset = "0x17B5F9C", VA = "0x7BBBFB5F9C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C13F RID: 49471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C13F")]
		[Address(RVA = "0x17B60F8", Offset = "0x17B60F8", VA = "0x7BBBFB60F8")]
		public UIHudMovingJoystickView()
		{
		}

		// Token: 0x0400D994 RID: 55700
		[Token(Token = "0x400D994")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget MainWidget;

		// Token: 0x0400D995 RID: 55701
		[Token(Token = "0x400D995")]
		[FieldOffset(Offset = "0x28")]
		public Transform Joystick;

		// Token: 0x0400D996 RID: 55702
		[Token(Token = "0x400D996")]
		[FieldOffset(Offset = "0x30")]
		public Transform JoystickBG;

		// Token: 0x0400D997 RID: 55703
		[Token(Token = "0x400D997")]
		[FieldOffset(Offset = "0x38")]
		public Transform Outjoystick;
	}
}
