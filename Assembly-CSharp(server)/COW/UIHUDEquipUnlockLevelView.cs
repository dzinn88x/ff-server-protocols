using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022C6 RID: 8902
	[Token(Token = "0x20022C6")]
	public class UIHUDEquipUnlockLevelView : UIBaseView
	{
		// Token: 0x0600C09C RID: 49308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C09C")]
		[Address(RVA = "0x16B9678", Offset = "0x16B9678", VA = "0x7BBBEB9678", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C09D RID: 49309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C09D")]
		[Address(RVA = "0x16B9798", Offset = "0x16B9798", VA = "0x7BBBEB9798")]
		public UIHUDEquipUnlockLevelView()
		{
		}

		// Token: 0x0400D65B RID: 54875
		[Token(Token = "0x400D65B")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid LevelGrid;

		// Token: 0x0400D65C RID: 54876
		[Token(Token = "0x400D65C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CountdownLabel;

		// Token: 0x0400D65D RID: 54877
		[Token(Token = "0x400D65D")]
		[FieldOffset(Offset = "0x30")]
		public UIButton ConfirmBtn;
	}
}
