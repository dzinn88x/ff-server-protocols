using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200235C RID: 9052
	[Token(Token = "0x200235C")]
	public class UIHudServerMiniGameInviteView : UIBaseView
	{
		// Token: 0x0600C1C8 RID: 49608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C8")]
		[Address(RVA = "0x166401C", Offset = "0x166401C", VA = "0x7BBBE6401C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1C9 RID: 49609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C9")]
		[Address(RVA = "0x1664470", Offset = "0x1664470", VA = "0x7BBBE64470")]
		public UIHudServerMiniGameInviteView()
		{
		}

		// Token: 0x0400DB62 RID: 56162
		[Token(Token = "0x400DB62")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnAction;

		// Token: 0x0400DB63 RID: 56163
		[Token(Token = "0x400DB63")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ActionNameTxt;

		// Token: 0x0400DB64 RID: 56164
		[Token(Token = "0x400DB64")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BtnBg;

		// Token: 0x0400DB65 RID: 56165
		[Token(Token = "0x400DB65")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BtnIcon;

		// Token: 0x0400DB66 RID: 56166
		[Token(Token = "0x400DB66")]
		[FieldOffset(Offset = "0x40")]
		public GameObject CDMask;

		// Token: 0x0400DB67 RID: 56167
		[Token(Token = "0x400DB67")]
		[FieldOffset(Offset = "0x48")]
		public UISprite CDProgress;

		// Token: 0x0400DB68 RID: 56168
		[Token(Token = "0x400DB68")]
		[FieldOffset(Offset = "0x50")]
		public GameObject InviteBox;

		// Token: 0x0400DB69 RID: 56169
		[Token(Token = "0x400DB69")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LabelInfo;

		// Token: 0x0400DB6A RID: 56170
		[Token(Token = "0x400DB6A")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnAll;

		// Token: 0x0400DB6B RID: 56171
		[Token(Token = "0x400DB6B")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LabelAll;

		// Token: 0x0400DB6C RID: 56172
		[Token(Token = "0x400DB6C")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnFriend;

		// Token: 0x0400DB6D RID: 56173
		[Token(Token = "0x400DB6D")]
		[FieldOffset(Offset = "0x78")]
		public UILabel LabelFriend;

		// Token: 0x0400DB6E RID: 56174
		[Token(Token = "0x400DB6E")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnClose;

		// Token: 0x0400DB6F RID: 56175
		[Token(Token = "0x400DB6F")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnBackTo;

		// Token: 0x0400DB70 RID: 56176
		[Token(Token = "0x400DB70")]
		[FieldOffset(Offset = "0x90")]
		public UISprite GuideSprite;

		// Token: 0x0400DB71 RID: 56177
		[Token(Token = "0x400DB71")]
		[FieldOffset(Offset = "0x98")]
		public UILabel TipTxt;
	}
}
