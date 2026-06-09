using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200252A RID: 9514
	[Token(Token = "0x200252A")]
	public class UISPHudReplayCtrlView : UIBaseView
	{
		// Token: 0x0600C564 RID: 50532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C564")]
		[Address(RVA = "0x1EF0048", Offset = "0x1EF0048", VA = "0x7BBC6F0048", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C565 RID: 50533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C565")]
		[Address(RVA = "0x1EF0400", Offset = "0x1EF0400", VA = "0x7BBC6F0400")]
		public UISPHudReplayCtrlView()
		{
		}

		// Token: 0x0400F330 RID: 62256
		[Token(Token = "0x400F330")]
		[FieldOffset(Offset = "0x20")]
		public UIButton FilterBtn;

		// Token: 0x0400F331 RID: 62257
		[Token(Token = "0x400F331")]
		[FieldOffset(Offset = "0x28")]
		public UIButton PauseBtn;

		// Token: 0x0400F332 RID: 62258
		[Token(Token = "0x400F332")]
		[FieldOffset(Offset = "0x30")]
		public UIButton PlayBtn;

		// Token: 0x0400F333 RID: 62259
		[Token(Token = "0x400F333")]
		[FieldOffset(Offset = "0x38")]
		public UIButton MinusBtn;

		// Token: 0x0400F334 RID: 62260
		[Token(Token = "0x400F334")]
		[FieldOffset(Offset = "0x40")]
		public UIButton PlusBtn;

		// Token: 0x0400F335 RID: 62261
		[Token(Token = "0x400F335")]
		[FieldOffset(Offset = "0x48")]
		public UILabel SpeedTxt;

		// Token: 0x0400F336 RID: 62262
		[Token(Token = "0x400F336")]
		[FieldOffset(Offset = "0x50")]
		public ReplayEventBtnView EventBtnTemplate;

		// Token: 0x0400F337 RID: 62263
		[Token(Token = "0x400F337")]
		[FieldOffset(Offset = "0x58")]
		public UILabel TimeTxt;

		// Token: 0x0400F338 RID: 62264
		[Token(Token = "0x400F338")]
		[FieldOffset(Offset = "0x60")]
		public UISlider GameTimeSlider;

		// Token: 0x0400F339 RID: 62265
		[Token(Token = "0x400F339")]
		[FieldOffset(Offset = "0x68")]
		public UIWidget ProgressBG;

		// Token: 0x0400F33A RID: 62266
		[Token(Token = "0x400F33A")]
		[FieldOffset(Offset = "0x70")]
		public UIWidget BG;

		// Token: 0x0400F33B RID: 62267
		[Token(Token = "0x400F33B")]
		[FieldOffset(Offset = "0x78")]
		public GameObject FilterPanel;

		// Token: 0x0400F33C RID: 62268
		[Token(Token = "0x400F33C")]
		[FieldOffset(Offset = "0x80")]
		public UILabel FilterTitle;

		// Token: 0x0400F33D RID: 62269
		[Token(Token = "0x400F33D")]
		[FieldOffset(Offset = "0x88")]
		public UIGrid FilterGrid;
	}
}
