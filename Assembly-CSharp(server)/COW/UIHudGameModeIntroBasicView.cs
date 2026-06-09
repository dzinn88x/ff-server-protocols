using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022D4 RID: 8916
	[Token(Token = "0x20022D4")]
	public class UIHudGameModeIntroBasicView : UIBaseView
	{
		// Token: 0x0600C0B8 RID: 49336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0B8")]
		[Address(RVA = "0x1C1116C", Offset = "0x1C1116C", VA = "0x7BBC41116C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0B9 RID: 49337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0B9")]
		[Address(RVA = "0x1C112E0", Offset = "0x1C112E0", VA = "0x7BBC4112E0")]
		public UIHudGameModeIntroBasicView()
		{
		}

		// Token: 0x0400D6B2 RID: 54962
		[Token(Token = "0x400D6B2")]
		[FieldOffset(Offset = "0x20")]
		public GameObject contentcontainer;

		// Token: 0x0400D6B3 RID: 54963
		[Token(Token = "0x400D6B3")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ModeIcon;

		// Token: 0x0400D6B4 RID: 54964
		[Token(Token = "0x400D6B4")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ModeTitleLable;

		// Token: 0x0400D6B5 RID: 54965
		[Token(Token = "0x400D6B5")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ModeDescLabel;
	}
}
