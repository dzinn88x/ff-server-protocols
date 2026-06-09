using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002336 RID: 9014
	[Token(Token = "0x2002336")]
	internal class UIHUDPVEGameCountdownView : UIBaseView
	{
		// Token: 0x0600C17C RID: 49532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C17C")]
		[Address(RVA = "0x16BA454", Offset = "0x16BA454", VA = "0x7BBBEBA454", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C17D RID: 49533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C17D")]
		[Address(RVA = "0x16BA4F0", Offset = "0x16BA4F0", VA = "0x7BBBEBA4F0")]
		public UIHUDPVEGameCountdownView()
		{
		}

		// Token: 0x0400DA8E RID: 55950
		[Token(Token = "0x400DA8E")]
		[FieldOffset(Offset = "0x20")]
		public UILabel CountDownLabel;
	}
}
