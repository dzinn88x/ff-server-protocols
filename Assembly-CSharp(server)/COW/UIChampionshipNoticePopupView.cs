using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002136 RID: 8502
	[Token(Token = "0x2002136")]
	public class UIChampionshipNoticePopupView : UIBaseView
	{
		// Token: 0x0600BD7C RID: 48508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD7C")]
		[Address(RVA = "0x1EC8418", Offset = "0x1EC8418", VA = "0x7BBC6C8418", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD7D RID: 48509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD7D")]
		[Address(RVA = "0x1EC8630", Offset = "0x1EC8630", VA = "0x7BBC6C8630")]
		public UIChampionshipNoticePopupView()
		{
		}

		// Token: 0x0400C3A5 RID: 50085
		[Token(Token = "0x400C3A5")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView CDNScrollView;

		// Token: 0x0400C3A6 RID: 50086
		[Token(Token = "0x400C3A6")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid CDNGrid;

		// Token: 0x0400C3A7 RID: 50087
		[Token(Token = "0x400C3A7")]
		[FieldOffset(Offset = "0x30")]
		public UICenterOnChild UICenterOnChild;

		// Token: 0x0400C3A8 RID: 50088
		[Token(Token = "0x400C3A8")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid DotGrid;

		// Token: 0x0400C3A9 RID: 50089
		[Token(Token = "0x400C3A9")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnClose;

		// Token: 0x0400C3AA RID: 50090
		[Token(Token = "0x400C3AA")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnLeft;

		// Token: 0x0400C3AB RID: 50091
		[Token(Token = "0x400C3AB")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnRight;
	}
}
