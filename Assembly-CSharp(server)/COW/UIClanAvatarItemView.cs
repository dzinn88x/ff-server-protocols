using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002161 RID: 8545
	[Token(Token = "0x2002161")]
	internal class UIClanAvatarItemView : UIBaseView
	{
		// Token: 0x0600BDD2 RID: 48594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD2")]
		[Address(RVA = "0x1CEB2B0", Offset = "0x1CEB2B0", VA = "0x7BBC4EB2B0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDD3 RID: 48595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD3")]
		[Address(RVA = "0x1CEB3A0", Offset = "0x1CEB3A0", VA = "0x7BBC4EB3A0")]
		public UIClanAvatarItemView()
		{
		}

		// Token: 0x0400C597 RID: 50583
		[Token(Token = "0x400C597")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Item;

		// Token: 0x0400C598 RID: 50584
		[Token(Token = "0x400C598")]
		[FieldOffset(Offset = "0x28")]
		public UISprite HeadSprite;
	}
}
