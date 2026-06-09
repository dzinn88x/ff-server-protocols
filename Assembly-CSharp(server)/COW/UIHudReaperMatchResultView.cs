using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200234A RID: 9034
	[Token(Token = "0x200234A")]
	public class UIHudReaperMatchResultView : UIBaseView
	{
		// Token: 0x0600C1A4 RID: 49572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1A4")]
		[Address(RVA = "0x17EBAD4", Offset = "0x17EBAD4", VA = "0x7BBBFEBAD4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1A5 RID: 49573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1A5")]
		[Address(RVA = "0x17EBC38", Offset = "0x17EBC38", VA = "0x7BBBFEBC38")]
		public UIHudReaperMatchResultView()
		{
		}

		// Token: 0x0400DAD9 RID: 56025
		[Token(Token = "0x400DAD9")]
		[FieldOffset(Offset = "0x20")]
		public GameObject CallSignContainer;

		// Token: 0x0400DADA RID: 56026
		[Token(Token = "0x400DADA")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnShare;

		// Token: 0x0400DADB RID: 56027
		[Token(Token = "0x400DADB")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnNext;

		// Token: 0x0400DADC RID: 56028
		[Token(Token = "0x400DADC")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid ListGrid;
	}
}
