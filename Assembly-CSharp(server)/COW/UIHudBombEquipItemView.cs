using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200227E RID: 8830
	[Token(Token = "0x200227E")]
	public class UIHudBombEquipItemView : UIBaseView
	{
		// Token: 0x0600C00D RID: 49165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C00D")]
		[Address(RVA = "0x1898A58", Offset = "0x1898A58", VA = "0x7BBC098A58", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C00E RID: 49166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C00E")]
		[Address(RVA = "0x1898DB4", Offset = "0x1898DB4", VA = "0x7BBC098DB4")]
		public UIHudBombEquipItemView()
		{
		}

		// Token: 0x0400D407 RID: 54279
		[Token(Token = "0x400D407")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButton ItemBtn;

		// Token: 0x0400D408 RID: 54280
		[Token(Token = "0x400D408")]
		[FieldOffset(Offset = "0x28")]
		public GameObject OneObjectContainer;

		// Token: 0x0400D409 RID: 54281
		[Token(Token = "0x400D409")]
		[FieldOffset(Offset = "0x30")]
		public UISprite itemSprite;

		// Token: 0x0400D40A RID: 54282
		[Token(Token = "0x400D40A")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelItemCount;

		// Token: 0x0400D40B RID: 54283
		[Token(Token = "0x400D40B")]
		[FieldOffset(Offset = "0x40")]
		public GameObject TwoObjectContainer;

		// Token: 0x0400D40C RID: 54284
		[Token(Token = "0x400D40C")]
		[FieldOffset(Offset = "0x48")]
		public UISprite itemSprite1;

		// Token: 0x0400D40D RID: 54285
		[Token(Token = "0x400D40D")]
		[FieldOffset(Offset = "0x50")]
		public UISprite itemSprite2;

		// Token: 0x0400D40E RID: 54286
		[Token(Token = "0x400D40E")]
		[FieldOffset(Offset = "0x58")]
		public UILabel name;

		// Token: 0x0400D40F RID: 54287
		[Token(Token = "0x400D40F")]
		[FieldOffset(Offset = "0x60")]
		public GameObject HL;

		// Token: 0x0400D410 RID: 54288
		[Token(Token = "0x400D410")]
		[FieldOffset(Offset = "0x68")]
		public UILabel price;

		// Token: 0x0400D411 RID: 54289
		[Token(Token = "0x400D411")]
		[FieldOffset(Offset = "0x70")]
		public GameObject gray;

		// Token: 0x0400D412 RID: 54290
		[Token(Token = "0x400D412")]
		[FieldOffset(Offset = "0x78")]
		public GameObject bonus;

		// Token: 0x0400D413 RID: 54291
		[Token(Token = "0x400D413")]
		[FieldOffset(Offset = "0x80")]
		public UILabel limitation;
	}
}
