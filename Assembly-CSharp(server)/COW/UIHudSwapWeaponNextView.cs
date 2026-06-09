using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002370 RID: 9072
	[Token(Token = "0x2002370")]
	internal class UIHudSwapWeaponNextView : UIBaseView
	{
		// Token: 0x0600C1F0 RID: 49648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1F0")]
		[Address(RVA = "0x16756D0", Offset = "0x16756D0", VA = "0x7BBBE756D0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1F1 RID: 49649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1F1")]
		[Address(RVA = "0x167576C", Offset = "0x167576C", VA = "0x7BBBE7576C")]
		public UIHudSwapWeaponNextView()
		{
		}

		// Token: 0x0400DBFA RID: 56314
		[Token(Token = "0x400DBFA")]
		[FieldOffset(Offset = "0x20")]
		public UIButton swapBtn;
	}
}
