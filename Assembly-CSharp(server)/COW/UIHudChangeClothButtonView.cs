using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002293 RID: 8851
	[Token(Token = "0x2002293")]
	internal class UIHudChangeClothButtonView : UIBaseView
	{
		// Token: 0x0600C037 RID: 49207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C037")]
		[Address(RVA = "0x19D2254", Offset = "0x19D2254", VA = "0x7BBC1D2254", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C038 RID: 49208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C038")]
		[Address(RVA = "0x19D22F0", Offset = "0x19D22F0", VA = "0x7BBC1D22F0")]
		public UIHudChangeClothButtonView()
		{
		}

		// Token: 0x0400D479 RID: 54393
		[Token(Token = "0x400D479")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ChangeButton;
	}
}
