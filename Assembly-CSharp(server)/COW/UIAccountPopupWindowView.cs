using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020D6 RID: 8406
	[Token(Token = "0x20020D6")]
	public class UIAccountPopupWindowView : UIBaseView
	{
		// Token: 0x0600BCBD RID: 48317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCBD")]
		[Address(RVA = "0x1A3C4F0", Offset = "0x1A3C4F0", VA = "0x7BBC23C4F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCBE RID: 48318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCBE")]
		[Address(RVA = "0x1A3C854", Offset = "0x1A3C854", VA = "0x7BBC23C854")]
		public UIAccountPopupWindowView()
		{
		}

		// Token: 0x0400BE80 RID: 48768
		[Token(Token = "0x400BE80")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400BE81 RID: 48769
		[Token(Token = "0x400BE81")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TitleLabel;

		// Token: 0x0400BE82 RID: 48770
		[Token(Token = "0x400BE82")]
		[FieldOffset(Offset = "0x30")]
		public UILabel RegionLabel;

		// Token: 0x0400BE83 RID: 48771
		[Token(Token = "0x400BE83")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelIdentifier;

		// Token: 0x0400BE84 RID: 48772
		[Token(Token = "0x400BE84")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LabelPassword;

		// Token: 0x0400BE85 RID: 48773
		[Token(Token = "0x400BE85")]
		[FieldOffset(Offset = "0x48")]
		public UIInput InputPassword;

		// Token: 0x0400BE86 RID: 48774
		[Token(Token = "0x400BE86")]
		[FieldOffset(Offset = "0x50")]
		public UIInput InputIdentifier;

		// Token: 0x0400BE87 RID: 48775
		[Token(Token = "0x400BE87")]
		[FieldOffset(Offset = "0x58")]
		public UILabel MessageLabel;

		// Token: 0x0400BE88 RID: 48776
		[Token(Token = "0x400BE88")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnLeft;

		// Token: 0x0400BE89 RID: 48777
		[Token(Token = "0x400BE89")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LeftLabel;

		// Token: 0x0400BE8A RID: 48778
		[Token(Token = "0x400BE8A")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnRight;

		// Token: 0x0400BE8B RID: 48779
		[Token(Token = "0x400BE8B")]
		[FieldOffset(Offset = "0x78")]
		public UILabel RightLabel;

		// Token: 0x0400BE8C RID: 48780
		[Token(Token = "0x400BE8C")]
		[FieldOffset(Offset = "0x80")]
		public UIToggle PasswardToggle;
	}
}
