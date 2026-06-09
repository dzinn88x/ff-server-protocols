using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002294 RID: 8852
	[Token(Token = "0x2002294")]
	internal class UIHudChangeClothListView : UIBaseView
	{
		// Token: 0x0600C039 RID: 49209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C039")]
		[Address(RVA = "0x1A8DD60", Offset = "0x1A8DD60", VA = "0x7BBC28DD60", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C03A RID: 49210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C03A")]
		[Address(RVA = "0x1A8DF70", Offset = "0x1A8DF70", VA = "0x7BBC28DF70")]
		public UIHudChangeClothListView()
		{
		}

		// Token: 0x0400D47A RID: 54394
		[Token(Token = "0x400D47A")]
		[FieldOffset(Offset = "0x20")]
		public UISprite bg;

		// Token: 0x0400D47B RID: 54395
		[Token(Token = "0x400D47B")]
		[FieldOffset(Offset = "0x28")]
		public UIButton CloseBtn;

		// Token: 0x0400D47C RID: 54396
		[Token(Token = "0x400D47C")]
		[FieldOffset(Offset = "0x30")]
		public UIInput SearchInput;

		// Token: 0x0400D47D RID: 54397
		[Token(Token = "0x400D47D")]
		[FieldOffset(Offset = "0x38")]
		public UIButton _1PViewBtn;

		// Token: 0x0400D47E RID: 54398
		[Token(Token = "0x400D47E")]
		[FieldOffset(Offset = "0x40")]
		public UIButton _3PViewBtn;

		// Token: 0x0400D47F RID: 54399
		[Token(Token = "0x400D47F")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid Grid;

		// Token: 0x0400D480 RID: 54400
		[Token(Token = "0x400D480")]
		[FieldOffset(Offset = "0x50")]
		public UIHudClothItemView ClothItem;
	}
}
