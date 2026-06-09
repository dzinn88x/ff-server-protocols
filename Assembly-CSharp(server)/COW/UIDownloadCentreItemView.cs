using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021AC RID: 8620
	[Token(Token = "0x20021AC")]
	internal class UIDownloadCentreItemView : UIBaseView
	{
		// Token: 0x0600BE68 RID: 48744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE68")]
		[Address(RVA = "0x220B9A0", Offset = "0x220B9A0", VA = "0x7BBCA0B9A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE69 RID: 48745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE69")]
		[Address(RVA = "0x220BD60", Offset = "0x220BD60", VA = "0x7BBCA0BD60")]
		public UIDownloadCentreItemView()
		{
		}

		// Token: 0x0400C98B RID: 51595
		[Token(Token = "0x400C98B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Content;

		// Token: 0x0400C98C RID: 51596
		[Token(Token = "0x400C98C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel NameLabel;

		// Token: 0x0400C98D RID: 51597
		[Token(Token = "0x400C98D")]
		[FieldOffset(Offset = "0x30")]
		public UISprite DLCIcon_pic;

		// Token: 0x0400C98E RID: 51598
		[Token(Token = "0x400C98E")]
		[FieldOffset(Offset = "0x38")]
		public UIButton Reward_btn;

		// Token: 0x0400C98F RID: 51599
		[Token(Token = "0x400C98F")]
		[FieldOffset(Offset = "0x40")]
		public UISprite RewardStateIcon;

		// Token: 0x0400C990 RID: 51600
		[Token(Token = "0x400C990")]
		[FieldOffset(Offset = "0x48")]
		public GameObject RewardHint;

		// Token: 0x0400C991 RID: 51601
		[Token(Token = "0x400C991")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ProgressBar;

		// Token: 0x0400C992 RID: 51602
		[Token(Token = "0x400C992")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Data_label;

		// Token: 0x0400C993 RID: 51603
		[Token(Token = "0x400C993")]
		[FieldOffset(Offset = "0x60")]
		public UIButton DownloadingIcon_pic_btn;

		// Token: 0x0400C994 RID: 51604
		[Token(Token = "0x400C994")]
		[FieldOffset(Offset = "0x68")]
		public UIButton DownloadPause_pic_btn;

		// Token: 0x0400C995 RID: 51605
		[Token(Token = "0x400C995")]
		[FieldOffset(Offset = "0x70")]
		public UIButton DownloadRetry_pic_btn;

		// Token: 0x0400C996 RID: 51606
		[Token(Token = "0x400C996")]
		[FieldOffset(Offset = "0x78")]
		public UIButton DownloadDeleteIcon_btn;

		// Token: 0x0400C997 RID: 51607
		[Token(Token = "0x400C997")]
		[FieldOffset(Offset = "0x80")]
		public UILabel DownloadStatLabel;

		// Token: 0x0400C998 RID: 51608
		[Token(Token = "0x400C998")]
		[FieldOffset(Offset = "0x88")]
		public UISprite Bg_pic;
	}
}
