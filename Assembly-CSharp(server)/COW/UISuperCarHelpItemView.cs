using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200255C RID: 9564
	[Token(Token = "0x200255C")]
	public class UISuperCarHelpItemView : UIBaseView
	{
		// Token: 0x0600C5C8 RID: 50632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C8")]
		[Address(RVA = "0x2143AC8", Offset = "0x2143AC8", VA = "0x7BBC943AC8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5C9 RID: 50633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C9")]
		[Address(RVA = "0x2143C64", Offset = "0x2143C64", VA = "0x7BBC943C64")]
		public UISuperCarHelpItemView()
		{
		}

		// Token: 0x0400F529 RID: 62761
		[Token(Token = "0x400F529")]
		[FieldOffset(Offset = "0x20")]
		public Transform ProfileContainer;

		// Token: 0x0400F52A RID: 62762
		[Token(Token = "0x400F52A")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnInvite;

		// Token: 0x0400F52B RID: 62763
		[Token(Token = "0x400F52B")]
		[FieldOffset(Offset = "0x30")]
		public UISprite InviteBtnSprite;

		// Token: 0x0400F52C RID: 62764
		[Token(Token = "0x400F52C")]
		[FieldOffset(Offset = "0x38")]
		public UILabel InviteBtnLabel;

		// Token: 0x0400F52D RID: 62765
		[Token(Token = "0x400F52D")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnInvited;
	}
}
