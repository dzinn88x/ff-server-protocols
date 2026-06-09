using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200210F RID: 8463
	[Token(Token = "0x200210F")]
	public class UIAvatarSuitRecommendItemView : UIBaseView
	{
		// Token: 0x0600BD2F RID: 48431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD2F")]
		[Address(RVA = "0x1E536FC", Offset = "0x1E536FC", VA = "0x7BBC6536FC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD30 RID: 48432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD30")]
		[Address(RVA = "0x1E53898", Offset = "0x1E53898", VA = "0x7BBC653898")]
		public UIAvatarSuitRecommendItemView()
		{
		}

		// Token: 0x0400C1AC RID: 49580
		[Token(Token = "0x400C1AC")]
		[FieldOffset(Offset = "0x20")]
		public UIButton RecommendBuyBtn;

		// Token: 0x0400C1AD RID: 49581
		[Token(Token = "0x400C1AD")]
		[FieldOffset(Offset = "0x28")]
		public UILabel SetName;

		// Token: 0x0400C1AE RID: 49582
		[Token(Token = "0x400C1AE")]
		[FieldOffset(Offset = "0x30")]
		public UIButton CloseBtn;

		// Token: 0x0400C1AF RID: 49583
		[Token(Token = "0x400C1AF")]
		[FieldOffset(Offset = "0x38")]
		public UILabel FakeSetKey;

		// Token: 0x0400C1B0 RID: 49584
		[Token(Token = "0x400C1B0")]
		[FieldOffset(Offset = "0x40")]
		public UISprite SuitSprite;
	}
}
