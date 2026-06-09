using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022D1 RID: 8913
	[Token(Token = "0x20022D1")]
	public class UIHudFireView : UIBaseView
	{
		// Token: 0x0600C0B2 RID: 49330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0B2")]
		[Address(RVA = "0x1C0F244", Offset = "0x1C0F244", VA = "0x7BBC40F244", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0B3 RID: 49331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0B3")]
		[Address(RVA = "0x1C0F46C", Offset = "0x1C0F46C", VA = "0x7BBC40F46C")]
		public UIHudFireView()
		{
		}

		// Token: 0x0400D69F RID: 54943
		[Token(Token = "0x400D69F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnFire;

		// Token: 0x0400D6A0 RID: 54944
		[Token(Token = "0x400D6A0")]
		[FieldOffset(Offset = "0x28")]
		public UISprite SpriteNormal;

		// Token: 0x0400D6A1 RID: 54945
		[Token(Token = "0x400D6A1")]
		[FieldOffset(Offset = "0x30")]
		public Transform iconFire;

		// Token: 0x0400D6A2 RID: 54946
		[Token(Token = "0x400D6A2")]
		[FieldOffset(Offset = "0x38")]
		public UIWidget iconWidget;

		// Token: 0x0400D6A3 RID: 54947
		[Token(Token = "0x400D6A3")]
		[FieldOffset(Offset = "0x40")]
		public Transform DamageBuffGo;

		// Token: 0x0400D6A4 RID: 54948
		[Token(Token = "0x400D6A4")]
		[FieldOffset(Offset = "0x48")]
		public Transform fire_BG;

		// Token: 0x0400D6A5 RID: 54949
		[Token(Token = "0x400D6A5")]
		[FieldOffset(Offset = "0x50")]
		public TweenFill cdBar;
	}
}
