using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023EC RID: 9196
	[Token(Token = "0x20023EC")]
	internal class UILoadingView : UIBaseView
	{
		// Token: 0x0600C2E8 RID: 49896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E8")]
		[Address(RVA = "0x1CC9660", Offset = "0x1CC9660", VA = "0x7BBC4C9660", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2E9 RID: 49897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E9")]
		[Address(RVA = "0x1CC97FC", Offset = "0x1CC97FC", VA = "0x7BBC4C97FC")]
		public UILoadingView()
		{
		}

		// Token: 0x0400E101 RID: 57601
		[Token(Token = "0x400E101")]
		[FieldOffset(Offset = "0x20")]
		public GameObject tips;

		// Token: 0x0400E102 RID: 57602
		[Token(Token = "0x400E102")]
		[FieldOffset(Offset = "0x28")]
		public UILabel modeTips;

		// Token: 0x0400E103 RID: 57603
		[Token(Token = "0x400E103")]
		[FieldOffset(Offset = "0x30")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400E104 RID: 57604
		[Token(Token = "0x400E104")]
		[FieldOffset(Offset = "0x38")]
		public GameObject BgPanel;

		// Token: 0x0400E105 RID: 57605
		[Token(Token = "0x400E105")]
		[FieldOffset(Offset = "0x40")]
		public GameObject DefaultBg;
	}
}
