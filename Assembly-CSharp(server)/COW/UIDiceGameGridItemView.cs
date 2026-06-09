using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021A4 RID: 8612
	[Token(Token = "0x20021A4")]
	public class UIDiceGameGridItemView : UIBaseView
	{
		// Token: 0x0600BE58 RID: 48728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE58")]
		[Address(RVA = "0x21FA850", Offset = "0x21FA850", VA = "0x7BBC9FA850", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE59 RID: 48729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE59")]
		[Address(RVA = "0x21FAA50", Offset = "0x21FAA50", VA = "0x7BBC9FAA50")]
		public UIDiceGameGridItemView()
		{
		}

		// Token: 0x0400C910 RID: 51472
		[Token(Token = "0x400C910")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BoxSpr;

		// Token: 0x0400C911 RID: 51473
		[Token(Token = "0x400C911")]
		[FieldOffset(Offset = "0x28")]
		public UISprite TokenSpr;

		// Token: 0x0400C912 RID: 51474
		[Token(Token = "0x400C912")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BonusDiceSpr;

		// Token: 0x0400C913 RID: 51475
		[Token(Token = "0x400C913")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BonusRwdSpr;

		// Token: 0x0400C914 RID: 51476
		[Token(Token = "0x400C914")]
		[FieldOffset(Offset = "0x40")]
		public UISprite MoveForwardSpr;

		// Token: 0x0400C915 RID: 51477
		[Token(Token = "0x400C915")]
		[FieldOffset(Offset = "0x48")]
		public UISprite MoveBackoffSpr;

		// Token: 0x0400C916 RID: 51478
		[Token(Token = "0x400C916")]
		[FieldOffset(Offset = "0x50")]
		public UISprite EventSpr;
	}
}
