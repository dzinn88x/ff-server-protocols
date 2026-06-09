using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023A6 RID: 9126
	[Token(Token = "0x20023A6")]
	public class UIHudWereWolvesInteractView : UIBaseView
	{
		// Token: 0x0600C25C RID: 49756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C25C")]
		[Address(RVA = "0x1D13D18", Offset = "0x1D13D18", VA = "0x7BBC513D18", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C25D RID: 49757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C25D")]
		[Address(RVA = "0x1D13EF8", Offset = "0x1D13EF8", VA = "0x7BBC513EF8")]
		public UIHudWereWolvesInteractView()
		{
		}

		// Token: 0x0400DDB6 RID: 56758
		[Token(Token = "0x400DDB6")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ActButton;

		// Token: 0x0400DDB7 RID: 56759
		[Token(Token = "0x400DDB7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SpriteTable;

		// Token: 0x0400DDB8 RID: 56760
		[Token(Token = "0x400DDB8")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SpriteOther;

		// Token: 0x0400DDB9 RID: 56761
		[Token(Token = "0x400DDB9")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CountDownRoot;

		// Token: 0x0400DDBA RID: 56762
		[Token(Token = "0x400DDBA")]
		[FieldOffset(Offset = "0x40")]
		public UILabel CountDownLabel;

		// Token: 0x0400DDBB RID: 56763
		[Token(Token = "0x400DDBB")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ActionLabel;
	}
}
