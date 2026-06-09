using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002204 RID: 8708
	[Token(Token = "0x2002204")]
	public class UIFullScreenPreviewView : UIBaseView
	{
		// Token: 0x0600BF19 RID: 48921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF19")]
		[Address(RVA = "0x214F328", Offset = "0x214F328", VA = "0x7BBC94F328", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF1A RID: 48922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF1A")]
		[Address(RVA = "0x214F4CC", Offset = "0x214F4CC", VA = "0x7BBC94F4CC")]
		public UIFullScreenPreviewView()
		{
		}

		// Token: 0x0400CE43 RID: 52803
		[Token(Token = "0x400CE43")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture BG;

		// Token: 0x0400CE44 RID: 52804
		[Token(Token = "0x400CE44")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Close;

		// Token: 0x0400CE45 RID: 52805
		[Token(Token = "0x400CE45")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget LeftBorder;

		// Token: 0x0400CE46 RID: 52806
		[Token(Token = "0x400CE46")]
		[FieldOffset(Offset = "0x38")]
		public UIWidget RightBorder;

		// Token: 0x0400CE47 RID: 52807
		[Token(Token = "0x400CE47")]
		[FieldOffset(Offset = "0x40")]
		public UIPanel PanelMaxDepth;
	}
}
