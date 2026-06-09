using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002261 RID: 8801
	[Token(Token = "0x2002261")]
	public class UIHudArmsItemView : UIBaseView
	{
		// Token: 0x0600BFD3 RID: 49107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD3")]
		[Address(RVA = "0x1884B60", Offset = "0x1884B60", VA = "0x7BBC084B60", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFD4 RID: 49108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD4")]
		[Address(RVA = "0x1884CFC", Offset = "0x1884CFC", VA = "0x7BBC084CFC")]
		public UIHudArmsItemView()
		{
		}

		// Token: 0x0400D35F RID: 54111
		[Token(Token = "0x400D35F")]
		[FieldOffset(Offset = "0x20")]
		public Animator EffectControl;

		// Token: 0x0400D360 RID: 54112
		[Token(Token = "0x400D360")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid Grid;

		// Token: 0x0400D361 RID: 54113
		[Token(Token = "0x400D361")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Tens;

		// Token: 0x0400D362 RID: 54114
		[Token(Token = "0x400D362")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Units;

		// Token: 0x0400D363 RID: 54115
		[Token(Token = "0x400D363")]
		[FieldOffset(Offset = "0x40")]
		public UISprite WeaponSprite;
	}
}
