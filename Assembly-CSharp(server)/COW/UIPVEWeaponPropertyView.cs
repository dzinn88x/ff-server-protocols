using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024B8 RID: 9400
	[Token(Token = "0x20024B8")]
	internal class UIPVEWeaponPropertyView : UIBaseView
	{
		// Token: 0x0600C480 RID: 50304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C480")]
		[Address(RVA = "0x16E95C0", Offset = "0x16E95C0", VA = "0x7BBBEE95C0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C481 RID: 50305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C481")]
		[Address(RVA = "0x16E97B8", Offset = "0x16E97B8", VA = "0x7BBBEE97B8")]
		public UIPVEWeaponPropertyView()
		{
		}

		// Token: 0x0400EEE9 RID: 61161
		[Token(Token = "0x400EEE9")]
		[FieldOffset(Offset = "0x20")]
		public GameObject propertyScore;

		// Token: 0x0400EEEA RID: 61162
		[Token(Token = "0x400EEEA")]
		[FieldOffset(Offset = "0x28")]
		public UISprite bg;

		// Token: 0x0400EEEB RID: 61163
		[Token(Token = "0x400EEEB")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid scoreGrid;

		// Token: 0x0400EEEC RID: 61164
		[Token(Token = "0x400EEEC")]
		[FieldOffset(Offset = "0x38")]
		public UIPVEWeaponPropertyItemView item;

		// Token: 0x0400EEED RID: 61165
		[Token(Token = "0x400EEED")]
		[FieldOffset(Offset = "0x40")]
		public UILabel desc;

		// Token: 0x0400EEEE RID: 61166
		[Token(Token = "0x400EEEE")]
		[FieldOffset(Offset = "0x48")]
		public UILabel pValue;
	}
}
