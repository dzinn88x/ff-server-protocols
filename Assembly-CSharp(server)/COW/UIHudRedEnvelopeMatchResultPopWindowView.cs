using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200234E RID: 9038
	[Token(Token = "0x200234E")]
	internal class UIHudRedEnvelopeMatchResultPopWindowView : UIBaseView
	{
		// Token: 0x0600C1AC RID: 49580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1AC")]
		[Address(RVA = "0x17EF228", Offset = "0x17EF228", VA = "0x7BBBFEF228", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1AD RID: 49581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1AD")]
		[Address(RVA = "0x17EF39C", Offset = "0x17EF39C", VA = "0x7BBBFEF39C")]
		public UIHudRedEnvelopeMatchResultPopWindowView()
		{
		}

		// Token: 0x0400DAE7 RID: 56039
		[Token(Token = "0x400DAE7")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid Grid;

		// Token: 0x0400DAE8 RID: 56040
		[Token(Token = "0x400DAE8")]
		[FieldOffset(Offset = "0x28")]
		public RedEnvelopeAwardItemView RewardItem;

		// Token: 0x0400DAE9 RID: 56041
		[Token(Token = "0x400DAE9")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Bg;

		// Token: 0x0400DAEA RID: 56042
		[Token(Token = "0x400DAEA")]
		[FieldOffset(Offset = "0x38")]
		public UIButton CloseBtn;
	}
}
