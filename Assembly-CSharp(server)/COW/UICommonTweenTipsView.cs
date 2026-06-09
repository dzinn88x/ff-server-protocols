using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002189 RID: 8585
	[Token(Token = "0x2002189")]
	public class UICommonTweenTipsView : UIBaseView
	{
		// Token: 0x0600BE22 RID: 48674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE22")]
		[Address(RVA = "0x1816AE8", Offset = "0x1816AE8", VA = "0x7BBC016AE8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE23 RID: 48675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE23")]
		[Address(RVA = "0x1816CE0", Offset = "0x1816CE0", VA = "0x7BBC016CE0")]
		public UICommonTweenTipsView()
		{
		}

		// Token: 0x0400C7CB RID: 51147
		[Token(Token = "0x400C7CB")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel TipsPanel;

		// Token: 0x0400C7CC RID: 51148
		[Token(Token = "0x400C7CC")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ParentContainer;

		// Token: 0x0400C7CD RID: 51149
		[Token(Token = "0x400C7CD")]
		[FieldOffset(Offset = "0x30")]
		public TweenPosition ParentTP;

		// Token: 0x0400C7CE RID: 51150
		[Token(Token = "0x400C7CE")]
		[FieldOffset(Offset = "0x38")]
		public Animation anim;

		// Token: 0x0400C7CF RID: 51151
		[Token(Token = "0x400C7CF")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TipTxt;

		// Token: 0x0400C7D0 RID: 51152
		[Token(Token = "0x400C7D0")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Bg;
	}
}
