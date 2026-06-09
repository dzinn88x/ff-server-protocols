using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002396 RID: 9110
	[Token(Token = "0x2002396")]
	public class UIHudVehicleDriverFireView : UIBaseView
	{
		// Token: 0x0600C23C RID: 49724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C23C")]
		[Address(RVA = "0x15EF82C", Offset = "0x15EF82C", VA = "0x7BBBDEF82C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C23D RID: 49725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C23D")]
		[Address(RVA = "0x15EFA24", Offset = "0x15EFA24", VA = "0x7BBBDEFA24")]
		public UIHudVehicleDriverFireView()
		{
		}

		// Token: 0x0400DD18 RID: 56600
		[Token(Token = "0x400DD18")]
		[FieldOffset(Offset = "0x20")]
		public UISprite fire_BG;

		// Token: 0x0400DD19 RID: 56601
		[Token(Token = "0x400DD19")]
		[FieldOffset(Offset = "0x28")]
		public UIButton btn;

		// Token: 0x0400DD1A RID: 56602
		[Token(Token = "0x400DD1A")]
		[FieldOffset(Offset = "0x30")]
		public TweenFill cooldown;

		// Token: 0x0400DD1B RID: 56603
		[Token(Token = "0x400DD1B")]
		[FieldOffset(Offset = "0x38")]
		public Transform InteractionTran;

		// Token: 0x0400DD1C RID: 56604
		[Token(Token = "0x400DD1C")]
		[FieldOffset(Offset = "0x40")]
		public UISprite icon;

		// Token: 0x0400DD1D RID: 56605
		[Token(Token = "0x400DD1D")]
		[FieldOffset(Offset = "0x48")]
		public UISprite normal;
	}
}
