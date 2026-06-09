using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002504 RID: 9476
	[Token(Token = "0x2002504")]
	public class UISPHudCSRoundResultItemView : UIBaseView
	{
		// Token: 0x0600C51A RID: 50458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C51A")]
		[Address(RVA = "0x1EE24D8", Offset = "0x1EE24D8", VA = "0x7BBC6E24D8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C51B RID: 50459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C51B")]
		[Address(RVA = "0x1EE2734", Offset = "0x1EE2734", VA = "0x7BBC6E2734")]
		public UISPHudCSRoundResultItemView()
		{
		}

		// Token: 0x0400F1B5 RID: 61877
		[Token(Token = "0x400F1B5")]
		[FieldOffset(Offset = "0x20")]
		public UILabel RoundId;

		// Token: 0x0400F1B6 RID: 61878
		[Token(Token = "0x400F1B6")]
		[FieldOffset(Offset = "0x28")]
		public GameObject RedWinObj;

		// Token: 0x0400F1B7 RID: 61879
		[Token(Token = "0x400F1B7")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RedWin;

		// Token: 0x0400F1B8 RID: 61880
		[Token(Token = "0x400F1B8")]
		[FieldOffset(Offset = "0x38")]
		public GameObject RedExplode;

		// Token: 0x0400F1B9 RID: 61881
		[Token(Token = "0x400F1B9")]
		[FieldOffset(Offset = "0x40")]
		public GameObject RedRemove;

		// Token: 0x0400F1BA RID: 61882
		[Token(Token = "0x400F1BA")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BlueWinObj;

		// Token: 0x0400F1BB RID: 61883
		[Token(Token = "0x400F1BB")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BlueWin;

		// Token: 0x0400F1BC RID: 61884
		[Token(Token = "0x400F1BC")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BlueExplode;

		// Token: 0x0400F1BD RID: 61885
		[Token(Token = "0x400F1BD")]
		[FieldOffset(Offset = "0x60")]
		public GameObject BlueRemove;
	}
}
