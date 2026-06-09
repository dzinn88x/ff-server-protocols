using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023D3 RID: 9171
	[Token(Token = "0x20023D3")]
	public class UILadderHeroicMarkPopupView : UIBaseView
	{
		// Token: 0x0600C2B6 RID: 49846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2B6")]
		[Address(RVA = "0x1E85E58", Offset = "0x1E85E58", VA = "0x7BBC685E58", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2B7 RID: 49847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2B7")]
		[Address(RVA = "0x1E860C4", Offset = "0x1E860C4", VA = "0x7BBC6860C4")]
		public UILadderHeroicMarkPopupView()
		{
		}

		// Token: 0x0400DF71 RID: 57201
		[Token(Token = "0x400DF71")]
		[FieldOffset(Offset = "0x20")]
		public Animation EnterAnim;

		// Token: 0x0400DF72 RID: 57202
		[Token(Token = "0x400DF72")]
		[FieldOffset(Offset = "0x28")]
		public GameObject InfoBefore;

		// Token: 0x0400DF73 RID: 57203
		[Token(Token = "0x400DF73")]
		[FieldOffset(Offset = "0x30")]
		public UISprite IconBeforeSprite;

		// Token: 0x0400DF74 RID: 57204
		[Token(Token = "0x400DF74")]
		[FieldOffset(Offset = "0x38")]
		public GameObject InfoAfter;

		// Token: 0x0400DF75 RID: 57205
		[Token(Token = "0x400DF75")]
		[FieldOffset(Offset = "0x40")]
		public UISprite IconAftereSprite;

		// Token: 0x0400DF76 RID: 57206
		[Token(Token = "0x400DF76")]
		[FieldOffset(Offset = "0x48")]
		public UIButton backBtnMask;

		// Token: 0x0400DF77 RID: 57207
		[Token(Token = "0x400DF77")]
		[FieldOffset(Offset = "0x50")]
		public UILabel BackBtnLabel;

		// Token: 0x0400DF78 RID: 57208
		[Token(Token = "0x400DF78")]
		[FieldOffset(Offset = "0x58")]
		public GameObject VfxContent;
	}
}
