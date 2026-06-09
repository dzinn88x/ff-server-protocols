using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002397 RID: 9111
	[Token(Token = "0x2002397")]
	public class UIHudVehicleHornView : UIBaseView
	{
		// Token: 0x0600C23E RID: 49726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C23E")]
		[Address(RVA = "0x15EFA2C", Offset = "0x15EFA2C", VA = "0x7BBBDEFA2C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C23F RID: 49727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C23F")]
		[Address(RVA = "0x15EFBC8", Offset = "0x15EFBC8", VA = "0x7BBBDEFBC8")]
		public UIHudVehicleHornView()
		{
		}

		// Token: 0x0400DD1E RID: 56606
		[Token(Token = "0x400DD1E")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btn;

		// Token: 0x0400DD1F RID: 56607
		[Token(Token = "0x400DD1F")]
		[FieldOffset(Offset = "0x28")]
		public TweenFill cooldown;

		// Token: 0x0400DD20 RID: 56608
		[Token(Token = "0x400DD20")]
		[FieldOffset(Offset = "0x30")]
		public UISprite CoolDownSpr;

		// Token: 0x0400DD21 RID: 56609
		[Token(Token = "0x400DD21")]
		[FieldOffset(Offset = "0x38")]
		public UISprite icon;

		// Token: 0x0400DD22 RID: 56610
		[Token(Token = "0x400DD22")]
		[FieldOffset(Offset = "0x40")]
		public UISprite normal;
	}
}
