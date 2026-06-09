using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024D2 RID: 9426
	[Token(Token = "0x20024D2")]
	public class UIRelationshipInviteSucessWndView : UIBaseView
	{
		// Token: 0x0600C4B4 RID: 50356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B4")]
		[Address(RVA = "0x1E1E5B8", Offset = "0x1E1E5B8", VA = "0x7BBC61E5B8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4B5 RID: 50357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B5")]
		[Address(RVA = "0x1E1E754", Offset = "0x1E1E754", VA = "0x7BBC61E754")]
		public UIRelationshipInviteSucessWndView()
		{
		}

		// Token: 0x0400EFC3 RID: 61379
		[Token(Token = "0x400EFC3")]
		[FieldOffset(Offset = "0x20")]
		public UISprite MyHeadPic;

		// Token: 0x0400EFC4 RID: 61380
		[Token(Token = "0x400EFC4")]
		[FieldOffset(Offset = "0x28")]
		public UILabel MyNickName;

		// Token: 0x0400EFC5 RID: 61381
		[Token(Token = "0x400EFC5")]
		[FieldOffset(Offset = "0x30")]
		public UISprite FriendHeadPic;

		// Token: 0x0400EFC6 RID: 61382
		[Token(Token = "0x400EFC6")]
		[FieldOffset(Offset = "0x38")]
		public UILabel FriendNickName;

		// Token: 0x0400EFC7 RID: 61383
		[Token(Token = "0x400EFC7")]
		[FieldOffset(Offset = "0x40")]
		public UIButton ClickMask;
	}
}
