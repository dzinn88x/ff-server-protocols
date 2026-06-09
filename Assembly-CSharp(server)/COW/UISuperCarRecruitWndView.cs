using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002564 RID: 9572
	[Token(Token = "0x2002564")]
	public class UISuperCarRecruitWndView : UIBaseView
	{
		// Token: 0x0600C5D8 RID: 50648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D8")]
		[Address(RVA = "0x214A5D8", Offset = "0x214A5D8", VA = "0x7BBC94A5D8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5D9 RID: 50649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D9")]
		[Address(RVA = "0x214A8C0", Offset = "0x214A8C0", VA = "0x7BBC94A8C0")]
		public UISuperCarRecruitWndView()
		{
		}

		// Token: 0x0400F566 RID: 62822
		[Token(Token = "0x400F566")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400F567 RID: 62823
		[Token(Token = "0x400F567")]
		[FieldOffset(Offset = "0x28")]
		public UIToggle WorldToggle;

		// Token: 0x0400F568 RID: 62824
		[Token(Token = "0x400F568")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget WorldWidget;

		// Token: 0x0400F569 RID: 62825
		[Token(Token = "0x400F569")]
		[FieldOffset(Offset = "0x38")]
		public UILabel WorldLabel;

		// Token: 0x0400F56A RID: 62826
		[Token(Token = "0x400F56A")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle ClanToggle;

		// Token: 0x0400F56B RID: 62827
		[Token(Token = "0x400F56B")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget ClanWidget;

		// Token: 0x0400F56C RID: 62828
		[Token(Token = "0x400F56C")]
		[FieldOffset(Offset = "0x50")]
		public UIButton SendBtn;

		// Token: 0x0400F56D RID: 62829
		[Token(Token = "0x400F56D")]
		[FieldOffset(Offset = "0x58")]
		public GameObject SendIconLight;

		// Token: 0x0400F56E RID: 62830
		[Token(Token = "0x400F56E")]
		[FieldOffset(Offset = "0x60")]
		public UISprite SendIcon;

		// Token: 0x0400F56F RID: 62831
		[Token(Token = "0x400F56F")]
		[FieldOffset(Offset = "0x68")]
		public UILabel SendDesc;
	}
}
