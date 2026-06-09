using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200256D RID: 9581
	[Token(Token = "0x200256D")]
	public class UISuperFighterMissionWndView : UIBaseView
	{
		// Token: 0x0600C5EA RID: 50666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5EA")]
		[Address(RVA = "0x1F4DF38", Offset = "0x1F4DF38", VA = "0x7BBC74DF38", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5EB RID: 50667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5EB")]
		[Address(RVA = "0x1F4E028", Offset = "0x1F4E028", VA = "0x7BBC74E028")]
		public UISuperFighterMissionWndView()
		{
		}

		// Token: 0x0400F609 RID: 62985
		[Token(Token = "0x400F609")]
		[FieldOffset(Offset = "0x20")]
		public UILabel UpdateTimeDesc;

		// Token: 0x0400F60A RID: 62986
		[Token(Token = "0x400F60A")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid Grid;
	}
}
