using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002124 RID: 8484
	[Token(Token = "0x2002124")]
	public class UIBriefProfileInfoView : UIBaseView
	{
		// Token: 0x0600BD58 RID: 48472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD58")]
		[Address(RVA = "0x1C1C398", Offset = "0x1C1C398", VA = "0x7BBC41C398", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD59 RID: 48473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD59")]
		[Address(RVA = "0x1C1C5B0", Offset = "0x1C1C5B0", VA = "0x7BBC41C5B0")]
		public UIBriefProfileInfoView()
		{
		}

		// Token: 0x0400C2F3 RID: 49907
		[Token(Token = "0x400C2F3")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIBriefProfileInfo;

		// Token: 0x0400C2F4 RID: 49908
		[Token(Token = "0x400C2F4")]
		[FieldOffset(Offset = "0x28")]
		public UISprite bg;

		// Token: 0x0400C2F5 RID: 49909
		[Token(Token = "0x400C2F5")]
		[FieldOffset(Offset = "0x30")]
		public GameObject fakebg;

		// Token: 0x0400C2F6 RID: 49910
		[Token(Token = "0x400C2F6")]
		[FieldOffset(Offset = "0x38")]
		public UILabel nickname;

		// Token: 0x0400C2F7 RID: 49911
		[Token(Token = "0x400C2F7")]
		[FieldOffset(Offset = "0x40")]
		public UISprite BtnPinIcon;

		// Token: 0x0400C2F8 RID: 49912
		[Token(Token = "0x400C2F8")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnPin;

		// Token: 0x0400C2F9 RID: 49913
		[Token(Token = "0x400C2F9")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Icon_Celebrity;
	}
}
