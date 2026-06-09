using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002162 RID: 8546
	[Token(Token = "0x2002162")]
	public class UIClanAvatarView : UIBaseView
	{
		// Token: 0x0600BDD4 RID: 48596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD4")]
		[Address(RVA = "0x1CEB3A8", Offset = "0x1CEB3A8", VA = "0x7BBC4EB3A8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDD5 RID: 48597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD5")]
		[Address(RVA = "0x1CEB498", Offset = "0x1CEB498", VA = "0x7BBC4EB498")]
		public UIClanAvatarView()
		{
		}

		// Token: 0x0400C599 RID: 50585
		[Token(Token = "0x400C599")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Mask;

		// Token: 0x0400C59A RID: 50586
		[Token(Token = "0x400C59A")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList EasyList;
	}
}
