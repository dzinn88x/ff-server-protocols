using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002325 RID: 8997
	[Token(Token = "0x2002325")]
	internal class UIHudPetNameView : UIBaseView
	{
		// Token: 0x0600C15A RID: 49498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C15A")]
		[Address(RVA = "0x1D6EBB0", Offset = "0x1D6EBB0", VA = "0x7BBC56EBB0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C15B RID: 49499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C15B")]
		[Address(RVA = "0x1D6ECA0", Offset = "0x1D6ECA0", VA = "0x7BBC56ECA0")]
		public UIHudPetNameView()
		{
		}

		// Token: 0x0400DA1C RID: 55836
		[Token(Token = "0x400DA1C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400DA1D RID: 55837
		[Token(Token = "0x400DA1D")]
		[FieldOffset(Offset = "0x28")]
		public UILabel name;
	}
}
