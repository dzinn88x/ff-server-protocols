using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002507 RID: 9479
	[Token(Token = "0x2002507")]
	public class UISPHudCSRoundTransitionView : UIBaseView
	{
		// Token: 0x0600C520 RID: 50464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C520")]
		[Address(RVA = "0x1EE3858", Offset = "0x1EE3858", VA = "0x7BBC6E3858", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C521 RID: 50465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C521")]
		[Address(RVA = "0x1EE3A38", Offset = "0x1EE3A38", VA = "0x7BBC6E3A38")]
		public UISPHudCSRoundTransitionView()
		{
		}

		// Token: 0x0400F1CE RID: 61902
		[Token(Token = "0x400F1CE")]
		[FieldOffset(Offset = "0x20")]
		public Animator Animator;

		// Token: 0x0400F1CF RID: 61903
		[Token(Token = "0x400F1CF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject nextRoundContainer;

		// Token: 0x0400F1D0 RID: 61904
		[Token(Token = "0x400F1D0")]
		[FieldOffset(Offset = "0x30")]
		public UILabel roundNum;

		// Token: 0x0400F1D1 RID: 61905
		[Token(Token = "0x400F1D1")]
		[FieldOffset(Offset = "0x38")]
		public UILabel MapName;

		// Token: 0x0400F1D2 RID: 61906
		[Token(Token = "0x400F1D2")]
		[FieldOffset(Offset = "0x40")]
		public UILabel gamezoneName;

		// Token: 0x0400F1D3 RID: 61907
		[Token(Token = "0x400F1D3")]
		[FieldOffset(Offset = "0x48")]
		public UILabel matchpoint;
	}
}
