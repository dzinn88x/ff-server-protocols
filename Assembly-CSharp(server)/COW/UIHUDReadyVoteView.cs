using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002344 RID: 9028
	[Token(Token = "0x2002344")]
	public class UIHUDReadyVoteView : UIBaseView
	{
		// Token: 0x0600C198 RID: 49560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C198")]
		[Address(RVA = "0x16BE018", Offset = "0x16BE018", VA = "0x7BBBEBE018", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C199 RID: 49561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C199")]
		[Address(RVA = "0x16BE18C", Offset = "0x16BE18C", VA = "0x7BBBEBE18C")]
		public UIHUDReadyVoteView()
		{
		}

		// Token: 0x0400DAC3 RID: 56003
		[Token(Token = "0x400DAC3")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ShowRoot;

		// Token: 0x0400DAC4 RID: 56004
		[Token(Token = "0x400DAC4")]
		[FieldOffset(Offset = "0x28")]
		public UIButton VoteBtn;

		// Token: 0x0400DAC5 RID: 56005
		[Token(Token = "0x400DAC5")]
		[FieldOffset(Offset = "0x30")]
		public UISprite icon;

		// Token: 0x0400DAC6 RID: 56006
		[Token(Token = "0x400DAC6")]
		[FieldOffset(Offset = "0x38")]
		public UISprite bg;
	}
}
