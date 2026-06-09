using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022CC RID: 8908
	[Token(Token = "0x20022CC")]
	public class UIHudEscortVehicleInfoView : UIBaseView
	{
		// Token: 0x0600C0A8 RID: 49320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0A8")]
		[Address(RVA = "0x1C091B4", Offset = "0x1C091B4", VA = "0x7BBC4091B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0A9 RID: 49321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0A9")]
		[Address(RVA = "0x1C093CC", Offset = "0x1C093CC", VA = "0x7BBC4093CC")]
		public UIHudEscortVehicleInfoView()
		{
		}

		// Token: 0x0400D683 RID: 54915
		[Token(Token = "0x400D683")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BodyHPBar;

		// Token: 0x0400D684 RID: 54916
		[Token(Token = "0x400D684")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BodyTipBtn;

		// Token: 0x0400D685 RID: 54917
		[Token(Token = "0x400D685")]
		[FieldOffset(Offset = "0x30")]
		public UISprite WheelHPBar;

		// Token: 0x0400D686 RID: 54918
		[Token(Token = "0x400D686")]
		[FieldOffset(Offset = "0x38")]
		public UIButton WheelTipBtn;

		// Token: 0x0400D687 RID: 54919
		[Token(Token = "0x400D687")]
		[FieldOffset(Offset = "0x40")]
		public UISprite OKStatus;

		// Token: 0x0400D688 RID: 54920
		[Token(Token = "0x400D688")]
		[FieldOffset(Offset = "0x48")]
		public UIButton StatusTipBtn;

		// Token: 0x0400D689 RID: 54921
		[Token(Token = "0x400D689")]
		[FieldOffset(Offset = "0x50")]
		public UISprite NotOKStatus;
	}
}
