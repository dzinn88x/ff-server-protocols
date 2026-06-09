using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001993 RID: 6547
	[Token(Token = "0x2001993")]
	public class UIHudWeaponShield : MonoBehaviour
	{
		// Token: 0x060085CA RID: 34250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085CA")]
		[Address(RVA = "0x1D0DE2C", Offset = "0x1D0DE2C", VA = "0x7BBC50DE2C")]
		public void UpdateShieldState(object shield)
		{
		}

		// Token: 0x060085CB RID: 34251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085CB")]
		[Address(RVA = "0x1D0E0A0", Offset = "0x1D0E0A0", VA = "0x7BBC50E0A0")]
		public UIHudWeaponShield()
		{
		}

		// Token: 0x0400953C RID: 38204
		[Token(Token = "0x400953C")]
		[FieldOffset(Offset = "0x18")]
		public UISprite shieldIcon;

		// Token: 0x0400953D RID: 38205
		[Token(Token = "0x400953D")]
		[FieldOffset(Offset = "0x20")]
		public UISprite hp;
	}
}
