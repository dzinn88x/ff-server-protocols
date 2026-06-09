using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022BF RID: 8895
	[Token(Token = "0x20022BF")]
	public class UIHudEatMushroomView : UIBaseView
	{
		// Token: 0x0600C08E RID: 49294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C08E")]
		[Address(RVA = "0x1C017EC", Offset = "0x1C017EC", VA = "0x7BBC4017EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C08F RID: 49295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C08F")]
		[Address(RVA = "0x1C01958", Offset = "0x1C01958", VA = "0x7BBC401958")]
		public UIHudEatMushroomView()
		{
		}

		// Token: 0x0400D642 RID: 54850
		[Token(Token = "0x400D642")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnEat;

		// Token: 0x0400D643 RID: 54851
		[Token(Token = "0x400D643")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Icon;

		// Token: 0x0400D644 RID: 54852
		[Token(Token = "0x400D644")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ActionName;

		// Token: 0x0400D645 RID: 54853
		[Token(Token = "0x400D645")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Cooldown;
	}
}
