using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200249C RID: 9372
	[Token(Token = "0x200249C")]
	public class UIPopMenuView : UIBaseView
	{
		// Token: 0x0600C448 RID: 50248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C448")]
		[Address(RVA = "0x20EFE24", Offset = "0x20EFE24", VA = "0x7BBC8EFE24", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C449 RID: 50249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C449")]
		[Address(RVA = "0x20EFFC8", Offset = "0x20EFFC8", VA = "0x7BBC8EFFC8")]
		public UIPopMenuView()
		{
		}

		// Token: 0x0400EBEE RID: 60398
		[Token(Token = "0x400EBEE")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel WindowPanel;

		// Token: 0x0400EBEF RID: 60399
		[Token(Token = "0x400EBEF")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Mask;

		// Token: 0x0400EBF0 RID: 60400
		[Token(Token = "0x400EBF0")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget Bg;

		// Token: 0x0400EBF1 RID: 60401
		[Token(Token = "0x400EBF1")]
		[FieldOffset(Offset = "0x38")]
		public UIScrollView MenuScrollView;

		// Token: 0x0400EBF2 RID: 60402
		[Token(Token = "0x400EBF2")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid ItemGrid;
	}
}
