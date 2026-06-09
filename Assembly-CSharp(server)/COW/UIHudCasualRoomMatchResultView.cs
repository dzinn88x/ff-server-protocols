using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200228F RID: 8847
	[Token(Token = "0x200228F")]
	internal class UIHudCasualRoomMatchResultView : UIBaseView
	{
		// Token: 0x0600C02F RID: 49199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C02F")]
		[Address(RVA = "0x19D1004", Offset = "0x19D1004", VA = "0x7BBC1D1004", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C030 RID: 49200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C030")]
		[Address(RVA = "0x19D11A8", Offset = "0x19D11A8", VA = "0x7BBC1D11A8")]
		public UIHudCasualRoomMatchResultView()
		{
		}

		// Token: 0x0400D460 RID: 54368
		[Token(Token = "0x400D460")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BackBtn;

		// Token: 0x0400D461 RID: 54369
		[Token(Token = "0x400D461")]
		[FieldOffset(Offset = "0x28")]
		public UIButton PrevBtn;

		// Token: 0x0400D462 RID: 54370
		[Token(Token = "0x400D462")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid LeftGrid;

		// Token: 0x0400D463 RID: 54371
		[Token(Token = "0x400D463")]
		[FieldOffset(Offset = "0x38")]
		public UIScrollView RightScrollView;

		// Token: 0x0400D464 RID: 54372
		[Token(Token = "0x400D464")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid RightGrid;
	}
}
