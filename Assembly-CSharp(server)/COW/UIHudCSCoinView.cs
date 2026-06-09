using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022A4 RID: 8868
	[Token(Token = "0x20022A4")]
	internal class UIHudCSCoinView : UIBaseView
	{
		// Token: 0x0600C059 RID: 49241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C059")]
		[Address(RVA = "0x19B6630", Offset = "0x19B6630", VA = "0x7BBC1B6630", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C05A RID: 49242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C05A")]
		[Address(RVA = "0x19B66CC", Offset = "0x19B66CC", VA = "0x7BBC1B66CC")]
		public UIHudCSCoinView()
		{
		}

		// Token: 0x0400D4F6 RID: 54518
		[Token(Token = "0x400D4F6")]
		[FieldOffset(Offset = "0x20")]
		public UILabel coin;
	}
}
