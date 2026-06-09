using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022BA RID: 8890
	[Token(Token = "0x20022BA")]
	internal class UIHudDGGProgressBarView : UIBaseView
	{
		// Token: 0x0600C084 RID: 49284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C084")]
		[Address(RVA = "0x1AAB170", Offset = "0x1AAB170", VA = "0x7BBC2AB170", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C085 RID: 49285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C085")]
		[Address(RVA = "0x1AAB3FC", Offset = "0x1AAB3FC", VA = "0x7BBC2AB3FC")]
		public UIHudDGGProgressBarView()
		{
		}

		// Token: 0x0400D60F RID: 54799
		[Token(Token = "0x400D60F")]
		[FieldOffset(Offset = "0x20")]
		public UILabel TimeLabel;

		// Token: 0x0400D610 RID: 54800
		[Token(Token = "0x400D610")]
		[FieldOffset(Offset = "0x28")]
		public UIProgressBar MyBar;

		// Token: 0x0400D611 RID: 54801
		[Token(Token = "0x400D611")]
		[FieldOffset(Offset = "0x30")]
		public UISprite MyBarValue;

		// Token: 0x0400D612 RID: 54802
		[Token(Token = "0x400D612")]
		[FieldOffset(Offset = "0x38")]
		public UIProgressBar TargetBar;

		// Token: 0x0400D613 RID: 54803
		[Token(Token = "0x400D613")]
		[FieldOffset(Offset = "0x40")]
		public UISprite TargetBarValue;

		// Token: 0x0400D614 RID: 54804
		[Token(Token = "0x400D614")]
		[FieldOffset(Offset = "0x48")]
		public Transform MyThump;

		// Token: 0x0400D615 RID: 54805
		[Token(Token = "0x400D615")]
		[FieldOffset(Offset = "0x50")]
		public Transform TargetThump;

		// Token: 0x0400D616 RID: 54806
		[Token(Token = "0x400D616")]
		[FieldOffset(Offset = "0x58")]
		public UILabel TargetThumpLabel;

		// Token: 0x0400D617 RID: 54807
		[Token(Token = "0x400D617")]
		[FieldOffset(Offset = "0x60")]
		public Transform WarningThump;
	}
}
