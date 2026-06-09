using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021AE RID: 8622
	[Token(Token = "0x20021AE")]
	internal class UIDownloadInfoPopupWindowView : UIBaseView
	{
		// Token: 0x0600BE6C RID: 48748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE6C")]
		[Address(RVA = "0x220BE68", Offset = "0x220BE68", VA = "0x7BBCA0BE68", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE6D RID: 48749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE6D")]
		[Address(RVA = "0x220C320", Offset = "0x220C320", VA = "0x7BBCA0C320")]
		public UIDownloadInfoPopupWindowView()
		{
		}

		// Token: 0x0400C99B RID: 51611
		[Token(Token = "0x400C99B")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400C99C RID: 51612
		[Token(Token = "0x400C99C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TitleLabel;

		// Token: 0x0400C99D RID: 51613
		[Token(Token = "0x400C99D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SingleHint;

		// Token: 0x0400C99E RID: 51614
		[Token(Token = "0x400C99E")]
		[FieldOffset(Offset = "0x38")]
		public UIButton SingleHintCancleBtn;

		// Token: 0x0400C99F RID: 51615
		[Token(Token = "0x400C99F")]
		[FieldOffset(Offset = "0x40")]
		public UIButton SingleHintConfirmBtn;

		// Token: 0x0400C9A0 RID: 51616
		[Token(Token = "0x400C9A0")]
		[FieldOffset(Offset = "0x48")]
		public GameObject DonwloadInfo;

		// Token: 0x0400C9A1 RID: 51617
		[Token(Token = "0x400C9A1")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnLeft;

		// Token: 0x0400C9A2 RID: 51618
		[Token(Token = "0x400C9A2")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LeftLabel;

		// Token: 0x0400C9A3 RID: 51619
		[Token(Token = "0x400C9A3")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnRight;

		// Token: 0x0400C9A4 RID: 51620
		[Token(Token = "0x400C9A4")]
		[FieldOffset(Offset = "0x68")]
		public UILabel RightLabel;

		// Token: 0x0400C9A5 RID: 51621
		[Token(Token = "0x400C9A5")]
		[FieldOffset(Offset = "0x70")]
		public UILabel InfoLabel;

		// Token: 0x0400C9A6 RID: 51622
		[Token(Token = "0x400C9A6")]
		[FieldOffset(Offset = "0x78")]
		public UIProgressBar DownloadProgressBar;

		// Token: 0x0400C9A7 RID: 51623
		[Token(Token = "0x400C9A7")]
		[FieldOffset(Offset = "0x80")]
		public UILabel DownloadPercent;

		// Token: 0x0400C9A8 RID: 51624
		[Token(Token = "0x400C9A8")]
		[FieldOffset(Offset = "0x88")]
		public UILabel FileName;

		// Token: 0x0400C9A9 RID: 51625
		[Token(Token = "0x400C9A9")]
		[FieldOffset(Offset = "0x90")]
		public TweenAlpha FileNameTween;

		// Token: 0x0400C9AA RID: 51626
		[Token(Token = "0x400C9AA")]
		[FieldOffset(Offset = "0x98")]
		public UILabel PauseHint;

		// Token: 0x0400C9AB RID: 51627
		[Token(Token = "0x400C9AB")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject SingleDownloadInfo;

		// Token: 0x0400C9AC RID: 51628
		[Token(Token = "0x400C9AC")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel SingleFileSizeInfo;

		// Token: 0x0400C9AD RID: 51629
		[Token(Token = "0x400C9AD")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton SingleDownloadBtn;
	}
}
