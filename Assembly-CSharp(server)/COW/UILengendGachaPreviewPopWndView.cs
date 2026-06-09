using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023E0 RID: 9184
	[Token(Token = "0x20023E0")]
	public class UILengendGachaPreviewPopWndView : UIBaseView
	{
		// Token: 0x0600C2D0 RID: 49872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D0")]
		[Address(RVA = "0x1CB5F30", Offset = "0x1CB5F30", VA = "0x7BBC4B5F30", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2D1 RID: 49873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D1")]
		[Address(RVA = "0x1CB6050", Offset = "0x1CB6050", VA = "0x7BBC4B6050")]
		public UILengendGachaPreviewPopWndView()
		{
		}

		// Token: 0x0400E073 RID: 57459
		[Token(Token = "0x400E073")]
		[FieldOffset(Offset = "0x20")]
		public UIButton OkBtn;

		// Token: 0x0400E074 RID: 57460
		[Token(Token = "0x400E074")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView ScrollView;

		// Token: 0x0400E075 RID: 57461
		[Token(Token = "0x400E075")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid Grid;
	}
}
