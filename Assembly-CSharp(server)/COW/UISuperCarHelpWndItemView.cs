using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200255E RID: 9566
	[Token(Token = "0x200255E")]
	public class UISuperCarHelpWndItemView : UIBaseView
	{
		// Token: 0x0600C5CC RID: 50636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5CC")]
		[Address(RVA = "0x21458D0", Offset = "0x21458D0", VA = "0x7BBC9458D0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5CD RID: 50637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5CD")]
		[Address(RVA = "0x2145AB0", Offset = "0x2145AB0", VA = "0x7BBC945AB0")]
		public UISuperCarHelpWndItemView()
		{
		}

		// Token: 0x0400F535 RID: 62773
		[Token(Token = "0x400F535")]
		[FieldOffset(Offset = "0x20")]
		public UILabel NameLabel;

		// Token: 0x0400F536 RID: 62774
		[Token(Token = "0x400F536")]
		[FieldOffset(Offset = "0x28")]
		public UILabel AccLabel;

		// Token: 0x0400F537 RID: 62775
		[Token(Token = "0x400F537")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BgSprite;

		// Token: 0x0400F538 RID: 62776
		[Token(Token = "0x400F538")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnGetSkin;

		// Token: 0x0400F539 RID: 62777
		[Token(Token = "0x400F539")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ReturnToken;

		// Token: 0x0400F53A RID: 62778
		[Token(Token = "0x400F53A")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnInvite;
	}
}
