using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021CF RID: 8655
	[Token(Token = "0x20021CF")]
	public class UIEPDebrisRewardView : UIBaseView
	{
		// Token: 0x0600BEAF RID: 48815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEAF")]
		[Address(RVA = "0x1ACC1CC", Offset = "0x1ACC1CC", VA = "0x7BBC2CC1CC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEB0 RID: 48816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB0")]
		[Address(RVA = "0x1ACC3D4", Offset = "0x1ACC3D4", VA = "0x7BBC2CC3D4")]
		public UIEPDebrisRewardView()
		{
		}

		// Token: 0x0400CB54 RID: 52052
		[Token(Token = "0x400CB54")]
		[FieldOffset(Offset = "0x20")]
		public UISprite EPBadgeSpr;

		// Token: 0x0400CB55 RID: 52053
		[Token(Token = "0x400CB55")]
		[FieldOffset(Offset = "0x28")]
		public UILabel BadgeCnt;

		// Token: 0x0400CB56 RID: 52054
		[Token(Token = "0x400CB56")]
		[FieldOffset(Offset = "0x30")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400CB57 RID: 52055
		[Token(Token = "0x400CB57")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ProcessCnt;

		// Token: 0x0400CB58 RID: 52056
		[Token(Token = "0x400CB58")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ConstDebrisRate;

		// Token: 0x0400CB59 RID: 52057
		[Token(Token = "0x400CB59")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TipLabel;

		// Token: 0x0400CB5A RID: 52058
		[Token(Token = "0x400CB5A")]
		[FieldOffset(Offset = "0x50")]
		public UIButton SkipBtn;
	}
}
