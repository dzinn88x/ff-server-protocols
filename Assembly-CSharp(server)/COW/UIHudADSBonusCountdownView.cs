using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200225B RID: 8795
	[Token(Token = "0x200225B")]
	public class UIHudADSBonusCountdownView : UIBaseView
	{
		// Token: 0x0600BFC7 RID: 49095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC7")]
		[Address(RVA = "0x1D61EA8", Offset = "0x1D61EA8", VA = "0x7BBC561EA8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFC8 RID: 49096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC8")]
		[Address(RVA = "0x1D6200C", Offset = "0x1D6200C", VA = "0x7BBC56200C")]
		public UIHudADSBonusCountdownView()
		{
		}

		// Token: 0x0400D33A RID: 54074
		[Token(Token = "0x400D33A")]
		[FieldOffset(Offset = "0x20")]
		public UIProgressBar ProgressBarBg;

		// Token: 0x0400D33B RID: 54075
		[Token(Token = "0x400D33B")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ProgressBarBgSprite;

		// Token: 0x0400D33C RID: 54076
		[Token(Token = "0x400D33C")]
		[FieldOffset(Offset = "0x30")]
		public UISprite ProgressbarForSprite;

		// Token: 0x0400D33D RID: 54077
		[Token(Token = "0x400D33D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel BonusTimeLabel;
	}
}
