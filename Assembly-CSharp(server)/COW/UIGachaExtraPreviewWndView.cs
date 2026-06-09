using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002210 RID: 8720
	[Token(Token = "0x2002210")]
	public class UIGachaExtraPreviewWndView : UIBaseView
	{
		// Token: 0x0600BF31 RID: 48945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF31")]
		[Address(RVA = "0x2164A14", Offset = "0x2164A14", VA = "0x7BBC964A14", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF32 RID: 48946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF32")]
		[Address(RVA = "0x2164BB0", Offset = "0x2164BB0", VA = "0x7BBC964BB0")]
		public UIGachaExtraPreviewWndView()
		{
		}

		// Token: 0x0400CEB8 RID: 52920
		[Token(Token = "0x400CEB8")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid PreviewGrid;

		// Token: 0x0400CEB9 RID: 52921
		[Token(Token = "0x400CEB9")]
		[FieldOffset(Offset = "0x28")]
		public UIButton OKBtn;

		// Token: 0x0400CEBA RID: 52922
		[Token(Token = "0x400CEBA")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BtnLabel;

		// Token: 0x0400CEBB RID: 52923
		[Token(Token = "0x400CEBB")]
		[FieldOffset(Offset = "0x38")]
		public UILabel AccumulationLabel;

		// Token: 0x0400CEBC RID: 52924
		[Token(Token = "0x400CEBC")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LeftTimes;
	}
}
