using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002599 RID: 9625
	[Token(Token = "0x2002599")]
	public class UIWeaponSkinUpgraderGunPickView : UIBaseView
	{
		// Token: 0x0600C642 RID: 50754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C642")]
		[Address(RVA = "0x22308C4", Offset = "0x22308C4", VA = "0x7BBCA308C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C643 RID: 50755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C643")]
		[Address(RVA = "0x2230A38", Offset = "0x2230A38", VA = "0x7BBCA30A38")]
		public UIWeaponSkinUpgraderGunPickView()
		{
		}

		// Token: 0x0400F81A RID: 63514
		[Token(Token = "0x400F81A")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnCloseGunPick;

		// Token: 0x0400F81B RID: 63515
		[Token(Token = "0x400F81B")]
		[FieldOffset(Offset = "0x28")]
		public GameObject GunPickContainer;

		// Token: 0x0400F81C RID: 63516
		[Token(Token = "0x400F81C")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView GunPickScrollView;

		// Token: 0x0400F81D RID: 63517
		[Token(Token = "0x400F81D")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid GunGrid;
	}
}
