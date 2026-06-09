using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024E3 RID: 9443
	[Token(Token = "0x20024E3")]
	public class UIRoomModeSelectPopupWindowView : UIBaseView
	{
		// Token: 0x0600C4D6 RID: 50390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4D6")]
		[Address(RVA = "0x1A1CE38", Offset = "0x1A1CE38", VA = "0x7BBC21CE38", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4D7 RID: 50391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4D7")]
		[Address(RVA = "0x1A1D0A4", Offset = "0x1A1D0A4", VA = "0x7BBC21D0A4")]
		public UIRoomModeSelectPopupWindowView()
		{
		}

		// Token: 0x0400F031 RID: 61489
		[Token(Token = "0x400F031")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ApplyBtn;

		// Token: 0x0400F032 RID: 61490
		[Token(Token = "0x400F032")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ApplyLabel;

		// Token: 0x0400F033 RID: 61491
		[Token(Token = "0x400F033")]
		[FieldOffset(Offset = "0x30")]
		public UIButton PasswordBtn;

		// Token: 0x0400F034 RID: 61492
		[Token(Token = "0x400F034")]
		[FieldOffset(Offset = "0x38")]
		public UILabel PasswordLabel;

		// Token: 0x0400F035 RID: 61493
		[Token(Token = "0x400F035")]
		[FieldOffset(Offset = "0x40")]
		public UIButton SimulatorBtn;

		// Token: 0x0400F036 RID: 61494
		[Token(Token = "0x400F036")]
		[FieldOffset(Offset = "0x48")]
		public UILabel SimulatorLabel;

		// Token: 0x0400F037 RID: 61495
		[Token(Token = "0x400F037")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid GroupModeGrid;

		// Token: 0x0400F038 RID: 61496
		[Token(Token = "0x400F038")]
		[FieldOffset(Offset = "0x58")]
		public UIEasyList ItemList;
	}
}
