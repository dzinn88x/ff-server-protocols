using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200216A RID: 8554
	[Token(Token = "0x200216A")]
	internal class UIClanLevelUpView : UIBaseView
	{
		// Token: 0x0600BDE4 RID: 48612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE4")]
		[Address(RVA = "0x1CFB7BC", Offset = "0x1CFB7BC", VA = "0x7BBC4FB7BC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDE5 RID: 48613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE5")]
		[Address(RVA = "0x1CFB9DC", Offset = "0x1CFB9DC", VA = "0x7BBC4FB9DC")]
		public UIClanLevelUpView()
		{
		}

		// Token: 0x0400C603 RID: 50691
		[Token(Token = "0x400C603")]
		[FieldOffset(Offset = "0x20")]
		public UILabel BeforeLevel;

		// Token: 0x0400C604 RID: 50692
		[Token(Token = "0x400C604")]
		[FieldOffset(Offset = "0x28")]
		public UILabel AfterLevel;

		// Token: 0x0400C605 RID: 50693
		[Token(Token = "0x400C605")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BG;

		// Token: 0x0400C606 RID: 50694
		[Token(Token = "0x400C606")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid AwardGrid;

		// Token: 0x0400C607 RID: 50695
		[Token(Token = "0x400C607")]
		[FieldOffset(Offset = "0x40")]
		public UIButton OKBtn;

		// Token: 0x0400C608 RID: 50696
		[Token(Token = "0x400C608")]
		[FieldOffset(Offset = "0x48")]
		public UISprite LevelIcon;

		// Token: 0x0400C609 RID: 50697
		[Token(Token = "0x400C609")]
		[FieldOffset(Offset = "0x50")]
		public UILabel LevelLabel;
	}
}
