using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002299 RID: 8857
	[Token(Token = "0x2002299")]
	public class UIHudCombineWeaponView : UIBaseView
	{
		// Token: 0x0600C043 RID: 49219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C043")]
		[Address(RVA = "0x1A913F0", Offset = "0x1A913F0", VA = "0x7BBC2913F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C044 RID: 49220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C044")]
		[Address(RVA = "0x1A9158C", Offset = "0x1A9158C", VA = "0x7BBC29158C")]
		public UIHudCombineWeaponView()
		{
		}

		// Token: 0x0400D490 RID: 54416
		[Token(Token = "0x400D490")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnCombine;

		// Token: 0x0400D491 RID: 54417
		[Token(Token = "0x400D491")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SpriteCombine;

		// Token: 0x0400D492 RID: 54418
		[Token(Token = "0x400D492")]
		[FieldOffset(Offset = "0x30")]
		public Transform iconEmotion;

		// Token: 0x0400D493 RID: 54419
		[Token(Token = "0x400D493")]
		[FieldOffset(Offset = "0x38")]
		public UIWidget iconWidget;

		// Token: 0x0400D494 RID: 54420
		[Token(Token = "0x400D494")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SpriteDissolve;
	}
}
