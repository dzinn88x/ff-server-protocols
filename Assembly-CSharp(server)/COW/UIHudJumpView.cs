using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022F8 RID: 8952
	[Token(Token = "0x20022F8")]
	public class UIHudJumpView : UIBaseView
	{
		// Token: 0x0600C100 RID: 49408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C100")]
		[Address(RVA = "0x1C4E7F0", Offset = "0x1C4E7F0", VA = "0x7BBC44E7F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C101 RID: 49409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C101")]
		[Address(RVA = "0x1C4E9E8", Offset = "0x1C4E9E8", VA = "0x7BBC44E9E8")]
		public UIHudJumpView()
		{
		}

		// Token: 0x0400D7E6 RID: 55270
		[Token(Token = "0x400D7E6")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Effect_VFX;

		// Token: 0x0400D7E7 RID: 55271
		[Token(Token = "0x400D7E7")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnJump;

		// Token: 0x0400D7E8 RID: 55272
		[Token(Token = "0x400D7E8")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BtnSprite;

		// Token: 0x0400D7E9 RID: 55273
		[Token(Token = "0x400D7E9")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Energy;

		// Token: 0x0400D7EA RID: 55274
		[Token(Token = "0x400D7EA")]
		[FieldOffset(Offset = "0x40")]
		public UISprite EnergyBar;

		// Token: 0x0400D7EB RID: 55275
		[Token(Token = "0x400D7EB")]
		[FieldOffset(Offset = "0x48")]
		public UISprite EnergyBarHL;
	}
}
