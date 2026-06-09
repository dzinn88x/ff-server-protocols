using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002289 RID: 8841
	[Token(Token = "0x2002289")]
	internal class UIHudBrakeView : UIBaseView
	{
		// Token: 0x0600C023 RID: 49187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C023")]
		[Address(RVA = "0x189F294", Offset = "0x189F294", VA = "0x7BBC09F294", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C024 RID: 49188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C024")]
		[Address(RVA = "0x189F384", Offset = "0x189F384", VA = "0x7BBC09F384")]
		public UIHudBrakeView()
		{
		}

		// Token: 0x0400D450 RID: 54352
		[Token(Token = "0x400D450")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnBrake;

		// Token: 0x0400D451 RID: 54353
		[Token(Token = "0x400D451")]
		[FieldOffset(Offset = "0x28")]
		public UILabel BtnName;
	}
}
