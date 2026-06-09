using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002399 RID: 9113
	[Token(Token = "0x2002399")]
	public class UIHUDVehicleLevelUpTipView : UIBaseView
	{
		// Token: 0x0600C242 RID: 49730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C242")]
		[Address(RVA = "0x1D52BE8", Offset = "0x1D52BE8", VA = "0x7BBC552BE8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C243 RID: 49731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C243")]
		[Address(RVA = "0x1D52CD8", Offset = "0x1D52CD8", VA = "0x7BBC552CD8")]
		public UIHUDVehicleLevelUpTipView()
		{
		}

		// Token: 0x0400DD27 RID: 56615
		[Token(Token = "0x400DD27")]
		[FieldOffset(Offset = "0x20")]
		public UISprite ArmIcon;

		// Token: 0x0400DD28 RID: 56616
		[Token(Token = "0x400DD28")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TipLabel;
	}
}
