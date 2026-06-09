using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200238B RID: 9099
	[Token(Token = "0x200238B")]
	public class UIHudTrainingVehicleTimerView : UIBaseView
	{
		// Token: 0x0600C226 RID: 49702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C226")]
		[Address(RVA = "0x15E9ABC", Offset = "0x15E9ABC", VA = "0x7BBBDE9ABC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C227 RID: 49703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C227")]
		[Address(RVA = "0x15E9BAC", Offset = "0x15E9BAC", VA = "0x7BBBDE9BAC")]
		public UIHudTrainingVehicleTimerView()
		{
		}

		// Token: 0x0400DCF8 RID: 56568
		[Token(Token = "0x400DCF8")]
		[FieldOffset(Offset = "0x20")]
		public UILabel BestHistoryTime;

		// Token: 0x0400DCF9 RID: 56569
		[Token(Token = "0x400DCF9")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CurTimer;
	}
}
