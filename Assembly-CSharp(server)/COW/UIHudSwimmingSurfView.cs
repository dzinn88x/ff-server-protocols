using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002374 RID: 9076
	[Token(Token = "0x2002374")]
	internal class UIHudSwimmingSurfView : UIBaseView
	{
		// Token: 0x0600C1F8 RID: 49656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1F8")]
		[Address(RVA = "0x1676380", Offset = "0x1676380", VA = "0x7BBBE76380", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1F9 RID: 49657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1F9")]
		[Address(RVA = "0x16764F4", Offset = "0x16764F4", VA = "0x7BBBE764F4")]
		public UIHudSwimmingSurfView()
		{
		}

		// Token: 0x0400DBFF RID: 56319
		[Token(Token = "0x400DBFF")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIHudSwimmingSurf;

		// Token: 0x0400DC00 RID: 56320
		[Token(Token = "0x400DC00")]
		[FieldOffset(Offset = "0x28")]
		public UIButton btnSwimmingSurf;

		// Token: 0x0400DC01 RID: 56321
		[Token(Token = "0x400DC01")]
		[FieldOffset(Offset = "0x30")]
		public UISprite normal;

		// Token: 0x0400DC02 RID: 56322
		[Token(Token = "0x400DC02")]
		[FieldOffset(Offset = "0x38")]
		public UISprite icon;
	}
}
