using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200251B RID: 9499
	[Token(Token = "0x200251B")]
	internal class UISPHudMultiPlayerItemView : UIBaseView
	{
		// Token: 0x0600C546 RID: 50502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C546")]
		[Address(RVA = "0x1EEAB70", Offset = "0x1EEAB70", VA = "0x7BBC6EAB70", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C547 RID: 50503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C547")]
		[Address(RVA = "0x1EEAD04", Offset = "0x1EEAD04", VA = "0x7BBC6EAD04")]
		public UISPHudMultiPlayerItemView()
		{
		}

		// Token: 0x0400F28C RID: 62092
		[Token(Token = "0x400F28C")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Arrow;

		// Token: 0x0400F28D RID: 62093
		[Token(Token = "0x400F28D")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TeamNo;

		// Token: 0x0400F28E RID: 62094
		[Token(Token = "0x400F28E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TeamName;

		// Token: 0x0400F28F RID: 62095
		[Token(Token = "0x400F28F")]
		[FieldOffset(Offset = "0x38")]
		public GameObject PlayerInfo;

		// Token: 0x0400F290 RID: 62096
		[Token(Token = "0x400F290")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid PlayerGrid;
	}
}
