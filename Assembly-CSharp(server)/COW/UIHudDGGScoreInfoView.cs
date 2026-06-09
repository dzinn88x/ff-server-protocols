using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022BB RID: 8891
	[Token(Token = "0x20022BB")]
	internal class UIHudDGGScoreInfoView : UIBaseView
	{
		// Token: 0x0600C086 RID: 49286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C086")]
		[Address(RVA = "0x1BFB17C", Offset = "0x1BFB17C", VA = "0x7BBC3FB17C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C087 RID: 49287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C087")]
		[Address(RVA = "0x1BFB26C", Offset = "0x1BFB26C", VA = "0x7BBC3FB26C")]
		public UIHudDGGScoreInfoView()
		{
		}

		// Token: 0x0400D618 RID: 54808
		[Token(Token = "0x400D618")]
		[FieldOffset(Offset = "0x20")]
		public UILabel ScoreLabel;

		// Token: 0x0400D619 RID: 54809
		[Token(Token = "0x400D619")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LeadingScoreLabel;
	}
}
