using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200259F RID: 9631
	[Token(Token = "0x200259F")]
	public class UIWeaponZoomInView : UIBaseView
	{
		// Token: 0x0600C64E RID: 50766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C64E")]
		[Address(RVA = "0x1785BD8", Offset = "0x1785BD8", VA = "0x7BBBF85BD8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C64F RID: 50767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C64F")]
		[Address(RVA = "0x1785CF8", Offset = "0x1785CF8", VA = "0x7BBBF85CF8")]
		public UIWeaponZoomInView()
		{
		}

		// Token: 0x0400F87C RID: 63612
		[Token(Token = "0x400F87C")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btnClose;

		// Token: 0x0400F87D RID: 63613
		[Token(Token = "0x400F87D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject arrow;

		// Token: 0x0400F87E RID: 63614
		[Token(Token = "0x400F87E")]
		[FieldOffset(Offset = "0x30")]
		public UITexture PetBgPanel;
	}
}
