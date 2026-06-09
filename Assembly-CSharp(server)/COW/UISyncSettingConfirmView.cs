using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002570 RID: 9584
	[Token(Token = "0x2002570")]
	public class UISyncSettingConfirmView : UIBaseView
	{
		// Token: 0x0600C5F0 RID: 50672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5F0")]
		[Address(RVA = "0x1F4F994", Offset = "0x1F4F994", VA = "0x7BBC74F994", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5F1 RID: 50673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5F1")]
		[Address(RVA = "0x1F4FD90", Offset = "0x1F4FD90", VA = "0x7BBC74FD90")]
		public UISyncSettingConfirmView()
		{
		}

		// Token: 0x0400F613 RID: 62995
		[Token(Token = "0x400F613")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SuccessContainer;

		// Token: 0x0400F614 RID: 62996
		[Token(Token = "0x400F614")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnSuccessConfirm;

		// Token: 0x0400F615 RID: 62997
		[Token(Token = "0x400F615")]
		[FieldOffset(Offset = "0x30")]
		public GameObject UploadCoverContainer;

		// Token: 0x0400F616 RID: 62998
		[Token(Token = "0x400F616")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnUploadCoverConfirm;

		// Token: 0x0400F617 RID: 62999
		[Token(Token = "0x400F617")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnUploadCoverCancel;

		// Token: 0x0400F618 RID: 63000
		[Token(Token = "0x400F618")]
		[FieldOffset(Offset = "0x48")]
		public GameObject DownloadCoverContainer;

		// Token: 0x0400F619 RID: 63001
		[Token(Token = "0x400F619")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnDownloadCoverConfirm;

		// Token: 0x0400F61A RID: 63002
		[Token(Token = "0x400F61A")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BtnDownloadCoverCancel;

		// Token: 0x0400F61B RID: 63003
		[Token(Token = "0x400F61B")]
		[FieldOffset(Offset = "0x60")]
		public GameObject FailureContainer;

		// Token: 0x0400F61C RID: 63004
		[Token(Token = "0x400F61C")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BtnFailureConfirm;

		// Token: 0x0400F61D RID: 63005
		[Token(Token = "0x400F61D")]
		[FieldOffset(Offset = "0x70")]
		public GameObject UploadFailureContainer;

		// Token: 0x0400F61E RID: 63006
		[Token(Token = "0x400F61E")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnUploadFailureConfirm;

		// Token: 0x0400F61F RID: 63007
		[Token(Token = "0x400F61F")]
		[FieldOffset(Offset = "0x80")]
		public GameObject DownloadFailureContainer;

		// Token: 0x0400F620 RID: 63008
		[Token(Token = "0x400F620")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnDownloadFailureConfirm;

		// Token: 0x0400F621 RID: 63009
		[Token(Token = "0x400F621")]
		[FieldOffset(Offset = "0x90")]
		public GameObject DownloadSuccessContainer;

		// Token: 0x0400F622 RID: 63010
		[Token(Token = "0x400F622")]
		[FieldOffset(Offset = "0x98")]
		public UIButton BtnDownloadSuccessConfirm;
	}
}
