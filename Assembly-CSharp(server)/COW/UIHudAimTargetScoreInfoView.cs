using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200225D RID: 8797
	[Token(Token = "0x200225D")]
	public class UIHudAimTargetScoreInfoView : UIBaseView
	{
		// Token: 0x0600BFCB RID: 49099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFCB")]
		[Address(RVA = "0x1884338", Offset = "0x1884338", VA = "0x7BBC084338", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFCC RID: 49100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFCC")]
		[Address(RVA = "0x1884548", Offset = "0x1884548", VA = "0x7BBC084548")]
		public UIHudAimTargetScoreInfoView()
		{
		}

		// Token: 0x0400D351 RID: 54097
		[Token(Token = "0x400D351")]
		[FieldOffset(Offset = "0x20")]
		public UILabel AllScoreLabel;

		// Token: 0x0400D352 RID: 54098
		[Token(Token = "0x400D352")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ScaleScoreLabel;

		// Token: 0x0400D353 RID: 54099
		[Token(Token = "0x400D353")]
		[FieldOffset(Offset = "0x30")]
		public UILabel AngleScoreLabel;

		// Token: 0x0400D354 RID: 54100
		[Token(Token = "0x400D354")]
		[FieldOffset(Offset = "0x38")]
		public UILabel DistScoreLabel;

		// Token: 0x0400D355 RID: 54101
		[Token(Token = "0x400D355")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BG;

		// Token: 0x0400D356 RID: 54102
		[Token(Token = "0x400D356")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ChooseBG;

		// Token: 0x0400D357 RID: 54103
		[Token(Token = "0x400D357")]
		[FieldOffset(Offset = "0x50")]
		public UISprite TagSprite;
	}
}
