using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002244 RID: 8772
	[Token(Token = "0x2002244")]
	public class UIGoliathRecruitWndView : UIBaseView
	{
		// Token: 0x0600BF99 RID: 49049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF99")]
		[Address(RVA = "0x1A82584", Offset = "0x1A82584", VA = "0x7BBC282584", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF9A RID: 49050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF9A")]
		[Address(RVA = "0x1A8286C", Offset = "0x1A8286C", VA = "0x7BBC28286C")]
		public UIGoliathRecruitWndView()
		{
		}

		// Token: 0x0400D225 RID: 53797
		[Token(Token = "0x400D225")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400D226 RID: 53798
		[Token(Token = "0x400D226")]
		[FieldOffset(Offset = "0x28")]
		public UIToggle WorldToggle;

		// Token: 0x0400D227 RID: 53799
		[Token(Token = "0x400D227")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget WorldWidget;

		// Token: 0x0400D228 RID: 53800
		[Token(Token = "0x400D228")]
		[FieldOffset(Offset = "0x38")]
		public UILabel WorldLabel;

		// Token: 0x0400D229 RID: 53801
		[Token(Token = "0x400D229")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle ClanToggle;

		// Token: 0x0400D22A RID: 53802
		[Token(Token = "0x400D22A")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget ClanWidget;

		// Token: 0x0400D22B RID: 53803
		[Token(Token = "0x400D22B")]
		[FieldOffset(Offset = "0x50")]
		public UIButton SendBtn;

		// Token: 0x0400D22C RID: 53804
		[Token(Token = "0x400D22C")]
		[FieldOffset(Offset = "0x58")]
		public GameObject SendIconLight;

		// Token: 0x0400D22D RID: 53805
		[Token(Token = "0x400D22D")]
		[FieldOffset(Offset = "0x60")]
		public UISprite SendIcon;

		// Token: 0x0400D22E RID: 53806
		[Token(Token = "0x400D22E")]
		[FieldOffset(Offset = "0x68")]
		public UILabel SendDesc;
	}
}
