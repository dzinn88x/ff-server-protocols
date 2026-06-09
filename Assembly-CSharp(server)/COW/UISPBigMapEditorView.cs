using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024F9 RID: 9465
	[Token(Token = "0x20024F9")]
	public class UISPBigMapEditorView : UIBaseView
	{
		// Token: 0x0600C502 RID: 50434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C502")]
		[Address(RVA = "0x1A263F4", Offset = "0x1A263F4", VA = "0x7BBC2263F4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C503 RID: 50435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C503")]
		[Address(RVA = "0x1A266DC", Offset = "0x1A266DC", VA = "0x7BBC2266DC")]
		public UISPBigMapEditorView()
		{
		}

		// Token: 0x0400F132 RID: 61746
		[Token(Token = "0x400F132")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Grid;

		// Token: 0x0400F133 RID: 61747
		[Token(Token = "0x400F133")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget BG;

		// Token: 0x0400F134 RID: 61748
		[Token(Token = "0x400F134")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Line;

		// Token: 0x0400F135 RID: 61749
		[Token(Token = "0x400F135")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Arrow;

		// Token: 0x0400F136 RID: 61750
		[Token(Token = "0x400F136")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Circle;

		// Token: 0x0400F137 RID: 61751
		[Token(Token = "0x400F137")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Draw;

		// Token: 0x0400F138 RID: 61752
		[Token(Token = "0x400F138")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Color;

		// Token: 0x0400F139 RID: 61753
		[Token(Token = "0x400F139")]
		[FieldOffset(Offset = "0x58")]
		public UIButton CtrlZ;

		// Token: 0x0400F13A RID: 61754
		[Token(Token = "0x400F13A")]
		[FieldOffset(Offset = "0x60")]
		public UIWidget Rect1;

		// Token: 0x0400F13B RID: 61755
		[Token(Token = "0x400F13B")]
		[FieldOffset(Offset = "0x68")]
		public UIButton Delete;

		// Token: 0x0400F13C RID: 61756
		[Token(Token = "0x400F13C")]
		[FieldOffset(Offset = "0x70")]
		public UIWidget Rect2;
	}
}
