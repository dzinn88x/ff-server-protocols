using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024B7 RID: 9399
	[Token(Token = "0x20024B7")]
	internal class UIPVEWeaponItemView : UIBaseView
	{
		// Token: 0x0600C47E RID: 50302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C47E")]
		[Address(RVA = "0x16E84CC", Offset = "0x16E84CC", VA = "0x7BBBEE84CC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C47F RID: 50303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C47F")]
		[Address(RVA = "0x16E87BC", Offset = "0x16E87BC", VA = "0x7BBBEE87BC")]
		public UIPVEWeaponItemView()
		{
		}

		// Token: 0x0400EEDF RID: 61151
		[Token(Token = "0x400EEDF")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButton ItemBtn;

		// Token: 0x0400EEE0 RID: 61152
		[Token(Token = "0x400EEE0")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Purchase;

		// Token: 0x0400EEE1 RID: 61153
		[Token(Token = "0x400EEE1")]
		[FieldOffset(Offset = "0x30")]
		public UISprite avatarIcon;

		// Token: 0x0400EEE2 RID: 61154
		[Token(Token = "0x400EEE2")]
		[FieldOffset(Offset = "0x38")]
		public GameObject gray;

		// Token: 0x0400EEE3 RID: 61155
		[Token(Token = "0x400EEE3")]
		[FieldOffset(Offset = "0x40")]
		public UISprite itemSprite;

		// Token: 0x0400EEE4 RID: 61156
		[Token(Token = "0x400EEE4")]
		[FieldOffset(Offset = "0x48")]
		public GameObject TipsGO;

		// Token: 0x0400EEE5 RID: 61157
		[Token(Token = "0x400EEE5")]
		[FieldOffset(Offset = "0x50")]
		public UILabel TagLabel;

		// Token: 0x0400EEE6 RID: 61158
		[Token(Token = "0x400EEE6")]
		[FieldOffset(Offset = "0x58")]
		public GameObject HL;

		// Token: 0x0400EEE7 RID: 61159
		[Token(Token = "0x400EEE7")]
		[FieldOffset(Offset = "0x60")]
		public UISprite descSprite;

		// Token: 0x0400EEE8 RID: 61160
		[Token(Token = "0x400EEE8")]
		[FieldOffset(Offset = "0x68")]
		public UILabel description;
	}
}
