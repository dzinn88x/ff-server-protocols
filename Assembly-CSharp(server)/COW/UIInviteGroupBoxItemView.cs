using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023CE RID: 9166
	[Token(Token = "0x20023CE")]
	public class UIInviteGroupBoxItemView : UIBaseView
	{
		// Token: 0x0600C2AC RID: 49836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2AC")]
		[Address(RVA = "0x1928C18", Offset = "0x1928C18", VA = "0x7BBC128C18", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2AD RID: 49837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2AD")]
		[Address(RVA = "0x1928D08", Offset = "0x1928D08", VA = "0x7BBC128D08")]
		public UIInviteGroupBoxItemView()
		{
		}

		// Token: 0x0400DF2C RID: 57132
		[Token(Token = "0x400DF2C")]
		[FieldOffset(Offset = "0x20")]
		public Transform ProfileObj;

		// Token: 0x0400DF2D RID: 57133
		[Token(Token = "0x400DF2D")]
		[FieldOffset(Offset = "0x28")]
		public UIButton AddBtn;
	}
}
