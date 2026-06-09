using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002394 RID: 9108
	[Token(Token = "0x2002394")]
	internal class UIHudVehicleBoostView : UIBaseView
	{
		// Token: 0x0600C238 RID: 49720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C238")]
		[Address(RVA = "0x15EF11C", Offset = "0x15EF11C", VA = "0x7BBBDEF11C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C239 RID: 49721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C239")]
		[Address(RVA = "0x15EF280", Offset = "0x15EF280", VA = "0x7BBBDEF280")]
		public UIHudVehicleBoostView()
		{
		}

		// Token: 0x0400DD0F RID: 56591
		[Token(Token = "0x400DD0F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btnBoost;

		// Token: 0x0400DD10 RID: 56592
		[Token(Token = "0x400DD10")]
		[FieldOffset(Offset = "0x28")]
		public UISprite normal;

		// Token: 0x0400DD11 RID: 56593
		[Token(Token = "0x400DD11")]
		[FieldOffset(Offset = "0x30")]
		public UISprite icon;

		// Token: 0x0400DD12 RID: 56594
		[Token(Token = "0x400DD12")]
		[FieldOffset(Offset = "0x38")]
		public TweenFill cooldown;
	}
}
