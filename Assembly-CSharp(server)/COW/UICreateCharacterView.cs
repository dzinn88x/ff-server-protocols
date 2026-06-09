using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200218C RID: 8588
	[Token(Token = "0x200218C")]
	internal class UICreateCharacterView : UIBaseView
	{
		// Token: 0x0600BE28 RID: 48680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE28")]
		[Address(RVA = "0x181A60C", Offset = "0x181A60C", VA = "0x7BBC01A60C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE29 RID: 48681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE29")]
		[Address(RVA = "0x181A888", Offset = "0x181A888", VA = "0x7BBC01A888")]
		public UICreateCharacterView()
		{
		}

		// Token: 0x0400C7DA RID: 51162
		[Token(Token = "0x400C7DA")]
		[FieldOffset(Offset = "0x20")]
		public UISprite MaskBg;

		// Token: 0x0400C7DB RID: 51163
		[Token(Token = "0x400C7DB")]
		[FieldOffset(Offset = "0x28")]
		public UITexture BG;

		// Token: 0x0400C7DC RID: 51164
		[Token(Token = "0x400C7DC")]
		[FieldOffset(Offset = "0x30")]
		public UIButton close;

		// Token: 0x0400C7DD RID: 51165
		[Token(Token = "0x400C7DD")]
		[FieldOffset(Offset = "0x38")]
		public GameObject RegisterPanel;

		// Token: 0x0400C7DE RID: 51166
		[Token(Token = "0x400C7DE")]
		[FieldOffset(Offset = "0x40")]
		public UIInput InputCode;

		// Token: 0x0400C7DF RID: 51167
		[Token(Token = "0x400C7DF")]
		[FieldOffset(Offset = "0x48")]
		public UIInput InputNickName;

		// Token: 0x0400C7E0 RID: 51168
		[Token(Token = "0x400C7E0")]
		[FieldOffset(Offset = "0x50")]
		public UIButton Random;

		// Token: 0x0400C7E1 RID: 51169
		[Token(Token = "0x400C7E1")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BtnRegister;
	}
}
