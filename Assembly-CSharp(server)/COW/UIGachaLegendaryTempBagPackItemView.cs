using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002216 RID: 8726
	[Token(Token = "0x2002216")]
	public class UIGachaLegendaryTempBagPackItemView : UIBaseView
	{
		// Token: 0x0600BF3D RID: 48957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF3D")]
		[Address(RVA = "0x2058A04", Offset = "0x2058A04", VA = "0x7BBC858A04", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF3E RID: 48958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF3E")]
		[Address(RVA = "0x2058B24", Offset = "0x2058B24", VA = "0x7BBC858B24")]
		public UIGachaLegendaryTempBagPackItemView()
		{
		}

		// Token: 0x0400CF1B RID: 53019
		[Token(Token = "0x400CF1B")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ClickBtn;

		// Token: 0x0400CF1C RID: 53020
		[Token(Token = "0x400CF1C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ItemMini;

		// Token: 0x0400CF1D RID: 53021
		[Token(Token = "0x400CF1D")]
		[FieldOffset(Offset = "0x30")]
		public UIToggle RewardToggle;
	}
}
