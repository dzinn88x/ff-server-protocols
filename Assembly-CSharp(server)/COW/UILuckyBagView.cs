using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200240C RID: 9228
	[Token(Token = "0x200240C")]
	public class UILuckyBagView : UIBaseView
	{
		// Token: 0x0600C328 RID: 49960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C328")]
		[Address(RVA = "0x19EBB1C", Offset = "0x19EBB1C", VA = "0x7BBC1EBB1C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C329 RID: 49961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C329")]
		[Address(RVA = "0x19EBCC0", Offset = "0x19EBCC0", VA = "0x7BBC1EBCC0")]
		public UILuckyBagView()
		{
		}

		// Token: 0x0400E3B8 RID: 58296
		[Token(Token = "0x400E3B8")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView ScrollView;

		// Token: 0x0400E3B9 RID: 58297
		[Token(Token = "0x400E3B9")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList Grid;

		// Token: 0x0400E3BA RID: 58298
		[Token(Token = "0x400E3BA")]
		[FieldOffset(Offset = "0x30")]
		public GameObject NoLuckyBagTips;

		// Token: 0x0400E3BB RID: 58299
		[Token(Token = "0x400E3BB")]
		[FieldOffset(Offset = "0x38")]
		public UIButton RefreshBtn;

		// Token: 0x0400E3BC RID: 58300
		[Token(Token = "0x400E3BC")]
		[FieldOffset(Offset = "0x40")]
		public UILabel RefreshLabel;
	}
}
