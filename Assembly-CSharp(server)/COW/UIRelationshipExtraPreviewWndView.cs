using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024CC RID: 9420
	[Token(Token = "0x20024CC")]
	public class UIRelationshipExtraPreviewWndView : UIBaseView
	{
		// Token: 0x0600C4A8 RID: 50344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A8")]
		[Address(RVA = "0x1E1B268", Offset = "0x1E1B268", VA = "0x7BBC61B268", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4A9 RID: 50345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A9")]
		[Address(RVA = "0x1E1B3F4", Offset = "0x1E1B3F4", VA = "0x7BBC61B3F4")]
		public UIRelationshipExtraPreviewWndView()
		{
		}

		// Token: 0x0400EFB0 RID: 61360
		[Token(Token = "0x400EFB0")]
		[FieldOffset(Offset = "0x20")]
		public UIButton OKBtn;

		// Token: 0x0400EFB1 RID: 61361
		[Token(Token = "0x400EFB1")]
		[FieldOffset(Offset = "0x28")]
		public UILabel BtnLabel;

		// Token: 0x0400EFB2 RID: 61362
		[Token(Token = "0x400EFB2")]
		[FieldOffset(Offset = "0x30")]
		public UILabel AccumulationLabel;

		// Token: 0x0400EFB3 RID: 61363
		[Token(Token = "0x400EFB3")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LeftTimes;

		// Token: 0x0400EFB4 RID: 61364
		[Token(Token = "0x400EFB4")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid PreviewGrid;
	}
}
