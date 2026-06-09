using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200217E RID: 8574
	[Token(Token = "0x200217E")]
	public class UICommonGuideView : UIBaseView
	{
		// Token: 0x0600BE0C RID: 48652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE0C")]
		[Address(RVA = "0x1802C88", Offset = "0x1802C88", VA = "0x7BBC002C88", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE0D RID: 48653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE0D")]
		[Address(RVA = "0x1802EDC", Offset = "0x1802EDC", VA = "0x7BBC002EDC")]
		public UICommonGuideView()
		{
		}

		// Token: 0x0400C786 RID: 51078
		[Token(Token = "0x400C786")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget Circle;

		// Token: 0x0400C787 RID: 51079
		[Token(Token = "0x400C787")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Pics;

		// Token: 0x0400C788 RID: 51080
		[Token(Token = "0x400C788")]
		[FieldOffset(Offset = "0x30")]
		public UILabel GuideText;

		// Token: 0x0400C789 RID: 51081
		[Token(Token = "0x400C789")]
		[FieldOffset(Offset = "0x38")]
		public UISprite LabelBG;

		// Token: 0x0400C78A RID: 51082
		[Token(Token = "0x400C78A")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Arrow;

		// Token: 0x0400C78B RID: 51083
		[Token(Token = "0x400C78B")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Effect_Circle;

		// Token: 0x0400C78C RID: 51084
		[Token(Token = "0x400C78C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Effect_Arrow;

		// Token: 0x0400C78D RID: 51085
		[Token(Token = "0x400C78D")]
		[FieldOffset(Offset = "0x58")]
		public TweenPosition UI_CommonGuide_Arrow;
	}
}
