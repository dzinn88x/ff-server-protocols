using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022BD RID: 8893
	[Token(Token = "0x20022BD")]
	public class UIHudDriftBottleAddFriendView : UIBaseView
	{
		// Token: 0x0600C08A RID: 49290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C08A")]
		[Address(RVA = "0x1C0014C", Offset = "0x1C0014C", VA = "0x7BBC40014C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C08B RID: 49291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C08B")]
		[Address(RVA = "0x1C002B0", Offset = "0x1C002B0", VA = "0x7BBC4002B0")]
		public UIHudDriftBottleAddFriendView()
		{
		}

		// Token: 0x0400D63C RID: 54844
		[Token(Token = "0x400D63C")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Message;

		// Token: 0x0400D63D RID: 54845
		[Token(Token = "0x400D63D")]
		[FieldOffset(Offset = "0x28")]
		public UIButton OKBtn;

		// Token: 0x0400D63E RID: 54846
		[Token(Token = "0x400D63E")]
		[FieldOffset(Offset = "0x30")]
		public UIButton CloseBtn;

		// Token: 0x0400D63F RID: 54847
		[Token(Token = "0x400D63F")]
		[FieldOffset(Offset = "0x38")]
		public UILabel CloseTime;
	}
}
